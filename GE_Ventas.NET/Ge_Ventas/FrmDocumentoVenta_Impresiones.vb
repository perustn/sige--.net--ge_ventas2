Public Class FrmDocumentoVenta_Impresiones
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public scoddestino As String, sdesdestino As String, sCodEmbarque As String, sdesembarque As String
    Public SImp_Total As Double, sCod_Tipdoc As String, sCod_Cliente As String, sFlgExp As String
    Dim sFactGuia As String, sCodOrigen As String

    Private Sub FrmDocumentoVenta_Impresiones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = DEVANLAY
    End Sub

    Private Sub DEVANLAY_Click(sender As Object, e As EventArgs) Handles DEVANLAY.Click
        Try
            If sCod_Tipdoc = "FA" Then
                sFactGuia = oHP.DevuelveDato("SELECT FLG_GUIA_FACTURA FROM CN_VENTAS WHERE NUM_CORRE = '" & TxtNroCorrelativo.Text & "'", cCONNECT)

                If sFactGuia = "S" Then
                    Imprimir_FactGuia(TxtNroCorrelativo.Text, sCod_Tipdoc, SImp_Total)
                Else
                    sCodOrigen = oHP.DevuelveDato("SELECT COD_ORIGEN FROM CN_VENTAS WHERE NUM_CORRE = '" & TxtNroCorrelativo.Text & "'", cCONNECT)
                    If sCodOrigen = "4" And oHP.DevuelveDato("SELECT SER_DOCUM FROM CN_VENTAS WHERE NUM_CORRE = '" & TxtNroCorrelativo.Text & "'", cCONNECT) <> "036" Then
                        Imprimir_Muestras(TxtNroCorrelativo.Text, sCod_Tipdoc, SImp_Total)
                    Else

                        Dim sSerie2 As String, sFormSerie2 As String
                        sSerie2 = oHP.DevuelveDato("SELECT SER_DOCUM FROM CN_VENTAS WHERE NUM_CORRE = '" & TxtNroCorrelativo.Text & "'", cCONNECT)
                        sCodOrigen = oHP.DevuelveDato("SELECT COD_ORIGEN FROM CN_VENTAS WHERE NUM_CORRE = '" & TxtNroCorrelativo.Text & "'", cCONNECT)

                        If sSerie2 = "033" And sCodOrigen <> "7" Then
                            Imprimir_Muest_033(TxtNroCorrelativo.Text, sCod_Tipdoc, SImp_Total)
                        Else
                            sFormSerie2 = oHP.DevuelveDato("SELECT RTRIM(FORMATO) FROM CN_VENTAS_SERIES WHERE COD_TIPDOC = '" & sCod_Tipdoc & "' AND SER_DOCUM = '" & sSerie2 & "'", cCONNECT)
                            If Trim(sFormSerie2) <> "" Then
                                Imprimir_FactLoc(TxtNroCorrelativo.Text, sCod_Tipdoc, sFormSerie2)
                            Else
                                Imprimir_Devanlay(TxtNroCorrelativo.Text, sCod_Tipdoc, SImp_Total)
                            End If
                        End If
                    End If
                End If

            ElseIf sCod_Tipdoc = "BV" Then
                Imprimir_Boletas(TxtNroCorrelativo.Text, sCod_Tipdoc)
            Else
                Imprimir_Notas(TxtNroCorrelativo.Text, sCod_Tipdoc)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Imprimir_FactGuia(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String, dbImp_Total As Double)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Factura_Fact_Guia.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre, UCase(EnLetras(Trim(CStr(dbImp_Total)))))
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub Imprimir_Muestras(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String, dbImp_Total As Double)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Factura_Muestras_Man.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre, UCase(EnLetras(Trim(CStr(dbImp_Total)))))
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub Imprimir_Muest_033(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String, dbImp_Total As Double)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Factura_Muestras_033.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre, UCase(EnLetras(Trim(CStr(dbImp_Total)))))
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub Imprimir_FactLoc(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String, ByVal sFormSerie2 As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\" & sFormSerie2)
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre)
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub Imprimir_Devanlay(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String, dbImp_Total As Double)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Factura_Devanlay.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre, UCase(EnLetras(Trim(CStr(dbImp_Total)))))
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub Imprimir_Boletas(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String)
        Dim oo As Object
        Dim sSerie As String, sFormSerie As String

        sSerie = oHP.DevuelveDato("SELECT SER_DOCUM FROM CN_VENTAS WHERE NUM_CORRE = '" & sNum_Corre & "'", cCONNECT)
        sFormSerie = oHP.DevuelveDato("SELECT RTRIM(FORMATO) FROM CN_VENTAS_SERIES WHERE COD_TIPDOC = '" & sCod_Tipdoc & "' AND SER_DOCUM = '" & sSerie & "'", cCONNECT)

        If Trim(sFormSerie) <> "" Then
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\" & sFormSerie)
            oo.Visible = False
            oo.DisplayAlerts = False
            oo.Run("reporte", cCONNECTVB6, sNum_Corre)
            oo = Nothing
        End If
        Exit Sub
    End Sub

    Private Sub Imprimir_Notas(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Factura_Notas.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre)
        oo = Nothing
        Exit Sub
    End Sub

    Private Sub DECLAJURADA_Click(sender As Object, e As EventArgs) Handles DECLAJURADA.Click
        Try
            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptDeclaracionJurada.XLT")
            oo.Visible = False
            oo.DisplayAlerts = False
            oo.Run("reporte", cCONNECT, TxtNroCorrelativo.Text)
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DECLAJURADADVL_Click(sender As Object, e As EventArgs) Handles DECLAJURADADVL.Click
        Try
            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptDeclaracionJuradaDvl.XLT")
            oo.Visible = False
            oo.DisplayAlerts = False
            oo.Run("reporte", cCONNECTVB6, TxtNroCorrelativo.Text)
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub FORMACLIENTE_Click(sender As Object, e As EventArgs) Handles FORMACLIENTE.Click
        If sCod_Tipdoc = "FA" Then
            ImprimirCliente(TxtNroCorrelativo.Text, sCod_Tipdoc)
        Else
            Imprimir_Notas_FC(TxtNroCorrelativo.Text, sCod_Tipdoc)
        End If
    End Sub

    Private Sub ImprimirCliente(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String)
        Try
            Dim oo As Object
            Dim sFormato_Invoice As String
            Dim strSQL As String
            Dim sRutaLogo As String
            strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            sRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            Dim sEmpresa As String
            strSQL = "SELECT Des_Empresa = ISNULL(Des_Empresa, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            sEmpresa = oHP.DevuelveDato(strSQL, cCONNECT)


            sFormato_Invoice = oHP.DevuelveDato("SELECT FORMATO_INVOICE FROM TG_CLIENTE WHERE COD_CLIENTE = '" & sCod_Cliente & "'", cCONNECT)
            oo = CreateObject("excel.application")
            Select Case sCod_Tipdoc
                Case "FA"
                    If sFormato_Invoice = "01" Then
                        oo.Workbooks.Open(vRuta & "\InvoiceV2" & sFormato_Invoice & ".XLT")
                    Else
                        If sFormato_Invoice = "07" Or sFormato_Invoice = "08" Then
                            FraImpFactura.Enabled = True
                            Exit Sub
                        Else
                            oo.Workbooks.Open(vRuta & "\InvoiceV2" & sFormato_Invoice & ".XLT")
                        End If
                    End If
            End Select
            oo.Visible = True
            oo.DisplayAlerts = False

            If sFormato_Invoice = "01" Then
                oo.Run("reporte", cCONNECTVB6, sNum_Corre, sEmpresa, sRutaLogo)
            Else
                oo.Run("reporte", cCONNECTVB6, sNum_Corre, "", "")
            End If
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim oo As Object
            Dim sFormato_Invoice As String

            FraImpFactura.Enabled = False
            sFormato_Invoice = oHP.DevuelveDato("SELECT FORMATO_INVOICE FROM TG_CLIENTE WHERE COD_CLIENTE = '" & sCod_Cliente & "'", cCONNECT)

            oo = CreateObject("excel.application")
            If OptFactCli.Checked = True Then
                oo.Workbooks.Open(vRuta & "\Invoice" & sFormato_Invoice & "1.XLT")
            Else
                oo.Workbooks.Open(vRuta & "\Invoice" & sFormato_Invoice & "2.XLT")
            End If
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("reporte", cCONNECTVB6, TxtNroCorrelativo.Text)
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Imprimir_Notas_FC(ByVal sNum_Corre As String, ByVal sCod_Tipdoc As String)
        Try
            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\Factura_Notas_FC.XLT")
            oo.Visible = False
            oo.DisplayAlerts = False
            oo.Run("reporte", cCONNECTVB6, sNum_Corre, sCod_Tipdoc)
            oo = Nothing
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class