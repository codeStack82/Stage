Public Class frm_PrintBooks
    Private Sub btn_PrintFrmClose_Sub_Click(sender As Object, e As EventArgs) Handles btn_PrintFrmClose_Sub.Click

        Me.Close()
    End Sub

    Private Sub frm_PrintBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AddPrintBook_Sub_Click(sender As Object, e As EventArgs) Handles btn_AddPrintBook_Sub.Click


        Dim index = Me.lb_PrintBookItems_Sub.SelectedIndex                  'Get index value from Print form list
        Dim selectedCost As Decimal                                              'Holds added cost value
        Dim TextString = Me.lb_PrintBookItems_Sub.SelectedItem              'Get text string form form

        If index <> -1 Then

            'Place text string in main form
            My.Forms.frm_Main.lb_SelectedList.Items.Add(TextString)

            'Get & set the addCost value from module Array
            selectedCost = gDec_PricesArray(index)

            'Add cost to List using the selected index from list
            SelectCostList.Add(selectedCost)

        End If

        'Clear marked item once it is added
        Me.lb_PrintBookItems_Sub.ClearSelected()

        'Update Subtotal in mainForm
        updateCostSummary()

    End Sub

    Private Sub frm_PrintBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'gSng_index = My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedIndex

        'MsgBox(gSng_index)

        ' MsgBox(My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedIndex.ToString())
        'MsgBox(My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedItem.ToString())

    End Sub
End Class