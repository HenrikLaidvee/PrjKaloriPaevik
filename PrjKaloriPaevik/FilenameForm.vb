Imports System.Windows.Forms.VisualStyles
Imports ExportToCSV
Imports CSVExporterDNF
Imports System.Data.OleDb

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

    Private Sub btnSaveDll_Click(sender As Object, e As EventArgs) Handles btnSaveDll.Click

        Dim myArray(,) As Object = Nothing
        ConvertAccessTableToArray("your_connection_string_here", "Sisestatud_toit", myArray)


    End Sub
    Sub ConvertAccessTableToArray(connectionString As String, tableName As String, ByRef array(,) As Object)
        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            ' Construct a SQL query to select all data from the specified table
            Dim query As String = "SELECT * FROM " & tableName

            ' Create a command to execute the SQL query
            Using command As New OleDbCommand(query, connection)
                ' Execute the command and get the data into a DataReader
                Using reader As OleDbDataReader = command.ExecuteReader()
                    ' Determine the number of columns
                    Dim num_cols As Integer = reader.FieldCount

                    ' Create a list to hold the rows
                    Dim rows As New List(Of Object())

                    ' Loop through the reader to populate the list with rows
                    While reader.Read()
                        ' Create an array to hold the current row data
                        Dim row(num_cols - 1) As Object

                        ' Copy the data from the reader to the row array
                        For col_index As Integer = 0 To num_cols - 1
                            row(col_index) = reader(col_index)
                        Next

                        ' Add the row array to the list
                        rows.Add(row)
                    End While

                    ' Initialize the array with the correct dimensions
                    array = New Object(rows.Count - 1, num_cols - 1) {}

                    ' Copy the data from the list to the array
                    For row_index As Integer = 0 To rows.Count - 1
                        For col_index As Integer = 0 To num_cols - 1
                            array(row_index, col_index) = rows(row_index)(col_index)
                        Next
                    Next
                End Using
            End Using
        End Using
    End Sub


    Private Sub btnPathSelect_Click(sender As Object, e As EventArgs) Handles btnPathSelect.Click
        Dim dllExporter As IExporter
        dllExporter = New CSVExporterDNF.CExporter

        lblCurrentFilePath.Text = dllExporter.setFileToSave()
    End Sub

End Class