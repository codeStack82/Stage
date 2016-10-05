Public Class frm_AudioBooks
    Private Sub btn_AudioFrmClose_Sub_Click(sender As Object, e As EventArgs) Handles btn_AudioFrmClose_Sub.Click
        Me.Close()
    End Sub

    Private Sub frm_AudioBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AddAudioBook_Sub_Click(sender As Object, e As EventArgs) Handles btn_AddAudioBook_Sub.Click

        Dim index = Me.lb_AudioBookItems_Sub.SelectedIndex                  'Get index value from Audio form list
        Dim selectedCost As Decimal                                          'Holds added cost value
        Dim TextString = Me.lb_AudioBookItems_Sub.SelectedItem              'Get text string form form

        If index <> -1 Then

            'Place text string in main form
            My.Forms.frm_Main.lb_SelectedList.Items.Add(TextString)

            'Get & set the addCost value from module Array
            selectedCost = gDec_PricesArray(index)

            'Add cost to List using the selected index from list
            SelectCostList.Add(selectedCost)

        End If

        'Clear marked item once it is added
        Me.lb_AudioBookItems_Sub.ClearSelected()

        'Update Subtotal in mainForm
        updateCostSummary()

    End Sub
End Class