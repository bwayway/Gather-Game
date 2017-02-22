Public Class ItemShop
    Private Sub ItemShopBackButton_Click(sender As Object, e As EventArgs) Handles ItemShopBackButton.Click
        Me.Visible = False
        TraderForm.Visible = True
    End Sub
End Class