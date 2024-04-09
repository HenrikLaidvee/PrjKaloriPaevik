Imports System.IO
Imports System.Data.OleDb

Public Class CCalories
    Implements ICalories

    Private calorieLimit As Integer
    Private consumedCalories As Integer

    Public Sub New()
        ' Load saved data when the FitnessTracker instance is created

    End Sub

    Public Sub SetCalorieLimit(ByRef limit As Integer) Implements ICalories.SetCalorieLimit
        calorieLimit = limit
        SaveData() ' Save data after each modification
    End Sub

    Public Sub AddCalories(ByRef calories As Integer) Implements ICalories.AddCalories
        consumedCalories += calories
        SaveData() ' Save data after each modification
    End Sub

    Public Function GetRemainingCalories() As Integer Implements ICalories.GetRemainingCalories
        Return calorieLimit - consumedCalories
    End Function

    Public Function GetConsumedCalories() As Integer Implements ICalories.GetConsumedCalories
        Return consumedCalories
    End Function

    Public Function GetCalorieLimit() As Integer Implements ICalories.GetCalorieLimit
        Return calorieLimit
    End Function
    Private Function GetCurrentDateComponents() As String()
        Dim currentDate As Date = Date.Now
        Dim dayString As String = currentDate.Day.ToString()
        Dim monthString As String = currentDate.Month.ToString()
        Dim yearString As String = currentDate.Year.ToString()

        ' Ensure day and month are formatted as two digits if necessary (e.g., '05' instead of '5')
        If dayString.Length = 1 Then
            dayString = "0" & dayString
        End If
        If monthString.Length = 1 Then
            monthString = "0" & monthString
        End If

        Return {dayString, monthString, yearString}
    End Function

    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\FoodDatabase.accdb;"

    Private Sub WriteData(value1 As String, value2 As String)
        Dim dateArrey As String() = GetCurrentDateComponents()
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
