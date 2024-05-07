Imports System.Data.OleDb

Public Class RegAken

    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"

    Private Sub RegAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblLimitReached.Visible = False

        For i As Integer = 1 To 31
            cmbDay.Items.Add(i)
        Next

        ' Lisame kuud
        For i As Integer = 1 To 12
            cmbMonth.Items.Add(MonthName(i))
        Next

        ' Lisame aastad 1900-st 2024-ni
        For i As Integer = 2024 To 1900 Step -1
            cmbYear.Items.Add(i)
        Next

        For i As Integer = 0 To 1000 Step 100
            cbAlcohol.Items.Add(i)
        Next

    End Sub

    Private Sub btnSeePassword_Click(sender As Object, e As EventArgs) Handles btnSeePassword.Click
        If txtPassword.PasswordChar = "" Or txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnSeePassword.Text = "Peida parool"
        Else
            txtPassword.PasswordChar = "*"
            btnSeePassword.Text = "Vaata parooli"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If cmbDay.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbYear.SelectedIndex = -1 _
            OrElse String.IsNullOrEmpty(txtWeight.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) _
            OrElse String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtLastName.Text) _
            OrElse String.IsNullOrEmpty(txtHeight.Text) OrElse String.IsNullOrEmpty(txtGoalWeight.Text) _
            OrElse String.IsNullOrEmpty(txtDailyCalories.Text) Then

            MessageBox.Show("Palun täitke kõik väljad!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim weight As Double = Double.Parse(txtWeight.Text)

            Dim height As Double = Double.Parse(txtHeight.Text)

            Dim goalWeight As Double = Double.Parse(txtGoalWeight.Text)

            Dim dailyCalories As Double = Double.Parse(txtDailyCalories.Text)

            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO Kasutaja (Eesnimi, Perenimi, Pikkus, Paev, Kuu, Aasta, Parool, Kaal, Eesmark, Kalorid, Alkohol) 
                                        VALUES (@Eesnimi, @Perenimi, @Pikkus, @Paev, @Kuu, @Aasta, @Parool, @Kaal, @Eesmark, @Kalorid, @Alkohol)"
                Using command As New OleDbCommand(query, connection)

                    command.Parameters.AddWithValue("@Eesnimi", txtUsername.Text)
                    command.Parameters.AddWithValue("@Perenimi", txtLastName.Text)
                    command.Parameters.AddWithValue("@Pikkus", height)
                    command.Parameters.AddWithValue("@Paev", cmbDay.SelectedItem)
                    command.Parameters.AddWithValue("@Kuu", cmbMonth.SelectedItem)
                    command.Parameters.AddWithValue("@Aasta", cmbYear.SelectedItem)
                    command.Parameters.AddWithValue("@Parool", txtPassword.Text)
                    command.Parameters.AddWithValue("@Kaal", weight)
                    command.Parameters.AddWithValue("@Eesmark", goalWeight)
                    command.Parameters.AddWithValue("@Kalorid", dailyCalories)
                    command.Parameters.AddWithValue("@Alkohol", cbAlcohol.SelectedItem)

                    'command.Parameters.AddWithValue("@Age", age)

                    command.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Andmed salvestatud edukalt!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Clear()
            Me.Close()

        Catch ex As FormatException
            ' Kui sisestatud tekst ei ole number, siis error
            MessageBox.Show("Palun sisestage ainult numbrid kaalu, pikkuse, eemärgi ja kalorite väljale!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show("Andmete salvestamisel tekkis viga: " & ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

        Dim maxChars As Integer = 30

        Dim remainingChars As Integer = maxChars - txtUsername.Text.Length

        ' Uuendame Labeli teksti, et näidata järelejäänud tähemärkide arvu
        lblUsernameMaxWords.Text = $"{remainingChars}"

        If remainingChars <= 0 Then
            ' Kui järelejäänud tähemärkide arv on null või väiksem, siis takistame tähemärkide sisestamist
            Dim newText As String = txtUsername.Text.Substring(0, maxChars)
            txtUsername.Text = newText
            txtUsername.SelectionStart = maxChars ' liigutame kursori teksti lõppu

            lblLimitReached.Visible = True
        Else
            lblLimitReached.Visible = False ' peidame teate, kui piirangut pole veel täis
        End If

    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged
        Dim maxChars As Integer = 30

        Dim remainingChars As Integer = maxChars - txtLastName.Text.Length


        lblLastNameMaxWords.Text = $"{remainingChars}"

        If remainingChars <= 0 Then

            Dim newText As String = txtLastName.Text.Substring(0, maxChars)
            txtLastName.Text = newText
            txtLastName.SelectionStart = maxChars

            lblLimitReached.Visible = True
        Else
            lblLimitReached.Visible = False
        End If
    End Sub

    Private Function Clear()
        cmbDay.SelectedIndex = -1
        cmbMonth.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        txtWeight.Text = ""
        txtHeight.Text = ""
        txtGoalWeight.Text = ""
        txtDailyCalories.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
    End Function

    Private Sub btnCalculateAge_Click(sender As Object, e As EventArgs)

        If cmbDay.SelectedItem Is Nothing OrElse cmbMonth.SelectedItem Is Nothing OrElse cmbYear.SelectedItem Is Nothing Then
            MessageBox.Show("Palun valige kõik kuupäevaväljad!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim selectedDay As Integer = CInt(cmbDay.SelectedItem)
            Dim selectedMonth As Integer = MonthToInt(cmbMonth.SelectedItem.ToString())
            Dim selectedYear As Integer = CInt(cmbYear.SelectedItem)

            ' Leiame täpse vanuse, kasutades DateTime klassi
            Dim birthDate As New DateTime(selectedYear, selectedMonth, selectedDay)
            Dim age As Integer = CalculateAge(birthDate, Today)

            ' Kuvame vanuse MessageBox-is
            MessageBox.Show($"Teie vanus on {age} aastat.")
        Catch ex As Exception
            ' Kui midagi läheb valesti, kuvatakse veateade
            MessageBox.Show("Sisestatud kuupäeva arvutamisega tekkis probleem." & Environment.NewLine & Environment.NewLine &
                            ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Funktsioon vanuse arvutamiseks kahe kuupäeva vahel
    Private Function CalculateAge(ByVal birthDate As DateTime, ByVal targetDate As DateTime) As Integer
        Dim age As Integer = targetDate.Year - birthDate.Year
        If targetDate < birthDate.AddYears(age) Then
            age -= 1
        End If
        Return age
    End Function

    ' Funktsioon, mis muudab kuu nimeks vastava kuunumbri
    Private Function MonthToInt(ByVal monthName As String) As Integer
        Return Date.ParseExact(monthName, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub chbKosher_CheckedChanged(sender As Object, e As EventArgs) Handles chbKosher.CheckedChanged
        Kosher = chbKosher.Checked
    End Sub

    Private Sub chbUnhealthy_CheckedChanged(sender As Object, e As EventArgs) Handles chbUnhealthy.CheckedChanged
        Unhealthy = chbUnhealthy.Checked
    End Sub
End Class