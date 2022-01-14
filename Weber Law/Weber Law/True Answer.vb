Public Class True_Answer

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim tanya
        tanya = MessageBox.Show("Anda Ingin Bermain Lagi ??", "Keluar", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If tanya = vbYes Then
            Me.Hide()
        Else
            Me.Hide()
            Rectangular_Shapes.Hide()
            Circular_Shapes.Hide()
            Color_Opacity.Hide()
            Home.Show()
        End If
    End Sub

    Private Sub Benar_Weber_Law_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class