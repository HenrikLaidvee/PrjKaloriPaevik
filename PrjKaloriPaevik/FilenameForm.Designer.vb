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
        Me.chkExport1 = New System.Windows.Forms.CheckBox()
        Me.chkExport2 = New System.Windows.Forms.CheckBox()
        Me.btnSaveDll = New System.Windows.Forms.Button()
        Me.lblCurrentFilePath = New System.Windows.Forms.Label()
        Me.lblPath = New System.Windows.Forms.Label()
        Me.cmbDelimiter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPathSelect = New System.Windows.Forms.Button()
        Me.cmbEraldus = New System.Windows.Forms.ComboBox()
        Me.lblQualifier = New System.Windows.Forms.Label()
        Me.chkAppend = New System.Windows.Forms.CheckBox()
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
        Me.pathbtn.Location = New System.Drawing.Point(279, 48)
        Me.pathbtn.Name = "pathbtn"
        Me.pathbtn.Size = New System.Drawing.Size(79, 48)
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
        'chkExport1
        '
        Me.chkExport1.AutoSize = True
        Me.chkExport1.Location = New System.Drawing.Point(464, 63)
        Me.chkExport1.Name = "chkExport1"
        Me.chkExport1.Size = New System.Drawing.Size(192, 20)
        Me.chkExport1.TabIndex = 6
        Me.chkExport1.Text = "Kasuta kirjutatud funktsiooni"
        Me.chkExport1.UseVisualStyleBackColor = True
        '
        'chkExport2
        '
        Me.chkExport2.AutoSize = True
        Me.chkExport2.Location = New System.Drawing.Point(464, 233)
        Me.chkExport2.Name = "chkExport2"
        Me.chkExport2.Size = New System.Drawing.Size(185, 20)
        Me.chkExport2.TabIndex = 7
        Me.chkExport2.Text = "Kasuta valmis komponenti"
        Me.chkExport2.UseVisualStyleBackColor = True
        '
        'btnSaveDll
        '
        Me.btnSaveDll.Location = New System.Drawing.Point(279, 267)
        Me.btnSaveDll.Name = "btnSaveDll"
        Me.btnSaveDll.Size = New System.Drawing.Size(79, 41)
        Me.btnSaveDll.TabIndex = 8
        Me.btnSaveDll.Text = "Salvesta"
        Me.btnSaveDll.UseVisualStyleBackColor = True
        '
        'lblCurrentFilePath
        '
        Me.lblCurrentFilePath.AutoSize = True
        Me.lblCurrentFilePath.Location = New System.Drawing.Point(151, 200)
        Me.lblCurrentFilePath.Name = "lblCurrentFilePath"
        Me.lblCurrentFilePath.Size = New System.Drawing.Size(0, 16)
        Me.lblCurrentFilePath.TabIndex = 9
        '
        'lblPath
        '
        Me.lblPath.AutoSize = True
        Me.lblPath.Location = New System.Drawing.Point(36, 200)
        Me.lblPath.Name = "lblPath"
        Me.lblPath.Size = New System.Drawing.Size(90, 16)
        Me.lblPath.TabIndex = 10
        Me.lblPath.Text = "Faili teekond: "
        '
        'cmbDelimiter
        '
        Me.cmbDelimiter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDelimiter.FormattingEnabled = True
        Me.cmbDelimiter.Items.AddRange(New Object() {".", ",", ":"})
        Me.cmbDelimiter.Location = New System.Drawing.Point(123, 229)
        Me.cmbDelimiter.Name = "cmbDelimiter"
        Me.cmbDelimiter.Size = New System.Drawing.Size(121, 24)
        Me.cmbDelimiter.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Eraldaja: "
        '
        'btnPathSelect
        '
        Me.btnPathSelect.Location = New System.Drawing.Point(279, 193)
        Me.btnPathSelect.Name = "btnPathSelect"
        Me.btnPathSelect.Size = New System.Drawing.Size(79, 56)
        Me.btnPathSelect.TabIndex = 13
        Me.btnPathSelect.Text = "Vali teekond"
        Me.btnPathSelect.UseVisualStyleBackColor = True
        '
        'cmbEraldus
        '
        Me.cmbEraldus.FormattingEnabled = True
        Me.cmbEraldus.Location = New System.Drawing.Point(123, 267)
        Me.cmbEraldus.Name = "cmbEraldus"
        Me.cmbEraldus.Size = New System.Drawing.Size(121, 24)
        Me.cmbEraldus.TabIndex = 14
        '
        'lblQualifier
        '
        Me.lblQualifier.AutoSize = True
        Me.lblQualifier.Location = New System.Drawing.Point(20, 270)
        Me.lblQualifier.Name = "lblQualifier"
        Me.lblQualifier.Size = New System.Drawing.Size(97, 16)
        Me.lblQualifier.TabIndex = 15
        Me.lblQualifier.Text = "Eraldustunnus: "
        '
        'chkAppend
        '
        Me.chkAppend.AutoSize = True
        Me.chkAppend.Location = New System.Drawing.Point(123, 308)
        Me.chkAppend.Name = "chkAppend"
        Me.chkAppend.Size = New System.Drawing.Size(125, 20)
        Me.chkAppend.TabIndex = 16
        Me.chkAppend.Text = "Kirjutada lõppu?"
        Me.chkAppend.UseVisualStyleBackColor = True
        '
        'FilenameForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(687, 374)
        Me.Controls.Add(Me.chkAppend)
        Me.Controls.Add(Me.lblQualifier)
        Me.Controls.Add(Me.cmbEraldus)
        Me.Controls.Add(Me.btnPathSelect)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbDelimiter)
        Me.Controls.Add(Me.lblPath)
        Me.Controls.Add(Me.lblCurrentFilePath)
        Me.Controls.Add(Me.btnSaveDll)
        Me.Controls.Add(Me.chkExport2)
        Me.Controls.Add(Me.chkExport1)
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
    Friend WithEvents chkExport1 As CheckBox
    Friend WithEvents chkExport2 As CheckBox
    Friend WithEvents btnSaveDll As Button
    Friend WithEvents lblCurrentFilePath As Label
    Friend WithEvents lblPath As Label
    Friend WithEvents cmbDelimiter As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnPathSelect As Button
    Friend WithEvents cmbEraldus As ComboBox
    Friend WithEvents lblQualifier As Label
    Friend WithEvents chkAppend As CheckBox
End Class
