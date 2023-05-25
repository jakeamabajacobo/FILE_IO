Imports System.IO
Imports System.Text

Public Class Form1
    Dim open_Dlg As New OpenFileDialog
    Dim sv_Dlg As New SaveFileDialog
    Dim dir As String
    Dim pic_name As String



    Function DataStream()

    End Function


    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        Try

            'NEW TEXT
            If (IO.File.Exists(dir) = False) Then
                sv_Dlg.Filter = "Text [*.txt*]|*.txt|All Files[*.*]|*.*"
                sv_Dlg.Title = "save file location"
                sv_Dlg.FilterIndex = 1
                If sv_Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
                    dir = sv_Dlg.FileName
                End If
            End If


            Dim File As FileStream = New FileStream(dir, FileMode.Create, FileAccess.Write)
            Dim buffer As [Byte]() = Encoding.ASCII.GetBytes(txt_box.Text)
            Dim MS As MemoryStream = New MemoryStream(buffer)
            MS.WriteTo(File)
            File.Close()
            MS.Close()
            sv_Dlg.Dispose()
            sv_Dlg.Reset()

            MsgBox("File saved!")
            txt_box.Clear()


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

    Private Sub btn_upload_Click(sender As Object, e As EventArgs) Handles btn_upload.Click

        With open_Dlg
            .InitialDirectory = "C:\"
            .Filter = "JPEGs|*.jpg|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
            .FilterIndex = 1
            .Title = "Select Image"
        End With

        If open_Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            pic_box.Image = Image.FromFile(open_Dlg.FileName)
            pic_box.SizeMode = PictureBoxSizeMode.StretchImage
        End If





    End Sub

    Private Sub btn_save_image_Click(sender As Object, e As EventArgs) Handles btn_save_image.Click
        With sv_Dlg
            .InitialDirectory = "C:\"
            .Filter = "JPEG|*.jpg|PNG|*.png|GIFs|*.gif|Bitmaps|*.bmp|AllFiles|*.*"
            .FilterIndex = 1
            .Title = "Saving Image - Select Location"
        End With

        If sv_Dlg.ShowDialog = Windows.Forms.DialogResult.OK Then
            Using pic As New Bitmap(open_Dlg.FileName)
                pic.Save(IO.Path.Combine(Path.GetDirectoryName(sv_Dlg.FileName), Path.GetFileName(sv_Dlg.FileName)))
            End Using
            pic_box.Image = Nothing
        End If
    End Sub



End Class
