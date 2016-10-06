Public Class frm_PrintBooks

    'Event to add selected items to the main form
    Private Sub btn_AddPrintBook_Sub_Click(sender As Object, e As EventArgs) Handles btn_AddPrintBook_Sub.Click


        Dim index As Integer = lb_PrintBookItems_Sub.SelectedIndex                  'Get index value from Print form list
        Dim selectedCost As Decimal                                                 'Holds added cost value
        Dim TextString = lb_PrintBookItems_Sub.SelectedItem                         'Get text string form form

        If index <> -1 Then

            'Place text string in main form
            My.Forms.frm_Main.lb_SelectedList.Items.Add(TextString)

            'Get & set the addCost value from module Array
            selectedCost = gDec_PricesArray(index)

            'Add cost to List using the selected index from list
            gLst_SelectCostList.Add(selectedCost)
        Else
            MessageBox.Show("Sorry, You must select a value from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)

        End If

        'Clear marked item once it is added
        Me.lb_PrintBookItems_Sub.ClearSelected()

        'Update Subtotal in mainForm
        updateCostSummary()

    End Sub

    'Event to close form
    Private Sub btn_PrintFrmClose_Sub_Click(sender As Object, e As EventArgs) Handles btn_PrintFrmClose_Sub.Click
        Me.Close()
    End Sub

End Class