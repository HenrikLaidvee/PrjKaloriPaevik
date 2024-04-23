Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class CExportToCSV
    Implements IExportToCSV



    Public Sub IExportToCSV_WriteToFile(filepath As String, filename As String, field1 As String, field2 As String, field3 As String, field4 As String, field5 As String, delimiter As String) Implements IExportToCSV.WriteToFile
        Try
            Dim completePath As String
            If Not String.IsNullOrEmpty(filename) Or Not ContainsSymbols(filename) Then
                completePath = filepath + "\" + filename
            Else
                MessageBox.Show("Ebasobiv failinimi")
                Exit Sub
            End If

            If Not String.IsNullOrEmpty(filepath) Or Not ContainsSymbols(filepath) Then
                completePath = filepath + "\" + filename
            Else
                MessageBox.Show("Ebasobiv faili asukoht")
                Exit Sub
            End If


            Dim fileWriter As New System.IO.StreamWriter(completePath, True)
            'MessageBox.Show(filepath + "\" + filename)
            Dim record As String = field1 + delimiter + field2 + delimiter + field3 + delimiter + field4 + delimiter + field5
            'Seda tuleks teha võibolla tsükliliselt oleneb kuidas data antakse
            fileWriter.WriteLine(record)

            fileWriter.Close()

            If File.ReadAllText(completePath).Length > 0 Then
                MessageBox.Show("Salvestatud")
            Else
                MessageBox.Show("Ebaõnnestus")
            End If
        Catch ex As IOException
            'MessageBox.Show("An IO error occurred: " & ex.Message)
        End Try
    End Sub

    Public Function ContainsSymbols(input As String) As Boolean Implements IExportToCSV.ContainsSymbols
        Try
            Dim pattern As String = "[^\w\s]"
            'Regex otsib antud patternit 
            Dim regex As New Regex(pattern)
            Return regex.IsMatch(input)
        Catch
            Return -1
        End Try
    End Function


End Class