Imports System.Linq.Expressions

Public Class Silindr
    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        Try
            Label_S.Visible = False
            Label_V.Visible = False
            Label_SW.Visible = False
            Label_S.ForeColor = Color.Black
            Dim r As Double = Val(R_V.Text)
            Dim h As Double = Val(H_V.Text)
            If r <= 0 Or h <= 0 Then
                Throw New Exception("Число меньше нуля")
            End If
            Dim sw As Double = 2 * Math.PI * r * h
            Dim s As Double = 2 * (Math.PI * r * r) + sw
            Dim v As Double = Math.PI * r * r * h
            Label_S.Visible = True
            Label_V.Visible = True
            Label_SW.Visible = True
            Label_S.Text = "цилиндрдин сырткы бетинин аянты"
            Label_V.Text = "цилиндрдин көлөмү"
            Label_SW.Text = "цилиндрдин толук аянты"


            Label_S.Text = Label_S.Text + "   " + sw.ToString()
            Label_V.Text = Label_V.Text + "   " + v.ToString()
            Label_SW.Text = Label_SW.Text + "   " + s.ToString()

        Catch ex As Exception
            Label_S.Visible = True
            Label_S.ForeColor = Color.Red
            Label_S.Text = "Туура эмес маалымат киргизилди"
        End Try

    End Sub


End Class