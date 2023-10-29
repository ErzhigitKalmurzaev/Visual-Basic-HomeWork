Public Class Kesilgen_Konus
    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        Try
            Label_S.ForeColor = Color.Black
            Label_S.Text = "Конустун толук аянты   "
            Label_SW.Text = "Конустун сырткы бетинин аянты   "
            Label_V.Text = "Конустун көлөмү   "
            Label_S.Visible = False
            Label_V.Visible = False
            Label_SW.Visible = False
            Dim R As Double = Convert.ToDouble(TextBox_R.Text)
            Dim H As Double = Convert.ToDouble(TextBox_H.Text)
            Dim rr As Double = Convert.ToDouble(TextBox_rr.Text)

            If R <= 0 Or H <= 0 Or rr <= 0 Or rr >= R Then
                Throw New Exception("Invalid Value")
            End If
            Dim l As Double = Math.Sqrt(Math.Pow(R - rr, 2) + H * H)
            Dim SW As Double = Math.PI * (R + rr) * l
            Dim S As Double = Math.PI * (R + rr) * l + Math.PI * R * R + Math.PI * rr * rr
            Dim V As Double = 1 / 3 * Math.PI * H * (R * R + rr * rr + R * rr)

            Label_S.Visible = True
            Label_V.Visible = True
            Label_SW.Visible = True
            Label_S.Text += S.ToString
            Label_V.Text += V.ToString
            Label_SW.Text += SW.ToString
        Catch ex As Exception
            Label_S.ForeColor = Color.Red
            Label_S.Visible = True
            Label_S.Text = "Invalid Value"
        End Try

    End Sub
End Class