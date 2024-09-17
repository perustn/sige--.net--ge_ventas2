Imports Janus.Windows.GridEX
Imports System.IO

Public Class FrmDocumentoVentaExportacion_EventoComprometido
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private oDtFacturas As New DataTable
    Private oDtArchivos As New DataTable
    Public sFactura As String
    Public sFecha As String
    Public sEmbarque As String

    Dim vlRuta_ As String

    Private Sub FrmDocumentoVentaExportacion_EventoComprometido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        oDtArchivos = New DataTable
        With oDtArchivos
            With .Columns
                .Add("Ruta_Archivo", Type.GetType("System.String"))
                .Add("Nombre_Archivo", Type.GetType("System.String"))
                .Add("Formato_Archivo", Type.GetType("System.String"))
            End With
        End With

        Dim i As Integer
        oDtFacturas = New DataTable
        With oDtFacturas
            With .Columns
                .Add("Nro.Factura", Type.GetType("System.String"))
                .Add("Fecha_Factura_SUNAT", Type.GetType("System.String"))
                .Add("Embarque", Type.GetType("System.String"))
            End With
        End With

        If Trim(sFactura) <> "" Then
            Dim xFactura() As String
            Dim xFecha() As String
            Dim xEmbarque() As String

            xFactura = Split(sFactura, ",")
            xFecha = Split(sFecha, ",")
            xEmbarque = Split(sEmbarque, ",")

            For i = LBound(xFactura) To UBound(xFactura) - 1
                Dim oDrNUEVO As DataRow = oDtFacturas.NewRow()
                oDrNUEVO("Nro.Factura") = xFactura(i)
                oDrNUEVO("Fecha_Factura_SUNAT") = xFecha(i)
                oDrNUEVO("Embarque") = xEmbarque(i)
                oDtFacturas.Rows.Add(oDrNUEVO)
            Next

            GridEX2.DataSource = oDtFacturas
            CheckLayoutGridEx(GridEX2)

            With GridEX2
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 25
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("Nro.Factura").Width = 250
                    .Columns("Fecha_Factura_SUNAT").Width = 150
                    .Columns("Fecha_Factura_SUNAT").TextAlignment = TextAlignment.Center
                    .Columns("Fecha_Factura_SUNAT").Caption = "FECHA FACTURA SUNAT"
                    .Columns("Embarque").Width = 200
                End With
            End With
        End If
    End Sub

    Private Sub BtnArchivos_Click(sender As Object, e As EventArgs) Handles BtnArchivos.Click
        Carga_Archivos_ECR()
    End Sub

    Private Sub BtnGrabar_Click(sender As Object, e As EventArgs) Handles BtnGrabar.Click
        Try
            If Strings.Len(Trim(txtFec_ECR.Text)) = 0 Or Strings.Len(Trim(txtFec_ECR.Text)) > 10 Then
                MessageBox.Show("Ingrese Fecha Valida..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Strings.Right(DtpHoraECR.Value, 8) = "00:00:00" Or Strings.Len(DtpHoraECR.Value) = 10 Then
                MessageBox.Show("Verificar Hora ingresada..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If FraArchivo.Visible = False And FraArchivos.Visible = False Then
                MessageBox.Show("Seleccione Archivos..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            For i = 1 To GridEX2.RowCount
                GridEX2.Row = 1
                If (oHP.DevuelveDato("SELECT DBO.DEVUELVE_FECHA_MOV_APT(" + Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Embarque").Index)) + ",'" + txtFec_ECR.Text + "')", cCONNECT)) = 1 Then
                    MessageBox.Show("Embarque : " + Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Embarque").Index)) + vbCrLf + "Fecha Evento Comprometido es MENOR al Movimiento APT..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            Next i

            If FraArchivo.Visible = True Then
                If Trim(TxtRutaArchivo.Text) <> "" Then
                    For i = 1 To GridEX2.RowCount
                        GridEX2.Row = i
                        Grabar(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Nro.Factura").Index)), Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Embarque").Index)))
                    Next i

                    MessageBox.Show("Fecha y Hora Actualizada Correctamente." & vbCrLf & "Archivos Almacenados en Red", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtRutaArchivo.Text = ""
                    GridEX1.DataSource = Nothing
                    FraArchivo.Visible = False
                    FraArchivos.Visible = False
                    Exit Sub
                End If
            End If

            If FraArchivos.Visible = True Then
                If GridEX1.RowCount > 0 Then
                    For i = 1 To GridEX2.RowCount
                        GridEX2.Row = i
                        Grabar(Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Nro.Factura").Index)), Trim(GridEX2.GetValue(GridEX2.RootTable.Columns("Embarque").Index)))
                    Next i

                    MessageBox.Show("Fecha y Hora Actualizada Correctamente." & vbCrLf & "Archivos Almacenados en Red", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    TxtRutaArchivo.Text = ""
                    GridEX1.DataSource = Nothing
                    FraArchivo.Visible = False
                    FraArchivos.Visible = False
                End If
            End If

            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Grabar(x_Factura As String, x_Embarque As String)
        Try
            Dim i As Integer

            If Strings.Right(DtpHoraECR.Value, 8) = "00:00:00" Or Strings.Len(DtpHoraECR.Value) = 10 Then
                MessageBox.Show("Verificar Hora ingresada..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            vlRuta_ = oHP.DevuelveDato("exec SP_MUESTRA_RUTA_EXPORTACION '" & vusu & "'", cCONNECT)

            If Strings.Len(Trim(vlRuta_)) = 0 Then
                MessageBox.Show("Verificar Acceso y Ruta de Usuario..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            vlRuta_ = vlRuta_ & "\" & x_Factura & "-" & x_Embarque

            If FraArchivo.Visible = True Then
                If System.IO.File.Exists(vlRuta_) Then
                    vlRuta_ = vlRuta_
                Else
                    Directory.CreateDirectory(vlRuta_)
                End If

                If CopiarArchivos(TxtRutaArchivo.Text, vlRuta_ & "\") = False Then
                    EliminarArchivos(vlRuta_)
                End If
            End If

            If FraArchivos.Visible = True Then
                If System.IO.File.Exists(vlRuta_) Then
                    vlRuta_ = vlRuta_
                Else
                    Directory.CreateDirectory(vlRuta_)
                End If

                Dim vlcadena As String

                For i = 1 To GridEX1.RowCount
                    GridEX1.Row = i
                    vlcadena = Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Ruta_Archivo").Index)) & "\" & Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Nombre_Archivo").Index))
                    If CopiarArchivos(vlcadena, vlRuta_ & "\") = False Then
                        EliminarArchivos(vlRuta_)
                    End If
                Next i
            End If

            If Procesar(x_Embarque, txtFec_ECR.Text, DtpHoraECR.Value) = False Then
                EliminarArchivos(vlRuta_)
            End If

        Catch ex As Exception
            EliminarArchivos(vlRuta_)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Function Procesar(sEmbarque As String, sFecha As String, sHora As String) As Boolean
        Try
            Dim rsp As String

            Procesar = False
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_REGISTRA_FECHA_HORA_ECR_EXPORTACIONES"
            strSQL &= vbNewLine & String.Format(" @EMBARQUE     = '{0}'", sEmbarque)
            strSQL &= vbNewLine & String.Format(",@FECHA_ECR    = '{0}'", sFecha)
            strSQL &= vbNewLine & String.Format(",@HORA_ECR     = '{0}'", Strings.Right(sHora, 8))
            strSQL &= vbNewLine & String.Format(",@COD_USER     = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@PC           = '{0}'", Trim(Environ("computername")))

            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            Dim oDr As DataRow
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then Exit Function
                rsp = oDr("Mensaje")
            End If

            If Trim(rsp) = "" Then
                Procesar = True
            Else
                Procesar = False
                MessageBox.Show(rsp, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Public Function CopiarArchivos(sRutaOrigen As String, sRutaFin As String) As Boolean
        Try
            If System.IO.File.Exists(sRutaOrigen) Then
                System.IO.File.Copy(sRutaOrigen, sRutaFin, True)
                CopiarArchivos = True
            Else
                CopiarArchivos = False
                MessageBox.Show("No se encontro el archivo en la siguiente ruta:" + vbCrLf + sRutaOrigen, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Exit Function
        Catch ex As Exception
            CopiarArchivos = False
        End Try
    End Function

    Sub EliminarArchivos(sxRuta As String)
        Dim x As Integer
        Dim vlcadena As String
        Dim sFullPath As String
        Dim sFullFilename As String

        If System.IO.File.Exists(sxRuta) Then
            If FraArchivo.Visible = True Then
                If Trim(TxtRutaArchivo.Text) <> "" Then
                    sFullPath = Trim(TxtRutaArchivo.Text)
                    sFullFilename = Strings.Right(sFullPath, Len(sFullPath) - InStrRev(sFullPath, "\"))
                    System.IO.File.Delete(sxRuta + "\" + sFullFilename)
                End If
            End If

            If FraArchivos.Visible = True Then
                For x = 1 To GridEX1.RowCount
                    GridEX1.Row = x
                    vlcadena = "\" & Trim(GridEX1.GetValue(GridEX1.RootTable.Columns("Nombre_Archivo").Index))
                    vlcadena = sxRuta + vlcadena
                    System.IO.File.Delete(vlcadena)
                Next x
            End If
        Else
        End If
            MessageBox.Show("Los Archvios Copiados Fueron Eliminados..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Sub Carga_Archivos_ECR()
        Try
            Dim Archivos() As String
            Dim i As Long, flag As String
            Dim posicionExt As Integer

            OpenFileDialog1.Filter = "All Files|*.*"
            OpenFileDialog1.FileName = ""
            If OpenFileDialog1.ShowDialog(Me) = Windows.Forms.DialogResult.OK Then
                Archivos = Split(OpenFileDialog1.FileName, Chr(0))

                If UBound(Archivos) > 0 Then
                    For i = 1 To UBound(Archivos)
                        posicionExt = InStrRev(Archivos(i), ".")
                        Dim oDrNUEVO As DataRow = oDtArchivos.NewRow()
                        oDrNUEVO("Ruta_Archivo") = Archivos(0)
                        oDrNUEVO("Nombre_Archivo") = Archivos(i)
                        oDrNUEVO("Formato_Archivo") = CStr(Strings.Right(Archivos(i), Len(Archivos(i)) - posicionExt))
                        oDtArchivos.Rows.Add(oDrNUEVO)
                    Next i

                    GridEX1.DataSource = oDtArchivos
                    CheckLayoutGridEx(GridEX1)

                    With GridEX1
                        .FilterMode = FilterMode.Automatic
                        .DefaultFilterRowComparison = FilterConditionOperator.Contains
                        With .RootTable
                            .HeaderLines = 2
                            .PreviewRow = False
                            .PreviewRowLines = 10
                            .RowHeight = 25
                            For Each oGridEXColumn As GridEXColumn In .Columns
                                With oGridEXColumn
                                    .WordWrap = True
                                    .FilterEditType = FilterEditType.Combo
                                End With
                            Next
                            .Columns("Ruta_Archivo").Width = 180
                            .Columns("Nombre_Archivo").Width = 220
                            .Columns("Nombre_Archivo").Caption = "NOMBRE ARCHIVO"
                            .Columns("Formato_Archivo").Width = 130
                        End With
                    End With
                    TxtRutaArchivo.Text = ""
                    FraArchivo.Visible = False
                    FraArchivos.Visible = True
                Else
                    If Trim(OpenFileDialog1.FileName) = "" Then
                        GridEX1.DataSource = Nothing
                        TxtRutaArchivo.Text = ""
                        FraArchivos.Visible = False
                        FraArchivo.Visible = False
                        Exit Sub
                    End If
                    GridEX1.DataSource = Nothing
                    FraArchivos.Visible = False
                    TxtRutaArchivo.Text = OpenFileDialog1.FileName
                    FraArchivo.Visible = True
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class