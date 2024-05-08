Imports System.Windows.Forms.VisualStyles
Imports ExportToCSV
Imports CSVExporterDNF
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


'Tuleb mainformis välja kutsuda

Public Class FilenameForm
    Private numberOfLines As Integer = 0 ' Declare numberOfLines as a class-level variable
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
    'Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"

    Private Sub txtRidadeArv_TextChanged(sender As Object, e As EventArgs) Handles txtRidadeArv.TextChanged
        Integer.TryParse(txtRidadeArv.Text, numberOfLines)
    End Sub
    Private Sub pathBtn_Click(sender As Object, e As EventArgs) Handles pathbtn.Click
        FolderBrowserDialog1.ShowDialog()
        Dim filepath As String = FolderBrowserDialog1.SelectedPath
        Dim filename As String = filepathtxt.Text + ".csv"

        Dim exporter As IExportToCSV
        exporter = New ExportToCSV.CExportToCSV

        exporter.WriteToFile(filepath, filename, numberOfLines, connectionString)
    End Sub

    Private Sub FilenameForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        filepathtxt.Enabled = False
        txtRidadeArv.Enabled = False
        pathbtn.Enabled = False
        cmbDelimiter.Enabled = False
        cmbEraldus.Enabled = False
        chkAppend.Enabled = False
        btnPathSelect.Enabled = False
        btnSaveDll.Enabled = False

        cmbDelimiter.SelectedIndex = 0
        cmbEraldus.SelectedIndex = 0

    End Sub

    Private Sub btnSaveDll_Click(sender As Object, e As EventArgs) Handles btnSaveDll.Click
        Dim append As Boolean
        Dim myArray(,) As Object = Nothing
        ConvertAccessTableToArray(connectionString, "Sisestatud_toit", myArray)

        If chkAppend.Checked Then
            append = True
        Else
            append = False
        End If

        'Dim dllExporter As IExporter
        'dllExporter = New CSVExporterDNF.CExporter

        'Dim success As Integer = dllExporter.saveDataToCsv(myArray, append)
        'If success < 0 Then
        'MessageBox.Show("Salvestamine õnnestus. Salvestatud ridade arv :" & success)
        'End If



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

        'Dim dllExporter As IExporter
        'dllExporter = New CSVExporterDNF.CExporter


        'lblCurrentFilePath.Text = dllExporter.setFileToSave()

    End Sub

    Private Sub chkExport1_CheckedChanged(sender As Object, e As EventArgs) Handles chkExport1.CheckedChanged
        filepathtxt.Enabled = chkExport1.Checked
        txtRidadeArv.Enabled = chkExport1.Checked
        pathbtn.Enabled = chkExport1.Checked
        chkExport2.Enabled = Not chkExport1.Checked

    End Sub

    Private Sub chkExport2_CheckedChanged(sender As Object, e As EventArgs) Handles chkExport2.CheckedChanged
        cmbDelimiter.Enabled = chkExport2.Checked
        cmbEraldus.Enabled = chkExport2.Checked
        chkAppend.Enabled = chkExport2.Checked
        btnPathSelect.Enabled = chkExport2.Checked
        btnSaveDll.Enabled = chkExport2.Checked
        chkExport1.Enabled = Not chkExport2.Checked
    End Sub
End Class