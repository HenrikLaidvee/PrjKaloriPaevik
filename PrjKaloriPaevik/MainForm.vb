Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Windows.Forms.VisualStyles.VisualStyleElement


Public Class MainForm
    Public series As New Series()
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

    Private Sub MainForm_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
        Dim query As String = "SELECT Motivational_quote FROM Motivate;"

        Dim quotesDataTable As New DataTable()

        Using connection As New OleDbConnection(connectionString)
            Using adapter As New OleDbDataAdapter(query, connection)
                connection.Open()
                adapter.Fill(quotesDataTable)
            End Using
        End Using

        If loggedInID <> 0 Then
            Dim showMakro As PrjKaloriPaevikKalorid.ICalories
            showMakro = New PrjKaloriPaevikKalorid.CCalories
            txtProtein.Text = showMakro.makroPercent(0, loggedInID).ToString
            txtFat.Text = showMakro.makroPercent(1, loggedInID).ToString
            txtCarbs.Text = showMakro.makroPercent(2, loggedInID).ToString
            series.ChartType = SeriesChartType.Pie
            series.Points.AddXY("Protein", showMakro.makroPercent(0, loggedInID))
            series.Points.AddXY("Fat", showMakro.makroPercent(1, loggedInID))
            series.Points.AddXY("Carbs", showMakro.makroPercent(2, loggedInID))
        End If


        ' Display a random motivational quote
        If quotesDataTable.Rows.Count > 0 Then
            Dim random As New Random()
            Dim randomIndex As Integer = random.Next(0, quotesDataTable.Rows.Count)
            txtMotivate.Text = quotesDataTable.Rows(randomIndex)("Motivational_quote").ToString()
        End If
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLogFood.Enabled = True
        btnProfile.Enabled = False
        btnKaal.Enabled = False
        txtMotivate.ReadOnly = True

    End Sub

    Private Sub btnKaal_Click(sender As Object, e As EventArgs) Handles btnKaal.Click
        StatistikaForm.Show()
    End Sub
    Private Sub InsertDataIntoWeightData(weightValue As Double, ID As Integer)



        ' Define SQL query to retrieve Pikkus value
        Dim selectQuery As String = "SELECT Pikkus FROM Kasutaja WHERE ID = @ID"

        ' Define SQL query to insert data with parameterized query
        Dim insertQuery As String = "INSERT INTO KaaluAndmed ([Kuupäev], [Kaal], [BMI], [Kasutaja_ID]) VALUES (@DateValue, @WeightValue, @BMIValue, @Kasutaja_ID)"

        ' Connect to your Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
        Using connection As New OleDbConnection(connectionString)
            ' First, retrieve the Pikkus value from the database
            Using selectCommand As New OleDbCommand(selectQuery, connection)
                ' Add parameter for ID
                selectCommand.Parameters.AddWithValue("@Kasutaja_ID", ID) ' ID is a variable containing the User ID to search for

                Try
                    connection.Open()

                    ' Execute the SELECT command and retrieve the Pikkus value
                    Dim pikkus As Integer = Convert.ToInt32(selectCommand.ExecuteScalar())

                    'Calculate BMI values
                    Dim BMI As Double = weightValue / ((pikkus / 100) * (pikkus / 100))

                    ' Now, you have the Pikkus value, proceed with inserting data
                    Using insertCommand As New OleDbCommand(insertQuery, connection)
                        ' Add parameters to the INSERT command
                        insertCommand.Parameters.AddWithValue("@DateValue", DateTime.Now) ' Use current system time as date value
                        insertCommand.Parameters.AddWithValue("@WeightValue", weightValue)
                        insertCommand.Parameters.AddWithValue("@BMIValue", BMI) ' Use the calculated BMI value
                        insertCommand.Parameters.AddWithValue("@Kasutaja_ID", ID) ' Use the ID value

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
        'Current user ID

        If Double.TryParse(txtCurrentWeight.Text, weightValue) Then
            'Call the method To insert data into the WeightData table
            InsertDataIntoWeightData(weightValue, KasutajaMoodul.loggedInID)
        End If

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        FilenameForm.Show()
    End Sub
End Class