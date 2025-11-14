Imports System.Data.SqlClient
Imports Janus.Windows
Imports Janus.Windows.GridEX
Imports WinFormsControls

Public Class FrmBandeja_Facturacion006_CMT_Envios
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable

    Public NroCorrelativo As String
    Public PO As String
    Public Estilo As String

    Dim Envio As New EnvioTrama
    Private ds As New DataTable
    Dim vlTabla As String
    Dim vlImportLetra As String
    Dim ST As Double
    Dim igv As Double
    Dim Total As Double
    Dim vlCorrelativo As String

    Dim Resultado_acepta As String = ""

    Public Serie_guia As String
    Public Numero_Doc As String
    Public Ejecutado As Boolean = False

    Private Sub Bandeja_Facturacion006_CMT_Envios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel1.BackColor = colEmpresa
        Panel2.BackColor = colEmpresa

        txtSerie.Text = Serie_guia
        txtNro_Doc.Text = Numero_Doc
        CargarGrilla()
    End Sub

    Sub CargarGrilla()
        Try
            LblCorrelativo.Text = NroCorrelativo
            LblPO.Text = PO
            LblEstilo.Text = Estilo

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MUESTRA_Ventas_Facturas_CMT_Detalle_FE"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE   = '{0}'", NroCorrelativo)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD  = '{0}'", PO)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI  = '{0}'", Estilo)
            strSQL &= vbNewLine & String.Format(",@Fecha       = '{0}'", "")

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
                .FilterMode = FilterMode.None
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

                    .Columns("Descripcion_Adicional").Visible = False
                    .Columns("UN").Visible = False
                    .Columns("Num_Guia").Visible = False
                    .Columns("Factura").Visible = False
                    .Columns("Prendas").Width = 90
                    .Columns("Precio").Width = 90
                    .Columns("Partida").Width = 90
                    .Columns("Fecha").Width = 100
                    .Columns("Valor_Venta").Width = 100
                    .Columns("Total").Width = 100
                    .Columns("Descripcion").Width = 190
                End With
            End With

            If GridEX1.RowCount = 0 Then
                Exit Sub
            End If

            TxtGlosaFinal.Text = "^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^" & Strings.Left(Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ruta").Index)), Len(Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ruta").Index))) - 1) _
                & "^O/S:" & Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Oservicio_CMT").Index)) & "^Descripcion Contiene:PARTIDA,PO,ESTILO"

            TxtGuia.Text = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Guia").Index))
            '^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^(COR),(EST),(COS),(LAV),(PLA),(PEG),(ACA),^O/S: 100-018723^Descripcion Contiene: PARTIDA, PO, ESTILO

            GridEX1.FrozenColumns = 3

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

        Dim Fecha As Date = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Fecha").Index))
        Dim Num_guia As String = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Guia").Index))
        Dim Num_Correlativo As String = LblCorrelativo.Text
        Dim PO As String = LblPO.Text
        Dim Estilo As String = LblEstilo.Text
        Dim vlcadena As String

        For Each oGridEXRow As GridEXRow In GridEX1.GetDataRows
            vlcadena = vlcadena + Strings.Right("        " + Trim(oGridEXRow.Cells("Partida").Value), 8) +
            Strings.Right("                         " + Trim(oGridEXRow.Cells("PO").Value), 25) +
            Strings.Right("                         " + Trim(oGridEXRow.Cells("Estilo_Cliente").Value), 25) +
            Strings.Right("          " + Trim(oGridEXRow.Cells("Prendas").Value), 10) +
            Strings.Right("          " + Trim(oGridEXRow.Cells("Precio").Value), 10) +
            Strings.Right("                                                                                                    " + Trim(oGridEXRow.Cells("Descripcion").Value), 100)
        Next


        'MessageBox.Show(vlcadena, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'Return

        If Len(vlcadena) > 0 Then
            Call Facturar(Serie_guia.Trim, Numero_Doc.Trim, vlcadena, Fecha, TxtGuia.Text.ToString.Trim, TxtGlosaFinal.Text.ToString.Trim, Num_Correlativo, PO, Estilo)
        End If

    End Sub


    Private Sub Facturar(sSerie As String, sNro_Doc As String, vlcadena As String, vFecha As Date, vGuia_CMT As String, vGlosa As String, Num_Corre_up As String, PO_up As String, Estilo_up As String)
        Dim strSQL As String = ""
        Dim vlTabla As String = ""
        Dim vlCorrelativo As String = ""
        Dim Mensaje_SP As String = ""
        Dim ImporteLetras As String = ""


        ' Primera ejecución con OP = C
        strSQL = $"
        DECLARE @CorrelativoDocumento VARCHAR(10) = '',
                @Tabla VARCHAR(30) = '{vlTabla}',
                @ImpLetras VARCHAR(8000) = '{ImporteLetras}',
                @Msj VARCHAR(300) = ''

        EXEC SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA 
            @CodigoTDoc = '01',
            @FechaDocumento = '{vFecha.ToString("dd/MM/yyyy")}',
            @CLICODCLI = '0012',
            @RucCliente = '20376729126',
            @CodigoFPago = '',
            @CodigoMnd = 'PEN',
            @CodigoTGuia = '',
            @CodUbgLocal = '',
            @CodUbgPais = '',
            @NroGuia = '{vGuia_CMT}',
            @SerieDoc = '006',
            @NumDoc = '',
            @TpDocRel = '',
            @NumDocRel = '',
            @PRCCODPRC = '01',
            @IGVCODIGV = '10',
            @DscFinal = '',
            @Modo = 'L',
            @Referencia = '',
            @Item = '0',
            @Partida = '',
            @PO = '',
            @Estilo = '',
            @Descripcion = '{vGlosa}',
            @DscAdc = '',
            @Cantidad = 0,
            @Precio = 0,
            @Cnt = '0',
            @OP = 'C',
            @Usr = '{vusu}',
            @Wks = '{ComputerName()}',
            @trbcod = '1000',
            @tdicod = '6',
            @unmcod = 'NIU',
            @coddocrel = '',
            @PorDet = 0,
            @CtaDet = '',
            @TotalCajas = 0,
            @PesoBruto = 0,
            @PesoNeto = 0,
            @Medidas = 0,
            @Cadena = '{vlcadena}',
            @CorrelativoDocumento = @CorrelativoDocumento OUTPUT,
            @Tabla = @Tabla OUTPUT,
            @ImpLetras = @ImpLetras OUTPUT,
            @Msj = @Msj OUTPUT

        SELECT @CorrelativoDocumento AS CorrelativoDocumento, @Tabla AS Tabla, @Msj AS Msj, @ImpLetras AS ImpLetras"

        Dim dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        If dt.Rows.Count > 0 Then
            vlCorrelativo = dt.Rows(0)("CorrelativoDocumento").ToString().Trim()
            vlTabla = dt.Rows(0)("Tabla").ToString().Trim()
            Mensaje_SP = dt.Rows(0)("Msj").ToString().Trim()
            ImporteLetras = dt.Rows(0)("ImpLetras").ToString().Trim()

            If Mensaje_SP <> "" Then
                'Guarda_Log_SP("SP", sSerie, sNro_Doc, Num_Corre_up, "", Mensaje_SP, "MTX_Carga_Informacion_Fct_CMT_a_STN_SIGE", "")
                Throw New SPException(SerieT:=sSerie, Nro_DocumentoT:=sNro_Doc, Num_CorreT:=Num_Corre_up, cod_ClienteT:="", Mensaje_errorT:=Mensaje_SP, Nombre_SPT:="SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA", flg_muestra:="N")
            End If

            If vlTabla = "" Then
                Throw New SPException(SerieT:=sSerie, Nro_DocumentoT:=sNro_Doc, Num_CorreT:=Num_Corre_up, cod_ClienteT:="", Mensaje_errorT:="VARIABLE OUPUT @TABLA VACIA", Nombre_SPT:="SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA", flg_muestra:="N")
            End If

            If ImporteLetras = "" Then
                Throw New SPException(SerieT:=sSerie, Nro_DocumentoT:=sNro_Doc, Num_CorreT:=Num_Corre_up, cod_ClienteT:="", Mensaje_errorT:="IMPORTE NO FUE GENERADO CORRECTAMENTE", Nombre_SPT:="SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA", flg_muestra:="N")
            End If
        End If




        ' Segunda ejecución con OP = N
        If Not String.IsNullOrEmpty(vlTabla) Then
            strSQL = $"
            DECLARE @CorrelativoDocumento VARCHAR(10) = '{vlCorrelativo}',
                    @Tabla VARCHAR(30) = '{vlTabla}',
                    @ImpLetras VARCHAR(8000) = '{ImporteLetras}',
                    @Msj VARCHAR(300) = ''

            EXEC SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA 
                @CodigoTDoc = '01',
                @FechaDocumento = '{vFecha.ToString("dd/MM/yyyy")}',
                @CLICODCLI = '0012',
                @RucCliente = '20376729126',
                @CodigoFPago = '',
                @CodigoMnd = 'PEN',
                @CodigoTGuia = '',
                @CodUbgLocal = '',
                @CodUbgPais = '',
                @NroGuia = '{vGuia_CMT}',
                @SerieDoc = '006',
                @NumDoc = '',
                @TpDocRel = '',
                @NumDocRel = '',
                @PRCCODPRC = '01',
                @IGVCODIGV = '10',
                @DscFinal = '',
                @Modo = 'L',
                @Referencia = '',
                @Item = '0',
                @Partida = '',
                @PO = '',
                @Estilo = '',
                @Descripcion = '',
                @DscAdc = '',
                @Cantidad = 0,
                @Precio = 0,
                @Cnt = '0',
                @OP = 'N',
                @Usr = '{vusu}',
                @Wks = '{ComputerName()}',
                @trbcod = '1000',
                @tdicod = '6',
                @unmcod = 'NIU',
                @coddocrel = '',
                @PorDet = 0,
                @CtaDet = '',
                @TotalCajas = 0,
                @PesoBruto = 0,
                @PesoNeto = 0,
                @Medidas = 0,
                @Cadena = '',
                @CorrelativoDocumento = @CorrelativoDocumento OUTPUT,
                @Tabla = @Tabla OUTPUT,
                @ImpLetras = @ImpLetras OUTPUT,
                @Msj = @Msj OUTPUT

            SELECT  @Msj AS Msj, @ImpLetras AS ImpLetras, @Tabla AS Tabla, @CorrelativoDocumento AS CorrelativoDocumento"

            Dim dt_ultima As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
            If dt_ultima.Rows.Count > 0 Then
                vlCorrelativo = dt_ultima.Rows(0)("CorrelativoDocumento").ToString().Trim()
                vlTabla = dt_ultima.Rows(0)("Tabla").ToString().Trim()
                Mensaje_SP = dt_ultima.Rows(0)("Msj").ToString().Trim()

                If Mensaje_SP <> "" Then
                    'Guarda_Log_SP("SP", sSerie, sNro_Doc, Num_Corre_up, "", Mensaje_SP, "MTX_Carga_Informacion_Fct_CMT_a_STN_SIGE", "")
                    Throw New SPException(SerieT:=sSerie, Nro_DocumentoT:=sNro_Doc, Num_CorreT:=Num_Corre_up, cod_ClienteT:="", Mensaje_errorT:=Mensaje_SP, Nombre_SPT:="SP_RETORNA_ENVIA_INFORMACION_FACTURA_ACEPTA", flg_muestra:="N")
                Else
                    EnvioCMTFACT006_NEW(vlCorrelativo, Num_Corre_up, PO_up, Estilo_up, sSerie, sNro_Doc)
                End If
            End If
        End If
    End Sub


    Private Sub Guarda_Log_SP(serie As String, nro_doc As String, num_corre As String, sCod_Cliente As String, sMensaje_log As String, sNombre_SP As String, flg_muestra As String)
        Try
            strSQL = ""
            strSQL = $"EXEC SP_GUARDA_LOG '{serie.Trim}','{nro_doc.Trim}','{num_corre.Trim}','{sCod_Cliente.Trim}','{sMensaje_log.Trim}','{sNombre_SP.Trim}','{flg_muestra.Trim}'"
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ObtieneRespuesta_Acepta(serie As String, nro_doc As String, num_corre As String, sCorrelativoFactura As String, sMensaje_acepta As String, status As String)
        Try
            strSQL = ""
            strSQL = $"EXEC SP_GUARDA_TRAZA_ERRORES '{serie.Trim}','{nro_doc.Trim}','{num_corre.Trim}','{sCorrelativoFactura.Trim}','{sMensaje_acepta.Trim}','{status.Trim}'"
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub EnvioCMTFACT006_NEW(Correlativo As String, Num_Corre_Doc As String, PO_doc As String, Estilo_doc As String, Serie_traza As String, Nro_Doc_traza As String)

        Dim url As String
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim vlsCab As String
        Dim vlsDet As String

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxCabeceraFactura_NacionalCMT_005_UBL2_1"
        strSQL &= vbNewLine & String.Format(" @NROMov   = '{0}'", Correlativo)
        strSQL &= vbNewLine & String.Format(",@Tipo     = '{0}'", "F")
        Dim oDt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT, True)
        If oDt.Rows.Count = 0 Then
            'Guarda_Log_SP("SP", Serie_traza, Nro_Doc_traza, Num_Corre_Doc, "", "No se encontro datos para cabecera del comprobante..!!!", "MtxCabeceraFactura_NacionalCMT_005_UBL2_1", "")
            Throw New SPException(SerieT:=Serie_traza, Nro_DocumentoT:=Nro_Doc_traza, Num_CorreT:=Num_Corre_Doc, cod_ClienteT:="", Mensaje_errorT:="No se encontro datos para cabecera del comprobante..!!!", Nombre_SPT:="MtxCabeceraFactura_NacionalCMT_005_UBL2_1", flg_muestra:="S")
        Else
            vlsCab = oDt.Rows(0)(0).ToString
        End If

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxDetalleFactura_Nacional_Dst_STN04_01_UBL2_1"
        strSQL &= vbNewLine & String.Format(" @NROMov   = '{0}'", Correlativo)
        Dim oDTs As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        If oDTs.Rows.Count = 0 Then
            'Guarda_Log_SP("SP", Serie_traza, Nro_Doc_traza, Num_Corre_Doc, "", "El Documento no tiene Detalle", "MtxDetalleFactura_Nacional_Dst_STN04_01_UBL2_1", "")
            Throw New SPException(SerieT:=Serie_traza, Nro_DocumentoT:=Nro_Doc_traza, Num_CorreT:=Num_Corre_Doc, cod_ClienteT:="", Mensaje_errorT:="El Documento no tiene Detalle", Nombre_SPT:="MtxDetalleFactura_Nacional_Dst_STN04_01_UBL2_1", flg_muestra:="S")
        Else
            vlsDet = ""
            For Each dr As DataRow In oDTs.Rows
                vlsDet = (vlsDet + dr(0).ToString)
            Next
            vlsDet = (vlsDet + ("~" + oDTs.Rows(0)(1).ToString))
        End If


        'C   CERTIFICACION	http: //192.168.30.30:5001/ca4xml
        'P	PRODUCCION	http: //192.168.30.4:5002/ca4xml

        Dim Datos As String = (vlsCab + (vlsDet + "/"))
        url = "http://192.168.30.4:5002/ca4xml"
        Dim docid As String = "FF12-001"
        Dim comando As String = "emitir"
        Dim parametro As String = ""
        Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)

        If (respuesta.Substring(0, 2).ToUpper = "OK") Then
            ' ACTUALIZAMOS CAMPOS DE ENVIO DE FACTURA ELECTRONICA.
            Try
                Using oCn As New SqlConnection(cCONNECT)
                    Using oCmd As New SqlCommand("test", oCn)
                        With oCmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "SP_Actualiza_CorrelativoFacturaCMT_005"
                            .Parameters.Add("@Num_Corre", SqlDbType.VarChar, 15).Value = Num_Corre_Doc 'TxtNroCorrelativo.Text
                            .Parameters.Add("@PO", SqlDbType.VarChar, 30).Value = PO_doc 'txtpo.Text
                            .Parameters.Add("@Estilo", SqlDbType.VarChar, 100).Value = Estilo_doc 'TxtEstilo.Text
                            .Parameters.Add("@Correlativo", SqlDbType.VarChar, 30).Value = Correlativo
                            .Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = vusu

                            With .Parameters.Add("@P_MSJ", SqlDbType.VarChar, 8000)
                                .Direction = ParameterDirection.Output
                                .Value = ""
                            End With
                            .Connection.Open()
                            'oDtDetalle.Load(.ExecuteReader)
                            oCmd.ExecuteNonQuery()
                        End With

                        Dim mensajeSP = oCmd.Parameters("@P_MSJ").Value.ToString().Trim()

                        If mensajeSP <> "" Then
                            'SI SE ENVIO LA TRAZA CORRECTAMENTE A ACEPTA , PERO OCURRIO UN PROBELMA AL ACTUALIZAR, SE CAPTURA DIRECTAMENTE EL ERROR EN EL GUARDA_LOG PERO SE EPERMITE EL ENVIO 
                            Guarda_Log_SP(Serie_traza, Nro_Doc_traza, Num_Corre_Doc, "", mensajeSP, "SP_Actualiza_CorrelativoFacturaCMT_005", "S")
                        End If
                    End Using
                End Using

                ObtieneRespuesta_Acepta(Serie_traza, Nro_Doc_traza, Num_Corre_Doc, Correlativo, respuesta, respuesta.Substring(0, 2).ToUpper)

            Catch ex As Exception
                'Guarda_Log_SP("SP", Serie_traza, Nro_Doc_traza, Num_Corre_Doc, "", ex.Message, "SP_Actualiza_CorrelativoFacturaCMT_005", respuesta)
                Throw New SPException(SerieT:=Serie_traza, Nro_DocumentoT:=Nro_Doc_traza, Num_CorreT:=Num_Corre_Doc, cod_ClienteT:="", Mensaje_errorT:=ex.Message, Nombre_SPT:="SP_Actualiza_CorrelativoFacturaCMT_005", flg_muestra:="N")
            End Try
        Else
            If Not String.IsNullOrEmpty(respuesta) Then
                Dim partes = respuesta.Split("|"c)
                If partes.Length > 0 AndAlso Not String.IsNullOrWhiteSpace(partes(0)) Then
                    Resultado_acepta = partes(0).Trim().ToUpper()
                End If
            End If

            ObtieneRespuesta_Acepta(Serie_traza, Nro_Doc_traza, Num_Corre_Doc, Correlativo, respuesta, Resultado_acepta)
        End If

        MessageBox.Show("El envio fue realizada correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Ejecutado = True
        Me.Close()
    End Sub

    Public Class SPException
        Inherits Exception

        Public Property sSerie As String
        Public Property sNro_Documento As String
        Public Property sNum_Corre As String
        Public Property sCod_Cliente As String
        Public Property sMensaje_error As String
        Public Property sNombre_SP As String
        Public Property sFlg_Muestra As String

        Public Sub New(Optional SerieT As String = "",
                       Optional Nro_DocumentoT As String = "",
                       Optional Num_CorreT As String = "",
                       Optional cod_ClienteT As String = "",
                       Optional Mensaje_errorT As String = "",
                       Optional Nombre_SPT As String = "",
                       Optional flg_muestra As String = "")

            Me.sSerie = SerieT
            Me.sNro_Documento = Nro_DocumentoT
            Me.sNum_Corre = Num_CorreT
            Me.sCod_Cliente = cod_ClienteT
            Me.sMensaje_error = Mensaje_errorT
            Me.sNombre_SP = Nombre_SPT
            Me.sFlg_Muestra = flg_muestra
        End Sub
    End Class

End Class