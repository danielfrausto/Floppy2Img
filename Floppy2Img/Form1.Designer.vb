<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.cbox_drives = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_dir = New System.Windows.Forms.Button()
        Me.txt_dir = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_copy = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_read = New System.Windows.Forms.Button()
        Me.btn_write = New System.Windows.Forms.Button()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.sfd = New System.Windows.Forms.SaveFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbox_drives
        '
        Me.cbox_drives.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_drives.FormattingEnabled = True
        Me.cbox_drives.Location = New System.Drawing.Point(6, 19)
        Me.cbox_drives.Name = "cbox_drives"
        Me.cbox_drives.Size = New System.Drawing.Size(63, 21)
        Me.cbox_drives.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_dir)
        Me.GroupBox1.Controls.Add(Me.txt_dir)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 54)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Image File"
        '
        'btn_dir
        '
        Me.btn_dir.Location = New System.Drawing.Point(324, 18)
        Me.btn_dir.Name = "btn_dir"
        Me.btn_dir.Size = New System.Drawing.Size(75, 23)
        Me.btn_dir.TabIndex = 4
        Me.btn_dir.Text = "Set"
        Me.btn_dir.UseVisualStyleBackColor = True
        '
        'txt_dir
        '
        Me.txt_dir.Location = New System.Drawing.Point(6, 20)
        Me.txt_dir.Name = "txt_dir"
        Me.txt_dir.Size = New System.Drawing.Size(312, 20)
        Me.txt_dir.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_refresh)
        Me.GroupBox2.Controls.Add(Me.cbox_drives)
        Me.GroupBox2.Location = New System.Drawing.Point(417, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(153, 54)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Device"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(72, 17)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(75, 23)
        Me.btn_refresh.TabIndex = 1
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_copy
        '
        Me.btn_copy.Enabled = False
        Me.btn_copy.Location = New System.Drawing.Point(12, 63)
        Me.btn_copy.Name = "btn_copy"
        Me.btn_copy.Size = New System.Drawing.Size(75, 23)
        Me.btn_copy.TabIndex = 3
        Me.btn_copy.Text = "Copy"
        Me.btn_copy.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 92)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(558, 48)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Progress"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(6, 19)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(482, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Version: 0.0.1"
        '
        'btn_cancel
        '
        Me.btn_cancel.Enabled = False
        Me.btn_cancel.Location = New System.Drawing.Point(250, 145)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 23)
        Me.btn_cancel.TabIndex = 6
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_read
        '
        Me.btn_read.Enabled = False
        Me.btn_read.Location = New System.Drawing.Point(331, 145)
        Me.btn_read.Name = "btn_read"
        Me.btn_read.Size = New System.Drawing.Size(75, 23)
        Me.btn_read.TabIndex = 7
        Me.btn_read.Text = "Read"
        Me.btn_read.UseVisualStyleBackColor = True
        '
        'btn_write
        '
        Me.btn_write.Enabled = False
        Me.btn_write.Location = New System.Drawing.Point(412, 145)
        Me.btn_write.Name = "btn_write"
        Me.btn_write.Size = New System.Drawing.Size(75, 23)
        Me.btn_write.TabIndex = 8
        Me.btn_write.Text = "Write"
        Me.btn_write.UseVisualStyleBackColor = True
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(493, 145)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(75, 23)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 171)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(580, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 193)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_write)
        Me.Controls.Add(Me.btn_read)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_copy)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Floppy2Img"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbox_drives As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_dir As Button
    Friend WithEvents txt_dir As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btn_copy As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents btn_read As Button
    Friend WithEvents btn_write As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents sfd As SaveFileDialog
    Friend WithEvents btn_refresh As Button
End Class
