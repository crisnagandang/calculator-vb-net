Public Class Calculator
    Private totalValue As String
    Private currentValue As String
    Private currentOperator As String
    Private operatorFlagIsOn As Boolean
    'Private errorFlag As Boolean
    Private newValueFlag As Boolean
    Private equalsFlagIsOn As Boolean


    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResetValues()
        DisplayValue()
    End Sub

    Private Sub ResetValues()
        totalValue = 0
        currentValue = ""
        currentOperator = ""
        operatorFlagIsOn = False
        newValueFlag = False
        'errorFlag = False
        equalsFlagIsOn = False
    End Sub

    Private Sub InputController(ByVal input As String, Optional type As String = "value")
        'If errorFlag = True Then
        ' ResetValues()
        'End If

        If type = "operator" Then
            ProcessOperatorLogic(input)
        ElseIf type = "function" Then
            ProcessFunctionLogic(input)
        ElseIf type = "value" Then
            TurnOperatorFlagOff()
            SetCurrentValue(input)
        End If

        DisplayValue()
    End Sub
    Private Sub ProcessOperatorLogic(input As String)
        If Not operatorFlagIsOn Then
            'If Equals was previously clicked, turn it off
            If equalsFlagIsOn Then
                TurnEqualsFlagOff()
            Else
                DoComputation()
            End If

            TurnOperatorFlagOn()
            newValueFlag = True
        End If

        currentOperator = input
    End Sub

    Private Sub TurnOperatorFlagOff()
        operatorFlagIsOn = False
    End Sub
    Private Sub TurnOperatorFlagOn()
        operatorFlagIsOn = True
    End Sub
    Private Sub TurnEqualsFlagOff()
        equalsFlagIsOn = False
    End Sub
    Private Sub TurnEqualsFlagOn()
        equalsFlagIsOn = True
    End Sub
    Private Sub ProcessFunctionLogic(input As String)
        If input = "AC" Then
            ResetValues()
        ElseIf input = "DEL" And (currentValue.Length > 1) Then
            currentValue = currentValue.Substring(0, currentValue.Length - 1)
        ElseIf input = "Sqrt" Then
            currentValue = Math.Sqrt(currentValue)
        ElseIf input = "Percentage" Then
            currentValue = (currentValue / 100)
        Else
            currentValue = "0"
        End If
    End Sub
    Private Sub SetCurrentValue(input As String)
        'Check if the current value has dot
        Dim result = currentValue.IndexOf(".")

        'If dot is already visible in the current option, do nothing
        If result > 0 And input = "." And Not newValueFlag Then
            Exit Sub
        End If

        'Set new value
        If newValueFlag And input = "." Then
            currentValue = "0."
            newValueFlag = False
        ElseIf newValueFlag Then
            currentValue = input
            newValueFlag = False
            'Convert to remove the leading zero
            currentValue = Double.Parse(currentValue)
        ElseIf input = "." And currentValue.Length < 2 Then
            currentValue = "0."
        ElseIf input = "." Then
            currentValue = String.Concat(currentValue + input)
        ElseIf currentValue.Length < 2 Then
            currentValue = String.Concat(currentValue + input)
            'Convert to remove the leading zero
            currentValue = Double.Parse(currentValue)
        Else
            currentValue = String.Concat(currentValue + input)
        End If
    End Sub

    Private Sub DoComputation()
        If currentOperator = "Add" Then
            totalValue = Double.Parse(totalValue) + Double.Parse(currentValue)
        ElseIf currentOperator = "Subtract" Then
            totalValue = Double.Parse(totalValue) - Double.Parse(currentValue)
        ElseIf currentOperator = "Multiply" Then
            totalValue = Double.Parse(totalValue) * Double.Parse(currentValue)
        ElseIf currentOperator = "Divide" Then
            totalValue = Double.Parse(totalValue) / Double.Parse(currentValue)
        ElseIf currentOperator = "" Then
            totalValue = currentValue
        End If

        currentValue = totalValue
        TurnOperatorFlagOff()
    End Sub

    Private Sub DisplayValue()
        If currentValue = "" Then
            tbDisplay.Text = totalValue
        Else
            tbDisplay.Text = currentValue
        End If
    End Sub

    Private Sub btnNumber_Click(sender As Object, e As EventArgs) Handles btnNumber.Click
        InputController("0")
    End Sub

    Private Sub btnNumber1_Click(sender As Object, e As EventArgs) Handles btnNumber1.Click
        InputController("1")
    End Sub

    Private Sub btnNumber2_Click(sender As Object, e As EventArgs) Handles btnNumber2.Click
        InputController("2")
    End Sub

    Private Sub btnNumber3_Click(sender As Object, e As EventArgs) Handles btnNumber3.Click
        InputController("3")
    End Sub

    Private Sub btnNumber4_Click(sender As Object, e As EventArgs) Handles btnNumber4.Click
        InputController("4")
    End Sub

    Private Sub btnNumber5_Click(sender As Object, e As EventArgs) Handles btnNumber5.Click
        InputController("5")
    End Sub

    Private Sub btnNumber6_Click(sender As Object, e As EventArgs) Handles btnNumber6.Click
        InputController("6")
    End Sub

    Private Sub btnNumber7_Click(sender As Object, e As EventArgs) Handles btnNumber7.Click
        InputController("7")
    End Sub

    Private Sub btnNumber8_Click(sender As Object, e As EventArgs) Handles btnNumber8.Click
        InputController("8")
    End Sub

    Private Sub btnNumber9_Click(sender As Object, e As EventArgs) Handles btnNumber9.Click
        InputController("9")
    End Sub
    Private Sub btnDoubleZero_Click(sender As Object, e As EventArgs) Handles btnDoubleZero.Click
        InputController("00")
    End Sub
    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        InputController(".")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        InputController("AC", "function")
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        InputController("DEL", "function")
    End Sub

    Private Sub btnPercent_Click(sender As Object, e As EventArgs) Handles btnPercent.Click
        InputController("Percentage", "function")
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        InputController("Add", "operator")
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        InputController("Subtract", "operator")
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        InputController("Sqrt", "function")
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        InputController("Multiply", "operator")
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        InputController("Divide", "operator")
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        DoComputation()
        DisplayValue()
        TurnEqualsFlagOn()
    End Sub
End Class
