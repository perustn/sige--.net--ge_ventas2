Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
'Imports System.Net.Mail
'Imports System.Net.Mime
Imports System.Text

Imports Aspose.Email.Mail
Imports Aspose.Email.Mime
Imports System.Drawing.Imaging
Imports System.Runtime.InteropServices
'Imports System.Windows

Public Class FrmDocumentoVentaExportacion_ProcesarFacturas_CMT

    Dim oHP As New clsHELPER
    Dim Envio As New EnvioTrama
    Dim strSQL As String
    Private ds As New DataTable
    'Public vusu As String = "Automatico"
    Private sender_address As String
    Private rs As New ADODB.Recordset

    Dim vlTabla As String
    Dim vlImportLetra As String
    Dim ST As Double
    Dim igv As Double
    Dim Total As Double
    Dim vlCorrelativo As String
    Dim ReporteExiste As Boolean = True
    Dim Resultado_acepta As String = ""
    Dim Fecha_exportacion As String = Date.Now.ToString("dd_MM_yyyy")

    Private EjecutadoConExito As Boolean = False
    Private Sub FrmDocumentoVentaExportacion_ProcesarFacturas_CMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelBusqueda.Visible = True
        Label2.Text = "Preparando datos..."
        ProgressBar1.Value = 0
    End Sub

    Private Sub Inicio_Procesamiento()

        strSQL = ""
        strSQL = $"EXEC SP_MUESTRA_GUIAS_A_FACTURAR"
        ds = oHP.DevuelveDatos(strSQL, cCONNECT)

        Dim totalRegistros As Integer = ds.Rows.Count
        Dim registrosProcesados As Integer = 0
        Dim registrosNoProcesados As Integer = 0

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = totalRegistros
        ProgressBar1.Value = 0

        'If totalRegistros = 0 Then
        '    Label2.Text = "No hay registros para procesar."
        '    Label2.ForeColor = Color.Red
        '    ProgressBar1.Value = 0
        '    Application.DoEvents()
        '    Return
        'Else
        '    Label2.Text = $"Procesados: 0 / {totalRegistros}"
        '    Application.DoEvents()
        'End If

        If totalRegistros = 0 Then
            MessageBox.Show("No existen Registros para enviar a Facturar", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            Exit Sub
        End If

        If totalRegistros > 0 Then
            Label2.Text = $"Procesados: 0 / {totalRegistros}"
            Application.DoEvents()
        End If

        For Each row As DataRow In ds.Rows
            If Not IsDBNull(row("SERIE")) AndAlso
                Not IsDBNull(row("NRO_DOC")) AndAlso
                Not IsDBNull(row("CADENA")) AndAlso
                Not IsDBNull(row("FECHA")) AndAlso
                Not IsDBNull(row("NUM_GUIA")) AndAlso
                Not IsDBNull(row("GLOSA")) AndAlso
                Not IsDBNull(row("NUM_CORRE")) AndAlso
                Not IsDBNull(row("PO")) AndAlso
                Not IsDBNull(row("ESTILO_CLIENTE")) Then

                Dim vlcadena As String = row("CADENA").ToString()
                Dim vFecha As Date = Convert.ToDateTime(row("FECHA"))
                Dim vGuia As String = row("NUM_GUIA").ToString().Trim
                Dim vGlosa As String = row("GLOSA").ToString().Trim

                Dim sSerie As String = row("SERIE").ToString().Trim
                Dim sNro_Doc As String = row("NRO_DOC").ToString().Trim
                Dim sNum_Corre As String = row("NUM_CORRE").ToString().Trim
                Dim sPO As String = row("PO").ToString().Trim
                Dim sEstilo_Cliente As String = row("ESTILO_CLIENTE").ToString().Trim

                Try
                    Facturar(sSerie, sNro_Doc, vlcadena, vFecha, vGuia, vGlosa, sNum_Corre, sPO, sEstilo_Cliente)

                    ' Registro procesado con éxito
                    registrosProcesados += 1
                    ProgressBar1.Value = registrosProcesados

                    Label2.Text = $"Procesados: {registrosProcesados} / {totalRegistros}"
                    Application.DoEvents()

                    'Se ajusta 1 segundo para visualizacion del procesamiento '100 = 1 SEG
                    System.Threading.Thread.Sleep(600)

                Catch ex As SPException
                    registrosNoProcesados += 1
                    Dim mensajeLog As String = If(Not String.IsNullOrEmpty(ex.sMensaje_error), ex.sMensaje_error, ex.Message)
                    Guarda_Log_SP(ex.sSerie, ex.sNro_Documento, ex.sNum_Corre, ex.sCod_Cliente, mensajeLog, ex.sNombre_SP, ex.sFlg_Muestra)
                    Label3.Text = $"Errores: {registrosNoProcesados}"
                    Application.DoEvents()
                    Continue For

                Catch ex As Exception
                    registrosNoProcesados += 1
                    Guarda_Log_SP(sSerie, sNro_Doc, sNum_Corre, "", ex.Message, "BUCLE FACTURAR", "")
                    Label3.Text = $"Errores: {registrosNoProcesados}"
                    Application.DoEvents()
                    Continue For
                End Try
            End If
        Next


        '    If registrosNoProcesados > 0 Then
        '        MessageBox.Show(
        '    $"Procesamiento finalizado con {registrosProcesados} correctos y {registrosNoProcesados} con errores. Se procederá con el envío de correos...",
        '    "Aviso",
        '    MessageBoxButtons.OK,
        '    MessageBoxIcon.Warning
        ')
        '    Else
        '        MessageBox.Show(
        '    "Procesamiento finalizado correctamente. Ahora se procederá con el envío de correos...",
        '    "Información",
        '    MessageBoxButtons.OK,
        '    MessageBoxIcon.Information
        ')
        '    End If


        'Envio_Correo()



        ' TODO ERROR GENERADO EN EL CORREO ES INDEPENDIENTE DE LA FACTURACION QUE SE EJECUTA CON NORMALIDAD  ... SE NOTIFICA AL USUARIO

        Try
            Envio_Correo()
        Catch ex As Exception
            MessageBox.Show(
                "Proceso de facturación y envio se completó, pero ocurrió un error al enviar el correo: " & ex.Message,
                "Error de envío de correo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
            )
        End Try

        ' LIMPIAMOS LA TABLA TEMPÓRAL DE REGISTROS PROCESADOS PARA ENVIO ACEPTA
        Call Limpia_Tabla_Procesados()
    End Sub

    Private Sub Limpia_Tabla_Procesados()
        Try
            strSQL = ""
            strSQL = $"EXEC SP_LIMPIA_TABLA_TEMPORAL_FACTURACION_PROCESADOS"
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub FrmDocumentoVentaExportacion_ProcesarFacturas_CMT_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Inicio_Procesamiento()
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
            @SerieDoc = '005',
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
                @SerieDoc = '005',
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
                    EnvioCMTFACT005(vlCorrelativo, Num_Corre_up, PO_up, Estilo_up, sSerie, sNro_Doc)
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

    Sub EnvioCMTFACT005(Correlativo As String, Num_Corre_Doc As String, PO_doc As String, Estilo_doc As String, Serie_traza As String, Nro_Doc_traza As String)

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

        Dim Datos As String = (vlsCab + (vlsDet + "/"))
        url = "http://192.168.30.30:5001/ca4xml"
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
    End Sub

    Private Sub Envio_Correo()
        Try

            If Not System.IO.Directory.Exists("C:\TEMP") Then
                Directory.CreateDirectory("C:\TEMP")
            End If

            If Not System.IO.Directory.Exists("C:\TEMP\Envio_Facturas_CTM") Then
                Directory.CreateDirectory("C:\TEMP\Envio_Facturas_CTM")
            End If

            '==================================         DESTINATORIOS Y CORREOS EN COPIA - USUARIO QUE EMITE CORREO  =========================================

            Dim receptores = oHP.DevuelveDato($"Select dbo.fn_Retorna_Cadena_Corres_Destino_FacturaCMT('D')", cCONNECT)
            Dim copia = oHP.DevuelveDato($"SELECT dbo.fn_Retorna_Cadena_Corres_Destino_FacturaCMT('C')", cCONNECT)

            If String.IsNullOrEmpty(receptores) Then
                MessageBox.Show($"No existen correos destinos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

            '==================================        CONFIGURACION CORREO Y ENVIO DE ARCHIVOS   =========================================
            Dim rnd As New Random()
            Dim Veces_Impresion_reporte As Integer = rnd.Next(1, 1000)

            Reporte(Veces_Impresion_reporte)

            Dim cabecera As String = "PENDIENTES FACTURA CMT"
            strSQL = "select Domain, SenderAddress, SMTP_Password, SMTP_Puerto from Mails"
            ds = oHP.DevuelveDatos(strSQL, cCONNECT)
            Dim stp As New SmtpClient()
            For Each w As DataRow In ds.Rows
                stp.Host = w("Domain")
                stp.Username = w("SenderAddress")
                sender_address = w("SenderAddress")
                stp.Password = w("SMTP_Password")
                stp.Port = w("SMTP_Puerto")
            Next
            'stp.SecurityMode = SmtpSslSecurityMode.Explicit
            'stp.EnableSsl = True

            Dim ml As New MailMessage
            ml.From = New MailAddress(sender_address, "BD SIGE_STN")
            Dim Matriz As Object = Split(receptores, ";")
            For i = 0 To UBound(Matriz)
                ml.To.Add(New MailAddress(Matriz(i)))
            Next i

            If Not String.IsNullOrWhiteSpace(copia) Then
                Dim Matriz_Copia As Object = Split(copia, ";")
                For i = 0 To UBound(Matriz_Copia)
                    ml.CC.Add(New MailAddress(Matriz_Copia(i).Trim()))
                Next i
            End If


            ml.Subject = cabecera
            ml.IsBodyHtml = True
            ml.Priority = MailPriority.High

            Dim cuerpo As New StringBuilder()
            cuerpo.Append("<html><body>")
            cuerpo.Append("<span style='font-style:italic; color:#003366; font-family:Arial; font-size:14px;'>")
            cuerpo.Append("Buenas,<br><br>")
            cuerpo.Append("Se adjunta Reporte de Facturas Pendientes:<br><br>")


            Dim imgPath = $"C:\TEMP\Envio_Facturas_CTM\Img_Reporte Pendientes Facturas CMT_{Fecha_exportacion}_{Veces_Impresion_reporte}.jpg"
            Dim Archivo_Factura = $"C:\TEMP\Envio_Facturas_CTM\Reporte Pendientes Facturas CMT_{Fecha_exportacion}_{Veces_Impresion_reporte}.xlsx"

            If File.Exists(Archivo_Factura) Then
                ml.Attachments.Add(New Attachment(Archivo_Factura))

                cuerpo.Append("<br><br>Saludos.<br>")
                cuerpo.Append("</span></body></html>")
                ml.Body = cuerpo.ToString()

                ' ENVÍO DEL CORREO
                'stp.Send(ml)

                Try
                    stp.Send(ml)

                Catch ex As SmtpException
                    MessageBox.Show("Error SMTP: " & ex.StatusCode.ToString() & vbCrLf & ex.Message, CStr(MessageBoxIcon.Information))
                    Throw
                Catch ex As Exception
                    MessageBox.Show("Error general: " & ex.Message, CStr(MessageBoxIcon.Information))
                    Throw
                End Try


                Dim Mensaje_final As String = "Correo enviado correctamente"
                MessageBox.Show(Mensaje_final, "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("No se encontró el archivo adjunto. No se envió el correo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub



    Private Sub Reporte(Veces_Impresion As Integer)
        Try
            strSQL = ""
            strSQL = $"EXEC SP_MUESTRA_FACTURADOS_PENDIENTES_ERRORES 'E'"
            ds = oHP.DevuelveDatos(strSQL, cCONNECT)
            rs = ConvertToRecordset(ds)

            Dim oo As Object = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptReportePendientesFacturasCMT.xltm")
            oo.Visible = False
            oo.DisplayAlerts = False
            oo.Run("REPORTE", rs, "Reporte Pendientes Facturas CMT" & "_" & Fecha_exportacion & "_" & Veces_Impresion, "C:\TEMP\Envio_Facturas_CTM" & "\")
            oo.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(oo)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
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

