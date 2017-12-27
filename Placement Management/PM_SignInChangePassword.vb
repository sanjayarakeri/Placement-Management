Imports System
Imports System.Data.OleDb

Public Class PM_SignInChangePassword

    Dim Dset As DataSet

    Private Sub PMChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls(Me)
    End Sub
   
    Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click
        Dim Confirm As DialogResult

        Dset = Package.ExeCmd("SELECT * FROM SignIn WHERE UID='" + TxtUID.Text + "' AND Pwd='" + TxtUPwd.Text + "'")
        If Dset.Tables(0).Rows.Count = 0 Then
            MessageBox.Show(" User Not Exist ", " Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearControls(Me)
            Exit Sub
        End If

        If TxtUID.Text <> Dset.Tables(0).Rows(0).ItemArray(0).ToString Or TxtUPwd.Text <> Dset.Tables(0).Rows(0).ItemArray(1).ToString Then
            MessageBox.Show(" Wrong UserID Or Current Password !", " Warning ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearControls(Me)
            Exit Sub
        End If

        If Package.BlankControl(Me) Then
            MessageBox.Show(" Enter All Fields Corrrectly", " Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearControls(Me)
            Exit Sub
        End If

        If TxtNPwd.Text.Length < 6 Or TxtNCPwd.Text.Length < 6 Then
            MessageBox.Show(" Password Should Be Min 6 Characters ", " Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearControls(Me)
            Exit Sub
        End If

        If TxtNPwd.Text = TxtNCPwd.Text Then
            Confirm = MessageBox.Show(" Update New Password !", " Update Confirmation ! ", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
            If Confirm = Windows.Forms.DialogResult.OK Then
                Dset = Package.ExeCmd("UPDATE SignIn SET Pwd='" + TxtNPwd.Text + "' WHERE UID='" + TxtUID.Text + "' AND Pwd='" + TxtUPwd.Text + "'")
                MessageBox.Show(" New Password Upadted Successfully !", " Success ! ", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearControls(Me)
                Exit Sub
            Else
                ClearControls(Me)
                Exit Sub
            End If
        Else
            MessageBox.Show(" Re-Enter Passwords ", " Warning !", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            ClearControls(Me)
        End If
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class