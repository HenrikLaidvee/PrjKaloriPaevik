Imports System.IO

Public Class CCalories
    Implements ICalories

    Private calorieLimit As Integer
    Private consumedCalories As Integer

    Public Sub New()
        ' Load saved data when the FitnessTracker instance is created
        LoadData()
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

    Private Sub LoadData()
        'Load calorie limit and consumed calories from a text file
        Try
            Using reader As New StreamReader("FitnessData.txt")
                Dim savedDate As Date = Date.ParseExact(reader.ReadLine(), "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture)

                If savedDate.Date = Date.Today Then
                    'If saved date is today, load the saved consumed calories
                    calorieLimit = Integer.Parse(reader.ReadLine())
                    consumedCalories = Integer.Parse(reader.ReadLine())
                Else
                    'If saved date is not today, reset consumed calories to 0
                    calorieLimit = Integer.Parse(reader.ReadLine())
                    consumedCalories = 0
                End If
            End Using
        Catch ex As Exception
            ' If the file doesn't exist or there's an error, set default values
            calorieLimit = 2000
            consumedCalories = 0
        End Try
    End Sub

    Private Sub SaveData()
        Dim existingData As New List(Of String)()
        Try
            Using reader As New StreamReader("FitnessData.txt")
                Dim line As String
                While (InlineAssignHelper(line, reader.ReadLine())) IsNot Nothing
                    existingData.Add(line)
                End While
            End Using
        Catch ex As Exception
            ' Handle any errors in reading existing data
        End Try

        ' Prepend new data to the existing data
        existingData.Insert(0, Date.Today.ToString("yyyy-MM-dd")) ' Prepend today's date in "yyyy-MM-dd" format
        existingData.Insert(1, calorieLimit.ToString())
        existingData.Insert(2, consumedCalories.ToString())

        ' Write the modified content back to the file
        Try
            Using writer As New StreamWriter("FitnessData.txt")
                For Each line As String In existingData
                    writer.WriteLine(line)
                Next
            End Using
        Catch ex As Exception
            ' Handle any errors in saving data
        End Try
    End Sub
    Private Shared Function InlineAssignHelper(Of T)(ByRef target As T, ByVal value As T) As T
        target = value
        Return value
    End Function
End Class
