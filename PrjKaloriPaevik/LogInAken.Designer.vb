<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LogInAken
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.lblLimitReached = New System.Windows.Forms.Label()
        Me.btnSeePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsernameMaxWords = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogIn)
        Me.GroupBox1.Controls.Add(Me.lblLimitReached)
        Me.GroupBox1.Controls.Add(Me.btnSeePassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsernameMaxWords)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.txtEmail)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(643, 270)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kasutaja andmed"
        '
        'btnLogIn
        '
        Me.btnLogIn.Location = New System.Drawing.Point(156, 163)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(320, 34)
        Me.btnLogIn.TabIndex = 21
        Me.btnLogIn.Text = "Log in"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'lblLimitReached
        '
        Me.lblLimitReached.AutoSize = True
        Me.lblLimitReached.Location = New System.Drawing.Point(232, 41)
        Me.lblLimitReached.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLimitReached.Name = "lblLimitReached"
        Me.lblLimitReached.Size = New System.Drawing.Size(174, 25)
        Me.lblLimitReached.TabIndex = 9
        Me.lblLimitReached.Text = "Emaili limiit on täis!"
        '
        'btnSeePassword
        '
        Me.btnSeePassword.Location = New System.Drawing.Point(482, 118)
        Me.btnSeePassword.Name = "btnSeePassword"
        Me.btnSeePassword.Size = New System.Drawing.Size(137, 30)
        Me.btnSeePassword.TabIndex = 8
        Me.btnSeePassword.Text = "Vaata parooli"
        Me.btnSeePassword.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(454, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 25)
        Me.Label1.TabIndex = 7
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(156, 118)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(320, 30)
        Me.txtPassword.TabIndex = 6
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblPassword.Location = New System.Drawing.Point(72, 121)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(74, 25)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Parool:"
        '
        'lblUsernameMaxWords
        '
        Me.lblUsernameMaxWords.AutoSize = True
        Me.lblUsernameMaxWords.Location = New System.Drawing.Point(492, 86)
        Me.lblUsernameMaxWords.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblUsernameMaxWords.Name = "lblUsernameMaxWords"
        Me.lblUsernameMaxWords.Size = New System.Drawing.Size(34, 25)
        Me.lblUsernameMaxWords.TabIndex = 3
        Me.lblUsernameMaxWords.Text = "50"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(80, 83)
        Me.lblFirstName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(66, 25)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(156, 83)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(320, 30)
        Me.txtEmail.TabIndex = 1
        '
        'LogInAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 292)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "LogInAken"
        Me.Text = "LogInAken"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnLogIn As Button
    Friend WithEvents lblLimitReached As Label
    Friend WithEvents btnSeePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblUsernameMaxWords As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtEmail As TextBox
End Class
