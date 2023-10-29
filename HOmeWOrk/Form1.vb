Public Class Form1
    Sub Silindr()
        Dim Form_silindr As New Silindr
        Form_silindr.MdiParent = Me
        Form_silindr.Show()
    End Sub
    Sub Cfera()
        Dim Form_Cfera As New Cfera
        Form_Cfera.MdiParent = Me
        Form_Cfera.Show()
    End Sub
    Sub Konus()
        Dim FormC As New Konus
        FormC.MdiParent = Me
        FormC.Show()
    End Sub
    Sub KKonus()
        Dim FormC As New Kesilgen_Konus
        FormC.MdiParent = Me
        FormC.Show()
    End Sub


    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Silindr()
    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click
        Cfera()
    End Sub

    Private Sub ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem4.Click
        Konus()
    End Sub

    Private Sub ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem5.Click
        KKonus()

    End Sub
End Class
