Public Class TraderForm
    Public Shared Property Visbile As Boolean

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.Visible = False
        GatherGameMain.Visible = True
        TraderListBox.Items.Clear()
        GatherGameMain.Refresh()
    End Sub

    Private Sub TraderForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Visible = False
        GatherGameMain.Visible = True
    End Sub

    Private Sub TraderFoodButton_Click(sender As Object, e As EventArgs) Handles TraderFoodButton.Click
        FoodTradeForm.Visible = True
    End Sub

    Private Sub TraderWoodButton_Click(sender As Object, e As EventArgs) Handles TraderWoodButton.Click
        WoodTradeForm.Visible = True
    End Sub

    Private Sub TraderStoneButton_Click(sender As Object, e As EventArgs) Handles TraderStoneButton.Click
        StoneTradeForm.Visible = True
    End Sub

    Private Sub ItemShopButton_Click(sender As Object, e As EventArgs) Handles ItemShopButton.Click
        ItemShop.FoodBox.Text = GatherGameMain.foodAmount
        ItemShop.WoodBox.Text = GatherGameMain.woodAmount
        ItemShop.StoneBox.Text = GatherGameMain.stoneAmount
        ItemShop.ItemShopLabelLevelCount.Text = GatherGameMain.levelNumber
        ItemShop.ItemShopLabelDayCount.Text = GatherGameMain.dayNumber
        Me.Visible = False
        ItemShop.Visible = True
    End Sub
End Class