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
        Me.txt_box = New System.Windows.Forms.TextBox()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txt_box
        '
        Me.txt_box.Location = New System.Drawing.Point(12, 21)
        Me.txt_box.Multiline = True
        Me.txt_box.Name = "txt_box"
        Me.txt_box.Size = New System.Drawing.Size(382, 314)
        Me.txt_box.TabIndex = 0
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(220, 350)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(125, 36)
        Me.btn_save.TabIndex = 1
        Me.btn_save.Text = "SAVE"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_open
        '
        Me.btn_open.Location = New System.Drawing.Point(62, 350)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(125, 36)
        Me.btn_open.TabIndex = 2
        Me.btn_open.Text = "OPEN"
        Me.btn_open.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 450)
        Me.Controls.Add(Me.btn_open)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.txt_box)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_box As TextBox
    Friend WithEvents btn_save As Button
    Friend WithEvents btn_open As Button
End Class
