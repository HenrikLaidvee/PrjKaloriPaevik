<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnKaal = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtMotivate = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
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
        Me.Label4.Location = New System.Drawing.Point(34, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(184, 25)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Päevane kalorilimiit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label5.Location = New System.Drawing.Point(24, 235)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(192, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Limiidini veel jäänud:"
        '
        'txtCalorieLimit
        '
        Me.txtCalorieLimit.Enabled = False
        Me.txtCalorieLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCalorieLimit.Location = New System.Drawing.Point(222, 193)
        Me.txtCalorieLimit.Name = "txtCalorieLimit"
        Me.txtCalorieLimit.Size = New System.Drawing.Size(100, 30)
        Me.txtCalorieLimit.TabIndex = 13
        '
        'txtCaloriesLeft
        '
        Me.txtCaloriesLeft.Enabled = False
        Me.txtCaloriesLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCaloriesLeft.Location = New System.Drawing.Point(222, 235)
        Me.txtCaloriesLeft.Name = "txtCaloriesLeft"
        Me.txtCaloriesLeft.Size = New System.Drawing.Size(100, 30)
        Me.txtCaloriesLeft.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnKaal)
        Me.GroupBox1.Controls.Add(Me.btnLogIn)
        Me.GroupBox1.Controls.Add(Me.btnLogFood)
        Me.GroupBox1.Controls.Add(Me.btnCreateUser)
        Me.GroupBox1.Controls.Add(Me.btnProfile)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 410)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Menüü"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox3)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
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
        Me.GroupBox2.Size = New System.Drawing.Size(487, 410)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tänane statistika"
        '
        'btnKaal
        '
        Me.btnKaal.Location = New System.Drawing.Point(18, 320)
        Me.btnKaal.Margin = New System.Windows.Forms.Padding(2)
        Me.btnKaal.Name = "btnKaal"
        Me.btnKaal.Size = New System.Drawing.Size(137, 67)
        Me.btnKaal.TabIndex = 15
        Me.btnKaal.Text = "Kaalu statistika"
        Me.btnKaal.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtMotivate)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(25, 458)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(702, 198)
        Me.GroupBox3.TabIndex = 18
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Tänane motiveeriv sõnum"
        '
        'txtMotivate
        '
        Me.txtMotivate.Location = New System.Drawing.Point(6, 29)
        Me.txtMotivate.Name = "txtMotivate"
        Me.txtMotivate.Size = New System.Drawing.Size(690, 163)
        Me.txtMotivate.TabIndex = 0
        Me.txtMotivate.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TextBox1.Location = New System.Drawing.Point(222, 313)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 30)
        Me.TextBox1.TabIndex = 18
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TextBox2.Location = New System.Drawing.Point(222, 271)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 30)
        Me.TextBox2.TabIndex = 17
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label6.Location = New System.Drawing.Point(132, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 25)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Rasvad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label7.Location = New System.Drawing.Point(92, 271)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Süsivesikud:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.TextBox3.Location = New System.Drawing.Point(222, 349)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 30)
        Me.TextBox3.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label8.Location = New System.Drawing.Point(136, 349)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 25)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Valgud:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(751, 668)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
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
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtMotivate As RichTextBox
End Class
