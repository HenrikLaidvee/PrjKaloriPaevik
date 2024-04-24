
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

        cbAmount.SelectedIndex = 0

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

            If Kosher Then
                filterString &= " AND NOT (description LIKE '*shellfish*' OR description LIKE '*crab*' OR description LIKE '*lobster*' OR description LIKE '*shrimp*' " &
                    "OR description LIKE '*beef*' OR description LIKE '*game*' OR description LIKE '*lamb*' OR description LIKE '*chicken*' " &
                    "OR description LIKE '*turkey*' OR description LIKE '*duck*' OR description LIKE '*goose*' OR description LIKE '*Milk*' " &
                    "OR description LIKE '*cheese*' OR description LIKE '*yogurt*')"
            End If

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

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        ' Check the condition 'Unhealthy'
        If Unhealthy Then
            ' Check if a row is selected in the DataGridView
            If DataGridView1.SelectedRows.Count > 0 Then
                ' Retrieve the selected row
                Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

                ' Extract the gram_weight from the selected row
                Dim gramWeight As Integer ' = Convert.ToInt32(selectedRow.Cells("gram_weight").Value)

                ' Check if the gram_weight is greater than 700
                If gramWeight > 700 Then
                    ' Display a warning message box
                    MessageBox.Show("Ebatervislik toit", "Hoiatus", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub


    Private selected_row_weight As Integer = 218

    'Private Sub btnDelete_Click(sender As Object, e As EventArgs)
    'ToitBindingSource.RemoveCurrent()
    'End Sub

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

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveSelectedFood()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MainForm.Refresh()
        Dim a As Integer = 1872 '3000 - KasutajaMoodul.food_amount * 5
        MainForm.txtCaloriesLeft.Text = a.ToString()
        'MessageBox.Show(food_amount, "Teade!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'MessageBox.Show(loggedInID, "Teade!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


    'Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
    ' Check if a row is selected in the DataGridView
    'If DataGridView1.SelectedRows.Count > 0 Then
    '       SaveSelectedFood()
    'End If
    'End Sub

    Private Sub SaveSelectedFood()
        If (KasutajaMoodul.test) Then
            MessageBox.Show("Valik on edukalt salvestatud!", "Teade", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Dim Multiplier As Integer = cbAmount.SelectedIndex
            Dim foodWeight As Integer = selected_row_weight
            KasutajaMoodul.food_amount = Multiplier * foodWeight
            Return
        End If

        ' Retrieve the selected row
        Dim selectedRow As DataGridViewRow = DataGridView1.SelectedRows(0)

        Dim foodID As Integer = Convert.ToInt32(selectedRow.Cells("food_id").Value)
        Dim nutrientID As Integer = Convert.ToInt32(selectedRow.Cells("NutrientIDColumn").Value)
        Dim selectedAmount As Integer = cbAmount.SelectedIndex
        Dim currentDate As Date = Date.Now
        Dim kasutajaID As Integer = loggedInID
        Dim gramWeight As Integer = Convert.ToInt32(selectedRow.Cells("gram_weight").Value)

        Dim amount As Integer = selectedAmount * gramWeight

        Dim query As String = $"INSERT INTO Sisestatud_toit (Food_ID, Kasutaja_ID, Nutrient_ID, Amount, Date) " &
                              $"VALUES ({foodID}, {kasutajaID}, {nutrientID}, {amount}, '{currentDate.ToString("yyyy-MM-dd")}')"

        Try
            Using connection As New OleDbConnection("YourConnectionString")
                connection.Open()
                Dim command As New OleDbCommand(query, connection)
                command.ExecuteNonQuery()
            End Using

            MessageBox.Show("Valik on edukalt salvestatud!", "Teade", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving selected item: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
