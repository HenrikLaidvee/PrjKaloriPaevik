Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


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

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
        Dim query As String = "SELECT Motivational_quote FROM Motivate;"

        Dim quotesDataTable As New DataTable()

        Using connection As New OleDbConnection(connectionString)
            Using adapter As New OleDbDataAdapter(query, connection)
                connection.Open()
                adapter.Fill(quotesDataTable)
            End Using
        End Using

        ' Display a random motivational quote
        If quotesDataTable.Rows.Count > 0 Then
            Dim random As New Random()
            Dim randomIndex As Integer = random.Next(0, quotesDataTable.Rows.Count)
            txtMotivate.Text = quotesDataTable.Rows(randomIndex)("Motivational_quote").ToString()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogFood.Enabled = True
        btnProfile.Enabled = False
        btnKaal.Enabled = False
        txtMotivate.ReadOnly = True


    End Sub

    Private Sub btnKaal_Click(sender As Object, e As EventArgs) Handles btnKaal.Click
        StatistikaForm.Show()
    End Sub


    Private Sub txtCurrentWeight_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentWeight.TextChanged
        ' Get the weight value from the textbox
        Dim weightValue As Double
        Dim ID As Integer
        If Double.TryParse(txtCurrentWeight.Text, weightValue) Then
            ' Call the method to insert data into the WeightData table
            'InsertDataIntoWeightData(weightValue, ID)
        End If

    End Sub

    Private Sub btnDownload_Click(sender As Object, e As EventArgs) Handles btnDownload.Click
        FilenameForm.ShowDialog()
    End Sub

End Class