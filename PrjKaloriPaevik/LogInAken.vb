Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class LogInAken
    Private Sub LogInAken_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblLimitReached.Visible = False
    End Sub


    Private Sub btnLogIn_Click_1(sender As Object, e As EventArgs) Handles btnLogIn.Click
        If String.IsNullOrEmpty(txtPassword.Text) OrElse String.IsNullOrEmpty(txtEmail.Text) Then

            MessageBox.Show("Palun täitke kõik väljad!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\marku\Downloads\ToiduAndmebaas\ToiduAndmebaas.accdb;"
            Dim query As String = "SELECT * FROM Kasutaja WHERE Email = @Email AND  Parool = @Parool"

            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Using command As New OleDbCommand(query, connection)
                    command.Parameters.AddWithValue("@Email", txtEmail.Text)
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
                                loggedAlcohol = reader("Alkohol")
                                loggedInSugar = reader("Suhkur")
                                Kosher = reader("Kosher")
                                Unhealthy = reader("Ebatervislik")
                                loggedInEmail = reader("Email")
                            End While
                            Dim showMakro As PrjKaloriPaevikKalorid.ICalories
                            showMakro = New PrjKaloriPaevikKalorid.CCalories
                            loggedInRemainingCalories = loggedInCalories - showMakro.getCalories(loggedInID)
                            loggedInRemainingSugar = loggedInSugar - showMakro.getSugar(loggedInID)
                            SetLoginStatus(True)
                            MainForm.txtSugarLimit.Text = loggedInSugar.ToString()
                            MainForm.txtCaloriesLeft.Text = loggedInRemainingCalories.ToString()
                            MainForm.txtSugarLeft.Text = loggedInRemainingSugar.ToString()
                            MainForm.btnLogIn.Enabled = False
                            MainForm.btnCreateUser.Enabled = False
                            MainForm.btnProfile.Enabled = True
                            MainForm.btnLogFood.Enabled = True
                            MainForm.btnKaal.Enabled = True
                            MainForm.btnLogOut.Enabled = True
                            MainForm.btnExport.Enabled = True
                            MainForm.btnSaveLive.Enabled = True
                            MainForm.txtCurrentWeight.Text = loggedInWeight.ToString()
                            MainForm.txtGoalWeight.Text = loggedInGoal.ToString()
                            MainForm.txtNeedToLose.Text = (loggedInWeight - loggedInGoal).ToString()
                            MainForm.txtCalorieLimit.Text = loggedInCalories.ToString()
                            MainForm.txtSugarLimit.Text = loggedInSugar.ToString()
                            MainForm.txtSugarLeft.Text = loggedInRemainingSugar.ToString()
                            MainForm.txtCaloriesLeft.Text = loggedInRemainingCalories.ToString()

                            MainForm.txtProtein.Text = showMakro.makroPercent(0, loggedInID).ToString
                            MainForm.txtFat.Text = showMakro.makroPercent(1, loggedInID).ToString
                            MainForm.txtCarbs.Text = showMakro.makroPercent(2, loggedInID).ToString
                            With MainForm.chartMakro
                                .Legends.Clear()
                                .Series.Clear()
                                .ChartAreas.Clear()
                            End With

                            Dim areas1 As ChartArea = MainForm.chartMakro.ChartAreas.Add("Areas1")

                            With areas1
                            End With

                            Dim series1 As Series = MainForm.chartMakro.Series.Add("Series1")

                            With series1
                                .ChartArea = areas1.Name
                                .ChartType = SeriesChartType.Pie
                                .Points.AddXY("Protein", showMakro.makroPercent(0, loggedInID))
                                .Points.AddXY("Fat", showMakro.makroPercent(1, loggedInID))
                                .Points.AddXY("Carbs", showMakro.makroPercent(2, loggedInID))
                            End With

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

    Private Sub btnSeePassword_Click_1(sender As Object, e As EventArgs) Handles btnSeePassword.Click
        If txtPassword.PasswordChar = "" Or txtPassword.PasswordChar = "*" Then
            txtPassword.PasswordChar = ""
            btnSeePassword.Text = "Peida parool"
        Else
            txtPassword.PasswordChar = "*"
            btnSeePassword.Text = "Vaata parooli"
        End If
    End Sub
End Class