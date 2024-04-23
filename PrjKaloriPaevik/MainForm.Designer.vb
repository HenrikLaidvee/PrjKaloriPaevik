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
        Me.txtMotivation = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCalorieLimit = New System.Windows.Forms.TextBox()
        Me.txtCaloriesLeft = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnProfile
        '
        Me.btnProfile.Location = New System.Drawing.Point(42, 48)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(137, 51)
        Me.btnProfile.TabIndex = 0
        Me.btnProfile.Text = "Profiil"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'btnCreateUser
        '
        Me.btnCreateUser.Location = New System.Drawing.Point(42, 120)
        Me.btnCreateUser.Name = "btnCreateUser"
        Me.btnCreateUser.Size = New System.Drawing.Size(137, 51)
        Me.btnCreateUser.TabIndex = 1
        Me.btnCreateUser.Text = "Tee kasutaja"
        Me.btnCreateUser.UseVisualStyleBackColor = True
        '
        'btnLogFood
        '
        Me.btnLogFood.Location = New System.Drawing.Point(42, 192)
        Me.btnLogFood.Name = "btnLogFood"
        Me.btnLogFood.Size = New System.Drawing.Size(137, 51)
        Me.btnLogFood.TabIndex = 2
        Me.btnLogFood.Text = "Lisa toit"
        Me.btnLogFood.UseVisualStyleBackColor = True
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(42, 264)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(137, 51)
        Me.btnLogIn.TabIndex = 3
        Me.btnLogIn.Text = "Logi sisse"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Praegune kaal:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(325, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Soovitud kaal:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(325, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Veel vaja kaotada:"
        '
        'txtCurrentWeight
        '
        Me.txtCurrentWeight.Enabled = False
        Me.txtCurrentWeight.Location = New System.Drawing.Point(462, 48)
        Me.txtCurrentWeight.Name = "txtCurrentWeight"
        Me.txtCurrentWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrentWeight.TabIndex = 7
        '
        'txtGoalWeight
        '
        Me.txtGoalWeight.Enabled = False
        Me.txtGoalWeight.Location = New System.Drawing.Point(462, 93)
        Me.txtGoalWeight.Name = "txtGoalWeight"
        Me.txtGoalWeight.Size = New System.Drawing.Size(100, 20)
        Me.txtGoalWeight.TabIndex = 8
        '
        'txtNeedToLose
        '
        Me.txtNeedToLose.Enabled = False
        Me.txtNeedToLose.Location = New System.Drawing.Point(462, 138)
        Me.txtNeedToLose.Name = "txtNeedToLose"
        Me.txtNeedToLose.Size = New System.Drawing.Size(100, 20)
        Me.txtNeedToLose.TabIndex = 9
        '
        'txtMotivation
        '
        Me.txtMotivation.Enabled = False
        Me.txtMotivation.Location = New System.Drawing.Point(237, 374)
        Me.txtMotivation.Name = "txtMotivation"
        Me.txtMotivation.Size = New System.Drawing.Size(447, 20)
        Me.txtMotivation.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(321, 211)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Päevane kalorilimiit:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(317, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Limiidini veel jäänud:"
        '
        'txtCalorieLimit
        '
        Me.txtCalorieLimit.Enabled = False
        Me.txtCalorieLimit.Location = New System.Drawing.Point(462, 211)
        Me.txtCalorieLimit.Name = "txtCalorieLimit"
        Me.txtCalorieLimit.Size = New System.Drawing.Size(100, 20)
        Me.txtCalorieLimit.TabIndex = 13
        '
        'txtCaloriesLeft
        '
        Me.txtCaloriesLeft.Enabled = False
        Me.txtCaloriesLeft.Location = New System.Drawing.Point(462, 253)
        Me.txtCaloriesLeft.Name = "txtCaloriesLeft"
        Me.txtCaloriesLeft.Size = New System.Drawing.Size(100, 20)
        Me.txtCaloriesLeft.TabIndex = 14
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtCaloriesLeft)
        Me.Controls.Add(Me.txtCalorieLimit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMotivation)
        Me.Controls.Add(Me.txtNeedToLose)
        Me.Controls.Add(Me.txtGoalWeight)
        Me.Controls.Add(Me.txtCurrentWeight)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogIn)
        Me.Controls.Add(Me.btnLogFood)
        Me.Controls.Add(Me.btnCreateUser)
        Me.Controls.Add(Me.btnProfile)
        Me.Name = "MainForm"
        Me.Text = "MainForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Friend WithEvents txtMotivation As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtCalorieLimit As TextBox
    Friend WithEvents txtCaloriesLeft As TextBox
End Class
