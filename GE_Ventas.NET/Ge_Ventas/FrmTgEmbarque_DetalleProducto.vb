Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_DetalleProducto
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private ColEmpresa As Color
    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_DetalleProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = ColEmpresa
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty

            strSQL = "EXEC TG_Embarques_Productos_Muestra "
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE		= '{0}'", sNum_Embarque)

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

                    .Columns("NUM_EMBARQUE").Visible = False
                    .Columns("ABR_CLIENTE").Visible = False

                    With .Columns("SEC_EMBARQUE")
                        .Caption = "SEC"
                        .TextAlignment = TextAlignment.Center
                        .Width = 40
                    End With

                    With .Columns("NOM_CLIENTE")
                        .Caption = "CLIENTE"
                        .Width = 170
                    End With

                    With .Columns("COD_PURORD")
                        .Caption = "PO"
                        .Width = 80
                    End With

                    With .Columns("COD_LOTPURORD")
                        .Caption = "LOTE"
                        .TextAlignment = TextAlignment.Center
                        .Width = 50
                    End With

                    With .Columns("COD_ESTCLI")
                        .Caption = "ESTILO CLIENTE"
                        .Width = 90
                    End With

                    With .Columns("SUB")
                        .TextAlignment = TextAlignment.Center
                        .Width = 40
                    End With
                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Call Adicionar("I")

                Case "MODIFICAR"
                    Call Adicionar("U")

                Case "ELIMINAR"
                    Call Adicionar("D")

                Case "ADDPO"
                    Call AdicionarPO_OP()

                Case "ADDPACKING"
                    Call AdicionarPackingList()

                Case "LEERMOVIMIENTO"
                    Call LeerMovimiento
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub LeerMovimiento()
        Dim Frm As New FrmTgEmbarque_DetalleProducto_LeerMovimiento
        With Frm
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .TxtSec.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
            .sNum_Embarque = sNum_Embarque
            .sSec_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)

            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Sub AdicionarPackingList()
        Dim Frm As New FrmTgEmbarque_DetalleProducto_PackingList
        With Frm
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .TxtSec.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
            .sNum_Embarque = sNum_Embarque
            .sSec_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
            .sAccion = "I"
            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Sub AdicionarPO_OP()
        Dim Frm As New FrmTgEmbarque_DetalleProducto_PO
        With Frm
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .TxtSec.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
            .sNum_Embarque = sNum_Embarque
            .sSec_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
            .sAccion = "I"
            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Sub Adicionar(sAccion As String)
        Dim Frm As New FrmTgEmbarque_Detalle_Add
        With Frm
            .ModoGUIImpresion = FrmTgEmbarque_Detalle_Add.ModoVentana.DesdeDetalleProducto
            .sNum_Embarque = sNum_Embarque
            .sSec_Embarque = 0
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .sAccion = sAccion
            If sAccion = "U" Or sAccion = "D" Then
                If GridEX1.RowCount = 0 Then Exit Sub
                .LabelSec.Visible = True
                .TxtSec.Visible = True
                .TxtSec.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
                .sSec_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("SEC_EMBARQUE").Index)
                .txtCod_OrdPro.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("ORDENES").Index)
                .txtAbr_Cliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("ABR_CLIENTE").Index)
                .sCod_Cliente = GridEX1.GetValue(GridEX1.RootTable.Columns("COD_CLIENTE").Index)
                .txtNom_Cliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NOM_CLIENTE").Index)
                .txtCod_PurOrd.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("COD_PURORD").Index)
                .txtCod_LotPurOrd.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("COD_LOTPURORD").Index)
                .txtCod_EstCli.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("COD_ESTCLI").Index)
            End If

            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub
End Class