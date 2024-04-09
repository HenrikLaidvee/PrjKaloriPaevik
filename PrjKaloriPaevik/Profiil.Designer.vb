<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profiil
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
        Me.gbProfile = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel3 = New System.Windows.Forms.LinkLabel()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.LinkLabel4 = New System.Windows.Forms.LinkLabel()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.gbProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbProfile
        '
        Me.gbProfile.Controls.Add(Me.lblWeight)
        Me.gbProfile.Controls.Add(Me.LinkLabel4)
        Me.gbProfile.Controls.Add(Me.lbl4)
        Me.gbProfile.Controls.Add(Me.lblDate)
        Me.gbProfile.Controls.Add(Me.lblPassword)
        Me.gbProfile.Controls.Add(Me.lblUsername)
        Me.gbProfile.Controls.Add(Me.LinkLabel3)
        Me.gbProfile.Controls.Add(Me.LinkLabel2)
        Me.gbProfile.Controls.Add(Me.lbl3)
        Me.gbProfile.Controls.Add(Me.lbl2)
        Me.gbProfile.Controls.Add(Me.lbl1)
        Me.gbProfile.Controls.Add(Me.LinkLabel1)
        Me.gbProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.gbProfile.Location = New System.Drawing.Point(170, 12)
        Me.gbProfile.Name = "gbProfile"
        Me.gbProfile.Size = New System.Drawing.Size(292, 364)
        Me.gbProfile.TabIndex = 0
        Me.gbProfile.TabStop = False
        Me.gbProfile.Text = "Profiili andmed"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LinkLabel1.Location = New System.Drawing.Point(146, 51)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(109, 17)
        Me.LinkLabel1.TabIndex = 0
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Muuda andmeid"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 44)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(124, 25)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Kasutajanimi"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(9, 116)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(68, 25)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Parool"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(6, 187)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(138, 25)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "Sünnikuupäev"
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LinkLabel2.Location = New System.Drawing.Point(149, 123)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(109, 17)
        Me.LinkLabel2.TabIndex = 4
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Muuda andmeid"
        '
        'LinkLabel3
        '
        Me.LinkLabel3.AutoSize = True
        Me.LinkLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LinkLabel3.Location = New System.Drawing.Point(146, 194)
        Me.LinkLabel3.Name = "LinkLabel3"
        Me.LinkLabel3.Size = New System.Drawing.Size(109, 17)
        Me.LinkLabel3.TabIndex = 5
        Me.LinkLabel3.TabStop = True
        Me.LinkLabel3.Text = "Muuda andmeid"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(9, 78)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(50, 25)
        Me.lblUsername.TabIndex = 6
        Me.lblUsername.Text = "Nimi"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(9, 151)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 25)
        Me.lblPassword.TabIndex = 7
        Me.lblPassword.Text = "Parool"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(9, 226)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 25)
        Me.lblDate.TabIndex = 8
        Me.lblDate.Text = "Kuupäev"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(9, 268)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(52, 25)
        Me.lbl4.TabIndex = 9
        Me.lbl4.Text = "Kaal"
        '
        'LinkLabel4
        '
        Me.LinkLabel4.AutoSize = True
        Me.LinkLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LinkLabel4.Location = New System.Drawing.Point(146, 276)
        Me.LinkLabel4.Name = "LinkLabel4"
        Me.LinkLabel4.Size = New System.Drawing.Size(109, 17)
        Me.LinkLabel4.TabIndex = 10
        Me.LinkLabel4.TabStop = True
        Me.LinkLabel4.Text = "Muuda andmeid"
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(9, 304)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(52, 25)
        Me.lblWeight.TabIndex = 11
        Me.lblWeight.Text = "Kaal"
        '
        'Profiil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 450)
        Me.Controls.Add(Me.gbProfile)
        Me.Name = "Profiil"
        Me.Text = "Profiil"
        Me.gbProfile.ResumeLayout(False)
        Me.gbProfile.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbProfile As GroupBox
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblUsername As Label
    Friend WithEvents LinkLabel3 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents lblPassword As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents LinkLabel4 As LinkLabel
    Friend WithEvents lbl4 As Label
    Friend WithEvents lblWeight As Label
End Class
