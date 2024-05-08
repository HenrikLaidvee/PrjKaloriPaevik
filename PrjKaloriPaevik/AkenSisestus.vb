
Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports FoodSafetyWarning
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

        RichTextBox2.ReadOnly = True

        'cbValik.Items.AddRange(colors)


    End Sub

    Private foodWarning As New CFoodWarning() ' Create an instance of CFoodWarning

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        If Unhealthy Then
            Dim foodName As String = txtFoodName.Text
            Dim calorieContent As Integer
            If Integer.TryParse(txtEnergy.Text, calorieContent) Then
                Dim fatContent As Double
                If Double.TryParse(txtFat.Text, fatContent) Then

                    ' Check if the food is unhealthy and display warning if necessary
                    foodWarning.DisplayWarning(foodName, calorieContent, fatContent)
                End If
            End If
        End If

    End Sub


    Private Sub cbValik_SelectedIndexChanged(sender As Object, e As EventArgs)
        txtSisestus.Select()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Validate input values
        If Not ValidateInputs() Then
            Return
        End If

        ' Check for alcohol consumption
        If CheckAlcoholConsumption() Then
            MessageBox.Show("Teade! Te olete ületanud alkoholi piiri")
            Return
        End If

        ' Insert data into the database
        If InsertData() Then
            MessageBox.Show("Toit salvestatud edukalt!")
        Else
            MessageBox.Show("Failed to save food data.")
        End If
    End Sub

    Private Function ValidateInputs() As Boolean
        ' Validate the input values
        If Not Integer.TryParse(txtFoodID.Text, Nothing) Then
            MessageBox.Show("Invalid value for food_id.")
            Return False
        End If

        Dim fieldsToCheck = {txtCResult, txtPResult, txtFResult, txtEResult, txtSResult, txtWResult}
        For Each field In fieldsToCheck
            Dim value As Decimal
            If Not Decimal.TryParse(field.Text, value) Then
                MessageBox.Show($"Invalid value for {field.Name.Substring(3)}.")
                Return False
            End If
        Next

        Return True
    End Function

    Private Function CheckAlcoholConsumption() As Boolean
        If txtFoodName.Text.ToLower().Contains("beer") Then
            Dim amount As Decimal
            If Decimal.TryParse(txtWResult.Text, amount) Then
                Dim alkohol As Integer
                Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
                Dim query As String = "SELECT alkohol FROM kasutaja WHERE id = @loggedInID"
                Using connection As New OleDbConnection(connectionString)
                    Using command As New OleDbCommand(query, connection)
                        command.Parameters.AddWithValue("@loggedInID", loggedInID)
                        connection.Open()
                        alkohol = Convert.ToInt32(command.ExecuteScalar())
                    End Using
                End Using

                Return amount > alkohol AndAlso alkohol <> 0
            Else
                MessageBox.Show("Invalid value for Amount.")
                Return False
            End If
        End If
        Return False
    End Function



    Private Function InsertData() As Boolean
        Dim food_id As Integer = Convert.ToInt32(txtFoodID.Text)
        Dim carbohydrates As Decimal = Convert.ToDecimal(txtCResult.Text)
        Dim protein As Decimal = Convert.ToDecimal(txtPResult.Text)
        Dim fat As Decimal = Convert.ToDecimal(txtFResult.Text)
        Dim energy As Decimal = Convert.ToDecimal(txtEResult.Text)
        Dim sugar As Decimal = Convert.ToDecimal(txtSResult.Text)
        Dim amount As Decimal = Convert.ToDecimal(txtWResult.Text)
        Dim currentDate As String = DateTime.Now.ToString("dd-MM-yyyy")

        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Users\B\Documents\Tarkvaratehnika\Andmebaas\ToiduAndmebaas.accdb;"
        Dim query As String = "INSERT INTO sisestatud_toit (food_id, kasutaja_id, carbohydrates, protein, fat, Energy, Sugar, Amount, [Date]) VALUES (@food_id, @kasutaja_id, @carbohydrates, @protein, @fat, @Energy, @Sugar, @Amount, @Date)"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(query, connection)
                command.Parameters.AddWithValue("@food_id", food_id)
                command.Parameters.AddWithValue("@kasutaja_id", loggedInID)
                command.Parameters.AddWithValue("@carbohydrates", carbohydrates)
                command.Parameters.AddWithValue("@protein", protein)
                command.Parameters.AddWithValue("@fat", fat)
                command.Parameters.AddWithValue("@Energy", energy)
                command.Parameters.AddWithValue("@Sugar", sugar)
                command.Parameters.AddWithValue("@Amount", amount)
                command.Parameters.AddWithValue("@Date", currentDate)

                connection.Open()
                command.ExecuteNonQuery()
                Return True
            End Using
        End Using

        Return False
    End Function


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
