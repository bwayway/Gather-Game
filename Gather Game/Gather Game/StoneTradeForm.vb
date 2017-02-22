Public Class StoneTradeForm
    Public foodAmount As Decimal
    Public woodAmount As Decimal
    Public stoneAmount As Decimal

    Private Sub FoodTradeButton_Click(sender As Object, e As EventArgs) Handles StoneTradeButton.Click
        Dim foodTraded As Decimal
        Dim woodTraded As Decimal
        Dim stoneGained As Decimal

        foodAmount = GatherGameMain.foodAmount
        woodAmount = GatherGameMain.woodAmount
        stoneAmount = GatherGameMain.stoneAmount
        Decimal.TryParse(FoodTradedBox.Text, foodTraded)
        Decimal.TryParse(WoodTradedBox.Text, woodTraded)
        foodAmount -= foodTraded
        woodAmount -= woodTraded
        If foodAmount < 0 Or woodAmount < 0 Then
            TraderForm.TraderListBox.Items.Add("You can't trade what you don't have.")
            foodAmount += foodTraded
            woodAmount += woodTraded
            Me.Close()
        Else
            stoneGained = foodTraded + woodTraded
            GatherGameMain.stoneAmount += stoneGained
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.foodAmount -= foodTraded
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.woodAmount -= woodTraded
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderListBox.Items.Add("You traded " & foodTraded & " food and " & woodTraded & " wood for " & stoneGained & " stone.")
            TraderForm.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub WoodTradedBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles FoodTradedBox.KeyPress
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StoneTradedBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WoodTradedBox.KeyPress
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

End Class