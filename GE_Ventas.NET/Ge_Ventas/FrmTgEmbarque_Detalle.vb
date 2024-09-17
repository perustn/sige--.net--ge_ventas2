Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_Detalle
    Private oHP As New clsHELPER
    Private oDT As New DataTable
    Private ColEmpresa As Color
    Private strSQL As String = String.Empty
    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_Detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = ColEmpresa
        CargaDatos()

    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_Embarques_Prendas_Muestra "
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
                    Dim FilaSeleccionada As Integer
                    FilaSeleccionada = GridEX1.CurrentRow.Position
                    Call Adicionar("U")
                    GridEX1.Row = FilaSeleccionada

                Case "ELIMINAR"
                    Call Adicionar("D")

                Case "LEER"
                    Call LeerPacking()

                Case "VER"
                    Call VerPacking()

                Case "IMPRIMIR"
                    Call Imprimir
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Imprimir()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            Dim oXL As Object
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"
            Dim vnum_embarque As String
            Dim Packing As Integer
            vnum_embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Embarque").Index)

            Packing = oHP.DevuelveDato("select num_packing from TG_Embarque_packing where num_embarque  = '" & vnum_embarque & "'", cCONNECT)

            RouteFileXLT = RouteFileXLT & "\rptPacking_detallado.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, Packing, 0, cCONNECTVB6)
            oXL.UserControl = True

            oXL = Nothing

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub VerPacking()
        If GridEX1.RowCount = 0 Then Exit Sub

        Dim Frm As New FrmTgEmbarque_Detalle_VerPacking
        With Frm
            .sNum_Embarque = sNum_Embarque
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .txtCliente.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NOM_CLIENTE").Index)
            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Sub LeerPacking()
        Dim Frm As New FrmTgEmbarque_Detalle_Packing
        With Frm
            .sNum_Embarque = sNum_Embarque
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Sub Adicionar(sAccion As String)
        Dim Frm As New FrmTgEmbarque_Detalle_Add
        With Frm
            .sNum_Embarque = sNum_Embarque
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            .sSec_Embarque = 0
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
                .txtNum_Prendas_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_PRENDAS_PROG").Index)
                .txtPre_Unitario.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Pre_Unitario").Index)
                .txtNum_Cajas_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Cajas_Prog").Index)
                .txtPeso_Bruto_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Bruto_Prog").Index)
                .txtPeso_Neto_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Neto_Prog").Index)
                .txtCubicaje_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cubicaje_Prog").Index)

                .txtNum_Prendas.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("NUM_PRENDAS").Index)
                .txtNum_Cajas.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Cajas").Index)
                .txtPeso_Bruto.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Bruto").Index)
                .txtPeso_Neto.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Neto").Index)
                .txtCubicaje.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cubicaje").Index)

                .txtarancelaria1.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Partida_Arancelaria").Index)
                .txtarancelaria2.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Sec_Partida_Arancelaria").Index)
                .txtarancelaria3.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Categoria_Internacional").Index)

                .txtCod_OrdPro.Enabled = False
                .txtAbr_Cliente.Enabled = False
                .txtNom_Cliente.Enabled = False
                .txtCod_PurOrd.Enabled = False
                .txtCod_LotPurOrd.Enabled = False
                .txtCod_EstCli.Enabled = False
                .txtarancelaria1.Enabled = False
                .txtarancelaria2.Enabled = False
                .txtarancelaria3.Enabled = False
                .grpOpcion.Enabled = False
            End If

            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class