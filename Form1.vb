Public Class Form1

    Public Shared strcProgramName As String =
        "Python.exe"
    Public Shared strcFilePath As String =
        "C:\CDNSP\CDNSP.py"

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim titleid As String
        Dim ticketid As String
        Dim dlUpVer As String
        Dim dblProgTaskID As Double
        Dim strPathName As String
        titleid = TextBox1.Text
        ticketid = TextBox2.Text
        dlUpVer = TextBox3.Text

        If TextBox2.Text = "" Then
            strPathName = strcProgramName & " " & strcFilePath & " " & "-r -g" & " " & titleid & "-" & dlUpVer
        Else
            strPathName = strcProgramName & " " & strcFilePath & " " & "-r -g" & " " & titleid & "-" & dlUpVer & "-" & ticketid
        End If
        dblProgTaskID = Shell(strPathName, vbMaximizedFocus)

        '''MsgBox(strPathName, vbMaximizedFocus)'''

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim titleid As String
        titleid = TextBox1.Text
        Dim url As String = "http://switchbrew.org/index.php?search=" & titleid
        System.Diagnostics.Process.Start(url)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:\Program Files\Python37\Python.exe") Then

        End If



    End Sub

    Private Sub UpVerComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim titleid As String
        titleid = TextBox1.Text
        Dim url As String = "https://track8.mixtape.moe/zesket.html" & titleid
        System.Diagnostics.Process.Start(url)
    End Sub
End Class
