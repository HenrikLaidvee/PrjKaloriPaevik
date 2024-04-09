<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbDatabase = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NimiDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KategooriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KaloridDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodDatabaseDataSet1 = New PrjKaloriPaevik.FoodDatabaseDataSet1()
        Me.FoodDataBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodDatabaseDataSet = New PrjKaloriPaevik.FoodDatabaseDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtSisestus = New System.Windows.Forms.TextBox()
        Me.FoodDataTableAdapter = New PrjKaloriPaevik.FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter()
        Me.TableAdapterManager = New PrjKaloriPaevik.FoodDatabaseDataSetTableAdapters.TableAdapterManager()
        Me.ToitTableAdapter = New PrjKaloriPaevik.FoodDatabaseDataSet1TableAdapters.ToitTableAdapter()
        Me.TableAdapterManager1 = New PrjKaloriPaevik.FoodDatabaseDataSet1TableAdapters.TableAdapterManager()
        Me.FoodDataBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.gbDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDatabaseDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDataBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        CType(Me.FoodDataBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label1.Location = New System.Drawing.Point(22, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sisestage toit:"
        '
        'gbDatabase
        '
        Me.gbDatabase.Controls.Add(Me.DataGridView1)
        Me.gbDatabase.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.gbDatabase.Location = New System.Drawing.Point(12, 80)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(610, 346)
        Me.gbDatabase.TabIndex = 1
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Valige sobiv toode"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NimiDataGridViewTextBoxColumn, Me.KategooriaDataGridViewTextBoxColumn, Me.KaloridDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ToitBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(589, 309)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NimiDataGridViewTextBoxColumn
        '
        Me.NimiDataGridViewTextBoxColumn.DataPropertyName = "Nimi"
        Me.NimiDataGridViewTextBoxColumn.HeaderText = "Nimi"
        Me.NimiDataGridViewTextBoxColumn.Name = "NimiDataGridViewTextBoxColumn"
        Me.NimiDataGridViewTextBoxColumn.Width = 200
        '
        'KategooriaDataGridViewTextBoxColumn
        '
        Me.KategooriaDataGridViewTextBoxColumn.DataPropertyName = "Kategooria"
        Me.KategooriaDataGridViewTextBoxColumn.HeaderText = "Kategooria"
        Me.KategooriaDataGridViewTextBoxColumn.Name = "KategooriaDataGridViewTextBoxColumn"
        Me.KategooriaDataGridViewTextBoxColumn.Width = 150
        '
        'KaloridDataGridViewTextBoxColumn
        '
        Me.KaloridDataGridViewTextBoxColumn.DataPropertyName = "Kalorid"
        Me.KaloridDataGridViewTextBoxColumn.HeaderText = "Kalorid"
        Me.KaloridDataGridViewTextBoxColumn.Name = "KaloridDataGridViewTextBoxColumn"
        '
        'ToitBindingSource
        '
        Me.ToitBindingSource.DataMember = "Toit"
        Me.ToitBindingSource.DataSource = Me.FoodDatabaseDataSet1
        '
        'FoodDatabaseDataSet1
        '
        Me.FoodDatabaseDataSet1.DataSetName = "FoodDatabaseDataSet1"
        Me.FoodDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FoodDataBindingSource
        '
        Me.FoodDataBindingSource.DataMember = "FoodData"
        Me.FoodDataBindingSource.DataSource = Me.FoodDatabaseDataSet
        '
        'FoodDatabaseDataSet
        '
        Me.FoodDatabaseDataSet.DataSetName = "FoodDatabaseDataSet"
        Me.FoodDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSearch.Location = New System.Drawing.Point(628, 31)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(123, 43)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Otsi"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSave.Location = New System.Drawing.Point(757, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(122, 43)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Salvesta"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnClear.Location = New System.Drawing.Point(628, 83)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(251, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Puhasta"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnExit.Location = New System.Drawing.Point(757, 375)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(122, 43)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Välju"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnBack.Location = New System.Drawing.Point(628, 375)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 43)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.RichTextBox1)
        Me.gbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.gbInfo.Location = New System.Drawing.Point(628, 132)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(251, 237)
        Me.gbInfo.TabIndex = 7
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Info"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 29)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(239, 202)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'txtSisestus
        '
        Me.txtSisestus.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.txtSisestus.Location = New System.Drawing.Point(163, 31)
        Me.txtSisestus.Name = "txtSisestus"
        Me.txtSisestus.Size = New System.Drawing.Size(459, 30)
        Me.txtSisestus.TabIndex = 8
        '
        'FoodDataTableAdapter
        '
        Me.FoodDataTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.FoodDataTableAdapter = Me.FoodDataTableAdapter
        Me.TableAdapterManager.NutrientsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = PrjKaloriPaevik.FoodDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ToitTableAdapter
        '
        Me.ToitTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.FoodDataTableAdapter = Nothing
        Me.TableAdapterManager1.NutrientsTableAdapter = Nothing
        Me.TableAdapterManager1.ToitTableAdapter = Me.ToitTableAdapter
        Me.TableAdapterManager1.UpdateOrder = PrjKaloriPaevik.FoodDatabaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FoodDataBindingSource1
        '
        Me.FoodDataBindingSource1.DataMember = "FoodData"
        Me.FoodDataBindingSource1.DataSource = Me.FoodDatabaseDataSet
        '
        'btnCreateAccount
        '
        Me.btnCreateAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnCreateAccount.Location = New System.Drawing.Point(12, 459)
        Me.btnCreateAccount.Name = "btnCreateAccount"
        Me.btnCreateAccount.Size = New System.Drawing.Size(163, 34)
        Me.btnCreateAccount.TabIndex = 9
        Me.btnCreateAccount.Text = "Loo kasutaja"
        Me.btnCreateAccount.UseVisualStyleBackColor = True
        '
        'btnProfile
        '
        Me.btnProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnProfile.Location = New System.Drawing.Point(181, 459)
        Me.btnProfile.Name = "btnProfile"
        Me.btnProfile.Size = New System.Drawing.Size(163, 34)
        Me.btnProfile.TabIndex = 10
        Me.btnProfile.Text = "Profiil"
        Me.btnProfile.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 505)
        Me.Controls.Add(Me.btnProfile)
        Me.Controls.Add(Me.btnCreateAccount)
        Me.Controls.Add(Me.txtSisestus)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.gbDatabase)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Database aken"
        Me.gbDatabase.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToitBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDatabaseDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDataBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfo.ResumeLayout(False)
        CType(Me.FoodDataBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtSisestus As TextBox
    Friend WithEvents FoodDatabaseDataSet As FoodDatabaseDataSet
    Friend WithEvents FoodDataBindingSource As BindingSource
    Friend WithEvents FoodDataTableAdapter As FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter
    Friend WithEvents TableAdapterManager As FoodDatabaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FoodDatabaseDataSet1 As FoodDatabaseDataSet1
    Friend WithEvents ToitBindingSource As BindingSource
    Friend WithEvents ToitTableAdapter As FoodDatabaseDataSet1TableAdapters.ToitTableAdapter
    Friend WithEvents TableAdapterManager1 As FoodDatabaseDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NimiDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KategooriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KaloridDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDataBindingSource1 As BindingSource
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnProfile As Button
End Class
