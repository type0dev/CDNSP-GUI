Public Class Form1

    Public Shared strcProgramName As String =
        "Python.exe"
    Public Shared strcFilePath As String =
        "CDNSP.py"
    Public Shared dlUpVer As String =
        "0"

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
       

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim titleid As String
        titleid = TextBox1.Text
        Dim url As String = "http://switchbrew.org/index.php?search=" & titleid
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBox1.Items.Add("0")
        ComboBox1.Items.Add("1")
        ComboBox1.Items.Add("65536")
        ComboBox1.Items.Add("131072")
        ComboBox1.Items.Add("196608")
        ComboBox1.Items.Add("262144")
        ComboBox1.Items.Add("327680")
        ComboBox1.Items.Add("393216")
        ComboBox1.Items.Add("458752")
        ComboBox1.Items.Add("524288")
        ComboBox1.Items.Add("589824")
        ComboBox1.Items.Add("655360")
        ComboBox1.Items.Add("720896")
        ComboBox1.Items.Add("786432")
        ComboBox1.Items.Add("854968")
        ComboBox1.Items.Add("917504")
        ComboBox1.Items.Add("983040")
        ComboBox1.Items.Add("1048576")

    End Sub

    Private Sub UpVerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim titleid As String
        titleid = TextBox1.Text
        Dim url As String = "https://track8.mixtape.moe/zesket.html" & titleid
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim titleid As String
        Dim ticketid As String
        Dim dblProgTaskID As Double
        Dim strPathName As String
        titleid = TextBox1.Text
        ticketid = TextBox2.Text



        If TextBox2.Text = "" Then
            strPathName = strcProgramName & " " & strcFilePath & " " & "-r -g" & " " & titleid & "-" & dlUpVer
        Else
            strPathName = strcProgramName & " " & strcFilePath & " " & "-r -g" & " " & titleid & "-" & dlUpVer & "-" & ticketid
        End If
        dblProgTaskID = Shell(strPathName, vbMaximizedFocus)


        MsgBox(strPathName, MsgBoxStyle.Information)
    End Sub

    Public Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        dlUpVer = ComboBox1.SelectedItem.ToString()
    End Sub
End Class
