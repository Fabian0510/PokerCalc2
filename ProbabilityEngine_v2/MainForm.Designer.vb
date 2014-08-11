<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.removeRedButton = New System.Windows.Forms.Button()
        Me.removeBlackButton = New System.Windows.Forms.Button()
        Me.ProbabilityTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.HeartStatTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiamondStatBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SpadeStatBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClubStatBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RedListBox = New System.Windows.Forms.ListBox()
        Me.BlackListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 12)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Red Cards"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(118, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 12)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Black Cards"
        '
        'removeRedButton
        '
        Me.removeRedButton.Location = New System.Drawing.Point(14, 227)
        Me.removeRedButton.Name = "removeRedButton"
        Me.removeRedButton.Size = New System.Drawing.Size(80, 21)
        Me.removeRedButton.TabIndex = 4
        Me.removeRedButton.Text = "Remove"
        Me.removeRedButton.UseVisualStyleBackColor = True
        '
        'removeBlackButton
        '
        Me.removeBlackButton.Location = New System.Drawing.Point(121, 227)
        Me.removeBlackButton.Name = "removeBlackButton"
        Me.removeBlackButton.Size = New System.Drawing.Size(80, 21)
        Me.removeBlackButton.TabIndex = 5
        Me.removeBlackButton.Text = "Remove"
        Me.removeBlackButton.UseVisualStyleBackColor = True
        '
        'ProbabilityTextBox
        '
        Me.ProbabilityTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ProbabilityTextBox.Location = New System.Drawing.Point(220, 26)
        Me.ProbabilityTextBox.Name = "ProbabilityTextBox"
        Me.ProbabilityTextBox.ReadOnly = True
        Me.ProbabilityTextBox.Size = New System.Drawing.Size(390, 14)
        Me.ProbabilityTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(521, 252)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 14)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Copyright Geoff Jones"
        '
        'HeartStatTextBox
        '
        Me.HeartStatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HeartStatTextBox.Location = New System.Drawing.Point(442, 53)
        Me.HeartStatTextBox.Name = "HeartStatTextBox"
        Me.HeartStatTextBox.ReadOnly = True
        Me.HeartStatTextBox.Size = New System.Drawing.Size(168, 14)
        Me.HeartStatTextBox.TabIndex = 13
        Me.HeartStatTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Gulim", 15.0!)
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(412, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "♥"
        '
        'DiamondStatBox
        '
        Me.DiamondStatBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DiamondStatBox.Location = New System.Drawing.Point(442, 76)
        Me.DiamondStatBox.Name = "DiamondStatBox"
        Me.DiamondStatBox.ReadOnly = True
        Me.DiamondStatBox.Size = New System.Drawing.Size(168, 14)
        Me.DiamondStatBox.TabIndex = 15
        Me.DiamondStatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(217, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(177, 12)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Diamond Statistcal Probability:"
        '
        'SpadeStatBox
        '
        Me.SpadeStatBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SpadeStatBox.Location = New System.Drawing.Point(442, 168)
        Me.SpadeStatBox.Name = "SpadeStatBox"
        Me.SpadeStatBox.ReadOnly = True
        Me.SpadeStatBox.Size = New System.Drawing.Size(168, 14)
        Me.SpadeStatBox.TabIndex = 19
        Me.SpadeStatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(217, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(163, 12)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Spade Statistcal Probability:"
        '
        'ClubStatBox
        '
        Me.ClubStatBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ClubStatBox.Location = New System.Drawing.Point(442, 145)
        Me.ClubStatBox.Name = "ClubStatBox"
        Me.ClubStatBox.ReadOnly = True
        Me.ClubStatBox.Size = New System.Drawing.Size(168, 14)
        Me.ClubStatBox.TabIndex = 17
        Me.ClubStatBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(217, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(153, 12)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Club Statistcal Probability:"
        '
        'RedListBox
        '
        Me.RedListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RedListBox.FormattingEnabled = True
        Me.RedListBox.ItemHeight = 25
        Me.RedListBox.Location = New System.Drawing.Point(14, 26)
        Me.RedListBox.Name = "RedListBox"
        Me.RedListBox.Size = New System.Drawing.Size(80, 179)
        Me.RedListBox.TabIndex = 0
        '
        'BlackListBox
        '
        Me.BlackListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BlackListBox.FormattingEnabled = True
        Me.BlackListBox.ItemHeight = 25
        Me.BlackListBox.Location = New System.Drawing.Point(121, 26)
        Me.BlackListBox.Name = "BlackListBox"
        Me.BlackListBox.Size = New System.Drawing.Size(80, 179)
        Me.BlackListBox.TabIndex = 1
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = Global.ProbabilityEnginev2.My.Resources.Resources.appBackground
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(672, 279)
        Me.Controls.Add(Me.SpadeStatBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ClubStatBox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DiamondStatBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HeartStatTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ProbabilityTextBox)
        Me.Controls.Add(Me.removeBlackButton)
        Me.Controls.Add(Me.removeRedButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BlackListBox)
        Me.Controls.Add(Me.RedListBox)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(682, 311)
        Me.MinimumSize = New System.Drawing.Size(682, 311)
        Me.Name = "MainForm"
        Me.Text = "Geoff's Fabulous Probabily Engine"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents removeRedButton As System.Windows.Forms.Button
    Friend WithEvents removeBlackButton As System.Windows.Forms.Button
    Friend WithEvents ProbabilityTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents HeartStatTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DiamondStatBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents SpadeStatBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ClubStatBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RedListBox As System.Windows.Forms.ListBox
    Friend WithEvents BlackListBox As System.Windows.Forms.ListBox

End Class
