<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GatherGameMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.FoodButton = New System.Windows.Forms.Button()
        Me.NextDayButton = New System.Windows.Forms.Button()
        Me.WoodButton = New System.Windows.Forms.Button()
        Me.StoneButton = New System.Windows.Forms.Button()
        Me.WoodLabel = New System.Windows.Forms.Label()
        Me.FoodLabel = New System.Windows.Forms.Label()
        Me.DayLabel = New System.Windows.Forms.Label()
        Me.StoneLabel = New System.Windows.Forms.Label()
        Me.DayCountLabel = New System.Windows.Forms.Label()
        Me.StoneBox = New System.Windows.Forms.TextBox()
        Me.FoodBox = New System.Windows.Forms.TextBox()
        Me.WoodBox = New System.Windows.Forms.TextBox()
        Me.ListBoxGame = New System.Windows.Forms.ListBox()
        Me.LevelAmountLabel = New System.Windows.Forms.Label()
        Me.LevelLabel = New System.Windows.Forms.Label()
        Me.TraderButton = New System.Windows.Forms.Button()
        Me.LevelButton = New System.Windows.Forms.Button()
        Me.ActionLabel = New System.Windows.Forms.Label()
        Me.ActionCountLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'FoodButton
        '
        Me.FoodButton.Location = New System.Drawing.Point(29, 263)
        Me.FoodButton.Name = "FoodButton"
        Me.FoodButton.Size = New System.Drawing.Size(100, 23)
        Me.FoodButton.TabIndex = 0
        Me.FoodButton.Text = "Gather Food"
        Me.FoodButton.UseVisualStyleBackColor = True
        '
        'NextDayButton
        '
        Me.NextDayButton.Location = New System.Drawing.Point(155, 312)
        Me.NextDayButton.Name = "NextDayButton"
        Me.NextDayButton.Size = New System.Drawing.Size(100, 23)
        Me.NextDayButton.TabIndex = 1
        Me.NextDayButton.Text = "Next Day"
        Me.NextDayButton.UseVisualStyleBackColor = True
        '
        'WoodButton
        '
        Me.WoodButton.Location = New System.Drawing.Point(155, 263)
        Me.WoodButton.Name = "WoodButton"
        Me.WoodButton.Size = New System.Drawing.Size(100, 23)
        Me.WoodButton.TabIndex = 2
        Me.WoodButton.Text = "Gather Wood"
        Me.WoodButton.UseVisualStyleBackColor = True
        '
        'StoneButton
        '
        Me.StoneButton.Location = New System.Drawing.Point(284, 263)
        Me.StoneButton.Name = "StoneButton"
        Me.StoneButton.Size = New System.Drawing.Size(100, 23)
        Me.StoneButton.TabIndex = 3
        Me.StoneButton.Text = "Gather Stone"
        Me.StoneButton.UseVisualStyleBackColor = True
        '
        'WoodLabel
        '
        Me.WoodLabel.AutoSize = True
        Me.WoodLabel.Location = New System.Drawing.Point(189, 48)
        Me.WoodLabel.Name = "WoodLabel"
        Me.WoodLabel.Size = New System.Drawing.Size(39, 13)
        Me.WoodLabel.TabIndex = 4
        Me.WoodLabel.Text = "Wood:"
        '
        'FoodLabel
        '
        Me.FoodLabel.AutoSize = True
        Me.FoodLabel.Location = New System.Drawing.Point(63, 48)
        Me.FoodLabel.Name = "FoodLabel"
        Me.FoodLabel.Size = New System.Drawing.Size(34, 13)
        Me.FoodLabel.TabIndex = 5
        Me.FoodLabel.Text = "Food:"
        '
        'DayLabel
        '
        Me.DayLabel.AutoSize = True
        Me.DayLabel.Location = New System.Drawing.Point(315, 21)
        Me.DayLabel.Name = "DayLabel"
        Me.DayLabel.Size = New System.Drawing.Size(29, 13)
        Me.DayLabel.TabIndex = 6
        Me.DayLabel.Text = "Day:"
        '
        'StoneLabel
        '
        Me.StoneLabel.AutoSize = True
        Me.StoneLabel.Location = New System.Drawing.Point(315, 48)
        Me.StoneLabel.Name = "StoneLabel"
        Me.StoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.StoneLabel.TabIndex = 7
        Me.StoneLabel.Text = "Stone:"
        '
        'DayCountLabel
        '
        Me.DayCountLabel.AutoSize = True
        Me.DayCountLabel.Location = New System.Drawing.Point(341, 21)
        Me.DayCountLabel.Name = "DayCountLabel"
        Me.DayCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.DayCountLabel.TabIndex = 8
        Me.DayCountLabel.Text = "1"
        '
        'StoneBox
        '
        Me.StoneBox.CausesValidation = False
        Me.StoneBox.Location = New System.Drawing.Point(284, 64)
        Me.StoneBox.Name = "StoneBox"
        Me.StoneBox.ReadOnly = True
        Me.StoneBox.Size = New System.Drawing.Size(100, 20)
        Me.StoneBox.TabIndex = 9
        Me.StoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'FoodBox
        '
        Me.FoodBox.Location = New System.Drawing.Point(29, 64)
        Me.FoodBox.Name = "FoodBox"
        Me.FoodBox.ReadOnly = True
        Me.FoodBox.Size = New System.Drawing.Size(100, 20)
        Me.FoodBox.TabIndex = 10
        Me.FoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'WoodBox
        '
        Me.WoodBox.CausesValidation = False
        Me.WoodBox.Location = New System.Drawing.Point(155, 64)
        Me.WoodBox.Name = "WoodBox"
        Me.WoodBox.ReadOnly = True
        Me.WoodBox.Size = New System.Drawing.Size(100, 20)
        Me.WoodBox.TabIndex = 11
        Me.WoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ListBoxGame
        '
        Me.ListBoxGame.FormattingEnabled = True
        Me.ListBoxGame.Location = New System.Drawing.Point(29, 112)
        Me.ListBoxGame.Name = "ListBoxGame"
        Me.ListBoxGame.Size = New System.Drawing.Size(362, 121)
        Me.ListBoxGame.TabIndex = 12
        '
        'LevelAmountLabel
        '
        Me.LevelAmountLabel.AutoSize = True
        Me.LevelAmountLabel.Location = New System.Drawing.Point(94, 21)
        Me.LevelAmountLabel.Name = "LevelAmountLabel"
        Me.LevelAmountLabel.Size = New System.Drawing.Size(13, 13)
        Me.LevelAmountLabel.TabIndex = 13
        Me.LevelAmountLabel.Text = "1"
        '
        'LevelLabel
        '
        Me.LevelLabel.AutoSize = True
        Me.LevelLabel.Location = New System.Drawing.Point(61, 21)
        Me.LevelLabel.Name = "LevelLabel"
        Me.LevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.LevelLabel.TabIndex = 14
        Me.LevelLabel.Text = "Level:"
        '
        'TraderButton
        '
        Me.TraderButton.Location = New System.Drawing.Point(29, 312)
        Me.TraderButton.Name = "TraderButton"
        Me.TraderButton.Size = New System.Drawing.Size(100, 23)
        Me.TraderButton.TabIndex = 15
        Me.TraderButton.Text = "Trader"
        Me.TraderButton.UseVisualStyleBackColor = True
        '
        'LevelButton
        '
        Me.LevelButton.Location = New System.Drawing.Point(284, 312)
        Me.LevelButton.Name = "LevelButton"
        Me.LevelButton.Size = New System.Drawing.Size(100, 23)
        Me.LevelButton.TabIndex = 16
        Me.LevelButton.Text = "Level Up"
        Me.LevelButton.UseVisualStyleBackColor = True
        '
        'ActionLabel
        '
        Me.ActionLabel.AutoSize = True
        Me.ActionLabel.Location = New System.Drawing.Point(183, 21)
        Me.ActionLabel.Name = "ActionLabel"
        Me.ActionLabel.Size = New System.Drawing.Size(45, 13)
        Me.ActionLabel.TabIndex = 17
        Me.ActionLabel.Text = "Actions:"
        '
        'ActionCountLabel
        '
        Me.ActionCountLabel.AutoSize = True
        Me.ActionCountLabel.Location = New System.Drawing.Point(224, 21)
        Me.ActionCountLabel.Name = "ActionCountLabel"
        Me.ActionCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.ActionCountLabel.TabIndex = 18
        Me.ActionCountLabel.Text = "1"
        '
        'GatherGameMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 358)
        Me.Controls.Add(Me.ActionCountLabel)
        Me.Controls.Add(Me.ActionLabel)
        Me.Controls.Add(Me.LevelButton)
        Me.Controls.Add(Me.TraderButton)
        Me.Controls.Add(Me.LevelLabel)
        Me.Controls.Add(Me.LevelAmountLabel)
        Me.Controls.Add(Me.ListBoxGame)
        Me.Controls.Add(Me.WoodBox)
        Me.Controls.Add(Me.FoodBox)
        Me.Controls.Add(Me.StoneBox)
        Me.Controls.Add(Me.DayCountLabel)
        Me.Controls.Add(Me.StoneLabel)
        Me.Controls.Add(Me.DayLabel)
        Me.Controls.Add(Me.FoodLabel)
        Me.Controls.Add(Me.WoodLabel)
        Me.Controls.Add(Me.StoneButton)
        Me.Controls.Add(Me.WoodButton)
        Me.Controls.Add(Me.NextDayButton)
        Me.Controls.Add(Me.FoodButton)
        Me.Name = "GatherGameMain"
        Me.Text = "Gather Game"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FoodButton As Button
    Friend WithEvents NextDayButton As Button
    Friend WithEvents WoodButton As Button
    Friend WithEvents StoneButton As Button
    Friend WithEvents WoodLabel As Label
    Friend WithEvents FoodLabel As Label
    Friend WithEvents DayLabel As Label
    Friend WithEvents StoneLabel As Label
    Friend WithEvents DayCountLabel As Label
    Friend WithEvents StoneBox As TextBox
    Friend WithEvents FoodBox As TextBox
    Friend WithEvents WoodBox As TextBox
    Friend WithEvents ListBoxGame As ListBox
    Friend WithEvents LevelAmountLabel As Label
    Friend WithEvents LevelLabel As Label
    Friend WithEvents TraderButton As Button
    Friend WithEvents LevelButton As Button
    Friend WithEvents ActionLabel As Label
    Friend WithEvents ActionCountLabel As Label
End Class
