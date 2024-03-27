
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FoodDatabaseDataSet1.Toit' table. You can move, or remove it, as needed.
        'Me.ToitTableAdapter.Fill(Me.FoodDatabaseDataSet1.Toit)
        'cbTest()

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        Dim colors() As String = [Enum].GetNames(GetType(KnownColor))

        'cbValik.Items.AddRange(colors)

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Dim keyword As String = txtSisestus.Text.Trim()
        'MessageBox.Show("Searching for: " & keyword)

        If txtSisestus.Text = "" Then
            Exit Sub
        Else
            Dim keyword As String = txtSisestus.Text

            ToitBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSisestus.Text & "')" &
                " OR (nimi like '" & txtSisestus.Text & "')"

            If ToitBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = ToitBindingSource
                End With

            Else
                'MsgBox("-->The search item was not found.",
                'MsgBoxStyle.Information = "Hey Boss!")

                ToitBindingSource.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = ToitBindingSource
                End With


            End If


        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs)
        ToitBindingSource.RemoveCurrent()
    End Sub

    Private Sub cbValik_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtSisestus.Select()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSisestus.Select()
        ToitBindingSource.Filter = Nothing

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        ' Error
        'MsgBox("Error Number" & Err.Number & vbNewLine &
        '      "Error Description" & Err.Description, MsgBoxStyle.Critical, _
        '      "Reset Error!")

    End Sub

End Class
