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
        Me.fileNameLbl = New System.Windows.Forms.Label()
        Me.filepathTxt = New System.Windows.Forms.TextBox()
        Me.pathBtn = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'fileNameLbl
        '
        Me.fileNameLbl.AutoSize = True
        Me.fileNameLbl.Location = New System.Drawing.Point(84, 45)
        Me.fileNameLbl.Name = "fileNameLbl"
        Me.fileNameLbl.Size = New System.Drawing.Size(65, 16)
        Me.fileNameLbl.TabIndex = 0
        Me.fileNameLbl.Text = "Faili nimi: "
        '
        'filepathTxt
        '
        Me.filepathTxt.Location = New System.Drawing.Point(155, 45)
        Me.filepathTxt.Name = "filepathTxt"
        Me.filepathTxt.Size = New System.Drawing.Size(100, 22)
        Me.filepathTxt.TabIndex = 1
        '
        'pathBtn
        '
        Me.pathBtn.Location = New System.Drawing.Point(274, 33)
        Me.pathBtn.Name = "pathBtn"
        Me.pathBtn.Size = New System.Drawing.Size(75, 40)
        Me.pathBtn.TabIndex = 2
        Me.pathBtn.Text = "Select path"
        Me.pathBtn.UseVisualStyleBackColor = True
        '
        'FilenameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(429, 123)
        Me.Controls.Add(Me.pathBtn)
        Me.Controls.Add(Me.filepathTxt)
        Me.Controls.Add(Me.fileNameLbl)
        Me.Name = "FilenameForm"
        Me.Text = "FilenameForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents fileNameLbl As Windows.Forms.Label
    Friend WithEvents filepathTxt As Windows.Forms.TextBox
    Friend WithEvents pathBtn As Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As Windows.Forms.FolderBrowserDialog
End Class
