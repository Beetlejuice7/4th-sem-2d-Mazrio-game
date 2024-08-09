Public Class Form1
    Dim life As Integer = 0
    Dim coin As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox2.BackColor = Color.Reds
        'Win Label location - 172, 389
        'PressSpaceplayAgain - 326, 569
        'GameOver - 150, 392
        'PressSpacetoRetry - 326, 569
        'OutofRange - 284, 425
        'Dim currentLocation As Point = PictureBox39.Location
        'Dim x As Integer = currentLocation.X
        'Dim y As Integer = currentLocation.Y
        'MessageBox.Show("X: " & x & ", Y: " & y)
        PictureBox39.Location = New Point(24, 45)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyValue = Keys.D Then
            PictureBox1.Left = PictureBox1.Left + 5
        End If
        If e.KeyValue = Keys.A Then
            PictureBox1.Left = PictureBox1.Left - 5
        End If
        If e.KeyValue = Keys.W Then
            PictureBox1.Top = PictureBox1.Top - 5
        End If
        If e.KeyValue = Keys.S Then
            PictureBox1.Top = PictureBox1.Top + 5
        End If
        If PictureBox1.Location.X < 0 Then
            PictureBox1.Left = 0
        End If

        If e.KeyValue = Keys.Space Then
            Label4.Visible = False
            Label5.Visible = False
            'Label6.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            Label6.Text = "X"
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            PictureBox40.Visible = False
            Reset()
            coinReset()
            life = 0
            coin = 0
            Label6.Text = coin
            Label2.Visible = False
            PictureBox41.Visible = False
        End If

        If coin = 2 And PictureBox1.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            coin = 99998
            Label6.Text = coin
        End If

        'coin counter
        If PictureBox1.Bounds.IntersectsWith(PictureBox32.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox33.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox34.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox35.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox36.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox37.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox38.Bounds) Then

            coin += 1
            Label6.Text = coin
            PictureBox39.Location = New Point(24, 30)
            PictureBox39.Location = New Point(24, 45)
        End If

        'if touch wall reset position
        If PictureBox1.Bounds.IntersectsWith(PictureBox16.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox18.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox11.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox9.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox8.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox7.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox15.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox17.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox19.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox14.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            Reset()
            life += 1
            'Coin storing top left
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox32.Bounds) Then
            'PictureBox32.Visible = False

            PictureBox32.Location = New Point(31, 58)
            PictureBox32.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox33.Bounds) Then
            PictureBox33.Location = New Point(31, 58)
            PictureBox33.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox34.Bounds) Then
            PictureBox34.Location = New Point(31, 58)
            PictureBox34.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox35.Bounds) Then
            PictureBox35.Location = New Point(31, 58)
            PictureBox35.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox36.Bounds) Then
            PictureBox36.Location = New Point(31, 58)
            PictureBox36.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox37.Bounds) Then
            PictureBox37.Location = New Point(31, 58)
            PictureBox37.Visible = False
            soundEffect()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox38.Bounds) Then
            PictureBox38.Location = New Point(31, 58)
            PictureBox38.Visible = False
            soundEffect()

        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox20.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox25.Bounds) Then
            'MsgBox("Out of Range")
            outofrange()
            Reset()
        ElseIf PictureBox1.Bounds.IntersectsWith(Label3.Bounds) Then
            Application.Exit()
        ElseIf PictureBox1.Bounds.IntersectsWith(PictureBox27.Bounds) Then
            PictureBox1.Left = 45
            PictureBox1.Top = 270
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox31.Bounds) Then
            PictureBox1.Left += 7
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox28.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox29.Bounds) Then
            'PictureBox1.Left += 7
            PictureBox1.Top += 7
        End If
        If PictureBox1.Bounds.IntersectsWith(PictureBox30.Bounds) Then
            'PictureBox1.Left -= 2
            PictureBox1.Top -= 7
        End If

        'life count
        If life = 1 Then
            PictureBox24.Visible = False
        ElseIf life = 2 Then
            PictureBox23.Visible = False
        ElseIf life = 3 Then
            PictureBox22.Visible = False
            life = 0
            coin = 0
            Label6.Text = coin
            'MsgBox("Game Over")
            Label4.Visible = True
            Label5.Visible = True
        End If

        'if finish game
        If PictureBox1.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            'MsgBox("Hurray you won!!!")
            Label7.Visible = True
            Label8.Visible = True
            PictureBox40.Visible = True
            'Reset()
            life = 0
            PictureBox22.Visible = False
            PictureBox23.Visible = False
            PictureBox24.Visible = False
        End If

        'if box out of range
        If PictureBox1.Bounds.IntersectsWith(PictureBox20.Bounds) Then
            'MsgBox("Out of Range")
            outofrange()
            Reset()
        End If
    End Sub
    Public Sub Reset()
        PictureBox1.Left = 97.5
        PictureBox1.Top = 135
    End Sub

    Private Sub outofrange()
        Label2.Visible = True
        PictureBox41.Visible = True
        Timer1.Interval = 2000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Visible = False
        PictureBox41.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub soundEffect()
        My.Computer.Audio.Play("C:\Users\ME\Desktop\mario coin sound effect.wav")
    End Sub

    Private Sub coinReset()
        PictureBox32.Location = New Point(115, 67)
        PictureBox33.Location = New Point(245, 148)
        PictureBox34.Location = New Point(115, 205)
        PictureBox35.Location = New Point(448, 282)
        PictureBox36.Location = New Point(193, 273)
        PictureBox37.Location = New Point(262, 411)
        PictureBox38.Location = New Point(458, 406)

        PictureBox32.Visible = True
        PictureBox33.Visible = True
        PictureBox34.Visible = True
        PictureBox35.Visible = True
        PictureBox36.Visible = True
        PictureBox37.Visible = True
        PictureBox38.Visible = True

    End Sub

    Private Sub Label13_MouseHover(sender As Object, e As EventArgs) Handles Label13.MouseHover
        'Label13.BackColor = Color.Red
        Label14.Visible = True
    End Sub

    Private Sub Label13_MouseLeave(sender As Object, e As EventArgs) Handles Label13.MouseLeave
        'Label13.BackColor = Color.LightSteelBlue
        Label14.Visible = False
    End Sub
End Class
