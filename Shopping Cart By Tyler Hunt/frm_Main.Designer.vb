<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
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
        Me.mnuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetCtrlRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitCtrlQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_SelectedProducts = New System.Windows.Forms.GroupBox()
        Me.lb_SelectedList = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.mnuStrip_Main.SuspendLayout()
        Me.gb_SelectedProducts.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuStrip_Main
        '
        Me.mnuStrip_Main.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.mnuStrip_Main.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ProductsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.mnuStrip_Main.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip_Main.Name = "mnuStrip_Main"
        Me.mnuStrip_Main.Size = New System.Drawing.Size(1082, 40)
        Me.mnuStrip_Main.TabIndex = 0
        Me.mnuStrip_Main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetCtrlRToolStripMenuItem, Me.ExitCtrlQToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(64, 38)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStripMenuItem, Me.AudioBooksToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(119, 38)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(77, 38)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ResetCtrlRToolStripMenuItem
        '
        Me.ResetCtrlRToolStripMenuItem.Name = "ResetCtrlRToolStripMenuItem"
        Me.ResetCtrlRToolStripMenuItem.Size = New System.Drawing.Size(314, 38)
        Me.ResetCtrlRToolStripMenuItem.Text = "Reset          Ctrl+R"
        '
        'ExitCtrlQToolStripMenuItem
        '
        Me.ExitCtrlQToolStripMenuItem.Name = "ExitCtrlQToolStripMenuItem"
        Me.ExitCtrlQToolStripMenuItem.Size = New System.Drawing.Size(314, 38)
        Me.ExitCtrlQToolStripMenuItem.Text = "Exit             Ctrl+Q"
        '
        'PrintBooksToolStripMenuItem
        '
        Me.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem"
        Me.PrintBooksToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.PrintBooksToolStripMenuItem.Text = "&Print Books"
        '
        'AudioBooksToolStripMenuItem
        '
        Me.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem"
        Me.AudioBooksToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AudioBooksToolStripMenuItem.Text = "&Audio Books"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(269, 38)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'gb_SelectedProducts
        '
        Me.gb_SelectedProducts.Controls.Add(Me.Button1)
        Me.gb_SelectedProducts.Controls.Add(Me.TextBox4)
        Me.gb_SelectedProducts.Controls.Add(Me.TextBox3)
        Me.gb_SelectedProducts.Controls.Add(Me.TextBox2)
        Me.gb_SelectedProducts.Controls.Add(Me.TextBox1)
        Me.gb_SelectedProducts.Controls.Add(Me.Label4)
        Me.gb_SelectedProducts.Controls.Add(Me.Label3)
        Me.gb_SelectedProducts.Controls.Add(Me.Label2)
        Me.gb_SelectedProducts.Controls.Add(Me.Label1)
        Me.gb_SelectedProducts.Controls.Add(Me.lb_SelectedList)
        Me.gb_SelectedProducts.Location = New System.Drawing.Point(12, 62)
        Me.gb_SelectedProducts.Name = "gb_SelectedProducts"
        Me.gb_SelectedProducts.Size = New System.Drawing.Size(1050, 514)
        Me.gb_SelectedProducts.TabIndex = 1
        Me.gb_SelectedProducts.TabStop = False
        Me.gb_SelectedProducts.Text = "Products Selected"
        '
        'lb_SelectedList
        '
        Me.lb_SelectedList.FormattingEnabled = True
        Me.lb_SelectedList.ItemHeight = 25
        Me.lb_SelectedList.Location = New System.Drawing.Point(16, 48)
        Me.lb_SelectedList.Name = "lb_SelectedList"
        Me.lb_SelectedList.Size = New System.Drawing.Size(656, 404)
        Me.lb_SelectedList.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(720, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Subtotal:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(763, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tax:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(715, 217)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 25)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Shipping:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(751, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 25)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Total:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(836, 72)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 31)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(836, 139)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 31)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(836, 217)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 31)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(836, 284)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(192, 31)
        Me.TextBox4.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(201, 50)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Remove"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1082, 593)
        Me.Controls.Add(Me.gb_SelectedProducts)
        Me.Controls.Add(Me.mnuStrip_Main)
        Me.MainMenuStrip = Me.mnuStrip_Main
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart By Tyle Hunt"
        Me.mnuStrip_Main.ResumeLayout(False)
        Me.mnuStrip_Main.PerformLayout()
        Me.gb_SelectedProducts.ResumeLayout(False)
        Me.gb_SelectedProducts.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuStrip_Main As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResetCtrlRToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitCtrlQToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrintBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AudioBooksToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents gb_SelectedProducts As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lb_SelectedList As ListBox
End Class
