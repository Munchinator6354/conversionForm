<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversionForm
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblConversionOptions = New System.Windows.Forms.Label()
        Me.lstConversionOptions = New System.Windows.Forms.ListBox()
        Me.lblInputDescription = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.lblInputUnits = New System.Windows.Forms.Label()
        Me.lblEqualsSign = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(3, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(198, 68)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 4 - Feet To Meters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 5 - Hours " &
    "To Minutes"
        '
        'lblConversionOptions
        '
        Me.lblConversionOptions.AutoSize = True
        Me.lblConversionOptions.Location = New System.Drawing.Point(581, 79)
        Me.lblConversionOptions.Name = "lblConversionOptions"
        Me.lblConversionOptions.Size = New System.Drawing.Size(132, 17)
        Me.lblConversionOptions.TabIndex = 2
        Me.lblConversionOptions.Text = "Conversion Options"
        '
        'lstConversionOptions
        '
        Me.lstConversionOptions.FormattingEnabled = True
        Me.lstConversionOptions.ItemHeight = 16
        Me.lstConversionOptions.Items.AddRange(New Object() {"Feet To Meters", "Meters To Feet", "Hours To Minutes", "Minutes To Hours", "Earth Weight To Moon Weight", "Moon Weight To Earth Weight"})
        Me.lstConversionOptions.Location = New System.Drawing.Point(548, 112)
        Me.lstConversionOptions.Name = "lstConversionOptions"
        Me.lstConversionOptions.Size = New System.Drawing.Size(203, 292)
        Me.lstConversionOptions.TabIndex = 4
        '
        'lblInputDescription
        '
        Me.lblInputDescription.AutoSize = True
        Me.lblInputDescription.Location = New System.Drawing.Point(58, 121)
        Me.lblInputDescription.Name = "lblInputDescription"
        Me.lblInputDescription.Size = New System.Drawing.Size(449, 17)
        Me.lblInputDescription.TabIndex = 1
        Me.lblInputDescription.Text = "Select a Conversion Option and Input Your Input Numeric Value Below"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(84, 227)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(110, 22)
        Me.txtInput.TabIndex = 3
        '
        'lblOutput
        '
        Me.lblOutput.AutoSize = True
        Me.lblOutput.Location = New System.Drawing.Point(314, 230)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(162, 17)
        Me.lblOutput.TabIndex = 7
        Me.lblOutput.Text = "Output WIll Appear Here"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 352)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 52)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(210, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 52)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExitProgram
        '
        Me.btnExitProgram.Location = New System.Drawing.Point(375, 352)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(145, 52)
        Me.btnExitProgram.TabIndex = 10
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        '
        'lblInputUnits
        '
        Me.lblInputUnits.AutoSize = True
        Me.lblInputUnits.Location = New System.Drawing.Point(200, 230)
        Me.lblInputUnits.Name = "lblInputUnits"
        Me.lblInputUnits.Size = New System.Drawing.Size(0, 17)
        Me.lblInputUnits.TabIndex = 5
        '
        'lblEqualsSign
        '
        Me.lblEqualsSign.AutoSize = True
        Me.lblEqualsSign.Location = New System.Drawing.Point(276, 230)
        Me.lblEqualsSign.Name = "lblEqualsSign"
        Me.lblEqualsSign.Size = New System.Drawing.Size(16, 17)
        Me.lblEqualsSign.TabIndex = 6
        Me.lblEqualsSign.Text = "="
        '
        'frmConversionForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExitProgram
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblEqualsSign)
        Me.Controls.Add(Me.lblInputUnits)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInputDescription)
        Me.Controls.Add(Me.lstConversionOptions)
        Me.Controls.Add(Me.lblConversionOptions)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmConversionForm"
        Me.Text = "conversionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblConversionOptions As Label
    Friend WithEvents lstConversionOptions As ListBox
    Friend WithEvents lblInputDescription As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents lblInputUnits As Label
    Friend WithEvents lblEqualsSign As Label
End Class
