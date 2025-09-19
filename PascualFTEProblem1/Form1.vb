Public Class Form1
    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        Try

            Dim customerName As String = txtCustomerName.Text
            If String.IsNullOrWhiteSpace(customerName) Then
                MessageBox.Show("Please enter customer name.")
                Exit Sub
            End If


            If Beverage.SelectedIndex = -1 Then
                MessageBox.Show("Please select a beverage.")
                Exit Sub
            End If


            Dim quantity As Integer
            If Not Integer.TryParse(txtQuantity.Text, quantity) OrElse quantity <= 0 Then
                MessageBox.Show("Please enter a valid positive number for quantity.")
                Exit Sub
            End If

            Dim price As Integer
            Select Case Beverage.SelectedItem.ToString()
                Case "Espresso" : price = 120
                Case "Latte" : price = 150
                Case "Cappuccino" : price = 160
                Case "Americano" : price = 130
                Case "Mocha" : price = 170
                Case Else
                    MessageBox.Show("Invalid beverage selected.")
                    Exit Sub
            End Select

            Dim subtotal As Decimal = price * quantity
            Dim discount As Decimal = 0

            If chkDiscount.Checked Then
                discount = subtotal * 0.1
            End If

            Dim finalTotal As Decimal = subtotal - discount

            lblSubtotal.Text = "₱" & subtotal.ToString("F2")
            lblDiscount.Text = "₱" & discount.ToString("F2")
            lblFinalTotal.Text = "₱" & finalTotal.ToString("F2")


            MessageBox.Show("Order for " & customerName & " submitted. Total: ₱" & finalTotal.ToString("F2"))

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub
End Class
