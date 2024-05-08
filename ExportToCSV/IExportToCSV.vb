Public Interface IExportToCSV
    Sub WriteToFile(filepath As String, filename As String, numberOfLines As Integer, connectionString As String)

    Function ContainsSymbols(input As String) As Boolean
    'Sub WriteToLog()
End Interface
