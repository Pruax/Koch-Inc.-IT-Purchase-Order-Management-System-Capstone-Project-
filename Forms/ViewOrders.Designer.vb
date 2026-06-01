<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmViewOrder
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
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.lstbox = New System.Windows.Forms.ListBox()
        Me.lblOrderContents = New System.Windows.Forms.Label()
        Me.clstboxSelectOrder = New System.Windows.Forms.CheckedListBox()
        Me.lblApprovalStatus = New System.Windows.Forms.Label()
        Me.txtOrderStatus = New System.Windows.Forms.TextBox()
        Me.btnApproveOrder = New System.Windows.Forms.Button()
        Me.btnReturnNavPane = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Location = New System.Drawing.Point(27, 43)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(66, 13)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select Order"
        '
        'lstbox
        '
        Me.lstbox.FormattingEnabled = True
        Me.lstbox.Location = New System.Drawing.Point(350, 43)
        Me.lstbox.Name = "lstbox"
        Me.lstbox.Size = New System.Drawing.Size(107, 147)
        Me.lstbox.TabIndex = 2
        '
        'lblOrderContents
        '
        Me.lblOrderContents.AutoSize = True
        Me.lblOrderContents.Location = New System.Drawing.Point(266, 43)
        Me.lblOrderContents.Name = "lblOrderContents"
        Me.lblOrderContents.Size = New System.Drawing.Size(78, 13)
        Me.lblOrderContents.TabIndex = 3
        Me.lblOrderContents.Text = "Order Contents"
        '
        'clstboxSelectOrder
        '
        Me.clstboxSelectOrder.FormattingEnabled = True
        Me.clstboxSelectOrder.Location = New System.Drawing.Point(99, 43)
        Me.clstboxSelectOrder.Name = "clstboxSelectOrder"
        Me.clstboxSelectOrder.Size = New System.Drawing.Size(112, 169)
        Me.clstboxSelectOrder.TabIndex = 4
        '
        'lblApprovalStatus
        '
        Me.lblApprovalStatus.AutoSize = True
        Me.lblApprovalStatus.Location = New System.Drawing.Point(485, 103)
        Me.lblApprovalStatus.Name = "lblApprovalStatus"
        Me.lblApprovalStatus.Size = New System.Drawing.Size(111, 13)
        Me.lblApprovalStatus.TabIndex = 5
        Me.lblApprovalStatus.Text = "Order Approval Status"
        '
        'txtOrderStatus
        '
        Me.txtOrderStatus.Location = New System.Drawing.Point(546, 119)
        Me.txtOrderStatus.Name = "txtOrderStatus"
        Me.txtOrderStatus.Size = New System.Drawing.Size(50, 20)
        Me.txtOrderStatus.TabIndex = 6
        '
        'btnApproveOrder
        '
        Me.btnApproveOrder.Location = New System.Drawing.Point(488, 43)
        Me.btnApproveOrder.Name = "btnApproveOrder"
        Me.btnApproveOrder.Size = New System.Drawing.Size(111, 23)
        Me.btnApproveOrder.TabIndex = 7
        Me.btnApproveOrder.Text = "Approve Order"
        Me.btnApproveOrder.UseVisualStyleBackColor = True
        '
        'btnReturnNavPane
        '
        Me.btnReturnNavPane.Location = New System.Drawing.Point(15, 248)
        Me.btnReturnNavPane.Name = "btnReturnNavPane"
        Me.btnReturnNavPane.Size = New System.Drawing.Size(78, 40)
        Me.btnReturnNavPane.TabIndex = 8
        Me.btnReturnNavPane.Text = "Return to Nav. Pane"
        Me.btnReturnNavPane.UseVisualStyleBackColor = True
        '
        'frmViewOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 305)
        Me.Controls.Add(Me.btnReturnNavPane)
        Me.Controls.Add(Me.btnApproveOrder)
        Me.Controls.Add(Me.txtOrderStatus)
        Me.Controls.Add(Me.lblApprovalStatus)
        Me.Controls.Add(Me.clstboxSelectOrder)
        Me.Controls.Add(Me.lblOrderContents)
        Me.Controls.Add(Me.lstbox)
        Me.Controls.Add(Me.lblSelect)
        Me.Name = "frmViewOrder"
        Me.Text = "View Orders"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSelect As Label
    Friend WithEvents lstbox As ListBox
    Friend WithEvents lblOrderContents As Label
    Friend WithEvents clstboxSelectOrder As CheckedListBox
    Friend WithEvents lblApprovalStatus As Label
    Friend WithEvents txtOrderStatus As TextBox
    Friend WithEvents btnApproveOrder As Button
    Friend WithEvents btnReturnNavPane As Button
End Class
