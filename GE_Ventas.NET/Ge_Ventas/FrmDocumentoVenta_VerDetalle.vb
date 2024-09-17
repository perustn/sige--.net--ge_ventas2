Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_VerDetalle
    Private strSQL As String = String.Empty
    Private strSQLTraza As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sDOCUMENTO As String
    Public strCod_TipDoc As String

    Private Sub FrmDocumentoVenta_VerDetalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdLista
    End Sub

    Public Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Muestra_Detalle_Factura_Items"
        strSQL &= vbNewLine & String.Format(" @Num_Corre       = '{0}'", TxtNroCorrelativo.Text)
        strSQLTraza = strSQL

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdLista.DataSource = oDT
        CheckLayoutGridEx(GrdLista)

        With GrdLista
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                .Columns("T").Width = 24
                .Columns("CODIGO").Width = 145
                .Columns("CODIGO").Caption = "CODIGO"
                .Columns("ARTICULO").Width = 200
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
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    If Not ifValidaDoc() Then Exit Sub
                    If strCod_TipDoc = "NC" Or strCod_TipDoc = "ND" Then
                        Using oAsig As New FrmDocumentoVenta_VerDetalleAddAsigNotas    'frmAdicionaDetalleDocumAsigNotas
                            With oAsig
                                .Text = "Adicion " + Me.Text
                                .strNum_Corre_Ori = TxtNroCorrelativo.Text
                                .ShowDialog()
                            End With
                        End Using
                    Else
                        Using oAd2 As New FrmDocumentoVenta_VerDetalleAdd   'frmAdicionaDetalleDocum
                            With oAd2
                                .Text = "Adicion " + Me.Text
                                .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                                .strNum_Corre_Detalle = TxtNroCorrelativo.Text
                                .IntSencuencia = 0
                                .StrOption = "I"
                                If .ShowDialog = DialogResult.OK Then
                                    CARGA_GRID()
                                End If
                            End With
                        End Using
                    End If

                Case "MODIFICAR"
                    If GrdLista.RowCount = 0 Then Exit Sub

                    If Not ifValidaDoc() Then Exit Sub

                    Using oMod As New FrmDocumentoVenta_VerDetalleAdd
                        With oMod
                            .Text = "Modificar " + Me.Text
                            .strNum_Corre_Detalle = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .IntSencuencia = GrdLista.GetValue(GrdLista.RootTable.Columns("Secuencia").Index)
                            .StrOption = "U"
                            .strNum_Corre_Detalle = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .txtTip_Item.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("T").Index)
                            .txtCod_Producto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Codigo").Index)
                            .TxtDescripcion.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Articulo").Index)
                            .txtDescripcion_Agrup.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Descripcion_Agrupador").Index)
                            .txtCantidad.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Cantidad").Index)
                            .txtUnida_Medida.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Uni_Med").Index)
                            .txtImp_Unitario.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Valor_Unitario").Index)
                            .txtImp_Total.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Valor_Venta").Index)
                            .txtPorc_Commision.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Porcentaje_Commision").Index)
                            .txtCantUniAlter.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Cantidad_Item_NC_ND").Index)
                            .strNum_Corre_Doc_Asig = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre_Original_NCNC").Index)
                            .IntSencuencia_Doc_Asig = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Secuencia_OriginalNCND").Index)
                            .txtDescripcion_CliExt.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Descripcion_Cliente").Index)
                            If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("T").Index)) = "P" Then
                                .cmdBuscar.Visible = True
                            Else
                                .cmdBuscar.Visible = False
                            End If
                            If .ShowDialog = DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    If Not ifValidaDoc Then Exit Sub

                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Está Seguro de Eliminar este Registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Up_Man_Detalle"
                        strSQL &= vbNewLine & String.Format(" @StrOption    = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@Num_Corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@Secuencia    =  {0} ", GrdLista.GetValue(GrdLista.RootTable.Columns("Secuencia").Index))

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            CARGA_GRID()
                        End If
                    End If

                Case "AJUSIMP"
                    If GrdLista.RecordCount = 0 Then Return
                    Using oAjsu As New FrmDocumentoVenta_VerDetalleAjusteImp
                        With oAjsu
                            .NroCorrelativo = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .TxtSEc.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Secuencia").Index)
                            .txtImporteTotal.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Valor_Venta").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CARGA_GRID()
                            End If
                        End With
                    End Using

                Case "IMPRIMIR"
                    Dim oo As Object
                    Dim sRutaLogo As String, sTitulo As String, ruta As String

                    If GrdLista.RowCount > 0 Then
                        sTitulo = Trim(sDOCUMENTO) & " : " & Trim(TxtNroCorrelativo.Text)

                        If MessageBox.Show("Desea imprimir usando Microsoft Excel?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            oo = CreateObject("excel.application")
                            oo.Workbooks.Open(vRuta & "\RptDetalleDeDocumentoV2.XLT")
                            oo.DisplayAlerts = False
                            oo.Visible = True
                            strSQL = "SELECT Ruta_Logo From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
                            sRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)
                            sRutaLogo = CStr(IIf(IsDBNull(sRutaLogo), "", sRutaLogo))
                            oo.Run("REPORTE", CStr(sRutaLogo), strSQLTraza, cCONNECTVB6, sTitulo)
                        Else
                            ruta = vRuta & "\RptDetalleDeDocumento.OTS"
                            oo = CreateObject("ooBusiness.Calc")
                            oo.OfficeTemplateSheet = ruta
                            oo.OfficeDocumentSheet = Replace(ruta, ".OTS", Format(Now, "YYYYMMDDHHMMSSMM") & ".ods")
                            oo.MacroLibraryName = "Library1"
                            oo.MacroModuleName = "Module1"
                            oo.MacroName = "Reporte"
                            strSQL = "SELECT Des_Empresa From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
                            sRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)
                            sRutaLogo = CStr(IIf(IsDBNull(sRutaLogo), "", sRutaLogo))
                            oo.Run(CStr(sRutaLogo), strSQLTraza, sTitulo, cCONNECTVB6)
                        End If
                        oo = Nothing
                    Else
                        MessageBox.Show("No se han encontrado datos para imprirmir....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    Exit Sub
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function ifValidaDoc() As Boolean
        Dim strMsg As String
        strMsg = oHP.DevuelveDato("Select dbo.ventas_Valida_Documento_Manuales_Det('" & TxtNroCorrelativo.Text & "')", cCONNECT)
        If strMsg <> "" Then
            MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ifValidaDoc = False
            Exit Function
        End If
        ifValidaDoc = True
    End Function

End Class