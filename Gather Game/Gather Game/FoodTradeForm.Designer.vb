<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodTradeForm
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
        Me.WoodTradeButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.WoodTradedBox = New System.Windows.Forms.TextBox()
        Me.StoneTradedBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'WoodTradeButton
        '
        Me.WoodTradeButton.Location = New System.Drawing.Point(50, 163)
        Me.WoodTradeButton.Name = "WoodTradeButton"
        Me.WoodTradeButton.Size = New System.Drawing.Size(75, 23)
        Me.WoodTradeButton.TabIndex = 0
        Me.WoodTradeButton.Text = "Trade"
        Me.WoodTradeButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Trading for Food"
        '
        'WoodTradedBox
        '
        Me.WoodTradedBox.Location = New System.Drawing.Point(37, 59)
        Me.WoodTradedBox.Name = "WoodTradedBox"
        Me.WoodTradedBox.Size = New System.Drawing.Size(100, 20)
        Me.WoodTradedBox.TabIndex = 2
        '
        'StoneTradedBox
        '
        Me.StoneTradedBox.Location = New System.Drawing.Point(37, 113)
        Me.StoneTradedBox.Name = "StoneTradedBox"
        Me.StoneTradedBox.Size = New System.Drawing.Size(100, 20)
        Me.StoneTradedBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Wood:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(66, 97)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Stone:"
        '
        'FoodTradeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(174, 217)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.StoneTradedBox)
        Me.Controls.Add(Me.WoodTradedBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WoodTradeButton)
        Me.Name = "FoodTradeForm"
        Me.Text = "Trading"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WoodTradeButton As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents WoodTradedBox As TextBox
    Friend WithEvents StoneTradedBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
