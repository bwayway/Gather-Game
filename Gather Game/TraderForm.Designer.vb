<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TraderForm
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
        Me.TraderFoodBox = New System.Windows.Forms.TextBox()
        Me.TraderWoodBox = New System.Windows.Forms.TextBox()
        Me.TraderStoneBox = New System.Windows.Forms.TextBox()
        Me.TraderFoodLabel = New System.Windows.Forms.Label()
        Me.TraderStoneLabel = New System.Windows.Forms.Label()
        Me.TraderWoodLabel = New System.Windows.Forms.Label()
        Me.TraderListBox = New System.Windows.Forms.ListBox()
        Me.TradingLabel = New System.Windows.Forms.Label()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.TraderLevelLabel = New System.Windows.Forms.Label()
        Me.TraderLevelAmountLabel = New System.Windows.Forms.Label()
        Me.TraderDayCountLabel = New System.Windows.Forms.Label()
        Me.TraderDayLabel = New System.Windows.Forms.Label()
        Me.TraderStoneButton = New System.Windows.Forms.Button()
        Me.TraderWoodButton = New System.Windows.Forms.Button()
        Me.TraderFoodButton = New System.Windows.Forms.Button()
        Me.ItemShopButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TraderFoodBox
        '
        Me.TraderFoodBox.Location = New System.Drawing.Point(29, 64)
        Me.TraderFoodBox.Name = "TraderFoodBox"
        Me.TraderFoodBox.ReadOnly = True
        Me.TraderFoodBox.Size = New System.Drawing.Size(100, 20)
        Me.TraderFoodBox.TabIndex = 0
        Me.TraderFoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TraderWoodBox
        '
        Me.TraderWoodBox.Location = New System.Drawing.Point(155, 64)
        Me.TraderWoodBox.Name = "TraderWoodBox"
        Me.TraderWoodBox.ReadOnly = True
        Me.TraderWoodBox.Size = New System.Drawing.Size(100, 20)
        Me.TraderWoodBox.TabIndex = 1
        Me.TraderWoodBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TraderStoneBox
        '
        Me.TraderStoneBox.Location = New System.Drawing.Point(284, 64)
        Me.TraderStoneBox.Name = "TraderStoneBox"
        Me.TraderStoneBox.ReadOnly = True
        Me.TraderStoneBox.Size = New System.Drawing.Size(100, 20)
        Me.TraderStoneBox.TabIndex = 2
        Me.TraderStoneBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TraderFoodLabel
        '
        Me.TraderFoodLabel.AutoSize = True
        Me.TraderFoodLabel.Location = New System.Drawing.Point(63, 48)
        Me.TraderFoodLabel.Name = "TraderFoodLabel"
        Me.TraderFoodLabel.Size = New System.Drawing.Size(34, 13)
        Me.TraderFoodLabel.TabIndex = 3
        Me.TraderFoodLabel.Text = "Food:"
        '
        'TraderStoneLabel
        '
        Me.TraderStoneLabel.AutoSize = True
        Me.TraderStoneLabel.Location = New System.Drawing.Point(317, 48)
        Me.TraderStoneLabel.Name = "TraderStoneLabel"
        Me.TraderStoneLabel.Size = New System.Drawing.Size(38, 13)
        Me.TraderStoneLabel.TabIndex = 4
        Me.TraderStoneLabel.Text = "Stone:"
        '
        'TraderWoodLabel
        '
        Me.TraderWoodLabel.AutoSize = True
        Me.TraderWoodLabel.Location = New System.Drawing.Point(189, 48)
        Me.TraderWoodLabel.Name = "TraderWoodLabel"
        Me.TraderWoodLabel.Size = New System.Drawing.Size(39, 13)
        Me.TraderWoodLabel.TabIndex = 5
        Me.TraderWoodLabel.Text = "Wood:"
        '
        'TraderListBox
        '
        Me.TraderListBox.FormattingEnabled = True
        Me.TraderListBox.Location = New System.Drawing.Point(155, 112)
        Me.TraderListBox.Name = "TraderListBox"
        Me.TraderListBox.Size = New System.Drawing.Size(229, 134)
        Me.TraderListBox.TabIndex = 9
        '
        'TradingLabel
        '
        Me.TradingLabel.AutoSize = True
        Me.TradingLabel.Location = New System.Drawing.Point(53, 112)
        Me.TradingLabel.Name = "TradingLabel"
        Me.TradingLabel.Size = New System.Drawing.Size(56, 13)
        Me.TradingLabel.TabIndex = 10
        Me.TradingLabel.Text = "Trade For:"
        '
        'BackButton
        '
        Me.BackButton.Location = New System.Drawing.Point(155, 312)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(100, 23)
        Me.BackButton.TabIndex = 11
        Me.BackButton.Text = "Back"
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'TraderLevelLabel
        '
        Me.TraderLevelLabel.AutoSize = True
        Me.TraderLevelLabel.Location = New System.Drawing.Point(125, 21)
        Me.TraderLevelLabel.Name = "TraderLevelLabel"
        Me.TraderLevelLabel.Size = New System.Drawing.Size(36, 13)
        Me.TraderLevelLabel.TabIndex = 18
        Me.TraderLevelLabel.Text = "Level:"
        '
        'TraderLevelAmountLabel
        '
        Me.TraderLevelAmountLabel.AutoSize = True
        Me.TraderLevelAmountLabel.Location = New System.Drawing.Point(158, 21)
        Me.TraderLevelAmountLabel.Name = "TraderLevelAmountLabel"
        Me.TraderLevelAmountLabel.Size = New System.Drawing.Size(13, 13)
        Me.TraderLevelAmountLabel.TabIndex = 17
        Me.TraderLevelAmountLabel.Text = "1"
        '
        'TraderDayCountLabel
        '
        Me.TraderDayCountLabel.AutoSize = True
        Me.TraderDayCountLabel.Location = New System.Drawing.Point(276, 21)
        Me.TraderDayCountLabel.Name = "TraderDayCountLabel"
        Me.TraderDayCountLabel.Size = New System.Drawing.Size(13, 13)
        Me.TraderDayCountLabel.TabIndex = 16
        Me.TraderDayCountLabel.Text = "1"
        '
        'TraderDayLabel
        '
        Me.TraderDayLabel.AutoSize = True
        Me.TraderDayLabel.Location = New System.Drawing.Point(250, 21)
        Me.TraderDayLabel.Name = "TraderDayLabel"
        Me.TraderDayLabel.Size = New System.Drawing.Size(29, 13)
        Me.TraderDayLabel.TabIndex = 15
        Me.TraderDayLabel.Text = "Day:"
        '
        'TraderStoneButton
        '
        Me.TraderStoneButton.Location = New System.Drawing.Point(43, 223)
        Me.TraderStoneButton.Name = "TraderStoneButton"
        Me.TraderStoneButton.Size = New System.Drawing.Size(75, 23)
        Me.TraderStoneButton.TabIndex = 8
        Me.TraderStoneButton.Text = "Stone"
        Me.TraderStoneButton.UseVisualStyleBackColor = True
        '
        'TraderWoodButton
        '
        Me.TraderWoodButton.Location = New System.Drawing.Point(43, 175)
        Me.TraderWoodButton.Name = "TraderWoodButton"
        Me.TraderWoodButton.Size = New System.Drawing.Size(75, 23)
        Me.TraderWoodButton.TabIndex = 7
        Me.TraderWoodButton.Text = "Wood"
        Me.TraderWoodButton.UseVisualStyleBackColor = True
        '
        'TraderFoodButton
        '
        Me.TraderFoodButton.Location = New System.Drawing.Point(43, 128)
        Me.TraderFoodButton.Name = "TraderFoodButton"
        Me.TraderFoodButton.Size = New System.Drawing.Size(75, 23)
        Me.TraderFoodButton.TabIndex = 6
        Me.TraderFoodButton.Text = "Food"
        Me.TraderFoodButton.UseVisualStyleBackColor = True
        '
        'ItemShopButton
        '
        Me.ItemShopButton.Location = New System.Drawing.Point(155, 270)
        Me.ItemShopButton.Name = "ItemShopButton"
        Me.ItemShopButton.Size = New System.Drawing.Size(100, 23)
        Me.ItemShopButton.TabIndex = 19
        Me.ItemShopButton.Text = "Item Shop"
        Me.ItemShopButton.UseVisualStyleBackColor = True
        '
        'TraderForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 358)
        Me.Controls.Add(Me.ItemShopButton)
        Me.Controls.Add(Me.TraderLevelLabel)
        Me.Controls.Add(Me.TraderLevelAmountLabel)
        Me.Controls.Add(Me.TraderDayCountLabel)
        Me.Controls.Add(Me.TraderDayLabel)
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.TradingLabel)
        Me.Controls.Add(Me.TraderListBox)
        Me.Controls.Add(Me.TraderStoneButton)
        Me.Controls.Add(Me.TraderWoodButton)
        Me.Controls.Add(Me.TraderFoodButton)
        Me.Controls.Add(Me.TraderWoodLabel)
        Me.Controls.Add(Me.TraderStoneLabel)
        Me.Controls.Add(Me.TraderFoodLabel)
        Me.Controls.Add(Me.TraderStoneBox)
        Me.Controls.Add(Me.TraderWoodBox)
        Me.Controls.Add(Me.TraderFoodBox)
        Me.Name = "TraderForm"
        Me.Text = "Trader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TraderFoodBox As TextBox
    Friend WithEvents TraderWoodBox As TextBox
    Friend WithEvents TraderStoneBox As TextBox
    Friend WithEvents TraderFoodLabel As Label
    Friend WithEvents TraderStoneLabel As Label
    Friend WithEvents TraderWoodLabel As Label
    Friend WithEvents TraderListBox As ListBox
    Friend WithEvents TradingLabel As Label
    Friend WithEvents BackButton As Button
    Friend WithEvents TraderLevelLabel As Label
    Friend WithEvents TraderLevelAmountLabel As Label
    Friend WithEvents TraderDayCountLabel As Label
    Friend WithEvents TraderDayLabel As Label
    Friend WithEvents TraderStoneButton As Button
    Friend WithEvents TraderWoodButton As Button
    Friend WithEvents TraderFoodButton As Button
    Friend WithEvents ItemShopButton As Button
End Class
