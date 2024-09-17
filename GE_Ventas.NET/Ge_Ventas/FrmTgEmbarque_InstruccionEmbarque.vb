Imports System.Data.SqlClient
Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_InstruccionEmbarque
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private Const K_strColCheck As String = "SEL"
    Private NumMovimiento As String = String.Empty
    Private colEmpresa As Color
    Dim vlTabla As String = ""
    Dim vlMsj As String = ""

    Private Sub FrmTgEmbarque_InstruccionEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel6.BackColor = colEmpresa

    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        If Trim(txtPO.Text) = "" Then
            MessageBox.Show("Debe ingresar un numero de Po", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtPO.Select()
            Exit Sub
        End If

        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC SP_MUESTRAPACKING_X_PO_INSTRUCCION "
            strSQL &= vbNewLine & String.Format(" @PO		    = '{0}'", txtPO.Text)

            GridEX1.RootTable.Columns.Clear()
            oDT = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains

                With .RootTable
                    .RowHeight = 30
                    .PreviewRow = True
                    .PreviewRowMember = "Observacion"
                    .PreviewRowLines = 4

                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    With .Columns("PACKING")
                        .Width = 60
                    End With

                    With .Columns("PO")
                        .Width = 60
                    End With

                    With .Columns("ESTILO")
                        .Width = 70
                        .TextAlignment = TextAlignment.Empty
                    End With

                    With .Columns("COD_COLOR")
                        .Caption = "CODIGO COLOR"
                        .TextAlignment = TextAlignment.Empty
                        .Width = 60
                    End With

                    With .Columns("Color")
                        .Caption = "COLOR"
                        .Width = 80
                    End With

                    With .Columns("NRO_CAJAS")
                        .Caption = "Nº CAJAS"
                        .Width = 55
                    End With

                    With .Columns("NRO_PRENDAS")
                        .Caption = "Nº PRENDAS"
                        .Width = 65
                    End With

                    With .Columns(K_strColCheck)
                        .Caption = "SEL"
                        .Visible = True
                        .ColumnType = ColumnType.CheckBox
                        .EditType = EditType.CheckBox
                        .ActAsSelector = True
                        .Width = 25
                        .Caption = String.Empty
                    End With

                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnAgregarPacking_Click(sender As Object, e As EventArgs) Handles btnAgregarPacking.Click
        Call AgregarPacking
    End Sub

    Sub AgregarPacking()
        Try
            Dim Dt As DataTable = New DataTable("HPdata")
            Using connection As SqlConnection = New SqlConnection(cCONNECT)
                connection.Open()
                Using cmd As SqlCommand = connection.CreateCommand()
                    Dim transaction As SqlTransaction
                    transaction = connection.BeginTransaction("Gen_Instruccion_Embarque")
                    cmd.Connection = connection
                    cmd.Transaction = transaction
                    cmd.CommandType = CommandType.StoredProcedure
                    Try
                        NumMovimiento = String.Empty

                        Dim vlMsj As String = ""
                        Dim sMsj As SqlParameter
                        Dim sTabla As SqlParameter
                        vlTabla = ""

                        cmd.CommandText = "SP_INSTRUCCION_EMBARQUE_STN_x_PO"

                        For Each oGridEXRow As GridEXRow In GridEX1.GetCheckedRows
                            cmd.Parameters.Add(New SqlParameter("@PACKING", SqlDbType.Int)).Value = oGridEXRow.Cells("PAcking").Value
                            cmd.Parameters.Add(New SqlParameter("@COD_COLCLI", SqlDbType.VarChar, 100)).Value = oGridEXRow.Cells("cod_color").Value
                            cmd.Parameters.Add(New SqlParameter("@OPCION", SqlDbType.Int)).Value = 1
                            cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.VarChar, 150)).Value = oGridEXRow.Cells("PO").Value
                            cmd.Parameters.Add(New SqlParameter("@ESTILO", SqlDbType.VarChar, 150)).Value = oGridEXRow.Cells("ESTILO").Value
                            cmd.Parameters.Add(New SqlParameter("@COLOR", SqlDbType.VarChar, 250)).Value = oGridEXRow.Cells("COLOR").Value

                            sTabla = New SqlParameter("@Tabla", SqlDbType.VarChar, 100)
                            sTabla.Direction = ParameterDirection.Output
                            cmd.Parameters.Add(sTabla).Value = vlTabla


                            sMsj = New SqlParameter("@MSJ", SqlDbType.VarChar, 8000)
                            sMsj.Direction = ParameterDirection.Output
                            cmd.Parameters.Add(sMsj).Value = vlMsj

                            'cmd.ExecuteNonQuery()

                            Dim oDa = New SqlDataAdapter(cmd)
                            oDa.Fill(Dt)

                            If Dt.Rows.Count > 0 Then
                                For Each row As DataRow In Dt.Rows
                                    vlTabla = row(0)
                                    vlMsj = row(1)
                                Next row

                                vlTabla = cmd.Parameters("@Tabla").Value

                                vlMsj = cmd.Parameters("@MSJ").Value
                            End If

                            cmd.Parameters.Clear()
                        Next

                        transaction.Commit()
                        'transaction.Rollback()

                        If Trim(vlMsj) <> "" Then
                            MsgBox(vlMsj, vbCritical, "Mensaje")
                            Exit Sub
                        Else

                            '    If RSReport.RecordCount >= 1 Then
                            GridEX2.DataSource = Dt 'CargarRecordSetDesconectado2(RSReport, cCONNECT)
                            CheckLayoutGridEx(GridEX2)
                            'GridEX2.AllowEdit = True
                            'Dim iCol As Integer
                            'For iCol = 1 To GridEX1.Columns.Count

                            '    GridEX1.Columns(iCol).EditType = jgexEditNone
                            'Next iCol
                            '    End If

                        End If

                        'CargaDatos()
                        'DialogResult = Windows.Forms.DialogResult.OK

                    Catch ex As Exception
                        Try
                            transaction.Rollback()
                        Catch ex2 As Exception
                            MessageBox.Show(ex.Message, "Error al revertir transaccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnQuitarPO_Click(sender As Object, e As EventArgs) Handles btnQuitarPO.Click
        Call QuitarPO
    End Sub

    Sub quitarPO()
        Try
            Using connection As SqlConnection = New SqlConnection(cCONNECT)
                connection.Open()
                Using cmd As SqlCommand = connection.CreateCommand()
                    Dim transaction As SqlTransaction
                    transaction = connection.BeginTransaction("Del_Instruccion_Embarque")
                    cmd.Connection = connection
                    cmd.Transaction = transaction
                    cmd.CommandType = CommandType.StoredProcedure
                    Try
                        NumMovimiento = String.Empty

                        Dim sMsj As SqlParameter
                        Dim sTabla As SqlParameter

                        cmd.CommandText = "SP_INSTRUCCION_EMBARQUE_STN_x_PO"


                        cmd.Parameters.Add(New SqlParameter("@PACKING", SqlDbType.Int)).Value = 0
                        cmd.Parameters.Add(New SqlParameter("@COD_COLCLI", SqlDbType.VarChar, 100)).Value = ""
                        cmd.Parameters.Add(New SqlParameter("@Tabla", SqlDbType.VarChar, 30)).Value = vlTabla
                        cmd.Parameters.Add(New SqlParameter("@OPCION", SqlDbType.Int)).Value = 2
                        cmd.Parameters.Add(New SqlParameter("@PO", SqlDbType.VarChar, 150)).Value = GridEX2.GetValue(GridEX2.RootTable.Columns("PO").Index)
                        cmd.Parameters.Add(New SqlParameter("@ESTILO", SqlDbType.VarChar, 150)).Value = GridEX2.GetValue(GridEX2.RootTable.Columns("STYLES").Index)
                        cmd.Parameters.Add(New SqlParameter("@COLOR", SqlDbType.VarChar, 250)).Value = GridEX2.GetValue(GridEX2.RootTable.Columns("COLOR").Index)

                        sMsj = New SqlParameter("@MSJ", SqlDbType.VarChar, 8000)
                        sMsj.Direction = ParameterDirection.Output
                        cmd.Parameters.Add(sMsj).Value = vlMsj

                        'cmd.ExecuteNonQuery()

                        Dim oDa = New SqlDataAdapter(cmd)
                        Dim Dt As DataTable = New DataTable("HPdata")
                        oDa.Fill(Dt)

                        If Dt.Rows.Count > 0 Then
                            For Each row As DataRow In Dt.Rows
                                vlTabla = row(0)
                                vlMsj = row(1)
                            Next row

                            vlTabla = cmd.Parameters("@Tabla").Value

                            vlMsj = cmd.Parameters("@MSJ").Value
                        End If

                        cmd.Parameters.Clear()

                        transaction.Commit()

                        If Trim(vlMsj) <> "" Then
                            MsgBox(vlMsj, vbCritical, "Mensaje")
                            Exit Sub
                        Else

                            GridEX1.DataSource = Dt
                            CheckLayoutGridEx(GridEX1)

                        End If

                        'transaction.Rollback()

                        CargaDatos()
                        'DialogResult = Windows.Forms.DialogResult.OK

                    Catch ex As Exception
                        Try
                            transaction.Rollback()
                        Catch ex2 As Exception
                            MessageBox.Show(ex.Message, "Error al revertir transaccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub btnGenerarInstruccionEmbarque_Click(sender As Object, e As EventArgs) Handles btnGenerarInstruccionEmbarque.Click
        Call GenerarInstruccionEmbarque
    End Sub

    Sub GenerarInstruccionEmbarque()
        Try
            Dim oXL As Object
            Dim RouteLogo As String
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "App.Run"
            Dim strSQLExcel As String = ""

            strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            RouteLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQLExcel = "SP_INSTRUCCION_EMBARQUE_STN_x_PO 0,'','" & vlTabla & "', 3, '', '', '', ''"

            RouteFileXLT = RouteFileXLT & "\Rpt_Instruccion_Embarque.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, strSQLExcel, cCONNECTVB6, RouteLogo)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPO.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub
End Class