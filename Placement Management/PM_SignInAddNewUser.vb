Imports System
Imports System.Data.OleDb
Public Class PM_SignInAddNewUser
    Dim Dset As DataSet

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Dim Confirm As DialogResult

        If TxtUPwd.Text.Length < 6 Then
            MessageBox.Show(" Password Should Be Min 6 Characters ", " Warning !", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Package.BlankControl(Me) Then
            MessageBox.Show(" Enter All Fields Correctly ", " Warning ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ClearControls(Me)
            Exit Sub
        Else
            Confirm = MessageBox.Show(" Save User :" + TxtUName.Text, " Confirm ", MessageBoxButtons.OKCancel)
            If Confirm = Windows.Forms.DialogResult.OK Then
                Dset = Package.ExeCmd("INSERT INTO SignIn VALUES('" + TxtUID.Text + "','" + TxtUPwd.Text + "','" + TxtUType.Text + "','" + TxtUName.Text + "')")
                MessageBox.Show(" New User Saved Sucessfully", " Success !", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ClearControls(Me)
                Exit Sub
            Else
                ClearControls(Me)
                Exit Sub
            End If
        End If
    End Sub

    Private Sub PM_SignInAddNewUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClearControls(Me)
    End Sub

    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub
End Class