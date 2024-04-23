﻿Imports System.Data.OleDb

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
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\FoodDatabase.accdb;"
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

                            SetLoginStatus(True, txtUsername.Text, txtLastName.Text)
                            Me.Close()

                            'Form1.Refresh()

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