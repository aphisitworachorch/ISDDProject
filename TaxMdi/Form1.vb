Imports System.IO
Public Class Form1
    Public tax As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Filename As String
        Dim write1 As StreamWriter
        Try
            With SaveFileDialog1
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    Filename = .FileName
                    write1 = New StreamWriter(Filename)
                    write1.WriteLine(TextBox1.Text)
                    write1.WriteLine(TextBox2.Text)
                    write1.WriteLine(TextBox3.Text)
                    write1.WriteLine(TextBox4.Text)
                    write1.WriteLine(TextBox5.Text)

                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (write1 Is Nothing) Then
                write1.Close()
            End If
        End Try
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        tax = CInt(TextBox4.Text) * 0.07
        TextBox5.Text = tax
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Filename As String
        Dim read1 As StreamReader
        Try
            With OpenFileDialog1
                .Filter = "Text files (*.txt)|*.txt|" & "All files|*.*"
                If .ShowDialog() = DialogResult.OK Then
                    Filename = .FileName
                    read1 = New StreamReader(.OpenFile)
                    TextBox1.Text = read1.ReadLine()
                    TextBox2.Text = read1.ReadLine()
                    TextBox3.Text = read1.ReadLine()
                    TextBox4.Text = read1.ReadLine()
                    TextBox5.Text = read1.ReadLine()
                End If
            End With
        Catch es As Exception
            MessageBox.Show(es.Message)
        Finally
            If Not (read1 Is Nothing) Then
                read1.Close()
            End If
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Application.Exit()
    End Sub
End Class
