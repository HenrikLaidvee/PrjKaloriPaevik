Module KasutajaMoodul
    Public isLoggedIn As Boolean = False
    Public loggedInFirstName As String = ""
    Public loggedInLastName As String = ""

    ' Funktsioon, mis määrab kasutaja sisselogimise oleku
    Public Sub SetLoginStatus(ByVal status As Boolean, ByVal firstname As String, ByVal lastname As String)
        isLoggedIn = status
        loggedInFirstName = firstname
        loggedInLastName = lastname
    End Sub

End Module
