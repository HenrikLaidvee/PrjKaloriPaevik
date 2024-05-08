<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
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
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.btnCreateUser = New System.Windows.Forms.Button()
        Me.btnLogFood = New System.Windows.Forms.Button()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCurrentWeight = New System.Windows.Forms.TextBox()
        Me.txtGoalWeight = New System.Windows.Forms.TextBox()
        Me.txtNeedToLose = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCalorieLimit = New System.Windows.Forms.TextBox()
        Me.txtCaloriesLeft = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnKaal = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSugarLeft = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSugarLimit = New System.Windows.Forms.TextBox()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtCarbs = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnDownload = New System.Windows.Forms.Button()
        Me.btnDownload2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMotivate = New System.Windows.Forms.RichTextBox()
        Me.chartMakro = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.chartMakro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnProfile.Location = New System.Drawing.Point(18, 34)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(137, 51)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Profiil"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCreateUser.Location = New System.Drawing.Point(18, 106)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(137, 51)
        Me.btnCreateUser.TabIndex = 1
        Me.btnCreateUser.Text = "Tee kasutaja"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnLogFood
        '
        Me.btnLogFood.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnLogFood.Location = New System.Drawing.Point(18, 178)
        Me.btnLogFood.Name = "btnLogFood"
        Me.btnLogFood.Size = New System.Drawing.Size(137, 51)
        Me.btnLogFood.TabIndex = 2
        Me.btnLogFood.Text = "Lisa toit"
        Me.btnLogFood.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnLogIn.Location = New System.Drawing.Point(18, 250)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(137, 51)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Logi sisse"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(72, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Praegune kaal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(72, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Soovitud kaal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label3.Location = New System.Drawing.Point(34, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Veel vaja kaotada:"
        '
        'txtCurrentWeight
        '
        Me.txtCurrentWeight.Enabled = False
        Me.txtCurrentWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCurrentWeight.Location = New System.Drawing.Point(222, 30)
        Me.txtCurrentWeight.Name = "txtCurrentWeight"
        Me.txtCurrentWeight.Size = New System.Drawing.Size(100, 30)
        Me.txtCurrentWeight.TabIndex = 7
        '
        'txtGoalWeight
        '
        Me.txtGoalWeight.Enabled = False
        Me.txtGoalWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtGoalWeight.Location = New System.Drawing.Point(222, 75)
        Me.txtGoalWeight.Name = "txtGoalWeight"
        Me.txtGoalWeight.Size = New System.Drawing.Size(100, 30)
        Me.txtGoalWeight.TabIndex = 8
        '
        'txtNeedToLose
        '
        Me.txtNeedToLose.Enabled = False
        Me.txtNeedToLose.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtNeedToLose.Location = New System.Drawing.Point(222, 120)
        Me.txtNeedToLose.Name = "txtNeedToLose"
        Me.txtNeedToLose.Size = New System.Drawing.Size(100, 30)
        Me.txtNeedToLose.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(34, 180)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Päevane kalorilimiit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(26, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Limiidini veel jäänud:"
        '
        'txtCalorieLimit
        '
        Me.txtCalorieLimit.Enabled = False
        Me.txtCalorieLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCalorieLimit.Location = New System.Drawing.Point(222, 178)
        Me.txtCalorieLimit.Name = "txtCalorieLimit"
        Me.txtCalorieLimit.Size = New System.Drawing.Size(100, 30)
        Me.txtCalorieLimit.TabIndex = 13
        '
        'txtCaloriesLeft
        '
        Me.txtCaloriesLeft.Enabled = False
        Me.txtCaloriesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCaloriesLeft.Location = New System.Drawing.Point(222, 214)
        Me.txtCaloriesLeft.Name = "txtCaloriesLeft"
        Me.txtCaloriesLeft.Size = New System.Drawing.Size(100, 30)
        Me.txtCaloriesLeft.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogOut)
        Me.GroupBox1.Controls.Add(Me.btnExport)
        Me.GroupBox1.Controls.Add(Me.btnLogIn)
        Me.GroupBox1.Controls.Add(Me.btnLogFood)
        Me.GroupBox1.Controls.Add(Me.btnCreateUser)
        Me.GroupBox1.Controls.Add(Me.btnProfile)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 486)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menüü"
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(18, 398)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(137, 51)
        Me.btnLogOut.TabIndex = 5
        Me.btnLogOut.Text = "Logi välja"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(18, 327)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(137, 51)
        Me.btnExport.TabIndex = 4
        Me.btnExport.Text = "Lae alla"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnKaal
        '
        Me.btnKaal.Location = New System.Drawing.Point(650, 361)
        Me.btnKaal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKaal.Name = "btnKaal"
        Me.btnKaal.Size = New System.Drawing.Size(137, 67)
        Me.btnKaal.TabIndex = 15
        Me.btnKaal.Text = "Kaalu statistika"
        Me.btnKaal.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtSugarLeft)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtSugarLimit)
        Me.GroupBox2.Controls.Add(Me.txtProtein)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtFat)
        Me.GroupBox2.Controls.Add(Me.txtCarbs)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.btnDownload)
        Me.GroupBox2.Controls.Add(Me.txtCaloriesLeft)
        Me.GroupBox2.Controls.Add(Me.txtCalorieLimit)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNeedToLose)
        Me.GroupBox2.Controls.Add(Me.txtGoalWeight)
        Me.GroupBox2.Controls.Add(Me.txtCurrentWeight)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(240, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(338, 434)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tänane statistika"
        '
        'txtSugarLeft
        '
        Me.txtSugarLeft.Location = New System.Drawing.Point(222, 288)
        Me.txtSugarLeft.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSugarLeft.Name = "txtSugarLeft"
        Me.txtSugarLeft.Size = New System.Drawing.Size(100, 30)
        Me.txtSugarLeft.TabIndex = 24
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(26, 288)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(192, 25)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Limiidini veel jäänud:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 250)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(197, 25)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Päevane suhkrulimiit:"
        '
        'txtSugarLimit
        '
        Me.txtSugarLimit.Location = New System.Drawing.Point(222, 250)
        Me.txtSugarLimit.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSugarLimit.Name = "txtSugarLimit"
        Me.txtSugarLimit.Size = New System.Drawing.Size(100, 30)
        Me.txtSugarLimit.TabIndex = 21
        '
        'txtProtein
        '
        Me.txtProtein.Enabled = False
        Me.txtProtein.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtProtein.Location = New System.Drawing.Point(222, 398)
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(100, 30)
        Me.txtProtein.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(135, 398)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Valgud:"
        '
        'txtFat
        '
        Me.txtFat.Enabled = False
        Me.txtFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtFat.Location = New System.Drawing.Point(222, 362)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 30)
        Me.txtFat.TabIndex = 18
        '
        'txtCarbs
        '
        Me.txtCarbs.Enabled = False
        Me.txtCarbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCarbs.Location = New System.Drawing.Point(222, 327)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(100, 30)
        Me.txtCarbs.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(130, 365)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Rasvad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(92, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Süsivesikud:"
        '
        'btnDownload
        '
        Me.btnDownload.Location = New System.Drawing.Point(368, 148)
        Me.btnDownload.Name = "btnDownload"
        Me.btnDownload.Size = New System.Drawing.Size(95, 63)
        Me.btnDownload.TabIndex = 16
        Me.btnDownload.Text = "Lae alla"
        Me.btnDownload.UseVisualStyleBackColor = True
        '
        'btnDownload2
        '
        Me.btnDownload2.Location = New System.Drawing.Point(466, 254)
        Me.btnDownload2.Name = "btnDownload2"
        Me.btnDownload2.Size = New System.Drawing.Size(147, 98)
        Me.btnDownload2.TabIndex = 21
        Me.btnDownload2.Text = "Export"
        Me.btnDownload2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMotivate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 530)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(851, 198)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tänane motiveeriv sõnum"
        '
        'txtMotivate
        '
        Me.txtMotivate.Location = New System.Drawing.Point(6, 29)
        Me.txtMotivate.Name = "txtMotivate"
        Me.txtMotivate.Size = New System.Drawing.Size(830, 163)
        Me.txtMotivate.TabIndex = 0
        Me.txtMotivate.Text = ""
        '
        'chartMakro
        '
        Me.chartMakro.BackColor = System.Drawing.Color.Transparent
        Me.chartMakro.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea2.BackSecondaryColor = System.Drawing.Color.Transparent
        ChartArea2.Name = "ChartArea1"
        Me.chartMakro.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Legend2.TitleBackColor = System.Drawing.Color.Transparent
        Me.chartMakro.Legends.Add(Legend2)
        Me.chartMakro.Location = New System.Drawing.Point(584, 30)
        Me.chartMakro.Margin = New System.Windows.Forms.Padding(2)
        Me.chartMakro.Name = "chartMakro"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series2.Legend = "Legend1"
        Series2.Name = "series"
        Me.chartMakro.Series.Add(Series2)
        Me.chartMakro.Size = New System.Drawing.Size(304, 289)
        Me.chartMakro.TabIndex = 19
        Me.chartMakro.Text = "Chart1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 740)
        Me.Controls.Add(Me.chartMakro)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnKaal)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.chartMakro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnProfile As Button
    Friend WithEvents btnCreateUser As Button
    Friend WithEvents btnLogFood As Button
    Friend WithEvents btnLogIn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCurrentWeight As TextBox
    Friend WithEvents txtGoalWeight As TextBox
    Friend WithEvents txtNeedToLose As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCalorieLimit As TextBox
    Friend WithEvents txtCaloriesLeft As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnKaal As Button
    Friend WithEvents txtProtein As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtFat As TextBox
    Friend WithEvents txtCarbs As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMotivate As RichTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSugarLimit As TextBox
    Friend WithEvents txtSugarLeft As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents chartMakro As DataVisualization.Charting.Chart
    Friend WithEvents btnDownload As Button
    Friend WithEvents btnDownload2 As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnLogOut As Button
End Class
