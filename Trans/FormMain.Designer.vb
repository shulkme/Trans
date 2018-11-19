<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextTo = New System.Windows.Forms.TextBox()
        Me.BtnClrFrom = New System.Windows.Forms.Button()
        Me.BtnPaste = New System.Windows.Forms.Button()
        Me.BtnTrans = New System.Windows.Forms.Button()
        Me.BtnClrTo = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.BtnHistory = New System.Windows.Forms.Button()
        Me.ComboFrom = New System.Windows.Forms.ComboBox()
        Me.ComboTo = New System.Windows.Forms.ComboBox()
        Me.LabStatus = New System.Windows.Forms.Label()
        Me.LabSetting = New System.Windows.Forms.Label()
        Me.TimerRequest = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "原文："
        '
        'TextFrom
        '
        Me.TextFrom.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextFrom.Location = New System.Drawing.Point(7, 27)
        Me.TextFrom.Multiline = True
        Me.TextFrom.Name = "TextFrom"
        Me.TextFrom.Size = New System.Drawing.Size(225, 75)
        Me.TextFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 144)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 12)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "译文："
        '
        'TextTo
        '
        Me.TextTo.Font = New System.Drawing.Font("宋体", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.TextTo.Location = New System.Drawing.Point(7, 162)
        Me.TextTo.Multiline = True
        Me.TextTo.Name = "TextTo"
        Me.TextTo.Size = New System.Drawing.Size(225, 75)
        Me.TextTo.TabIndex = 3
        '
        'BtnClrFrom
        '
        Me.BtnClrFrom.Location = New System.Drawing.Point(7, 109)
        Me.BtnClrFrom.Name = "BtnClrFrom"
        Me.BtnClrFrom.Size = New System.Drawing.Size(70, 25)
        Me.BtnClrFrom.TabIndex = 4
        Me.BtnClrFrom.Text = "清空"
        Me.BtnClrFrom.UseVisualStyleBackColor = True
        '
        'BtnPaste
        '
        Me.BtnPaste.Location = New System.Drawing.Point(85, 109)
        Me.BtnPaste.Name = "BtnPaste"
        Me.BtnPaste.Size = New System.Drawing.Size(70, 25)
        Me.BtnPaste.TabIndex = 5
        Me.BtnPaste.Text = "粘贴"
        Me.BtnPaste.UseVisualStyleBackColor = True
        '
        'BtnTrans
        '
        Me.BtnTrans.Enabled = False
        Me.BtnTrans.Location = New System.Drawing.Point(162, 109)
        Me.BtnTrans.Name = "BtnTrans"
        Me.BtnTrans.Size = New System.Drawing.Size(70, 25)
        Me.BtnTrans.TabIndex = 6
        Me.BtnTrans.Text = "翻译"
        Me.BtnTrans.UseVisualStyleBackColor = True
        '
        'BtnClrTo
        '
        Me.BtnClrTo.Location = New System.Drawing.Point(7, 243)
        Me.BtnClrTo.Name = "BtnClrTo"
        Me.BtnClrTo.Size = New System.Drawing.Size(70, 25)
        Me.BtnClrTo.TabIndex = 7
        Me.BtnClrTo.Text = "清空"
        Me.BtnClrTo.UseVisualStyleBackColor = True
        '
        'BtnCopy
        '
        Me.BtnCopy.Location = New System.Drawing.Point(162, 243)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(70, 25)
        Me.BtnCopy.TabIndex = 8
        Me.BtnCopy.Text = "拷贝"
        Me.BtnCopy.UseVisualStyleBackColor = True
        '
        'BtnHistory
        '
        Me.BtnHistory.Location = New System.Drawing.Point(86, 243)
        Me.BtnHistory.Name = "BtnHistory"
        Me.BtnHistory.Size = New System.Drawing.Size(70, 25)
        Me.BtnHistory.TabIndex = 9
        Me.BtnHistory.Text = "历史"
        Me.BtnHistory.UseVisualStyleBackColor = True
        '
        'ComboFrom
        '
        Me.ComboFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboFrom.FormattingEnabled = True
        Me.ComboFrom.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.ComboFrom.ItemHeight = 12
        Me.ComboFrom.Location = New System.Drawing.Point(152, 5)
        Me.ComboFrom.Name = "ComboFrom"
        Me.ComboFrom.Size = New System.Drawing.Size(80, 20)
        Me.ComboFrom.TabIndex = 10
        '
        'ComboTo
        '
        Me.ComboTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTo.FormattingEnabled = True
        Me.ComboTo.Location = New System.Drawing.Point(152, 140)
        Me.ComboTo.Name = "ComboTo"
        Me.ComboTo.Size = New System.Drawing.Size(80, 20)
        Me.ComboTo.TabIndex = 11
        '
        'LabStatus
        '
        Me.LabStatus.AutoSize = True
        Me.LabStatus.Location = New System.Drawing.Point(5, 280)
        Me.LabStatus.Name = "LabStatus"
        Me.LabStatus.Size = New System.Drawing.Size(53, 12)
        Me.LabStatus.TabIndex = 12
        Me.LabStatus.Text = "状态正常"
        '
        'LabSetting
        '
        Me.LabSetting.AutoSize = True
        Me.LabSetting.ForeColor = System.Drawing.Color.Blue
        Me.LabSetting.Location = New System.Drawing.Point(203, 280)
        Me.LabSetting.Name = "LabSetting"
        Me.LabSetting.Size = New System.Drawing.Size(29, 12)
        Me.LabSetting.TabIndex = 13
        Me.LabSetting.Text = "设置"
        '
        'TimerRequest
        '
        Me.TimerRequest.Interval = 1
        '
        'Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(238, 299)
        Me.Controls.Add(Me.LabSetting)
        Me.Controls.Add(Me.LabStatus)
        Me.Controls.Add(Me.ComboTo)
        Me.Controls.Add(Me.ComboFrom)
        Me.Controls.Add(Me.BtnHistory)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.BtnClrTo)
        Me.Controls.Add(Me.BtnTrans)
        Me.Controls.Add(Me.BtnPaste)
        Me.Controls.Add(Me.BtnClrFrom)
        Me.Controls.Add(Me.TextTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextFrom)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trans"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextFrom As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextTo As TextBox
    Friend WithEvents BtnClrFrom As Button
    Friend WithEvents BtnPaste As Button
    Friend WithEvents BtnTrans As Button
    Friend WithEvents BtnClrTo As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents BtnHistory As Button
    Friend WithEvents ComboFrom As ComboBox
    Friend WithEvents ComboTo As ComboBox
    Friend WithEvents LabStatus As Label
    Friend WithEvents LabSetting As Label
    Friend WithEvents TimerRequest As Timer
End Class
