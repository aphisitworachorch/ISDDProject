Public Class Form1
    Public a As Integer
    Public b As Integer
    Public c As Integer
    Public TempX As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text

        If a > b Then
            TempX = a
            a = b
            b = TempX
        End If
        If b > c Then
            TempX = b
            b = c
            c = TempX
        End If
        If a > b Then
            TempX = a
            a = b
            b = TempX
        End If

        Label4.Text = (a & "," & b & "," & c)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class
