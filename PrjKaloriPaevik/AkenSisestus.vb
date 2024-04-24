
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToiduAndmebaasDataSet.Toit' table. You can move, or remove it, as needed.
        Me.ToitTableAdapter.Fill(Me.ToiduAndmebaasDataSet.Toit)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        For i As Integer = 1 To 10
            cbAmount.Items.Add(i.ToString())
        Next

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

            ' Construct the filter string to match description containing the keyword
            Dim filterString As String = $"description LIKE '*{keyword}*'"
            ' Apply the filter
            ToitBindingSource.Filter = filterString

            If ToitBindingSource.Count <> 0 Then
                With DataGridView1
                    .DataSource = ToitBindingSource
                End With

            Else
                MessageBox.Show("Otsitud toodet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)

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
        'ToitBindingSource.RemoveCurrent()
    End Sub

    Private Sub cbValik_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtSisestus.Select()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'txtSisestus.Text = ""
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



    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub



    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Peaks salvestama koos kasutaja idga enda logi
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub
End Class
