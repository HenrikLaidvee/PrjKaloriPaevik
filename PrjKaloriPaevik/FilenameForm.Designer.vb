<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FilenameForm
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pathbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.filepathtxt = New System.Windows.Forms.TextBox()
        Me.txtRidadeArv = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 63)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(8, 8)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'pathbtn
        '
        Me.pathbtn.Location = New System.Drawing.Point(279, 35)
        Me.pathbtn.Name = "pathbtn"
        Me.pathbtn.Size = New System.Drawing.Size(79, 64)
        Me.pathbtn.TabIndex = 1
        Me.pathbtn.Text = "Salvesta"
        Me.pathbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(54, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Faili nimi :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ridade arv : "
        '
        'filepathtxt
        '
        Me.filepathtxt.Location = New System.Drawing.Point(123, 35)
        Me.filepathtxt.Name = "filepathtxt"
        Me.filepathtxt.Size = New System.Drawing.Size(100, 22)
        Me.filepathtxt.TabIndex = 4
        '
        'txtRidadeArv
        '
        Me.txtRidadeArv.Location = New System.Drawing.Point(123, 80)
        Me.txtRidadeArv.Name = "txtRidadeArv"
        Me.txtRidadeArv.Size = New System.Drawing.Size(100, 22)
        Me.txtRidadeArv.TabIndex = 5
        '
        'FilenameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 176)
        Me.Controls.Add(Me.txtRidadeArv)
        Me.Controls.Add(Me.filepathtxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pathbtn)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FilenameForm"
        Me.Text = "FilenameForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents pathbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents filepathtxt As TextBox
    Friend WithEvents txtRidadeArv As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
