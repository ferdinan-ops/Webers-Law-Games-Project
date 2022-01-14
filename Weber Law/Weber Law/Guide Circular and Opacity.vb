Public Class Guide_Circular_and_Opacity

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        Me.Hide()
    End Sub

    Private Sub Guide_Circular_and_Opacity_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
    End Sub
End Class