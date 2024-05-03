Public Interface IFoodWarning

    Sub DisplayWarning(foodName As String, calorieContent As Integer, fatContent As Double)
    Function IsFoodUnhealthy(foodName As String, calorieContent As Integer, fatContent As Double) As Integer


End Interface
