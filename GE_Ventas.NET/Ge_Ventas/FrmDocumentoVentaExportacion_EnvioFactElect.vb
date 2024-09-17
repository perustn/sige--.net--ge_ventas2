Imports Janus.Windows.GridEX
Imports System.Data.SqlClient

Public Class FrmDocumentoVentaExportacion_EnvioFactElect
    Private strSQL As String = String.Empty
    Private strSQLTrazaImp As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Dim Envio As New EnvioTrama
    ' Variables para Factura Electronica DVL
    Dim vlTabla As String

    Private Sub FrmDocumentoVentaExportacion_EnvioFactElect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa
        Me.ActiveControl = GrdDatos
    End Sub

    Public Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Genera_Interfase_FE_Devanlay"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@guia         = '{0}'", TxtGuia.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDT Is Nothing Then Exit Sub
            GrdDatos.RootTable.Columns.Clear()
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                .FilterRowButtonStyle = FilterRowButtonStyle.ConditionOperatorDropDown
                With .RootTable
                    .HeaderLines = 2
                    .RowHeight = 30
                    .PreviewRow = False
                    .PreviewRowLines = 15
                    '.PreviewRowMember = "OBSERVACIONES"
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("Item").Width = 50
                    .Columns("OF").Width = 110
                    .Columns("Estilo").Width = 150
                    .Columns("Temporada").Width = 110
                    .Columns("Descripcion").Width = 220
                    .Columns("Color").Width = 110
                    .Columns("Guia").Width = 110
                    .Columns("Cant").Width = 80
                    .Columns("Precio Unit.").Width = 110
                    .Columns("Importe").Width = 110
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If Len(Trim(TxtPeso.Text)) <= 7 Or Len(Trim(TxtGuia.Text)) <= 1 Then
                MessageBox.Show("Ingrese Precio / Guia", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If
            GrabarFactura()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub GrabarFactura()
        vlTabla = ""
        Dim RsDatos As New ADODB.Recordset
        Dim Subt As Double
        Dim igv As Double
        Dim Total As Double
        Dim vlImportLetra As String
        vlImportLetra = ""
        Dim vlx As Integer
        Dim vlcadena As String
        vlcadena = ""

        For Each oGridEXRow As GridEXRow In GrdDatos.GetDataRows
            vlcadena = vlcadena + oGridEXRow.Cells("Item").Value +
            Strings.Right("^^^^^^^^^^^^^^^^^^^^^^^^^" + Trim(oGridEXRow.Cells("OF").Value), 25) +
            Strings.Right("^^^^^^^^^^^^^^^^^^^^^^^^^" + Trim(oGridEXRow.Cells("Estilo").Value), 25) +
            Strings.Left(Trim(oGridEXRow.Cells("Temporada").Value) + "^^^^^^", 6) +
            Strings.Right("^^^" + Trim(oGridEXRow.Cells("Color").Value), 3) +
            Strings.Right("^^^^^^^^^^" + Trim(oGridEXRow.Cells("Cant").Value), 10) +
            Strings.Right("^^^^^^^^^^" + Trim(oGridEXRow.Cells("Precio Unit.").Value), 10) +
            Strings.Left(Trim(oGridEXRow.Cells("Descripcion").Value) + "^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^", 100)
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
                            .CommandText = "MTX_Carga_Informacion_Fct_CMT_a_DVL03_01_ML"
                            .Parameters.Add("@CorrelativoDocumento", SqlDbType.VarChar, 10).Value = Trim("")
                            .Parameters.Add("@CodigoTDoc", SqlDbType.VarChar, 2).Value = "01"
                            .Parameters.Add("@FechaDocumento", SqlDbType.VarChar, 10).Value = Strings.Right(Trim(TxtFecha.Text), 10)
                            .Parameters.Add("@CLICODCLI", SqlDbType.VarChar, 10).Value = Trim("0001")
                            .Parameters.Add("@RucCliente", SqlDbType.VarChar, 11).Value = Trim("20501977439")
                            .Parameters.Add("@CodigoFPago", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@CodigoMnd", SqlDbType.VarChar, 3).Value = Trim("USD")
                            .Parameters.Add("@CodigoTGuia", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@CodUbgLocal", SqlDbType.VarChar, 6).Value = ""
                            .Parameters.Add("@CodUbgPais", SqlDbType.VarChar, 2).Value = ""
                            .Parameters.Add("@NroGuia", SqlDbType.VarChar, 150).Value = Trim(TxtGuia.Text)
                            .Parameters.Add("@SerieDoc", SqlDbType.VarChar, 4).Value = Strings.Left(Trim("006"), 3)
                            .Parameters.Add("@NumDoc", SqlDbType.VarChar, 15).Value = Strings.Right(Trim(TxtFactura.Text), 8)
                            .Parameters.Add("@TpDocRel", SqlDbType.VarChar, 6).Value = ""
                            .Parameters.Add("@NumDocRel", SqlDbType.VarChar, 20).Value = Trim("")
                            .Parameters.Add("@PRCCODPRC", SqlDbType.VarChar, 2).Value = Trim("01")
                            .Parameters.Add("@IGVCODIGV", SqlDbType.VarChar, 2).Value = "10"
                            .Parameters.Add("@DscFinal", SqlDbType.VarChar, 300).Value = ""
                            .Parameters.Add("@Modo", SqlDbType.VarChar, 1).Value = "L"
                            .Parameters.Add("@Referencia", SqlDbType.VarChar, 300).Value = ""
                            .Parameters.Add("@Item", SqlDbType.VarChar, 4).Value = Trim(Str(0))
                            .Parameters.Add("@Partida", SqlDbType.VarChar, 15).Value = ""
                            .Parameters.Add("@PO", SqlDbType.VarChar, 30).Value = ""
                            .Parameters.Add("@Estilo", SqlDbType.VarChar, 30).Value = ""
                            .Parameters.Add("@Descripcion", SqlDbType.VarChar, 200).Value = Trim(Me.TxtGlosa1.Text) + Trim(Me.TxtGlosa2.Text) + Trim(Me.TxtPeso.Text) + Trim(Me.TxtGlosa3.Text)
                            .Parameters.Add("@DscAdc", SqlDbType.VarChar, 100).Value = ""
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
                        Subt = cmd.Parameters("@ST").Value
                        igv = cmd.Parameters("@IGV").Value
                        Total = cmd.Parameters("@Total").Value
                        vlImportLetra = IIf(IsDBNull(cmd.Parameters("@ImpLetras").Value), "", cmd.Parameters("@ImpLetras").Value)
                        vlTabla = IIf(IsDBNull(cmd.Parameters("@Tabla").Value), "", cmd.Parameters("@Tabla").Value)
                        cmd.Parameters.Clear()

                        Dim vlNumDoc As String
                        If MessageBox.Show("¿Desea Generar la Factura?" & vbCrLf & "Detalle ------->" & vbCrLf & "SubTotal : " & Str(Subt) & vbCrLf & "IGV : " & Str(igv) & vbCrLf & "Total : " & Str(Total), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            With cmd
                                .CommandText = "MTX_Carga_Informacion_Fct_CMT_a_DVL03_02"
                                .Parameters.Add("@CorrelativoDocumento", SqlDbType.VarChar, 10).Value = Trim("")
                                .Parameters.Add("@CodigoTDoc", SqlDbType.VarChar, 2).Value = "01"
                                .Parameters.Add("@FechaDocumento", SqlDbType.VarChar, 10).Value = Strings.Right(Trim(TxtFecha.Text), 10)
                                .Parameters.Add("@CLICODCLI", SqlDbType.VarChar, 10).Value = Trim("0001")
                                .Parameters.Add("@RucCliente", SqlDbType.VarChar, 11).Value = Trim("20501977439")
                                .Parameters.Add("@CodigoFPago", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@CodigoMnd", SqlDbType.VarChar, 3).Value = Trim("USD")
                                .Parameters.Add("@CodigoTGuia", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@CodUbgLocal", SqlDbType.VarChar, 6).Value = ""
                                .Parameters.Add("@CodUbgPais", SqlDbType.VarChar, 2).Value = ""
                                .Parameters.Add("@NroGuia", SqlDbType.VarChar, 150).Value = Trim(TxtGuia.Text)
                                .Parameters.Add("@SerieDoc", SqlDbType.VarChar, 4).Value = Strings.Left(Trim("006"), 3)
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
                                .Parameters.Add("@Descripcion", SqlDbType.VarChar, 200).Value = ""
                                .Parameters.Add("@DscAdc", SqlDbType.VarChar, 100).Value = ""
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
                                With .Parameters.Add("@NumDoc", SqlDbType.VarChar, 15)
                                    .Direction = ParameterDirection.Output
                                    .Value = Strings.Right(Trim(TxtFactura.Text), 8)
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

                            If Len(Trim(cmd.Parameters("@Msj").Value)) > 0 Then
                                MessageBox.Show(Trim(cmd.Parameters("@Msj").Value), Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                LblCorrelativoFact.Text = ".."
                                Exit Sub
                            End If
                            vlNumDoc = cmd.Parameters("@NumDoc").Value
                            vlTabla = cmd.Parameters("@Tabla").Value
                            LblCorrelativoFact.Text = "Corr. Factura : " + cmd.Parameters("@CorrelativoDocumento").Value
                            cmd.Parameters.Clear()

                            'Grabamos Relacion de facturacion con Registros de Enbarque SIGE
                            cmd.CommandText = "SP_Registra_Ref_Factura_FactElectronica"
                            With cmd
                                .Parameters.Add(New SqlParameter("@NumCorre", SqlDbType.VarChar, 15)).Value = TxtNroCorrelativo.Text
                                .Parameters.Add(New SqlParameter("@Serie", SqlDbType.VarChar, 3)).Value = "006"
                                .Parameters.Add(New SqlParameter("@NumDoc", SqlDbType.VarChar, 10)).Value = vlNumDoc
                                .Parameters.Add(New SqlParameter("@Fecha", SqlDbType.VarChar, 10)).Value = TxtFecha.Text
                                .Parameters.Add(New SqlParameter("@CorrelativoDoc", SqlDbType.VarChar, 10)).Value = Strings.Right(LblCorrelativoFact.Text, 10)
                                .Parameters.Add(New SqlParameter("@Usr", SqlDbType.VarChar, 15)).Value = vusu
                            End With

                            cmd.ExecuteNonQuery()
                            transaction.Commit()

                            EnvioDVL(Strings.Right(Trim(LblCorrelativoFact.Text), 10))
                            Me.Close()
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
            End Using
        End If
    End Sub

    Sub EnvioDVL(Correlativo As String)
        Dim url As String
        Dim vlsCab As String
        Dim vlsDet As String

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxCabeceraFactura_Cabecera_STN_a_DVL02_UBL2_1"
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
        strSQL &= vbNewLine & "EXEC MtxDetalleFactura_Nacional_Dst_Devanlay04_02_UBL2_1"
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
        url = "http://192.168.30.4:5002/ca4xml"
        Dim docid As String = "FF12-001"
        Dim comando As String = "emitir"
        Dim parametro As String = ""
        Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
        If (respuesta.Substring(0, 2).ToUpper = "OK") Then
            MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub


    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class