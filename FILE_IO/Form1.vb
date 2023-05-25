Imports System.IO
Imports System.IO.File
Imports System.Diagnostics
Imports System.Security.Cryptography
Imports System.Net.WebRequestMethods
Imports System.Text

Public Class Form1
    Dim open_Dlg As New OpenFileDialog
    Dim strm_rdr As StreamReader
    Dim strm_wtr As StreamWriter
    Dim dir As String




    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try
            If (IO.File.Exists(dir)) Then

                Try
                    Dim buffer As [Byte]() = Encoding.ASCII.GetBytes(txt_box.Text)
                    Dim MS As MemoryStream = New MemoryStream(buffer)

                    If (IO.File.Exists(dir)) Then
                        Dim File As FileStream = New FileStream(dir, FileMode.Create, FileAccess.Write)
                    Else

                        If sv_dialog.ShowDialog = Windows.Forms.DialogResult.OK Then


                        End If
                    End If

                

                    MS.WriteTo(File)
                    File.Close()
                    MS.Close()


                    MsgBox("File saved!")
                    txt_box.Clear()

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Else
                Dim sv_dialog As New SaveFileDialog

                sv_dialog.Filter = "TXT Files (*.txt*)|*.txt"

                If sv_dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
                    My.Computer.FileSystem.WriteAllText(sv_dialog.FileName, txt_box.Text, False)
                End If



                MsgBox("File saved!")
                txt_box.Clear()


            End If






            ' strm_writer.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_open_Click(sender As Object, e As EventArgs) Handles btn_open.Click


        open_Dlg.Filter = "Text [*.txt*]|*.txt|All Files[*.*]|*.*"
        open_Dlg.Title = "Select Text File"

        If open_Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            dir = Convert.ToString(open_Dlg.FileName)
            Try

                Using fileStream As FileStream = New FileStream(dir, FileMode.Open, FileAccess.Read, FileShare.ReadWrite, FileMode.Append)
                    Dim sr As StreamReader = New StreamReader(fileStream)
                    Dim Str As String = sr.ReadToEnd()
                    txt_box.Text = Str
                    sr.Dispose()
                    sr.Close()
                    fileStream.Dispose()
                    fileStream.Close()
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
End Class
