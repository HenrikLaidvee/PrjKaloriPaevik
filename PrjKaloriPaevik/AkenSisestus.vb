
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FoodDatabaseDataSet2.Toit' table. You can move, or remove it, as needed.
        Me.ToitTableAdapter1.Fill(Me.FoodDatabaseDataSet2.Toit)
        'TODO: This line of code loads data into the 'FoodDatabaseDataSet2.FoodData' table. You can move, or remove it, as needed.
        Me.FoodDataTableAdapter1.Fill(Me.FoodDatabaseDataSet2.FoodData)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        Dim colors() As String = [Enum].GetNames(GetType(KnownColor))

        'cbValik.Items.AddRange(colors)

        ' Tuleb leida parem asukoht või lahendus
        If KasutajaMoodul.isLoggedIn Then
            btnProfile.Show()
            btnCreateAccount.Hide()
            btnLogIn.Hide()
        Else
            btnCreateAccount.Show()
            'btnProfile.Hide()
            btnLogIn.Show()
        End If

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Dim keyword As String = txtSisestus.Text.Trim()
        'MessageBox.Show("Searching for: " & keyword)

        If txtSisestus.Text = "" Then
            Exit Sub
        Else
            Dim keyword As String = txtSisestus.Text

            FoodDataBindingSource2.Filter = "(Convert(ID, 'System.String') LIKE '" & txtSisestus.Text & "')" &
                " OR (description like '" & txtSisestus.Text & "')"

            If FoodDataBindingSource2.Count <> 0 Then
                With DataGridView1
                    .DataSource = FoodDataBindingSource2
                End With

            Else
                MsgBox("The search item was not found.")

                FoodDataBindingSource2.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = FoodDataBindingSource2
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
        FoodDataBindingSource2.Filter = Nothing

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

    Private Sub btnCreateAccount_Click(sender As Object, e As EventArgs) Handles btnCreateAccount.Click
        RegAken.Show()
    End Sub

    Private Sub btnProfile_Click(sender As Object, e As EventArgs) Handles btnProfile.Click
        Profiil.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        LogInAken.Show()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Peaks salvestama koos kasutaja idga enda logi
    End Sub
End Class
