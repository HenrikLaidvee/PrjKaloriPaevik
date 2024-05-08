Imports System.Data.OleDb

Public Class CFoodCalculate
    Implements IFoodCalculate

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"

    Public Sub CalculateAndInsertTotals() Implements IFoodCalculate.CalculateAndInsertTotals
        ' SQL query to calculate the sum of nutrients for each day
        Dim query As String = "SELECT Kasutaja_ID, Date, SUM(Amount) AS TotalAmount, SUM(Energy) AS TotalEnergy, SUM(Protein) AS TotalProtein, SUM(Carbohydrates) AS TotalCarbohydrates, SUM(Sugar) AS TotalSugar, SUM(Fat) AS TotalFat " &
                              "FROM Sisestatud_toit " &
                              "GROUP BY Kasutaja_ID, Date"

        ' SQL query to insert the calculated totals into "ajalugu" table
        Dim insertQuery As String = "INSERT INTO ajalugu (Kasutaja_ID, Amount, Energy, Protein, Carbohydrates, Sugar, Fat, Date) VALUES (@Kasutaja_ID, @Amount, @Energy, @Protein, @Carbohydrates, @Sugar, @Fat, @Date)"

        Using connection As New OleDbConnection(connectionString)
            connection.Open()

            Using command As New OleDbCommand(query, connection)
                Using reader As OleDbDataReader = command.ExecuteReader()
                    While reader.Read()
                        Dim kasutajaID As Integer = Convert.ToInt32(reader("Kasutaja_ID"))
                        Dim dateValue As String = reader("Date").ToString()
                        Dim totalAmount As Integer = Convert.ToInt32(reader("TotalAmount"))
                        Dim totalEnergy As Double = Convert.ToDouble(reader("TotalEnergy"))
                        Dim totalProtein As Double = Convert.ToDouble(reader("TotalProtein"))
                        Dim totalCarbohydrates As Double = Convert.ToDouble(reader("TotalCarbohydrates"))
                        Dim totalSugar As Double = Convert.ToDouble(reader("TotalSugar"))
                        Dim totalFat As Double = Convert.ToDouble(reader("TotalFat"))

                        ' Insert the calculated totals into "ajalugu" table
                        Using insertCommand As New OleDbCommand(insertQuery, connection)
                            insertCommand.Parameters.AddWithValue("@Kasutaja_ID", kasutajaID)
                            insertCommand.Parameters.AddWithValue("@Amount", totalAmount)
                            insertCommand.Parameters.AddWithValue("@Energy", totalEnergy)
                            insertCommand.Parameters.AddWithValue("@Protein", totalProtein)
                            insertCommand.Parameters.AddWithValue("@Carbohydrates", totalCarbohydrates)
                            insertCommand.Parameters.AddWithValue("@Sugar", totalSugar)
                            insertCommand.Parameters.AddWithValue("@Fat", totalFat)
                            insertCommand.Parameters.AddWithValue("@Date", dateValue)

                            insertCommand.ExecuteNonQuery()
                        End Using
                    End While
                End Using
            End Using
        End Using
    End Sub

End Class

