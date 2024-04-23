Imports System.Data.OleDb

Public Class Profiil
    Private Sub Profiil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If KasutajaMoodul.isLoggedIn Then


            'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\FoodDatabase.accdb;"
            Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\FoodDatabase.accdb;"
            Dim query As String = "SELECT Eesnimi, Perenimi, Parool, Päev, Kuu, Aasta, Pikkus, Kaal 
                                   FROM Kasutaja WHERE Eesnimi = @Eesnimi"

            Try
                Using connection As New OleDbConnection(connectionString)
                    connection.Open()

                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@Eesnimi", KasutajaMoodul.loggedInFirstName)

                        Using reader As OleDbDataReader = command.ExecuteReader()
                            If reader.Read() Then

                                lblUsername.Text = reader("Eesnimi").ToString() & "  " & reader("Perenimi").ToString()
                                lblPassword.Text = New String("*"c, reader("Parool").ToString().Length)
                                lblDate.Text = reader("Päev").ToString() & "." & reader("Kuu").ToString() _
                                 & "." & reader("Aasta").ToString()
                                lblWeight.Text = reader("Kaal").ToString()
                                lblHeight.Text = reader("Pikkus").ToString()

                            End If
                        End Using
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Andmete laadimisel tekkis viga: " & ex.Message, "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub


    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
    End Sub

End Class