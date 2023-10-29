Public Class Cfera
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Label_S.Visible = False
            Label_V.Visible = False
            Label_S.Text = "Cферанын аянты"
            Label_V.Text = "Сферанын  көлөмү"
            Label_S.ForeColor = Color.Black
            Dim R As Double = Convert.ToDouble(TextBox_R.Text)
            If R <= 0 Then
                Throw New Exception("invalid value")
            End If
            Dim S As Double = 4 * Math.PI * R * R
            Dim V As Double = 4 / 3 * Math.PI * R * R * R
            Label_S.Visible = True
            Label_V.Visible = True
            Label_S.Text = Label_S.Text + "   " + S.ToString
            Label_V.Text = Label_V.Text + "   " + V.ToString
        Catch ex As Exception
            Label_S.Visible = True
            Label_S.ForeColor = Color.Red
            Label_S.Text = "Invalid Value"
        End Try

    End Sub
End Class