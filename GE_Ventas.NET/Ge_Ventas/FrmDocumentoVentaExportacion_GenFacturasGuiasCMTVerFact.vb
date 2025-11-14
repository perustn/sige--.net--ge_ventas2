Imports Janus.Windows.GridEX
Imports System.Data.SqlClient

Public Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer
    Private oDtDetalle As New DataTable

    Dim vlTabla As String
    Dim vlImportLetra As String
    Dim ST As Double
    Dim igv As Double
    Dim Total As Double
    Dim vlCorrelativo As String
    Dim Envio As New EnvioTrama

    Private Sub FrmDocumentoVentaExportacion_GenFacturasGuiasCMTVerFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel1.BackColor = colEmpresa
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            LblCorrelativo.Text = TxtNroCorrelativo.Text
            LblPO.Text = TxtPO.Text
            LblEstilo.Text = TxtEstilo.Text

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MUESTRA_Ventas_Facturas_CMT_Detalle"
            strSQL &= vbNewLine & String.Format(" @num_corre   = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD  = '{0}'", TxtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI  = '{0}'", TxtEstilo.Text)

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
                End With
            End With

            GrdDatos.FrozenColumns = 3
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        vlTabla = ""
        vlImportLetra = ""
        RegistraFactura
    End Sub
    Sub RegistraFactura()
        Dim vlcadena As String

        For Each oGridEXRow As GridEXRow In GridEX2.GetDataRows
            vlcadena = vlcadena + Strings.Right("        " + Trim(oGridEXRow.Cells("Partida").Value), 8) +
            Strings.Right("                         " + Trim(oGridEXRow.Cells("PO").Value), 25) +
            Strings.Right("                         " + Trim(oGridEXRow.Cells("Estilo_Cliente").Value), 25) +
            Strings.Right("          " + Trim(oGridEXRow.Cells("Prendas").Value), 10) +
            Strings.Right("          " + Trim(oGridEXRow.Cells("Precio").Value), 10) +
            Strings.Right("                                                                                                    " + Trim(oGridEXRow.Cells("Descripcion").Value), 100)
        Next

        If Len(vlcadena) > 0 Then
            Using connection As SqlConnection = New SqlConnection(cCONNECT)
                connection.Open()
                Using cmd As SqlCommand = connection.CreateCommand()
                    Dim transaction As SqlTransaction
                    transaction = connection.BeginTransaction("Facturacion Saldos")
                    cmd.Connection = connection
                    cmd.Transaction = transaction
                    cmd.CommandTimeout = 0
                    cmd.CommandType = CommandType.StoredProcedure
                    Try
                        With cmd
                            .CommandType = CommandType.StoredProcedure
                            .CommandText = "MTX_Carga_Informacion_Fct_CMT_a_STN_SIGE"
                            .Parameters.Add("@CorrelativoDocumento", SqlDbType.VarChar, 10).Value = Trim("")
                            .Parameters.Add("@CodigoTDoc", SqlDbType.VarChar, 2).Value = "01"
                            .Parameters.Add("@FechaDocumento", SqlDbType.VarChar, 10).Value = DTPicker1.Value.ToShortDateString
                            .Parameters.Add("@CLICODCLI", SqlDbType.VarChar, 10).Value = Trim("0012")
                            .Parameters.Add("@RucCliente", SqlDbType.VarChar, 11).Value = Trim("20376729126")
                            .Parameters.Add("@CodigoFPago", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@CodigoMnd", SqlDbType.VarChar, 3).Value = Trim("PEN")
                            .Parameters.Add("@CodigoTGuia", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@CodUbgLocal", SqlDbType.VarChar, 6).Value = ""
                            .Parameters.Add("@CodUbgPais", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@NroGuia", SqlDbType.VarChar, 150).Value = Trim(TxtGuia.Text)
                            .Parameters.Add("@SerieDoc", SqlDbType.VarChar, 4).Value = "005"
                            .Parameters.Add("@NumDoc", SqlDbType.VarChar, 15).Value = ""
                            .Parameters.Add("@TpDocRel", SqlDbType.VarChar, 6).Value = ""
                            .Parameters.Add("@NumDocRel", SqlDbType.VarChar, 20).Value = Trim("")
                            .Parameters.Add("@PRCCODPRC", SqlDbType.VarChar, 2).Value = Trim("01")
                            .Parameters.Add("@IGVCODIGV", SqlDbType.VarChar, 2).Value = "10"
                            .Parameters.Add("@DscFinal", SqlDbType.VarChar, 300).Value = ""
                            .Parameters.Add("@Modo", SqlDbType.VarChar, 1).Value = "L"
                            .Parameters.Add("@Referencia", SqlDbType.VarChar, 300).Value = ""
                            .Parameters.Add("@Item", SqlDbType.VarChar, 4).Value = Trim(Str(0))
                            .Parameters.Add("@Partida", SqlDbType.VarChar, 8).Value = ""
                            .Parameters.Add("@PO", SqlDbType.VarChar, 30).Value = ""
                            .Parameters.Add("@Estilo", SqlDbType.VarChar, 30).Value = ""
                            .Parameters.Add("@Descripcion", SqlDbType.VarChar, 250).Value = Trim(Me.TxtGlosaFinal.Text)
                            .Parameters.Add("@DscAdc", SqlDbType.VarChar, 250).Value = ""
                            .Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = Val(Trim("0"))
                            .Parameters.Add("@Precio", SqlDbType.Decimal).Value = Val(Trim("0"))
                            .Parameters.Add("@Cnt", SqlDbType.VarChar, 30).Value = 0
                            .Parameters.Add("@OP", SqlDbType.VarChar, 1).Value = "C"
                            .Parameters.Add("@Usr", SqlDbType.VarChar, 30).Value = vusu
                            .Parameters.Add("@Wks", SqlDbType.VarChar, 30).Value = ComputerName()
                            .Parameters.Add("@trbcod", SqlDbType.VarChar, 4).Value = Trim("1000")
                            .Parameters.Add("@tdicod", SqlDbType.VarChar, 1).Value = Trim("6")
                            .Parameters.Add("@unmcod", SqlDbType.VarChar, 4).Value = Trim("NIU")
                            .Parameters.Add("@coddocrel", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@PorDet", SqlDbType.Decimal).Value = Val(0)
                            .Parameters.Add("@CtaDet", SqlDbType.VarChar, 100).Value = ""
                            .Parameters.Add("@TotalCajas", SqlDbType.Decimal).Value = 0
                            .Parameters.Add("@PesoBruto", SqlDbType.Decimal).Value = 0
                            .Parameters.Add("@PesoNeto", SqlDbType.Decimal).Value = 0
                            .Parameters.Add("@Medidas", SqlDbType.Decimal).Value = 0
                            .Parameters.Add("@Cadena", SqlDbType.VarChar, 8000).Value = vlcadena

                            With .Parameters.Add("@ST", SqlDbType.Decimal)
                                .Direction = ParameterDirection.Output
                                .Value = 0
                            End With
                            With .Parameters.Add("@IGV", SqlDbType.Decimal)
                                .Direction = ParameterDirection.Output
                                .Value = 0
                            End With
                            With .Parameters.Add("@Total", SqlDbType.Decimal)
                                .Direction = ParameterDirection.Output
                                .Value = 0
                            End With
                            With .Parameters.Add("@Tabla", SqlDbType.VarChar, 30)
                                .Direction = ParameterDirection.Output
                                .Value = Trim(vlTabla)
                            End With

                            With .Parameters.Add("@Msj", SqlDbType.VarChar, 300)
                                .Direction = ParameterDirection.Output
                                .Value = ""
                            End With
                            With .Parameters.Add("@ImpLetras", SqlDbType.VarChar, 8000)
                                .Direction = ParameterDirection.Output
                                .Value = Trim(vlImportLetra)
                            End With
                            With .Parameters.Add("@MntDet", SqlDbType.Decimal)
                                .Direction = ParameterDirection.Output
                                .Value = 0
                            End With
                        End With
                        cmd.ExecuteNonQuery()
                        Dim Msgg As String
                        Msgg = IIf(IsDBNull(cmd.Parameters("@Msj").Value), "", cmd.Parameters("@Msj").Value)
                        If Len(Trim(Msgg)) > 0 Then
                            MessageBox.Show(Trim(cmd.Parameters("@Msj").Value), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Exit Sub
                        End If
                        ST = cmd.Parameters("@ST").Value
                        igv = cmd.Parameters("@IGV").Value
                        Total = cmd.Parameters("@Total").Value
                        vlImportLetra = IIf(IsDBNull(cmd.Parameters("@ImpLetras").Value), "", cmd.Parameters("@ImpLetras").Value)
                        vlTabla = IIf(IsDBNull(cmd.Parameters("@Tabla").Value), "", cmd.Parameters("@Tabla").Value)
                        cmd.Parameters.Clear()

                        If MessageBox.Show("Desea grabar el Movimiento" & vbCrLf & "Sub Total : " & CStr(ST) + vbCrLf & "IGV : " & CStr(igv) & vbCrLf & "Total : " & CStr(Total) & vbCrLf & "Importe Letras : " & vlImportLetra, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            With cmd
                                .CommandType = CommandType.StoredProcedure
                                .CommandText = "MTX_Carga_Informacion_Fct_CMT_a_STN_SIGE"
                                .Parameters.Add("@CodigoTDoc", SqlDbType.VarChar, 2).Value = "01"
                                .Parameters.Add("@FechaDocumento", SqlDbType.VarChar, 10).Value = DTPicker1.Value.ToShortDateString
                                .Parameters.Add("@CLICODCLI", SqlDbType.VarChar, 10).Value = Trim("0012")
                                .Parameters.Add("@RucCliente", SqlDbType.VarChar, 11).Value = Trim("20376729126")
                                .Parameters.Add("@CodigoFPago", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@CodigoMnd", SqlDbType.VarChar, 3).Value = Trim("PEN")
                                .Parameters.Add("@CodigoTGuia", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@CodUbgLocal", SqlDbType.VarChar, 6).Value = ""
                                .Parameters.Add("@CodUbgPais", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@NroGuia", SqlDbType.VarChar, 150).Value = Trim(TxtGuia.Text)
                                .Parameters.Add("@SerieDoc", SqlDbType.VarChar, 4).Value = "005"
                                .Parameters.Add("@NumDoc", SqlDbType.VarChar, 15).Value = ""
                                .Parameters.Add("@TpDocRel", SqlDbType.VarChar, 6).Value = ""
                                .Parameters.Add("@NumDocRel", SqlDbType.VarChar, 20).Value = Trim("")
                                .Parameters.Add("@PRCCODPRC", SqlDbType.VarChar, 2).Value = Trim("01")
                                .Parameters.Add("@IGVCODIGV", SqlDbType.VarChar, 2).Value = "10"
                                .Parameters.Add("@DscFinal", SqlDbType.VarChar, 300).Value = ""
                                .Parameters.Add("@Modo", SqlDbType.VarChar, 1).Value = "L"
                                .Parameters.Add("@Referencia", SqlDbType.VarChar, 300).Value = ""
                                .Parameters.Add("@Item", SqlDbType.VarChar, 4).Value = Trim(Str(0))
                                .Parameters.Add("@Partida", SqlDbType.VarChar, 8).Value = ""
                                .Parameters.Add("@PO", SqlDbType.VarChar, 30).Value = ""
                                .Parameters.Add("@Estilo", SqlDbType.VarChar, 30).Value = ""
                                .Parameters.Add("@Descripcion", SqlDbType.VarChar, 250).Value = ""
                                .Parameters.Add("@DscAdc", SqlDbType.VarChar, 250).Value = ""
                                .Parameters.Add("@Cantidad", SqlDbType.Decimal).Value = Val(Trim("0"))
                                .Parameters.Add("@Precio", SqlDbType.Decimal).Value = Val(Trim("0"))
                                .Parameters.Add("@Cnt", SqlDbType.VarChar, 30).Value = 0
                                .Parameters.Add("@OP", SqlDbType.VarChar, 1).Value = "N"
                                .Parameters.Add("@Usr", SqlDbType.VarChar, 30).Value = vusu
                                .Parameters.Add("@Wks", SqlDbType.VarChar, 30).Value = ComputerName()
                                .Parameters.Add("@trbcod", SqlDbType.VarChar, 4).Value = Trim("1000")
                                .Parameters.Add("@tdicod", SqlDbType.VarChar, 1).Value = Trim("6")
                                .Parameters.Add("@unmcod", SqlDbType.VarChar, 4).Value = Trim("NIU")
                                .Parameters.Add("@coddocrel", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@PorDet", SqlDbType.Decimal).Value = Val(0)
                                .Parameters.Add("@CtaDet", SqlDbType.VarChar, 100).Value = ""
                                .Parameters.Add("@TotalCajas", SqlDbType.Decimal).Value = 0
                                .Parameters.Add("@PesoBruto", SqlDbType.Decimal).Value = 0
                                .Parameters.Add("@PesoNeto", SqlDbType.Decimal).Value = 0
                                .Parameters.Add("@Medidas", SqlDbType.Decimal).Value = 0
                                .Parameters.Add("@Cadena", SqlDbType.VarChar, 8000).Value = ""

                                With .Parameters.Add("@CorrelativoDocumento", SqlDbType.VarChar, 10)
                                    .Direction = ParameterDirection.Output
                                    .Value = ""
                                End With
                                With .Parameters.Add("@ST", SqlDbType.Decimal)
                                    .Direction = ParameterDirection.Output
                                    .Value = 0
                                End With
                                With .Parameters.Add("@IGV", SqlDbType.Decimal)
                                    .Direction = ParameterDirection.Output
                                    .Value = 0
                                End With
                                With .Parameters.Add("@Total", SqlDbType.Decimal)
                                    .Direction = ParameterDirection.Output
                                    .Value = 0
                                End With
                                With .Parameters.Add("@Tabla", SqlDbType.VarChar, 30)
                                    .Direction = ParameterDirection.InputOutput 'Output
                                    .Value = Trim(vlTabla)
                                End With

                                With .Parameters.Add("@Msj", SqlDbType.VarChar, 300)
                                    .Direction = ParameterDirection.InputOutput 'Output
                                    .Value = ""
                                End With

                                With .Parameters.Add("@ImpLetras", SqlDbType.VarChar, 8000)
                                    .Direction = ParameterDirection.Output
                                    .Value = Trim(vlImportLetra)
                                End With
                                With .Parameters.Add("@MntDet", SqlDbType.Decimal)
                                    .Direction = ParameterDirection.Output
                                    .Value = 0
                                End With
                            End With
                            cmd.ExecuteNonQuery()
                            If Len(Trim(cmd.Parameters("@Msj").Value)) > 0 Then
                                MessageBox.Show(Trim(cmd.Parameters("@Msj").Value), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Exit Sub
                            Else
                                vlTabla = cmd.Parameters("@Tabla").Value
                                vlCorrelativo = cmd.Parameters("@CorrelativoDocumento").Value
                                EnvioCMTFACT005(vlCorrelativo)
                                GridEX2.RootTable.Columns.Clear()
                                TxtGlosaFinal.Text = ""
                                TxtGuia.Text = ""
                                Frame1.Visible = False
                                'If vlCorrelativo <> "" Then
                                '    transaction.Commit()
                                'End If
                            End If
                            transaction.Commit()
                        End If

                    Catch ex As Exception
                        Try
                            transaction.Rollback()
                        Catch ex2 As Exception
                            MessageBox.Show(ex.Message, "Error al revertir transaccion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End Try
                        MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Try
                End Using




                '' --- Segunda transacción para el subproceso ---
                'Using cmd2 As SqlCommand = connection.CreateCommand()
                '    Dim transaction2 As SqlTransaction = connection.BeginTransaction("EnvioSubproceso")
                '    cmd2.Connection = connection
                '    cmd2.Transaction = transaction2
                '    cmd2.CommandTimeout = 0
                '    Try
                '        ' Ejecutamos subproceso en su propia transacción
                '        EnvioCMTFACT005(vlCorrelativo)
                '        transaction2.Commit()
                '        Frame1.Visible = False
                '        GridEX2.RootTable.Columns.Clear()
                '        TxtGlosaFinal.Text = ""
                '        TxtGuia.Text = ""
                '    Catch ex As Exception
                '        Try
                '            transaction2.Rollback()
                '        Catch ex2 As Exception
                '            MessageBox.Show(ex2.Message, "Error al revertir segunda transacción", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '        End Try
                '        MessageBox.Show(ex.Message, "Error en subproceso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                '    End Try
                'End Using


            End Using
        End If
    End Sub

    Sub EnvioCMTFACT005(Correlativo As String)
        Dim url As String
        '--------------------------------------------------------------------------------------------------------------------------------------------------------------------
        Dim vlsCab As String
        Dim vlsDet As String

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxCabeceraFactura_NacionalCMT_005_UBL2_1"
        strSQL &= vbNewLine & String.Format(" @NROMov   = '{0}'", Correlativo)
        strSQL &= vbNewLine & String.Format(",@Tipo     = '{0}'", "F")
        Dim oDt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        If oDt.Rows.Count = 0 Then
            MessageBox.Show("No se encontro datos para cabecera del comprobante..!!!", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            vlsCab = oDt.Rows(0)(0).ToString
        End If

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxDetalleFactura_Nacional_Dst_STN04_01_UBL2_1"
        strSQL &= vbNewLine & String.Format(" @NROMov   = '{0}'", Correlativo)
        Dim oDTs As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
        If oDTs.Rows.Count = 0 Then
            MessageBox.Show("El Documento no tiene Detalle", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        Else
            vlsDet = ""
            For Each dr As DataRow In oDTs.Rows
                vlsDet = (vlsDet + dr(0).ToString)
            Next
            vlsDet = (vlsDet + ("~" + oDTs.Rows(0)(1).ToString))
        End If

        Dim Datos As String = (vlsCab + (vlsDet + "/"))
        url = "http: //192.168.30.4:5002/ca4xml"  '"http: //192.168.30.9:5001/ca4xml"
        'url = "http://192.168.30.30:5001/ca4xml"   'PARA PRUEBAS

        Dim docid As String = "FF12-001"
        Dim comando As String = "emitir"
        Dim parametro As String = ""
        Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
        If (respuesta.Substring(0, 2).ToUpper = "OK") Then
            ' ACTUALIZAMOS CAMPOS DE ENVIO DE FACTURA ELECTRONICA.
            Using oCn As New SqlConnection(cCONNECT)
                Using oCmd As New SqlCommand("test", oCn)
                    With oCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_Actualiza_CorrelativoFacturaCMT_005"
                        .Parameters.Add("@Num_Corre", SqlDbType.VarChar, 15).Value = TxtNroCorrelativo.Text
                        .Parameters.Add("@PO", SqlDbType.VarChar, 30).Value = txtpo.Text
                        .Parameters.Add("@Estilo", SqlDbType.VarChar, 100).Value = TxtEstilo.Text
                        .Parameters.Add("@Correlativo", SqlDbType.VarChar, 30).Value = Correlativo
                        .Parameters.Add("@Usuario", SqlDbType.VarChar, 30).Value = vusu

                        With .Parameters.Add("@P_MSJ", SqlDbType.VarChar, 8000)
                            .Direction = ParameterDirection.Output
                            .Value = ""
                        End With
                        .Connection.Open()
                        oDtDetalle.Load(.ExecuteReader)
                    End With

                    If oCmd.Parameters("@P_MSJ").Value = "" Then
                        MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Envio Exitoso..!!" & vbCrLf & "Ocurrio un Problema al Actualizar el Numero de Factura en el Movimiento de Venta." & vbCrLf & Trim(oCmd.Parameters("@P_MSJ").Value) & vbCrLf & "--------------------------------------------" & vbCrLf & respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
        Else
            MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        GridEX2.RootTable.Columns.Clear()
        TxtGlosaFinal.Text = ""
        TxtGuia.Text = ""
        Frame1.Visible = False
    End Sub

    Private Sub GridEX2_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GridEX2.FormattingRow

    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click
        'Try
        'DTPicker1.Value = Now.Date

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC CN_MUESTRA_Ventas_Facturas_CMT_Detalle_FE"
        strSQL &= vbNewLine & String.Format(" @NUM_CORRE   = '{0}'", TxtNroCorrelativo.Text)
        strSQL &= vbNewLine & String.Format(",@COD_PURORD  = '{0}'", TxtPO.Text)
        strSQL &= vbNewLine & String.Format(",@COD_ESTCLI  = '{0}'", TxtEstilo.Text)
        strSQL &= vbNewLine & String.Format(",@Fecha       = '{0}'", "")

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GridEX2.DataSource = oDT
        CheckLayoutGridEx(GridEX2)

        With GridEX2
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

        If GridEX2.RowCount = 0 Then
            Exit Sub
        End If

        TxtGlosaFinal.Text = "^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^" & Strings.Left(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Ruta").Index)), Len(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Ruta").Index))) - 1) _
            & "^O/S:" & Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Oservicio_CMT").Index)) & "^Descripcion Contiene:PARTIDA,PO,ESTILO"

        TxtGuia.Text = Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Num_Guia").Index))
        '^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^(COR),(EST),(COS),(LAV),(PLA),(PEG),(ACA),^O/S: 100-018723^Descripcion Contiene: PARTIDA, PO, ESTILO

        GridEX2.FrozenColumns = 3
        Frame1.Visible = True
        Exit Sub
        'Catch ex As Exception
        '    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End Try
    End Sub

    Private Sub BtnCalcular_Click(sender As Object, e As EventArgs) Handles BtnCalcular.Click
        Try
            'DTPicker1.Value = Now.Date

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MUESTRA_Ventas_Facturas_CMT_Detalle_FE"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE   = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD  = '{0}'", TxtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI  = '{0}'", TxtEstilo.Text)
            strSQL &= vbNewLine & String.Format(",@Fecha       = '{0}'", DTPicker1.Value.ToShortDateString)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GridEX2.DataSource = oDT
            CheckLayoutGridEx(GridEX2)

            With GridEX2
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

            If GridEX2.RowCount = 0 Then
                Exit Sub
            End If

            strSQL = "SELECT Tipo_Venta FROM CN_TipoCambio WHERE  convert(varchar,fecha,103) =  '" & DTPicker1.Value.ToShortDateString & "'"
            LblTipoCambio.Text = CStr(oHP.DevuelveDato(strSQL, cCONNECT))

            TxtGlosaFinal.Text = "^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^" & Strings.Left(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Ruta").Index)), Len(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Ruta").Index))) - 1) _
            & "^O/S:" & Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Oservicio_CMT").Index)) & "^Descripcion Contiene:PARTIDA,PO,ESTILO"

            TxtGuia.Text = Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Num_Guia").Index))
            '^^SERVICIO DE FABRICACION DE PRENDA POR ENCARGO SEGUN CONTRATO^(COR),(EST),(COS),(LAV),(PLA),(PEG),(ACA),^O/S: 100-018723^Descripcion Contiene: PARTIDA, PO, ESTILO

            GridEX2.FrozenColumns = 3
            Frame1.Visible = True
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Frame1.Visible = False
        End Try
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Distribuye_por_Partida_Muestra_Partidas"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@num_guia     = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("num_guia").Index))
            strSQL &= vbNewLine & String.Format(",@factura      = '{0}'", GrdDatos.GetValue(GrdDatos.RootTable.Columns("factura").Index))

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptDocumentoVenta.XLT")
            oo.DisplayAlerts = False
            oo.Visible = True
            oo.Run("REPORTE", strSQL, cCONNECTVB6)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class