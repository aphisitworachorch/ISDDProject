Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1, num2, calc As Integer
        num1 = TextBox1.Text
        num2 = TextBox2.Text

        calc += Int(num1) + Int(num2)

        Label1.Text = ("ผลรวมทั้งหมดคือ " & calc)

        MessageBox.Show(calc, "Summation")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub
End Class
