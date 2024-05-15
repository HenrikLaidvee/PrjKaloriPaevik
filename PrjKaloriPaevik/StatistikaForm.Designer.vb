<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StatistikaForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chkPiir = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblMaxKaal = New System.Windows.Forms.Label()
        Me.lblMinKaal = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(14, 2)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Enabled = False
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(873, 556)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'chkPiir
        '
        Me.chkPiir.AutoSize = True
        Me.chkPiir.Location = New System.Drawing.Point(718, 92)
        Me.chkPiir.Name = "chkPiir"
        Me.chkPiir.Size = New System.Drawing.Size(150, 24)
        Me.chkPiir.TabIndex = 1
        Me.chkPiir.Text = "Kuva piirnäitajad"
        Me.chkPiir.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(714, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Max kaal: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(714, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Min kaal: "
        '
        'lblMaxKaal
        '
        Me.lblMaxKaal.AutoSize = True
        Me.lblMaxKaal.Location = New System.Drawing.Point(799, 178)
        Me.lblMaxKaal.Name = "lblMaxKaal"
        Me.lblMaxKaal.Size = New System.Drawing.Size(0, 20)
        Me.lblMaxKaal.TabIndex = 4
        '
        'lblMinKaal
        '
        Me.lblMinKaal.AutoSize = True
        Me.lblMinKaal.Location = New System.Drawing.Point(799, 221)
        Me.lblMinKaal.Name = "lblMinKaal"
        Me.lblMinKaal.Size = New System.Drawing.Size(0, 20)
        Me.lblMinKaal.TabIndex = 5
        '
        'StatistikaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(900, 562)
        Me.Controls.Add(Me.lblMinKaal)
        Me.Controls.Add(Me.lblMaxKaal)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkPiir)
        Me.Controls.Add(Me.Chart1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "StatistikaForm"
        Me.Text = "StatistikaForm"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents chkPiir As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblMaxKaal As Label
    Friend WithEvents lblMinKaal As Label
End Class
