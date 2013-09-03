Imports System.IO
Public Class AmazPrimelauncher
    'Public v(10) As String

    Private Sub btn_Mining_Click(sender As Object, e As EventArgs) Handles btn_Mining.Click
        Try
            If v(4) = 0 And v(7) = "False" Then
                Shell("Amaz Miner.exe -o " & v(0) & " -u " & v(1) & " -p " & v(2) & " -s " & v(3))
            End If
            If v(4) = 0 And v(7) = "True" Then
                Shell("Amaz Miner.exe -o " & v(0) & " -u " & v(1) & " -p " & v(2) & " -s " & v(3), AppWinStyle.Hide)
            End If
            If v(4) > 0 And v(7) = "False" Then
                Shell("Amaz Miner.exe -o " & v(0) & " -u " & v(1) & " -p " & v(2) & " -s " & v(3) & " -t " & v(4))
            End If
            If v(4) > 0 And v(7) = "True" Then
                Shell("Amaz Miner.exe -o " & v(0) & " -u " & v(1) & " -p " & v(2) & " -s " & v(3) & " -t " & v(4), AppWinStyle.Hide)
            End If
            Me.Hide()
        Catch ex As Exception
            MsgBox("Error opening Amaz Miner.exe")
        End Try

        Try
            Dim disco As System.IO.File
            Dim scrivi As System.IO.StreamWriter
            System.IO.File.Move("Amaz-Data.dat", "Amaz-Data_temp.dat")
            System.IO.File.Delete("Amaz-Data_temp.dat")
            scrivi = disco.CreateText("Amaz-Data.dat")
            scrivi.WriteLine("amaz-pool:" & v(0) & vbCrLf & "amaz-user:" & v(1) & vbCrLf & "amaz-pass:" & v(2) & vbCrLf & "amaz-siev:" & v(3) & vbCrLf & "amaz-thre:" & v(4) & vbCrLf & "check-sie:" & v(5) & vbCrLf & "check-thr:" & v(6) & vbCrLf & "check-hid:" & v(7))
            scrivi.Close()
        Catch ex As Exception
        End Try
        End
    End Sub

    Private Sub AmazPrimelauncher_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oFile As System.IO.File
        Dim oRead As System.IO.StreamReader


        Try
            oRead = oFile.OpenText("Amaz-Data.dat")
            While oRead.Peek <> -1
                For i = 0 To 7
                    v(i) = oRead.ReadLine()
                    v(i) = v(i).ToString.Replace("amaz-pool:", "") '0 = Pool
                    v(i) = v(i).ToString.Replace("amaz-user:", "") '1 = Username
                    v(i) = v(i).ToString.Replace("amaz-pass:", "") '2 = Password
                    v(i) = v(i).ToString.Replace("amaz-siev:", "") '3 = Sieve size
                    v(i) = v(i).ToString.Replace("amaz-thre:", "") '4 = Thread value
                    v(i) = v(i).ToString.Replace("check-sie:", "") '5 = Check sieve
                    v(i) = v(i).ToString.Replace("check-thr:", "") '6 = Check Thread
                    v(i) = v(i).ToString.Replace("check-hid:", "") '7 = Check Hide
                Next
            End While

        Catch ex As Exception
            MsgBox(ErrorToString)
        Finally
            oRead.Close()
        End Try
        txt_Pool.Text = v(0)
        txt_Username.Text = v(1)
        txt_Password.Text = v(2)
    End Sub

    Private Sub btn_Opzioni_Click(sender As Object, e As EventArgs) Handles btn_Opzioni.Click
        Opzioni.Show()
        Me.Hide()
    End Sub

    Private Sub Notifica_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Notifica.MouseDoubleClick
        Me.Show()
    End Sub

    Private Sub lnk_Info_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnk_Info.LinkClicked
        MsgBox("This software is published by Micio for Amaz" & vbCrLf & vbCrLf & "Insert your pool worker data for mine, for security, don't insert same password for account and worker" & vbCrLf & vbCrLf & "© 2013 Amaz - Amaz Primelauncher. Version 0.2 (beta)")
    End Sub

    Private Sub txt_Pool_TextChanged(sender As Object, e As EventArgs) Handles txt_Pool.TextChanged
        v(0) = txt_Pool.Text
    End Sub

    Private Sub txt_Username_TextChanged(sender As Object, e As EventArgs) Handles txt_Username.TextChanged
        v(1) = txt_Username.Text
    End Sub

    Private Sub txt_Password_TextChanged(sender As Object, e As EventArgs) Handles txt_Password.TextChanged
        v(2) = txt_Password.Text
    End Sub
End Class
