
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports PrjKaloriPaevikKalorid

Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ToiduAndmebaasDataSet.Toit' table. You can move, or remove it, as needed.
        Me.ToitTableAdapter.Fill(Me.ToiduAndmebaasDataSet.Toit)
        'TODO: This line of code loads data into the 'ToiduAndmebaasDataSet.Toit' table. You can move, or remove it, as needed.
        'Me.ToitTableAdapter.Fill(Me.ToiduAndmebaasDataSet.Toit)

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With

        For i As Integer = 1 To 10
            cbAmount.Items.Add(i.ToString())
        Next

        cbAmount.SelectedIndex = 0

        'cbValik.Items.AddRange(colors)


    End Sub


    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs)
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

    Private Sub cbValik_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtSisestus.Select()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Get the values from the TextBoxes
        Dim food_id As Integer
        If Integer.TryParse(txtFoodID.Text, food_id) Then
            Dim carbohydrates As Decimal
            If Decimal.TryParse(txtCResult.Text, carbohydrates) Then
                Dim protein As Decimal
                If Decimal.TryParse(txtPResult.Text, protein) Then
                    Dim fat As Decimal
                    If Decimal.TryParse(txtFResult.Text, fat) Then
                        Dim energy As Decimal
                        If Decimal.TryParse(txtEResult.Text, energy) Then
                            Dim sugar As Decimal
                            If Decimal.TryParse(txtSResult.Text, sugar) Then
                                Dim amount As Decimal
                                If Decimal.TryParse(txtWResult.Text, amount) Then
                                    ' Format the date as "dd-MM-yyyy"
                                    Dim currentDate As String = DateTime.Now.ToString("dd-MM-yyyy")

                                    ' Insert the values into the Access table "sisestatud_toit"
                                    Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
                                    Dim query As String = "INSERT INTO sisestatud_toit (food_id, kasutaja_id, carbohydrates, protein, fat, Energy, Sugar, Amount, [Date]) VALUES (@food_id, @kasutaja_id, @carbohydrates, @protein, @fat, @Energy, @Sugar, @Amount, @Date)"

                                    Using connection As New OleDbConnection(connectionString)
                                        Using command As New OleDbCommand(query, connection)
                                            ' Add parameters
                                            command.Parameters.AddWithValue("@food_id", food_id)
                                            command.Parameters.AddWithValue("@kasutaja_id", loggedInID)
                                            command.Parameters.AddWithValue("@carbohydrates", carbohydrates)
                                            command.Parameters.AddWithValue("@protein", protein)
                                            command.Parameters.AddWithValue("@fat", fat)
                                            command.Parameters.AddWithValue("@Energy", energy)
                                            command.Parameters.AddWithValue("@Sugar", sugar)
                                            command.Parameters.AddWithValue("@Amount", amount)
                                            command.Parameters.AddWithValue("@Date", currentDate)

                                            ' Open the connection and execute the command
                                            connection.Open()
                                            command.ExecuteNonQuery()
                                        End Using
                                    End Using

                                    MessageBox.Show("Toit salvestatud edukalt!")
                                Else
                                    MessageBox.Show("Invalid value for Amount.")
                                End If
                            Else
                                MessageBox.Show("Invalid value for Sugar.")
                            End If
                        Else
                            MessageBox.Show("Invalid value for Energy.")
                        End If
                    Else
                        MessageBox.Show("Invalid value for Fat.")
                    End If
                Else
                    MessageBox.Show("Invalid value for Protein.")
                End If
            Else
                MessageBox.Show("Invalid value for Carbohydrates.")
            End If
        Else
            MessageBox.Show("Invalid value for food_id.")
        End If
    End Sub

    Private Sub cbAmount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAmount.SelectedIndexChanged
        ' Parse the selected amount from the ComboBox
        Dim selectedAmount As Integer
        If Integer.TryParse(cbAmount.SelectedItem.ToString(), selectedAmount) Then
            ' Parse the values in txtCarbs, txtProtein, txtFat, and txtEnergy
            Dim carbs As Decimal
            Dim protein As Decimal
            Dim fat As Decimal
            Dim energy As Decimal
            Dim weight As Decimal
            Dim sugar As Decimal


            If Decimal.TryParse(txtCarbs.Text, carbs) AndAlso
           Decimal.TryParse(txtProtein.Text, protein) AndAlso
           Decimal.TryParse(txtFat.Text, fat) AndAlso
           Decimal.TryParse(txtSugar.Text, sugar) AndAlso
           Decimal.TryParse(txtWeight.Text, weight) AndAlso
           Decimal.TryParse(txtEnergy.Text, energy) Then

                ' Calculate the results
                Dim newCarbs As Decimal = carbs * selectedAmount
                Dim newProtein As Decimal = protein * selectedAmount
                Dim newFat As Decimal = fat * selectedAmount
                Dim newEnergy As Decimal = energy * selectedAmount
                Dim newWeight As Decimal = weight * selectedAmount
                Dim newSugar As Decimal = sugar * selectedAmount


                ' Set the calculated values to the respective TextBoxes
                txtCResult.Text = newCarbs.ToString()
                txtPResult.Text = newProtein.ToString()
                txtFResult.Text = newFat.ToString()
                txtEResult.Text = newEnergy.ToString()
                txtWResult.Text = newWeight.ToString()
                txtSResult.Text = newSugar.ToString()

            Else
                ' Handle invalid input in any of the TextBoxes
                MessageBox.Show("Invalid value in one of the TextBoxes.")
            End If
        Else
            ' Handle invalid selection in cbAmount
            MessageBox.Show("Invalid selection in cbAmount.")
        End If

    End Sub



    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSisestus.Text = ""
        txtSisestus.Select()
        ToitBindingSource.Filter = Nothing

        With DataGridView1
            .ClearSelection()
            .ReadOnly = True
            .MultiSelect = False
        End With
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

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

            ToitBindingSource2.Filter = filterString

            If ToitBindingSource2.Count <> 0 Then
                With DataGridView1
                    .DataSource = ToitBindingSource2
                End With

            Else
                MessageBox.Show("Otsitud toodet ei leitud!", "Viga", MessageBoxButtons.OK, MessageBoxIcon.Error)

                ToitBindingSource2.Filter = Nothing

                With DataGridView1
                    .ClearSelection()
                    .ReadOnly = True
                    .MultiSelect = False
                    .DataSource = ToitBindingSource2
                End With

            End If

        End If
    End Sub
End Class
