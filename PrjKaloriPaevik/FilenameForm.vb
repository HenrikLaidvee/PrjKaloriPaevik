Imports System.Windows.Forms.VisualStyles
Imports ExportToCSV

'Tuleb mainformis välja kutsuda
Public Class FilenameForm
    Private numberOfLines As Integer = 0 ' Declare numberOfLines as a class-level variable

    Private Sub txtRidadeArv_TextChanged(sender As Object, e As EventArgs) Handles txtRidadeArv.TextChanged
        Integer.TryParse(txtRidadeArv.Text, numberOfLines)
    End Sub
    Private Sub pathBtn_Click(sender As Object, e As EventArgs) Handles pathBtn.Click
        FolderBrowserDialog1.ShowDialog()
        Dim filepath As String = FolderBrowserDialog1.SelectedPath
        Dim filename As String = filepathTxt.Text + ".csv"

        Dim exporter As IExportToCSV
        exporter = New ExportToCSV.CExportToCSV

        exporter.WriteToFile(filepath, filename, numberOfLines)
    End Sub

    Private Sub FilenameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class