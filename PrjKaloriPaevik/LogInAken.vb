Imports System.Data.OleDb

Public Class LogInAken
    Private Sub LogInAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLimitReached.Visible = False
    End Sub
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If String.IsNullOrEmpty(txtPassword.Text) OrElse String.IsNullOrEmpty(txtUsername.Text) _
            OrElse String.IsNullOrEmpty(txtLastName.Text) Then

            MessageBox.Show("Palun täitke kõik väljad!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
            Dim query As String = "SELECT * FROM Kasutaja WHERE Eesnimi = @Eesnimi AND Perenimi = @Perenimi AND  Parool = @Parool"

            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Eesnimi", txtUsername.Text)
                    command.Parameters.AddWithValue("@Perenimi", txtLastName.Text)
                    command.Parameters.AddWithValue("@Parool", txtPassword.Text)

                    Using reader As OleDbDataReader = command.ExecuteReader()
                        If reader.HasRows Then
                            MessageBox.Show("Sisselogimine õnnestus!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            While reader.Read()
                                loggedInID = reader("ID")
                                loggedInFirstName = reader("Eesnimi").ToString()
                                loggedInLastName = reader("Perenimi").ToString()
                                loggedInHeight = reader("Pikkus")
                                loggedInDay = reader("Paev")
                                loggedInMonth = reader("Kuu").ToString()
                                loggedInYear = reader("Aasta")
                                loggedInPassword = reader("Parool").ToString()
                                loggedInWeight = reader("Kaal")
                                loggedInGoal = reader("Eesmark")
                                loggedInCalories = reader("Kalorid")
                                loggedInSugar = Double.Parse(reader("suhkur"))
                            End While
                            Dim showMakro As PrjKaloriPaevikKalorid.ICalories
                            showMakro = New PrjKaloriPaevikKalorid.CCalories
                            loggedInRemainingCalories = loggedInCalories - showMakro.getCalories(loggedInID)
                            loggedInRemainingSugar = loggedInSugar - showMakro.getSugar(loggedInID)

                            SetLoginStatus(True)
                            MainForm.btnLogIn.Enabled = False
                            MainForm.btnCreateUser.Enabled = False
                            MainForm.btnProfile.Enabled = True
                            MainForm.btnLogFood.Enabled = True
                            MainForm.btnKaal.Enabled = True
                            MainForm.txtCurrentWeight.Text = loggedInWeight.ToString()
                            MainForm.txtGoalWeight.Text = loggedInGoal.ToString()
                            MainForm.txtNeedToLose.Text = (loggedInWeight - loggedInGoal).ToString()
                            MainForm.txtCalorieLimit.Text = loggedInCalories.ToString()

                            'KasutajaMoodul.latestUserID = GetLatestUserID()

                            Me.Close()

                            MainForm.Refresh()

                        Else
                            MessageBox.Show("Vale kasutajanimi või parool!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Sisselogimisel tekkis viga: " & ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
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

End Class