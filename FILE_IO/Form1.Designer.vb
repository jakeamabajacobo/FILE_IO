<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txt_box = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.pic_box = New System.Windows.Forms.PictureBox()
        Me.btn_upload = New System.Windows.Forms.Button()
        Me.btn_save_image = New System.Windows.Forms.Button()
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_box
        '
        Me.txt_box.Location = New System.Drawing.Point(12, 76)
        Me.txt_box.Multiline = True
        Me.txt_box.Name = "txt_box"
        Me.txt_box.Size = New System.Drawing.Size(382, 314)
        Me.txt_box.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(184, 415)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(125, 36)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(53, 415)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(125, 36)
        Me.btn_open.TabIndex = 2
        Me.btn_open.Text = "OPEN"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'pic_box
        '
        Me.pic_box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pic_box.InitialImage = CType(resources.GetObject("pic_box.InitialImage"), System.Drawing.Image)
        Me.pic_box.Location = New System.Drawing.Point(427, 76)
        Me.pic_box.Name = "pic_box"
        Me.pic_box.Size = New System.Drawing.Size(382, 314)
        Me.pic_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_box.TabIndex = 3
        Me.pic_box.TabStop = False
        '
        'btn_upload
        '
        Me.btn_upload.Location = New System.Drawing.Point(488, 415)
        Me.btn_upload.Name = "btn_upload"
        Me.btn_upload.Size = New System.Drawing.Size(125, 36)
        Me.btn_upload.TabIndex = 5
        Me.btn_upload.Text = "UPLOAD"
        Me.btn_upload.UseVisualStyleBackColor = True
        '
        'btn_save_image
        '
        Me.btn_save_image.Location = New System.Drawing.Point(619, 415)
        Me.btn_save_image.Name = "btn_save_image"
        Me.btn_save_image.Size = New System.Drawing.Size(125, 36)
        Me.btn_save_image.TabIndex = 4
        Me.btn_save_image.Text = "SAVE"
        Me.btn_save_image.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(821, 559)
        Me.Controls.Add(Me.btn_upload)
        Me.Controls.Add(Me.btn_save_image)
        Me.Controls.Add(Me.pic_box)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_box)
        Me.Name = "Form1"
        Me.Text = "FILE IO"
        CType(Me.pic_box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_box As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_open As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents pic_box As PictureBox
    Friend WithEvents btn_upload As Button
    Friend WithEvents btn_save_image As Button
End Class
