<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.btnSave = New CardEditor.NSButton()
        Me.cbDebug = New CardEditor.NSCheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbLang = New CardEditor.NSComboBox()
        Me.NsTheme1 = New CardEditor.NSTheme()
        Me.NsControlButton1 = New CardEditor.NSControlButton()
        Me.NsTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSave.Location = New System.Drawing.Point(237, 102)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 24)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        '
        'cbDebug
        '
        Me.cbDebug.Checked = False
        Me.cbDebug.Location = New System.Drawing.Point(134, 66)
        Me.cbDebug.Name = "cbDebug"
        Me.cbDebug.Size = New System.Drawing.Size(97, 24)
        Me.cbDebug.TabIndex = 8
        Me.cbDebug.Text = "Debug Mode"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(17, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(111, 15)
        Me.Label21.TabIndex = 53
        Me.Label21.Text = "Launcher Language"
        '
        'cmbLang
        '
        Me.cmbLang.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.cmbLang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.cmbLang.FormattingEnabled = True
        Me.cmbLang.Items.AddRange(New Object() {"English", "Chinese", "French"})
        Me.cmbLang.Location = New System.Drawing.Point(134, 36)
        Me.cmbLang.Name = "cmbLang"
        Me.cmbLang.Size = New System.Drawing.Size(170, 24)
        Me.cmbLang.TabIndex = 5
        '
        'NsTheme1
        '
        Me.NsTheme1.AccentOffset = 42
        Me.NsTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.NsTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.NsTheme1.Colors = New CardEditor.Bloom(-1) {}
        Me.NsTheme1.Controls.Add(Me.NsControlButton1)
        Me.NsTheme1.Controls.Add(Me.btnSave)
        Me.NsTheme1.Controls.Add(Me.Label21)
        Me.NsTheme1.Controls.Add(Me.cbDebug)
        Me.NsTheme1.Controls.Add(Me.cmbLang)
        Me.NsTheme1.Customization = ""
        Me.NsTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NsTheme1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.NsTheme1.Image = Nothing
        Me.NsTheme1.Location = New System.Drawing.Point(0, 0)
        Me.NsTheme1.Movable = True
        Me.NsTheme1.Name = "NsTheme1"
        Me.NsTheme1.NoRounding = False
        Me.NsTheme1.Padding = New System.Windows.Forms.Padding(3, 33, 3, 3)
        Me.NsTheme1.Sizable = False
        Me.NsTheme1.Size = New System.Drawing.Size(327, 140)
        Me.NsTheme1.SmartBounds = True
        Me.NsTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.NsTheme1.TabIndex = 61
        Me.NsTheme1.Text = "Settings"
        Me.NsTheme1.TransparencyKey = System.Drawing.Color.Empty
        Me.NsTheme1.Transparent = False
        '
        'NsControlButton1
        '
        Me.NsControlButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NsControlButton1.ControlButton = CardEditor.NSControlButton.Button.Close
        Me.NsControlButton1.Location = New System.Drawing.Point(304, 3)
        Me.NsControlButton1.Margin = New System.Windows.Forms.Padding(0)
        Me.NsControlButton1.MaximumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.MinimumSize = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.Name = "NsControlButton1"
        Me.NsControlButton1.Size = New System.Drawing.Size(18, 20)
        Me.NsControlButton1.TabIndex = 66
        Me.NsControlButton1.Text = "NsControlButton1"
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 140)
        Me.Controls.Add(Me.NsTheme1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.NsTheme1.ResumeLayout(False)
        Me.NsTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As NSButton
    Friend WithEvents cbDebug As NSCheckBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label21 As Label
    Friend WithEvents cmbLang As NSComboBox
    Friend WithEvents NsTheme1 As NSTheme
    Friend WithEvents NsControlButton1 As NSControlButton
End Class
