Public Class TaxSolution

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ValueText.Text = String.Empty
        totalTax.Text = String.Empty
    End Sub
    Private Sub CalcButton_Click(sender As Object, e As EventArgs) Handles CalcButton.Click
        Dim Assessed As Integer = 0
        Dim PropTax As Double = 0

        Assessed = CInt(ValueText.Text)
        PropTax = Assessed / 100 * 1.35

        totalTax.Text = $"${PropTax:#,0.00}"
    End Sub

    Private Sub ValueText_TextChanged(sender As Object, e As EventArgs) Handles ValueText.TextChanged
        totalTax.Text = String.Empty
    End Sub

    Private Sub TaxSolution_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
