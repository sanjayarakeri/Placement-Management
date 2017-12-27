<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PM_SignInChangePassword
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
        Me.label9 = New System.Windows.Forms.Label
        Me.label5 = New System.Windows.Forms.Label
        Me.label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtUID = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtNCPwd = New System.Windows.Forms.TextBox
        Me.TxtNPwd = New System.Windows.Forms.TextBox
        Me.TxtUPwd = New System.Windows.Forms.TextBox
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.BtnDone = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.label4 = New System.Windows.Forms.Label
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Teal
        Me.label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Red
        Me.label9.Location = New System.Drawing.Point(213, 15)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(128, 15)
        Me.label9.TabIndex = 77
        Me.label9.Text = "( Min. 6 Characters )"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Teal
        Me.label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(19, 12)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(186, 19)
        Me.label5.TabIndex = 73
        Me.label5.Text = "Change Your Password :"
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.Teal
        Me.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label10.Location = New System.Drawing.Point(7, 4)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(386, 37)
        Me.label10.TabIndex = 68
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtUID)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtNCPwd)
        Me.GroupBox1.Controls.Add(Me.TxtNPwd)
        Me.GroupBox1.Controls.Add(Me.TxtUPwd)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Controls.Add(Me.BtnDone)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.label4)
        Me.GroupBox1.Controls.Add(Me.label3)
        Me.GroupBox1.Controls.Add(Me.label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(388, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtUID
        '
        Me.TxtUID.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUID.Location = New System.Drawing.Point(208, 12)
        Me.TxtUID.MaxLength = 15
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(166, 25)
        Me.TxtUID.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(27, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(66, 17)
        Me.Label11.TabIndex = 106
        Me.Label11.Text = "User ID :"
        '
        'TxtNCPwd
        '
        Me.TxtNCPwd.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNCPwd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNCPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNCPwd.Location = New System.Drawing.Point(208, 131)
        Me.TxtNCPwd.MaxLength = 15
        Me.TxtNCPwd.Name = "TxtNCPwd"
        Me.TxtNCPwd.Size = New System.Drawing.Size(166, 25)
        Me.TxtNCPwd.TabIndex = 4
        Me.TxtNCPwd.UseSystemPasswordChar = True
        '
        'TxtNPwd
        '
        Me.TxtNPwd.BackColor = System.Drawing.SystemColors.Control
        Me.TxtNPwd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtNPwd.Location = New System.Drawing.Point(208, 92)
        Me.TxtNPwd.MaxLength = 15
        Me.TxtNPwd.Name = "TxtNPwd"
        Me.TxtNPwd.Size = New System.Drawing.Size(166, 25)
        Me.TxtNPwd.TabIndex = 3
        Me.TxtNPwd.UseSystemPasswordChar = True
        '
        'TxtUPwd
        '
        Me.TxtUPwd.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUPwd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUPwd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.TxtUPwd.Location = New System.Drawing.Point(208, 52)
        Me.TxtUPwd.MaxLength = 15
        Me.TxtUPwd.Name = "TxtUPwd"
        Me.TxtUPwd.Size = New System.Drawing.Size(166, 25)
        Me.TxtUPwd.TabIndex = 2
        Me.TxtUPwd.UseSystemPasswordChar = True
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(27, 132)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(175, 17)
        Me.label8.TabIndex = 105
        Me.label8.Text = "ReEnter New Password :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(27, 93)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(116, 17)
        Me.label7.TabIndex = 104
        Me.label7.Text = "New Password :"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(27, 53)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(140, 17)
        Me.label6.TabIndex = 103
        Me.label6.Text = "Current Password :"
        '
        'BtnDone
        '
        Me.BtnDone.BackColor = System.Drawing.Color.Green
        Me.BtnDone.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDone.ForeColor = System.Drawing.Color.White
        Me.BtnDone.Location = New System.Drawing.Point(128, 166)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(120, 28)
        Me.BtnDone.TabIndex = 97
        Me.BtnDone.Text = "D O N E"
        Me.BtnDone.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Green
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(254, 166)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(120, 28)
        Me.BtnCancel.TabIndex = 98
        Me.BtnCancel.Text = "C L O S E"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'label4
        '
        Me.label4.BackColor = System.Drawing.Color.Transparent
        Me.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label4.Location = New System.Drawing.Point(15, 161)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(384, 37)
        Me.label4.TabIndex = 102
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(15, 121)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(384, 37)
        Me.label3.TabIndex = 101
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label2.Location = New System.Drawing.Point(15, 81)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(384, 37)
        Me.label2.TabIndex = 100
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.label1.Location = New System.Drawing.Point(15, 41)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(384, 37)
        Me.label1.TabIndex = 99
        '
        'PM_SignInChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(405, 255)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label10)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PM_SignInChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents TxtUID As System.Windows.Forms.TextBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents TxtNCPwd As System.Windows.Forms.TextBox
    Private WithEvents TxtNPwd As System.Windows.Forms.TextBox
    Private WithEvents TxtUPwd As System.Windows.Forms.TextBox
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
    Private WithEvents BtnDone As System.Windows.Forms.Button
    Private WithEvents BtnCancel As System.Windows.Forms.Button
    Private WithEvents label4 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
