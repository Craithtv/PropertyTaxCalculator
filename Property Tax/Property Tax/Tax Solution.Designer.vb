<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaxSolution
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
        Me.ValueLabel = New System.Windows.Forms.Label()
        Me.ValueText = New System.Windows.Forms.TextBox()
        Me.TaxLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.totalTax = New System.Windows.Forms.Label()
        Me.CalcButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Title = New System.Windows.Forms.Label()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ValueLabel
        '
        Me.ValueLabel.AutoSize = True
        Me.ValueLabel.Location = New System.Drawing.Point(12, 105)
        Me.ValueLabel.Name = "ValueLabel"
        Me.ValueLabel.Size = New System.Drawing.Size(113, 13)
        Me.ValueLabel.TabIndex = 0
        Me.ValueLabel.Text = "Enter Assessed Value:"
        Me.ValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ValueText
        '
        Me.ValueText.Location = New System.Drawing.Point(15, 121)
        Me.ValueText.Name = "ValueText"
        Me.ValueText.Size = New System.Drawing.Size(110, 20)
        Me.ValueText.TabIndex = 1
        '
        'TaxLabel
        '
        Me.TaxLabel.AutoSize = True
        Me.TaxLabel.Location = New System.Drawing.Point(209, 105)
        Me.TaxLabel.Name = "TaxLabel"
        Me.TaxLabel.Size = New System.Drawing.Size(93, 13)
        Me.TaxLabel.TabIndex = 6
        Me.TaxLabel.Text = "Property Tax Rate"
        Me.TaxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(212, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "1.35%"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(122, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Property Tax Total"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'totalTax
        '
        Me.totalTax.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.totalTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.totalTax.Location = New System.Drawing.Point(124, 181)
        Me.totalTax.Name = "totalTax"
        Me.totalTax.Size = New System.Drawing.Size(91, 23)
        Me.totalTax.TabIndex = 9
        Me.totalTax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CalcButton
        '
        Me.CalcButton.Location = New System.Drawing.Point(12, 248)
        Me.CalcButton.Name = "CalcButton"
        Me.CalcButton.Size = New System.Drawing.Size(68, 28)
        Me.CalcButton.TabIndex = 2
        Me.CalcButton.Text = "Calculate"
        Me.CalcButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(249, 248)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(68, 28)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Title
        '
        Me.Title.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Title.Location = New System.Drawing.Point(12, 9)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(305, 73)
        Me.Title.TabIndex = 5
        Me.Title.Text = "Property Tax Calculator"
        Me.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(136, 248)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(68, 28)
        Me.ClearButton.TabIndex = 3
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'TaxSolution
        '
        Me.AcceptButton = Me.CalcButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 294)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.CalcButton)
        Me.Controls.Add(Me.totalTax)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TaxLabel)
        Me.Controls.Add(Me.ValueText)
        Me.Controls.Add(Me.ValueLabel)
        Me.Name = "TaxSolution"
        Me.Text = "Tax Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ValueLabel As Label
    Friend WithEvents ValueText As TextBox
    Friend WithEvents TaxLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents totalTax As Label
    Friend WithEvents CalcButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents Title As Label
    Friend WithEvents ClearButton As Button
End Class
