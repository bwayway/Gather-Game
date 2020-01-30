﻿Public Class WoodTradeForm
    Public foodAmount As Decimal
    Public woodAmount As Decimal
    Public stoneAmount As Decimal

    Private Sub FoodTradeButton_Click(sender As Object, e As EventArgs) Handles WoodTradeButton.Click
        Dim foodTraded As Decimal
        Dim stoneTraded As Decimal
        Dim woodGained As Decimal

        foodAmount = GatherGameMain.foodAmount
        woodAmount = GatherGameMain.woodAmount
        stoneAmount = GatherGameMain.stoneAmount
        Decimal.TryParse(FoodTradedBox.Text, foodTraded)
        Decimal.TryParse(StoneTradedBox.Text, stoneTraded)
        foodAmount -= foodTraded
        stoneAmount -= stoneTraded
        If foodAmount < 0 Or stoneAmount < 0 Then
            TraderForm.TraderListBox.Items.Add("You can't trade what you don't have.")
            foodAmount += foodTraded
            stoneAmount += stoneTraded
            Me.Close()
        Else
            woodGained = foodTraded + stoneTraded
            GatherGameMain.woodAmount += woodGained
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.foodAmount -= foodTraded
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.stoneAmount -= stoneTraded
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderListBox.Items.Add("You traded " & foodTraded & " food and " & stoneTraded & " stone for " & woodGained & " wood.")
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

    Private Sub StoneTradedBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles StoneTradedBox.KeyPress
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class