Imports System.Data.OleDb
Imports System.IO
Imports System.Text.RegularExpressions
Imports System.Windows.Forms
Public Class CExportToCSV
    Implements IExportToCSV


    Public Sub IExportToCSV_WriteToFile(filepath As String, filename As String, numberOfLines As Integer, connectionString As String) Implements IExportToCSV.WriteToFile
        Dim completePath As String
        Try

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
        Catch ex As IOException
            MessageBox.Show("An IO error occurred: " & ex.Message)
            Exit Sub
        End Try

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Construct a SQL query to select a specific number of lines from your table

            'Tuleb YourTable ära vahetada veel
            Dim query As String = "SELECT TOP " & numberOfLines & " * FROM Sisestatud_toit"

            ' Create a command to execute the SQL query
            Using command As New OleDbCommand(query, connection)
                ' Execute the command and get the data into a DataReader
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Create a StreamWriter to write to the CSV file
                    Using fileWriter As New System.IO.StreamWriter(completePath)
                        ' Write the header row with column names
                        Dim header As String = ""
                        For i As Integer = 0 To reader.FieldCount - 1
                            header += reader.GetName(i) + ","
                        Next
                        header = header.TrimEnd(",")
                        fileWriter.WriteLine(header)

                        ' Loop through the reader to write the retrieved data to the CSV file
                        While reader.Read()
                            Dim record As String = ""
                            For i As Integer = 0 To reader.FieldCount - 1
                                record += reader(i).ToString() + ","
                            Next
                            record = record.TrimEnd(",")
                            fileWriter.WriteLine(record)
                        End While
                    End Using
                End Using
            End Using
        End Using
        MessageBox.Show("Edukalt salvestatud")
        '    Dim fileWriter As New System.IO.StreamWriter(completePath, True)
        '    'MessageBox.Show(filepath + "\" + filename)
        '    Dim record As String = field1 + delimiter + field2 + delimiter + field3 + delimiter + field4 + delimiter + field5
        '    'Seda tuleks teha võibolla tsükliliselt oleneb kuidas data antakse
        '    fileWriter.WriteLine(record)

        '    fileWriter.Close()

        '    If File.ReadAllText(completePath).Length > 0 Then
        '        MessageBox.Show("Salvestatud")
        '    Else
        '        MessageBox.Show("Ebaõnnestus")
        '    End If
        'Catch ex As IOException
        '    'MessageBox.Show("An IO error occurred: " & ex.Message)
        'End Try
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