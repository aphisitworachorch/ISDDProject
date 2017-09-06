<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.title = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ResultPlan = New System.Windows.Forms.ListBox()
        Me.groupbx_cal = New System.Windows.Forms.GroupBox()
        Me.calculate = New System.Windows.Forms.Button()
        Me.destination_combo = New System.Windows.Forms.ComboBox()
        Me.budget_travel = New System.Windows.Forms.TextBox()
        Me.day_travel = New System.Windows.Forms.TextBox()
        Me.time_label = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.showcase = New System.Windows.Forms.Label()
        Me.groupbx_cal.SuspendLayout()
        Me.SuspendLayout()
        '
        'title
        '
        Me.title.AutoSize = True
        Me.title.Font = New System.Drawing.Font("TH Baijam", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.title.Location = New System.Drawing.Point(116, 38)
        Me.title.Name = "title"
        Me.title.Size = New System.Drawing.Size(417, 49)
        Me.title.TabIndex = 0
        Me.title.Text = "Hello World , Happy Trip :)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "คุณมีเวลากี่วัน"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Free Time"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Budget Travel"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label4.Location = New System.Drawing.Point(17, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "มีเงินกี่บาท"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Destination"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 149)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "จุดหมายปลายทาง"
        '
        'ResultPlan
        '
        Me.ResultPlan.FormattingEnabled = True
        Me.ResultPlan.Location = New System.Drawing.Point(333, 140)
        Me.ResultPlan.Name = "ResultPlan"
        Me.ResultPlan.Size = New System.Drawing.Size(266, 264)
        Me.ResultPlan.TabIndex = 7
        '
        'groupbx_cal
        '
        Me.groupbx_cal.Controls.Add(Me.showcase)
        Me.groupbx_cal.Controls.Add(Me.calculate)
        Me.groupbx_cal.Controls.Add(Me.destination_combo)
        Me.groupbx_cal.Controls.Add(Me.budget_travel)
        Me.groupbx_cal.Controls.Add(Me.day_travel)
        Me.groupbx_cal.Controls.Add(Me.Label5)
        Me.groupbx_cal.Controls.Add(Me.Label6)
        Me.groupbx_cal.Controls.Add(Me.Label3)
        Me.groupbx_cal.Controls.Add(Me.Label4)
        Me.groupbx_cal.Controls.Add(Me.Label2)
        Me.groupbx_cal.Controls.Add(Me.Label1)
        Me.groupbx_cal.Location = New System.Drawing.Point(32, 140)
        Me.groupbx_cal.Name = "groupbx_cal"
        Me.groupbx_cal.Size = New System.Drawing.Size(286, 263)
        Me.groupbx_cal.TabIndex = 8
        Me.groupbx_cal.TabStop = False
        Me.groupbx_cal.Text = "กรอกข้อมูลเพื่อคำนวณ"
        '
        'calculate
        '
        Me.calculate.Location = New System.Drawing.Point(144, 220)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(124, 27)
        Me.calculate.TabIndex = 10
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'destination_combo
        '
        Me.destination_combo.FormattingEnabled = True
        Me.destination_combo.Items.AddRange(New Object() {"JAPAN", "USA", "UK", "FRANCE"})
        Me.destination_combo.Location = New System.Drawing.Point(144, 158)
        Me.destination_combo.Name = "destination_combo"
        Me.destination_combo.Size = New System.Drawing.Size(125, 21)
        Me.destination_combo.TabIndex = 9
        '
        'budget_travel
        '
        Me.budget_travel.Location = New System.Drawing.Point(144, 107)
        Me.budget_travel.Name = "budget_travel"
        Me.budget_travel.Size = New System.Drawing.Size(125, 20)
        Me.budget_travel.TabIndex = 8
        '
        'day_travel
        '
        Me.day_travel.Location = New System.Drawing.Point(144, 50)
        Me.day_travel.Name = "day_travel"
        Me.day_travel.Size = New System.Drawing.Size(125, 20)
        Me.day_travel.TabIndex = 7
        '
        'time_label
        '
        Me.time_label.AutoSize = True
        Me.time_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.time_label.Location = New System.Drawing.Point(526, 117)
        Me.time_label.Name = "time_label"
        Me.time_label.Size = New System.Drawing.Size(18, 20)
        Me.time_label.TabIndex = 11
        Me.time_label.Text = "#"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'showcase
        '
        Me.showcase.AutoSize = True
        Me.showcase.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(222, Byte))
        Me.showcase.Location = New System.Drawing.Point(148, 197)
        Me.showcase.Name = "showcase"
        Me.showcase.Size = New System.Drawing.Size(21, 20)
        Me.showcase.TabIndex = 11
        Me.showcase.Text = "..."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 429)
        Me.Controls.Add(Me.time_label)
        Me.Controls.Add(Me.groupbx_cal)
        Me.Controls.Add(Me.ResultPlan)
        Me.Controls.Add(Me.title)
        Me.Name = "Form1"
        Me.Text = "I believe I Can Fly"
        Me.groupbx_cal.ResumeLayout(False)
        Me.groupbx_cal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents title As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ResultPlan As ListBox
    Friend WithEvents groupbx_cal As GroupBox
    Friend WithEvents calculate As Button
    Friend WithEvents destination_combo As ComboBox
    Friend WithEvents budget_travel As TextBox
    Friend WithEvents day_travel As TextBox
    Friend WithEvents time_label As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents showcase As Label
End Class
