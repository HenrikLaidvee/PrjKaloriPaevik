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
        Me.FoodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GramweightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToitBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToiduAndmebaasDataSet = New PrjKaloriPaevik.ToiduAndmebaasDataSet()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtSisestus = New System.Windows.Forms.TextBox()
        Me.FoodDataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodDatabaseDataSet2 = New PrjKaloriPaevik.FoodDatabaseDataSet2()
        Me.TableAdapterManager2 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.TableAdapterManager()
        Me.FoodDataTableAdapter1 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.FoodDataTableAdapter()
        Me.ToitTableAdapter1 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.ToitTableAdapter()
        Me.FoodDataTableAdapter = New PrjKaloriPaevik.FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter()
        Me.ToitTableAdapter = New PrjKaloriPaevik.ToiduAndmebaasDataSetTableAdapters.ToitTableAdapter()
        Me.cbAmount = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.gbDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToitBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToiduAndmebaasDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.gbDatabase.Location = New System.Drawing.Point(12, 124)
        Me.gbDatabase.Name = "gbDatabase"
        Me.gbDatabase.Size = New System.Drawing.Size(1087, 346)
        Me.gbDatabase.TabIndex = 1
        Me.gbDatabase.TabStop = False
        Me.gbDatabase.Text = "Valige sobiv toode"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FoodidDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn, Me.GramweightDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ToitBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(15, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1062, 309)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FoodidDataGridViewTextBoxColumn
        '
        Me.FoodidDataGridViewTextBoxColumn.DataPropertyName = "food_id"
        Me.FoodidDataGridViewTextBoxColumn.HeaderText = "food_id"
        Me.FoodidDataGridViewTextBoxColumn.Name = "FoodidDataGridViewTextBoxColumn"
        Me.FoodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.FoodidDataGridViewTextBoxColumn.Visible = False
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescriptionDataGridViewTextBoxColumn.Width = 800
        '
        'GramweightDataGridViewTextBoxColumn
        '
        Me.GramweightDataGridViewTextBoxColumn.DataPropertyName = "gram_weight"
        Me.GramweightDataGridViewTextBoxColumn.HeaderText = "gram_weight"
        Me.GramweightDataGridViewTextBoxColumn.Name = "GramweightDataGridViewTextBoxColumn"
        Me.GramweightDataGridViewTextBoxColumn.ReadOnly = True
        Me.GramweightDataGridViewTextBoxColumn.Width = 200
        '
        'ToitBindingSource
        '
        Me.ToitBindingSource.DataMember = "Toit"
        Me.ToitBindingSource.DataSource = Me.ToiduAndmebaasDataSet
        '
        'ToiduAndmebaasDataSet
        '
        Me.ToiduAndmebaasDataSet.DataSetName = "ToiduAndmebaasDataSet"
        Me.ToiduAndmebaasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSearch.Location = New System.Drawing.Point(628, 31)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(251, 43)
        Me.btnSearch.TabIndex = 2
        Me.btnSearch.Text = "Otsi"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnSave.Location = New System.Drawing.Point(885, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(214, 43)
        Me.btnSave.TabIndex = 3
        Me.btnSave.Text = "Salvesta"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnClear.Location = New System.Drawing.Point(628, 75)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(251, 43)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Puhasta"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnBack.Location = New System.Drawing.Point(885, 75)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(214, 43)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Tagasi"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'gbInfo
        '
        Me.gbInfo.Controls.Add(Me.RichTextBox1)
        Me.gbInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.gbInfo.Location = New System.Drawing.Point(12, 476)
        Me.gbInfo.Name = "gbInfo"
        Me.gbInfo.Size = New System.Drawing.Size(1087, 237)
        Me.gbInfo.TabIndex = 7
        Me.gbInfo.TabStop = False
        Me.gbInfo.Text = "Toidu või joogi lisainfo ning toitained"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(6, 29)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1075, 202)
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
        'FoodDataBindingSource2
        '
        Me.FoodDataBindingSource2.DataMember = "FoodData"
        Me.FoodDataBindingSource2.DataSource = Me.FoodDatabaseDataSet2
        '
        'FoodDatabaseDataSet2
        '
        Me.FoodDatabaseDataSet2.DataSetName = "FoodDatabaseDataSet2"
        Me.FoodDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.AjaluguTableAdapter = Nothing
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.FoodDataTableAdapter = Me.FoodDataTableAdapter1
        Me.TableAdapterManager2.KasutajaTableAdapter = Nothing
        Me.TableAdapterManager2.NutrientsTableAdapter = Nothing
        Me.TableAdapterManager2.Sisestatud_toitTableAdapter = Nothing
        Me.TableAdapterManager2.ToitTableAdapter = Me.ToitTableAdapter1
        Me.TableAdapterManager2.UpdateOrder = PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FoodDataTableAdapter1
        '
        Me.FoodDataTableAdapter1.ClearBeforeFill = True
        '
        'ToitTableAdapter1
        '
        Me.ToitTableAdapter1.ClearBeforeFill = True
        '
        'FoodDataTableAdapter
        '
        Me.FoodDataTableAdapter.ClearBeforeFill = True
        '
        'ToitTableAdapter
        '
        Me.ToitTableAdapter.ClearBeforeFill = True
        '
        'cbAmount
        '
        Me.cbAmount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.cbAmount.FormattingEnabled = True
        Me.cbAmount.Location = New System.Drawing.Point(163, 67)
        Me.cbAmount.Name = "cbAmount"
        Me.cbAmount.Size = New System.Drawing.Size(459, 33)
        Me.cbAmount.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label2.Location = New System.Drawing.Point(22, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 25)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Valige kogus:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1103, 712)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbAmount)
        Me.Controls.Add(Me.txtSisestus)
        Me.Controls.Add(Me.gbInfo)
        Me.Controls.Add(Me.btnBack)
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
        CType(Me.ToiduAndmebaasDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbInfo.ResumeLayout(False)
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents gbDatabase As GroupBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents gbInfo As GroupBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents txtSisestus As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents FoodDatabaseDataSet2 As FoodDatabaseDataSet2
    Friend WithEvents FoodDataBindingSource2 As BindingSource
    Friend WithEvents TableAdapterManager2 As FoodDatabaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents ToitTableAdapter1 As FoodDatabaseDataSet2TableAdapters.ToitTableAdapter
    Friend WithEvents FoodDataTableAdapter1 As FoodDatabaseDataSet2TableAdapters.FoodDataTableAdapter
    Friend WithEvents FoodDataTableAdapter As FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter
    Friend WithEvents ToiduAndmebaasDataSet As ToiduAndmebaasDataSet
    Friend WithEvents ToitBindingSource As BindingSource
    Friend WithEvents ToitTableAdapter As ToiduAndmebaasDataSetTableAdapters.ToitTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GramweightDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents cbAmount As ComboBox
    Friend WithEvents Label2 As Label
End Class
