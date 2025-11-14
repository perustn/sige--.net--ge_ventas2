Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMT
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Dim Envio As New EnvioTrama

    Private Sub FrmDocumentoVentaExportacion_GenFacturasGuiasCMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel5.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Cn_Ventas_Facturas_CMT"
            strSQL &= vbNewLine & String.Format("@num_corre  = '{0}'", txtCorrelativo.Text)

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

                    .Columns("cod_cliente").Visible = False
                    .Columns("nom_cliente").Width = 210
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "PROCESAR"
                    If MessageBox.Show("¿Está seguro de procesar información?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                        Dim Flg_Evento_Parametrizable_GR_CMT_Desde_GR_STN As String
                        Flg_Evento_Parametrizable_GR_CMT_Desde_GR_STN = oHP.DevuelveDato("select DBO.sm_valida_Tg_Eventos_Parametrizables(364)", cCONNECT)

                        If Flg_Evento_Parametrizable_GR_CMT_Desde_GR_STN = "S" Then
                            strSQL = String.Empty
                            strSQL &= vbNewLine & "EXEC Ventas_Distribuye_por_Partida_Actualzia_GR_CMT_Desde_GR_Exportacion_STN"
                            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", txtCorrelativo.Text)
                            strSQL &= vbNewLine & String.Format(",@opcion       = '{0}'", "1")
                            strSQL &= vbNewLine & String.Format(",@Cod_Usuario  = '{0}'", vusu)
                            strSQL &= vbNewLine & String.Format(",@Flg_Facturacion_Automatica  = '{0}'", "S")
                            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                                CargarGrilla()
                            End If
                        Else
                            strSQL = String.Empty
                            strSQL &= vbNewLine & "EXEC Ventas_Distribuye_por_Partida"
                            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", txtCorrelativo.Text)
                            strSQL &= vbNewLine & String.Format(",@opcion       = '{0}'", "1")
                            strSQL &= vbNewLine & String.Format(",@Cod_Usuario  = '{0}'", vusu)
                            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                                CargarGrilla()
                            End If
                        End If
                    End If

                Case "GENERARFACT"
                    If oHP.DevuelveDato("select dbo.Cn_Ventas_ValidaExisteFacturaCompraRelacionada('" & GrdDatos.GetValue(GrdDatos.RootTable.Columns("factura_cmt").Index) & "')", cCONNECT) = "S" Then
                        MessageBox.Show("Factura CMT tiene factura relacionada STN, verificar con Contabilidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    End If
                    Using oAdd As New FrmDocumentoVentaExportacion_GenFacturasGuiasCMTAdd
                        With oAdd
                            .TxtNroCorrelativo.Text = txtCorrelativo.Text
                            .scliente = GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_cliente").Index)
                            .sPO = GrdDatos.GetValue(GrdDatos.RootTable.Columns("po").Index)
                            .sEstiloCliente = GrdDatos.GetValue(GrdDatos.RootTable.Columns("EstiloCliente").Index)
                            .txtGuia.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("num_guia_cmt").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "VERFACTURA"
                    Using oVer As New FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact
                        With oVer
                            .TxtNroCorrelativo.Text = Me.txtCorrelativo.Text
                            .TxtPO.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("po").Index)
                            .TxtEstilo.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("estilocliente").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "IMPGUIAMEC"
                    Using oVer As New FrmDocumentoVentaExportacion_GenFacturasGuiasCMTMec
                        With oVer
                            .TxtNroCorrelativo.Text = Me.txtCorrelativo.Text
                            .TxtPO.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("po").Index)
                            .TxtEstilo.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("estilocliente").Index)
                            .TxtCodCli.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_cliente").Index)
                            .CantidadGuias
                            .ShowDialog()
                        End With
                    End Using

                Case "IMPGUIAELEC"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    DTPicker1.Value = Now.Date
                    TxtSerie_Electronica.Text = ""
                    TxtNumero_Electronico.Text = ""

                    LblPO.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("po").Index)
                    LblEstilo.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("estilocliente").Index)
                    LblCodCliente.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("cod_cliente").Index)

                    Frm_Guia_Electronica.Visible = True
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TxtSerie_Electronica_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerie_Electronica.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaSerie()
        End If
    End Sub

    Private Sub TxtNumero_Electronico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero_Electronico.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaSerie()
        End If
    End Sub

    Public Sub BuscaSerie()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "EXEC SP_MUESTRA_SERIE_ELECTRONICA_CMT_CONFECCION"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("SERIE")
            Descripcion = oTipo.dtResultados.Rows(0)("NUMERO")
        End If

        If Codigo <> "" Then
            TxtSerie_Electronica.Text = Trim(Codigo)
            TxtNumero_Electronico.Text = Trim(Descripcion)
            BtnAceptar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Dim url As String
        Dim scadena As String

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Genera_Guia_Despacho_CMT_STN_Estilo_PO_Electronica"
        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", txtCorrelativo.Text)
        strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", LblCodCliente.Text)
        strSQL &= vbNewLine & String.Format(",@COD_PURORD   = '{0}'", LblPO.Text)
        strSQL &= vbNewLine & String.Format(",@COD_ESTCLI   = '{0}'", LblEstilo.Text)
        strSQL &= vbNewLine & String.Format(",@FECHA_EMI    = '{0}'", DTPicker1.Value.ToShortDateString)
        strSQL &= vbNewLine & String.Format(",@SERIE        = '{0}'", TxtSerie_Electronica.Text)
        strSQL &= vbNewLine & String.Format(",@NUMERO       = '{0}'", TxtNumero_Electronico.Text)
        scadena = oHP.DevuelveDato(strSQL, cCONNECT)

        If Trim(scadena) = "" Then
            MessageBox.Show("Cadena vacia..!!", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
            scadena = scadena + "/"

            Dim Datos As String = scadena
            url = "http://192.168.30.4:5002/ca4xml" '"http://192.168.30.9:5001/ca4xml"
            Dim docid As String = "FF12-001"
            Dim comando As String = "emitir"
            Dim parametro As String = ""
            Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
            If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC SP_ACTUALIZA_CORRELATIVO_GUIA_ELECTORNICA_CMT"
                strSQL &= vbNewLine & String.Format(",@SERIE        = '{0}'", TxtSerie_Electronica.Text)
                strSQL &= vbNewLine & String.Format(",@NUMERO       = '{0}'", TxtNumero_Electronico.Text)
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
                oHP.EjecutaOperacion(strSQL, cCONNECT)
                MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Frm_Guia_Electronica.Visible = False
    End Sub
End Class