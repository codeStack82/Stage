Public Class frm_Main
    'Menu Event to show about form
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frm_About.ShowDialog()
    End Sub

    'Menu Event to show printBooks form
    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        frm_PrintBooks.Show()
    End Sub

    'Menu Event to show AudioBooks form
    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        frm_AudioBooks.ShowDialog()
    End Sub

    'Form Event to remove selected items
    Private Sub btn_Remove_Click(sender As Object, e As EventArgs) Handles btn_Remove.Click

        Dim selectedIndex As Single = lb_SelectedList.SelectedIndex

        If selectedIndex >= 0 Then
            removeSelectedItem()
        Else
            MessageBox.Show("Sorry, You must select a value from the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub

    'Method to remove selected items from main Listbox           <<<<<<<------/////////// TODO: Need to work on the delete order 
    Sub removeSelectedItem()

        Dim itemIndex As Integer = My.Forms.frm_Main.lb_SelectedList.SelectedIndex

        'Remove selected item from listBox in main form
        lb_SelectedList.Items.RemoveAt(itemIndex)

        'Remove selected item from List
        gLst_SelectCostList.RemoveAt(itemIndex)

        'Reset global item count
        gSng_SelectedItemCount = -1

        'Update main form cost summary
        updateCostSummary()


    End Sub

    'Menu Event to reset form
    Private Sub ResetCtrlRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ResetCtrlRToolStripMenuItem.Click
        resetForm()
    End Sub

    'Form Event to close form
    Private Sub ExitCtrlQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitCtrlQToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim test As String

        For Each num In gLst_SelectCostList
            test += num & vbNewLine

        Next

        MsgBox(test)
    End Sub
End Class
