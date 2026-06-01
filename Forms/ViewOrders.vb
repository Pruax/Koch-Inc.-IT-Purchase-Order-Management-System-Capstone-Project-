Public Class frmViewOrder
    Private Sub btnReturnNavPane_Click(sender As Object, e As EventArgs) Handles btnReturnNavPane.Click
        'Will return the user to the Home screen without saving any progress.
        frmNavPane.Show()
        Me.Close()
    End Sub

    Private Sub btnApproveOrder_Click(sender As Object, e As EventArgs) Handles btnApproveOrder.Click
        'Approve button should only be visable to management roles. 
    End Sub

    Private Sub frmViewOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class