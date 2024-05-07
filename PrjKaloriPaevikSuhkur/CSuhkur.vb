Imports System.IO
Imports System.Data.OleDb

Public Class CSuhkur
    Implements ISuhkur

    Private sugarLimit As Integer
    Private consumedSugar As Integer
    Private kaal As Integer
    Dim oldDate As Date
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\FoodDatabase.accdb;"
    Sub New()
        Using connection As New OleDbConnection(connectionString)
            Try
                connection.Open()
                Dim commandText As String = "SELECT top 1 Kaal, Limiit, Kalorid, DateSerial(Päev, Kuu, Aasta) AS combined_date FROM ajalugu ORDER BY ID DESC"
                Dim command As New OleDbCommand(commandText, connection)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Access individual columns by column name or index
                    kaal = Convert.ToInt32(reader("Kaal"))
                    sugarLimit = Convert.ToInt32(reader("Limiit"))
                    consumedSugar = Convert.ToInt32(reader("Kalorid"))
                    oldDate = Convert.ToDateTime(reader("combined_date"))
                    If DateTime.Now.Date > oldDate Then
                        consumedSugar = 0
                    End If
                End If
                reader.Close()
                connection.Close()
            Catch ex As Exception
                Throw New Exception("Error reading data from the database: " & ex.Message)
            End Try
        End Using
    End Sub
    Public Sub SetCalorieLimit(ByRef limit As Integer) Implements ISuhkur.SetCalorieLimit
        sugarLimit = limit
        WriteData()
    End Sub

    Public Sub AddCalories(ByRef foodID As Integer) Implements ISuhkur.AddCalories
        'add consumed calories
        Dim sugar As Integer = getCalories(foodID)
        consumedSugar += sugar
        WriteData()
    End Sub

    Private Function getCalories(ByRef ID As Integer)
        'gets calories from food
        Dim result As Integer
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT Kalorid FROM Toit WHERE YourPrimaryKeyColumn = ID"
            Dim command As New OleDbCommand(commandText, connection)
            ' Specify the value of the primary key to retrieve
            command.Parameters.AddWithValue("ID", ID)
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
        Dim dateArrey As Integer() = GetCurrentDateComponents()
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim commandText As String = "INSERT INTO ajalugu (Päev, Kuu, Aasta, Kaal, Kalorid, Limiit) VALUES (@Päev, @Kuu, @Aasta, @kaal, @consumedSugar, @sugarLimit)"
                Dim command As New OleDbCommand(commandText, connection)

                ' Add parameters to the command
                command.Parameters.AddWithValue("@Päev", dateArrey(0))
                command.Parameters.AddWithValue("@Kuu", dateArrey(1))
                command.Parameters.AddWithValue("@Aasta", dateArrey(2))
                command.Parameters.AddWithValue("@Kaal", kaal)
                command.Parameters.AddWithValue("@consumedSugar", consumedSugar)
                command.Parameters.AddWithValue("@sugarLimit", sugarLimit)

                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            Throw New Exception("Error writing data to the database: " & ex.Message)
        End Try
    End Sub
End Class
