Imports System.Windows.Forms

Public Class CFoodWarning
    Implements IFoodWarning

    Const fatPerCalorie As Double = 0.35

    Private calorieThresholdPerServing As Integer = 500




    Public Function IsFoodUnhealthy(foodName As String, calorieContent As Integer, fatContent As Double) As Integer Implements IFoodWarning.IsFoodUnhealthy
        If calorieContent > calorieThresholdPerServing Then
            Return 1
        ElseIf calorieContent / fatPerCalorie > fatContent Then

            Return 2
        Else
            Return 0
        End If
    End Function
    Public Sub DisplayWarning(foodName As String, calorieContent As Integer, fatContent As Double) Implements IFoodWarning.DisplayWarning
        If IsFoodUnhealthy(foodName, calorieContent, fatContent) > 0 Then
            MessageBox.Show($"Warning: {foodName} is high in calories ({calorieContent} calories per serving) or contains too much fat and may not be suitable for consumption.")
        End If
    End Sub


End Class
