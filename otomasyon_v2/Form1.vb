Public Class Form1
    Dim sonuc As Object
    Dim girdi As String
    Dim btn As Button

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click, Button11.Click, Button12.Click, Button13.Click, Button14.Click, Button15.Click, Button19.Click, Button20.Click
        btn = DirectCast(sender, Button)
        TextBox1.Text += btn.Text
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Clear()
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If TextBox1.TextLength > 0 Then
            TextBox1.Text = TextBox1.Text.Substring(0, TextBox1.TextLength - 1)
            TextBox1.SelectionStart = TextBox1.TextLength
        End If
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Dim hata As Exception
        girdi = TextBox1.Text.Trim()
        If girdi.All(Function(c) Char.IsDigit(c) OrElse "+-*/,()".Contains(c)) Then
            Try
                sonuc = New DataTable().Compute(girdi.Replace(",", "."), Nothing)
                TextBox1.Text += vbNewLine + sonuc.ToString()
            Catch hata
                MessageBox.Show("Geçersiz işlem girişi: " & hata.Message)
            End Try
        End If
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not (Char.IsDigit(e.KeyChar) OrElse
            e.KeyChar = "+"c OrElse
            e.KeyChar = "-"c OrElse
            e.KeyChar = "*"c OrElse
            e.KeyChar = "/"c OrElse
            e.KeyChar = ","c OrElse
            e.KeyChar = "("c OrElse
            e.KeyChar = ")"c OrElse
            e.KeyChar = Convert.ToChar(Keys.Back) OrElse
            e.KeyChar = Convert.ToChar(Keys.Enter)) Then
            e.Handled = True
        End If
        If e.KeyChar = Convert.ToChar(Keys.Enter) Then
            e.Handled = True
            Button18.PerformClick()
        End If
    End Sub
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Delete Then
            TextBox1.Clear()
            e.Handled = True
        End If
    End Sub
End Class
