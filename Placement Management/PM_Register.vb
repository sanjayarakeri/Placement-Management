Imports System.Data.OleDb
Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel

Public Class PM_Register

    Dim Dset, DDSet As DataSet
    Dim str As String
    Dim Index As Integer
    Dim Tick As Integer

   Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BSave.Click
        If BTM.Text = "" Or BAP.Text = "" Or USN.Text = "" Or SName.Text = "" Or DOB.Text = "" Or Branch.Text = "" Or Address.Text = "" Or ContNo.Text = "" Or SSLC.Text = "" Or PUCOrDIP.Text = "" Or Batch.Text = "" Then
            Message.Text = " Warning : Fill Blank Fields ! "
            Timer.Start()
            Exit Sub
        End If
        Dset = Package.ExeCmd("SELECT USN FROM StudentMaster WHERE USN='" + Trim(USN.Text) + "'")
        If Dset.Tables(0).Rows.Count = 1 Then
            Message.Text = " Warning : " + USN.Text + " Already Exist ! "
            Timer.Start()
            Exit Sub
        End If

        Dset = Package.ExeCmd("INSERT INTO StudentMaster VALUES('" + USN.Text + "','" + SName.Text + "','" + DOB.Text + "','" + Branch.Text + "','" + Batch.Text + "','" + Address.Text + "','" + ContNo.Text + "','" + Email.Text + "','" + POrD.Text + "','" + SSLC.Text + "','" + PUCOrDIP.Text + "','" + BMS1.Text + "','" + BPS1.Text + "','" + BMS2.Text + "','" + BPS2.Text + "','" + BMS3.Text + "','" + BPS3.Text + "','" + BMS4.Text + "','" + BPS4.Text + "','" + BMS5.Text + "','" + BPS5.Text + "','" + BMS6.Text + "','" + BPS6.Text + "','" + BMS7.Text + "','" + BPS7.Text + "','" + BMS8.Text + "','" + BPS8.Text + "','" + BackLogs.Text + "','" + BTM.Text + "','" + BAP.Text + "','" + Company.Text + "','" + Salary.Text + "','" + Company.Text + "','" + Salary.Text + "')")

        Message.Text = " Success : " + USN.Text + " Saved "
        Timer.Start()
        Me.PM_Register_Load(Nothing, Nothing)
    End Sub
   
    Private Sub BtnEquals_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEquals.Click
         If POrD.Text = "P" Then
            Dim T1() As MaskedTextBox = {BMS3, BMS4, BMS5, BMS6, BMS7, BMS8}
            Dim T2() As MaskedTextBox = {BPS3, BPS4, BPS5, BPS6, BPS7, BPS8}
            Package.CalculateTotal(T1, Me.BTM, T2, Me.BAP)
        ElseIf POrD.Text = "D" Then
            Dim T3() As MaskedTextBox = {BMS1, BMS2, BMS3, BMS4, BMS5, BMS6, BMS7, BMS8}
            Dim T4() As MaskedTextBox = {BPS1, BPS2, BPS3, BPS4, BPS5, BPS6, BPS7, BPS8}
            Package.CalculateTotal(T3, Me.BTM, T4, Me.BAP)
        End If
    End Sub

    Private Sub BMS1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS1.TextChanged
        Package.CalculatePercent(BMS1, BPS1, 775)
    End Sub

    Private Sub BMS2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS2.TextChanged
        Package.CalculatePercent(BMS2, BPS2, 775)
    End Sub

    Private Sub BMS3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS3.TextChanged
        Package.CalculatePercent(BMS3, BPS3, 900)
    End Sub

    Private Sub BMS4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS4.TextChanged
        Package.CalculatePercent(BMS4, BPS4, 900)
    End Sub

    Private Sub BMS5_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS5.TextChanged
        Package.CalculatePercent(BMS5, BPS5, 900)
    End Sub

    Private Sub BMS6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS6.TextChanged
        Package.CalculatePercent(BMS6, BPS6, 900)
    End Sub

    Private Sub BMS7_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS7.TextChanged
        Package.CalculatePercent(BMS7, BPS7, 900)

    End Sub

    Private Sub BMS8_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles BMS8.TextChanged
        Package.CalculatePercent(BMS8, BPS8, 750)
    End Sub

    Private Sub PM_Register_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DDGrid.Rows.Clear()
        Package.ClearControls(Me)
        Dim C1() As ComboBox = {Batch, SBatch, RPBatch}
        FillCombo(C1, "Batches", "Batch")
        Dim C2() As ComboBox = {Branch, SBranch}
        FillCombo(C2, "Branches", "BranchName")
        Dset = Package.ExeCmd("SELECT Batch  FROM Batches")
        DGrid.DataSource = Dset.Tables(0)
    End Sub

    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If TxtBatchYear.Text = "" Then
            Message.Text = " Warning!: Enter The Batch "
            Timer.Start()
        Else
            Dset = Package.ExeCmd("SELECT * FROM Batches WHERE Batch='" + TxtBatchYear.Text + "'")
            If Dset.Tables(0).Rows.Count = 1 Then
                Message.Text = " Warning!: Record Already Exist "
                Timer.Start()
            Else
                Dset = Package.ExeCmd("INSERT INTO Batches VALUES('" + TxtBatchYear.Text + "')")
                Message.Text = " Record Added Successfully "
                Timer.Start()
            End If
        End If
        Me.PM_Register_Load(Nothing, Nothing)
    End Sub

    Private Sub BtnExpToExcelBatch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExpToExcelBatch.Click
        Dim str() As String = {"USN", "Student Name", "DOB", "Branch", "Batch", "Address", "Contact No", "Email", "PUC/DIP", "SSLC %", "PUC/DIP %", "Sem1 Marks", "Sem1 %", "Sem2 Marks", "Sem2 %", "Sem3 Marks", "Sem3 %", "Sem4 Marks", "Sem4 %", "Sem5 Marks", "Sem5 %", "Sem6 Marks", "Sem6 %", "Sem7 Marks", "Sem7 %", "Sem8 Marks", "Sem8 %", "BackLogs", "Total Marks", "Aggregate %", "Company Name", "Salary", "Company Name", "Salary"}
        ExportToExcel("SELECT * FROM StudentMaster WHERE Branch='" + SBranch.Text + "' AND Batch='" + SBatch.Text + "' ORDER BY USN", str)
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ExportToExcel(ByVal Query As String, ByVal str() As String)
        Dset = Package.ExeCmd(Query)
        Dim xlapp As Excel.Application
        Dim xlworkbook As Excel.Workbook
        Dim xlworksheet As Excel.Worksheet
        Dim misvalue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim x As Integer
        xlapp = New Excel.Application
        xlworkbook = xlapp.Workbooks.Add(misvalue)
        xlworksheet = xlworkbook.Sheets("Sheet1")

        With xlworksheet
            .Rows().Font.FontStyle = "Bold"
            .Rows().Font.Size = 10
            .Cells.Columns.AutoFit()
            .Cells.Select()
            .Cells.EntireColumn.AutoFit()
        End With

        For x = 0 To str.Length - 1
            xlworksheet.Cells(0 + 1, x + 1) = str(x)
            xlworksheet.Columns().AutoFit()
        Next

        For i = 0 To Dset.Tables(0).Rows.Count - 1
            For j = 0 To Dset.Tables(0).Columns.Count - 1
                xlworksheet.Cells(i + 2, j + 1) = Dset.Tables(0).Rows(i).ItemArray(j).ToString()
                xlworksheet.Columns().AutoFit()
            Next
        Next

        Dim dialog As New SaveFileDialog
        Dim result As DialogResult = dialog.ShowDialog
        Try
            xlworksheet.SaveAs(dialog.FileName)
        Catch exerr As Exception
        End Try

        xlworkbook.Close()
        xlapp.Quit()

        releaseObject(xlapp)
        releaseObject(xlworkbook)
        releaseObject(xlworksheet)

    End Sub

    Private Sub BUPDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BUPDate.Click
        If BTM.Text = "" Or BAP.Text = "" Or USN.Text = "" Or SName.Text = "" Or DOB.Text = "" Or Branch.Text = "" Or Address.Text = "" Or ContNo.Text = "" Or SSLC.Text = "" Or PUCOrDIP.Text = "" Or Batch.Text = "" Then
            Message.Text = " Warning : Fill Blank Fields ! "
            Timer.Start()
            Exit Sub
        End If
        Dset = Package.ExeCmd("UPDATE StudentMaster SET SName='" + SName.Text + "',DOB='" + DOB.Text + "',Branch='" + Branch.Text + "', Batch='" + Batch.Text + "', Address='" + Address.Text + "', ContactNo='" + ContNo.Text + "', Email='" + Email.Text + "',PUCOrDIP='" + POrD.Text + "',SSLCPer='" + SSLC.Text + "', POrDPer='" + PUCOrDIP.Text + "',BMS1='" + BMS1.Text + "',BPS1='" + BPS1.Text + "',BMS2='" + BMS2.Text + "',BPS2='" + BPS2.Text + "',BMS3='" + BMS3.Text + "',BPS3='" + BPS3.Text + "',BMS4='" + BMS4.Text + "',BPS4='" + BPS4.Text + "',BMS5='" + BMS5.Text + "',BPS5='" + BPS5.Text + "', BMS6='" + BMS6.Text + "', BPS6='" + BPS6.Text + "', BMS7='" + BMS7.Text + "', BPS7='" + BPS7.Text + "',BMS8='" + BMS8.Text + "',BPS8='" + BPS8.Text + "',BLogs='" + BackLogs.Text + "', BMTotal='" + BTM.Text + "', BAggPer='" + BAP.Text + "' WHERE USN='" + USN.Text + "'")
        Message.Text = " Success : " + USN.Text + " Updated "
        Timer.Start()
        PUSN_Validated(Nothing, Nothing)
    End Sub

    Private Sub PUSN_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles PUSN.Validated
        DDGrid.Rows.Clear()
        If PUSN.Text <> "" Then
            Dset = Package.ExeCmd("SELECT USN,SName,FCName,FCSalary,SCName,SCSalary FROM StudentMaster WHERE USN='" + PUSN.Text + "' AND (FCName<>'' OR SCName<>'')")
            If Dset.Tables(0).Rows.Count = 0 Then
                Message.Text = " USN : " + PUSN.Text + " Not Placed In Any Company :"
                Timer.Start()
            Else
                With Dset.Tables(0).Rows(0)
                    If .ItemArray(3).ToString <> "" Then
                        DDGrid.Rows.Add()
                        DDGrid.Rows(0).Cells(0).Value = .ItemArray(0).ToString()
                        DDGrid.Rows(0).Cells(1).Value = .ItemArray(1).ToString()
                        DDGrid.Rows(0).Cells(2).Value = .ItemArray(2).ToString()
                        DDGrid.Rows(0).Cells(3).Value = .ItemArray(3).ToString()
                    End If
                    If .ItemArray(4).ToString <> "" Then
                        DDGrid.Rows.Add()
                        DDGrid.Rows(0).Cells(0).Value = .ItemArray(0).ToString()
                        DDGrid.Rows(0).Cells(1).Value = .ItemArray(1).ToString()
                        DDGrid.Rows(0).Cells(2).Value = .ItemArray(4).ToString()
                        DDGrid.Rows(0).Cells(3).Value = .ItemArray(5).ToString()
                    End If
                    If .ItemArray(3).ToString <> "" And .ItemArray(4).ToString <> "" Then
                        DDGrid.Rows.Clear()
                        DDGrid.Rows.Add()
                        DDGrid.Rows(0).Cells(0).Value = .ItemArray(0).ToString()
                        DDGrid.Rows(0).Cells(1).Value = .ItemArray(1).ToString()
                        DDGrid.Rows(0).Cells(2).Value = .ItemArray(2).ToString()
                        DDGrid.Rows(0).Cells(3).Value = .ItemArray(3).ToString()
                        DDGrid.Rows.Add()
                        DDGrid.Rows(1).Cells(0).Value = .ItemArray(0).ToString()
                        DDGrid.Rows(1).Cells(1).Value = .ItemArray(1).ToString()
                        DDGrid.Rows(1).Cells(2).Value = .ItemArray(4).ToString()
                        DDGrid.Rows(1).Cells(3).Value = .ItemArray(5).ToString()
                    End If
                End With
            End If
        End If
    End Sub

    Private Sub BDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BDelete.Click
        If USN.Text = "" Then
            Message.Text = " Enter The USN First "
            Timer.Start()
            Exit Sub
        End If
        Dim Confirm As DialogResult
        Confirm = MessageBox.Show(" Delete USN No :  " + USN.Text, "SGBIT", MessageBoxButtons.OKCancel)
        If Confirm = System.Windows.Forms.DialogResult.OK Then
            Dset = Package.ExeCmd("DELETE FROM StudentMaster WHERE USN='" + USN.Text + "'")
            Message.Text = " USN : " + USN.Text + " Record Deleted Succesfully "
            Timer.Start()
        End If
    End Sub

    Private Sub BtnExportPlacementStats_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportPlacementStats.Click
        Dim str() As String = {"USN", "Student Name", "DOB", "Branch", "Batch", "Address", "Contact No", "Email", "1St Company Name", "Salary", "2nd Company Name", "Salary"}
        ExportToExcel("SELECT USN,SName,DOB,Branch,Batch,Address,ContactNo,Email,FCName,FCSalary,SCName,SCSalary FROM StudentMaster WHERE Branch='" + SBranch.Text + "' AND Batch='" + SBatch.Text + "' AND FCName<>'' ORDER BY Branch", str)
        ClearControls(Me)
    End Sub

    Private Sub BtnExportCutOffPercentage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExportCutOffPercentage.Click
        Dim str() As String = {"USN", "SName", "Batch", "PUCOrDIP", "SSLCPer", "POrDPer", "BEAggPercentage", "BEBackLogs"}
        ExportToExcel("SELECT USN,SName,Batch,PUCOrDIP,SSLCPer,POrDPer,BAggPer,BLogs FROM StudentMaster WHERE Batch='" + SBatch.Text + "' AND Branch='" + SBranch.Text + "' AND SSLCPer>='" + TxtSSLC.Text + "' AND POrDPer>='" + TxtPUC.Text + "' AND BAggPer>='" + TxtBE.Text + "' ORDER BY SSLCPer,POrDPer,BAggPer", str)
        ClearControls(Me)
    End Sub

    Private Sub PSAVE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PSAVE.Click
        Dset = Package.ExeCmd("SELECT FCName,SCName FROM StudentMaster WHERE USN='" + PUSN.Text + "'")

        If Dset.Tables(0).Rows(0).ItemArray(0).ToString() = "" Then
            Dset = Package.ExeCmd("UPDATE StudentMaster SET FCName='" + Company.Text + "',FCSalary='" + Salary.Text + "' WHERE USN='" + PUSN.Text + "'")
        ElseIf Dset.Tables(0).Rows(0).ItemArray(1).ToString() = "" Then
            Dset = Package.ExeCmd("UPDATE StudentMaster SET SCName='" + Company.Text + "',SCSalary='" + Salary.Text + "' WHERE USN='" + PUSN.Text + "'")
        Else
            Message.Text = "USN : " + PUSN.Text + " Already Placed In Two Companies "
            Timer.Start()
        End If

        PUSN_Validated(Nothing, Nothing)
    End Sub

    Private Sub PUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PUpdate.Click
        If Index = 0 Then
            Dset = Package.ExeCmd("UPDATE StudentMaster SET FCName='" + Company.Text + "',FCSalary='" + Salary.Text + "' WHERE USN='" + PUSN.Text + "'")
            PUSN_Validated(Nothing, Nothing)
        ElseIf Index = 1 Then
            Dset = Package.ExeCmd("UPDATE StudentMaster SET SCName='" + Company.Text + "',SCSalary='" + Salary.Text + "' WHERE USN='" + PUSN.Text + "'")
            PUSN_Validated(Nothing, Nothing)
        End If
    End Sub

    Private Sub PCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCancel.Click
        PM_Register_Load(Nothing, Nothing)
    End Sub

    Private Sub PClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PClose.Click
        Me.Close()
    End Sub

    Private Sub POrD_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles POrD.TextChanged
        If POrD.Text = "P" Then
            BMS1.Enabled = True
            BMS2.Enabled = True
            PD.Text = "PUC"
            Exit Sub
        End If
        If POrD.Text = "D" Then
            BMS1.Enabled = False
            BMS2.Enabled = False
            PD.Text = "DIPLOMA"
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Dset = Package.ExeCmd("DELETE FROM Batches WHERE Batch='" + TxtBatchYear.Text + "'")
        Message.Text = "Batch Deleted Successfully "
        Timer.Start()
        PM_Register_Load(Nothing, Nothing)
    End Sub

    Private Sub DDGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DDGrid.CellContentClick
        Try
            Index = DDGrid.CurrentRow.Index
            PUSN.Text = DDGrid.Item(0, Index).Value
            Company.Text = DDGrid.Item(2, Index).Value
            Salary.Text = DDGrid.Item(3, Index).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RPBatch_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RPBatch.TextChanged
        Dim Reg() As System.Windows.Forms.Label = {R1, R2, R3, R4, R5}
        CountRegPla(Reg, "SELECT COUNT(Batch) FROM StudentMaster WHERE Batch='" + RPBatch.Text + "' GROUP BY  Branch")

        Dim Pla() As System.Windows.Forms.Label = {P1, P2, P3, P4, P5}
        CountRegPla(Pla, "SELECT COUNT(Batch) FROM StudentMaster WHERE Batch='" + RPBatch.Text + "' AND FCName<>'' GROUP BY  Branch")
    End Sub

    Private Sub Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer.Tick
        If Tick = 25 Then
            Message.Text = ""
            Tick = 0
            Timer.Stop()
        End If
        If Message.Visible = True Then
            Message.Visible = False
            Tick += 1
        ElseIf Message.Visible = False Then
            Message.Visible = True
            Tick += 1
        End If
    End Sub

    Private Sub USN_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles USN.Validated
        If USN.Text <> "" Then
            Dset = Package.ExeCmd("SELECT * FROM StudentMaster WHERE USN='" + USN.Text + "'")
            If Not Dset.Tables(0).Rows.Count = 0 Then
                Package.Fetch(Me, USN.Text)
            Else
                Message.Text = " Warning! : Record Not Exist "
                Timer.Start()
            End If
        End If
    End Sub

    Private Sub DGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGrid.CellContentClick
        Dim i As Integer = 0
        Try
            i = DGrid.CurrentRow.Index
            TxtBatchYear.Text = DGrid.Item(0, i).Value
            str = TxtBatchYear.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub USN_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USN.TextChanged

    End Sub
End Class