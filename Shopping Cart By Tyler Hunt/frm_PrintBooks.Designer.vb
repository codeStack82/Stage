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
        Me.gb_PrintBooks_Sub.Location = New System.Drawing.Point(29, 42)
        Me.gb_PrintBooks_Sub.Name = "gb_PrintBooks_Sub"
        Me.gb_PrintBooks_Sub.Size = New System.Drawing.Size(568, 322)
        Me.gb_PrintBooks_Sub.TabIndex = 0
        Me.gb_PrintBooks_Sub.TabStop = False
        Me.gb_PrintBooks_Sub.Text = "Select a Print Book"
        '
        'lb_PrintBookItems_Sub
        '
        Me.lb_PrintBookItems_Sub.FormattingEnabled = True
        Me.lb_PrintBookItems_Sub.ItemHeight = 25
        Me.lb_PrintBookItems_Sub.Items.AddRange(New Object() {"I Did It Your Way                             $11.95", "The History of Scottland                 $14.50", "Learn Calculus in One Day              $29.50", "Feel the Stress                                $18.50"})
        Me.lb_PrintBookItems_Sub.Location = New System.Drawing.Point(22, 42)
        Me.lb_PrintBookItems_Sub.Name = "lb_PrintBookItems_Sub"
        Me.lb_PrintBookItems_Sub.Size = New System.Drawing.Size(528, 254)
        Me.lb_PrintBookItems_Sub.TabIndex = 0
        '
        'btn_AddPrintBook_Sub
        '
        Me.btn_AddPrintBook_Sub.Location = New System.Drawing.Point(29, 388)
        Me.btn_AddPrintBook_Sub.Name = "btn_AddPrintBook_Sub"
        Me.btn_AddPrintBook_Sub.Size = New System.Drawing.Size(200, 67)
        Me.btn_AddPrintBook_Sub.TabIndex = 1
        Me.btn_AddPrintBook_Sub.Text = "Add Book to Cart"
        Me.btn_AddPrintBook_Sub.UseVisualStyleBackColor = True
        '
        'btn_PrintFrmClose_Sub
        '
        Me.btn_PrintFrmClose_Sub.Location = New System.Drawing.Point(397, 388)
        Me.btn_PrintFrmClose_Sub.Name = "btn_PrintFrmClose_Sub"
        Me.btn_PrintFrmClose_Sub.Size = New System.Drawing.Size(200, 67)
        Me.btn_PrintFrmClose_Sub.TabIndex = 2
        Me.btn_PrintFrmClose_Sub.Text = "Close"
        Me.btn_PrintFrmClose_Sub.UseVisualStyleBackColor = True
        '
        'frm_PrintBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 479)
        Me.Controls.Add(Me.btn_PrintFrmClose_Sub)
        Me.Controls.Add(Me.btn_AddPrintBook_Sub)
        Me.Controls.Add(Me.gb_PrintBooks_Sub)
        Me.MaximumSize = New System.Drawing.Size(650, 550)
        Me.MinimumSize = New System.Drawing.Size(650, 550)
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
