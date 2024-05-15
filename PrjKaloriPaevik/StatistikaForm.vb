Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class StatistikaForm
    Private Sub StatistikaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to your Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janlep\Desktop\ToiduAndmebaas.accdb;"
        'Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduAndmebaas.accdb;"
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()

        ' Retrieve data from the database
        Dim command As New OleDbCommand("SELECT Kuupäev, BMI FROM KaaluAndmed WHERE Kasutaja_ID = @id", connection)
        Dim commandMax As New OleDbCommand("SELECT Max(Kaal) AS maxKaal FROM KaaluAndmed WHERE Kasutaja_ID = @id", connection)
        Dim commandMin As New OleDbCommand("SELECT Min(Kaal) AS minKaal FROM KaaluAndmed WHERE Kasutaja_ID = @id", connection)
        command.Parameters.AddWithValue("@id", KasutajaMoodul.loggedInID)
        commandMax.Parameters.AddWithValue("@id", KasutajaMoodul.loggedInID)
        commandMin.Parameters.AddWithValue("@id", KasutajaMoodul.loggedInID)


        Dim reader As OleDbDataReader = command.ExecuteReader()

        Dim maxKaal As Integer = Convert.ToInt32(commandMax.ExecuteScalar())
        Dim minKaal As Integer = Convert.ToInt32(commandMin.ExecuteScalar())
        ' Check if the series exists or create it if necessary
        If Chart1.Series.IndexOf("BMI") = -1 Then
            ' If the series does not exist, create it
            Chart1.Series.Add("BMI")
        End If

        ' Check if the series exists or create it if necessary
        If Chart1.Series.IndexOf("Alakaal") = -1 Then
            ' If the series does not exist, create it
            Chart1.Series.Add("Alakaal")
        End If
        ' Check if the series exists or create it if necessary
        If Chart1.Series.IndexOf("Ülekaal") = -1 Then
            ' If the series does not exist, create it
            Chart1.Series.Add("Ülekaal")
        End If

        Const yleKaal As Double = 25
        Const alaKaal As Double = 20
        ' Bind data to the chart
        Chart1.DataSource = reader
        Chart1.Series("BMI").XValueMember = "Kuupäev"
        Chart1.Series("BMI").YValueMembers = "BMI"

        'Chart1.Series("Alakaal").XValueMember = "Kuupäev"
        'Chart1.Series("Alakaal").YValueMembers = yleKaal

        'Chart1.Series("Ülekaal").XValueMember = "Kuupäev"
        'Chart1.Series("Ülekaal").YValueMembers = alaKaal

        Chart1.DataBind()

        ' Close the connection
        connection.Close()

        ' Customize chart appearance

        Chart1.ChartAreas(0).AxisX.Title = "Kuupäev"
        Chart1.ChartAreas(0).AxisY.Title = "BMI"
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "dd/MM/yyyy"
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisY.Interval = 5
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        Chart1.Series("BMI").Color = Color.Blue
        Chart1.Series("BMI").BorderWidth = 2

        Chart1.Series("BMI").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Dock = DockStyle.Fill
        If Not chkPiir.Checked Then

            Dim horizontalLineÜlekaal As HorizontalLineAnnotation = New HorizontalLineAnnotation()
            horizontalLineÜlekaal.AxisY = Chart1.ChartAreas(0).AxisY
            horizontalLineÜlekaal.IsInfinitive = True
            horizontalLineÜlekaal.ClipToChartArea = Chart1.ChartAreas(0).Name
            horizontalLineÜlekaal.LineColor = Color.Red
            horizontalLineÜlekaal.LineWidth = 1
            horizontalLineÜlekaal.Y = yleKaal
            Chart1.Annotations.Add(horizontalLineÜlekaal)

            Dim horizontalLineAlakaal As HorizontalLineAnnotation = New HorizontalLineAnnotation()
            horizontalLineAlakaal.AxisY = Chart1.ChartAreas(0).AxisY
            horizontalLineAlakaal.IsInfinitive = True
            horizontalLineAlakaal.ClipToChartArea = Chart1.ChartAreas(0).Name
            horizontalLineAlakaal.LineColor = Color.Orange
            horizontalLineAlakaal.LineWidth = 1
            horizontalLineAlakaal.Y = alaKaal
            Chart1.Annotations.Add(horizontalLineAlakaal)

            'Chart1.Series("Alakaal").Color = Color.Red
            'Chart1.Series("Alakaal").BorderWidth = 1

            'Chart1.Series("Ülekaal").Color = Color.DeepPink
            'Chart1.Series("Ülekaal").BorderWidth = 1


        End If


        lblMaxKaal.Text = maxKaal
        lblMinKaal.Text = minKaal

        'Label1.Dock = DockStyle.Fill
        'Label2.Dock = DockStyle.Fill
        'lblMaxKaal.Dock = DockStyle.Fill
        'lblMinKaal.Dock = DockStyle.Fill
    End Sub

    Private Sub chkPiir_CheckedChanged(sender As Object, e As EventArgs) Handles chkPiir.CheckedChanged

    End Sub
End Class
