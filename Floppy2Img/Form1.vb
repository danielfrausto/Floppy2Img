Imports System.IO


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getdrives()
    End Sub
    Private Sub getdrives()



        If cbox_drives.Items.Count > 0 Then
            cbox_drives.Items.Clear()
        End If

        ' We through the list of drives
        For Each drive As IO.DriveInfo In IO.DriveInfo.GetDrives()

            ' Detection drive type


            If drive.DriveType = DriveType.Removable Then
                '    drive_type = "Removable Disk"


                ' The drive name and its type is added to the list of drives
                cbox_drives.Items.Add(drive.Name)
            End If
        Next





        Try
            ' It selects the first item in the list (ComboBox)
            cbox_drives.SelectedIndex = 0
        Catch ex As Exception
            MsgBox("No Drives Found")
        End Try






    End Sub



    Private Sub btn_dir_Click(sender As Object, e As EventArgs) Handles btn_dir.Click
        sfd.Filter = "img File|*.img"
        sfd.Title = "Save an Image File"
        sfd.ShowDialog()
        ' If the file name is not an empty string open it for saving.
        If sfd.FileName <> "" Then
            Dim loc = sfd.FileName
            txt_dir.Text = loc
            ' btn_read.Enabled = True
        End If
        sfd.Dispose()
    End Sub
    Private Sub read()
        Dim dir = txt_dir.Text
        Dim source = cbox_drives.SelectedItem

        If dir = "" Then
            dir = "No Directory Selected"
            MsgBox(dir)
            Exit Sub
        End If
        If source = "" Then
            source = "No Source Avalable"
            MsgBox(source)
            Exit Sub
        End If


        '  MsgBox(source & vbCrLf & dir)
        Dim apppath As String = Application.StartupPath & "\"
        Dim app As String = "imgCreate.exe"
        Dim SetupPath As String = apppath & app

        If Not File.Exists(app) Then
            ' MsgBox("NotFound!")
            Using sCreateMSIFile As New FileStream(SetupPath, FileMode.Create)
                sCreateMSIFile.Write(My.Resources.imgflpyd, 0, My.Resources.imgflpyd.Length)
            End Using
            '  MsgBox("App Created")
        End If

        Dim wait As Integer = 1000


        Process.Start("CMD")
        Threading.Thread.Sleep(wait)
        SendKeys.SendWait(app & " " & source & " " & dir)
        Threading.Thread.Sleep(wait)
        SendKeys.SendWait("{ENTER}")
        Threading.Thread.Sleep(wait)
        SendKeys.SendWait("exit")
        Threading.Thread.Sleep(wait)
        SendKeys.SendWait("{ENTER}")

    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        read()
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Application.Exit()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        getdrives()
    End Sub

    Public Function MyProcessRunning(ByVal name As String) As Boolean
        'Check if the process is runing.
        For Each CloseMyProcess As Process In Process.GetProcesses()
            If CloseMyProcess.ProcessName.StartsWith(name) Then
                'process found 
                Return False
            End If
        Next
        'process not found, imgCreate.exe killed
        Return True
    End Function
    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'To kill the imgCreate.exe Process.
        Dim MyProcess() As Process = System.Diagnostics.Process.GetProcessesByName("imgCreate")
        For Each p As Process In MyProcess
            p.Kill()
        Next
        ''To delete the imgCreate.exe file from the directory.
        'If MyProcessRunning("Testing") Then
        '    Dim FileToDelete As String = My.Application.Info.DirectoryPath + "\imgCreate.exe"
        '    If System.IO.File.Exists(FileToDelete) = True Then
        '        System.IO.File.Delete(FileToDelete)
        '    End If
        'Else : Form1_FormClosing(sender, e)
        'End If
    End Sub

    Private Sub txt_dir_TextChanged(sender As Object, e As EventArgs) Handles txt_dir.TextChanged

        If cbox_drives.SelectedItem = "" Then
            MsgBox("No Source Available")
        Else
            If btn_read.Enabled = False Then
                If Not txt_dir.Text = "" Then
                    If txt_dir.Text.Contains(".img") Then
                        btn_read.Enabled = True
                    End If
                End If
            Else
                btn_read.Enabled = False
            End If
        End If

    End Sub

End Class
