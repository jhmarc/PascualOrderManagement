<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Beverage = New System.Windows.Forms.ComboBox()
        Me.chkDiscount = New System.Windows.Forms.CheckBox()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblSubtotal = New System.Windows.Forms.Label()
        Me.lblDiscount = New System.Windows.Forms.Label()
        Me.lblFinalTotal = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.lblCustomerName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(275, 55)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 4
        '
        'Beverage
        '
        Me.Beverage.FormattingEnabled = True
        Me.Beverage.Items.AddRange(New Object() {"Espresso", "Latte", "Cappuccino", "Americano", "Mocha"})
        Me.Beverage.Location = New System.Drawing.Point(275, 88)
        Me.Beverage.Name = "Beverage"
        Me.Beverage.Size = New System.Drawing.Size(121, 21)
        Me.Beverage.TabIndex = 5
        '
        'chkDiscount
        '
        Me.chkDiscount.AutoSize = True
        Me.chkDiscount.Location = New System.Drawing.Point(275, 169)
        Me.chkDiscount.Name = "chkDiscount"
        Me.chkDiscount.Size = New System.Drawing.Size(68, 17)
        Me.chkDiscount.TabIndex = 7
        Me.chkDiscount.Text = "Discount"
        Me.chkDiscount.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(275, 198)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 30)
        Me.btnPlaceOrder.TabIndex = 8
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblSubtotal
        '
        Me.lblSubtotal.AutoSize = True
        Me.lblSubtotal.Location = New System.Drawing.Point(220, 251)
        Me.lblSubtotal.Name = "lblSubtotal"
        Me.lblSubtotal.Size = New System.Drawing.Size(46, 13)
        Me.lblSubtotal.TabIndex = 11
        Me.lblSubtotal.Text = "Subtotal"
        '
        'lblDiscount
        '
        Me.lblDiscount.AutoSize = True
        Me.lblDiscount.Location = New System.Drawing.Point(301, 251)
        Me.lblDiscount.Name = "lblDiscount"
        Me.lblDiscount.Size = New System.Drawing.Size(49, 13)
        Me.lblDiscount.TabIndex = 12
        Me.lblDiscount.Text = "Discount"
        '
        'lblFinalTotal
        '
        Me.lblFinalTotal.AutoSize = True
        Me.lblFinalTotal.Location = New System.Drawing.Point(384, 251)
        Me.lblFinalTotal.Name = "lblFinalTotal"
        Me.lblFinalTotal.Size = New System.Drawing.Size(56, 13)
        Me.lblFinalTotal.TabIndex = 13
        Me.lblFinalTotal.Text = "Final Total"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(275, 132)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(100, 20)
        Me.txtQuantity.TabIndex = 14
        '
        'lblCustomerName
        '
        Me.lblCustomerName.AutoSize = True
        Me.lblCustomerName.Location = New System.Drawing.Point(175, 58)
        Me.lblCustomerName.Name = "lblCustomerName"
        Me.lblCustomerName.Size = New System.Drawing.Size(82, 13)
        Me.lblCustomerName.TabIndex = 15
        Me.lblCustomerName.Text = "Customer Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(175, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Select Beverage"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(175, 135)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(97, 13)
        Me.Label.TabIndex = 17
        Me.Label.Text = "Select For Quantity"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCustomerName)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.lblFinalTotal)
        Me.Controls.Add(Me.lblDiscount)
        Me.Controls.Add(Me.lblSubtotal)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.chkDiscount)
        Me.Controls.Add(Me.Beverage)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents Beverage As ComboBox
    Friend WithEvents chkDiscount As CheckBox
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblSubtotal As Label
    Friend WithEvents lblDiscount As Label
    Friend WithEvents lblFinalTotal As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblCustomerName As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label As Label
End Class
