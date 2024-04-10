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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.gbInfo = New System.Windows.Forms.GroupBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.txtSisestus = New System.Windows.Forms.TextBox()
        Me.btnCreateAccount = New System.Windows.Forms.Button()
        Me.btnProfile = New System.Windows.Forms.Button()
        Me.FoodDatabaseDataSet2 = New PrjKaloriPaevik.FoodDatabaseDataSet2()
        Me.FoodDataBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager2 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.TableAdapterManager()
        Me.btnLogIn = New System.Windows.Forms.Button()
        Me.ToitTableAdapter1 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.ToitTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NutrientidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodDataTableAdapter1 = New PrjKaloriPaevik.FoodDatabaseDataSet2TableAdapters.FoodDataTableAdapter()
        Me.FoodDataTableAdapter = New PrjKaloriPaevik.FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter()
        Me.gbDatabase.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbInfo.SuspendLayout()
        CType(Me.FoodDatabaseDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.NutrientidDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FoodDataBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(15, 29)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(589, 309)
        Me.DataGridView1.TabIndex = 0
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
        'FoodDatabaseDataSet2
        '
        Me.FoodDatabaseDataSet2.DataSetName = "FoodDatabaseDataSet2"
        Me.FoodDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FoodDataBindingSource2
        '
        Me.FoodDataBindingSource2.DataMember = "FoodData"
        Me.FoodDataBindingSource2.DataSource = Me.FoodDatabaseDataSet2
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
        'btnLogIn
        '
        Me.btnLogIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnLogIn.Location = New System.Drawing.Point(350, 459)
        Me.btnLogIn.Name = "btnLogIn"
        Me.btnLogIn.Size = New System.Drawing.Size(205, 34)
        Me.btnLogIn.TabIndex = 11
        Me.btnLogIn.Text = "Logige kasutajasse"
        Me.btnLogIn.UseVisualStyleBackColor = True
        '
        'ToitTableAdapter1
        '
        Me.ToitTableAdapter1.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        Me.CategoryDataGridViewTextBoxColumn.Width = 200
        '
        'NutrientidDataGridViewTextBoxColumn
        '
        Me.NutrientidDataGridViewTextBoxColumn.DataPropertyName = "nutrient_id"
        Me.NutrientidDataGridViewTextBoxColumn.HeaderText = "nutrient_id"
        Me.NutrientidDataGridViewTextBoxColumn.Name = "NutrientidDataGridViewTextBoxColumn"
        Me.NutrientidDataGridViewTextBoxColumn.Visible = False
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.Width = 150
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
        Me.DescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'FoodDataTableAdapter1
        '
        Me.FoodDataTableAdapter1.ClearBeforeFill = True
        '
        'FoodDataTableAdapter
        '
        Me.FoodDataTableAdapter.ClearBeforeFill = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(898, 505)
        Me.Controls.Add(Me.btnLogIn)
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
        Me.gbInfo.ResumeLayout(False)
        CType(Me.FoodDatabaseDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodDataBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnCreateAccount As Button
    Friend WithEvents btnProfile As Button
    Friend WithEvents FoodDatabaseDataSet2 As FoodDatabaseDataSet2
    Friend WithEvents FoodDataBindingSource2 As BindingSource
    Friend WithEvents TableAdapterManager2 As FoodDatabaseDataSet2TableAdapters.TableAdapterManager
    Friend WithEvents btnLogIn As Button
    Friend WithEvents ToitTableAdapter1 As FoodDatabaseDataSet2TableAdapters.ToitTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NutrientidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodDataTableAdapter1 As FoodDatabaseDataSet2TableAdapters.FoodDataTableAdapter
    Friend WithEvents FoodDataTableAdapter As FoodDatabaseDataSetTableAdapters.FoodDataTableAdapter
End Class
