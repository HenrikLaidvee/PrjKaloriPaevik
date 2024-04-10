Imports System.IO
Imports System.Windows.Forms
Public Class CExportToCSV
    Implements IExportToCSV



    Public Sub IExportToCSV_WriteToFile(filepath As String, filename As String, field1 As String, field2 As String, field3 As String, field4 As String, field5 As String, delimiter As String) Implements IExportToCSV.WriteToFile
        Try
            Dim fileWriter As New System.IO.StreamWriter(filepath + "\" + filename, True)
            'MessageBox.Show(filepath + "\" + filename)
            Dim record As String = field1 + delimiter + field2 + delimiter + field3 + delimiter + field4 + delimiter + field5
            fileWriter.WriteLine(record)
            fileWriter.Close()
            'MessageBox.Show("Salvestatud")
        Catch ex As IOException
            'MessageBox.Show("An IO error occurred: " & ex.Message)
        End Try
    End Sub

    'Public Sub WriteToLog() Implements IExportToCSV.WriteToLog
    '    Dim currentTime As String
    '    currentTime = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss")


    'End Sub
End Class