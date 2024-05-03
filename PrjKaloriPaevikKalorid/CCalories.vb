Imports System.IO
Imports System.Data.OleDb

Public Class CCalories
    Implements ICalories

    Private kasutaja As Integer
    Private food As Integer
    Private amount As Integer
    Private oldDate As Date
    Private makro As Integer() = {0, 0, 0, 0, 0}
    Private nutrients As Integer() = {1003, 1004, 1005, 2000, 1008}
    'Private makrod As String() = {"protein", "fat", "carbs", "suhkur", "calories"}
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\ToiduTest.accdb;"
    Sub New()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim commandText As String = "SELECT top 5 ID, kasutaja_ID, Toidu_ID, Nutrient_ID, amount, Date FROM ajalugu ORDER BY ID DESC"
                Dim command As New OleDbCommand(commandText, connection)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    If Date.Now > oldDate Then
                        For i As Integer = 0 To 4
                            makro(i) = 0
                        Next
                    Else
                        For i As Integer = 0 To 4
                            ' Access individual columns by column name or index
                            Dim value As Integer = reader("Nutrient_id")
                            makro(i) = value
                        Next
                    End If
                    oldDate = Convert.ToDateTime(reader("Date"))
                    kasutaja = reader("kasutaja_ID")
                    food = reader("kasutaja_ID")
                    amount = reader("amount")
                End If
                reader.Close()
                connection.Close()
            Catch ex As Exception
                Throw New Exception("Error reading data from the database: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub AddCalories(ByRef foodID As Integer, ByRef amount As Integer) Implements ICalories.AddCalories
        'add consumed calories
        Dim calories As Integer = getNutrient(foodID, nutrients(4))
        Dim sugar As Integer = getNutrient(foodID, nutrients(3))
        Dim carbs As Integer = getNutrient(foodID, nutrients(2))
        Dim fat As Integer = getNutrient(foodID, nutrients(1))
        Dim protein As Integer = getNutrient(foodID, nutrients(0))

        makro(0) += protein * amount
        makro(1) += fat * amount
        makro(2) += carbs * amount
        makro(3) += sugar * amount
        makro(4) += calories * amount
        WriteData()
    End Sub

    Private Function getNutrient(ByRef ID As Integer, ByRef nutient As Integer)
        'gets calories from food
        Dim result As Integer
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT nutrient_amount FROM toit_ja_toitained WHERE ID = ID AND Nutrient_ID = nutient"
            Dim command As New OleDbCommand(commandText, connection)
            ' Specify the value of the primary key to retrieve
            command.Parameters.AddWithValue("ID", ID)
            command.Parameters.AddWithValue("nutient", nutient)
            result = command.ExecuteScalar()
            connection.Close()
        End Using
        Return result
    End Function

    Private Function GetCurrentDateComponents() As Integer()
        'converts data into day, month, year in arrey
        Dim currentDate As Date = Date.Now
        Dim dayString As Integer = currentDate.Day
        Dim monthString As Integer = currentDate.Month
        Dim yearString As Integer = currentDate.Year
        Return {dayString, monthString, yearString}
    End Function

    Private Sub WriteData()
        'Dim dateArrey As Integer() = GetCurrentDateComponents()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                For i As Integer = 0 To 4
                    Dim commandText As String = "INSERT INTO sisestatud_toit (kasutaja_ID, Toidu_ID, Nutrient_ID, amount, Date) VALUES (@kasutaja, @food, @makro, @amount, @date)"
                    Dim command As New OleDbCommand(commandText, connection)

                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@kasutaja", kasutaja)
                    command.Parameters.AddWithValue("@food", food)
                    command.Parameters.AddWithValue("@makro", makro(i))
                    command.Parameters.AddWithValue("@amount", amount)
                    command.Parameters.AddWithValue("@date", Date.Now)

                    command.ExecuteNonQuery()
                Next
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            Throw New Exception("Error writing data to the database: " & ex.Message)
        End Try
    End Sub
End Class
