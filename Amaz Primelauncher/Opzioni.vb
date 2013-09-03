Public Class Opzioni

    Private Sub Opzioni_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        AmazPrimelauncher.Show()
    End Sub

    Private Sub rad_SieveON_Click(sender As Object, e As EventArgs) Handles rad_SieveON.Click
        rad_SieveOFF.Checked = False
        rad_SieveON.Checked = True
        num_SieveSize.Visible = False
        v(5) = "True"
    End Sub

    Private Sub rad_SieveOFF_Click(sender As Object, e As EventArgs) Handles rad_SieveOFF.Click
        rad_SieveON.Checked = False
        rad_SieveOFF.Checked = True
        num_SieveSize.Visible = True
        v(5) = "False"
    End Sub

    Private Sub rad_ThreadON_Click(sender As Object, e As EventArgs) Handles rad_ThreadON.Click
        rad_ThreadOFF.Checked = False
        rad_ThreadON.Checked = True
        num_Thread.Visible = False
        v(6) = "True"

    End Sub

    Private Sub rad_ThreadOFF_Click(sender As Object, e As EventArgs) Handles rad_ThreadOFF.Click
        rad_ThreadON.Checked = False
        rad_ThreadOFF.Checked = True
        num_Thread.Visible = True
        v(6) = "False"
    End Sub

    Private Sub rad_HideOFF_Click(sender As Object, e As EventArgs) Handles rad_HideOFF.Click
        rad_HideON.Checked = False
        rad_HideOFF.Checked = True
        v(7) = "False"
    End Sub

    Private Sub rad_HideON_Click(sender As Object, e As EventArgs) Handles rad_HideON.Click
        rad_HideOFF.Checked = False
        rad_HideON.Checked = True
        v(7) = "True"
    End Sub

    Private Sub btn_Reset_Click(sender As Object, e As EventArgs) Handles btn_Reset.Click
        Dim disco As System.IO.File
        Dim scrivi As System.IO.StreamWriter
        scrivi = disco.CreateText("Amaz-Data.dat")
        scrivi.WriteLine("amaz-pool:http://ypool.net:10034" & vbCrLf & "amaz-user:Micio.1" & vbCrLf & "amaz-pass:1" & vbCrLf & "amaz-siev:1500000" & vbCrLf & "amaz-thre:0" & vbCrLf & "check-sie:True" & vbCrLf & "check-thr:True" & vbCrLf & "check-hid:False")
        scrivi.Close()
        Me.Close()
        Application.Restart()
    End Sub

    Private Sub btn_Salva_Click(sender As Object, e As EventArgs) Handles btn_Salva.Click

        Try
        Dim disco As System.IO.File
            Dim scrivi As System.IO.StreamWriter
            System.IO.File.Move("Amaz-Data.dat", "Amaz-Data_temp.dat")
            System.IO.File.Delete("Amaz-Data_temp.dat")
            scrivi = disco.CreateText("Amaz-Data.dat")
            scrivi.WriteLine("amaz-pool:" & v(0) & vbCrLf & "amaz-user:" & v(1) & vbCrLf & "amaz-pass:" & v(2) & vbCrLf & "amaz-siev:" & v(3) & vbCrLf & "amaz-thre:" & v(4) & vbCrLf & "check-sie:" & v(5) & vbCrLf & "check-thr:" & v(6) & vbCrLf & "check-hid:" & v(7))
            scrivi.Close()
        Me.Close()
        Application.Restart()
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
    End Sub

    Private Sub Opzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If v(5) = "False" Then
            rad_SieveON.Checked = False
            rad_SieveOFF.Checked = True
            num_SieveSize.Visible = True
            num_SieveSize.Value = v(3)
        End If
        If v(6) = "False" Then
            rad_ThreadON.Checked = False
            rad_ThreadOFF.Checked = True
            num_Thread.Visible = True
            num_Thread.Value = v(4)
        End If
        If v(7) = "True" Then
            rad_HideON.Checked = True
            rad_HideOFF.Checked = False
        End If


    End Sub

    Private Sub num_SieveSize_ValueChanged(sender As Object, e As EventArgs) Handles num_SieveSize.ValueChanged
        v(3) = num_SieveSize.Value
    End Sub

    Private Sub num_Thread_ValueChanged(sender As Object, e As EventArgs) Handles num_Thread.ValueChanged
        v(4) = num_Thread.Value
    End Sub
End Class