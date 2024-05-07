Imports System.IO
Imports System.Data.OleDb

Public Class CCalories
    Implements ICalories

    Private kasutaja As Integer
    Private food As Integer
    Private amount As Integer
    Private oldDate As Date
    Private makro As Integer
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\ToiduTest.accdb;"
    Sub New()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim commandText As String = "SELECT top 1 ID, kasutaja_ID, Toidu_ID, Nutrient_ID, amount, Date FROM sisestatu_ID WHERE nutrient_ID = 1008 ORDER BY ID"
                Dim command As New OleDbCommand(commandText, connection)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    If DateTime.Now.Date > oldDate Then
                        makro = 0
                    End If
                    oldDate = Convert.ToDateTime(reader("Date"))
                    kasutaja = reader("kasutaja_ID")
                    food = reader("kasutaja_ID")
                    amount = reader("amount")
                    makro = reader("nutrient_ID")
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
        Dim calories As Integer = getCalories(foodID)
        Dim result As Integer = amount * calories
        makro += calories
        WriteData()
    End Sub

    Private Function getCalories(ByRef ID As Integer)
        'gets calories from food
        Dim result As Integer
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT nutrient_amount FROM toit_ja_toitained WHERE food_ID = ID AND Nutrient_ID = 1008"
            Dim command As New OleDbCommand(commandText, connection)
            ' Specify the value of the primary key to retrieve
            command.Parameters.AddWithValue("ID", ID)
            result = command.ExecuteScalar()
            connection.Close()
        End Using
        Return result
    End Function

    Private Sub WriteData()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim commandText As String = "INSERT INTO sisestatud_toit (food_ID, kasutaja_ID, nutrient_ID, amount, date) VALUES (@food, @kasutaja, @makro, @amount, @date)"
                Dim command As New OleDbCommand(commandText, connection)

                ' Add parameters to the command
                command.Parameters.AddWithValue("@food", food)
                command.Parameters.AddWithValue("@kasutaja", kasutaja)
                command.Parameters.AddWithValue("@makro", makro)
                command.Parameters.AddWithValue("@amount", amount)
                command.Parameters.AddWithValue("@date", Date.Now)

                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            Throw New Exception("Error writing data to the database: " & ex.Message)
        End Try
    End Sub
End Class
