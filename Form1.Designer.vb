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
        Me.picBuilding = New System.Windows.Forms.PictureBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblEnterValue = New System.Windows.Forms.Label()
        Me.txtEnterValue = New System.Windows.Forms.TextBox()
        Me.grpConversion = New System.Windows.Forms.GroupBox()
        Me.radInchesToMeters = New System.Windows.Forms.RadioButton()
        Me.radMetersToInches = New System.Windows.Forms.RadioButton()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblConversion = New System.Windows.Forms.Label()
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpConversion.SuspendLayout()
        Me.SuspendLayout()
        '
        'picBuilding
        '
        Me.picBuilding.BackgroundImage = Global.GuiMidterm.My.Resources.Resources.building
        Me.picBuilding.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picBuilding.Location = New System.Drawing.Point(0, 0)
        Me.picBuilding.Name = "picBuilding"
        Me.picBuilding.Size = New System.Drawing.Size(331, 264)
        Me.picBuilding.TabIndex = 0
        Me.picBuilding.TabStop = False
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(351, 30)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(310, 44)
        Me.lblHeader.TabIndex = 1
        Me.lblHeader.Text = "Converter App"
        '
        'lblEnterValue
        '
        Me.lblEnterValue.AutoSize = True
        Me.lblEnterValue.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold)
        Me.lblEnterValue.Location = New System.Drawing.Point(354, 87)
        Me.lblEnterValue.Name = "lblEnterValue"
        Me.lblEnterValue.Size = New System.Drawing.Size(243, 52)
        Me.lblEnterValue.TabIndex = 2
        Me.lblEnterValue.Text = "Enter a value and" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "choose conversion"
        '
        'txtEnterValue
        '
        Me.txtEnterValue.BackColor = System.Drawing.Color.Navy
        Me.txtEnterValue.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnterValue.ForeColor = System.Drawing.Color.White
        Me.txtEnterValue.Location = New System.Drawing.Point(624, 98)
        Me.txtEnterValue.Name = "txtEnterValue"
        Me.txtEnterValue.Size = New System.Drawing.Size(138, 32)
        Me.txtEnterValue.TabIndex = 3
        Me.txtEnterValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'grpConversion
        '
        Me.grpConversion.BackColor = System.Drawing.Color.Navy
        Me.grpConversion.Controls.Add(Me.radMetersToInches)
        Me.grpConversion.Controls.Add(Me.radInchesToMeters)
        Me.grpConversion.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpConversion.ForeColor = System.Drawing.Color.White
        Me.grpConversion.Location = New System.Drawing.Point(359, 158)
        Me.grpConversion.Name = "grpConversion"
        Me.grpConversion.Size = New System.Drawing.Size(403, 151)
        Me.grpConversion.TabIndex = 4
        Me.grpConversion.TabStop = False
        Me.grpConversion.Text = "Convert Measurement"
        '
        'radInchesToMeters
        '
        Me.radInchesToMeters.AutoSize = True
        Me.radInchesToMeters.Checked = True
        Me.radInchesToMeters.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radInchesToMeters.Location = New System.Drawing.Point(17, 45)
        Me.radInchesToMeters.Name = "radInchesToMeters"
        Me.radInchesToMeters.Size = New System.Drawing.Size(222, 30)
        Me.radInchesToMeters.TabIndex = 0
        Me.radInchesToMeters.TabStop = True
        Me.radInchesToMeters.Text = "Inches to Meters"
        Me.radInchesToMeters.UseVisualStyleBackColor = True
        '
        'radMetersToInches
        '
        Me.radMetersToInches.AutoSize = True
        Me.radMetersToInches.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radMetersToInches.Location = New System.Drawing.Point(17, 84)
        Me.radMetersToInches.Name = "radMetersToInches"
        Me.radMetersToInches.Size = New System.Drawing.Size(222, 30)
        Me.radMetersToInches.TabIndex = 1
        Me.radMetersToInches.TabStop = True
        Me.radMetersToInches.Text = "Meters to Inches"
        Me.radMetersToInches.UseVisualStyleBackColor = True
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnConvert.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(24, 383)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(215, 55)
        Me.btnConvert.TabIndex = 5
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(293, 383)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(215, 55)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(562, 383)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(215, 55)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'lblConversion
        '
        Me.lblConversion.AutoSize = True
        Me.lblConversion.Font = New System.Drawing.Font("Verdana", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConversion.Location = New System.Drawing.Point(353, 333)
        Me.lblConversion.Name = "lblConversion"
        Me.lblConversion.Size = New System.Drawing.Size(95, 26)
        Me.lblConversion.TabIndex = 8
        Me.lblConversion.Text = "Label1"
        Me.lblConversion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblConversion.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblConversion)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.grpConversion)
        Me.Controls.Add(Me.txtEnterValue)
        Me.Controls.Add(Me.lblEnterValue)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.picBuilding)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        CType(Me.picBuilding, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpConversion.ResumeLayout(False)
        Me.grpConversion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picBuilding As PictureBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblEnterValue As Label
    Friend WithEvents txtEnterValue As TextBox
    Friend WithEvents grpConversion As GroupBox
    Friend WithEvents radMetersToInches As RadioButton
    Friend WithEvents radInchesToMeters As RadioButton
    Friend WithEvents btnConvert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblConversion As Label
End Class
