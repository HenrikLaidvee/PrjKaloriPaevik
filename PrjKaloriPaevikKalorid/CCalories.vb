Imports System.IO
Imports System.Data.OleDb

Public Class CCalories
    Implements ICalories

    Private kasutaja As Integer
    Private food As Integer
    Private oldDate As DateTime
    Private makro As Double() = {0, 0, 0, 0, 0}
    Private nutrients As Integer() = {1003, 1004, 1005, 2000, 1008}
    'Private makrod As String() = {"protein", "fat", "carbs", "suhkur", "calories"}
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\ToiduTest.accdb;"
    Sub New()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim commandText As String = "SELECT COUNT(*) as counted FROM sisestatud_toit"
                Dim command As New OleDbCommand(commandText, connection)
                Dim rowCount As Integer = CInt(command.ExecuteScalar())
                connection.Close()
                If rowCount > 0 Then
                    connection.Open()
                    Dim quoryText As String = "SELECT top 5 amount, daata FROM Sisestatud_toit ORDER BY ID DESC"
                    Dim quory As New OleDbCommand(quoryText, connection)
                    Dim reader As OleDbDataReader = quory.ExecuteReader()
                    Dim i As Integer = 0
                    While reader.Read() AndAlso i < 5
                        ' Access individual columns by column name or index
                        Dim value As Double = Convert.ToDouble(reader("amount"))
                        makro(i) = value
                        oldDate = DateTime.Parse(reader("daata"))
                        oldDate = oldDate.Date
                        i += 1
                    End While
                    If oldDate < Date.Now.Date Then
                        makro = {0, 0, 0, 0, 0}
                    End If
                    reader.Close()
                End If
                connection.Close()
            Catch ex As Exception
                Throw New Exception("Error reading data from the database: " & ex.Message)
            End Try
        End Using
    End Sub

    Public Sub AddCalories(ByRef foodID As Integer, ByRef amount As Integer) Implements ICalories.AddCalories
        'add consumed calories
        food = foodID
        Dim calories As Double = getNutrient(foodID, nutrients(4))
        Dim sugar As Double = getNutrient(foodID, nutrients(3))
        Dim carbs As Double = getNutrient(foodID, nutrients(2))
        Dim fat As Double = getNutrient(foodID, nutrients(1))
        Dim protein As Double = getNutrient(foodID, nutrients(0))

        makro(0) += protein '* Convert.ToDouble(amount)
        makro(1) += fat
        makro(2) += carbs
        makro(3) += sugar
        makro(4) += calories
        WriteData()
    End Sub

    Private Function getNutrient(ByRef ID As Integer, ByRef nutient As Integer)
        'gets calories from food
        Dim result As Double
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT nutrient_amount FROM toit_ja_toitained WHERE Food_ID = food AND nutrient_id = nut"
            Dim command As New OleDbCommand(commandText, connection)
            ' Specify the value of the primary key to retrieve
            command.Parameters.AddWithValue("food", ID)
            command.Parameters.AddWithValue("nut", nutient)
            result = Convert.ToDouble(command.ExecuteScalar())
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
                For i As Integer = 4 To 0 Step -1
                    Dim commandText As String = "INSERT INTO sisestatud_toit (kasutaja_ID, food_ID, Nutrien_ID, amount, daata) VALUES (@kasutaja, @food, @nutrients, @makro, @date)"
                    Dim command As New OleDbCommand(commandText, connection)

                    ' Add parameters to the command
                    command.Parameters.AddWithValue("@kasutaja", CInt(kasutaja))
                    command.Parameters.AddWithValue("@food", CInt(food))
                    command.Parameters.AddWithValue("@nutrients", CInt(nutrients(i)))
                    command.Parameters.AddWithValue("@makro", Convert.ToDouble(makro(i)))
                    command.Parameters.AddWithValue("@date", Date.Now.ToString())

                    command.ExecuteNonQuery()
                Next
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            Throw New Exception("Error writing data to the database: " & ex.Message)
        End Try
    End Sub
End Class
