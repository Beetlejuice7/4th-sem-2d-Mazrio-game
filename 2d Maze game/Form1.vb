Public Class Form1
    Dim count As Integer = 0
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'PictureBox2.BackColor = Color.Red
        'hello testing only
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
            Label6.Visible = True
            Label7.Visible = False
            Label8.Visible = False
            Label6.Text = "X"
            PictureBox22.Visible = True
            PictureBox23.Visible = True
            PictureBox24.Visible = True
            Reset()
            count = 0
        End If

        'if touch wall reset position
        If PictureBox1.Bounds.IntersectsWith(PictureBox16.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox10.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox18.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox4.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox11.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox6.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox9.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox8.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox7.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox5.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox15.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox17.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox12.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox19.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox13.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox14.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox3.Bounds) Or PictureBox1.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            Reset()
            count += 1
            Label6.Text = count
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
        If count = 1 Then
            PictureBox24.Visible = False
        ElseIf count = 2 Then
            PictureBox23.Visible = False
        ElseIf count = 3 Then
            PictureBox22.Visible = False
            Label6.Visible = False
            count = 0
            'MsgBox("Game Over")
            Label4.Visible = True
            Label5.Visible = True
            'Label1.Text = "Count"
            'PictureBox22.Visible = True
            'PictureBox23.Visible = True
            'PictureBox24.Visible = True
        End If

        'if finish game
        If PictureBox1.Bounds.IntersectsWith(PictureBox21.Bounds) Then
            'MsgBox("Hurray you won!!!")
            Label7.Visible = True
            Label8.Visible = True
            'Reset()
            count = 0
            Label6.Text = "X"
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
        Timer1.Interval = 2000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Visible = False
        Timer1.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Label5.Visible = False
        Label4.Visible = False
        Reset()
        count = 0
        Label1.Text = "Count"
        PictureBox22.Visible = True
        PictureBox23.Visible = True
        PictureBox24.Visible = True
    End Sub


End Class
