Public Class Form1
    Public date_cal As Integer
    Public budget_cal As Integer
    Public destination As String
    Public loop_cal As Integer
    Public travel_cal As Double
    Public Roundup As Integer
    Public calculus As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        time_label.Text = DateAndTime.Today
    End Sub

    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        ResultPlan.Items.Clear()
        loop_cal = 0
        calculus = 0
        travel_cal = 0
        date_cal = day_travel.Text
        budget_cal = budget_travel.Text
        destination = destination_combo.Text

        For loop_cal = 1 To date_cal
            Roundup = budget_cal / date_cal
            ' Start of Select Case Based on All Sheet '
            Select Case destination
                Case Is = "JAPAN"
                    showcase.Text = "สกุลที่เลือกคือ JPY"
                    calculus = calculus + 1
                    If date_cal = 1 Then
                        travel_cal = Roundup / 31.4
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " JPY")
                    ElseIf date_cal > 1 Then
                        travel_cal = Roundup * calculus / 31.4
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " JPY")
                    End If
                Case Is = "USA"
                    showcase.Text = "สกุลที่เลือกคือ USD"
                    calculus = calculus + 1
                    If date_cal = 1 Then
                        travel_cal = Roundup / 33.48
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " USD")
                    ElseIf date_cal > 1 Then
                    travel_cal = Roundup * calculus / 33.48
                    ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " USD")
                    End If
                Case Is = "UK"
                    showcase.Text = "สกุลที่เลือกคือ GBP"
                    calculus = calculus + 1
                    If date_cal = 1 Then
                        travel_cal = Roundup / 44.17
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " GBP")
                    ElseIf date_cal > 1 Then
                        travel_cal = Roundup * calculus / 44.17
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " GBP")
                    End If
                Case Is = "FRANCE"
                    showcase.Text = "สกุลที่เลือกคือ EUR"
                    calculus = calculus + 1
                    If date_cal = 1 Then
                        travel_cal = Roundup / 40.3
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " EUR")
                    ElseIf date_cal > 1 Then
                        travel_cal = Roundup * calculus / 40.3
                        ResultPlan.Items.Add("Day " & loop_cal & "ใช้เงิน" & Roundup * loop_cal & "THB / " & FormatNumber(travel_cal) & " EUR")
                    End If

            End Select

        Next

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    End Sub

    Private Sub time_label_Click(sender As Object, e As EventArgs) Handles time_label.Click

    End Sub
End Class
