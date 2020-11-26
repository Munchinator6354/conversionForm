<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmConversionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblConversionOptions = New System.Windows.Forms.Label()
        Me.lstConversionOptions = New System.Windows.Forms.ListBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExitProgram = New System.Windows.Forms.Button()
        Me.lblInputUnits = New System.Windows.Forms.Label()
        Me.lblEqualsSign = New System.Windows.Forms.Label()
        Me.lblOutput2 = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lstPlanetaryWeights = New System.Windows.Forms.ListBox()
        Me.lblFatPlanet = New System.Windows.Forms.Label()
        Me.picSol = New System.Windows.Forms.PictureBox()
        Me.lnkGitHub = New System.Windows.Forms.LinkLabel()
        CType(Me.picSol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(3, 4)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(241, 102)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "Ryan Isaacson / " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS115 - Fall2020" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 4 - Feet To Meters" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 5 - Hou" &
    "rs To Minutes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Lab 1 - Weight On The Moon" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Exercise 12 - Weight On The Planets"
        '
        'lblConversionOptions
        '
        Me.lblConversionOptions.AutoSize = True
        Me.lblConversionOptions.Location = New System.Drawing.Point(602, 79)
        Me.lblConversionOptions.Name = "lblConversionOptions"
        Me.lblConversionOptions.Size = New System.Drawing.Size(132, 17)
        Me.lblConversionOptions.TabIndex = 8
        Me.lblConversionOptions.Text = "Conversion Options"
        '
        'lstConversionOptions
        '
        Me.lstConversionOptions.FormattingEnabled = True
        Me.lstConversionOptions.ItemHeight = 16
        Me.lstConversionOptions.Items.AddRange(New Object() {"Feet To Meters", "Meters To Feet", "Hours To Minutes", "Minutes To Hours", "Earth Weight To Moon Weight", "Moon Weight To Earth Weight", "Earth Weight To Planetary Weights"})
        Me.lstConversionOptions.Location = New System.Drawing.Point(548, 99)
        Me.lstConversionOptions.Name = "lstConversionOptions"
        Me.lstConversionOptions.Size = New System.Drawing.Size(240, 340)
        Me.lstConversionOptions.TabIndex = 9
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Location = New System.Drawing.Point(58, 121)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(449, 17)
        Me.lblInstructions.TabIndex = 2
        Me.lblInstructions.Text = "Select a Conversion Option and Input Your Input Numeric Value Below"
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
        Me.lblOutput.Location = New System.Drawing.Point(325, 230)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(162, 17)
        Me.lblOutput.TabIndex = 6
        Me.lblOutput.Text = "Output WIll Appear Here"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(40, 352)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(145, 52)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(210, 352)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(145, 52)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExitProgram
        '
        Me.btnExitProgram.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExitProgram.Location = New System.Drawing.Point(375, 352)
        Me.btnExitProgram.Name = "btnExitProgram"
        Me.btnExitProgram.Size = New System.Drawing.Size(145, 52)
        Me.btnExitProgram.TabIndex = 14
        Me.btnExitProgram.Text = "Exit Program"
        Me.btnExitProgram.UseVisualStyleBackColor = True
        '
        'lblInputUnits
        '
        Me.lblInputUnits.AutoSize = True
        Me.lblInputUnits.Location = New System.Drawing.Point(200, 230)
        Me.lblInputUnits.Name = "lblInputUnits"
        Me.lblInputUnits.Size = New System.Drawing.Size(0, 17)
        Me.lblInputUnits.TabIndex = 4
        '
        'lblEqualsSign
        '
        Me.lblEqualsSign.AutoSize = True
        Me.lblEqualsSign.Location = New System.Drawing.Point(291, 230)
        Me.lblEqualsSign.Name = "lblEqualsSign"
        Me.lblEqualsSign.Size = New System.Drawing.Size(16, 17)
        Me.lblEqualsSign.TabIndex = 5
        Me.lblEqualsSign.Text = "="
        '
        'lblOutput2
        '
        Me.lblOutput2.AutoSize = True
        Me.lblOutput2.Location = New System.Drawing.Point(337, 257)
        Me.lblOutput2.Name = "lblOutput2"
        Me.lblOutput2.Size = New System.Drawing.Size(170, 17)
        Me.lblOutput2.TabIndex = 7
        Me.lblOutput2.Text = "Output2 WIll Appear Here"
        Me.lblOutput2.Visible = False
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Script MT Bold", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(203, 38)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(396, 39)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Super Conversion Form 9000"
        '
        'lstPlanetaryWeights
        '
        Me.lstPlanetaryWeights.FormattingEnabled = True
        Me.lstPlanetaryWeights.ItemHeight = 16
        Me.lstPlanetaryWeights.Location = New System.Drawing.Point(595, 264)
        Me.lstPlanetaryWeights.Name = "lstPlanetaryWeights"
        Me.lstPlanetaryWeights.Size = New System.Drawing.Size(152, 164)
        Me.lstPlanetaryWeights.TabIndex = 11
        Me.lstPlanetaryWeights.Visible = False
        '
        'lblFatPlanet
        '
        Me.lblFatPlanet.AutoSize = True
        Me.lblFatPlanet.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblFatPlanet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFatPlanet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblFatPlanet.Location = New System.Drawing.Point(590, 227)
        Me.lblFatPlanet.Name = "lblFatPlanet"
        Me.lblFatPlanet.Size = New System.Drawing.Size(157, 34)
        Me.lblFatPlanet.TabIndex = 10
        Me.lblFatPlanet.Text = "  How Fat You Are On  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Other Planets (Pounds)"
        Me.lblFatPlanet.Visible = False
        '
        'picSol
        '
        Me.picSol.Image = Global.conversionForm.My.Resources.Resources.Sol
        Me.picSol.Location = New System.Drawing.Point(308, 160)
        Me.picSol.Name = "picSol"
        Me.picSol.Size = New System.Drawing.Size(234, 164)
        Me.picSol.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSol.TabIndex = 15
        Me.picSol.TabStop = False
        Me.picSol.Visible = False
        '
        'lnkGitHub
        '
        Me.lnkGitHub.AutoSize = True
        Me.lnkGitHub.Location = New System.Drawing.Point(111, 4)
        Me.lnkGitHub.Name = "lnkGitHub"
        Me.lnkGitHub.Size = New System.Drawing.Size(144, 17)
        Me.lnkGitHub.TabIndex = 16
        Me.lnkGitHub.TabStop = True
        Me.lnkGitHub.Text = "Check Out My GitHub"
        '
        'frmConversionForm
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExitProgram
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lnkGitHub)
        Me.Controls.Add(Me.picSol)
        Me.Controls.Add(Me.lblFatPlanet)
        Me.Controls.Add(Me.lstPlanetaryWeights)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblOutput2)
        Me.Controls.Add(Me.lblEqualsSign)
        Me.Controls.Add(Me.lblInputUnits)
        Me.Controls.Add(Me.btnExitProgram)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lstConversionOptions)
        Me.Controls.Add(Me.lblConversionOptions)
        Me.Controls.Add(Me.lblID)
        Me.Name = "frmConversionForm"
        Me.Text = "conversionForm"
        CType(Me.picSol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblConversionOptions As Label
    Friend WithEvents lstConversionOptions As ListBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExitProgram As Button
    Friend WithEvents lblInputUnits As Label
    Friend WithEvents lblEqualsSign As Label
    Friend WithEvents lblOutput2 As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lstPlanetaryWeights As ListBox
    Friend WithEvents lblFatPlanet As Label
    Friend WithEvents picSol As PictureBox
    Friend WithEvents lnkGitHub As LinkLabel
End Class
