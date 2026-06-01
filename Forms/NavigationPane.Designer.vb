<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNavPane
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
        Me.btnOrderForm = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnApprovals = New System.Windows.Forms.Button()
        Me.btnViewOrder = New System.Windows.Forms.Button()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnOrderForm
        '
        Me.btnOrderForm.Location = New System.Drawing.Point(44, 46)
        Me.btnOrderForm.Name = "btnOrderForm"
        Me.btnOrderForm.Size = New System.Drawing.Size(75, 23)
        Me.btnOrderForm.TabIndex = 0
        Me.btnOrderForm.Text = "Order Form"
        Me.btnOrderForm.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(213, 254)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnApprovals
        '
        Me.btnApprovals.Location = New System.Drawing.Point(44, 183)
        Me.btnApprovals.Name = "btnApprovals"
        Me.btnApprovals.Size = New System.Drawing.Size(75, 23)
        Me.btnApprovals.TabIndex = 2
        Me.btnApprovals.Text = "Approvals"
        Me.btnApprovals.UseVisualStyleBackColor = True
        '
        'btnViewOrder
        '
        Me.btnViewOrder.Location = New System.Drawing.Point(44, 88)
        Me.btnViewOrder.Name = "btnViewOrder"
        Me.btnViewOrder.Size = New System.Drawing.Size(75, 23)
        Me.btnViewOrder.TabIndex = 3
        Me.btnViewOrder.Text = "View Order"
        Me.btnViewOrder.UseVisualStyleBackColor = True
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(12, 254)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(75, 23)
        Me.btnLogout.TabIndex = 4
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'frmNavPane
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(338, 301)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnViewOrder)
        Me.Controls.Add(Me.btnApprovals)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOrderForm)
        Me.Name = "frmNavPane"
        Me.Text = "Navigation Pane"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnOrderForm As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnApprovals As Button
    Friend WithEvents btnViewOrder As Button
    Friend WithEvents btnLogout As Button
End Class
