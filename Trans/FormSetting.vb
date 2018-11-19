Public Class FormSetting
    Private Sub Setting_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextAppid.Text = My.Settings.appid
        TextKey.Text = My.Settings.key
        CheckBoxSetTop.Checked = My.Settings.setTop
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Settings.appid = TextAppid.Text
        My.Settings.key = TextKey.Text
        My.Settings.setTop = CheckBoxSetTop.Checked
        My.Settings.Save()
        Form.TopMost = CheckBoxSetTop.Checked
        Me.Dispose()
    End Sub
    Private Sub FormSetting_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form.TopMost = CheckBoxSetTop.Checked
    End Sub
End Class