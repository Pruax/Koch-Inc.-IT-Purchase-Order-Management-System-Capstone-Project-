Public Class frmApprovals
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        'Will return the user to the Home screen without saving any progress.
        frmNavPane.Show()
        Me.Close()
    End Sub

    Private Sub frmApprovals_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class