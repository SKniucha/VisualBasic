<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BMI
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
        Me.TitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ImperialRadioButton = New System.Windows.Forms.RadioButton()
        Me.MetricRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BMITextBox = New System.Windows.Forms.TextBox()
        Me.ResultTextBox = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightTextBox = New System.Windows.Forms.TextBox()
        Me.WeightUnitLabel = New System.Windows.Forms.Label()
        Me.HeightUnitLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TitleLabel
        '
        Me.TitleLabel.AutoSize = True
        Me.TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleLabel.Location = New System.Drawing.Point(190, 31)
        Me.TitleLabel.Name = "TitleLabel"
        Me.TitleLabel.Size = New System.Drawing.Size(108, 16)
        Me.TitleLabel.TabIndex = 0
        Me.TitleLabel.Text = "BMI Calculator"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.WeightUnitLabel)
        Me.GroupBox1.Controls.Add(Me.HeightUnitLabel)
        Me.GroupBox1.Controls.Add(Me.WeightTextBox)
        Me.GroupBox1.Controls.Add(Me.HeightTextBox)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 74)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(452, 116)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.MetricRadioButton)
        Me.GroupBox2.Controls.Add(Me.ImperialRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(18, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(125, 91)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Choose System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "&Weight"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(199, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "&Height"
        '
        'ImperialRadioButton
        '
        Me.ImperialRadioButton.AutoCheck = False
        Me.ImperialRadioButton.AutoSize = True
        Me.ImperialRadioButton.Location = New System.Drawing.Point(19, 29)
        Me.ImperialRadioButton.Name = "ImperialRadioButton"
        Me.ImperialRadioButton.Size = New System.Drawing.Size(61, 17)
        Me.ImperialRadioButton.TabIndex = 2
        Me.ImperialRadioButton.Text = "&Imperial"
        Me.ImperialRadioButton.UseVisualStyleBackColor = True
        '
        'MetricRadioButton
        '
        Me.MetricRadioButton.AutoCheck = False
        Me.MetricRadioButton.AutoSize = True
        Me.MetricRadioButton.Location = New System.Drawing.Point(19, 68)
        Me.MetricRadioButton.Name = "MetricRadioButton"
        Me.MetricRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.MetricRadioButton.TabIndex = 3
        Me.MetricRadioButton.Text = "&Metric"
        Me.MetricRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ResultTextBox)
        Me.GroupBox3.Controls.Add(Me.BMITextBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Location = New System.Drawing.Point(43, 229)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(452, 100)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Output"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(34, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Body Mass Index"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(85, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Result"
        '
        'BMITextBox
        '
        Me.BMITextBox.Location = New System.Drawing.Point(155, 31)
        Me.BMITextBox.Name = "BMITextBox"
        Me.BMITextBox.Size = New System.Drawing.Size(100, 20)
        Me.BMITextBox.TabIndex = 2
        '
        'ResultTextBox
        '
        Me.ResultTextBox.Location = New System.Drawing.Point(155, 63)
        Me.ResultTextBox.Name = "ResultTextBox"
        Me.ResultTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ResultTextBox.TabIndex = 3
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(43, 355)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(75, 23)
        Me.CalculateButton.TabIndex = 4
        Me.CalculateButton.Text = "&Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(198, 355)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(75, 23)
        Me.ClearButton.TabIndex = 5
        Me.ClearButton.Text = "C&lear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(344, 355)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 402)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Satish Birajdar"
        '
        'HeightTextBox
        '
        Me.HeightTextBox.Location = New System.Drawing.Point(264, 84)
        Me.HeightTextBox.Name = "HeightTextBox"
        Me.HeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.HeightTextBox.TabIndex = 2
        '
        'WeightTextBox
        '
        Me.WeightTextBox.Location = New System.Drawing.Point(264, 47)
        Me.WeightTextBox.Name = "WeightTextBox"
        Me.WeightTextBox.Size = New System.Drawing.Size(100, 20)
        Me.WeightTextBox.TabIndex = 3
        '
        'WeightUnitLabel
        '
        Me.WeightUnitLabel.AutoSize = True
        Me.WeightUnitLabel.Location = New System.Drawing.Point(386, 50)
        Me.WeightUnitLabel.Name = "WeightUnitLabel"
        Me.WeightUnitLabel.Size = New System.Drawing.Size(0, 13)
        Me.WeightUnitLabel.TabIndex = 4
        '
        'HeightUnitLabel
        '
        Me.HeightUnitLabel.AutoSize = True
        Me.HeightUnitLabel.Location = New System.Drawing.Point(386, 89)
        Me.HeightUnitLabel.Name = "HeightUnitLabel"
        Me.HeightUnitLabel.Size = New System.Drawing.Size(0, 13)
        Me.HeightUnitLabel.TabIndex = 5
        '
        'BMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(527, 438)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TitleLabel)
        Me.MaximizeBox = False
        Me.Name = "BMI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BMI Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TitleLabel As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents WeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents HeightTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MetricRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ImperialRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents ResultTextBox As System.Windows.Forms.TextBox
    Friend WithEvents BMITextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents ExitButton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents WeightUnitLabel As System.Windows.Forms.Label
    Friend WithEvents HeightUnitLabel As System.Windows.Forms.Label

End Class
