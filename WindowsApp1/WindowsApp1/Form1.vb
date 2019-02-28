Public Class Form1
    Dim str1 As Double
    Dim str2 As Double
    Dim str As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text += Button1.Text
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text += Button12.Text
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text += Button11.Text
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text += Button13.Text
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text += Button10.Text
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text += Button8.Text
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text += Button4.Text
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text += Button9.Text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text += Button2.Text
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text += Button14.Text
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        str1 = Val(TextBox1.Text)
        TextBox1.Text = "+"
        str = Button15.Text
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        str1 = Val(TextBox1.Text)
        TextBox1.Text = "-"
        str = Button19.Text
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        str1 = Val(TextBox1.Text)
        TextBox1.Text = "*"
        str = Button18.Text
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        str1 = Val(TextBox1.Text)
        TextBox1.Text = "/"
        str = Button20.Text
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        'str = Val(TextBox1.Text)
        str2 = Val(TextBox1.Text)
        If str = "-" Then
            TextBox1.Text = str1 - str2
        ElseIf str = "+" Then
            TextBox1.Text = str1 + str2
        ElseIf str = "*" Then
            TextBox1.Text = str1 * str2
        ElseIf str = "/" Then
            TextBox1.Text = str1 / str2
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        TextBox1.Text = ""
        str = ""
    End Sub
End Class
