﻿Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class MainForm
    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Profiil.Show()
    End Sub

    Private Sub btnCreateUser_Click(sender As Object, e As EventArgs) Handles btnCreateUser.Click
        RegAken.Show()
    End Sub

    Private Sub btnLogFood_Click(sender As Object, e As EventArgs) Handles btnLogFood.Click
        Form1.Show()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LogInAken.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogFood.Enabled = False
        btnProfile.Enabled = False
        btnKaal.Enabled = Enabled
    End Sub

    Private Sub btnKaal_Click(sender As Object, e As EventArgs) Handles btnKaal.Click
        StatistikaForm.Show()
    End Sub
    Private Sub InsertDataIntoWeightData(weightValue As Double, ID As Integer)
        ' Connect to your Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduTest.accdb;"

        ' Define your SQL query to retrieve Pikkus value
        Dim selectQuery As String = "SELECT Pikkus FROM Kasutaja WHERE ID = @ID"

        ' Define your SQL query to insert data with parameterized query
        Dim insertQuery As String = "INSERT INTO KaaluAndmed ([Kuupäev], [Kaal], [BMI], [ID]) VALUES (@DateValue, @WeightValue, @BMIValue, @ID)"

        Using connection As New OleDbConnection(connectionString)
            ' First, retrieve the Pikkus value from the database
            Using selectCommand As New OleDbCommand(selectQuery, connection)
                ' Add parameter for Eesnimi
                selectCommand.Parameters.AddWithValue("@ID", ID) ' ID is a variable containing the User ID to search for

                Try
                    connection.Open()

                    ' Execute the SELECT command and retrieve the Pikkus value
                    Dim pikkus As Integer = Convert.ToInt32(selectCommand.ExecuteScalar())
                    Dim BMI As Double = weightValue / ((pikkus / 100) * (pikkus / 100))

                    ' Now, you have the Pikkus value, proceed with inserting data
                    Using insertCommand As New OleDbCommand(insertQuery, connection)
                        ' Add parameters to the INSERT command
                        insertCommand.Parameters.AddWithValue("@DateValue", DateTime.Now) ' Use current system time as date value
                        insertCommand.Parameters.AddWithValue("@WeightValue", weightValue)
                        insertCommand.Parameters.AddWithValue("@BMIValue", BMI) ' Use the calculated BMI value
                        insertCommand.Parameters.AddWithValue("@ID", ID) ' Use the ID value

                        ' Execute the INSERT command
                        insertCommand.ExecuteNonQuery()

                        ' Optionally, display a message indicating data was saved
                        ' MessageBox.Show("Data saved successfully!")
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error retrieving or saving data: " & ex.Message)
                End Try
            End Using
        End Using

    End Sub

    Private Sub txtCurrentWeight_TextChanged(sender As Object, e As EventArgs) Handles txtCurrentWeight.TextChanged
        ' Get the weight value from the textbox
        Dim weightValue As Double
        Dim ID As Integer
        If Double.TryParse(txtCurrentWeight.Text, weightValue) Then
            ' Call the method to insert data into the WeightData table
            InsertDataIntoWeightData(weightValue, ID)
        End If

    End Sub
End Class