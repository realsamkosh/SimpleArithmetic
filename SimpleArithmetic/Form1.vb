Public Class Form1
    Private Sub Evaluate_Click(sender As Object, e As EventArgs) Handles Evaluate.Click


        Dim results As New Decimal

        If Not IsNumeric(Me.variable1.Text.Trim()) And Not IsNumeric(Me.variable2.Text.Trim()) Then
            MessageBox.Show("Input Value Must be Numeric", "Warning")
        Else
            If useOperator.Text = "Addition" Then
                results = CInt(Me.variable1.Text) + CInt(Me.variable2.Text)
            ElseIf useOperator.Text = "Subtraction" Then
                results = CInt(Me.variable1.Text) - CInt(Me.variable2.Text)
            ElseIf useOperator.Text = "Multiplication" Then
                results = CInt(Me.variable1.Text) * CInt(Me.variable2.Text)
            ElseIf useOperator.Text = "Division" Then
                results = CDec(Me.variable1.Text) / CDec(Me.variable2.Text)
            ElseIf useOperator.Text = "Exponential" Then
                results = CInt(Me.variable1.Text) ^ CInt(Me.variable2.Text)
            End If
            Me.result.Text = results
        End If

    End Sub

    Private Sub endEval_Click(sender As Object, e As EventArgs) Handles endEval.Click
        Me.Close()
    End Sub
End Class
