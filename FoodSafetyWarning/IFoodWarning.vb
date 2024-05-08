Public Interface IFoodWarning
    Function IsFoodUnhealthy(foodName As String, calorieContent As Integer, fatContent As Double) As Boolean
    Sub DisplayWarning(foodName As String, calorieContent As Integer, fatContent As Double)

End Interface
