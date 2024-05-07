Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices

Public Class CCalories
    Implements ICalories

    Private sugar As Double
    Private calories As Double
    Private makro() As Double = {0, 0, 0}
    Private mass As Double
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\ToiduTest.accdb;"

    Public Function makroPercent(ByRef index As Integer, ByRef user As Integer) As Double Implements ICalories.makroPercent
        Dim aine As Double = 0
        getNutrient(user)
        If mass > 0 Then
            aine = (makro(index) * 100) / mass
        End If
        Return aine
    End Function

    Private Sub getNutrient(ByRef user As Integer)
        'gets calories from food
        Using connection As New OleDbConnection(connectionString)
            connection.Open()
            Dim commandText As String = "SELECT SUM(Energy) as AllEnergy, SUM(Protein) as AllProtein, SUM(Fat) as AllFat, SUM(Carbohydrates) as AllCarbohydrates, SUM(sugar) as AllSugar, SUM(amount) as AllMass FROM sisestatud_toit WHERE Date = data and kasutaj_id = user"
            Dim command As New OleDbCommand(commandText, connection)
            ' Specify the value of the primary key to retrieve
            command.Parameters.AddWithValue("?", Date.Now.ToString("yyyy-MM-dd"))
            command.Parameters.AddWithValue("data", user)
            Dim reader As OleDbDataReader = command.ExecuteScalar()
            makro(0) = reader("AllProtein")
            makro(1) = reader("AllFat")
            makro(2) = reader("AllCarbohydrates")
            makro(3) = reader("AllSugar")
            calories = reader("AllEnergy")
            mass = reader("AllMass")
            connection.Close()
        End Using
    End Sub

    Public Function getCalories(ByRef userId As Integer) As Double Implements ICalories.getCalories
        getNutrient(userId)
        Dim result As Integer
        Return result = calories
    End Function

    Public Function getSugar(ByRef userId As Integer) As Double Implements ICalories.getSugar
        getNutrient(userId)
        Dim result As Integer
        Return result = sugar
    End Function
End Class
