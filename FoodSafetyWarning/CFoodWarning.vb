Public Class CFoodWarning
    Implements IFoodWarning

    Private ReadOnly _calorieThreshold As Integer

    Public Sub New(calorieThreshold As Integer)
        _calorieThreshold = calorieThreshold
    End Sub

    Public Function IsFoodUnhealthy(foodName As String, calorieContent As Integer) As Boolean Implements IFoodWarning.IsFoodUnhealthy
        If calorieContent > _calorieThreshold Then
            Return True
        Else
            Return False
        End If
    End Function
    Public Sub DisplayWarning(foodName As String, calorieContent As Integer) Implements IFoodWarning.DisplayWarning
        If IsFoodUnhealthy(foodName, calorieContent) Then
            Console.WriteLine($"Warning: {foodName} is high in calories ({calorieContent} calories per serving) and may not be suitable for consumption.")
        End If
    End Sub
End Class
