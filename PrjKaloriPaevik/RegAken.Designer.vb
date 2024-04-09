<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegAken
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblLastNameMaxWords = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.btncalculateAge = New System.Windows.Forms.Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblLimitReached = New System.Windows.Forms.Label()
        Me.btnSeePassword = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsernameMaxWords = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBack)
        Me.GroupBox1.Controls.Add(Me.txtHeight)
        Me.GroupBox1.Controls.Add(Me.btncalculateAge)
        Me.GroupBox1.Controls.Add(Me.lblHeight)
        Me.GroupBox1.Controls.Add(Me.lblLastNameMaxWords)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.cmbYear)
        Me.GroupBox1.Controls.Add(Me.cmbMonth)
        Me.GroupBox1.Controls.Add(Me.cmbDay)
        Me.GroupBox1.Controls.Add(Me.lblWeight)
        Me.GroupBox1.Controls.Add(Me.lblAge)
        Me.GroupBox1.Controls.Add(Me.txtWeight)
        Me.GroupBox1.Controls.Add(Me.lblLimitReached)
        Me.GroupBox1.Controls.Add(Me.btnSeePassword)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.lblPassword)
        Me.GroupBox1.Controls.Add(Me.lblUsernameMaxWords)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.btnCreateAccount)
        Me.GroupBox1.Controls.Add(Me.txtUsername)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(634, 367)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Kasutaja andmed"
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(156, 230)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(102, 30)
        Me.txtHeight.TabIndex = 22
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblHeight.Location = New System.Drawing.Point(25, 235)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(121, 25)
        Me.lblHeight.TabIndex = 21
        Me.lblHeight.Text = "Pikkus (cm):"
        '
        'lblLastNameMaxWords
        '
        Me.lblLastNameMaxWords.AutoSize = True
        Me.lblLastNameMaxWords.Location = New System.Drawing.Point(482, 87)
        Me.lblLastNameMaxWords.Name = "lblLastNameMaxWords"
        Me.lblLastNameMaxWords.Size = New System.Drawing.Size(34, 25)
        Me.lblLastNameMaxWords.TabIndex = 20
        Me.lblLastNameMaxWords.Text = "30"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblLastName.Location = New System.Drawing.Point(52, 82)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(94, 25)
        Me.lblLastName.TabIndex = 19
        Me.lblLastName.Text = "Perenimi:"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(156, 82)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(320, 30)
        Me.txtLastName.TabIndex = 18
        '
        'btncalculateAge
        '
        Me.btncalculateAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btncalculateAge.Location = New System.Drawing.Point(156, 277)
        Me.btncalculateAge.Name = "btncalculateAge"
        Me.btncalculateAge.Size = New System.Drawing.Size(322, 34)
        Me.btncalculateAge.TabIndex = 17
        Me.btncalculateAge.Text = "arvuta vanus"
        Me.btncalculateAge.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(374, 154)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(102, 33)
        Me.cmbYear.TabIndex = 16
        '
        'cmbMonth
        '
        Me.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(266, 154)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(102, 33)
        Me.cmbMonth.TabIndex = 15
        '
        'cmbDay
        '
        Me.cmbDay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(156, 154)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(102, 33)
        Me.cmbDay.TabIndex = 14
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblWeight.Location = New System.Drawing.Point(48, 197)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(98, 25)
        Me.lblWeight.TabIndex = 13
        Me.lblWeight.Text = "Kaal (kg):"
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblAge.Location = New System.Drawing.Point(2, 157)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(144, 25)
        Me.lblAge.TabIndex = 12
        Me.lblAge.Text = "Sünnikuupäev:"
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(156, 194)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(102, 30)
        Me.txtWeight.TabIndex = 11
        '
        'lblLimitReached
        '
        Me.lblLimitReached.AutoSize = True
        Me.lblLimitReached.Location = New System.Drawing.Point(203, 18)
        Me.lblLimitReached.Name = "lblLimitReached"
        Me.lblLimitReached.Size = New System.Drawing.Size(241, 25)
        Me.lblLimitReached.TabIndex = 9
        Me.lblLimitReached.Text = "Kasutajanime limiit on täis!"
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
        Me.lblUsernameMaxWords.Location = New System.Drawing.Point(482, 51)
        Me.lblUsernameMaxWords.Name = "lblUsernameMaxWords"
        Me.lblUsernameMaxWords.Size = New System.Drawing.Size(34, 25)
        Me.lblUsernameMaxWords.TabIndex = 3
        Me.lblUsernameMaxWords.Text = "30"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.lblFirstName.Location = New System.Drawing.Point(59, 51)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(87, 25)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "Eesnimi:"
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Location = New System.Drawing.Point(266, 194)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(212, 66)
        Me.btnCreateAccount.TabIndex = 0
        Me.btnCreateAccount.Text = "Loo kasutaja"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(156, 46)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(320, 30)
        Me.txtUsername.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnBack.Location = New System.Drawing.Point(156, 317)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(322, 33)
        Me.btnBack.TabIndex = 23
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'RegAken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 388)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RegAken"
        Me.Text = "RegAken"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents lblUsernameMaxWords As Label
    Friend WithEvents lblPassword As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnSeePassword As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblLimitReached As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents cmbYear As ComboBox
    Friend WithEvents cmbMonth As ComboBox
    Friend WithEvents cmbDay As ComboBox
    Friend WithEvents btncalculateAge As Button
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastNameMaxWords As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents lblHeight As Label
    Friend WithEvents btnBack As Button
End Class
