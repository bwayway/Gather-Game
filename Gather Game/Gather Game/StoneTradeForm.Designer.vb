<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StoneTradeForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.WoodTradedBox = New System.Windows.Forms.TextBox()
        Me.FoodTradedBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StoneTradeButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Wood:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Food:"
        '
        'WoodTradedBox
        '
        Me.WoodTradedBox.Location = New System.Drawing.Point(37, 113)
        Me.WoodTradedBox.Name = "WoodTradedBox"
        Me.WoodTradedBox.Size = New System.Drawing.Size(100, 20)
        Me.WoodTradedBox.TabIndex = 15
        '
        'FoodTradedBox
        '
        Me.FoodTradedBox.Location = New System.Drawing.Point(37, 59)
        Me.FoodTradedBox.Name = "FoodTradedBox"
        Me.FoodTradedBox.Size = New System.Drawing.Size(100, 20)
        Me.FoodTradedBox.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Trading for Stone"
        '
        'StoneTradeButton
        '
        Me.StoneTradeButton.Location = New System.Drawing.Point(50, 163)
        Me.StoneTradeButton.Name = "StoneTradeButton"
        Me.StoneTradeButton.Size = New System.Drawing.Size(75, 23)
        Me.StoneTradeButton.TabIndex = 12
        Me.StoneTradeButton.Text = "Trade"
        Me.StoneTradeButton.UseVisualStyleBackColor = True
        '
        'StoneTradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(174, 217)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WoodTradedBox)
        Me.Controls.Add(Me.FoodTradedBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StoneTradeButton)
        Me.Name = "StoneTradeForm"
        Me.Text = "Trading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WoodTradedBox As TextBox
    Friend WithEvents FoodTradedBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents StoneTradeButton As Button
End Class
