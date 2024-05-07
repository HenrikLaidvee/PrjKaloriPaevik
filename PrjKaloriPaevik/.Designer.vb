<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.ToitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodDataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.txtSugar = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSResult = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWResult = New System.Windows.Forms.TextBox()
        Me.txtFResult = New System.Windows.Forms.TextBox()
        Me.txtFoodID = New System.Windows.Forms.TextBox()
        Me.txtEResult = New System.Windows.Forms.TextBox()
        Me.txtCResult = New System.Windows.Forms.TextBox()
        Me.txtPResult = New System.Windows.Forms.TextBox()
        Me.txtFat = New System.Windows.Forms.TextBox()
        Me.txtCarbs = New System.Windows.Forms.TextBox()
        Me.txtProtein = New System.Windows.Forms.TextBox()
        Me.txtEnergy = New System.Windows.Forms.TextBox()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbAmount = New System.Windows.Forms.ComboBox()
        Me.txtSisestus = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ToitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToitBindingSource
        '
        Me.ToitBindingSource.DataMember = "Toit"
        '
        'FoodDataBindingSource2
        '
        Me.FoodDataBindingSource2.DataMember = "FoodData"
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Menu
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 494)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(1084, 81)
        Me.RichTextBox2.TabIndex = 35
        Me.RichTextBox2.Text = ""
        '
        'txtWeight
        '
        Me.txtWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtWeight.Location = New System.Drawing.Point(620, 512)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(100, 30)
        Me.txtWeight.TabIndex = 34
        '
        'txtSugar
        '
        Me.txtSugar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSugar.Location = New System.Drawing.Point(514, 512)
        Me.txtSugar.Name = "txtSugar"
        Me.txtSugar.Size = New System.Drawing.Size(100, 30)
        Me.txtSugar.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtSResult)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtWResult)
        Me.GroupBox1.Controls.Add(Me.txtFResult)
        Me.GroupBox1.Controls.Add(Me.txtFoodID)
        Me.GroupBox1.Controls.Add(Me.txtEResult)
        Me.GroupBox1.Controls.Add(Me.txtCResult)
        Me.GroupBox1.Controls.Add(Me.txtPResult)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 581)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1087, 98)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Andmed ning koguse arvutused"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(920, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 25)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Suhkrud (g)"
        '
        'txtSResult
        '
        Me.txtSResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSResult.Location = New System.Drawing.Point(925, 62)
        Me.txtSResult.Name = "txtSResult"
        Me.txtSResult.Size = New System.Drawing.Size(155, 30)
        Me.txtSResult.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(759, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 25)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Rasvad (g)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(598, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Süsivesikud (g)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(437, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 25)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Proteiin (g)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(276, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Kalorid (KCAL)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(115, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 25)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Kaal (g)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 25)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Toidu ID"
        '
        'txtWResult
        '
        Me.txtWResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtWResult.Location = New System.Drawing.Point(120, 62)
        Me.txtWResult.Name = "txtWResult"
        Me.txtWResult.Size = New System.Drawing.Size(155, 30)
        Me.txtWResult.TabIndex = 14
        '
        'txtFResult
        '
        Me.txtFResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtFResult.Location = New System.Drawing.Point(764, 62)
        Me.txtFResult.Name = "txtFResult"
        Me.txtFResult.Size = New System.Drawing.Size(155, 30)
        Me.txtFResult.TabIndex = 21
        '
        'txtFoodID
        '
        Me.txtFoodID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtFoodID.Location = New System.Drawing.Point(15, 62)
        Me.txtFoodID.Name = "txtFoodID"
        Me.txtFoodID.Size = New System.Drawing.Size(99, 30)
        Me.txtFoodID.TabIndex = 11
        '
        'txtEResult
        '
        Me.txtEResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEResult.Location = New System.Drawing.Point(281, 62)
        Me.txtEResult.Name = "txtEResult"
        Me.txtEResult.Size = New System.Drawing.Size(155, 30)
        Me.txtEResult.TabIndex = 20
        '
        'txtCResult
        '
        Me.txtCResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCResult.Location = New System.Drawing.Point(603, 62)
        Me.txtCResult.Name = "txtCResult"
        Me.txtCResult.Size = New System.Drawing.Size(155, 30)
        Me.txtCResult.TabIndex = 18
        '
        'txtPResult
        '
        Me.txtPResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtPResult.Location = New System.Drawing.Point(442, 62)
        Me.txtPResult.Name = "txtPResult"
        Me.txtPResult.Size = New System.Drawing.Size(155, 30)
        Me.txtPResult.TabIndex = 19
        '
        'txtFat
        '
        Me.txtFat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtFat.Location = New System.Drawing.Point(408, 512)
        Me.txtFat.Name = "txtFat"
        Me.txtFat.Size = New System.Drawing.Size(100, 30)
        Me.txtFat.TabIndex = 31
        '
        'txtCarbs
        '
        Me.txtCarbs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtCarbs.Location = New System.Drawing.Point(302, 512)
        Me.txtCarbs.Name = "txtCarbs"
        Me.txtCarbs.Size = New System.Drawing.Size(100, 30)
        Me.txtCarbs.TabIndex = 30
        '
        'txtProtein
        '
        Me.txtProtein.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtProtein.Location = New System.Drawing.Point(196, 512)
        Me.txtProtein.Name = "txtProtein"
        Me.txtProtein.Size = New System.Drawing.Size(100, 30)
        Me.txtProtein.TabIndex = 29
        '
        'txtEnergy
        '
        Me.txtEnergy.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtEnergy.Location = New System.Drawing.Point(90, 512)
        Me.txtEnergy.Name = "txtEnergy"
        Me.txtEnergy.Size = New System.Drawing.Size(100, 30)
        Me.txtEnergy.TabIndex = 28
        '
        'gbDatabase
        '
        Me.gbDatabase.Controls.Add(Me.DataGridView1)
        Me.gbDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.gbDatabase.Location = New System.Drawing.Point(9, 142)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(1087, 346)
        Me.gbDatabase.TabIndex = 27
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Valige sobiv toode"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1062, 309)
        Me.DataGridView1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(18, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Valige kogus:"
        '
        'cbAmount
        '
        Me.cbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cbAmount.FormattingEnabled = True
        Me.cbAmount.Location = New System.Drawing.Point(155, 97)
        Me.cbAmount.Name = "cbAmount"
        Me.cbAmount.Size = New System.Drawing.Size(459, 33)
        Me.cbAmount.TabIndex = 42
        '
        'txtSisestus
        '
        Me.txtSisestus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSisestus.Location = New System.Drawing.Point(155, 24)
        Me.txtSisestus.Name = "txtSisestus"
        Me.txtSisestus.Size = New System.Drawing.Size(459, 30)
        Me.txtSisestus.TabIndex = 41
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnBack.Location = New System.Drawing.Point(877, 87)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(214, 43)
        Me.btnBack.TabIndex = 40
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnClear.Location = New System.Drawing.Point(620, 87)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(251, 43)
        Me.btnClear.TabIndex = 39
        Me.btnClear.Text = "Puhasta"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSave.Location = New System.Drawing.Point(877, 24)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 43)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Salvesta"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSearch.Location = New System.Drawing.Point(620, 24)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(251, 43)
        Me.btnSearch.TabIndex = 37
        Me.btnSearch.Text = "Otsi"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(18, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Sisestage toit:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 693)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAmount)
        Me.Controls.Add(Me.txtSisestus)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.txtWeight)
        Me.Controls.Add(Me.txtSugar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtFat)
        Me.Controls.Add(Me.txtCarbs)
        Me.Controls.Add(Me.txtProtein)
        Me.Controls.Add(Me.txtEnergy)
        Me.Controls.Add(Me.gbDatabase)
        Me.Name = "Form1"
        Me.Text = "Database aken"
        CType(Me.ToitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbDatabase.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    'Friend WithEvents FoodDatabaseDataSet2 As FoodDatabaseDataSet2
    Friend WithEvents FoodDataBindingSource2 As BindingSource
    'Friend WithEvents TableAdapterManager2 As FoodDatabaseDataSet2TableAdapters.TableAdapterManager
    'Friend WithEvents ToitTableAdapter1 As FoodDatabaseDataSet2TableAdapters.ToitTableAdapter
    'Friend WithEvents FoodDataTableAdapter1 As FoodDatabaseDataSet2TableAdapters.FoodDataTableAdapter
    'Friend WithEvents FoodDataTableAdapter As FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter
    'Friend WithEvents ToiduAndmebaasDataSet As ToiduAndmebaasDataSet
    Friend WithEvents ToitBindingSource As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents food_id As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GramweightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents txtWeight As TextBox
    Friend WithEvents txtSugar As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSResult As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWResult As TextBox
    Friend WithEvents txtFResult As TextBox
    Friend WithEvents txtFoodID As TextBox
    Friend WithEvents txtEResult As TextBox
    Friend WithEvents txtCResult As TextBox
    Friend WithEvents txtPResult As TextBox
    Friend WithEvents txtFat As TextBox
    Friend WithEvents txtCarbs As TextBox
    Friend WithEvents txtProtein As TextBox
    Friend WithEvents txtEnergy As TextBox
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cbAmount As ComboBox
    Friend WithEvents txtSisestus As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
End Class
