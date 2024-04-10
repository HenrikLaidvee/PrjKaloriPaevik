Public Interface IFoodWarning

    Sub DisplayWarning(foodName As String, calorieContent As Integer)
    Function IsFoodUnhealthy(foodName As String, calorieContent As Integer) As Boolean


End Interface
