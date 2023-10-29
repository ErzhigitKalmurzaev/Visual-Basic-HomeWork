Public Class Konus
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
            If R <= 0 Or H <= 0 Then
                Throw New Exception("Invalid Value")
            End If
            Dim l As Double = Math.Sqrt(R * R + H * H)
            Dim SW As Double = Math.PI * R * l
            Dim S As Double = Math.PI * R * R + SW
            Dim V As Double = 1 / 3 * Math.PI * R * R * H
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