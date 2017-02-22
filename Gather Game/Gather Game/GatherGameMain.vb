'Title: The Gather Game
'Author: Brendan Way
'Last Edited: 2/11/2017

Public Class GatherGameMain

    Public foodAmount As Decimal
    Public woodAmount As Decimal
    Public stoneAmount As Decimal
    Public dayNumber As Integer
    Public levelNumber As Integer
    Public actionNumber As Integer
    Private actionNumberMax As Integer
    Public randomInteger As Integer
    Public foodEvent As Boolean
    Public stoneEvent As Boolean
    Public woodEvent As Boolean
    Private LevelUp As Integer
    Public stoneShovel As Boolean
    Public ironShovel As Boolean
    Public goldShovel As Boolean
    Public stoneAxe As Boolean
    Public ironeAxe As Boolean
    Public goldAxe As Boolean
    Public stonePickaxe As Boolean
    Public ironPickAxe As Boolean
    Public goldPickaxe As Boolean

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TraderForm.BackButton.Focus()
        TraderForm.Visible = False

        actionNumberMax = 1
        levelNumber = 1
        LevelAmountLabel.Text = levelNumber
        dayNumber = 1
        DayCountLabel.Text = dayNumber
        actionNumber = 1
        ActionCountLabel.Text = actionNumber
        FoodBox.Text = foodAmount
        WoodBox.Text = woodAmount
        StoneBox.Text = stoneAmount
        ListBoxGame.Items.Add("Welcome to the Gather Game.")
        ListBoxGame.Items.Add("Day: " & dayNumber)
        foodEvent = False
        stoneEvent = False
        woodEvent = False
        LevelUp = 5

    End Sub

    Private Sub FoodButton_Click(sender As Object, e As EventArgs) Handles FoodButton.Click
        'User gains a random number of food based on a random number generator
        'User has a certain amount of "actions" per day. If "actions" is greater than zero, they gather a resource
        If actionNumber <> 0 Then
            'The screen to freeze to "search" for food
            ListBoxGame.Items.Add("Gathering food...")
            'Selects the last item in the listbox
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            Me.Refresh()
            System.Threading.Thread.Sleep(2000)
            Dim randNum As New Random
            Dim randFoodEvent As New Random
            Dim foodEventYes As Integer
            Dim foodEventAmount As Integer
            Dim foodEventLost As Integer

            randomInteger = randNum.Next(1, 6)
            'If a food event is triggered, user has a chance of getting a higher amount of food (*9) or losing food (/3)
            If foodEvent = True Then
                foodEventYes = randFoodEvent.Next(1, 10)
                foodEventAmount = (randomInteger * 9)
                foodEventLost = (foodAmount / 3)
                If foodEventYes <= 3 Then
                    foodAmount += foodEventAmount
                    FoodBox.Text = foodAmount
                    ListBoxGame.Items.Add("You managed to survive the storm. The rain brought a good harvest.")
                    ListBoxGame.Items.Add("You collected more food than usual.")
                    ListBoxGame.Items.Add("You collected " & foodEventAmount & " food.")
                Else
                    foodAmount = Decimal.Round(foodAmount - foodEventLost)
                    ListBoxGame.Items.Add("You were injured during the storm.")
                    ListBoxGame.Items.Add("You were forced to use excess food to heal.")
                    ListBoxGame.Items.Add("You lost " & foodEventLost & " food.")
                End If
            Else
                'If food event is not triggered, gain a random amount of food 1-5 and add it to the original food amount
                foodAmount += randomInteger
                ListBoxGame.Items.Add("You collected " & randomInteger & " food.")
            End If
            'set the food amount to the foodbox
            FoodBox.Text = foodAmount
            foodEvent = False
            actionNumber -= 1
            ActionCountLabel.Text = actionNumber
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        End If
        'When the user runs out of actions, the buttons disable
        If actionNumber = 0 Then
            FoodButton.Enabled = False
            WoodButton.Enabled = False
            StoneButton.Enabled = False
            LevelButton.Enabled = False
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        Else

        End If
    End Sub

    Private Sub WoodButton_Click(sender As Object, e As EventArgs) Handles WoodButton.Click
        'Collects Wood, pending there are enough actions
        'Follows the same pattern as collecting food
        If actionNumber <> 0 Then
            Dim randNum As New Random
            Dim randWoodEvent As New Random
            Dim woodEventYes As Integer
            Dim woodEventAmount As Integer
            Dim woodEventLost As Integer
            ListBoxGame.Items.Add("Gathering wood...")
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            Me.Refresh()
            System.Threading.Thread.Sleep(2000)
            randomInteger = randNum.Next(1, 6)

            If woodEvent = True Then
                woodEventYes = randWoodEvent.Next(1, 10)
                woodEventAmount = (randomInteger * 9)
                woodEventLost = (woodAmount / 3)
                If woodEventYes <= 3 Then
                    woodAmount += woodEventAmount
                    WoodBox.Text = woodAmount
                    ListBoxGame.Items.Add("You were able to fend off wolves while collecting wood.")
                    ListBoxGame.Items.Add("You collected more wood than usual.")
                    ListBoxGame.Items.Add("You collected " & woodEventAmount & " wood.")
                Else
                    woodAmount = (woodAmount - woodEventLost)
                    ListBoxGame.Items.Add("You were attacked by wolves while out collecting wood.")
                    ListBoxGame.Items.Add("You dropped some wood while fleeing.")
                    ListBoxGame.Items.Add("You lost " & woodEventLost & " wood.")
                End If
            Else
                woodAmount += randomInteger
                ListBoxGame.Items.Add("You collected " & randomInteger & " wood.")
            End If
            WoodBox.Text = woodAmount
            woodEvent = False
            actionNumber -= 1
            ActionCountLabel.Text = actionNumber
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        End If
        If actionNumber = 0 Then
            FoodButton.Enabled = False
            WoodButton.Enabled = False
            StoneButton.Enabled = False
            LevelButton.Enabled = False
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        End If
    End Sub

    Private Sub StoneButton_Click(sender As Object, e As EventArgs) Handles StoneButton.Click
        'Collects stone pending the user has actions
        'Follows the same pattern as collecting food and wood
        If actionNumber <> 0 Then
            Dim randNum As New Random
            Dim randFoodEvent As New Random
            Dim stoneEventYes As Integer
            Dim stoneEventAmount As Integer
            Dim stoneEventLost As Integer
            ListBoxGame.Items.Add("Gathering stone...")
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            Me.Refresh()
            System.Threading.Thread.Sleep(2000)
            randomInteger = randNum.Next(1, 6)
            If stoneEvent = True Then
                stoneEventYes = randFoodEvent.Next(1, 10)
                stoneEventAmount = (randomInteger * 9)
                stoneEventLost = (stoneAmount / 3)
                If stoneEventYes <= 3 Then
                    stoneAmount += stoneEventAmount
                    StoneBox.Text = stoneAmount
                    ListBoxGame.Items.Add("You carefully mine the stone without collapsing the mine.")
                    ListBoxGame.Items.Add("You collected more stone than usual.")
                    ListBoxGame.Items.Add("You collected " & stoneEventAmount & " stone.")
                Else
                    stoneAmount = Decimal.Round(stoneAmount - stoneEventLost)
                    ListBoxGame.Items.Add("Part of the mine collapsed while you were mining.")
                    ListBoxGame.Items.Add("You were forced to leave some stone behind.")
                    ListBoxGame.Items.Add("You lost " & stoneEventLost & " stone.")
                End If
            Else
                stoneAmount += randomInteger
                ListBoxGame.Items.Add("You collected " & randomInteger & " stone.")
            End If

            StoneBox.Text = stoneAmount
            stoneEvent = False
            actionNumber -= 1
            ActionCountLabel.Text = actionNumber
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        End If
        'if the user has no actions, the buttons become disabled
        If actionNumber = 0 Then
            FoodButton.Enabled = False
            WoodButton.Enabled = False
            StoneButton.Enabled = False
            LevelButton.Enabled = False
            '
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
            NextDayButton.Focus()
        End If
    End Sub

    Private Sub TraderButton_Click(sender As Object, e As EventArgs) Handles TraderButton.Click
        'Takes the user to a "Trader" screen where they can trade their resources
        Me.Visible = False
        TraderForm.Visible = True
        TraderForm.TraderDayCountLabel.Text = dayNumber
        TraderForm.TraderLevelAmountLabel.Text = levelNumber
        TraderForm.TraderFoodBox.Text = foodAmount
        TraderForm.TraderWoodBox.Text = woodAmount
        TraderForm.TraderStoneBox.Text = stoneAmount
        TraderForm.BackButton.Focus()
        TraderForm.TraderListBox.Items.Add("Welcome to the shop!")
        TraderForm.TraderListBox.Items.Add("What are you looking to trade?")
        TraderForm.TraderListBox.Items.Add("(Everything is traded on a 1 for 1 basis.)")
    End Sub

    Private Sub NextDayButton_Click(sender As Object, e As EventArgs) Handles NextDayButton.Click
        'Enables the gather buttons
        Dim randEvent As New Random
        Dim eventNumber As Integer
        FoodButton.Enabled = True
        WoodButton.Enabled = True
        StoneButton.Enabled = True
        LevelButton.Enabled = True
        'If the random events are on, it turns them off
        foodEvent = False
        woodEvent = False
        stoneEvent = False
        'resets action number
        actionNumber = actionNumberMax
        ActionCountLabel.Text = actionNumberMax
        'adds 1 to the day counter
        dayNumber += 1
        DayCountLabel.Text = dayNumber
        ListBoxGame.Items.Add("Day: " & dayNumber)
        'adds a random event to the day
        eventNumber = randEvent.Next(1, 101)
        Select Case eventNumber
            Case 1 To 5
                foodEvent = True
                ListBoxGame.Items.Add("You sense a storm approaching...")
            Case 6 To 10
                woodEvent = True
                ListBoxGame.Items.Add("Howling can be heard coming from the forest...")
            Case 11 To 15
                stoneEvent = True
                ListBoxGame.Items.Add("The walls of the mine seem a little unstable...")
        End Select
        ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub LevelButton_Click(sender As Object, e As EventArgs) Handles LevelButton.Click
        'if the user has enough resources they can level up
        If foodAmount >= LevelUp And woodAmount >= LevelUp And stoneAmount >= LevelUp Then
            MessageBox.Show("You are now level " & levelNumber + 1 & "!")
            'subtracts the amount to level up from each resource
            foodAmount -= LevelUp
            FoodBox.Text = foodAmount
            woodAmount -= LevelUp
            WoodBox.Text = woodAmount
            stoneAmount -= LevelUp
            StoneBox.Text = stoneAmount
            'increases  the level counter by 1
            levelNumber += 1
            LevelAmountLabel.Text = levelNumber
            LevelUp *= 2
            'user gains more actions per level
            actionNumberMax = (levelNumber * 0.45)
            ListBoxGame.Items.Add("Level " & levelNumber & "!")
            ListBoxGame.Items.Add("To level up you need:")
            ListBoxGame.Items.Add(LevelUp & " Food")
            ListBoxGame.Items.Add(LevelUp & " Wood")
            ListBoxGame.Items.Add(LevelUp & " Stone")
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
        Else
            'If the user doesn't have enough resources, the Level up button will tell them how much of each they will need
            ListBoxGame.Items.Add("You do not have enough resources to level up.")
            ListBoxGame.Items.Add("To level up you need:")
            ListBoxGame.Items.Add(LevelUp & " Food")
            ListBoxGame.Items.Add(LevelUp & " Wood")
            ListBoxGame.Items.Add(LevelUp & " Stone")
            ListBoxGame.SelectedIndex = ListBoxGame.Items.Count - 1
        End If

    End Sub
End Class

