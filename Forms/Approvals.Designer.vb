<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmApprovals
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
        Me.lblOrderWaiting = New System.Windows.Forms.Label()
        Me.clstboxOrderWait = New System.Windows.Forms.CheckedListBox()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.lblApprovedOrders = New System.Windows.Forms.Label()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOrderWaiting
        '
        Me.lblOrderWaiting.AutoSize = True
        Me.lblOrderWaiting.Location = New System.Drawing.Point(12, 41)
        Me.lblOrderWaiting.Name = "lblOrderWaiting"
        Me.lblOrderWaiting.Size = New System.Drawing.Size(122, 13)
        Me.lblOrderWaiting.TabIndex = 0
        Me.lblOrderWaiting.Text = "Orders Waiting Approval"
        '
        'clstboxOrderWait
        '
        Me.clstboxOrderWait.FormattingEnabled = True
        Me.clstboxOrderWait.Location = New System.Drawing.Point(140, 41)
        Me.clstboxOrderWait.Name = "clstboxOrderWait"
        Me.clstboxOrderWait.Size = New System.Drawing.Size(127, 184)
        Me.clstboxOrderWait.TabIndex = 1
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(441, 41)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(129, 169)
        Me.CheckedListBox1.TabIndex = 2
        '
        'lblApprovedOrders
        '
        Me.lblApprovedOrders.AutoSize = True
        Me.lblApprovedOrders.Location = New System.Drawing.Point(348, 41)
        Me.lblApprovedOrders.Name = "lblApprovedOrders"
        Me.lblApprovedOrders.Size = New System.Drawing.Size(87, 13)
        Me.lblApprovedOrders.TabIndex = 3
        Me.lblApprovedOrders.Text = "Approved Orders"
        '
        'btnReturn
        '
        Me.btnReturn.Location = New System.Drawing.Point(24, 278)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(84, 43)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return to Nav. Pane"
        Me.btnReturn.UseVisualStyleBackColor = True
        '
        'frmApprovals
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(668, 408)
        Me.Controls.Add(Me.btnReturn)
        Me.Controls.Add(Me.lblApprovedOrders)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.clstboxOrderWait)
        Me.Controls.Add(Me.lblOrderWaiting)
        Me.Name = "frmApprovals"
        Me.Text = "Approvals"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOrderWaiting As Label
    Friend WithEvents clstboxOrderWait As CheckedListBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents lblApprovedOrders As Label
    Friend WithEvents btnReturn As Button
End Class
