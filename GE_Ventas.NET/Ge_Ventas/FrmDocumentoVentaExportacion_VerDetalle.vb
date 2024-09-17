Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_VerDetalle
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Private Sub FrmDocumentoVentaExportacion_VerDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Detalle_Factura_Prendas"
            strSQL &= vbNewLine & String.Format("@Num_Corre  = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 30
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("CODIGO").Width = 90
                    .Columns("CODIGO").Caption = "CODIGO"
                    .Columns("ARTICULO").Width = 120
                    .Columns("ARTICULO").Caption = "ARTICULO"
                    .Columns("CANTIDAD").Width = 76
                    .Columns("CANTIDAD").Caption = "CANTIDAD"
                    .Columns("UNI_MED").Width = 78
                    .Columns("UNI_MED").Caption = "UNI MED"
                    .Columns("VALOR_UNITARIO").Width = 112
                    .Columns("VALOR_UNITARIO").Caption = "VALOR UNITARIO"
                    .Columns("VALOR_VENTA").Width = 100
                    .Columns("VALOR_VENTA").Caption = "VALOR VENTA"
                    .Columns("NUM_CORRE").Visible = False
                    .Columns("SECUENCIA").Visible = False
                    .Columns("ORIGEN").Visible = False
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmDocumentoVentaExportacion_VerDetalle_Add
                        With oAdd
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .LabelSec.Visible = False
                            .TxtSec.Visible = False
                            .strNum_Corre_Detalle = TxtNroCorrelativo.Text
                            .IntSencuencia = 0
                            .StrOption = "I"
                            .txtCantidad.Text = oHP.DevuelveDato("select isnull(sum(num_prendas), 0) from cn_ventas_prendas where num_corre = '" & TxtNroCorrelativo.Text & "'", cCONNECT)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oMod As New FrmDocumentoVentaExportacion_VerDetalle_Add
                        With oMod
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .TxtSec.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index)
                            .strNum_Corre_Detalle = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Num_Corre").Index)
                            .IntSencuencia = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index)
                            .StrOption = "U"
                            .strNum_Corre_Detalle = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Num_Corre").Index)
                            .txtDescripcion.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Articulo").Index)
                            .txtDescripcion_CliExt.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Articulo_ClienteExt").Index)
                            .txtCantidad.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Cantidad").Index)
                            .txtImp_Unitario.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Valor_Unitario").Index)
                            .txtImp_Total.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Valor_Venta").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdDatos.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está seguro de eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Up_Man_Detalle_Nuevo"
                        strSQL &= vbNewLine & String.Format(" @StrOption    = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@Num_Corre    = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@Secuencia    =  {0} ", Val(GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index)))

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("Se eliminó correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                        End If
                    End If

                Case "PESOS"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oReg As New FrmDocumentoVentaExportacion_VerDetalle_RegPesos
                        With oReg
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .TxtSec.Text = Val(GrdDatos.GetValue(GrdDatos.RootTable.Columns("secuencia").Index))
                            .txtPeso_Bruto.Text = IIf(IsDBNull(GrdDatos.GetValue(GrdDatos.RootTable.Columns("PESO_BRUTO").Index)), 0, GrdDatos.GetValue(GrdDatos.RootTable.Columns("PESO_BRUTO").Index))
                            .txtPeso_Neto.Text = IIf(IsDBNull(GrdDatos.GetValue(GrdDatos.RootTable.Columns("PESO_NETO").Index)), 0, GrdDatos.GetValue(GrdDatos.RootTable.Columns("PESO_NETO").Index))
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdDatos.Row = FilaSeleccionada
                            End If
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Function ifValidaDoc() As Boolean
        Dim strMsg As String
        strMsg = oHP.DevuelveDato("Select dbo.ventas_Valida_Documento_Manuales_Det('" & TxtNroCorrelativo.Text & "')", cCONNECT)
        If strMsg <> "" Then
            MessageBox.Show(strMsg, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ifValidaDoc = False
            Exit Function
        End If
        ifValidaDoc = True
    End Function
End Class