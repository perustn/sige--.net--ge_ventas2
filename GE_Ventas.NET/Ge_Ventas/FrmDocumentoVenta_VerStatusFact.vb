Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_VerStatusFact
    Private strSQL As String = String.Empty
    Private strSQLTraza As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Const K_strColCheck As String = "ColCheck"

    Private Sub FrmDocumentoVenta_VerStatusFact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))

        Me.ActiveControl = TxtCodTipoDoc
    End Sub

    Private Sub TxtCodTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodTipoDoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_TipoDoc(1)
        End If
    End Sub

    Private Sub TxtDesTipoDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDesTipoDoc.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_TipoDoc(2)
        End If
    End Sub

    Sub Busca_TipoDoc(Opcion As Integer)
        Dim oTipo As New frmBusGeneral7
        Select Case Opcion
            Case 1
                oTipo.sQuery = "SELECT COD_TIPDOC AS CODIGO, DES_TIPDOC AS DESCRIPCION FROM CN_TIPOSDOCUM WHERE COD_TIPDOC LIKE '%" & Trim(TxtCodTipoDoc.Text) & "%'"
            Case 2
                oTipo.sQuery = "SELECT COD_TIPDOC AS CODIGO, DES_TIPDOC AS DESCRIPCION FROM CN_TIPOSDOCUM WHERE DES_TIPDOC LIKE '%" & Trim(TxtDesTipoDoc.Text) & "%'"
        End Select
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            TxtCodTipoDoc.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
            TxtDesTipoDoc.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
            TxtSerie.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                TxtCodTipoDoc.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                TxtDesTipoDoc.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                TxtSerie.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerie.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNumero.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpInicio.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub dtpInicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpInicio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpFin.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub dtpFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFin.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCodEnvio.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtCodEnvio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodEnvio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Envio(1)
        End If
    End Sub

    Private Sub txtDesEnvio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesEnvio.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Envio(2)
        End If
    End Sub

    Sub Busca_Envio(Opcion As Integer)
        Dim oTipo As New frmBusGeneral7
        Select Case Opcion
            Case 1
                oTipo.sQuery = "SELECT flg_status_envio_facturacion_electronica AS CODIGO, des_status_envio_facturacion_electronica AS DESCRIPCION FROM CN_Ventas_Status_Envio_Facturacion_Electronica WHERE flg_status_envio_facturacion_electronica LIKE '%" & Trim(txtCodEnvio.Text) & "%'"
            Case 2
                oTipo.sQuery = "SELECT flg_status_envio_facturacion_electronica AS CODIGO, des_status_envio_facturacion_electronica AS DESCRIPCION FROM CN_Ventas_Status_Envio_Facturacion_Electronica WHERE des_status_envio_facturacion_electronica LIKE '%" & Trim(txtDesEnvio.Text) & "%'"
        End Select
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodEnvio.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
            txtDesEnvio.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
            txtCodProceso.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCodEnvio.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                txtDesEnvio.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                txtCodProceso.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCodProceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodProceso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Proceso(1)
        End If
    End Sub

    Private Sub txtDesProceso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesProceso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Proceso(2)
        End If
    End Sub

    Sub Busca_Proceso(Opcion As Integer)
        Dim oTipo As New frmBusGeneral7
        Select Case Opcion
            Case 1
                oTipo.sQuery = "SELECT flg_status_proceso_facturacion_electronica AS CODIGO, des_status_proceso_facturacion_electronica AS DESCRIPCION FROM CN_Ventas_Status_Proceso_Facturacion_Electronica WHERE flg_status_proceso_facturacion_electronica LIKE '%" & Trim(txtCodProceso.Text) & "%'"
            Case 2
                oTipo.sQuery = "SELECT flg_status_proceso_facturacion_electronica AS CODIGO, des_status_proceso_facturacion_electronica AS DESCRIPCION FROM CN_Ventas_Status_Proceso_Facturacion_Electronica WHERE des_status_proceso_facturacion_electronica LIKE '%" & Trim(txtDesProceso.Text) & "%'"
        End Select
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodProceso.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
            txtDesProceso.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
            txtCodValidacion.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCodProceso.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                txtDesProceso.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                txtCodValidacion.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCodValidacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodValidacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Validacion(1)
        End If
    End Sub

    Private Sub txtDesValidacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesValidacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Busca_Validacion(2)
        End If
    End Sub

    Sub Busca_Validacion(Opcion As Integer)
        Dim oTipo As New frmBusGeneral7
        Select Case Opcion
            Case 1
                oTipo.sQuery = "SELECT Flg_Status_Validacion_Facturacion_Electronica AS CODIGO, Des_Status_Validacion_Facturacion_Electronica AS DESCRIPCION FROM CN_Ventas_Status_Validacion_Facturacion_Electronica WHERE Flg_Status_Validacion_Facturacion_Electronica LIKE '%" & Trim(txtCodValidacion.Text) & "%'"
            Case 2
                oTipo.sQuery = "SELECT Flg_Status_Validacion_Facturacion_Electronica AS CODIGO, Des_Status_Validacion_Facturacion_Electronica AS DESCRIPCION FROM CN_Ventas_Status_Validacion_Facturacion_Electronica WHERE Des_Status_Validacion_Facturacion_Electronica LIKE '%" & Trim(txtDesValidacion.Text) & "%'"
        End Select
        oTipo.oParent = Me
        oTipo.Cargar_Datos()

        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodValidacion.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
            txtDesValidacion.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
            BtnBuscar.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCodValidacion.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                txtDesValidacion.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                BtnBuscar.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub

    Public Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Validar_Envio_Facturacion_Electronica"
        strSQL &= vbNewLine & String.Format(" @COD_TIPDOC       = '{0}'", TxtCodTipoDoc.Text)
        strSQL &= vbNewLine & String.Format(",@FEC_INICIO       = '{0}'", dtpInicio.Value.ToShortDateString)
        strSQL &= vbNewLine & String.Format(",@FEC_FINAL        = '{0}'", dtpFin.Value.ToShortDateString)
        strSQL &= vbNewLine & String.Format(",@SER_DOCUM        = '{0}'", TxtSerie.Text)
        strSQL &= vbNewLine & String.Format(",@COD_USUARIO_REGISTRO       = '{0}'", "")
        strSQL &= vbNewLine & String.Format(",@OPCION_ENVIO     = '{0}'", txtCodEnvio.Text)
        strSQL &= vbNewLine & String.Format(",@OPCION_PROCESO   = '{0}'", txtCodProceso.Text)
        strSQL &= vbNewLine & String.Format(",@num_docum_ventas = '{0}'", TxtNumero.Text)
        strSQL &= vbNewLine & String.Format(",@OPCION_VALIDACION= '{0}'", txtCodValidacion.Text)

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

                With .Columns(K_strColCheck)
                    .ActAsSelector = True
                    .BoundMode = ColumnBoundMode.Bound
                    .ColumnType = ColumnType.CheckBox
                    .EditType = EditType.CheckBox
                    .CheckBoxTrueValue = True
                    .CheckBoxFalseValue = False
                    .Width = 25
                    .Caption = String.Empty
                End With

                .Columns("Cod_TipDoc").Width = 50
                .Columns("Des_tipdoc").Width = 120
                .Columns("Ser_docum").Width = 50
                .Columns("num_docum_ventas").Width = 80
                .Columns("fec_emidoc").Width = 100
                .Columns("cod_tipanex").Width = 50
                .Columns("cod_anxo").Width = 80
                .Columns("des_anexo").Width = 180
                .Columns("imp_total").Width = 80
                .Columns("cod_moneda").Width = 50
                .Columns("nom_moneda").Width = 100
                .Columns("num_corre").Width = 50
                .Columns("Flg_Status_envio_facturacion_electronica").Width = 50
                .Columns("Flg_Status_proceso_Facturacion_Electronica").Width = 50
                .Columns("Flg_Status_Validacion_Facturacion_Electronica").Width = 50
            End With
        End With
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ACTEST"
                    If MessageBox.Show("¿Desea actualizar el Estado?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        Call Actualiza_Estado
                    End If

                Case "IMPDF"
                    ImprimirPDF()

                Case "IMTEXT"
                    ImprimirTexto()

                Case "IMCDR"
                    ImprimirCDR()

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Actualiza_Estado()
        Try
            If GrdLista.GetCheckedRows.Length Then
                For Each oGridEXRow As GridEXRow In GrdLista.GetCheckedRows
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC VENTAS_ACTUALIZAR_ESTADO_PROCESO"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE        = '{0}'", oGridEXRow.Cells("num_corre").Value)
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)
                    strSQL &= vbNewLine & String.Format(",@COD_ESTACION     = '{0}'", ComputerName())

                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next
                MessageBox.Show("Proceso realizado satisfactoriamente", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CARGA_GRID()
            Else
                MessageBox.Show("Debe Seleccionar Al Menos un Registro", "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub ImprimirPDF()
        Dim sruta As String
        Dim strSQL As String
        strSQL = "SELECT DBO.VENTAS_NOMBRE_ARCHIVO_PDF_FACTURACION_ELECTRONICA('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')"
        oHP.DevuelveDato(cCONNECT, strSQL)
        Call EjecutarArchivos(sruta)
    End Sub

    Sub ImprimirTexto()
        Dim strSQL As String
        Dim sruta As String
        strSQL = "SELECT DBO.VENTAS_NOMBRE_ARCHIVO_ERROR_FACTURACION_ELECTRONICA('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')"
        oHP.DevuelveDato(cCONNECT, strSQL)
        Call EjecutarArchivos(sruta)
    End Sub

    Sub ImprimirCDR()
        Dim strSQL As String
        Dim sruta As String
        strSQL = "SELECT DBO.VENTAS_NOMBRE_ARCHIVO_CDR_FACTURACION_ELECTRONICA('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')"
        oHP.DevuelveDato(cCONNECT, strSQL)
        Call EjecutarArchivos(sruta)
    End Sub

    Public Sub EjecutarArchivos(ruta As String)
        Try
            Dim ejecutarShell As Object
            ejecutarShell = Shell("rundll32.exe url.dll,FileProtocolHandler " & (ruta), 1)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error al procesar la información", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class