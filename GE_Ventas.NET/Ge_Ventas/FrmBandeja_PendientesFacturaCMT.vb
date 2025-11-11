Imports System.IO
Imports System.Text
Imports System.Windows
Imports Aspose.Email.Mail
Imports Janus.Windows.GridEX

Public Class FrmBandeja_PendientesFacturaCMT

    'Dim oBtnSeguridad As New clsBtnSeguridadJanus
    Dim strSQL As String
    Dim oHP As New clsHELPER
    Private ds As New DataTable
    Private Const K_strColCheckItem As String = "ColCheckItem"
    Private sender_address As String
    Private colEmpresa As Color
    Private rs As New ADODB.Recordset
    Private TipoVista As String = "E"
    Dim ReporteExiste As Boolean = True
    Dim Fecha_exportacion As String = Date.Now.ToString("dd_MM_yyyy")
    Private EnBusqueda As Boolean = False
    Private Exito As Boolean = False
    Private ErrorEjecucion As String = ""

    Private Sub Bandeja_PendientesFacturaCMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel1.BackColor = colEmpresa
        buscar()
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Select Case e.Item.Key
            Case "MANTENIMIENTO"
                Mantenimiento_Correos()
            Case "CORREO"
                Envio_Correo()
            Case "REPORTE"
                Exportar_Reporte()
            Case "PROCESAR"
                Procesar()
        End Select
    End Sub
    Private Sub Exportar_Reporte()
        Try
            strSQL = ""
            strSQL = $"EXEC SP_MUESTRA_FACTURADOS_PENDIENTES_ERRORES 'E'"

            ds = oHP.DevuelveDatos(strSQL, cCONNECT)
            rs = ConvertToRecordset(ds)

            Dim Exporta As Object = CreateObject("excel.application")
            Exporta.Workbooks.Open(vRuta & "\rptReportePendientesFacturasCMT.xltm")
            Exporta.Visible = True
            Exporta.DisplayAlerts = False
            Exporta.Run("REPORTE", rs, "", "")
            Exporta = Nothing
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub

    Private Sub Envio_Acepta()
        Using oDet As New FrmDocumentoVentaExportacion_ProcesarFacturas_CMT
            With oDet
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub Mantenimiento_Correos()
        Using xfmr As New FrmBandeja_PendientesFacturaCMT_Mantenimiento
            With xfmr
                .ShowDialog()
                Call buscar()
            End With
        End Using
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Call buscar()
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

                ' Agregar imagen embebida
                'If File.Exists(imgPath) Then
                '    Dim img As New Attachment(imgPath)
                '    img.ContentId = "reporteImagen"
                '    img.ContentDisposition.Inline = True
                '    img.ContentDisposition.DispositionType = DispositionTypeNames.Inline
                '    img.ContentType.MediaType = MediaTypeNames.Image.Jpeg
                '    ml.Attachments.Add(img)
                '    cuerpo.Append("<b>Facturas :</b><br><br><img src='cid:reporteImagen'><br>")
                'End If
                'End If

                cuerpo.Append("<br><br>Saludos.<br>")
                cuerpo.Append("</span></body></html>")
                ml.Body = cuerpo.ToString()

                MessageBox.Show("Antes del Envio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' ENVÍO DEL CORREO
                'stp.Send(ml)

                Try
                    stp.Send(ml)

                Catch ex As SmtpException
                    MessageBox.Show("Error SMTP: " & ex.StatusCode.ToString() & vbCrLf & ex.Message, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show("Error general: " & ex.Message, MessageBoxIcon.Information)
                End Try

                MessageBox.Show("Depsues del envio", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim Mensaje_final As String = "Correo enviado correctamente"
                MessageBox.Show(Mensaje_final, "Envío Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("No se encontró el archivo adjunto. No se envió el correo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
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

            ' ====================================      CAPTURA DE IMAGEN DEL REPORTE     ================================================

            'Dim excelApp As Object = Nothing
            'Dim excelBook As Object = Nothing
            'Dim excelSheet As Object = Nothing
            'Dim lastCell As Object = Nothing
            'Dim captureRange As Object = Nothing
            'excelApp = CreateObject("Excel.Application")
            'excelApp.Visible = False

            'Dim ExcelRutaGenerado As String = "Reporte Pendientes Facturas CMT" & "_" & Fecha_exportacion & "_" & Veces_Impresion '& ".xlsx"
            'Dim filePath As String = "C:\TEMP\Envio_Facturas_CTM\" & ExcelRutaGenerado
            'excelBook = excelApp.Workbooks.Open(filePath)
            'excelSheet = excelBook.Sheets(1)
            'Const xlUp As Integer = -4162
            'lastCell = excelSheet.Cells(excelSheet.Rows.Count, 2).End(xlUp)

            'Dim Ultima_fila_Original As Integer = lastCell.Row

            'Dim Ultima_Columna As Integer
            'Ultima_Columna = excelSheet.Cells(6, excelSheet.Columns.Count).End(-4159).Column

            'If Ultima_fila_Original < 6 Then
            '    ReporteExiste = False
            'End If


            'If ReporteExiste Then
            '    captureRange = excelSheet.Range(excelSheet.Cells(3, 1), excelSheet.Cells(Ultima_fila_Original, Ultima_Columna))
            '    captureRange.CopyPicture(1, 2)
            '        Dim dataObj As IDataObject = Clipboard.GetDataObject()
            '    Dim bmp As Bitmap = Nothing
            '    If dataObj IsNot Nothing AndAlso dataObj.GetDataPresent(DataFormats.Bitmap) Then
            '        bmp = CType(dataObj.GetData(DataFormats.Bitmap), Bitmap)
            '        Dim Ruta_Name_Imagen As String = "C:\TEMP\Envio_Facturas_CTM\Img_" & "Reporte Pendientes Facturas CMT" & "_" & Fecha_exportacion & "_" & Veces_Impresion & ".jpg"
            '        If bmp IsNot Nothing Then
            '            bmp.Save(Ruta_Name_Imagen, Imaging.ImageFormat.Jpeg)
            '            bmp.Dispose()
            '            Clipboard.Clear()
            '        End If
            '    End If
            'End If

            'excelApp.DisplayAlerts = False
            'excelBook.Close(False)
            'excelApp.Quit()


            'excelSheet = Nothing
            'excelBook = Nothing
            'excelApp = Nothing

            'GC.Collect()
            'GC.WaitForPendingFinalizers()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Error")
        End Try
    End Sub


    Public Sub buscar()
        strSQL = ""
        strSQL = $"EXEC SP_MUESTRA_FACTURADOS_PENDIENTES_ERRORES 'S'"
        ds = oHP.DevuelveDatos(strSQL, cCONNECT)

        GridEX1.DataSource = Nothing
        GridEX1.DataSource = ds
        CheckLayoutGridEx(GridEX1)

        With GridEX1
            .FilterMode = FilterMode.Automatic
            .DefaultFilterRowComparison = FilterConditionOperator.Contains

            With .RootTable
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowMember = "Observacion"
                .PreviewRowLines = 4
                .HeaderLines = 2

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                If .Columns.Contains("SERIE") Then
                    .Columns("SERIE").Width = 45
                    .Columns("SERIE").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .Columns("SERIE").Caption = "SERIE"
                End If

                If .Columns.Contains("NRO_DOC") Then
                    .Columns("NRO_DOC").Width = 60
                    .Columns("NRO_DOC").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .Columns("NRO_DOC").Caption = "NRO. DOC"
                End If

                If .Columns.Contains("NUM_CORRE") Then
                    .Columns("NUM_CORRE").Width = 95
                    .Columns("NUM_CORRE").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    .Columns("NUM_CORRE").Caption = "CORRELATIVO"
                End If

                If .Columns.Contains("FECHA") Then
                    .Columns("FECHA").Caption = "FECHA"
                    .Columns("FECHA").Width = 70
                    .Columns("FECHA").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                    '.Columns("FECHA").FormatString = "dd/MM/yyyy HH:mm:ss"
                    .Columns("FECHA").FormatString = "dd/MM/yyyy"
                End If

                If .Columns.Contains("PRENDAS") Then
                    .Columns("PRENDAS").Width = 60
                    .Columns("PRENDAS").Caption = "PRENDAS"
                    .Columns("PRENDAS").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                End If

                If .Columns.Contains("PRECIO") Then
                    .Columns("PRECIO").Width = 60
                    .Columns("PRECIO").Caption = "PRECIO"
                    .Columns("PRECIO").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                End If


                If .Columns.Contains("NUM_GUIA") Then
                    .Columns("NUM_GUIA").Width = 90
                    .Columns("NUM_GUIA").Caption = "GUIA CMT"
                    .Columns("NUM_GUIA").TextAlignment = Janus.Windows.GridEX.TextAlignment.Center
                End If

                If .Columns.Contains("DESCRIPCION") Then
                    .Columns("DESCRIPCION").Width = 230
                    .Columns("DESCRIPCION").Caption = "DESCRIPCION"
                End If

                If .Columns.Contains("ESTILO_CLIENTE") Then
                    .Columns("ESTILO_CLIENTE").Width = 80
                    .Columns("ESTILO_CLIENTE").Caption = "ESTILO CLIENTE"
                End If

            End With
        End With
    End Sub


    Private Sub Procesar()
        If EnBusqueda Then Exit Sub
        EnBusqueda = True
        panelBusqueda.Visible = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Try
            strSQL = ""
            strSQL = $"EXEC SP_PROCESAMIENTO_FACTURACION_CMT '{vusu}'"
            Exito = oHP.EjecutaOperacion(strSQL, cCONNECT, True)
        Catch ex As Exception
            Exito = False
            ErrorEjecucion = ex.Message
        End Try
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        EnBusqueda = False
        panelBusqueda.Visible = False
        If Exito Then
            MessageBox.Show("Procesamiento realizado con exito", "AVISO", MessageBoxButton.OK, MessageBoxIcon.Information)
            Call buscar()
        ElseIf ErrorEjecucion <> "" Then
            MessageBox.Show("Error: " & ErrorEjecucion, "Error")
        End If
    End Sub
End Class