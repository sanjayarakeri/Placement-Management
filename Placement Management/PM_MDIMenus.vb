Imports System
Imports System.Data.OleDb


Public Class PM_MDIMenus
   
    Private Sub Register_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Register.Click
        Package.CallForm(PM_Register)
    End Sub

    Private Sub AddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUser.Click
        Package.CallForm(PM_SignInAddNewUser)
    End Sub

    Private Sub ChangPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangPassword.Click
        Package.CallForm(PM_SignInChangePassword)
    End Sub

  
    Private Sub PM_MDIMenus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class