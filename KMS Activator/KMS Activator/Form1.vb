Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RunCommandCom("slmgr", "/ipk W269N-WFGWX-YVC9B-4J6C9-T83GX", False)
        Threading.Thread.Sleep(10000)
        RunCommandCom("slmgr", "/skms kms.digiboy.ir", False)
        Threading.Thread.Sleep(10000)
        RunCommandCom("slmgr", "/ato", False)
    End Sub

    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        pi.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()
    End Sub
End Class
