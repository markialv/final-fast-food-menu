Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Input variables declarations
        Dim sngBurgerPrice As Single
        Dim sngFriesPrice As Single
        Dim sngSodaPrice As Single
        Dim intBurgerCount As Integer
        Dim intFriesCount As Integer
        Dim intSodaCount As Integer

        ' Variables for computations
        Dim sngTotal As Single
        Dim sngTendered As Single
        Dim sngChange As Single

        ' Variables for denominations & coin counts
        Dim intTemp As Integer
        Dim intDollars As Integer
        Dim intCents As Integer
        Dim int20s As Integer
        Dim int10s As Integer
        Dim int5s As Integer
        Dim int1s As Integer
        Dim intQuarters As Integer
        Dim intDimes As Integer
        Dim intNickels As Integer
        Dim intPennies As Integer

        ' Get data from form
        sngBurgerPrice = CSng(lblBurgerPrice.Text)
        sngFriesPrice = CSng(lblFriesPrice.Text)
        sngSodaPrice = CSng(lblSodaPrice.Text)

        'in this line add statement for getting Soda price
        intBurgerCount = CInt(txtBurgerQty.Text)
        intFriesCount = CInt(txtFriesQty.Text)
        intSodaCount = CInt(txtSodaQty.Text)

        ' Calculate Total
        sngTotal = (sngBurgerPrice * intBurgerCount) + (sngFriesPrice * intFriesCount) + (sngSodaPrice * intSodaCount)
        lblTotal.Text = sngTotal.ToString("C")

        ' Get tendered amount from form and find the change
        sngTendered = CSng(txtTendered.Text)
        sngChange = sngTendered - sngTotal
        lblChange.Text = sngChange.ToString("C")

        ' Calculate change denominations & coin counts 
        intTemp = CInt(sngChange * 100) ' Convert all to cents
        intDollars = intTemp \ 100 ' Get dollars
        intCents = intTemp Mod 100 ' Get cents

        ' Calculate denominations and coins counts 
        int20s = intDollars \ 20 ' Find 20s count
        intDollars = intDollars Mod 20 ' Find remainder
        int10s = intDollars \ 10
        intDollars = intDollars Mod 10
        int5s = intDollars \ 5
        intDollars = intDollars Mod 5
        int1s = intDollars \ 1
        intDollars = intDollars Mod 1
        intQuarters = intCents \ 25
        intCents = intCents Mod 25
        intDimes = intCents \ 10
        intCents = intCents Mod 10
        intNickels = intCents \ 5
        intCents = intCents Mod 5

        ' at the end make sure to display numbers in their corresponding Labels: Total, Change, denominations and Coins.
        lbl20s.Text = CStr(int20s)
        lbl10s.Text = CStr(int10s)
        lbl5s.Text = CStr(int5s)
        lbl1s.Text = CStr(int1s)
        lblQuarters.Text = CStr(intQuarters)
        lblDimes.Text = CStr(intDimes)
        lblNickels.Text = CStr(intNickels)
        lblPennies.Text = CStr(intPennies)

    End Sub

    Private Sub btnClearAll_Click(sender As Object, e As EventArgs) Handles btnClearAll.Click
        txtBurgerQty.Text = ""
        txtFriesQty.Text = ""
        txtSodaQty.Text = ""
        txtTendered.Text = ""
        lblTotal.Text = ""
        lblChange.Text = ""
        lbl20s.Text = ""
        lbl10s.Text = ""
        lbl5s.Text = ""
        lbl1s.Text = ""
        lblQuarters.Text = ""
        lblDimes.Text = ""
        lblNickels.Text = ""
        lblPennies.Text = ""

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
