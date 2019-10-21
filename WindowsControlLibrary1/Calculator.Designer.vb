<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.tbDisplay = New System.Windows.Forms.TextBox()
        Me.btnNumber = New System.Windows.Forms.Button()
        Me.btnNumber1 = New System.Windows.Forms.Button()
        Me.btnNumber2 = New System.Windows.Forms.Button()
        Me.btnNumber3 = New System.Windows.Forms.Button()
        Me.btnNumber4 = New System.Windows.Forms.Button()
        Me.btnNumber5 = New System.Windows.Forms.Button()
        Me.btnNumber6 = New System.Windows.Forms.Button()
        Me.btnNumber7 = New System.Windows.Forms.Button()
        Me.btnNumber8 = New System.Windows.Forms.Button()
        Me.btnNumber9 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPercent = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnSqrt = New System.Windows.Forms.Button()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnEquals = New System.Windows.Forms.Button()
        Me.btnDoubleZero = New System.Windows.Forms.Button()
        Me.btnDot = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbDisplay
        '
        Me.tbDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbDisplay.Location = New System.Drawing.Point(29, 27)
        Me.tbDisplay.Margin = New System.Windows.Forms.Padding(4)
        Me.tbDisplay.Name = "tbDisplay"
        Me.tbDisplay.ReadOnly = True
        Me.tbDisplay.Size = New System.Drawing.Size(525, 60)
        Me.tbDisplay.TabIndex = 0
        Me.tbDisplay.TabStop = False
        Me.tbDisplay.Text = "0"
        Me.tbDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnNumber
        '
        Me.btnNumber.Location = New System.Drawing.Point(29, 331)
        Me.btnNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber.Name = "btnNumber"
        Me.btnNumber.Size = New System.Drawing.Size(244, 71)
        Me.btnNumber.TabIndex = 1
        Me.btnNumber.Text = "0"
        Me.btnNumber.UseVisualStyleBackColor = True
        '
        'btnNumber1
        '
        Me.btnNumber1.Location = New System.Drawing.Point(29, 252)
        Me.btnNumber1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber1.Name = "btnNumber1"
        Me.btnNumber1.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber1.TabIndex = 2
        Me.btnNumber1.Text = "1"
        Me.btnNumber1.UseVisualStyleBackColor = True
        '
        'btnNumber2
        '
        Me.btnNumber2.Location = New System.Drawing.Point(113, 252)
        Me.btnNumber2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber2.Name = "btnNumber2"
        Me.btnNumber2.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber2.TabIndex = 3
        Me.btnNumber2.Text = "2"
        Me.btnNumber2.UseVisualStyleBackColor = True
        '
        'btnNumber3
        '
        Me.btnNumber3.Location = New System.Drawing.Point(197, 252)
        Me.btnNumber3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber3.Name = "btnNumber3"
        Me.btnNumber3.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber3.TabIndex = 4
        Me.btnNumber3.Text = "3"
        Me.btnNumber3.UseVisualStyleBackColor = True
        '
        'btnNumber4
        '
        Me.btnNumber4.Location = New System.Drawing.Point(29, 174)
        Me.btnNumber4.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber4.Name = "btnNumber4"
        Me.btnNumber4.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber4.TabIndex = 5
        Me.btnNumber4.Text = "4"
        Me.btnNumber4.UseVisualStyleBackColor = True
        '
        'btnNumber5
        '
        Me.btnNumber5.Location = New System.Drawing.Point(113, 174)
        Me.btnNumber5.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber5.Name = "btnNumber5"
        Me.btnNumber5.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber5.TabIndex = 6
        Me.btnNumber5.Text = "5"
        Me.btnNumber5.UseVisualStyleBackColor = True
        '
        'btnNumber6
        '
        Me.btnNumber6.Location = New System.Drawing.Point(197, 174)
        Me.btnNumber6.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber6.Name = "btnNumber6"
        Me.btnNumber6.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber6.TabIndex = 7
        Me.btnNumber6.Text = "6"
        Me.btnNumber6.UseVisualStyleBackColor = True
        '
        'btnNumber7
        '
        Me.btnNumber7.Location = New System.Drawing.Point(29, 95)
        Me.btnNumber7.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber7.Name = "btnNumber7"
        Me.btnNumber7.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber7.TabIndex = 8
        Me.btnNumber7.Text = "7"
        Me.btnNumber7.UseVisualStyleBackColor = True
        '
        'btnNumber8
        '
        Me.btnNumber8.Location = New System.Drawing.Point(113, 95)
        Me.btnNumber8.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber8.Name = "btnNumber8"
        Me.btnNumber8.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber8.TabIndex = 9
        Me.btnNumber8.Text = "8"
        Me.btnNumber8.UseVisualStyleBackColor = True
        '
        'btnNumber9
        '
        Me.btnNumber9.Location = New System.Drawing.Point(197, 95)
        Me.btnNumber9.Margin = New System.Windows.Forms.Padding(4)
        Me.btnNumber9.Name = "btnNumber9"
        Me.btnNumber9.Size = New System.Drawing.Size(76, 71)
        Me.btnNumber9.TabIndex = 10
        Me.btnNumber9.Text = "9"
        Me.btnNumber9.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(312, 95)
        Me.btnReset.Margin = New System.Windows.Forms.Padding(4)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(76, 71)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "AC"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(396, 95)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(76, 71)
        Me.btnDelete.TabIndex = 12
        Me.btnDelete.Text = "DEL"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPercent
        '
        Me.btnPercent.Location = New System.Drawing.Point(480, 95)
        Me.btnPercent.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPercent.Name = "btnPercent"
        Me.btnPercent.Size = New System.Drawing.Size(76, 71)
        Me.btnPercent.TabIndex = 13
        Me.btnPercent.Text = "%"
        Me.btnPercent.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(312, 174)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(76, 71)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "+"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Location = New System.Drawing.Point(312, 253)
        Me.btnSubtract.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(76, 71)
        Me.btnSubtract.TabIndex = 17
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnSqrt
        '
        Me.btnSqrt.Location = New System.Drawing.Point(480, 174)
        Me.btnSqrt.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSqrt.Name = "btnSqrt"
        Me.btnSqrt.Size = New System.Drawing.Size(76, 71)
        Me.btnSqrt.TabIndex = 16
        Me.btnSqrt.Text = "Sqrt"
        Me.btnSqrt.UseVisualStyleBackColor = True
        '
        'btnMultiply
        '
        Me.btnMultiply.Location = New System.Drawing.Point(396, 173)
        Me.btnMultiply.Margin = New System.Windows.Forms.Padding(4)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(76, 71)
        Me.btnMultiply.TabIndex = 15
        Me.btnMultiply.Text = "*"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'btnDivide
        '
        Me.btnDivide.Location = New System.Drawing.Point(396, 252)
        Me.btnDivide.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(76, 71)
        Me.btnDivide.TabIndex = 18
        Me.btnDivide.Text = "/"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnEquals
        '
        Me.btnEquals.Location = New System.Drawing.Point(480, 252)
        Me.btnEquals.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEquals.Name = "btnEquals"
        Me.btnEquals.Size = New System.Drawing.Size(76, 150)
        Me.btnEquals.TabIndex = 19
        Me.btnEquals.Text = "="
        Me.btnEquals.UseVisualStyleBackColor = True
        '
        'btnDoubleZero
        '
        Me.btnDoubleZero.Location = New System.Drawing.Point(312, 331)
        Me.btnDoubleZero.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDoubleZero.Name = "btnDoubleZero"
        Me.btnDoubleZero.Size = New System.Drawing.Size(76, 71)
        Me.btnDoubleZero.TabIndex = 20
        Me.btnDoubleZero.Text = "00"
        Me.btnDoubleZero.UseVisualStyleBackColor = True
        '
        'btnDot
        '
        Me.btnDot.Location = New System.Drawing.Point(396, 331)
        Me.btnDot.Margin = New System.Windows.Forms.Padding(4)
        Me.btnDot.Name = "btnDot"
        Me.btnDot.Size = New System.Drawing.Size(76, 71)
        Me.btnDot.TabIndex = 21
        Me.btnDot.Text = "."
        Me.btnDot.UseVisualStyleBackColor = True
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnDot)
        Me.Controls.Add(Me.btnDoubleZero)
        Me.Controls.Add(Me.btnEquals)
        Me.Controls.Add(Me.btnDivide)
        Me.Controls.Add(Me.btnMultiply)
        Me.Controls.Add(Me.btnSqrt)
        Me.Controls.Add(Me.btnSubtract)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnPercent)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnNumber9)
        Me.Controls.Add(Me.btnNumber8)
        Me.Controls.Add(Me.btnNumber7)
        Me.Controls.Add(Me.btnNumber6)
        Me.Controls.Add(Me.btnNumber5)
        Me.Controls.Add(Me.btnNumber4)
        Me.Controls.Add(Me.btnNumber3)
        Me.Controls.Add(Me.btnNumber2)
        Me.Controls.Add(Me.btnNumber1)
        Me.Controls.Add(Me.btnNumber)
        Me.Controls.Add(Me.tbDisplay)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Calculator"
        Me.Size = New System.Drawing.Size(592, 434)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbDisplay As TextBox
    Friend WithEvents btnNumber As Button
    Friend WithEvents btnNumber1 As Button
    Friend WithEvents btnNumber2 As Button
    Friend WithEvents btnNumber3 As Button
    Friend WithEvents btnNumber4 As Button
    Friend WithEvents btnNumber5 As Button
    Friend WithEvents btnNumber6 As Button
    Friend WithEvents btnNumber7 As Button
    Friend WithEvents btnNumber8 As Button
    Friend WithEvents btnNumber9 As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnPercent As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnEquals As Button
    Friend WithEvents btnDoubleZero As Button
    Friend WithEvents btnDot As Button
End Class
