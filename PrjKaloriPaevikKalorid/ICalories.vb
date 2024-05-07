Public Interface ICalories
    Function makroPercent(ByRef index As Integer, ByRef user As Integer) As Double
    Function getCalories(ByRef userId As Integer) As Double
    Function getSugar(ByRef userId As Integer) As Double
End Interface
