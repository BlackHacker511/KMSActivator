Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RunCommandCom("slmgr", "/ipk W269N-WFGWX-YVC9B-4J6C9-T83GX", False) = True) Then
            If (RunCommandCom("slmgr", "/skms kms.digiboy.ir", False) = True) Then
                If (RunCommandCom("slmgr", "/ato", False) = True) Then
                    MsgBox("Windows Activated")
                Else
                    MsgBox("Activation Failled")
                End If
            Else
                MsgBox("Activation Failled")
            End If
        Else
            MsgBox("Activation Failled")
        End If
    End Sub

    Public Function RunCommandCom(command As String, arguments As String, permanent As Boolean) As Boolean
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        pi.WindowStyle = ProcessWindowStyle.Hidden
        p.Start()

        p.WaitForExit()

        If (p.ExitCode = 0) Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
