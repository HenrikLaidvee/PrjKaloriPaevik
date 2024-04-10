Imports System.Windows.Forms.VisualStyles
Imports CExportToCSV
Public Class FilenameForm


    Private Sub pathBtn_Click(sender As Object, e As EventArgs) Handles pathBtn.Click
        FolderBrowserDialog1.ShowDialog()
        Dim filepath As String = FolderBrowserDialog1.SelectedPath
        Dim filename As String = filepathTxt.Text + ".csv"

        Dim fild1 As String = "ID"
        Dim fild2 As String = "Category"
        Dim fild3 As String = "Nutrient ID"
        Dim fild4 As String = "Amount"
        Dim fild5 As String = "Description"
        Dim delimiter As String = ","

        Dim exporter As IExportToCSV
        exporter = New ExportToCSV.CExportToCSV

        exporter.WriteToFile(filepath, filename, fild1, fild2, fild3, fild4, fild5, delimiter)
    End Sub
End Class