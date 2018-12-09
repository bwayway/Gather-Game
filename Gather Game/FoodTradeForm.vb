Public Class FoodTradeForm
    Public foodAmount As Decimal
    Public woodAmount As Decimal
    Public stoneAmount As Decimal

    Private Sub FoodTradeButton_Click(sender As Object, e As EventArgs) Handles WoodTradeButton.Click
        Dim woodTraded As Decimal
        Dim stoneTraded As Decimal
        Dim foodGained As Decimal

        foodAmount = GatherGameMain.foodAmount
        woodAmount = GatherGameMain.woodAmount
        stoneAmount = GatherGameMain.stoneAmount
        Decimal.TryParse(WoodTradedBox.Text, woodTraded)
        Decimal.TryParse(StoneTradedBox.Text, stoneTraded)
        woodAmount -= woodTraded
        stoneAmount -= stoneTraded
        If woodAmount < 0 Or stoneAmount < 0 Then
            TraderForm.TraderListBox.Items.Add("You can't trade what you don't have.")
            woodAmount += woodTraded
            stoneAmount += stoneTraded
            Me.Close()
        Else
            foodGained = woodTraded + stoneTraded
            GatherGameMain.foodAmount += foodGained
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.woodAmount -= woodTraded
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.stoneAmount -= stoneTraded
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderListBox.Items.Add("You traded " & woodTraded & " wood and " & stoneTraded & " stone for " & foodGained & " food.")
            TraderForm.Refresh()
            Me.Close()
        End If
    End Sub

    Private Sub WoodTradedBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles WoodTradedBox.KeyPress
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub StoneTradedBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StoneTradedBox.KeyPress
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class