<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AudioBooks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btn_AudioFrmClose_Sub = New System.Windows.Forms.Button()
        Me.btn_AddAudioBook_Sub = New System.Windows.Forms.Button()
        Me.gb_AudioBooks_Sub = New System.Windows.Forms.GroupBox()
        Me.lb_AudioBookItems_Sub = New System.Windows.Forms.ListBox()
        Me.gb_AudioBooks_Sub.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_AudioFrmClose_Sub
        '
        Me.btn_AudioFrmClose_Sub.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_AudioFrmClose_Sub.Location = New System.Drawing.Point(192, 197)
        Me.btn_AudioFrmClose_Sub.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AudioFrmClose_Sub.Name = "btn_AudioFrmClose_Sub"
        Me.btn_AudioFrmClose_Sub.Size = New System.Drawing.Size(105, 35)
        Me.btn_AudioFrmClose_Sub.TabIndex = 5
        Me.btn_AudioFrmClose_Sub.Text = "Close"
        Me.btn_AudioFrmClose_Sub.UseVisualStyleBackColor = True
        '
        'btn_AddAudioBook_Sub
        '
        Me.btn_AddAudioBook_Sub.Location = New System.Drawing.Point(16, 197)
        Me.btn_AddAudioBook_Sub.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_AddAudioBook_Sub.Name = "btn_AddAudioBook_Sub"
        Me.btn_AddAudioBook_Sub.Size = New System.Drawing.Size(108, 35)
        Me.btn_AddAudioBook_Sub.TabIndex = 4
        Me.btn_AddAudioBook_Sub.Text = "Add Book to Cart"
        Me.btn_AddAudioBook_Sub.UseVisualStyleBackColor = True
        '
        'gb_AudioBooks_Sub
        '
        Me.gb_AudioBooks_Sub.Controls.Add(Me.lb_AudioBookItems_Sub)
        Me.gb_AudioBooks_Sub.Location = New System.Drawing.Point(16, 18)
        Me.gb_AudioBooks_Sub.Margin = New System.Windows.Forms.Padding(2)
        Me.gb_AudioBooks_Sub.Name = "gb_AudioBooks_Sub"
        Me.gb_AudioBooks_Sub.Padding = New System.Windows.Forms.Padding(2)
        Me.gb_AudioBooks_Sub.Size = New System.Drawing.Size(282, 167)
        Me.gb_AudioBooks_Sub.TabIndex = 3
        Me.gb_AudioBooks_Sub.TabStop = False
        Me.gb_AudioBooks_Sub.Text = "Select an Audio Book"
        '
        'lb_AudioBookItems_Sub
        '
        Me.lb_AudioBookItems_Sub.FormattingEnabled = True
        Me.lb_AudioBookItems_Sub.Items.AddRange(New Object() {"Learn Calculus in One Day              $29.95", "The History of Scottland                 $14.50", "The Science of Body Language       $12.95", "Relaxation Techniques                    $11.50"})
        Me.lb_AudioBookItems_Sub.Location = New System.Drawing.Point(11, 22)
        Me.lb_AudioBookItems_Sub.Margin = New System.Windows.Forms.Padding(2)
        Me.lb_AudioBookItems_Sub.Name = "lb_AudioBookItems_Sub"
        Me.lb_AudioBookItems_Sub.Size = New System.Drawing.Size(261, 134)
        Me.lb_AudioBookItems_Sub.TabIndex = 0
        '
        'frm_AudioBooks
        '
        Me.AcceptButton = Me.btn_AddAudioBook_Sub
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_AudioFrmClose_Sub
        Me.ClientSize = New System.Drawing.Size(317, 266)
        Me.Controls.Add(Me.btn_AudioFrmClose_Sub)
        Me.Controls.Add(Me.btn_AddAudioBook_Sub)
        Me.Controls.Add(Me.gb_AudioBooks_Sub)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(333, 304)
        Me.MinimumSize = New System.Drawing.Size(333, 304)
        Me.Name = "frm_AudioBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Audio Books"
        Me.gb_AudioBooks_Sub.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_AudioFrmClose_Sub As Button
    Friend WithEvents btn_AddAudioBook_Sub As Button
    Friend WithEvents gb_AudioBooks_Sub As GroupBox
    Friend WithEvents lb_AudioBookItems_Sub As ListBox
End Class
