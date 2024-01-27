Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (RunSlmgr("/ipk W269N-WFGWX-YVC9B-4J6C9-T83GX") = True) Then
            ListBox1.Items.Add("License Installed")
            If (RunSlmgr("/skms kms.digiboy.ir") = True) Then
                If (RunSlmgr("/ato")) Then
                    ListBox1.Items.Add("Microsoft Windows Activated")
                End If
            End If
        End If
    End Sub
    Public Function RunSlmgr(ByVal cmd As String) As Boolean
        Dim pi As New ProcessStartInfo With {
        .Arguments = $"/nologo slmgr.vbs {cmd}",
        .FileName = "cscript.exe",
        .RedirectStandardOutput = True,
        .UseShellExecute = False,
        .CreateNoWindow = True,
        .WorkingDirectory = "C:\Windows\System32"
        }

        Dim p As New Process() With {.StartInfo = pi}

        p.Start()
        p.WaitForExit()

        Return (p.ExitCode = 0)
    End Function
    Public Function RunOspp(ByVal cmd As String) As Boolean
        Dim pi As New ProcessStartInfo With {
        .Arguments = $"/nologo ospp.vbs {cmd}",
        .FileName = "cscript",
        .RedirectStandardOutput = True,
        .UseShellExecute = False,
        .CreateNoWindow = True,
        .WorkingDirectory = "C:\Program Files\Microsoft Office\Office16"
        }

        Dim p As New Process() With {.StartInfo = pi}

        p.Start()
        p.WaitForExit()

        Return (p.ExitCode = 0)
    End Function
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each foundFile As String In My.Computer.FileSystem.GetFiles("C:\Program Files\Microsoft Office\root\Licenses16", FileIO.SearchOption.SearchAllSubDirectories, "ProPlus2021VL_KMS*.xrm-ms")
            RunOspp($"/inslic:""{foundFile}""")
        Next

        ListBox1.Items.Add("License Installed")

        If (RunOspp("/setprt:1688")) Then
            If (RunOspp("/unpkey:6F7TH >nul")) Then
                If (RunOspp("/inpkey:FXYTK-NJJ8C-GB6DW-3DYQT-6F7TH")) Then
                    If (RunOspp("/sethst:107.175.77.7")) Then
                        If (RunOspp("/act")) Then
                            ListBox1.Items.Add("Office Activated")
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
