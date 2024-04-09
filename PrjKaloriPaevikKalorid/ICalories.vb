Public Interface ICalories
    Sub AddCalories(ByRef calories As Integer)
    Sub SetCalorieLimit(ByRef limit As Integer)
    Function GetRemainingCalories() As Integer
    Function GetConsumedCalories() As Integer
    Function GetCalorieLimit() As Integer
End Interface
