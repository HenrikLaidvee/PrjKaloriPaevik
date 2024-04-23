Imports System.Data.OleDb
Public Class MainForm
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Profiil.Show()
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        RegAken.Show()
    End Sub

    Private Sub btnLogFood_Click(sender As Object, e As EventArgs) Handles btnLogFood.Click
        Form1.Show()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LogInAken.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogFood.Enabled = False
        btnProfile.Enabled = False
    End Sub
End Class