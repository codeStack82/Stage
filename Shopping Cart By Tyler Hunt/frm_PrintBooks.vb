Public Class frm_PrintBooks
    Private Sub btn_PrintFrmClose_Sub_Click(sender As Object, e As EventArgs) Handles btn_PrintFrmClose_Sub.Click

        Me.Close()
    End Sub

    Private Sub frm_PrintBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_AddPrintBook_Sub_Click(sender As Object, e As EventArgs) Handles btn_AddPrintBook_Sub.Click

        'Get index value from list
        Dim index = Me.lb_PrintBookItems_Sub.SelectedIndex
        'Get text string form form
        Dim TextString = Me.lb_PrintBookItems_Sub.SelectedItem

        If index <> -1 Then
            'Place text string in main form
            My.Forms.frm_Main.lb_SelectedList.Items.Add(TextString)



            costList.Add(13.5D)
        End If

        Me.lb_PrintBookItems_Sub.ClearSelected()

        For i As Integer = 0 To costList.Count - 1

            MsgBox(costList(i).ToString() & vbNewLine)
        Next

    End Sub

    Private Sub frm_PrintBooks_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'gSng_index = My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedIndex

        'MsgBox(gSng_index)

        ' MsgBox(My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedIndex.ToString())
        'MsgBox(My.Forms.frm_PrintBooks.lb_PrintBookItems_Sub.SelectedItem.ToString())

    End Sub
End Class