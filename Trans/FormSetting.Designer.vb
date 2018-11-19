<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetting
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSetting))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextAppid = New System.Windows.Forms.TextBox()
        Me.TextKey = New System.Windows.Forms.TextBox()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.CheckBoxSetTop = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "AppId:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Key:"
        '
        'TextAppid
        '
        Me.TextAppid.Location = New System.Drawing.Point(7, 24)
        Me.TextAppid.Name = "TextAppid"
        Me.TextAppid.Size = New System.Drawing.Size(267, 21)
        Me.TextAppid.TabIndex = 2
        '
        'TextKey
        '
        Me.TextKey.Location = New System.Drawing.Point(7, 66)
        Me.TextKey.Name = "TextKey"
        Me.TextKey.Size = New System.Drawing.Size(267, 21)
        Me.TextKey.TabIndex = 3
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(204, 93)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(70, 25)
        Me.BtnSave.TabIndex = 4
        Me.BtnSave.Text = "保存"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'CheckBoxSetTop
        '
        Me.CheckBoxSetTop.AutoSize = True
        Me.CheckBoxSetTop.Location = New System.Drawing.Point(7, 97)
        Me.CheckBoxSetTop.Name = "CheckBoxSetTop"
        Me.CheckBoxSetTop.Size = New System.Drawing.Size(72, 16)
        Me.CheckBoxSetTop.TabIndex = 5
        Me.CheckBoxSetTop.Text = "窗口置顶"
        Me.CheckBoxSetTop.UseVisualStyleBackColor = True
        '
        'FormSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(281, 125)
        Me.Controls.Add(Me.CheckBoxSetTop)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.TextKey)
        Me.Controls.Add(Me.TextAppid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Setting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextAppid As TextBox
    Friend WithEvents TextKey As TextBox
    Friend WithEvents BtnSave As Button
    Friend WithEvents CheckBoxSetTop As CheckBox
End Class
