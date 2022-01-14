Public Class Circular_Shapes
    
    Private Sub Circular_Shapes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton2.Width = GunaCircleButton2.Width + 1
            GunaCircleButton2.Height = GunaCircleButton2.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton2.Width = GunaCircleButton2.Width + 1
            GunaCircleButton2.Height = GunaCircleButton2.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton2.Width = GunaCircleButton2.Width + 1
            GunaCircleButton2.Height = GunaCircleButton2.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton2.Width = GunaCircleButton2.Width + 1
            GunaCircleButton2.Height = GunaCircleButton2.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton2.Width = GunaCircleButton2.Width + 1
            GunaCircleButton2.Height = GunaCircleButton2.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1

        End If
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        If Label6.Text = 0 Or Label6.Text = Val(Label6.Text) Mod 6 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer1.Enabled = True Then
                Timer1.Start()
            Else
                Label1.Text = 10
                Timer1.Start()
            End If
        ElseIf Label6.Text = 1 Or Label6.Text = Val(Label6.Text) Mod 7 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer2.Enabled = True Then
                Timer2.Start()
            Else
                Label1.Text = 10
                Timer2.Start()
            End If
        ElseIf Label6.Text = 2 Or Label6.Text = Val(Label6.Text) Mod 8 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer3.Enabled = True Then
                Timer3.Start()
            Else
                Label1.Text = 10
                Timer3.Start()
            End If
        ElseIf Label6.Text = 3 Or Label6.Text = Val(Label6.Text) Mod 9 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer4.Enabled = True Then
                Timer2.Start()
            Else
                Label1.Text = 10
                Timer4.Start()
            End If
        ElseIf Label6.Text = 4 Or Label6.Text = Val(Label6.Text) Mod 10 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer5.Enabled = True Then
                Timer5.Start()
            Else
                Label1.Text = 10
                Timer5.Start()
            End If
        ElseIf Label6.Text = 5 Or Label6.Text = Val(Label6.Text) Mod 11 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer6.Enabled = True Then
                Timer6.Start()
            Else
                Label1.Text = 10
                Timer6.Start()
            End If
        End If
    End Sub

    Private Sub GunaButton8_Click(sender As Object, e As EventArgs) Handles GunaButton8.Click
        GunaButton7.Enabled = True
        Label1.Text = 10
        Label1.ForeColor = Color.FromArgb(0, 192, 0)
        Label1.ForeColor = Color.FromArgb(0, 192, 0)
        GunaCircleButton1.Size = New Size(80, 80)
        GunaCircleButton2.Size = New Size(80, 80)
        GunaCircleButton3.Size = New Size(80, 80)
        GunaCircleButton4.Size = New Size(80, 80)
        GunaCircleButton5.Size = New Size(80, 80)
        GunaCircleButton6.Size = New Size(80, 80)
        GunaCircleProgressBar1.ProgressMaxColor = Color.FromArgb(0, 192, 192)
        GunaCircleProgressBar1.ProgressMinColor = Color.FromArgb(0, 192, 0)
    End Sub

    Private Sub GunaCircleButton2_Click(sender As Object, e As EventArgs) Handles GunaCircleButton2.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 1 Or Label6.Text = Val(Label6.Text) Mod 7 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
            ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
            End If
        True_Answer.Show()
        Else
        Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaCircleButton1_Click(sender As Object, e As EventArgs) Handles GunaCircleButton1.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 2 Or Label6.Text = Val(Label6.Text) Mod 8 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
            ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
            End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaCircleButton3_Click(sender As Object, e As EventArgs) Handles GunaCircleButton3.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 3 Or Label6.Text = Val(Label6.Text) Mod 9 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
            ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
            End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaCircleButton6_Click(sender As Object, e As EventArgs) Handles GunaCircleButton6.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 6 Or Label6.Text = Val(Label6.Text) Mod 12 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
                ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
            End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaCircleButton5_Click(sender As Object, e As EventArgs) Handles GunaCircleButton5.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 5 Or Label6.Text = Val(Label6.Text) Mod 11 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
                ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
                End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaCircleButton4_Click(sender As Object, e As EventArgs) Handles GunaCircleButton4.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 4 Or Label6.Text = Val(Label6.Text) Mod 10 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
                ElseIf Val(Label5.Text) > 0 Then
                Label5.Text = Val(Label5.Text) + 1
            End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Guide_Circular_and_Opacity.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        Timer2.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton1.Width = GunaCircleButton1.Width + 1
            GunaCircleButton1.Height = GunaCircleButton1.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton1.Width = GunaCircleButton1.Width + 1
            GunaCircleButton1.Height = GunaCircleButton1.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton1.Width = GunaCircleButton1.Width + 1
            GunaCircleButton1.Height = GunaCircleButton1.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton1.Width = GunaCircleButton1.Width + 1
            GunaCircleButton1.Height = GunaCircleButton1.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton1.Width = GunaCircleButton1.Width + 1
            GunaCircleButton1.Height = GunaCircleButton1.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer2.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Start()
        Timer3.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton3.Width = GunaCircleButton3.Width + 1
            GunaCircleButton3.Height = GunaCircleButton3.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton3.Width = GunaCircleButton3.Width + 1
            GunaCircleButton3.Height = GunaCircleButton3.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton3.Width = GunaCircleButton3.Width + 1
            GunaCircleButton3.Height = GunaCircleButton3.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton3.Width = GunaCircleButton3.Width + 1
            GunaCircleButton3.Height = GunaCircleButton3.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton3.Width = GunaCircleButton3.Width + 1
            GunaCircleButton3.Height = GunaCircleButton3.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer3.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Start()
        Timer4.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton4.Width = GunaCircleButton4.Width + 1
            GunaCircleButton4.Height = GunaCircleButton4.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton4.Width = GunaCircleButton4.Width + 1
            GunaCircleButton4.Height = GunaCircleButton4.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton4.Width = GunaCircleButton4.Width + 1
            GunaCircleButton4.Height = GunaCircleButton4.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton4.Width = GunaCircleButton4.Width + 1
            GunaCircleButton4.Height = GunaCircleButton4.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton4.Width = GunaCircleButton4.Width + 1
            GunaCircleButton4.Height = GunaCircleButton4.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label4.Text = 0 Then
            Timer1.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Start()
        Timer5.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton5.Width = GunaCircleButton5.Width + 1
            GunaCircleButton5.Height = GunaCircleButton5.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton5.Width = GunaCircleButton5.Width + 1
            GunaCircleButton5.Height = GunaCircleButton5.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton5.Width = GunaCircleButton5.Width + 1
            GunaCircleButton5.Height = GunaCircleButton5.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton5.Width = GunaCircleButton5.Width + 1
            GunaCircleButton5.Height = GunaCircleButton5.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton5.Width = GunaCircleButton5.Width + 1
            GunaCircleButton5.Height = GunaCircleButton5.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer5.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer6.Start()
        Timer6.Interval = 1000

        GunaCircleButton1.Enabled = False
        GunaCircleButton2.Enabled = False
        GunaCircleButton3.Enabled = False
        GunaCircleButton4.Enabled = False
        GunaCircleButton5.Enabled = False
        GunaCircleButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaCircleButton6.Width = GunaCircleButton6.Width + 1
            GunaCircleButton6.Height = GunaCircleButton6.Height + 1
        ElseIf Label1.Text = 8 Then
            GunaCircleButton6.Width = GunaCircleButton6.Width + 1
            GunaCircleButton1.Height = GunaCircleButton6.Height + 1
        ElseIf Label1.Text = 6 Then
            GunaCircleButton6.Width = GunaCircleButton6.Width + 1
            GunaCircleButton6.Height = GunaCircleButton6.Height + 1
        ElseIf Label1.Text = 4 Then
            GunaCircleButton6.Width = GunaCircleButton6.Width + 1
            GunaCircleButton6.Height = GunaCircleButton6.Height + 1
        ElseIf Label1.Text = 2 Then
            GunaCircleButton6.Width = GunaCircleButton6.Width + 1
            GunaCircleButton6.Height = GunaCircleButton6.Height + 1
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer6.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaCircleButton1.Enabled = True
            GunaCircleButton2.Enabled = True
            GunaCircleButton3.Enabled = True
            GunaCircleButton4.Enabled = True
            GunaCircleButton5.Enabled = True
            GunaCircleButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub
End Class