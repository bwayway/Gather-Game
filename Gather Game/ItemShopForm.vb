Public Class ItemShop
    Private Sub ItemShopBackButton_Click(sender As Object, e As EventArgs) Handles ItemShopBackButton.Click
        Me.Visible = False
        TraderForm.Visible = True
    End Sub

    Private Sub StoneShovelButton_Click(sender As Object, e As EventArgs) Handles StoneShovelButton.Click

        If GatherGameMain.woodAmount >= 20 And GatherGameMain.stoneAmount >= 20 Then
            ItemListBox.Items.Add("You purchased the Stone Shovel.")
            ItemListBox.Items.Add("You can now gather more food.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.stoneShovel = True
            GatherGameMain.woodAmount -= 20
            GatherGameMain.stoneAmount -= 20
            WoodBox.Text = GatherGameMain.woodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            StoneShovelButton.Enabled = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("20 Wood")
            ItemListBox.Items.Add("20 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1


        End If
    End Sub

    Private Sub IronShovelButton_Click(sender As Object, e As EventArgs) Handles IronShovelButton.Click
        If GatherGameMain.woodAmount >= 75 And GatherGameMain.stoneAmount >= 75 Then
            ItemListBox.Items.Add("You purchased the Iron Shovel.")
            ItemListBox.Items.Add("You can now gather more food.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.ironShovel = True
            GatherGameMain.woodAmount -= 75
            GatherGameMain.stoneAmount -= 75
            WoodBox.Text = GatherGameMain.woodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            IronShovelButton.Enabled = False
            GatherGameMain.stoneShovel = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("75 Wood")
            ItemListBox.Items.Add("75 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub

    Private Sub GoldShovelButton_Click(sender As Object, e As EventArgs) Handles GoldShovelButton.Click
        If GatherGameMain.woodAmount >= 150 And GatherGameMain.stoneAmount >= 150 Then
            ItemListBox.Items.Add("You purchased the Gold Shovel.")
            ItemListBox.Items.Add("You can now gather more food.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.goldShovel = True
            GatherGameMain.woodAmount -= 150
            GatherGameMain.stoneAmount -= 150
            WoodBox.Text = GatherGameMain.woodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            GoldShovelButton.Enabled = False
            GatherGameMain.stoneShovel = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("150 Wood")
            ItemListBox.Items.Add("150 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub

    Private Sub StoneAxeButton_Click(sender As Object, e As EventArgs) Handles StoneAxeButton.Click
        If GatherGameMain.foodAmount >= 20 And GatherGameMain.stoneAmount >= 20 Then
            ItemListBox.Items.Add("You purchased the Stone Axe.")
            ItemListBox.Items.Add("You can now gather more wood.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.stoneAxe = True
            GatherGameMain.foodAmount -= 20
            GatherGameMain.stoneAmount -= 20
            FoodBox.Text = GatherGameMain.foodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            StoneAxeButton.Enabled = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("20 Food")
            ItemListBox.Items.Add("20 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub

    Private Sub ironAxeButton_Click(sender As Object, e As EventArgs) Handles ironAxeButton.Click
        If GatherGameMain.foodAmount >= 75 And GatherGameMain.stoneAmount >= 75 Then
            ItemListBox.Items.Add("You purchased the Iron Axe.")
            ItemListBox.Items.Add("You can now gather more wood.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.ironAxe = True
            GatherGameMain.foodAmount -= 75
            GatherGameMain.stoneAmount -= 75
            FoodBox.Text = GatherGameMain.foodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            ironAxeButton.Enabled = False
            GatherGameMain.ironAxe = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("75 Food")
            ItemListBox.Items.Add("75 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub

    Private Sub GoldAxeButton_Click(sender As Object, e As EventArgs) Handles GoldAxeButton.Click
        If GatherGameMain.foodAmount >= 150 And GatherGameMain.stoneAmount >= 150 Then
            ItemListBox.Items.Add("You purchased the Gold Axe.")
            ItemListBox.Items.Add("You can now gather more wood.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.goldAxe = True
            GatherGameMain.foodAmount -= 150
            GatherGameMain.stoneAmount -= 150
            FoodBox.Text = GatherGameMain.foodAmount
            StoneBox.Text = GatherGameMain.stoneAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderStoneBox.Text = GatherGameMain.stoneAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.StoneBox.Text = GatherGameMain.stoneAmount
            GoldAxeButton.Enabled = False
            GatherGameMain.ironAxe = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("150 Food")
            ItemListBox.Items.Add("150 Stone")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub

    Private Sub StonePickaxeButton_Click(sender As Object, e As EventArgs) Handles StonePickaxeButton.Click
        If GatherGameMain.foodAmount >= 20 And GatherGameMain.woodAmount >= 20 Then
            ItemListBox.Items.Add("You purchased the Stone Pickaxe.")
            ItemListBox.Items.Add("You can now gather more stone.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.stonePickaxe = True
            GatherGameMain.foodAmount -= 20
            GatherGameMain.woodAmount -= 20
            FoodBox.Text = GatherGameMain.foodAmount
            WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            StonePickaxeButton.Enabled = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("20 Food")
            ItemListBox.Items.Add("20 Wood")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1


        End If
    End Sub

    Private Sub IronPickaxeButton_Click(sender As Object, e As EventArgs) Handles IronPickaxeButton.Click
        If GatherGameMain.foodAmount >= 75 And GatherGameMain.woodAmount >= 75 Then
            ItemListBox.Items.Add("You purchased the Iron Pickaxe.")
            ItemListBox.Items.Add("You can now gather more stone.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.ironPickAxe = True
            GatherGameMain.foodAmount -= 75
            GatherGameMain.woodAmount -= 75
            FoodBox.Text = GatherGameMain.foodAmount
            WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            IronPickaxeButton.Enabled = False
            GatherGameMain.stonePickaxe = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("75 Food")
            ItemListBox.Items.Add("75 Wood")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1


        End If

    End Sub

    Private Sub GoldPickAxeButton_Click(sender As Object, e As EventArgs) Handles GoldPickAxeButton.Click
        If GatherGameMain.foodAmount >= 150 And GatherGameMain.woodAmount >= 150 Then
            ItemListBox.Items.Add("You purchased the GoldPickaxe.")
            ItemListBox.Items.Add("You can now gather more stone.")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
            GatherGameMain.goldPickaxe = True
            GatherGameMain.foodAmount -= 150
            GatherGameMain.woodAmount -= 150
            FoodBox.Text = GatherGameMain.foodAmount
            WoodBox.Text = GatherGameMain.woodAmount
            TraderForm.TraderFoodBox.Text = GatherGameMain.foodAmount
            TraderForm.TraderWoodBox.Text = GatherGameMain.woodAmount
            GatherGameMain.FoodBox.Text = GatherGameMain.foodAmount
            GatherGameMain.WoodBox.Text = GatherGameMain.woodAmount
            GoldPickAxeButton.Enabled = False
            GatherGameMain.ironPickAxe = False
        Else
            ItemListBox.Items.Add("You do not have enough resources.")
            ItemListBox.Items.Add("You need:")
            ItemListBox.Items.Add("150 Food")
            ItemListBox.Items.Add("150 Wood")
            ItemListBox.SelectedIndex = ItemListBox.Items.Count - 1
        End If
    End Sub
End Class