Module mdl_ShoppingCart

    Public Const gDec_TAXRATE As Decimal = 0.06D
    Public Const gDEC_ShippingCharge As Decimal = 2D

    Public Const gDEC_Book0 As Decimal = 11.95D
    Public Const gDEC_Book1 As Decimal = 14.5D
    Public Const gDEC_Book2 As Decimal = 29.95D
    Public Const gDEC_Book3 As Decimal = 18.5D
    Public Const gDEC_Book4 As Decimal = 29.95D
    Public Const gDEC_Book5 As Decimal = 14.5D
    Public Const gDEC_Book6 As Decimal = 12.95D
    Public Const gDEC_Book7 As Decimal = 11.5D

    Public gDec_PricesArray As Decimal() = {gDEC_Book0, gDEC_Book1, gDEC_Book2, gDEC_Book3,
                                            gDEC_Book4, gDEC_Book5, gDEC_Book6, gDEC_Book7}

    Public SelectCostList As New List(Of Decimal)()

    Sub updateCostSummary()
        Dim subTotal As Decimal = 0D
        Dim taxTotal As Decimal = 0D
        Dim itemCount As Single = 0S
        Dim shippingCostTotal As Decimal = 0D
        Dim finalTotal As Decimal = 0D

        'Loop thru selected costs and Sum
        For Each num In SelectCostList
            subTotal += num
            itemCount += 1
        Next

        'Add string to the Subtotal text box
        My.Forms.frm_Main.txt_SubTotal.Text = subTotal.ToString("c2")

        'Calc tax and Add string to the Tax textBox
        taxTotal = subTotal * gDec_TAXRATE
        My.Forms.frm_Main.txt_Tax.Text = taxTotal.ToString("c2")

        'Calc shipping cost
        shippingCostTotal = CDec(itemCount) * gDEC_ShippingCharge
        My.Forms.frm_Main.txt_Shipping.Text = shippingCostTotal.ToString("c2")

        finalTotal = subTotal + taxTotal + shippingCostTotal
        My.Forms.frm_Main.txt_Total.Text = finalTotal.ToString("c2")


    End Sub

End Module
