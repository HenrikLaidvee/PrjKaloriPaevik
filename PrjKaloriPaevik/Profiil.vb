Imports System.Data.OleDb

Public Class Profiil

    'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\marku\Downloads\ToiduAndmebaas\ToiduAndmebaas.accdb;"

    Private Sub Profiil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtEmail.Text = loggedInEmail
        txtUsername.Text = loggedInFirstName
        txtLastName.Text = loggedInLastName
        txtPassword.Text = loggedInPassword
        txtWeight.Text = loggedInWeight.ToString()
        txtHeight.Text = loggedInHeight.ToString()
        txtDailyCalories.Text = loggedInCalories.ToString()
        txtGoalWeight.Text = loggedInGoal.ToString()
        txtDailyCalories.Text = loggedInCalories.ToString()
        txtSugarLimit.Text = loggedInSugar.ToString()
        'txtCaloriesLeft.Text = (loggedInCalories - KasutajaMoodul.food_amount)

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

        If Kosher = 1 Then
            chbKosher.Checked = True
        Else
            chbKosher.Checked = False
        End If
        If Unhealthy = 1 Then
            chbUnhealthy.Checked = True
        Else
            chbUnhealthy.Checked = False
        End If

        cmbDay.SelectedItem = Convert.ToInt32(loggedInDay)
        cmbMonth.SelectedItem = loggedInMonth
        cmbYear.SelectedItem = Convert.ToInt32(loggedInYear)
        cbAlcohol.SelectedItem = Convert.ToInt32(loggedAlcohol)
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

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        Dim maxChars As Integer = 50

        Dim remainingChars As Integer = maxChars - txtEmail.Text.Length


        lblEmailMaxWords.Text = $"{remainingChars}"

        If remainingChars <= 0 Then

            Dim newText As String = txtEmail.Text.Substring(0, maxChars)
            txtEmail.Text = newText
            txtEmail.SelectionStart = maxChars

            lblLimitReached.Visible = True
        Else
            lblLimitReached.Visible = False
        End If
    End Sub

    Private Function Clear()
        cmbDay.SelectedIndex = -1
        cmbMonth.SelectedIndex = -1
        cmbYear.SelectedIndex = -1
        cbAlcohol.SelectedIndex = -1
        txtWeight.Text = ""
        txtHeight.Text = ""
        txtGoalWeight.Text = ""
        txtDailyCalories.Text = ""
        txtPassword.Text = ""
        txtUsername.Text = ""
        txtEmail.Text = ""
        txtSugarLimit.Text = ""
    End Function

    ' Funktsioon, mis muudab kuu nimeks vastava kuunumbri
    Private Function MonthToInt(ByVal monthName As String) As Integer
        Return Date.ParseExact(monthName, "MMMM", System.Globalization.CultureInfo.CurrentCulture).Month
    End Function

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click

        If cmbDay.SelectedIndex = -1 OrElse cmbMonth.SelectedIndex = -1 OrElse cmbYear.SelectedIndex = -1 _
            OrElse String.IsNullOrEmpty(txtWeight.Text) OrElse String.IsNullOrEmpty(txtPassword.Text) _
            OrElse String.IsNullOrEmpty(txtEmail.Text) _
            OrElse String.IsNullOrEmpty(txtUsername.Text) OrElse String.IsNullOrEmpty(txtLastName.Text) _
            OrElse String.IsNullOrEmpty(txtHeight.Text) OrElse String.IsNullOrEmpty(txtGoalWeight.Text) _
            OrElse String.IsNullOrEmpty(txtDailyCalories.Text) OrElse String.IsNullOrEmpty(txtSugarLimit.Text) Then

            MessageBox.Show("Palun täitke kõik väljad!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim weight As Double = Double.Parse(txtWeight.Text)

            Dim height As Double = Double.Parse(txtHeight.Text)

            Dim goalWeight As Double = Double.Parse(txtGoalWeight.Text)

            Dim dailyCalories As Double = Double.Parse(txtDailyCalories.Text)

            Dim SugarLimit As Double = Double.Parse(txtSugarLimit.Text)

            Dim kosherChecked As Double

            Dim unhealthyChecked As Double

            If chbKosher.Checked Then
                kosherChecked = 1
            Else
                kosherChecked = 0
            End If

            If chbUnhealthy.Checked Then
                unhealthyChecked = 1
            Else
                kosherChecked = 0
            End If

            Using connection As New OleDbConnection(connectionString)
                connection.Open()



                Dim query As String = "UPDATE Kasutaja SET Email = @Email, Eesnimi = @Eesnimi, Perenimi = @Perenimi, Pikkus = @Pikkus, 
                               Paev = @Paev, Kuu = @Kuu, Aasta = @Aasta, Parool = @Parool, Kaal = @Kaal, 
                               Eesmark = @Eesmark, Kalorid = @Kalorid, Alkohol = @Alkohol, Suhkur = @Suhkur, Kosher = @Kosher, Ebatervislik = @Ebatervislik WHERE ID = @ID"
                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
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
                    command.Parameters.AddWithValue("@Suhkur", SugarLimit)
                    command.Parameters.AddWithValue("@Kosher", kosherChecked)
                    command.Parameters.AddWithValue("@Ebatervislik", unhealthyChecked)
                    command.Parameters.AddWithValue("@ID", loggedInID)


                    command.ExecuteNonQuery()
                    loggedInEmail = txtEmail.Text
                    loggedInFirstName = txtUsername.Text
                    loggedInLastName = txtLastName.Text
                    loggedInHeight = height
                    loggedInDay = cmbDay.SelectedItem
                    loggedInMonth = cmbMonth.SelectedItem
                    loggedInYear = cmbYear.SelectedItem
                    loggedInPassword = txtPassword.Text
                    loggedInWeight = weight
                    loggedInGoal = goalWeight
                    loggedInCalories = dailyCalories
                    loggedAlcohol = cbAlcohol.SelectedItem
                    loggedInSugar = SugarLimit
                    Kosher = kosherChecked
                    Unhealthy = unhealthyChecked

                End Using
                MainForm.txtCurrentWeight.Text = loggedInWeight.ToString()
                MainForm.txtGoalWeight.Text = loggedInGoal.ToString()
                MainForm.txtNeedToLose.Text = (loggedInWeight - loggedInGoal).ToString()
                MainForm.txtCalorieLimit.Text = loggedInCalories.ToString()
                ' Peaks muutma TEST
                'MainForm.txtCaloriesLeft.Text = (loggedInCalories - KasutajaMoodul.food_amount).ToString()
                'MainForm.txtCaloriesLeft.Text = (loggedInCalories - KasutajaMoodul.food_amount)

                MainForm.Refresh()
                LogInAken.Refresh()
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
End Class