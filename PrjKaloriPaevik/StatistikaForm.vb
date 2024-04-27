﻿Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class StatistikaForm
    Private Sub StatistikaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Connect to your Access database
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\janml\OneDrive\Desktop\Kool\Tarkvaratehnika\ToiduTest.accdb;"
        Dim connection As New OleDbConnection(connectionString)
        connection.Open()

        ' Retrieve data from the database
        Dim command As New OleDbCommand("SELECT Kuupäev, Kaal FROM KaaluAndmed", connection)
        Dim reader As OleDbDataReader = command.ExecuteReader()

        ' Check if the series exists or create it if necessary
        If Chart1.Series.IndexOf("Kaal") = -1 Then
            ' If the series does not exist, create it
            Chart1.Series.Add("Kaal")
        End If

        ' Bind data to the chart
        Chart1.DataSource = reader
        Chart1.Series("Kaal").XValueMember = "Kuupäev"
        Chart1.Series("Kaal").YValueMembers = "Kaal"
        Chart1.DataBind()

        ' Close the connection
        connection.Close()

        ' Customize chart appearance
        Chart1.ChartAreas(0).AxisX.Title = "Kuupäev"
        Chart1.ChartAreas(0).AxisY.Title = "Kaal (kg)"
        Chart1.ChartAreas(0).AxisX.LabelStyle.Format = "dd/MM/yyyy"
        Chart1.ChartAreas(0).AxisX.Interval = 1
        Chart1.ChartAreas(0).AxisY.Interval = 5
        Chart1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.LightGray
        Chart1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.LightGray
        Chart1.Series("Kaal").Color = Color.Blue
        Chart1.Series("Kaal").BorderWidth = 2
        Chart1.Series("Kaal").ChartType = DataVisualization.Charting.SeriesChartType.Line
        Chart1.Dock = DockStyle.Fill
    End Sub
End Class
