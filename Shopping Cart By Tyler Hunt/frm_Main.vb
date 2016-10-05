Public Class frm_Main


    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frm_About.ShowDialog()
    End Sub

    Private Sub PrintBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintBooksToolStripMenuItem.Click
        frm_PrintBooks.Show()
    End Sub

    Private Sub AudioBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AudioBooksToolStripMenuItem.Click
        frm_AudioBooks.ShowDialog()
    End Sub

    Private Sub ExitCtrlQToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitCtrlQToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
