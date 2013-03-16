'Name - Satish Birajdar
'Date - 10/15/2012
'Purpose - BMI Calculator will calculate your Body Mass Index depending on height and weight. The input may be in Imperial or Metric format.  

Option Strict On
Option Explicit On




Public Class BMI
    'Declare CONSTANTS
    Const rangebound1 As Decimal = 18.5D
    Const rangebound2 As Decimal = 25D
    Const impconstant As Decimal = 703D

    Private Sub BMI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'default window

        ImperialRadioButton.AutoCheck = True
        MetricRadioButton.AutoCheck = True
        WeightTextBox.Enabled = False
        HeightTextBox.Enabled = False
        BMITextBox.Enabled = False
        ResultTextBox.Enabled = False


    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        'exit the window 
        Me.Close()

    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        Dim WeightDecimal, HeightDecimal, BMIDecimal As Decimal

        If (MetricRadioButton.Checked = True Or ImperialRadioButton.Checked = True) Then                'check whether radiobutton are checked 

            If (MetricRadioButton.Checked = True) Then                                      'check metric radio button is checked



                If (WeightTextBox.Text <> "" Or HeightTextBox.Text <> "") Then              'chech whether HeightTextBox and weightTextBox are filled
                    Try

                        WeightDecimal = Decimal.Parse(WeightTextBox.Text)                   'assign variable to the textbox
                        HeightDecimal = Decimal.Parse(HeightTextBox.Text)                   'assign variable to the textbox
                        If (WeightDecimal > 0) Then                                         'check for positive weight value
                            If (HeightDecimal > 0) Then                                     'check for positive weight value

                                BMIDecimal = (WeightDecimal) / (HeightDecimal * HeightDecimal)                  'logic for metric calculations
                                BMITextBox.Text = BMIDecimal.ToString("f")
                                If (BMIDecimal < rangebound1) Then                                              'logic for BMI scale
                                    ResultTextBox.Text = "Underweight"
                                ElseIf (BMIDecimal > rangebound1 And BMIDecimal < rangebound2) Then
                                    ResultTextBox.Text = "Normal"
                                Else
                                    ResultTextBox.Text = "Overweight"
                                End If

                            Else

                                MessageBox.Show("Height value MUST be a positive number greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                With WeightTextBox
                                    .SelectAll()
                                    .Focus()
                                End With
                            End If

                        Else
                            MessageBox.Show("Weight value MUST be a positive number greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            With HeightTextBox
                                .SelectAll()
                                .Focus()
                            End With
                        End If

                    Catch QuantityFormatException As FormatException
                        MessageBox.Show("Quantity MUST be a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Catch QuantityOverflowException As OverflowException
                        MessageBox.Show("Quantity value is out of limits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Catch AnException As Exception
                        MessageBox.Show("Error:" & AnException.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                    End Try
                Else
                    MessageBox.Show("Please input a positive values of weight and height. CANNOT leave it blank",
                                   "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    WeightTextBox.Focus()
                End If





            ElseIf (ImperialRadioButton.Checked = True) Then                                'check whether imperial radiobutton is checked


                If (WeightTextBox.Text <> "" Or HeightTextBox.Text <> "") Then              'chech whether HeightTextBox and weightTextBox are filled
                    Try

                        WeightDecimal = Decimal.Parse(WeightTextBox.Text)                   'assign variable to the textbox
                        HeightDecimal = Decimal.Parse(HeightTextBox.Text)                   'assign variable to the textbox
                        If (WeightDecimal > 0) Then                                         'check for positive weight value
                            If (HeightDecimal > 0) Then                                     'check for positive weight value

                                BMIDecimal = (WeightDecimal * impconstant) / (HeightDecimal * HeightDecimal)            'logic for Imperial calculations
                                BMITextBox.Text = BMIDecimal.ToString("f")
                                If (BMIDecimal < rangebound1) Then                                      'logic for BMI Scale calculations
                                    ResultTextBox.Text = "Underweight"
                                ElseIf (BMIDecimal > rangebound1 And BMIDecimal < rangebound2) Then
                                    ResultTextBox.Text = "Normal"
                                Else
                                    ResultTextBox.Text = "Overweight"
                                End If

                            Else

                                MessageBox.Show("Height value MUST be a positive number greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                                With WeightTextBox
                                    .SelectAll()
                                    .Focus()
                                End With
                            End If

                        Else
                            MessageBox.Show("Weight value MUST be a positive number greater than 0", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            With HeightTextBox
                                .SelectAll()
                                .Focus()
                            End With
                        End If

                    Catch QuantityFormatException As FormatException
                        MessageBox.Show("Quantity MUST be a numeric value", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Catch QuantityOverflowException As OverflowException
                        MessageBox.Show("Quantity value is out of limits", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    Catch AnException As Exception
                        MessageBox.Show("Error:" & AnException.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)



                    End Try
                End If

            Else
                MessageBox.Show("Please input a positive values of weight and height. CANNOT leave it blank",
                               "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                WeightTextBox.Focus()


            End If

        Else
            MessageBox.Show("Please choose one of the System ...!!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)   'show this message if no input is entered
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub ImperialRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ImperialRadioButton.CheckedChanged

        'Events that are undergone when Imperial Radio button is checked
        WeightUnitLabel.Text = "pounds"
        HeightUnitLabel.Text = "inches"
        WeightTextBox.Enabled = True
        HeightTextBox.Enabled = True
    End Sub

    Private Sub MetricRadioButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetricRadioButton.CheckedChanged
        'Events that are undergone when Metric Radio button is checked

        WeightUnitLabel.Text = "kilograms"
        HeightUnitLabel.Text = "meters"
        WeightTextBox.Enabled = True
        HeightTextBox.Enabled = True
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Events that are undergone when Clear button is clicked


        WeightTextBox.Text = ""
        HeightTextBox.Text = ""
        WeightUnitLabel.Text = ""
        HeightUnitLabel.Text = ""
        BMITextBox.Text = ""
        ResultTextBox.Text = ""
        MetricRadioButton.Checked = False
        ImperialRadioButton.Checked = False
        WeightTextBox.Enabled = False
        HeightTextBox.Enabled = False
    End Sub
End Class
