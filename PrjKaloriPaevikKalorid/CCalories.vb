Imports System.IO
Imports System.Data.OleDb
Imports Microsoft.VisualBasic.ApplicationServices
Imports System.Linq.Expressions

Public Class CCalories
    Implements ICalories

    Private sugar As Double = 0
    Private calories As Double = 0
    Private makro() As Double = {0, 0, 0}
    Private mass As Double
    'Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
    Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
    'Private connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Throthar\source\repos\PrjKaloriPaevik\ToiduTest.accdb;"

    Public Function makroPercent(ByRef index As Integer, ByRef user As Integer) As Double Implements ICalories.makroPercent
        Dim aine As Double = 0
        getNutrient(user)
        Dim mass = makro(0) + makro(1) + makro(2)
        If mass > 0 Then
            aine = Math.Round((makro(index) * 100) / mass)
        End If
        sugar = 0
        calories = 0
        makro = {0, 0, 0}
        Return aine
    End Function

    Private Sub getNutrient(ByRef user As Integer)
        Try
            Dim currentDate As String = DateTime.Now.ToString("dd-MM-yyyy")

            'gets calories from food
            Using connection As New OleDbConnection(connectionString)
                connection.Open()
                Dim commandText As String = "SELECT Energy, Protein, Fat, Carbohydrates, sugar FROM sisestatud_toit WHERE  [date] like ? AND kasutaja_id = data"
                Dim command As New OleDbCommand(commandText, connection)

                ' Specify the value of the primary key to retrieve
                command.Parameters.AddWithValue("?", "%" & currentDate & "%")
                command.Parameters.AddWithValue("data", user)
                Dim reader As OleDbDataReader = command.ExecuteReader()
                While reader.Read()
                    makro(0) += reader("Protein")
                    makro(1) += reader("Fat")
                    makro(2) += reader("Carbohydrates")
                    sugar += reader("Sugar")
                    calories += reader("Energy")
                End While
                connection.Close()
            End Using
        Catch ex As Exception
            Throw New Exception("Error reading data from the database: " & ex.Message)
        End Try
    End Sub

    Public Function getCalories(ByRef userId As Integer) As Double Implements ICalories.getCalories
        getNutrient(userId)
        Dim result As Integer = calories
        sugar = 0
        calories = 0
        makro = {0, 0, 0}
        Return result
    End Function

    Public Function getSugar(ByRef userId As Integer) As Double Implements ICalories.getSugar
        getNutrient(userId)
        Dim result As Integer = sugar
        sugar = 0
        calories = 0
        makro = {0, 0, 0}
        Return result
    End Function
End Class
