<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PrintBooks
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
        Me.gb_PrintBooks_Sub = New System.Windows.Forms.GroupBox()
        Me.lb_PrintBookItems_Sub = New System.Windows.Forms.ListBox()
        Me.btn_AddPrintBook_Sub = New System.Windows.Forms.Button()
        Me.btn_PrintFrmClose_Sub = New System.Windows.Forms.Button()
        Me.gb_PrintBooks_Sub.SuspendLayout()
        Me.SuspendLayout()
        '
        'gb_PrintBooks_Sub
        '
        Me.gb_PrintBooks_Sub.Controls.Add(Me.lb_PrintBookItems_Sub)
        Me.gb_PrintBooks_Sub.Location = New System.Drawing.Point(14, 22)
        Me.gb_PrintBooks_Sub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gb_PrintBooks_Sub.Name = "gb_PrintBooks_Sub"
        Me.gb_PrintBooks_Sub.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gb_PrintBooks_Sub.Size = New System.Drawing.Size(284, 167)
        Me.gb_PrintBooks_Sub.TabIndex = 0
        Me.gb_PrintBooks_Sub.TabStop = False
        Me.gb_PrintBooks_Sub.Text = "Select a Print Book"
        '
        'lb_PrintBookItems_Sub
        '
        Me.lb_PrintBookItems_Sub.FormattingEnabled = True
        Me.lb_PrintBookItems_Sub.Items.AddRange(New Object() {"I Did It Your Way                             $11.95", "The History of Scottland                 $14.50", "Learn Calculus in One Day              $29.50", "Feel the Stress                                $18.50"})
        Me.lb_PrintBookItems_Sub.Location = New System.Drawing.Point(11, 22)
        Me.lb_PrintBookItems_Sub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lb_PrintBookItems_Sub.Name = "lb_PrintBookItems_Sub"
        Me.lb_PrintBookItems_Sub.Size = New System.Drawing.Size(266, 134)
        Me.lb_PrintBookItems_Sub.TabIndex = 0
        '
        'btn_AddPrintBook_Sub
        '
        Me.btn_AddPrintBook_Sub.Location = New System.Drawing.Point(14, 202)
        Me.btn_AddPrintBook_Sub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_AddPrintBook_Sub.Name = "btn_AddPrintBook_Sub"
        Me.btn_AddPrintBook_Sub.Size = New System.Drawing.Size(100, 35)
        Me.btn_AddPrintBook_Sub.TabIndex = 1
        Me.btn_AddPrintBook_Sub.Text = "Add Book to Cart"
        Me.btn_AddPrintBook_Sub.UseVisualStyleBackColor = True
        '
        'btn_PrintFrmClose_Sub
        '
        Me.btn_PrintFrmClose_Sub.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_PrintFrmClose_Sub.Location = New System.Drawing.Point(198, 202)
        Me.btn_PrintFrmClose_Sub.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_PrintFrmClose_Sub.Name = "btn_PrintFrmClose_Sub"
        Me.btn_PrintFrmClose_Sub.Size = New System.Drawing.Size(100, 35)
        Me.btn_PrintFrmClose_Sub.TabIndex = 2
        Me.btn_PrintFrmClose_Sub.Text = "Close"
        Me.btn_PrintFrmClose_Sub.UseVisualStyleBackColor = True
        '
        'frm_PrintBooks
        '
        Me.AcceptButton = Me.btn_AddPrintBook_Sub
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_PrintFrmClose_Sub
        Me.ClientSize = New System.Drawing.Size(317, 266)
        Me.Controls.Add(Me.btn_PrintFrmClose_Sub)
        Me.Controls.Add(Me.btn_AddPrintBook_Sub)
        Me.Controls.Add(Me.gb_PrintBooks_Sub)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximumSize = New System.Drawing.Size(333, 304)
        Me.MinimumSize = New System.Drawing.Size(333, 304)
        Me.Name = "frm_PrintBooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Books"
        Me.gb_PrintBooks_Sub.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gb_PrintBooks_Sub As GroupBox
    Friend WithEvents lb_PrintBookItems_Sub As ListBox
    Friend WithEvents btn_AddPrintBook_Sub As Button
    Friend WithEvents btn_PrintFrmClose_Sub As Button
End Class
