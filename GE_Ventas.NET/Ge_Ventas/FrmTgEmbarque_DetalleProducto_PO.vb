Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_DetalleProducto_PO
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private ColEmpresa As Color

    Public sNum_Embarque, sSec_Embarque As String
    Public sAccion As String
    Private Const K_strColCheck As String = "SEL"

    Private Sub FrmTgEmbarque_DetalleProducto_PO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa

        Me.ActiveControl = txtPO
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC VENTAS_MUESTRA_DETALLE_PO "
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE		= '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD		= '{0}'", txtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO		= '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ORDPRO		= '{0}'", Trim(txtCod_OrdPro.Text))

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

                    With .Columns("PO")
                        .Width = 80
                    End With

                    With .Columns("COD_LOTPURORD")
                        .Caption = "LOTE"
                        .Width = 80
                    End With

                    With .Columns("COD_LOTPURORD")
                        .Caption = "LOTE"
                        .Width = 80
                    End With

                    With .Columns("COD_ESTCLI")
                        .Caption = "COD ESTILO CLIENTE"
                        .Width = 80
                    End With

                    With .Columns("ORDENES")
                        .Width = 80
                    End With

                    With .Columns("EXFACTORY_REPROGRAMADA")
                        .Caption = "EX FACTORY REPROGRAMADA"
                        .Width = 100
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

                    With .Columns("COD_CLIENTE")
                        .Caption = "CODIGO CLIENTE"
                        .Width = 70
                    End With

                    With .Columns("DESTINO")
                        .Width = 80
                    End With

                    With .Columns("LOCACION")
                        .Width = 80
                    End With
                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtPO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPO.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtCod_OrdPro.Select()
        End If
    End Sub

    Private Sub txtCod_OrdPro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_OrdPro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtCod_OrdPro.Text.Trim <> "" Then
                txtCod_OrdPro.Text = RellenaDeCerosEnIzquierda(txtCod_OrdPro.Text, 5)
            End If
            BtnBuscar.Select()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "PROCESAR"
                    Call ProcesarDatos
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ProcesarDatos()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub
            Dim Contador As Integer = 0
            If GridEX1.GetCheckedRows.Length Then
                If (MessageBox.Show("¿Esta seguro de realizar esta accion ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
                    For Each oGridEXRow As GridEXRow In GridEX1.GetCheckedRows

                        strSQL = "EXEC TG_EMBARQUE_PRODUCTOS_MAN"
                        strSQL &= vbNewLine & String.Format(" @accion           = '{0}'", sAccion)
                        strSQL &= vbNewLine & String.Format(",@num_embarque     = '{0}'", sNum_Embarque)
                        strSQL &= vbNewLine & String.Format(",@Sec_Embarque     = '{0}'", sSec_Embarque)
                        strSQL &= vbNewLine & String.Format(",@Cod_Cliente      = '{0}'", oGridEXRow.Cells("cod_cliente").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_PurOrd       = '{0}'", oGridEXRow.Cells("po").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_LotPurOrd    = '{0}'", oGridEXRow.Cells("COD_LOTPURORD").Value)
                        strSQL &= vbNewLine & String.Format(",@Cod_Estcli       = '{0}'", oGridEXRow.Cells("COD_ESTCLI").Value)
                        strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)
                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            Contador = Contador + 1
                        End If
                    Next

                    If Contador > 0 Then
                        MessageBox.Show("Proceso realizado correctamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
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