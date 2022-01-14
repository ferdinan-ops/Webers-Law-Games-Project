Public Class Rectangular_Shapes

    Private Sub Rectangular_Shapes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        Timer1.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton6.Width = GunaButton6.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton6.Width = GunaButton6.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton6.Width = GunaButton6.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton6.Width = GunaButton6.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton6.Width = GunaButton6.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer1.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub GunaButton7_Click(sender As Object, e As EventArgs) Handles GunaButton7.Click
        If Label6.Text = 0 Or Val(Label6.Text) Mod 6 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer1.Enabled = True Then
                Timer1.Start()
            Else
                Label1.Text = 10
                Timer1.Start()
            End If
        ElseIf Label6.Text = 1 Or Val(Label6.Text) Mod 7 = 0 Then
            GunaCircleProgressBar1.Animated = True
            Timer1.Enabled = False
            If Timer2.Enabled = True Then
                Timer2.Start()
            Else
                Label1.Text = 10
                Timer2.Start()
            End If
        ElseIf Label6.Text = 2 Or Val(Label6.Text) Mod 8 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer3.Enabled = True Then
                Timer3.Start()
            Else
                Label1.Text = 10
                Timer3.Start()
            End If
        ElseIf Label6.Text = 3 Or Val(Label6.Text) Mod 9 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer4.Enabled = True Then
                Timer2.Start()
            Else
                Label1.Text = 10
                Timer4.Start()
            End If
        ElseIf Label6.Text = 4 Or Val(Label6.Text) Mod 10 = 0 Then
            GunaCircleProgressBar1.Animated = True
            If Timer5.Enabled = True Then
                Timer5.Start()
            Else
                Label1.Text = 10
                Timer5.Start()
            End If
        ElseIf Label6.Text = 5 Or Val(Label6.Text) Mod 11 = 0 Then
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

        Label1.Text = 10
        GunaButton7.Enabled = True
        Label1.ForeColor = Color.FromArgb(0, 192, 0)
        GunaButton1.Width = 287
        GunaButton2.Width = 287
        GunaButton3.Width = 287
        GunaButton4.Width = 287
        GunaButton5.Width = 287
        GunaButton6.Width = 287
        GunaCircleProgressBar1.ProgressMaxColor = Color.FromArgb(0, 192, 192)
        GunaCircleProgressBar1.ProgressMinColor = Color.FromArgb(0, 192, 0)
    End Sub

    Private Sub GunaButton6_Click(sender As Object, e As EventArgs) Handles GunaButton6.Click
        Label6.Text = Label6.Text + 1
        If Label6.Text = 1 Or Label6.Text = Val(Label6.Text) Mod 7 = 0 Then
            If Label5.Text = "0" Then
                Label5.Text = Val(Label5.Text) + 1
                'Benar_Weber_Law.Show()
            End If
            True_Answer.Show()
        Else
            Wrong_Answer.Show()
        End If
    End Sub

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
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

    Private Sub GunaButton3_Click(sender As Object, e As EventArgs) Handles GunaButton3.Click
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

    Private Sub GunaButton5_Click(sender As Object, e As EventArgs) Handles GunaButton5.Click
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

    Private Sub GunaButton2_Click(sender As Object, e As EventArgs) Handles GunaButton2.Click
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

    Private Sub GunaButton4_Click(sender As Object, e As EventArgs) Handles GunaButton4.Click
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

    Private Sub GunaTransfarantPictureBox1_Click(sender As Object, e As EventArgs) Handles GunaTransfarantPictureBox1.Click
        Petunjuk.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Start()
        Timer2.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton1.Width = GunaButton1.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton1.Width = GunaButton1.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton1.Width = GunaButton1.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton1.Width = GunaButton1.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton1.Width = GunaButton1.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer2.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Start()
        Timer3.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton2.Width = GunaButton2.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton2.Width = GunaButton2.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton2.Width = GunaButton2.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton2.Width = GunaButton2.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton2.Width = GunaButton2.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer3.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Start()
        Timer4.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton3.Width = GunaButton3.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton3.Width = GunaButton3.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton3.Width = GunaButton3.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton3.Width = GunaButton3.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton3.Width = GunaButton3.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer4.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Timer5.Start()
        Timer5.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton4.Width = GunaButton4.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton4.Width = GunaButton4.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton4.Width = GunaButton4.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton4.Width = GunaButton4.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton4.Width = GunaButton4.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer5.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Timer6.Start()
        Timer6.Interval = 1000

        GunaButton1.Enabled = False
        GunaButton2.Enabled = False
        GunaButton3.Enabled = False
        GunaButton4.Enabled = False
        GunaButton5.Enabled = False
        GunaButton6.Enabled = False
        GunaButton8.Enabled = False

        If Label1.Text = 10 Then
            GunaButton5.Width = GunaButton5.Width + 2
        ElseIf Label1.Text = 8 Then
            GunaButton5.Width = GunaButton5.Width + 2
        ElseIf Label1.Text = 6 Then
            GunaButton5.Width = GunaButton5.Width + 2
        ElseIf Label1.Text = 4 Then
            GunaButton5.Width = GunaButton5.Width + 2
        ElseIf Label1.Text = 2 Then
            GunaButton5.Width = GunaButton5.Width + 2
        End If

        If Label1.Text = 4 Then
            Label1.ForeColor = Color.Red
            Label1.Text = Val(Label1.Text) - 1
            GunaCircleProgressBar1.ProgressMaxColor = Color.Red
            GunaCircleProgressBar1.ProgressMinColor = Color.MistyRose
        ElseIf Label1.Text = 0 Then
            Timer6.Enabled = False
            GunaCircleProgressBar1.Animated = False
            GunaButton1.Enabled = True
            GunaButton2.Enabled = True
            GunaButton3.Enabled = True
            GunaButton4.Enabled = True
            GunaButton5.Enabled = True
            GunaButton6.Enabled = True
            GunaButton8.Enabled = True
            GunaButton7.Enabled = False
        Else
            Label1.Text = Val(Label1.Text) - 1
        End If
    End Sub
End Class