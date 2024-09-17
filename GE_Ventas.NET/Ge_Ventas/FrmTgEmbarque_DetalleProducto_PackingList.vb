Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_DetalleProducto_PackingList
    Private oHP As New clsHELPER
    Private oDT As New DataTable
    Private strSQL As String = String.Empty

    Private ColEmpresa As Color
    Public sNum_Packing, sNum_Embarque, sSec_Embarque As String
    Private Const K_strColCheck As String = "sel"
    Public sAccion As String

    Private Sub FrmTgEmbarque_DetalleProducto_PackingList_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa

        Me.ActiveControl = txtNum_Packing
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC SP_MUESTRA_DETALLE_PRODUCTO_PACKING "
            strSQL &= vbNewLine & String.Format(" @NUM_PACKING		= '{0}'", txtNum_Packing.Text)

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
                            .TextAlignment = TextAlignment.Center
                        End With
                    Next

                    With .Columns("COD_CLIENTE")
                        .Caption = "CODIGO CLIENTE"
                        .Width = 70
                    End With

                    With .Columns("ABRE_CLIENTE")
                        .Caption = "ABR CLIENTE"
                        .Width = 60
                    End With

                    With .Columns("CLIENTE")
                        .Width = 100
                    End With

                    With .Columns("PO")
                        .Width = 70
                        .TextAlignment = TextAlignment.Empty
                    End With

                    With .Columns("LOTE")
                        .Width = 120
                    End With

                    With .Columns("ESTILO")
                        .Width = 70
                        .TextAlignment = TextAlignment.Empty
                    End With

                    With .Columns(K_strColCheck)
                        .Caption = "sel"
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

    Private Sub txtNum_Packing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Packing.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtNum_Packing.Text.Trim = "" Then
                txtNum_Packing.Select()
            Else
                BtnBuscar.Select()
            End If
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "PROCESAR"
                    Call Procesar

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Procesar()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub
            Dim Contador As Integer = 0
            If GridEX1.GetCheckedRows.Length Then
                If (MessageBox.Show("¿Esta Seguro de Realizar Esta Accion?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                    For Each oGridEXRow As GridEXRow In GridEX1.GetCheckedRows

                        strSQL = "EXEC TG_Embarque_Productos_man"
                        strSQL &= vbNewLine & String.Format(" @accion           = '{0}'", sAccion)
                        strSQL &= vbNewLine & String.Format(",@num_embarque     = '{0}'", sNum_Embarque)
                        strSQL &= vbNewLine & String.Format(",@Sec_Embarque     = '{0}'", sSec_Embarque)
                        strSQL &= vbNewLine & String.Format(",@Cod_Cliente      = '{0}'", oGridEXRow.Cells("COD_CLIENTE").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_PurOrd       = '{0}'", oGridEXRow.Cells("PO").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_LotPurOrd    = '{0}'", oGridEXRow.Cells("LOTE").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_Estcli       = '{0}'", oGridEXRow.Cells("ESTILO").Value)
                        strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            Contador = Contador + 1
                        End If

                    Next

                    If Contador > 0 Then
                        MessageBox.Show("Operación se ha realizado Correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DialogResult = Windows.Forms.DialogResult.OK
                    End If
                End If
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class