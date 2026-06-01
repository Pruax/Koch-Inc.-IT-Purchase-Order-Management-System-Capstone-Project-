<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderForm
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
        Me.btnReturnPane = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnPlaceOrder = New System.Windows.Forms.Button()
        Me.lblComputer = New System.Windows.Forms.Label()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblAcc = New System.Windows.Forms.Label()
        Me.txtComputerQuan = New System.Windows.Forms.TextBox()
        Me.txtAccQuan = New System.Windows.Forms.TextBox()
        Me.txtPrinterQuan = New System.Windows.Forms.TextBox()
        Me.txtDisplayQuan = New System.Windows.Forms.TextBox()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox3 = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox4 = New System.Windows.Forms.CheckedListBox()
        Me.lblComputerDescription = New System.Windows.Forms.Label()
        Me.lblDisplayDescription = New System.Windows.Forms.Label()
        Me.lblPrinterDescription = New System.Windows.Forms.Label()
        Me.lblAccessDescription = New System.Windows.Forms.Label()
        Me.pbComputer = New System.Windows.Forms.PictureBox()
        Me.pbAccess = New System.Windows.Forms.PictureBox()
        Me.pbPrinter = New System.Windows.Forms.PictureBox()
        Me.pbDisplay = New System.Windows.Forms.PictureBox()
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAccess, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPrinter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnReturnPane
        '
        Me.btnReturnPane.Location = New System.Drawing.Point(10, 522)
        Me.btnReturnPane.Name = "btnReturnPane"
        Me.btnReturnPane.Size = New System.Drawing.Size(90, 37)
        Me.btnReturnPane.TabIndex = 0
        Me.btnReturnPane.Text = "Return to Nav. Pane"
        Me.btnReturnPane.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(106, 536)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnPlaceOrder
        '
        Me.btnPlaceOrder.Location = New System.Drawing.Point(613, 522)
        Me.btnPlaceOrder.Name = "btnPlaceOrder"
        Me.btnPlaceOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnPlaceOrder.TabIndex = 2
        Me.btnPlaceOrder.Text = "Place Order"
        Me.btnPlaceOrder.UseVisualStyleBackColor = True
        '
        'lblComputer
        '
        Me.lblComputer.AutoSize = True
        Me.lblComputer.Location = New System.Drawing.Point(103, 94)
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(63, 13)
        Me.lblComputer.TabIndex = 8
        Me.lblComputer.Text = "Computer(s)"
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(273, 94)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(52, 13)
        Me.lblDisplay.TabIndex = 9
        Me.lblDisplay.Text = "Display(s)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(465, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Printer(s)"
        '
        'lblAcc
        '
        Me.lblAcc.AutoSize = True
        Me.lblAcc.Location = New System.Drawing.Point(628, 94)
        Me.lblAcc.Name = "lblAcc"
        Me.lblAcc.Size = New System.Drawing.Size(113, 13)
        Me.lblAcc.TabIndex = 11
        Me.lblAcc.Text = "Additional Accessories"
        '
        'txtComputerQuan
        '
        Me.txtComputerQuan.Location = New System.Drawing.Point(68, 425)
        Me.txtComputerQuan.Name = "txtComputerQuan"
        Me.txtComputerQuan.Size = New System.Drawing.Size(41, 20)
        Me.txtComputerQuan.TabIndex = 12
        '
        'txtAccQuan
        '
        Me.txtAccQuan.Location = New System.Drawing.Point(631, 425)
        Me.txtAccQuan.Name = "txtAccQuan"
        Me.txtAccQuan.Size = New System.Drawing.Size(41, 20)
        Me.txtAccQuan.TabIndex = 13
        '
        'txtPrinterQuan
        '
        Me.txtPrinterQuan.Location = New System.Drawing.Point(449, 425)
        Me.txtPrinterQuan.Name = "txtPrinterQuan"
        Me.txtPrinterQuan.Size = New System.Drawing.Size(41, 20)
        Me.txtPrinterQuan.TabIndex = 14
        '
        'txtDisplayQuan
        '
        Me.txtDisplayQuan.Location = New System.Drawing.Point(252, 425)
        Me.txtDisplayQuan.Name = "txtDisplayQuan"
        Me.txtDisplayQuan.Size = New System.Drawing.Size(41, 20)
        Me.txtDisplayQuan.TabIndex = 15
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(7, 432)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 16
        Me.lblQuantity.Text = "Quantity"
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(46, 110)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 154)
        Me.CheckedListBox1.TabIndex = 17
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(242, 110)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.Size = New System.Drawing.Size(114, 154)
        Me.CheckedListBox2.TabIndex = 18
        '
        'CheckedListBox3
        '
        Me.CheckedListBox3.FormattingEnabled = True
        Me.CheckedListBox3.Location = New System.Drawing.Point(439, 110)
        Me.CheckedListBox3.Name = "CheckedListBox3"
        Me.CheckedListBox3.Size = New System.Drawing.Size(108, 154)
        Me.CheckedListBox3.TabIndex = 19
        '
        'CheckedListBox4
        '
        Me.CheckedListBox4.FormattingEnabled = True
        Me.CheckedListBox4.Location = New System.Drawing.Point(621, 110)
        Me.CheckedListBox4.Name = "CheckedListBox4"
        Me.CheckedListBox4.Size = New System.Drawing.Size(129, 154)
        Me.CheckedListBox4.TabIndex = 20
        '
        'lblComputerDescription
        '
        Me.lblComputerDescription.AutoSize = True
        Me.lblComputerDescription.Location = New System.Drawing.Point(74, 289)
        Me.lblComputerDescription.Name = "lblComputerDescription"
        Me.lblComputerDescription.Size = New System.Drawing.Size(28, 13)
        Me.lblComputerDescription.TabIndex = 21
        Me.lblComputerDescription.Text = "Test"
        '
        'lblDisplayDescription
        '
        Me.lblDisplayDescription.AutoSize = True
        Me.lblDisplayDescription.Location = New System.Drawing.Point(286, 289)
        Me.lblDisplayDescription.Name = "lblDisplayDescription"
        Me.lblDisplayDescription.Size = New System.Drawing.Size(28, 13)
        Me.lblDisplayDescription.TabIndex = 22
        Me.lblDisplayDescription.Text = "Test"
        '
        'lblPrinterDescription
        '
        Me.lblPrinterDescription.AutoSize = True
        Me.lblPrinterDescription.Location = New System.Drawing.Point(468, 289)
        Me.lblPrinterDescription.Name = "lblPrinterDescription"
        Me.lblPrinterDescription.Size = New System.Drawing.Size(28, 13)
        Me.lblPrinterDescription.TabIndex = 23
        Me.lblPrinterDescription.Text = "Test"
        '
        'lblAccessDescription
        '
        Me.lblAccessDescription.AutoSize = True
        Me.lblAccessDescription.Location = New System.Drawing.Point(648, 289)
        Me.lblAccessDescription.Name = "lblAccessDescription"
        Me.lblAccessDescription.Size = New System.Drawing.Size(28, 13)
        Me.lblAccessDescription.TabIndex = 24
        Me.lblAccessDescription.Text = "Test"
        '
        'pbComputer
        '
        Me.pbComputer.Location = New System.Drawing.Point(46, 361)
        Me.pbComputer.Name = "pbComputer"
        Me.pbComputer.Size = New System.Drawing.Size(100, 50)
        Me.pbComputer.TabIndex = 25
        Me.pbComputer.TabStop = False
        '
        'pbAccess
        '
        Me.pbAccess.Location = New System.Drawing.Point(631, 361)
        Me.pbAccess.Name = "pbAccess"
        Me.pbAccess.Size = New System.Drawing.Size(100, 50)
        Me.pbAccess.TabIndex = 26
        Me.pbAccess.TabStop = False
        '
        'pbPrinter
        '
        Me.pbPrinter.Location = New System.Drawing.Point(447, 361)
        Me.pbPrinter.Name = "pbPrinter"
        Me.pbPrinter.Size = New System.Drawing.Size(100, 50)
        Me.pbPrinter.TabIndex = 27
        Me.pbPrinter.TabStop = False
        '
        'pbDisplay
        '
        Me.pbDisplay.Location = New System.Drawing.Point(225, 361)
        Me.pbDisplay.Name = "pbDisplay"
        Me.pbDisplay.Size = New System.Drawing.Size(100, 50)
        Me.pbDisplay.TabIndex = 28
        Me.pbDisplay.TabStop = False
        '
        'frmOrderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 594)
        Me.Controls.Add(Me.pbDisplay)
        Me.Controls.Add(Me.pbPrinter)
        Me.Controls.Add(Me.pbAccess)
        Me.Controls.Add(Me.pbComputer)
        Me.Controls.Add(Me.lblAccessDescription)
        Me.Controls.Add(Me.lblPrinterDescription)
        Me.Controls.Add(Me.lblDisplayDescription)
        Me.Controls.Add(Me.lblComputerDescription)
        Me.Controls.Add(Me.CheckedListBox4)
        Me.Controls.Add(Me.CheckedListBox3)
        Me.Controls.Add(Me.CheckedListBox2)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.txtDisplayQuan)
        Me.Controls.Add(Me.txtPrinterQuan)
        Me.Controls.Add(Me.txtAccQuan)
        Me.Controls.Add(Me.txtComputerQuan)
        Me.Controls.Add(Me.lblAcc)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.lblComputer)
        Me.Controls.Add(Me.btnPlaceOrder)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReturnPane)
        Me.Name = "frmOrderForm"
        Me.Text = "Order Form"
        CType(Me.pbComputer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAccess, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPrinter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReturnPane As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnPlaceOrder As Button
    Friend WithEvents lblComputer As Label
    Friend WithEvents lblDisplay As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblAcc As Label
    Friend WithEvents txtComputerQuan As TextBox
    Friend WithEvents txtAccQuan As TextBox
    Friend WithEvents txtPrinterQuan As TextBox
    Friend WithEvents txtDisplayQuan As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents CheckedListBox2 As CheckedListBox
    Friend WithEvents CheckedListBox3 As CheckedListBox
    Friend WithEvents CheckedListBox4 As CheckedListBox
    Friend WithEvents lblComputerDescription As Label
    Friend WithEvents lblDisplayDescription As Label
    Friend WithEvents lblPrinterDescription As Label
    Friend WithEvents lblAccessDescription As Label
    Friend WithEvents pbComputer As PictureBox
    Friend WithEvents pbAccess As PictureBox
    Friend WithEvents pbPrinter As PictureBox
    Friend WithEvents pbDisplay As PictureBox
End Class
