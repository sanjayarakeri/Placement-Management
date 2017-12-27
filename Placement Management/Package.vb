Imports System
Imports System.Data.OleDb
Imports System.Data.Sql
Imports System.Data.SqlClient

Module Package

    Dim Con As SqlConnection
    Dim Cmd As SqlCommand
    Dim Adpt As SqlDataAdapter
    Dim DSet, DDSet As DataSet
    Dim Transaction As SqlTransaction

    Public Function ExeCmd(ByVal StrCmd As String) As DataSet
        DSet = New DataSet()
        Cmd = New SqlCommand()
        Adpt = New SqlDataAdapter()
        Con = New SqlConnection("Data Source=DESKTOP-IT1KQVH\SQLEXPRESS;Initial Catalog=PlacementManagement;Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")

        If Con.State = ConnectionState.Open Then
            Con.Close()
        End If

        Con.Open()

        Cmd = Con.CreateCommand()
        Transaction = Con.BeginTransaction()
        Cmd.Transaction = Transaction
        Cmd.CommandText = StrCmd

        Try
            Adpt.SelectCommand = Cmd
            DSet.Clear()
            Adpt.Fill(DSet)
            Transaction.Commit()
        Catch Err As Exception
            Transaction.Rollback()
            MessageBox.Show(Err.ToString(), "Placement Management", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ExeCmd = Nothing
        End Try

        Con.Close()

        ExeCmd = DSet

    End Function

    Public Sub CallForm(ByVal Frm As Form)
        Frm.ShowDialog()
    End Sub

    Public Sub Fetch(ByVal Frm As Form, ByVal StoreUsn As String)
        Dim i As Integer = 0

        DSet = Package.ExeCmd("SELECT * FROM StudentMaster WHERE USN='" + StoreUsn.ToString() + "'")

        For Each ctrl As Control In Frm.Controls.OfType(Of GroupBox)().OrderBy(Function(t) t.TabIndex)
            For Each child As Control In ctrl.Controls.OfType(Of Object).OrderBy(Function(t) t.TabIndex)
                If i = 28 Then
                    Exit Sub
                End If
                If Not TypeOf child Is Label And Not TypeOf child Is Button Then
                    child.Text = DSet.Tables(0).Rows(0).Item(i).ToString()
                    i = i + 1
                End If
            Next
        Next

    End Sub

    Public Sub CalculatePercent(ByVal SemMarks As MaskedTextBox, ByVal SemPercent As MaskedTextBox, ByVal OutOf As Integer)
        If SemMarks.Text.Length = 3 Then
            SemPercent.Text = FormatNumber(Val(SemMarks.Text) * 100 / OutOf, 2).ToString()
        Else
            SemPercent.Clear()
        End If
    End Sub

    Public Sub CalculateTotal(ByVal arr1() As MaskedTextBox, ByVal T1 As TextBox, ByVal arr2() As MaskedTextBox, ByVal T2 As TextBox)

        Dim Child As MaskedTextBox
        Dim TotalMarks As Double = 0
        Dim TotalPercent As Double = 0
        Dim i As Integer
        i = 0

        For Each Child In arr1
            TotalMarks = TotalMarks + Val(Child.Text)
        Next

        For Each Child In arr2
            If Child.Text <> "" Then
                TotalPercent = TotalPercent + Val(Child.Text)
                i = i + 1
            End If
        Next

        T1.Text = TotalMarks.ToString()
        T2.Text = FormatNumber(TotalPercent / i, 2).ToString()

    End Sub

    Public Sub FillCombo(ByVal Cmb() As ComboBox, ByVal T As String, ByVal F As String)
        DSet = Package.ExeCmd("SELECT * FROM " + T + "")

        For i = 0 To Cmb.Count - 1
            Cmb(i).DataSource = DSet.Tables(0)
            Cmb(i).DisplayMember = F
        Next
    End Sub

    Public Sub ClearControls(ByVal Frm As Form)
        For Each ctrl As Control In Frm.Controls.OfType(Of GroupBox)().OrderBy(Function(t) t.TabIndex)
            For Each child As Control In ctrl.Controls.OfType(Of Object)().OrderBy(Function(t) t.TabIndex)
                If TypeOf child Is TextBox Or TypeOf child Is ComboBox Or TypeOf child Is MaskedTextBox Or TypeOf child Is RichTextBox Then
                    child.Text = ""
                End If
            Next
        Next
    End Sub

    Public Sub CountRegPla(ByVal L() As Label, ByVal Query As String)

        DSet = Package.ExeCmd(Query)

        If Not DSet.Tables(0).Rows.Count = 0 Then
            For i = 0 To DSet.Tables(0).Rows.Count - 1
                L(i).Text = DSet.Tables(0).Rows(i).ItemArray(0).ToString()
            Next
        Else
            For i = 0 To L.Count - 1
                L(i).Text = ""
            Next
        End If

    End Sub

    Public Function BlankControl(ByVal Frm As Form) As Boolean

        For Each Ctrl As Control In Frm.Controls
            If TypeOf Ctrl Is GroupBox Then
                For Each Child As Control In Ctrl.Controls
                    If TypeOf Child Is TextBox Or TypeOf Child Is ComboBox Or TypeOf Child Is RichTextBox Or TypeOf Child Is MaskedTextBox Then
                        If Child.Text = Nothing Then
                            BlankControl = True
                            Exit Function
                        End If
                    End If
                Next
            End If
        Next

    End Function

End Module