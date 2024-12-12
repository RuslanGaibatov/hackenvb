Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Button1.Size = New Size(Button1.Size.Width, Button1.Size.Height + 1)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button1.Size = New Size(Button1.Size.Width, Button1.Size.Height - 1)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Button2.Size = New Size(Button2.Size.Width + 1, Button2.Size.Height)
        Button1.Location = New Point(Button1.Location.X - 1, Button1.Location.Y)
        Button2.Location = New Point(Button2.Location.X - 1, Button2.Location.Y)
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Button2.Size = New Size(Button2.Size.Width - 1, Button2.Size.Height)
        Button1.Location = New Point(Button1.Location.X + 1, Button1.Location.Y)
        Button2.Location = New Point(Button2.Location.X + 1, Button2.Location.Y)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Timer4.Start()
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Button3.Size = New Size(Button3.Size.Width, Button3.Size.Height + 1)
        Button1.Location = New Point(Button1.Location.X, Button1.Location.Y - 1)
        Button2.Location = New Point(Button2.Location.X, Button2.Location.Y - 1)
        Button3.Location = New Point(Button3.Location.X, Button3.Location.Y - 1)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Timer5.Start()
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Button3.Size = New Size(Button3.Size.Width, Button3.Size.Height - 1)
        Button1.Location = New Point(Button1.Location.X, Button1.Location.Y + 1)
        Button2.Location = New Point(Button2.Location.X, Button2.Location.Y + 1)
        Button3.Location = New Point(Button3.Location.X, Button3.Location.Y + 1)
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Timer6.Start()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Button1.Location = New Point(Button1.Location.X - 5, Button1.Location.Y)
        Button2.Location = New Point(Button2.Location.X - 5, Button2.Location.Y)
        Button3.Location = New Point(Button3.Location.X - 5, Button3.Location.Y)
        Button4.Location = New Point(Button4.Location.X - 5, Button4.Location.Y)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Button1.Location = New Point(Button1.Location.X + 5, Button1.Location.Y)
        Button2.Location = New Point(Button2.Location.X + 5, Button2.Location.Y)
        Button3.Location = New Point(Button3.Location.X + 5, Button3.Location.Y)
        Button4.Location = New Point(Button4.Location.X + 5, Button4.Location.Y)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Button1.Location = New Point(383, 147)
        Button2.Location = New Point(383, 126)
        Button3.Location = New Point(473, 147)
        Button4.Location = New Point(360, 243)
        Button1.Size = New Point(12, 23)
        Button2.Size = New Point(160, 23)
        Button3.Size = New Point(22, 100)
        Button4.Size = New Point(224, 23)
    End Sub
End Class
