Module KasutajaMoodul
    Public isLoggedIn As Boolean = False
    Public loggedInID As Double
    Public loggedInFirstName As String = ""
    Public loggedInLastName As String = ""
    Public loggedInPassword As String = ""
    Public loggedInHeight As Double
    Public loggedInDay As Double
    Public test As Boolean = True
    Public loggedInMonth As String = ""
    Public loggedInYear As Double
    Public loggedAlcohol As Double
    Public loggedInWeight As Double
    Public food_amount As Double
    Public loggedInGoal As Double
    Public loggedInCalories As Double
    Public loggedInSugar As Double
    Public loggedInRemainingSugar As Double
    Public loggedInRemainingCalories As Double
    Public Unhealthy As Boolean = True
    'Public RemainingCalories As Double
    'Public latestUserID As Integer = -1
    Public Kosher As Boolean

    ' Funktsioon, mis määrab kasutaja sisselogimise oleku
    Public Sub SetLoginStatus(ByVal status As Boolean)
        isLoggedIn = status
    End Sub


End Module
