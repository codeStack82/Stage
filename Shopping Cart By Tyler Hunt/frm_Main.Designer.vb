﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.mnuStrip_Main = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetCtrlRToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitCtrlQToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AudioBooksToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.gb_SelectedProducts = New System.Windows.Forms.GroupBox()
        Me.btn_Remove = New System.Windows.Forms.Button()
        Me.txt_Total = New System.Windows.Forms.TextBox()
        Me.txt_Shipping = New System.Windows.Forms.TextBox()
        Me.txt_Tax = New System.Windows.Forms.TextBox()
        Me.txt_SubTotal = New System.Windows.Forms.TextBox()
        Me.lbl_Totasl = New System.Windows.Forms.Label()
        Me.lbl_Shipping = New System.Windows.Forms.Label()
        Me.lbl_Tax = New System.Windows.Forms.Label()
        Me.lbl_SubTotal = New System.Windows.Forms.Label()
        Me.lb_SelectedList = New System.Windows.Forms.ListBox()
        Me.tt_MainFrm = New System.Windows.Forms.ToolTip(Me.components)
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
        Me.mnuStrip_Main.Padding = New System.Windows.Forms.Padding(3, 1, 0, 1)
        Me.mnuStrip_Main.Size = New System.Drawing.Size(541, 24)
        Me.mnuStrip_Main.TabIndex = 0
        Me.mnuStrip_Main.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResetCtrlRToolStripMenuItem, Me.ExitCtrlQToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 22)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ResetCtrlRToolStripMenuItem
        '
        Me.ResetCtrlRToolStripMenuItem.Name = "ResetCtrlRToolStripMenuItem"
        Me.ResetCtrlRToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ResetCtrlRToolStripMenuItem.Text = "Reset          Ctrl+R"
        '
        'ExitCtrlQToolStripMenuItem
        '
        Me.ExitCtrlQToolStripMenuItem.Name = "ExitCtrlQToolStripMenuItem"
        Me.ExitCtrlQToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ExitCtrlQToolStripMenuItem.Text = "Exit             Ctrl+Q"
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintBooksToolStripMenuItem, Me.AudioBooksToolStripMenuItem})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(66, 22)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'PrintBooksToolStripMenuItem
        '
        Me.PrintBooksToolStripMenuItem.Name = "PrintBooksToolStripMenuItem"
        Me.PrintBooksToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.PrintBooksToolStripMenuItem.Text = "&Print Books"
        '
        'AudioBooksToolStripMenuItem
        '
        Me.AudioBooksToolStripMenuItem.Name = "AudioBooksToolStripMenuItem"
        Me.AudioBooksToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.AudioBooksToolStripMenuItem.Text = "&Audio Books"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 22)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'gb_SelectedProducts
        '
        Me.gb_SelectedProducts.Controls.Add(Me.Button1)
        Me.gb_SelectedProducts.Controls.Add(Me.btn_Remove)
        Me.gb_SelectedProducts.Controls.Add(Me.txt_Total)
        Me.gb_SelectedProducts.Controls.Add(Me.txt_Shipping)
        Me.gb_SelectedProducts.Controls.Add(Me.txt_Tax)
        Me.gb_SelectedProducts.Controls.Add(Me.txt_SubTotal)
        Me.gb_SelectedProducts.Controls.Add(Me.lbl_Totasl)
        Me.gb_SelectedProducts.Controls.Add(Me.lbl_Shipping)
        Me.gb_SelectedProducts.Controls.Add(Me.lbl_Tax)
        Me.gb_SelectedProducts.Controls.Add(Me.lbl_SubTotal)
        Me.gb_SelectedProducts.Controls.Add(Me.lb_SelectedList)
        Me.gb_SelectedProducts.Location = New System.Drawing.Point(6, 32)
        Me.gb_SelectedProducts.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gb_SelectedProducts.Name = "gb_SelectedProducts"
        Me.gb_SelectedProducts.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gb_SelectedProducts.Size = New System.Drawing.Size(525, 280)
        Me.gb_SelectedProducts.TabIndex = 1
        Me.gb_SelectedProducts.TabStop = False
        Me.gb_SelectedProducts.Text = "Products Selected"
        '
        'btn_Remove
        '
        Me.btn_Remove.Location = New System.Drawing.Point(8, 244)
        Me.btn_Remove.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_Remove.Name = "btn_Remove"
        Me.btn_Remove.Size = New System.Drawing.Size(100, 26)
        Me.btn_Remove.TabIndex = 9
        Me.btn_Remove.Text = "Remove"
        Me.tt_MainFrm.SetToolTip(Me.btn_Remove, "Click to remove the selected  item from the Products List above.")
        Me.btn_Remove.UseVisualStyleBackColor = True
        '
        'txt_Total
        '
        Me.txt_Total.Enabled = False
        Me.txt_Total.Location = New System.Drawing.Point(418, 148)
        Me.txt_Total.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Total.Name = "txt_Total"
        Me.txt_Total.Size = New System.Drawing.Size(98, 20)
        Me.txt_Total.TabIndex = 8
        '
        'txt_Shipping
        '
        Me.txt_Shipping.Enabled = False
        Me.txt_Shipping.Location = New System.Drawing.Point(418, 113)
        Me.txt_Shipping.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Shipping.Name = "txt_Shipping"
        Me.txt_Shipping.Size = New System.Drawing.Size(98, 20)
        Me.txt_Shipping.TabIndex = 7
        '
        'txt_Tax
        '
        Me.txt_Tax.Enabled = False
        Me.txt_Tax.Location = New System.Drawing.Point(418, 72)
        Me.txt_Tax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_Tax.Name = "txt_Tax"
        Me.txt_Tax.Size = New System.Drawing.Size(98, 20)
        Me.txt_Tax.TabIndex = 6
        '
        'txt_SubTotal
        '
        Me.txt_SubTotal.Enabled = False
        Me.txt_SubTotal.Location = New System.Drawing.Point(418, 37)
        Me.txt_SubTotal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txt_SubTotal.Name = "txt_SubTotal"
        Me.txt_SubTotal.Size = New System.Drawing.Size(98, 20)
        Me.txt_SubTotal.TabIndex = 5
        '
        'lbl_Totasl
        '
        Me.lbl_Totasl.AutoSize = True
        Me.lbl_Totasl.Location = New System.Drawing.Point(376, 149)
        Me.lbl_Totasl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Totasl.Name = "lbl_Totasl"
        Me.lbl_Totasl.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Totasl.TabIndex = 4
        Me.lbl_Totasl.Text = "Total:"
        Me.lbl_Totasl.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Shipping
        '
        Me.lbl_Shipping.AutoSize = True
        Me.lbl_Shipping.Location = New System.Drawing.Point(358, 113)
        Me.lbl_Shipping.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Shipping.Name = "lbl_Shipping"
        Me.lbl_Shipping.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Shipping.TabIndex = 3
        Me.lbl_Shipping.Text = "Shipping:"
        Me.lbl_Shipping.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Tax
        '
        Me.lbl_Tax.AutoSize = True
        Me.lbl_Tax.Location = New System.Drawing.Point(382, 75)
        Me.lbl_Tax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_Tax.Name = "lbl_Tax"
        Me.lbl_Tax.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tax.TabIndex = 2
        Me.lbl_Tax.Text = "Tax:"
        Me.lbl_Tax.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_SubTotal
        '
        Me.lbl_SubTotal.AutoSize = True
        Me.lbl_SubTotal.Location = New System.Drawing.Point(360, 37)
        Me.lbl_SubTotal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbl_SubTotal.Name = "lbl_SubTotal"
        Me.lbl_SubTotal.Size = New System.Drawing.Size(49, 13)
        Me.lbl_SubTotal.TabIndex = 1
        Me.lbl_SubTotal.Text = "Subtotal:"
        Me.lbl_SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lb_SelectedList
        '
        Me.lb_SelectedList.FormattingEnabled = True
        Me.lb_SelectedList.Location = New System.Drawing.Point(8, 25)
        Me.lb_SelectedList.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lb_SelectedList.Name = "lb_SelectedList"
        Me.lb_SelectedList.Size = New System.Drawing.Size(330, 212)
        Me.lb_SelectedList.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(418, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(541, 319)
        Me.Controls.Add(Me.gb_SelectedProducts)
        Me.Controls.Add(Me.mnuStrip_Main)
        Me.MainMenuStrip = Me.mnuStrip_Main
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frm_Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shopping Cart By Tyler Hunt"
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
    Friend WithEvents btn_Remove As Button
    Friend WithEvents txt_Total As TextBox
    Friend WithEvents txt_Shipping As TextBox
    Friend WithEvents txt_Tax As TextBox
    Friend WithEvents txt_SubTotal As TextBox
    Friend WithEvents lbl_Totasl As Label
    Friend WithEvents lbl_Shipping As Label
    Friend WithEvents lbl_Tax As Label
    Friend WithEvents lbl_SubTotal As Label
    Friend WithEvents lb_SelectedList As ListBox
    Friend WithEvents tt_MainFrm As ToolTip
    Friend WithEvents Button1 As Button
End Class
