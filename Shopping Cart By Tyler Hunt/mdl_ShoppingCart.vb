Module mdl_ShoppingCart
    'Constant for Tax rate and shipping cost
    Public Const gDec_TAXRATE As Decimal = 0.06D
    Public Const gDEC_SHIPPINGCHARGES As Decimal = 2D
    Public gSng_SelectedItemCount As Single = 0S                '?????? not sure if needed

    'Constants for each respective book
    Public Const gDEC_Book0 As Decimal = 11.95D
    Public Const gDEC_Book1 As Decimal = 14.5D
    Public Const gDEC_Book2 As Decimal = 29.95D
    Public Const gDEC_Book3 As Decimal = 18.5D
    Public Const gDEC_Book4 As Decimal = 29.95D
    Public Const gDEC_Book5 As Decimal = 14.5D
    Public Const gDEC_Book6 As Decimal = 12.95D
    Public Const gDEC_Book7 As Decimal = 11.5D

    'Array to hold the book prices
    Public gDec_PricesArray As Decimal() = {gDEC_Book0, gDEC_Book1, gDEC_Book2, gDEC_Book3,
                                            gDEC_Book4, gDEC_Book5, gDEC_Book6, gDEC_Book7}


    Public gLst_SelectCostList As New List(Of Decimal)()

    Sub updateCostSummary()
        'Declare local variables
        Dim subTotal As Decimal = 0D
        Dim taxTotal As Decimal = 0D
        Dim count As Single = 0S
        Dim shippingCostTotal As Decimal = 0D
        Dim finalTotal As Decimal = 0D

        'Loop thru selected costs and Sum the value
        For Each num In gLst_SelectCostList
            subTotal += num
            gSng_SelectedItemCount += 1  'TODO: not sure if this is needed or not   will test
            count += 1
        Next

        'Add string to the Subtotal txtbox
        My.Forms.frm_Main.txt_SubTotal.Text = subTotal.ToString("c2")  'TODO: Test why the remove function is not working properly

        'Calc tax and Add string to the Tax txtBox
        taxTotal = subTotal * gDec_TAXRATE
        My.Forms.frm_Main.txt_Tax.Text = taxTotal.ToString("c2")

        'Calc shipping costS and place in shipping txtbox
        shippingCostTotal = CDec(count) * gDEC_SHIPPINGCHARGES
        My.Forms.frm_Main.txt_Shipping.Text = shippingCostTotal.ToString("c2")

        'Calc total costs and plac in total txtbox
        finalTotal = subTotal + taxTotal + shippingCostTotal
        My.Forms.frm_Main.txt_Total.Text = finalTotal.ToString("c2")

    End Sub

    'Method to reset the form and all other values
    Sub resetForm()

        'Clear main form values
        frm_Main.txt_SubTotal.Text = String.Empty
        frm_Main.txt_Tax.Text = String.Empty
        frm_Main.txt_Shipping.Text = String.Empty
        frm_Main.txt_Total.Text = String.Empty

        'Clear selected List 
        gLst_SelectCostList.Clear()

        'Clear select listbox values
        My.Forms.frm_Main.lb_SelectedList.Items.Clear()


    End Sub

End Module
