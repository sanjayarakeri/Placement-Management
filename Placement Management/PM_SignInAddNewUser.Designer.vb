<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PM_SignInAddNewUser
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
        Me.label3 = New System.Windows.Forms.Label
        Me.label2 = New System.Windows.Forms.Label
        Me.label1 = New System.Windows.Forms.Label
        Me.label10 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TxtUName = New System.Windows.Forms.TextBox
        Me.TxtUID = New System.Windows.Forms.TextBox
        Me.TxtUType = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.TxtUPwd = New System.Windows.Forms.TextBox
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnCancel = New System.Windows.Forms.Button
        Me.label8 = New System.Windows.Forms.Label
        Me.label7 = New System.Windows.Forms.Label
        Me.label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label9
        '
        Me.label9.AutoSize = True
        Me.label9.BackColor = System.Drawing.Color.Teal
        Me.label9.Font = New System.Drawing.Font("Cambria", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label9.ForeColor = System.Drawing.Color.Red
        Me.label9.Location = New System.Drawing.Point(210, 16)
        Me.label9.Name = "label9"
        Me.label9.Size = New System.Drawing.Size(129, 16)
        Me.label9.TabIndex = 92
        Me.label9.Text = "( Min. 6 Characters )"
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.BackColor = System.Drawing.Color.Teal
        Me.label5.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label5.ForeColor = System.Drawing.Color.White
        Me.label5.Location = New System.Drawing.Point(76, 13)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(128, 20)
        Me.label5.TabIndex = 88
        Me.label5.Text = "Your Password :"
        '
        'label3
        '
        Me.label3.BackColor = System.Drawing.Color.Transparent
        Me.label3.ForeColor = System.Drawing.Color.White
        Me.label3.Location = New System.Drawing.Point(7, 166)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(384, 37)
        Me.label3.TabIndex = 86
        '
        'label2
        '
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(7, 85)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(384, 37)
        Me.label2.TabIndex = 85
        '
        'label1
        '
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(7, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(134, 37)
        Me.label1.TabIndex = 84
        '
        'label10
        '
        Me.label10.BackColor = System.Drawing.Color.Teal
        Me.label10.ForeColor = System.Drawing.Color.White
        Me.label10.Location = New System.Drawing.Point(7, 5)
        Me.label10.Name = "label10"
        Me.label10.Size = New System.Drawing.Size(384, 37)
        Me.label10.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtUName)
        Me.GroupBox1.Controls.Add(Me.TxtUID)
        Me.GroupBox1.Controls.Add(Me.TxtUType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.TxtUPwd)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.BtnCancel)
        Me.GroupBox1.Controls.Add(Me.label8)
        Me.GroupBox1.Controls.Add(Me.label7)
        Me.GroupBox1.Controls.Add(Me.label6)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 218)
        Me.GroupBox1.TabIndex = 93
        Me.GroupBox1.TabStop = False
        '
        'TxtUName
        '
        Me.TxtUName.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUName.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUName.ForeColor = System.Drawing.Color.Black
        Me.TxtUName.Location = New System.Drawing.Point(137, 137)
        Me.TxtUName.Name = "TxtUName"
        Me.TxtUName.Size = New System.Drawing.Size(232, 25)
        Me.TxtUName.TabIndex = 99
        '
        'TxtUID
        '
        Me.TxtUID.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUID.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUID.ForeColor = System.Drawing.Color.Black
        Me.TxtUID.Location = New System.Drawing.Point(137, 15)
        Me.TxtUID.Name = "TxtUID"
        Me.TxtUID.Size = New System.Drawing.Size(232, 25)
        Me.TxtUID.TabIndex = 96
        '
        'TxtUType
        '
        Me.TxtUType.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TxtUType.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUType.ForeColor = System.Drawing.Color.Black
        Me.TxtUType.FormattingEnabled = True
        Me.TxtUType.Items.AddRange(New Object() {"Adminstrator", "Employee"})
        Me.TxtUType.Location = New System.Drawing.Point(137, 97)
        Me.TxtUType.Name = "TxtUType"
        Me.TxtUType.Size = New System.Drawing.Size(232, 23)
        Me.TxtUType.TabIndex = 98
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(9, 97)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 18)
        Me.Label11.TabIndex = 105
        Me.Label11.Text = "User Type :"
        '
        'TxtUPwd
        '
        Me.TxtUPwd.BackColor = System.Drawing.SystemColors.Control
        Me.TxtUPwd.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUPwd.ForeColor = System.Drawing.Color.Black
        Me.TxtUPwd.Location = New System.Drawing.Point(137, 55)
        Me.TxtUPwd.MaxLength = 15
        Me.TxtUPwd.Name = "TxtUPwd"
        Me.TxtUPwd.Size = New System.Drawing.Size(232, 25)
        Me.TxtUPwd.TabIndex = 97
        Me.TxtUPwd.UseSystemPasswordChar = True
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.Green
        Me.BtnSave.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.White
        Me.BtnSave.Location = New System.Drawing.Point(137, 176)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 28)
        Me.BtnSave.TabIndex = 100
        Me.BtnSave.Text = "S A V E"
        Me.BtnSave.UseVisualStyleBackColor = False
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Green
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.White
        Me.BtnCancel.Location = New System.Drawing.Point(264, 176)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 28)
        Me.BtnCancel.TabIndex = 101
        Me.BtnCancel.Text = "C L O S E"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'label8
        '
        Me.label8.AutoSize = True
        Me.label8.BackColor = System.Drawing.Color.Transparent
        Me.label8.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label8.ForeColor = System.Drawing.Color.White
        Me.label8.Location = New System.Drawing.Point(9, 137)
        Me.label8.Name = "label8"
        Me.label8.Size = New System.Drawing.Size(89, 18)
        Me.label8.TabIndex = 104
        Me.label8.Text = "User Name :"
        '
        'label7
        '
        Me.label7.AutoSize = True
        Me.label7.BackColor = System.Drawing.Color.Transparent
        Me.label7.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label7.ForeColor = System.Drawing.Color.White
        Me.label7.Location = New System.Drawing.Point(9, 57)
        Me.label7.Name = "label7"
        Me.label7.Size = New System.Drawing.Size(118, 18)
        Me.label7.TabIndex = 103
        Me.label7.Text = "User Password :"
        '
        'label6
        '
        Me.label6.AutoSize = True
        Me.label6.BackColor = System.Drawing.Color.Transparent
        Me.label6.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label6.ForeColor = System.Drawing.Color.White
        Me.label6.Location = New System.Drawing.Point(9, 17)
        Me.label6.Name = "label6"
        Me.label6.Size = New System.Drawing.Size(66, 18)
        Me.label6.TabIndex = 102
        Me.label6.Text = "User ID :"
        '
        'PM_SignInAddNewUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(401, 275)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.label9)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.label10)
        Me.ForeColor = System.Drawing.Color.Teal
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.Name = "PM_SignInAddNewUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New User"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label9 As System.Windows.Forms.Label
    Private WithEvents label5 As System.Windows.Forms.Label
    Private WithEvents label3 As System.Windows.Forms.Label
    Private WithEvents label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtUName As System.Windows.Forms.TextBox
    Friend WithEvents TxtUID As System.Windows.Forms.TextBox
    Friend WithEvents TxtUType As System.Windows.Forms.ComboBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents TxtUPwd As System.Windows.Forms.TextBox
    Private WithEvents BtnSave As System.Windows.Forms.Button
    Private WithEvents BtnCancel As System.Windows.Forms.Button
    Private WithEvents label8 As System.Windows.Forms.Label
    Private WithEvents label7 As System.Windows.Forms.Label
    Private WithEvents label6 As System.Windows.Forms.Label
End Class
