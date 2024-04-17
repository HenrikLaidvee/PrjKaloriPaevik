Imports System.IO
Imports System.Data.OleDb

Public Class CCalories
    Implements ICalories

    Private calorieLimit As Integer
    Private consumedCalories As Integer
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\FoodDatabase.accdb;"

    Public Sub SetCalorieLimit(ByRef limit As Integer) Implements ICalories.SetCalorieLimit
        calorieLimit = limit
    End Sub

    Public Sub AddCalories(ByRef foodID As Integer) Implements ICalories.AddCalories
        Dim calories As Integer = getCalories(foodID)
        consumedCalories += calories
        WriteData()
    End Sub
    Private Function getCalories(ByRef ID As Integer)
        Dim result As Integer
        Try
            Using connection As New OleDbConnection(connectionString)
                connection.Open()

                Dim commandText As String = "SELECT Toit FROM Kalorid WHERE YourPrimaryKeyColumn = ID"
                Dim command As New OleDbCommand(commandText, connection)
                ' Specify the value of the primary key to retrieve
                command.Parameters.AddWithValue("ID", ID)
                result = command.ExecuteScalar()
                connection.Close()
            End Using
        Catch ex As Exception
            'MessageBox.Show("Error: " & ex.Message)
        End Try
        Return result
    End Function

    Private Function GetCurrentDateComponents() As Integer()
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

                Dim commandText As String = "INSERT INTO ajalugu (Kalorid, Limit, Päev, Kuu, Aasta) VALUES (@consumedCalories, @calorieLimit, @Päev, @Kuu, @Aasta)"
                Dim command As New OleDbCommand(commandText, connection)

                ' Add parameters to the command
                command.Parameters.AddWithValue("@consumedCalories", consumedCalories)
                command.Parameters.AddWithValue("@calorieLimit", calorieLimit)
                command.Parameters.AddWithValue("@Päev", dateArrey(0))
                command.Parameters.AddWithValue("@Kuu", dateArrey(1))
                command.Parameters.AddWithValue("@Aasta", dateArrey(2))

                command.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Handle exceptions appropriately
            Throw New Exception("Error writing data to the database: " & ex.Message)
        End Try
    End Sub


    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class
