Public Class frmOrderForm
    Private Sub btnReturnPane_Click(sender As Object, e As EventArgs) Handles btnReturnPane.Click
        'Will return the user to the Home screen without saving any progress.
        frmNavPane.Show()
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Will cancel all operations and close the system.
        Me.Close()
    End Sub

    Private Sub btnPlaceOrder_Click(sender As Object, e As EventArgs) Handles btnPlaceOrder.Click
        'Will place order within the system Selected items and quantities should be stored in the database along with an order number.
        'A prompt will pop up asking user if they are ready to confirm(place) order. If no they will be returned back to the order form screen. 
        'If yes their order will be confirmed with an order number and the manager that will approve the order before it it finalized. 


    End Sub

End Class