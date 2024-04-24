Module KasutajaMoodul
    Public isLoggedIn As Boolean = False
    Public loggedInID As Double
    Public loggedInFirstName As String = ""
    Public loggedInLastName As String = ""
    Public loggedInPassword As String = ""
    Public loggedInHeight As Double
    Public loggedInDay As Double
    Public loggedInMonth As String = ""
    Public loggedInYear As Double
    Public loggedInWeight As Double
    Public loggedInGoal As Double
    Public loggedInCalories As Double

    ' Funktsioon, mis määrab kasutaja sisselogimise oleku
    Public Sub SetLoginStatus(ByVal status As Boolean)
        isLoggedIn = status
    End Sub


End Module
