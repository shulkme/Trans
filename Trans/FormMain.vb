Imports System.IO
Imports System.Net
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading

Public Class Form
    Private LanFrom = "auto"
    Private LanTo = "en"
    Private AppID As String
    Private Key As String
    Private Salt As String
    Private Query As String
    Private Sign As String
    Private Url = "http://api.fanyi.baidu.com/api/trans/vip/translate"
    Private RequestData As String
    Private ArrLanItems = New String() {"自动检测"， "中文"， "英语"， "日语"， "韩语"， "德语"， "法语"， "泰语"， "西班牙语"， "阿拉伯语"， "希腊语"， "意大利语"， "粤语"， "繁体中文"}
    Private ArrLanValue = {"auto"， "zh"， "en"， "jp"， "kor"， "de"， "fra"， "th"， "spa"， "ara"， "el"， "it"， "yue"， "cht"}
    Dim getResult As String
    Dim transJson As JObject
    Dim transResult As String
    Dim transHistory(2) As String
    Public Function MD5(ByVal StrSource As Byte(), ByVal Code As Integer) As String
        'MD5加密
        Dim str As String = ""
        Dim md5Hasher As New MD5CryptoServiceProvider()
        Dim data As Byte() = md5Hasher.ComputeHash(StrSource)
        Dim sBuilder As New StringBuilder()
        Dim i As Integer
        For i = 0 To data.Length - 1
            sBuilder.Append(data(i).ToString("x2"))
        Next i
        Select Case Code
            Case 16
                str = sBuilder.ToString().Substring(0, 16)
            Case 32
                str = sBuilder.ToString().Substring(0, 32)
        End Select
        Return str
    End Function

    Public Function UTF8Encode(ByVal Input As String) As Byte()
        'UTF-8编码
        Dim bt As Byte()
        bt = Encoding.UTF8.GetBytes(Input)
        Return bt
    End Function

    Private Sub GetData()
        '网络请求GET
        AppID = My.Settings.appid
        Key = My.Settings.key
        Query = TextFrom.Text
        Randomize() '打乱随机数
        Salt = CInt(Rnd() * 100) + 1
        Dim str = UTF8Encode(AppID & Query & Salt & Key)
        Sign = MD5(str, 32)
        '拼接请求数据
        RequestData = "q=" & Query & "&from=" & LanFrom & "&to=" & LanTo & "&appid=" & AppID & "&salt=" & Salt & "&sign=" & Sign
        Try
            Dim request As HttpWebRequest = WebRequest.Create(Url + "?" + RequestData)
            request.Method = "GET"
            Dim sr As StreamReader = New StreamReader(request.GetResponse().GetResponseStream)
            getResult = sr.ReadToEnd '获取请求数据
            transJson = CType(JsonConvert.DeserializeObject(getResult), JObject) '解析Json数据
            transResult = transJson("trans_result").Item(0)("dst").ToString
            TextTo.Text = transResult
            transHistory(0) = TextFrom.Text
            transHistory(1) = TextTo.Text
            LabStatus.Text = "成功！"
        Catch ex As Exception
            LabStatus.Text = "发生错误！"
        End Try

    End Sub
    Private Sub BtnTrans_Click(sender As Object, e As EventArgs) Handles BtnTrans.Click
        LabStatus.Text = "... ..."
        GetData() '执行翻译

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SysInit()
    End Sub
    Private Sub SysInit()
        AppID = My.Settings.appid
        Key = My.Settings.key
        '初始化源语言列表
        For i = 0 To ArrLanItems.Length - 1
            ComboFrom.Items.Add(ArrLanItems(i).ToString)
        Next
        ComboFrom.SelectedIndex = My.Settings.lanFrom '读取用户上一次使用的源语言
        LanFrom = ArrLanValue(ComboFrom.SelectedIndex)
        '初始化目标语言列表
        For i = 1 To ArrLanItems.Length - 1
            ComboTo.Items.Add(ArrLanItems(i).ToString)
        Next
        ComboTo.SelectedIndex = My.Settings.lanTo '读取用户上一次使用的目标语言
        LanTo = ArrLanValue(ComboTo.SelectedIndex + 1)
        '判断用户appid和key是否有效
        If AppID = "" Or Key = "" Then
            'LabStatus.Text = "请先配置appid和key。"
            LabSetting_Click(Nothing, Nothing)
        End If
        If My.Settings.setTop Then
            Me.TopMost = True
        End If
    End Sub

    Private Sub BtnPaste_Click(sender As Object, e As EventArgs) Handles BtnPaste.Click
        '获取剪贴板内容
        TextFrom.Text = Clipboard.GetText()
    End Sub

    Private Sub ComboFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboFrom.SelectedIndexChanged
        '设置源语言
        LanFrom = ArrLanValue(ComboFrom.SelectedIndex)
    End Sub
    Private Sub ComboTo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboTo.SelectedIndexChanged
        '设置目标语言
        LanTo = ArrLanValue(ComboTo.SelectedIndex + 1)
    End Sub
    Private Sub BtnClrFrom_Click(sender As Object, e As EventArgs) Handles BtnClrFrom.Click
        '清空原文
        TextFrom.Text = ""
    End Sub
    Private Sub BtnClrTo_Click(sender As Object, e As EventArgs) Handles BtnClrTo.Click
        '清空译文
        TextTo.Text = ""
    End Sub

    Private Sub LabSetting_Click(sender As Object, e As EventArgs) Handles LabSetting.Click
        '打开设置
        Me.TopMost = False
        FormSetting.ShowDialog()
    End Sub

    Private Sub Form_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '保留用户最后一次设置的翻译语言
        My.Settings.lanFrom = ComboFrom.SelectedIndex
        My.Settings.lanTo = ComboTo.SelectedIndex
    End Sub

    Private Sub TextFrom_TextChanged(sender As Object, e As EventArgs) Handles TextFrom.TextChanged
        If TextFrom.Text = "" Or Len(TextFrom.Text) = 0 Then
            BtnTrans.Enabled = False
        Else
            BtnTrans.Enabled = True
        End If
    End Sub

    Private Sub BtnCopy_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        '拷贝译文至剪贴板
        Clipboard.Clear() ' 清除剪贴板
        Clipboard.SetText(TextTo.Text) ' 拷贝数据到粘贴板
    End Sub

    Private Sub BtnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        '获取上一条翻译内容
        TextFrom.Text = transHistory(0)
        TextTo.Text = transHistory(1)
    End Sub
End Class
