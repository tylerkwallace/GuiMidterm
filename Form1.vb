Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decInputValue As Decimal
        Dim decConversionValue As Decimal

        Dim strNegativeNumberErrMsg As String = "Please enter a positive number."

        If IsNumeric(txtEnterValue.Text) Then
            decInputValue = CDec(txtEnterValue.Text)
            If decInputValue > 0 Then
                If radInchesToMeters.Checked Then
                    decConversionValue = decInputValue * 0.0254
                    lblConversion.Text = decInputValue.ToString() & " inches is " & decConversionValue.ToString() & " meters. "
                    lblConversion.Visible = True
                ElseIf radMetersToInches.Checked Then
                    decConversionValue = decInputValue * 39.3701
                    lblConversion.Text = decInputValue.ToString() & " meters is " & decConversionValue.ToString() & " inches. "
                    lblConversion.Visible = True
                End If
            Else
                MsgBox("Please Enter a positive number.", , "Invalid Number Error")
                txtEnterValue.Clear()
                txtEnterValue.Focus()
            End If
        Else
            MsgBox("Please Enter a positive number.", , "Invalid Number Error")
            txtEnterValue.Clear()
            txtEnterValue.Focus()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtEnterValue.Clear()
        txtEnterValue.Focus()
        lblConversion.Text = ""
        radInchesToMeters.Checked = True
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
