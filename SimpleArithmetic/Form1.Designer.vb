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
        Me.Evaluate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.variable1 = New System.Windows.Forms.TextBox()
        Me.variable2 = New System.Windows.Forms.TextBox()
        Me.useOperator = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.endEval = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Evaluate
        '
        Me.Evaluate.Location = New System.Drawing.Point(239, 223)
        Me.Evaluate.Name = "Evaluate"
        Me.Evaluate.Size = New System.Drawing.Size(129, 53)
        Me.Evaluate.TabIndex = 0
        Me.Evaluate.Text = "Evaluate"
        Me.Evaluate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Variable 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 130)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Variable 2"
        '
        'variable1
        '
        Me.variable1.Location = New System.Drawing.Point(205, 49)
        Me.variable1.Name = "variable1"
        Me.variable1.Size = New System.Drawing.Size(146, 22)
        Me.variable1.TabIndex = 3
        '
        'variable2
        '
        Me.variable2.Location = New System.Drawing.Point(205, 127)
        Me.variable2.Name = "variable2"
        Me.variable2.Size = New System.Drawing.Size(146, 22)
        Me.variable2.TabIndex = 4
        '
        'useOperator
        '
        Me.useOperator.FormattingEnabled = True
        Me.useOperator.Items.AddRange(New Object() {"Addition", "Subtraction", "Multiplication", "Division", "Exponential"})
        Me.useOperator.Location = New System.Drawing.Point(205, 91)
        Me.useOperator.Name = "useOperator"
        Me.useOperator.Size = New System.Drawing.Size(146, 24)
        Me.useOperator.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(82, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Use of Operators"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(127, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Result"
        '
        'endEval
        '
        Me.endEval.Location = New System.Drawing.Point(384, 223)
        Me.endEval.Name = "endEval"
        Me.endEval.Size = New System.Drawing.Size(129, 53)
        Me.endEval.TabIndex = 8
        Me.endEval.Text = "End"
        Me.endEval.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(205, 173)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(51, 17)
        Me.result.TabIndex = 9
        Me.result.Text = "Label5"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 316)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.endEval)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.useOperator)
        Me.Controls.Add(Me.variable2)
        Me.Controls.Add(Me.variable1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Evaluate)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Simple Arithmetic Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Evaluate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents variable1 As TextBox
    Friend WithEvents variable2 As TextBox
    Friend WithEvents useOperator As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents endEval As Button
    Friend WithEvents result As Label
End Class
