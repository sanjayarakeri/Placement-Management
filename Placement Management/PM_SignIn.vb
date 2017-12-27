Imports System
Imports System.Data.OleDb


Public Class PM_SignIn

    Dim DSet As DataSet

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnSignIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSignIn.Click

        DSet = Package.ExeCmd("SELECT * FROM SignIn WHERE UID='" + TxtUserName.Text + "' AND Pwd='" + TxtPassword.Text + "'")

        If DSet.Tables(0).Rows.Count = 1 Then
            ClearControls(Me)
            Me.Hide()
            Package.CallForm(PM_MDIMenus)
        Else
            MessageBox.Show("Invalid User Name or Password", "Recruitment Management", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        
    End Sub

  
End Class
