Public Class frmNavPane
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'btnExit will exit the system at this point, saving no data or progress a user has made
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        'btnLogout will be used to log the current user out of the system and return them to the main login screen.
        frmLogin.Show()
        Me.Close()
    End Sub

    Private Sub btnOrderForm_Click(sender As Object, e As EventArgs) Handles btnOrderForm.Click
        'btnOrderForm will be available for all users. This will take them to the order form for the system
        'There will not need to be a check for the employees credintals since all users can access this, but we will need to store the users info for the order
        frmOrderForm.Show()
        Me.Close()
    End Sub

    Private Sub btnViewOrder_Click(sender As Object, e As EventArgs) Handles btnViewOrder.Click
        'btnViewOrder will vary between the users. Employees will only be able to view their own orders. While Management should be able to view all orders/past orders
        frmViewOrder.Show()
        Me.Close()
    End Sub

    Private Sub btnApprovals_Click(sender As Object, e As EventArgs) Handles btnApprovals.Click
        'Approvals will only be shown to Management roles. So it will either show up greyed out for nomral Employees or it will been hidden.
        frmApprovals.Show()
        Me.Close()
    End Sub
End Class