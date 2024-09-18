Imports Janus.Windows.GridEX
Imports Microsoft.Office.Interop
Imports System.Data.SqlClient
Imports System.Net
Imports RestSharp
Imports Newtonsoft.Json
Imports System.Text.Encoding

Public Class FrmDocumentoVentaExportacion
    Private strSQL As String = String.Empty
    Private strSQLTrazaImp As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private Seguridad As New ClsBtnSeguridad

    Private Const K_strColCheck As String = "SEL"
    Private FilaSeleccionada As Integer

    Private OpcionFiltroBusqueda As String
    Private Cod_Cliente As String
    Dim vlRuta_ As String
    Dim StrColBoton As String
    Public NombreXLT As String
    Public Eventos_Parametrizables_BotonesOcultos As String
    Dim IsCambioOK As Boolean
    Public indicegrilla As Long
    Public strCod_Anxo As String
    Private strSQL_Imp As String
    Dim Envio As New EnvioTrama

    Private oDtCabecera As New DataTable
    Private oDtDetalle As New DataTable
    Dim Importe As Double
    Dim ImportLetra As String

    Private Sub FrmDocumentoVentaExportacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))

        dtpFecEmiIni.Value = Now.Date
        dtpFecEmiFin.Value = Now.Date

        Seguridad.GetBotonesJanus(vper, vemp, Me.Name, Me.ButtonBar1, "")
        Seguridad.GetBotonesJanus(vper, vemp, Me.Name, Me.ButtonBar2, "")
        Seguridad.GetBotonesJanus(vper, vemp, Me.Name, Me.ButtonBar3, "")

        indicegrilla = 1
        OpcionFiltroBusqueda = "F"
        vlRuta_ = oHP.DevuelveDato("exec SP_MUESTRA_RUTA_EXPORTACION '" & vusu & "'", cCONNECT)
        StrColBoton = "Archivos"

        Eventos_Parametrizables_BotonesOcultos = oHP.DevuelveDato("select dbo.sm_valida_Tg_Eventos_Parametrizables(302)", cCONNECT)
        If Eventos_Parametrizables_BotonesOcultos = "S" Then
            ButtonBar2.Groups(0).Items("FACTURACMT").Enabled = True
            ButtonBar2.Groups(0).Items("GUIACMT").Enabled = True
            ButtonBar1.Groups(0).Items("CMT").Enabled = True
        Else
            ButtonBar2.Groups(0).Items("FACTURACMT").Enabled = False
            ButtonBar2.Groups(0).Items("GUIACMT").Enabled = False
            ButtonBar1.Groups(0).Items("CMT").Enabled = False
        End If
    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles PanelGuia.Paint
        FondoDegradeDiagonalEnPanel(sender, e, colEmpresa)
    End Sub

    Private Sub OpcionBusqueda(sender As Object, e As EventArgs) Handles OptFecha.Click,
                                                                         OptNroDocumento.Click,
                                                                         OptCorrelativo.Click,
                                                                         OptConsignatario.Click,
                                                                         OptClienteComercial.Click,
                                                                         OptAnioMes.Click
        LimpiarTextos()
        Select Case (sender.TAG)
            Case "1"    'Por Fecha
                grbFechaEmision.Visible = True
                OpcionFiltroBusqueda = "F"
                dtpFecEmiIni.Focus()

            Case "2"    'Por Consignatario
                grbConsignatario.Visible = True
                OpcionFiltroBusqueda = "C"
                txtNum_Ruc.Focus()

            Case "3"    'Por Año-Mes
                grbAnioMes.Visible = True
                OpcionFiltroBusqueda = "A"
                txtAno.Focus()

            Case "4"    'Por Nro Documento
                grbNroDocumento.Visible = True
                OpcionFiltroBusqueda = "N"
                txtCod_TipDoc.Focus()

            Case "5"    'Por Correlativo
                grbCorrelativo.Visible = True
                OpcionFiltroBusqueda = "O"
                txtNum_Corre.Focus()

            Case "6"    'Por Cliente Comercial
                grbClienteComercial.Visible = True
                OpcionFiltroBusqueda = "M"
                txtAbr_Cliente.Focus()
        End Select
    End Sub

    Sub LimpiarTextos()
        grbFechaEmision.Visible = False
        grbConsignatario.Visible = False
        grbAnioMes.Visible = False
        grbNroDocumento.Visible = False
        grbCorrelativo.Visible = False
        grbClienteComercial.Visible = False

        txtNum_Ruc.Text = String.Empty
        txtDes_Anexo.Text = String.Empty
        'txtCod_TipAnxo.Text = String.Empty
        'txtDes_TipAnxo.Text = String.Empty
        txtAno.Text = String.Empty
        txtMes.Text = String.Empty
        txtCod_TipDoc.Text = String.Empty
        txtDes_TipDoc.Text = String.Empty
        txtSer_Docum.Text = String.Empty
        txtNum_Docum.Text = String.Empty
        txtNum_Corre.Text = String.Empty
        txtAbr_Cliente.Text = String.Empty
        Cod_Cliente = String.Empty
        txtNom_Cliente.Text = String.Empty
        Chk_PO.Checked = False
        Txt_PO.Text = String.Empty
    End Sub

    Private Sub dtpFecEmiIni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecEmiIni.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            dtpFecEmiFin.Focus()
        End If
    End Sub

    Private Sub dtpFecEmiFin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecEmiFin.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub txtNum_Ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Ruc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion_Anexo(1)
        End If
    End Sub

    Private Sub txtDes_Anexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Anexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion_Anexo(2)
        End If
    End Sub

    Public Sub Busca_Opcion_Anexo(opcion As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me
        Select Case opcion
            Case 1 : oTipo.sQuery = "select Num_Ruc as Ruc, Des_Anexo as Nombre, Cod_Anxo as Cod from Cn_AnexosContables Where cod_tipanex ='" & Trim(txtCod_TipAnxo.Text) & "' and Num_Ruc like '%" & txtNum_Ruc.Text & "%'"
            Case 2 : oTipo.sQuery = "select Num_Ruc as Ruc, Des_Anexo as Nombre, Cod_Anxo as Cod from Cn_AnexosContables Where cod_tipanex ='" & Trim(txtCod_TipAnxo.Text) & "' and Des_Anexo Like '%" & txtDes_Anexo.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Ruc")
            Descripcion = oTipo.dtResultados.Rows(0)("Nombre")
            TipoAdd = oTipo.dtResultados.Rows(0)("Cod")
        End If

        If Codigo <> "" Then
            strCod_Anxo = Trim(TipoAdd)
            txtNum_Ruc.Text = Trim(Codigo)
            txtDes_Anexo.Text = Trim(Descripcion)
            txtCod_TipAnxo.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCod_TipAnxo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipAnxo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion(1)
        End If
    End Sub

    Private Sub txtDes_TipAnxo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipAnxo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion(2)
        End If
    End Sub

    Public Sub Busca_Opcion(opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        Select Case opcion
            Case 1 : oTipo.sQuery = "Select Cod_TipAnex AS Cod, Des_Tipanex as Descripcion from CN_TipoAnexoContable where Cod_TipAnex like '%" & txtCod_TipAnxo.Text & "%'"
            Case 2 : oTipo.sQuery = "Select Cod_TipAnex AS Cod, Des_Tipanex as Descripcion from CN_TipoAnexoContable where Des_Tipanex like '%" & txtDes_TipDoc.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_TipAnxo.Text = Trim(Codigo)
            txtDes_TipAnxo.Text = Trim(Descripcion)
            BtnBuscar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtAno_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAno.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtMes.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtMes_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMes.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtMes.Text = RellenaDeCerosEnIzquierda(txtMes.Text, 2)
            BtnBuscar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtCod_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion2(1)
        End If
    End Sub

    Private Sub txtDes_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion2(2)
        End If
    End Sub

    Public Sub Busca_Opcion2(opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        Select Case opcion
            Case 1 : oTipo.sQuery = "Select Cod_TipDoc AS Cod, Des_TipDoc as Descripcion from CN_TiposDocum where Flg_Doc_Ventas = '*' and Cod_TipDoc like '%" & txtCod_TipDoc.Text & "%'"
            Case 2 : oTipo.sQuery = "Select Cod_TipDoc AS Cod, Des_TipDoc as Descripcion from CN_TiposDocum where Flg_Doc_Ventas = '*' and Des_TipDoc like '%" & txtDes_TipDoc.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_TipDoc.Text = Trim(Codigo)
            txtDes_TipDoc.Text = Trim(Descripcion)
            txtSer_Docum.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtSer_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSer_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSer_Docum.Text = RellenaDeCerosEnIzquierda(txtSer_Docum.Text, 3)
            txtNum_Docum.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtNum_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Docum.Text = RellenaDeCerosEnIzquierda(txtNum_Docum.Text, 8)
            BtnBuscar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtNum_Corre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Corre.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Corre.Text = RellenaDeCerosEnIzquierda(txtNum_Corre.Text, 12)
            BtnBuscar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtAbr_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAbr_Cliente.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(txtAbr_Cliente.Text) = "" Then
                BuscaClienteComercial()
            Else
                strSQL = "SELECT Nom_Cliente FROM TG_CLIENTE WHERE Abr_Cliente LIKE '" & Trim(txtAbr_Cliente.Text) & "%'"
                txtNom_Cliente.Text = oHP.DevuelveDato(strSQL, cCONNECT)
                BtnBuscar.Focus()
            End If
        End If
    End Sub

    Private Sub txtNom_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Cliente.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Len(txtNom_Cliente) > 4 Then
                strSQL = "SELECT Abr_Cliente FROM TG_CLIENTE WHERE Nom_Cliente LIKE '" & Trim(txtNom_Cliente.Text) & "%'"
                txtAbr_Cliente.Text = oHP.DevuelveDato(strSQL, cCONNECT)
                strSQL = "SELECT Nom_Cliente FROM TG_CLIENTE WHERE Abr_Cliente='" & Trim(txtAbr_Cliente.Text) & "'"
                txtNom_Cliente.Text = oHP.DevuelveDato(strSQL, cCONNECT)
                BtnBuscar.Focus()
            Else
                MessageBox.Show("El Texto Ingresado debe contar con un mínimo de 5 caracteres", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtNom_Cliente.Focus()
            End If
        End If
    End Sub

    Private Sub BuscaClienteComercial()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT Abr_Cliente as Código, nom_cliente as Descripción FROM TG_Cliente ORDER BY Abr_Cliente"
        oTipo.Cargar_Datos()
        oTipo.ShowDialog()
        If Codigo <> "" Then
            txtAbr_Cliente.Text = Codigo
            txtNom_Cliente.Text = Descripcion
            Codigo = "" : Descripcion = ""
            If Chk_PO.Checked = True Then
                Txt_PO.Focus()
            Else
                BtnBuscar.Focus()
            End If
        End If
        oTipo = Nothing
    End Sub

    Private Sub Chk_PO_Click(sender As Object, e As EventArgs) Handles Chk_PO.Click
        If Me.Chk_PO.Checked = True Then
            fraPO.Visible = True
            OpcionFiltroBusqueda = "P"
            Txt_PO.Focus()
        Else
            Txt_PO.Text = String.Empty
            fraPO.Visible = False
            OpcionFiltroBusqueda = "M"
        End If
    End Sub

    Private Sub Txt_PO_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_PO.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargarGrilla()
    End Sub

    Public Sub CargarGrilla()
        Try

            If Me.OptClienteComercial.Checked = True Then
                strSQL = "SELECT Cod_Cliente FROM TG_CLIENTE WHERE Abr_Cliente LIKE '" & Trim(txtAbr_Cliente.Text) & "%'"
                Cod_Cliente = oHP.DevuelveDato(strSQL, cCONNECT)
            End If
            If txtAbr_Cliente.Text = "" Then Cod_Cliente = String.Empty

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Doc_Ventas_Export"
            strSQL &= vbNewLine & String.Format(" @StrOpcion        = '{0}'", OpcionFiltroBusqueda)
            strSQL &= vbNewLine & String.Format(",@FecIni           = '{0}'", dtpFecEmiIni.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@FecFin           = '{0}'", dtpFecEmiFin.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@Cod_Tipanex      = '{0}'", "C")
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo         = '{0}'", strCod_Anxo)
            strSQL &= vbNewLine & String.Format(",@Ano_Registro     = '{0}'", txtAno.Text)
            strSQL &= vbNewLine & String.Format(",@Mes_Registro     = '{0}'", txtMes.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", txtNum_Corre.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_TipDoc       = '{0}'", txtCod_TipDoc.Text)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", txtSer_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", txtNum_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Cod_Cliente      = '{0}'", Cod_Cliente)
            strSQL &= vbNewLine & String.Format(",@cod_purord       = '{0}'", Trim(Me.Txt_PO.Text))

            strSQL_Imp = String.Empty
            strSQL_Imp &= vbNewLine & "EXEC Ventas_Muestra_Doc_Ventas_Export_Rpt_Detallado"
            strSQL_Imp &= vbNewLine & String.Format(" @StrOpcion        = '{0}'", OpcionFiltroBusqueda)
            strSQL_Imp &= vbNewLine & String.Format(",@FecIni           = '{0}'", dtpFecEmiIni.Value.ToShortDateString)
            strSQL_Imp &= vbNewLine & String.Format(",@FecFin           = '{0}'", dtpFecEmiFin.Value.ToShortDateString)
            strSQL_Imp &= vbNewLine & String.Format(",@Cod_Tipanex      = '{0}'", "C")
            strSQL_Imp &= vbNewLine & String.Format(",@Cod_Anxo         = '{0}'", strCod_Anxo)
            strSQL_Imp &= vbNewLine & String.Format(",@Ano_Registro     = '{0}'", txtAno.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Mes_Registro     = '{0}'", txtMes.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", txtNum_Corre.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Cod_TipDoc       = '{0}'", txtCod_TipDoc.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", txtSer_Docum.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", txtNum_Docum.Text)
            strSQL_Imp &= vbNewLine & String.Format(",@Cod_Usuario      = '{0}'", vusu)
            strSQL_Imp &= vbNewLine & String.Format(",@Cod_Cliente      = '{0}'", Cod_Cliente)
            strSQL_Imp &= vbNewLine & String.Format(",@cod_purord       = '{0}'", Trim(Me.Txt_PO.Text))

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDT Is Nothing Then Exit Sub
            GrdLista.RootTable.Columns.Clear()
            GrdLista.DataSource = oDT
            CheckLayoutGridEx(GrdLista)

            With GrdLista
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

                    .Columns("COD_TIPDOC").Width = 37
                    .Columns("COD_TIPDOC").Caption = "TIP"
                    .Columns("SERIE").Width = 52
                    .Columns("SERIE").Caption = "SERIE"
                    .Columns("NRO_DOC").Width = 81
                    .Columns("NRO_DOC").Caption = "NRO_DOC"
                    .Columns("ANEXO").Width = 200
                    .Columns("ANEXO").Caption = "ANEXO"
                    .Columns("RUC").Width = 110
                    .Columns("RUC").Caption = "RUC"
                    .Columns("MONEDA").Width = 70
                    .Columns("MONEDA").Caption = "MONEDA"
                    .Columns("IMP_NETO").Width = 82
                    .Columns("IMP_NETO").Caption = "IMP NETO"
                    .Columns("IMP_IGV").Width = 70
                    .Columns("IMP_IGV").Caption = "IMP IGV"
                    .Columns("IMP_GASTOS_FINANCIEROS").Caption = "GASTOS FINANCIEROS"
                    .Columns("IMP_GASTOS_FINANCIEROS").Width = 99
                    .Columns("IMP_TOTAL").Width = 84
                    .Columns("IMP_TOTAL").Caption = "IMP TOTAL"
                    .Columns("IMP_OTROS").Width = 87
                    .Columns("IMP_OTROS").Caption = "IMP OTROS"
                    .Columns("EMISION").Width = 94
                    .Columns("EMISION").Caption = "EMISION"

                    .Columns("REGISTRO").Width = 94
                    .Columns("REGISTRO").Caption = "REGISTRO"
                    .Columns("VENCIMIENTO").Width = 94
                    .Columns("VENCIMIENTO").Caption = "VENCIMIENTO"
                    .Columns("CANCELADO").Width = 150
                    .Columns("CANCELADO").Caption = "CANCELADO"
                    .Columns("ANO_REGISTRO").Width = 109
                    .Columns("ANO_REGISTRO").Caption = "ANO_REGISTRO"
                    .Columns("MES_REGISTRO").Width = 111
                    .Columns("MES_REGISTRO").Caption = "MES_REGISTRO"
                    .Columns("NUM_REGISTRO").Width = 114
                    .Columns("NUM_REGISTRO").Caption = "NUM_REGISTRO"

                    With .Columns(K_strColCheck)
                        .Caption = "SEL"
                        .Visible = True
                        .ColumnType = ColumnType.CheckBox
                        .EditType = EditType.CheckBox
                        .ActAsSelector = True
                        .Width = 25
                        .Caption = String.Empty
                        .Position = 0
                    End With
                End With
            End With
            'GrdLista.Row = indicegrilla
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GrdLista_FormattingRow(sender As Object, e As RowLoadEventArgs) Handles GrdLista.FormattingRow
        Dim fs As New Janus.Windows.GridEX.GridEXFormatStyle
        If e.Row.RowType = RowType.Record Then
            If CType(e.Row.DataRow, DataRowView)("Feccha_Evento_Comprometido_Real").Equals("") Then 'Disponible
            Else
                fs.BackColor = System.Drawing.Color.FromArgb(192, 255, 255)
                'fs.ForeColor = Color.Blue
                e.Row.RowStyle = fs
            End If
        End If

        'If GridEX1.Columns.Count > 2 Then
        '    If RTrim(RowBuffer.Value(GridEX1.Columns("NUM_REGISTRO").Index)) <> "" Then
        '        RowBuffer.RowStyle = "DOLARES"
        '    End If
        'End If
    End Sub

    Private Sub BtnImprimir_Click(sender As Object, e As EventArgs) Handles BtnImprimir.Click
        Try
            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\Rpt_Ventas_Exportacion.xlsm")
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("reporte", strSQL_Imp, cCONNECTVB6)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            If GrdLista.RecordCount > 0 Then
                FilaSeleccionada = GrdLista.CurrentRow.Position
            End If

            Select Case e.Item.Key
                Case "VERDETALLE"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDet As New FrmDocumentoVentaExportacion_VerDetalle
                        With oDet
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .Text = "Detalle: " & GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) & " Nro " & GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & "-" & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .CargarGrilla()
                            .ShowDialog()
                            CargarGrilla()
                            GrdLista.Row = FilaSeleccionada
                        End With
                    End Using

                Case "REIMPRESION"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If GrdLista.GetValue(GrdLista.RootTable.Columns("id_formato_invoice").Index) <> 0 Then 'SI ES 1
                        Using oReimp As New FrmDocumentoVentaExportacion_Reimpresion
                            With oReimp
                                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                    NombreXLT = .NombreXLT
                                    ImprimirAvios(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                                End If
                            End With
                        End Using
                    Else
                        Dim xfil As Integer
                        xfil = GrdLista.Row
                        For Each oGridEXRow As GridEXRow In GrdLista.GetCheckedRows 'recorre la lista
                            If oHP.DevuelveDato("SELECT Estado From TB_FRM_ACTICACION WHERE NombreProceso = 'COLGADORES DICKS'", cCONNECT) = 1 Then
                                If oHP.DevuelveDato("SELECT DBO.TG_CLIENTE_DEVUELVE_FORMATO_NUEVO_INVOICE('" & oGridEXRow.Cells("Num_Corre").Value & "')", cCONNECT) = 1 Then
                                    ImprimirSTN_New_Invoice(oGridEXRow.Cells("Num_Corre").Value)
                                Else
                                    ImprimirSTN_Colgador(oGridEXRow.Cells("Num_Corre").Value)
                                End If
                            Else
                                ImprimirSTN(oGridEXRow.Cells("Num_Corre").Value)
                            End If
                        Next
                        GrdLista.Row = xfil
                    End If

                Case "ANULAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta Seguro de Anular este Documento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Man_Anula_Docum"
                        strSQL &= vbNewLine & String.Format(" @Num_Corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@Cod_Usuario  = '{0}'", vusu)

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                        End If
                    End If

                Case "REVIERTEDOCUM"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Esta Seguro de Revertir este Documento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Revierte_Docum"
                        strSQL &= vbNewLine & String.Format(" @Num_Corre_Ventas   = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@user_crea          = '{0}'", vusu)

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                            GrdLista.Row = FilaSeleccionada
                        End If
                    End If

                Case "DESPEXT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDesp As New FrmDocumentoVentaExportacion_DespachoExtemp
                        With oDesp
                            .Cod_TipDoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .TxtSerie.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If GrdLista.GetValue(GrdLista.RootTable.Columns("Despacho").Index) = "N" Then
                                .ChkDespacho.Checked = False
                            Else
                                .ChkDespacho.Checked = True
                            End If
                            .oParent = Me
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "FECDOC"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oFecha As New FrmDocumentoVentaExportacion_FechaEnvioDoc
                        With oFecha
                            .Cod_TipDoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .TxtSerie.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Envio_Documentos_Cobranza").Index)) Then
                                .DTPFecha.Checked = False
                            Else
                                .DTPFecha.Checked = True
                                .DTPFecha.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Envio_Documentos_Cobranza").Index)
                            End If
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "FECCOBREPRO"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oFecha As New FrmDocumentoVentaExportacion_FechaCobranza
                        With oFecha
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            If IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Cobranza_Reprogramada").Index)) Then
                                .DtpFecCobRepro.Checked = False
                            Else
                                .DtpFecCobRepro.Checked = True
                                .DtpFecCobRepro.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Cobranza_Reprogramada").Index)
                            End If
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "VEPACK"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oVer As New FrmDocumentoVentaExportacion_VerPacking
                        With oVer
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_CORRE").Index)
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using

                Case "REEMPFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oReem As New FrmDocumentoVentaExportacion_ReemplazarFactura
                        With oReem
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_CORRE").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "OTRGASDES"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oReem As New FrmDocumentoVentaExportacion_OtrosGastos
                        With oReem
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_CORRE").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "PREVIA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If GrdLista.GetValue(GrdLista.RootTable.Columns("id_formato_invoice").Index) <> 0 Then 'SI ES 1
                        Using oReimp As New FrmDocumentoVentaExportacion_Reimpresion
                            With oReimp
                                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                    NombreXLT = .NombreXLT
                                    ImprimirAvios(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                                End If
                            End With
                        End Using
                    Else

                        Importe = 0
                        ImportLetra = ""

                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC cn_facturacion_electronica_generar_txt_stn_ML_Rpt03"
                        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@OPCION       = '{0}'", "1")
                        strSQL &= vbNewLine & String.Format(",@MONTO        = '{0}'", 0)
                        strSQL &= vbNewLine & String.Format(",@MONTOPALABRA = '{0}'", "")
                        oDtCabecera = oHP.DevuelveDatos2(strSQL, cCONNECT)

                        Using oCn As New SqlConnection(cCONNECT)
                            Using oCmd As New SqlCommand("test", oCn)
                                With oCmd
                                    .CommandType = CommandType.StoredProcedure
                                    .CommandText = "cn_facturacion_electronica_generar_txt_stn_ML_Rpt03"
                                    .Parameters.Add("@num_corre", SqlDbType.Char, 12).Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                                    .Parameters.Add("@OPCION", SqlDbType.Char, 1).Value = "2"

                                    With .Parameters.Add("@MONTO", SqlDbType.Decimal)
                                        .Direction = ParameterDirection.Output
                                        .Value = 0
                                    End With
                                    With .Parameters.Add("@MONTOPALABRA", SqlDbType.VarChar, 8000)
                                        .Direction = ParameterDirection.Output
                                        .Value = ""
                                    End With
                                    .Connection.Open()
                                    oDtDetalle.Load(.ExecuteReader)
                                    '.ExecuteNonQuery()
                                    .Connection.Close()
                                End With
                                Importe = oCmd.Parameters("@MONTO").Value
                                ImportLetra = oCmd.Parameters("@MONTOPALABRA").Value
                            End Using
                        End Using

                        If oDtCabecera.Rows.Count > 0 And oDtDetalle.Rows.Count > 0 Then
                            Call ExportarRPT(oDtCabecera, oDtDetalle)
                        End If
                    End If

                Case "CMT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDet As New FrmDocumentoVentaExportacion_GenFacturasGuiasCMT
                        With oDet
                            .txtSerie.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .txtNumero.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .txtCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "ITEMOTROS"
                    'NO EXISTE EL SP EN NINGUNA BASE DE DATOS
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDet As New FrmDocumentoVentaExportacion_DetalleItem
                        With oDet
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_CORRE").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ImpCertiTLCCan(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\RptCerticadoTLCCan.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre)
        oo = Nothing
    End Sub

    Private Sub ImprimirAvios(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\" & NombreXLT)
        Dim RutaLogo As String
        RutaLogo = ""
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("App.Run", cCONNECTVB6, RutaLogo, sNum_Corre)
        oo = Nothing
    End Sub

    Private Sub ImprimirSTN_New_Invoice(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Rpt_Invoice_Travis_New.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", "CN_GENERA_DETALLE_PACKING_FACTURA_INVOICE '" & sNum_Corre & "'", "CN_GENERA_DETALLE_FACTURA_INVOICE '" & sNum_Corre & "'", cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub ImprimirSTN_Colgador(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\rptFacturaSTN_New.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", "Ventas_Exportacion_Vineyard_Vince_Cabecera '" & sNum_Corre & "'", "Ventas_Exportaciones_Genera_Lineas_Factura_Colgador '" & sNum_Corre & "'", "Ventas_Exportacion_Vineyard_Vince_Trailer  '" & sNum_Corre & "'", sNum_Corre, cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub ImprimirSTN(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\rptFacturaSTN.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", "Ventas_Exportacion_Vineyard_Vince_Cabecera '" & sNum_Corre & "'", "[Ventas_Exportaciones_Genera_Lineas_Factura] '" & sNum_Corre & "'", "Ventas_Exportacion_Vineyard_Vince_Trailer  '" & sNum_Corre & "'", sNum_Corre, cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub ButtonBar2_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar2.ItemClick
        Try
            If GrdLista.RecordCount > 0 Then
                FilaSeleccionada = GrdLista.CurrentRow.Position
            End If

            Select Case e.Item.Key
                Case "CERTLACAN"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    ImpCertiTLCCan(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                Case "ELIMFANULADA"
                    Using oAnul As New FrmDocumentoVentaExportacion_AnularFactura
                        With oAnul
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "MODPESBRU"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oModPesos As New FrmDocumentoVentaExportacion_ModificarPeso
                        With oModPesos
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .txtPesoBruAc.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Peso_Bruto").Index)
                            .txtPesoNetAc.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Peso_Neto").Index)
                            .txtPesoBruMod.Text = "0.00"
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ENVDOCEFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub

                    'ConsumirAPIGet(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                    'Exit Sub

                    If GrdLista.GetValue(GrdLista.RootTable.Columns("flg_enviado_FE").Index) = "S" Then
                        MessageBox.Show("Documento ya fue enviado a F.E., verifique!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If CDbl(GrdLista.GetValue(GrdLista.RootTable.Columns("Peso_Bruto").Index)) = 0 Then
                        MessageBox.Show("Documento debe tener PESO BRUTO, verifique!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    If CDbl(GrdLista.GetValue(GrdLista.RootTable.Columns("Peso_Neto").Index)) = 0 Then
                        MessageBox.Show("Documento debe tener PESO NETO, verifique!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    If oHP.DevuelveDato("select rtrim(isnull(guias, '')) from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT) = "" Then
                        MessageBox.Show("Documento no tiene Guia asociada, verifique!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    If CDbl(oHP.DevuelveDato("select num_cajas from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)) = 0 Then
                        MessageBox.Show("Documento debe tener cantidad de Cajas , verifique!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                    Call Ejecuta_Proceso()

                Case "DECJURF2"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Imprimir_DeclaJuradaF2(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                Case "QYCXFACTURA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oAct As New FrmDocumentoVentaExportacion_QYCFactura
                        With oAct
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "GUIAS"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oAct As New FrmDocumentoVentaExportacion_ActualizaGuias
                        With oAct
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .TxtGuias.Text = oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "FACTURACMT"
                    Call FacturaCMT_Devanlay()

                Case "GUIACMT"
                    Call GuiaCMT_Devanlay

                Case "VERCOBROS"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oAct As New FrmDocumentoVentaExportacion_VerCobros
                        With oAct
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "LIBERAR"
                    If GrdLista.RowCount > 0 Then
                        If MessageBox.Show("Desea Continuar con la Operación ?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            strSQL = String.Empty
                            strSQL &= vbNewLine & "EXEC VENTAS_REVIERTE_ACTUALIZACION_PRECIO_DDP"
                            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                            strSQL &= vbNewLine & String.Format(",@cod_usuario  = '{0}'", vusu)
                            strSQL &= vbNewLine & String.Format(",@cod_estacion = '{0}'", ComputerName)

                            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                                MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End If
                    End If

                Case "SEGUIMIENTO"
                    If GrdLista.RowCount > 0 Then
                        Using oSeg As New FrmDocumentoVentaExportacion_SeguimientoCobranza
                            With oSeg
                                .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                                .TxtCod_Concepto.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Tip_Glosa_Cobranza").Index))
                                .TxtDes_Concepto.Text = oHP.DevuelveDato("SELECT Descripcion FROM tg_tipos_tabla_detalle WHERE cod_tipo_tabla='017' and codigo ='" & .TxtCod_Concepto.Text & "'", cCONNECT)
                                If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Tip_Glosa_Cobranza").Index)) = "PRO" Then
                                    .DtpFecha.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Prevista_Cancelacion").Index)
                                End If
                                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                    CargarGrilla()
                                    GrdLista.Row = FilaSeleccionada = GrdLista.CurrentRow.Position
                                End If
                            End With
                        End Using
                    End If

                Case "DOCUMASO"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oAct As New FrmDocumentoVentaExportacion_DocumentosAsociados
                        With oAct
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "COPIADATFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oAct As New FrmDocumentoVentaExportacion_CopiaDatosFactura
                        With oAct
                            .TxtSerieOrigen.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .TxtDocumentoOrigen.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdLista.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ACTPREDDP"
                    If GrdLista.RowCount > 0 Then
                        Using oAct As New FrmDocumentoVentaExportacion_ActualizarPrecio
                            With oAct
                                .sIMP_Opc = "D"
                                .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                    CargarGrilla()
                                End If
                            End With
                        End Using
                    End If

                Case "CONSEMBEXP"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oEmb As New FrmTgEmbarque
                        With oEmb
                            .sOpcionBusqueda = "1"
                            .grpNumero.Visible = True
                            .txtNumero.Text = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("NUM_EMBARQUE").Index))
                            .CargaDatos()
                            .ShowDialog()
                        End With
                    End Using
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ConsumirAPIGet(v_Num_Corre As String)
        Try

            ServicePointManager.Expect100Continue = True
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls

            Dim client = New RestClient
            client.BaseUrl = New Uri("http://localhost:7143/externo/token/SOUTHERNTN")
            'client.BaseUrl = New Uri("http://192.168.30.23:6790/externo/token/SOUTHERNTN")

            Dim request = New RestRequest
            request.Method = Method.GET

            request.AddHeader("token", "fetch")

            Dim response = client.Execute(request).Content
            Dim xtoken = client.Execute(request).Headers(1).Value.ToString

            Dim jObject = JsonConvert.DeserializeObject(Of Respuesta)(response)

            If jObject.ok = False Then
                MessageBox.Show(jObject.erro.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub

            ElseIf jObject.ok = True Then
                ConsumoApiPost(xtoken, v_Num_Corre)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ConsumoApiPost(token As String, x_v_Num_Corre As String)
        Try

            Dim Dt_DetFact As New DataTable
            Dim vl_cant As Integer
            strSQL = String.Format("Exec Sp_Det_Fact_Exportacion_Api_integracion '{0}'", x_v_Num_Corre)
            Dt_DetFact = oHP.DevuelveDatos(strSQL, cCONNECT)

            If Dt_DetFact.Rows.Count > 0 Then
                Dim o_Factura As New factura
                Dim o_Item As New item
                vl_cant = Dt_DetFact.Rows.Count

                o_Factura.serie = Dt_DetFact.Rows(0)("serie")
                o_Factura.numero = Dt_DetFact.Rows(0)("numero")
                o_Factura.fecha = Dt_DetFact.Rows(0)("fecha")
                o_Factura.po = Dt_DetFact.Rows(0)("po_cab")
                o_Factura.clientecodigo = Dt_DetFact.Rows(0)("clientecodigo")
                o_Factura.clientenombre = Dt_DetFact.Rows(0)("clientenombre")
                o_Factura.montosubtotal = Dt_DetFact.Rows(0)("montosubtotal")
                o_Factura.montoigv = Dt_DetFact.Rows(0)("montoigv")
                o_Factura.montototal = Dt_DetFact.Rows(0)("montototal")
                o_Factura.programacodigo = Dt_DetFact.Rows(0)("programacodigo")
                o_Factura.programanombre = Dt_DetFact.Rows(0)("programanombre")
                o_Factura.divisioncodigo = Dt_DetFact.Rows(0)("divisioncodigo")
                o_Factura.divisionnombre = Dt_DetFact.Rows(0)("divisionnombre")
                o_Factura.enviotipocodigo = Dt_DetFact.Rows(0)("enviotipocodigo")
                o_Factura.enviotiponombre = Dt_DetFact.Rows(0)("enviotiponombre")
                o_Factura.temporada = Dt_DetFact.Rows(0)("temporada")
                o_Factura.prendas = Dt_DetFact.Rows(0)("prendas")

                Dim items(vl_cant - 1) As item 'ARRAY DE ITEMS

                For i As Integer = 0 To Dt_DetFact.Rows.Count - 1
                    items(i) = New item()
                    items(i).numero = Dt_DetFact.Rows(i)("item")
                    items(i).po = Dt_DetFact.Rows(i)("po_det")
                    items(i).estilocodigo = Dt_DetFact.Rows(i)("estilocodigo")
                    items(i).estilonombre = Dt_DetFact.Rows(i)("estilonombre")
                    items(i).colorcodigo = Dt_DetFact.Rows(i)("colorcodigo")
                    items(i).colornombre = Dt_DetFact.Rows(i)("colornombre")
                    items(i).cantidad = Dt_DetFact.Rows(i)("cantidad")
                    items(i).precio = Dt_DetFact.Rows(i)("precio")
                Next

                o_Factura.items = items

                ServicePointManager.Expect100Continue = True
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls

                Dim client = New RestClient
                client.BaseUrl = New Uri("http://localhost:7143/externo/facturacion/SOUTHERNTN")

                Dim request = New RestRequest
                request.Method = Method.POST

                request.AddHeader("token", token)

                Dim json_envio = JsonConvert.SerializeObject(o_Factura)

                request.AddJsonBody(o_Factura)

                Dim response = client.Execute(request).Content

                Dim jObject = JsonConvert.DeserializeObject(Of Respuesta)(response)

                If jObject.ok = False Then
                    MessageBox.Show(jObject.erro.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub

                ElseIf jObject.ok = True Then
                    'ConsumoApiPost(xtoken, v_Num_Corre)
                End If

            End If


        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Class Respuesta
        Public Property ok As String
        Public Property data As String
        Public Property erro As String

    End Class

    Public Class factura
        Public Property serie As String
        Public Property numero As String
        Public Property fecha As String
        Public Property po As String
        Public Property clientecodigo As String
        Public Property clientenombre As String
        Public Property montosubtotal As Decimal
        Public Property montoigv As Decimal
        Public Property montototal As Decimal
        Public Property programacodigo As String
        Public Property programanombre As String
        Public Property divisioncodigo As String
        Public Property divisionnombre As String
        Public Property enviotipocodigo As String
        Public Property enviotiponombre As String
        Public Property temporada As String
        Public Property prendas As Integer
        Public Property items() As item()

    End Class

    Public Class item
        Public Property numero As Integer
        Public Property po As String
        Public Property estilocodigo As String
        Public Property estilonombre As String
        Public Property colorcodigo As String
        Public Property colornombre As String
        Public Property cantidad As Decimal
        Public Property precio As Decimal

    End Class

    Private Sub Imprimir_DeclaJuradaF2(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\rptDeclaracionJuradaF2.XLT")
        oo.Visible = False
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre)
        oo = Nothing
    End Sub

    Sub Ejecuta_Proceso()
        Try
            Dim cadena As String, Servidor_FE As String, Servidor_GR As String
            Dim url As String, url_GR As String
            Dim Flg_Genera_info_cmt As Boolean

            Servidor_FE = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA", cCONNECT)
            Servidor_GR = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA_GR", cCONNECT)

            'http://192.168.30.4:5002/ca4xml

            If MessageBox.Show("¿Está seguro de enviar a Sunat - " & IIf(Strings.Left(Servidor_FE, 19) = "http://192.168.30.4", "Producción", "Pruebas") & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.No Then
                Exit Sub
            End If

            'Datos para consignacion
            Dim Val As String
            If MessageBox.Show("Desea Ingresar Datos de Consignación a la Factura?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Val = InputBox("Ingrese Dirección", "Datos Consignación.!")
                If Trim(Val) = "" Or Len(Trim(Val)) = 0 Then
                    MessageBox.Show("Debe Ingresar Dirección..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If
            End If

            If oHP.DevuelveDato("SELECT DBO.CN_FUNC_DEVUELVE_FLG_MUESTRAS_COURIER('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')", cCONNECT) = "M" Then
                ''validacion para GR Muestras
                If Ejecuta_Proceso_Muestras(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index), "M") = False Then
                    Exit Sub
                End If
            End If

            If oHP.DevuelveDato("SELECT DBO.CN_FUNC_DEVUELVE_FLG_MUESTRAS_COURIER('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')", cCONNECT) = "C" Then
                ''validacion para GR COURIER
                If Ejecuta_Proceso_Courier(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index), "C") = False Then
                    Exit Sub
                End If
            End If

            ''''''''''''''''''''''''''''
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_facturacion_electronica_generar_txt_stn_ML03"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
            strSQL &= vbNewLine & String.Format(",@OPCION       = '{0}'", "1")
            strSQL &= vbNewLine & String.Format(",@CONSIG       = '{0}'", "")
            Dim oDt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDt.Rows.Count = 0 Then
                MessageBox.Show("No se encontro datos para cabecera del comprobante..!!!", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                cadena = oDt.Rows(0)(0).ToString
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_facturacion_electronica_generar_txt_stn_ML03"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
            strSQL &= vbNewLine & String.Format(",@OPCION       = '{0}'", "2")
            strSQL &= vbNewLine & String.Format(",@CONSIG       = '{0}'", Val)
            Dim oDtS As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDtS.Rows.Count = 0 Then
                MessageBox.Show("No se encontro datos para cabecera del comprobante..!!!", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                cadena = cadena & oDtS.Rows(0)(0).ToString
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_facturacion_electronica_generar_txt_stn_ML03"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
            strSQL &= vbNewLine & String.Format(",@OPCION       = '{0}'", "3")
            strSQL &= vbNewLine & String.Format(",@CONSIG       = '{0}'", "")
            Dim oDt3 As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
            If oDt3.Rows.Count = 0 Then
                MessageBox.Show("No se encontro datos para cabecera del comprobante..!!!", "SIGE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            Else
                cadena = cadena & oDt3.Rows(0)(0).ToString
            End If

            '192.168.30.4 produccion
            '192.168.30.9 pruebas

            Dim Datos As String = cadena
            url = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA ", cCONNECT) 'Servidor_FE & ":5002/ca4xml"
            url_GR = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA_GR ", cCONNECT)
            Dim docid As String = "FF12-001"
            Dim comando As String = "emitir"
            Dim parametro As String = ""
            Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
            If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC cn_Ventas_Actualiza_flg_EnviadoFE"
                strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
                oHP.EjecutaOperacion(strSQL, cCONNECT)
                '--PROCESO PARA GENERACION DE INFORMACION FACTURA CMT
                Flg_Genera_info_cmt = oHP.DevuelveDato("select dbo.F_PERMITE_GENERAR_INFORMACION_CMT_DESDE_FAC_EXP()", cCONNECT)
                If Flg_Genera_info_cmt = True Then
                    Dim I As Integer
                    Dim xNum_Corre, xCod_Cliente, xPO, xEstilo, xDoc As String

                    '''CAMBIE EL PROCESO PARA QUE EL TIEMPO DE ESPERA SEA MEJOR Y NO HAYA PROBLEMAS CON LAS GUIAS Y FACTURAS DE CMT - MLEON.
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC SP_GENERA_DOC_AUTO_GUIA_FACT_CMT_DESDE_FACT_EXP"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
                    Dim oDtTablaData As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

                    If oDtTablaData.Rows.Count > 0 Then
                        For Each odr As DataRow In oDtTablaData.Rows
                            cadena = ""
                            xNum_Corre = ""
                            xCod_Cliente = ""
                            xPO = ""
                            xEstilo = ""
                            xDoc = ""

                            cadena = Trim(odr("TRAZA_GUIA"))
                            xNum_Corre = Trim(odr("Num_Corre"))
                            xCod_Cliente = Trim(odr("Cod_Cliente"))
                            xPO = Trim(odr("PO"))
                            xEstilo = Trim(odr("Estilo"))
                            xDoc = Trim(odr("GUIA"))
                            '                    url = Servidor_FE & ":5002/ca4xml"
                            docid = xDoc '"FF12-001"
                            comando = "emitir"
                            parametro = ""
                            Datos = cadena
                            respuesta = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
                            If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                                strSQL = String.Empty
                                strSQL &= vbNewLine & "EXEC SP_ACTUALIZA_ENVIO_ELECTRONICO"
                                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", xNum_Corre)
                                strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", xPO)
                                strSQL &= vbNewLine & String.Format(",@ESTILO       = '{0}'", xEstilo)
                                strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", xCod_Cliente)
                                strSQL &= vbNewLine & String.Format(",@DOC          = '{0}'", xDoc)
                                strSQL &= vbNewLine & String.Format(",@TIP_DOC      = '{0}'", "GUIA")
                                strSQL &= vbNewLine & String.Format(",@MSJ          = '{0}'", respuesta)
                                oHP.EjecutaOperacion(strSQL, cCONNECT)
                            Else
                                strSQL = String.Empty
                                strSQL &= vbNewLine & "EXEC SP_ACTUALIZA_ENVIO_ELECTRONICO"
                                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", xNum_Corre)
                                strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", xPO)
                                strSQL &= vbNewLine & String.Format(",@ESTILO       = '{0}'", xEstilo)
                                strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", xCod_Cliente)
                                strSQL &= vbNewLine & String.Format(",@DOC          = '{0}'", xDoc)
                                strSQL &= vbNewLine & String.Format(",@TIP_DOC      = '{0}'", "GUIA")
                                strSQL &= vbNewLine & String.Format(",@MSJ          = '{0}'", respuesta)
                                oHP.EjecutaOperacion(strSQL, cCONNECT)
                            End If

                            cadena = Trim(odr("TRAZA_FACT"))
                            xNum_Corre = Trim(odr("Num_Corre"))
                            xCod_Cliente = Trim(odr("Cod_Cliente"))
                            xPO = Trim(odr("PO"))
                            xEstilo = Trim(odr("Estilo"))
                            xDoc = Trim(odr("FACTURA_CMT"))

                            docid = xDoc '"FF12-001"
                            comando = "emitir"
                            parametro = ""
                            Datos = cadena
                            respuesta = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
                            If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                                strSQL = String.Empty
                                strSQL &= vbNewLine & "EXEC SP_ACTUALIZA_ENVIO_ELECTRONICO"
                                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", xNum_Corre)
                                strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", xPO)
                                strSQL &= vbNewLine & String.Format(",@ESTILO       = '{0}'", xEstilo)
                                strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", xCod_Cliente)
                                strSQL &= vbNewLine & String.Format(",@DOC          = '{0}'", xDoc)
                                strSQL &= vbNewLine & String.Format(",@TIP_DOC      = '{0}'", "FACTURA")
                                strSQL &= vbNewLine & String.Format(",@MSJ          = '{0}'", respuesta)
                                oHP.EjecutaOperacion(strSQL, cCONNECT)
                            Else
                                strSQL = String.Empty
                                strSQL &= vbNewLine & "EXEC SP_ACTUALIZA_ENVIO_ELECTRONICO"
                                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", xNum_Corre)
                                strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", xPO)
                                strSQL &= vbNewLine & String.Format(",@ESTILO       = '{0}'", xEstilo)
                                strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", xCod_Cliente)
                                strSQL &= vbNewLine & String.Format(",@DOC          = '{0}'", xDoc)
                                strSQL &= vbNewLine & String.Format(",@TIP_DOC      = '{0}'", "FACTURA")
                                strSQL &= vbNewLine & String.Format(",@MSJ          = '{0}'", respuesta)
                                oHP.EjecutaOperacion(strSQL, cCONNECT)
                            End If
                        Next
                    End If
                End If
            Else
                MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Function Ejecuta_Proceso_Muestras(vlNum_Corre As String, vTipo As String) As Boolean
        Using oRem As New FrmDocumentoVentaExportacion_MuestraGuiaRemision
            With oRem
                .TxtNroCorrelativo.Text = vlNum_Corre
                .v_Tipo = vTipo
                .Text = "Impresión GR - Muestras"
                .ShowDialog()
            End With
        End Using
        If oHP.DevuelveDato("select count(*) From TG_Cn_Ventas_GR_Muestras_Exportacion where Num_Corre = '" & vlNum_Corre & "'", cCONNECT) = 0 Then
            Ejecuta_Proceso_Muestras = False
        Else
            Ejecuta_Proceso_Muestras = True
        End If
    End Function

    Public Function Ejecuta_Proceso_Courier(vlNum_Corre As String, vTipo As String) As Boolean
        Using oRem As New FrmDocumentoVentaExportacion_MuestraGuiaRemision
            With oRem
                .TxtNroCorrelativo.Text = vlNum_Corre
                .v_Tipo = vTipo
                .Text = "Impresión GR - Courier"
                .ShowDialog()
            End With
        End Using
        If oHP.DevuelveDato("SELECT COUNT(*) FROM CN_VENTAS WHERE LEN(LTRIM(RTRIM(ISNULL(GUIAS,'')))) > 2 AND NUM_CORRE = '" & vlNum_Corre & "'", cCONNECT) = 0 Then
            Ejecuta_Proceso_Courier = False
        Else
            Ejecuta_Proceso_Courier = True
        End If
    End Function

    Private Function CarpetaExist()
        Dim NombreCarpeta As String
        Dim ExisteCarpeta As String
        Dim RutaDoc As String
        RutaDoc = Environ("UserProfile")

        NombreCarpeta = RutaDoc & "\txt_docum_temporal"
        ExisteCarpeta = Dir(NombreCarpeta, vbDirectory)

        If ExisteCarpeta = "" Then
            MkDir(NombreCarpeta)
        End If
    End Function

    Private Function MoverTxt(NombreTxtNew)
        Dim NombreCarpeta As String
        Dim NombreCarpetaDestino As String
        Dim ExisteCarpeta As String
        Dim RutaDoc As String
        RutaDoc = Environ("UserProfile")

        NombreCarpeta = RutaDoc & "\txt_docum_temporal\" & NombreTxtNew & ".txt"
        NombreCarpetaDestino = "\\172.16.87.19\esuite_suc\in\" & NombreTxtNew & ".txt"
        ExisteCarpeta = Dir(NombreCarpeta)

        If ExisteCarpeta <> "" Then
            FileCopy(NombreCarpeta, NombreCarpetaDestino)
            System.IO.File.Delete(NombreCarpeta)
        End If
    End Function

    Sub FacturaCMT_Devanlay()
        Dim rango As String
        Dim NomHoja As String
        Dim strSQL As String
        Dim oDtTablaExcel As DataTable

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Genera_Interfase_FE_Devanlay"
        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
        strSQL &= vbNewLine & String.Format(",@guia         = '{0}'", oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT))
        oDtTablaExcel = oHP.DevuelveDatos(strSQL, cCONNECT)

        If oDtTablaExcel.Rows.Count > 0 Then
            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

            Dim filaTabla As System.Data.DataRow

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets(1)
            NomHoja = "Factura CMT - Devanlay"
            exHoja.Name = NomHoja
            exApp.ActiveWindow.Zoom = 100

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = oDtTablaExcel.Columns.Count
            Dim NRow As Integer = oDtTablaExcel.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = oDtTablaExcel.Columns(i - 1).Caption
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = oDtTablaExcel.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = filaTabla(Col).ToString
                Next
            Next

            exApp.Sheets(NomHoja).Select
            rango = Trim(Str(oDtTablaExcel.Rows.Count + 1))
            rango = "A1:J" + rango

            exHoja.Range(rango).Select()
            exHoja.Range(rango).Font.Name = "Times New Roman"
            exHoja.Range(rango).Font.Size = "8"
            exHoja.Range(rango).ColumnWidth = 15

            exHoja.Range("A:A").NumberFormat = "@" ' "General"
            exApp.Range("A1:J1").Interior.ColorIndex = 15
            exApp.Range("A1:J1").Font.Bold = True
            exHoja.Range(rango).Borders.LineStyle = 1
            exHoja.Range("A1").Select()

            exApp.Visible = True
            exApp = Nothing
            exLibro = Nothing
            exHoja = Nothing
        Else
            MessageBox.Show("No se encontraron registros", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Sub GuiaCMT_Devanlay()
        Dim rango As String
        Dim NomHoja As String
        Dim x As Integer
        Dim oDtTablaExcel As DataTable

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Genera_Interfase_FE_Devanlay_Guia"
        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
        strSQL &= vbNewLine & String.Format(",@guia         = '{0}'", oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT))
        oDtTablaExcel = oHP.DevuelveDatos(strSQL, cCONNECT)

        If oDtTablaExcel.Rows.Count > 0 Then
            'Creamos las variables
            Dim exApp As New Microsoft.Office.Interop.Excel.Application
            Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
            Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

            Dim filaTabla As System.Data.DataRow

            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets(1)
            NomHoja = "Guía CMT - Devanlay"
            exHoja.Name = NomHoja
            exApp.ActiveWindow.Zoom = 130

            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = oDtTablaExcel.Columns.Count
            Dim NRow As Integer = oDtTablaExcel.Rows.Count

            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(24, i + 1) = oDtTablaExcel.Columns(i - 1).Caption
            Next

            For Fila As Integer = 0 To NRow - 1
                filaTabla = oDtTablaExcel.Rows(Fila)
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 25, Col + 2) = filaTabla(Col).ToString()
                Next
            Next

            exApp.Sheets(NomHoja).Select
            rango = Trim(Str(oDtTablaExcel.Rows.Count + 24))
            rango = "B24:K" + rango
            exHoja.Range(rango).Select()
            exHoja.Range(rango).Font.Name = "Times New Roman"
            exHoja.Range(rango).Font.Size = "8"
            exHoja.Range(rango).ColumnWidth = 15

            exApp.Range("B24:K24").Font.Bold = True
            exApp.Range("B24:K24").Font.Name = "Arial"
            exApp.Range("B24:K24").Font.Size = "8"
            '    Excel_Hoja.Range(rango).Borders.LineStyle = xlContinuous
            exHoja.Range("A1").Select()

            exApp.ActiveWindow.View = Excel.XlWindowView.xlPageBreakPreview
            exApp.ActiveWindow.Zoom = 130
            exHoja.Range("A1").ColumnWidth = 3.29
            exHoja.Range("B1").ColumnWidth = 4.43
            exHoja.Range("C1").ColumnWidth = 6
            exHoja.Range("D1").ColumnWidth = 7.14
            exHoja.Range("E1").ColumnWidth = 10.43
            exHoja.Range("F1").ColumnWidth = 5.14
            exHoja.Range("G1").ColumnWidth = 37.14
            exHoja.Range("H1").ColumnWidth = 4.57
            exHoja.Range("I1").ColumnWidth = 4.57
            exHoja.Range("J1").ColumnWidth = 6.86
            exHoja.Range("K1").ColumnWidth = 7.14
            exHoja.Cells(4, 2) = "Fecha Emision:"
            exApp.Range("D4:E4").Select()

            With exApp.Selection
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.Constants.xlBottom
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = True
            End With

            exApp.Selection.Merge
            exHoja.Cells(4, 4) = Strings.Format(Now, "dd/MM/yyyy")
            exHoja.Cells(5, 2) = "Señor(es):"
            exHoja.Cells(5, 4) = "DEVANLAY PERU SAC"
            exHoja.Cells(6, 2) = "Direccion:"
            exHoja.Cells(6, 4) = "AV. ARGENTINA N° 2743 - URB. LOS PINOS  - LIMA - LIMA -LIMA"
            exHoja.Cells(8, 2) = "RUC"
            exApp.Range("D8:F8").Select()

            With exApp.Selection
                .HorizontalAlignment = Excel.Constants.xlLeft
                .VerticalAlignment = Excel.Constants.xlBottom
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = True
            End With

            exApp.Selection.Merge
            exHoja.Cells(8, 4) = "20501977439"
            exHoja.Cells(10, 8) = "Otros:"
            exApp.Range("I10:K11").Select()

            With exApp.Selection
                .HorizontalAlignment = Excel.Constants.xlCenter
                .VerticalAlignment = Excel.Constants.xlBottom
                .WrapText = True
                .Orientation = 0
                .AddIndent = False
                .IndentLevel = 0
                .ShrinkToFit = False
                .ReadingOrder = Excel.Constants.xlContext
                .MergeCells = True
            End With

            exApp.Selection.Merge
            exApp.Selection.Font.Underline = Excel.XlUnderlineStyle.xlUnderlineStyleSingle
            exHoja.Cells(10, 9) = "Servicio de Fabricacion por Encargo de acuerdo al contrato"
            exApp.Range("I10").Font.Size = "14"
            exHoja.Cells(11, 2) = "Transportista"
            exHoja.Cells(12, 2) = "Ruc:"
            exHoja.Cells(14, 2) = "Lic. Conducir"
            exHoja.Cells(15, 2) = "Marca:"
            exHoja.Cells(16, 2) = "Placa:"
            exHoja.Cells(19, 2) = "Punto de Partida:"
            exHoja.Cells(19, 4) = "AV. INDUSTRIAL S/N PARCELA N° 46 CAU 03 DE OCTUBRE -CHINCHA BAJA - CHINCHA"
            exHoja.Cells(20, 2) = "Punto de Llegada:"
            exHoja.Cells(20, 4) = "AV. ARGENTINA NRO. 2085 -   CALLAO - PROV. CONST. DEL CALLAO "

            For x = 1 To 55

                If x = 1 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 25.5
                End If

                If x = 3 Or x = 23 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 0
                End If

                If x <> 1 And x <> 3 And x <> 23 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 11.25
                End If

                If x < 24 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).Font.Name = "Arial"
                    If x = 10 Then
                        exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).Font.Size = "7"
                    Else
                        exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).Font.Size = "8"
                    End If
                End If

                If x = 18 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 26.25
                End If

                If x = 9 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 20.25
                End If

                If x = 10 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 18
                End If

                If x = 21 Then
                    exHoja.Range("A" + Trim(Str(x)) + ":K" + Trim(Str(x))).RowHeight = 18.75
                End If
            Next x

            With exApp.ActiveSheet.PageSetup
                .PrintTitleRows = ""
                .PrintTitleColumns = ""
            End With

            exApp.ActiveSheet.PageSetup.PrintArea = ""

            With exApp.ActiveSheet.PageSetup
                .LeftHeader = ""
                .CenterHeader = ""
                .RightHeader = ""
                .LeftFooter = ""
                .CenterFooter = ""
                .RightFooter = ""
                .LeftMargin = exApp.InchesToPoints(0.196850393700787)
                .RightMargin = exApp.InchesToPoints(0)
                .TopMargin = exApp.InchesToPoints(0.984251968503937)
                .BottomMargin = exApp.InchesToPoints(0.984251968503937)
                .HeaderMargin = exApp.InchesToPoints(0)
                .FooterMargin = exApp.InchesToPoints(0)
                .PrintHeadings = False
                .PrintGridlines = False
                .PrintComments = Excel.XlPrintLocation.xlPrintNoComments
                .PrintQuality = 600
                .CenterHorizontally = False
                .CenterVertically = False
                .Orientation = Excel.XlPageOrientation.xlPortrait
                .Draft = False
                .PaperSize = Excel.XlPaperSize.xlPaperLetter
                .FirstPageNumber = Excel.Constants.xlAutomatic
                .Order = Excel.XlOrder.xlDownThenOver
                .BlackAndWhite = False
                .Zoom = 100
                .PrintErrors = Excel.XlPrintErrors.xlPrintErrorsDisplayed
                .OddAndEvenPagesHeaderFooter = False
                .DifferentFirstPageHeaderFooter = False
                .ScaleWithDocHeaderFooter = True
                .AlignMarginsHeaderFooter = True
                .EvenPage.LeftHeader.Text = ""
                .EvenPage.CenterHeader.Text = ""
                .EvenPage.RightHeader.Text = ""
                .EvenPage.LeftFooter.Text = ""
                .EvenPage.CenterFooter.Text = ""
                .EvenPage.RightFooter.Text = ""
                .FirstPage.LeftHeader.Text = ""
                .FirstPage.CenterHeader.Text = ""
                .FirstPage.RightHeader.Text = ""
                .FirstPage.LeftFooter.Text = ""
                .FirstPage.CenterFooter.Text = ""
                .FirstPage.RightFooter.Text = ""
            End With

            exApp.PrintCommunication = True
            exHoja.Cells(51, 2) = "TOTAL "
            exHoja.Cells(51, 4) = oHP.DevuelveDato("SELECT NUM_PRENDAS FROM CN_VENTAS WHERE NUM_CORRE = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)
            exHoja.Cells(52, 4) = oHP.DevuelveDato("SELECT NUM_CAJAS FROM CN_VENTAS WHERE NUM_CORRE = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)
            exHoja.Cells(53, 2) = "PRECINTOS"
            exHoja.Cells(51, 5) = "PRENDAS DE PRIMERA CALIDAD"
            exHoja.Cells(52, 5) = "CAJAS"
            exHoja.Cells(53, 5) = "METAL"
            exHoja.Cells(53, 7) = "METAL"
            exHoja.Cells(54, 5) = "METAL"

            exApp.Visible = True
            exApp = Nothing
            exLibro = Nothing
            exHoja = Nothing
        Else
            MessageBox.Show("No se encontraron registros", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub ButtonBar3_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar3.ItemClick
        Try
            Dim vlServidor As String
            Select Case e.Item.Key
                Case "CERTITLC"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    ImpCertiTLC(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                Case "AGRUPAR"
                    Using oAgr As New FrmDocumentoVentaExportacion_AgruparFacturas
                        With oAgr
                            .ShowDialog()
                            CargarGrilla()
                        End With
                    End Using

                Case "IMPAGRUPADA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("FacturaAgrupada").Index)) = "" Then
                        MessageBox.Show("Documento no tiene Factura agrupada", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Call ImprimirSTN_Agrupada(GrdLista.GetValue(GrdLista.RootTable.Columns("FacturaAgrupada").Index))

                Case "GUIALOCAL"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oLocal As New FrmDocumentoVentaExportacion_GuiaLocal
                        With oLocal
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .ShowDialog()
                        End With
                    End Using

                Case "FACTURALOCAL"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    vlServidor = oHP.DevuelveDato("select Servidor_FE from cn_control", cCONNECT)
                    If MessageBox.Show("¿Está seguro de enviar a Sunat - " & IIf(vlServidor = "http://192.168.30.4", "Producción", "Pruebas") & "?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        GeneraFacturaElectronica(Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)), vlServidor)
                    End If

                Case "ECR"
                    Dim vlCadFactura As String
                    Dim vlCadFecha As String
                    Dim vlCadEmbarque As String
                    If GrdLista.RowCount = 0 Then Exit Sub
                    GrdLista.RemoveFilters()
                    If GrdLista.GetCheckedRows.Length Then
                        For Each oGridEXRow As GridEXRow In GrdLista.GetCheckedRows 'recorre la lista
                            vlCadFactura = vlCadFactura + Trim(oGridEXRow.Cells("Serie").Value) + "-" + Trim(oGridEXRow.Cells("Nro_Doc").Value) + ","
                            vlCadFecha = vlCadFecha + Trim(oGridEXRow.Cells("Emision").Value) + ","
                            vlCadEmbarque = vlCadEmbarque + Trim(oGridEXRow.Cells("num_embarque").Value) + ","
                        Next
                    Else
                        MessageBox.Show("Debe seleccionar al menos un registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If Trim(vlCadFactura) = "" Then GrdLista.Row = 1 : Exit Sub
                    Using oEven As New FrmDocumentoVentaExportacion_EventoComprometido
                        With oEven
                            .sFactura = vlCadFactura
                            .sFecha = vlCadFecha
                            .sEmbarque = vlCadEmbarque
                            .ShowDialog()
                        End With
                    End Using

                Case "ARCHIVOS"
                    Dim sFactura As String
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Feccha_Evento_Comprometido_Real").Index)) = "" Then Exit Sub
                    sFactura = Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)) + "-" + Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)) + "-" + Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("num_embarque").Index))

                    If System.IO.File.Exists(vlRuta_ & "\" & sFactura) Then
                        Shell("explorer.exe " & vlRuta_ & "\" & sFactura, vbMaximizedFocus)
                    Else
                        MessageBox.Show("No se Encontró los Archivos", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If

                Case "COLGADOR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If oHP.DevuelveDato("EXEC SP_VALIDA_CLIENTE '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT) = 0 Then
                        MessageBox.Show("Proceso no Permite Asignar Colgador al Cliente Seleccionado..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                    Using oAsig As New FrmDocumentoVentaExportacion_AsignarColgador
                        With oAsig
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "INVOICE"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Dim vlCadNum_Corre As String
                    vlCadNum_Corre = ""
                    If GrdLista.GetCheckedRows.Length Then
                        For Each oGridEXRow As GridEXRow In GrdLista.GetCheckedRows 'recorre la lista
                            vlCadNum_Corre = vlCadNum_Corre + Trim(oGridEXRow.Cells("Num_Corre").Value)
                        Next
                    Else
                        MessageBox.Show("Debe seleccionar al menos un registro", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Exit Sub
                    End If

                    If Len(vlCadNum_Corre) = 0 Then
                        Exit Sub
                    Else
                        ImprimirSTN_Agrupado_Invoice(vlCadNum_Corre)
                    End If

                Case "FACTURADVL"
                    Dim vlCad As String

                    If GrdLista.RowCount = 0 Then Exit Sub
                    If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Ruc").Index)) <> "20501977439" Then
                        MessageBox.Show("Cliente debe ser DEVANLAY..!!! Revisar.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    strSQL = "DECLARE @Correlativo AS VARCHAR (8000)"
                    strSQL &= vbNewLine & "EXEC SP_Valida_Existencia"
                    strSQL &= vbNewLine & String.Format(" @Num_Corre    = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)))
                    strSQL &= vbNewLine & String.Format(",@Opcion       = '{0}'", "V")
                    strSQL &= vbNewLine & String.Format(",@Proceso      = '{0}'", "FACTURA DVL")
                    strSQL &= vbNewLine & ",@Correlativo   = @Correlativo OUTPUT"
                    strSQL &= vbNewLine & "SELECT @Correlativo AS RPTA"
                    vlCad = oHP.DevuelveDato(strSQL, cCONNECT)
                    If vlCad = "V-0" Then
                        MessageBox.Show("Opción Desabiitada..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If

                    strSQL = "DECLARE @Correlativo AS VARCHAR (8000)"
                    strSQL &= vbNewLine & "EXEC SP_Valida_Existencia"
                    strSQL &= vbNewLine & String.Format(" @Num_Corre    = '{0}'", Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)))
                    strSQL &= vbNewLine & String.Format(",@Opcion       = '{0}'", "C")
                    strSQL &= vbNewLine & String.Format(",@Proceso      = '{0}'", "")
                    strSQL &= vbNewLine & ",@Correlativo   = @Correlativo OUTPUT"
                    strSQL &= vbNewLine & "SELECT @Correlativo AS RPTA"
                    vlCad = oHP.DevuelveDato(strSQL, cCONNECT)
                    If Len(vlCad) = 0 Then
                        Dim oDtDatosFactElect As DataTable
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Genera_Interfase_FE_Devanlay"
                        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@guia         = '{0}'", oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT))
                        oDtDatosFactElect = oHP.DevuelveDatos(strSQL, cCONNECT)
                        If oDtDatosFactElect.Rows.Count = 0 Then
                            Exit Sub
                        Else
                            Using oEnvio As New FrmDocumentoVentaExportacion_EnvioFactElect
                                With oEnvio
                                    .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                                    .TxtFactura.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & "-" & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                                    .TxtFecha.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Emision").Index)
                                    If Len(Trim(oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT))) <= 2 Then
                                        .TxtGuia.Text = ""
                                    Else
                                        .TxtGuia.Text = Trim(oHP.DevuelveDato("select isnull(guias, '') from cn_ventas where num_corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT))
                                    End If
                                    .CargarGrilla()
                                    .ShowDialog()
                                End With
                            End Using
                        End If
                    Else
                        If MessageBox.Show("¿El Documento ya se encuentra Registrado, Desea Enviar a SUNAT?" & vbCrLf & "Detalle ------->" & vbCrLf & "Nro. Corre. Facturación : " & Mid(vlCad, 1, 10) & vbCrLf & "Fecha Doc. : " & Mid(vlCad, 11, 10) & vbCrLf & "Nro. Factura : " & Mid(vlCad, 21, 12), "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                            EnvioDVL(Mid(vlCad, 1, 10))
                        End If
                    End If

                Case "DESAGRUFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("Está seguro de desagrupar el Documento", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Desagrupa_Documento"
                        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                            GrdLista.Row = FilaSeleccionada
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ImpCertiTLC(ByVal sNum_Corre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\RptCerticadoTLC.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", cCONNECTVB6, sNum_Corre)
        oo = Nothing
    End Sub

    Private Sub ImprimirSTN_Agrupada(ByVal sFacturaAgrupada As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\rptFacturaSTN.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", "Ventas_Exportacion_Vineyard_Vince_Cabecera_Agrupada '" & sFacturaAgrupada & "'", "Ventas_Exportaciones_Genera_Lineas_Factura_Agrupada '" & sFacturaAgrupada & "'", "Ventas_Exportacion_Vineyard_Vince_Trailer_Agrupada  '" & sFacturaAgrupada & "'", sFacturaAgrupada, cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub ImprimirSTN_Agrupado_Invoice(ByVal sCadena_NumCorre As String)
        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\rptFacturaSTN_Invoice.XLT")
        oo.Visible = True
        oo.DisplayAlerts = False
        oo.Run("reporte", "Ventas_Exportacion_Vineyard_Vince_Cabecera_Agrupada_Invoice '" & sCadena_NumCorre & "'", "Ventas_Exportaciones_Genera_Lineas_Factura_Agrupada_Invoice '" & sCadena_NumCorre & "'", "Ventas_Exportacion_Vineyard_Vince_Trailer_Agrupada_Invoice  '" & sCadena_NumCorre & "'", sCadena_NumCorre, cCONNECTVB6)
        oo = Nothing
    End Sub

    Private Sub ExportarRPT(oDtTablaCabecera As DataTable, oDtTablaDetalle As DataTable)
        Dim rango As String
        Dim rango2 As Integer
        Dim NomHoja As String

        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Dim filaTabla As System.Data.DataRow

        'Añadimos el Libro al programa, y la hoja al libro
        exLibro = exApp.Workbooks.Add
        exHoja = exLibro.Worksheets(1)
        NomHoja = "Factura Exportacion Preview"
        exHoja.Name = NomHoja
        exApp.ActiveWindow.Zoom = 100

        ' ¿Cuantas columnas y cuantas filas?
        Dim NCol As Integer = oDtTablaDetalle.Columns.Count
        Dim NRow As Integer = oDtTablaDetalle.Rows.Count

        'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
        For i As Integer = 1 To NCol
            exHoja.Cells.Item(11, i + 1) = oDtTablaDetalle.Columns(i - 1).Caption
        Next

        For Fila As Integer = 0 To NRow - 1
            filaTabla = oDtTablaDetalle.Rows(Fila)
            For Col As Integer = 0 To NCol - 1
                exHoja.Cells.Item(Fila + 12, Col + 2) = filaTabla(Col).ToString()
            Next
        Next

        exApp.Sheets(NomHoja).Select
        exApp.Columns("C:C").Select
        exApp.Selection.Insert(Excel.XlInsertShiftDirection.xlShiftToRight, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        exApp.Selection.Insert(Excel.XlInsertShiftDirection.xlShiftToRight, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        exApp.Selection.Insert(Excel.XlInsertShiftDirection.xlShiftToRight, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        exApp.Selection.Insert(Excel.XlInsertShiftDirection.xlShiftToRight, Excel.XlInsertFormatOrigin.xlFormatFromLeftOrAbove)
        exApp.Range("B11:I11").Interior.ColorIndex = 15
        rango = oDtTablaDetalle.Rows.Count + 11
        rango = "I" & Trim(Str(rango))

        exHoja.Range("B11:" & rango).Borders.LineStyle = 1
        exHoja.Range("B11:F11").Select()

        With exHoja.Range("B11:F11")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("B11:F11").Merge()

        'CABECERA
        exHoja.Range("B2:G2").Select()
        With exHoja.Range("B2:G2")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("B2:G2").Merge()
        exHoja.Range("B2:G2").Borders.LineStyle = 1
        exHoja.Cells.Item(2, 2) = oDtTablaCabecera.Rows(0)(3).ToString  'exHoja.Range("B2") = oDtTablaCabecera.Rows(0)(3).ToString
        exApp.Range("B2:G2").Interior.ColorIndex = 15

        'RUC
        exHoja.Range("H2:I2").Select()
        With exHoja.Range("H2:I2")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("H2:I2").Merge()
        exHoja.Range("H2:I2").Borders.LineStyle = 1
        exHoja.Cells.Item(2, 8) = "RUC : " & oDtTablaCabecera.Rows(0)(2).ToString   'exHoja.Range("H2:I2") = "RUC : " & oDtTablaCabecera.Rows(0)(2).ToString
        exApp.Range("H2:I2").Interior.ColorIndex = 15
        exHoja.Range("H2:I2").Font.Name = "Calibri"
        exHoja.Range("H2:I2").Font.Size = "13"

        'TITULO FACTURA
        exHoja.Range("H3:I3").Select()
        With exHoja.Range("H3:I3")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("H3:I3").Merge()
        exHoja.Range("H3:I3").Borders.LineStyle = 1
        exHoja.Cells.Item(3, 8) = "FACTURA ELECTRÓNICA" 'exHoja.Range("H3:I3") = "FACTURA ELECTRÓNICA"
        exHoja.Range("H3:I3").Font.Name = "Calibri"
        exHoja.Range("H3:I3").Font.Size = "11"

        'SERIE NUMERO
        exHoja.Range("H4:I4").Select()
        With exHoja.Range("H4:I4")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("H4:I4").Merge()
        exHoja.Range("H4:I4").Borders.LineStyle = 1
        exHoja.Cells.Item(4, 8) = oDtTablaCabecera.Rows(0)(0).ToString  'exHoja.Range("H4:I4") = oDtTablaCabecera.Rows(0)(0).ToString
        exHoja.Range("H4:I4").Font.Name = "Calibri"
        exHoja.Range("H4:I4").Font.Size = "11"

        'FECHA
        exHoja.Range("H6:I6").Select()
        With exHoja.Range("H6:I6")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("H6:I6").Merge()
        exHoja.Range("H6:I6").Borders.LineStyle = 1
        exHoja.Cells.Item(6, 8) = "FECHA : " & oDtTablaCabecera.Rows(0)(1).ToString 'exHoja.Range("H6:I6") = "FECHA : " & oDtTablaCabecera.Rows(0)(1).ToString
        exHoja.Range("H6:I6").Font.Name = "Calibri"
        exHoja.Range("H6:I6").Font.Size = "11"

        'DIRECCION
        exHoja.Range("B3:G3").Select()
        With exHoja.Range("B3:G3")
            .HorizontalAlignment = Microsoft.Office.Interop.Excel.Constants.xlCenter
            .VerticalAlignment = Microsoft.Office.Interop.Excel.Constants.xlBottom
            .WrapText = False
            .Orientation = 0
            .AddIndent = False
            .IndentLevel = 0
            .ShrinkToFit = False
            .ReadingOrder = Microsoft.Office.Interop.Excel.Constants.xlContext
            .MergeCells = False
        End With
        exHoja.Range("B3:G3").Merge()
        exHoja.Range("B3:G3").Borders.LineStyle = 1
        exHoja.Cells.Item(3, 2) = oDtTablaCabecera.Rows(0)(4).ToString 'exHoja.Range("B3:G3") = oDtTablaCabecera.Rows(0)(4).ToString
        exHoja.Range("B3:G3").Font.Name = "Calibri"
        exHoja.Range("B3:G3").Font.Size = "8"

        ' CLIENTE
        exHoja.Cells.Item(7, 2) = "SEÑOR(ES) : "  'exHoja.Range("B7:B7") = "SEÑOR(ES) : "
        exHoja.Cells.Item(7, 3) = oDtTablaCabecera.Rows(0)(9).ToString    'exHoja.Range("C7:C7") = oDtTablaCabecera.Rows(0)(9).ToString

        'RUC CLIENTE
        exHoja.Cells.Item(8, 2) = "RUC : "    'exHoja.Range("B8:B8") = "RUC : "
        exHoja.Cells.Item(8, 3) = "-" 'exHoja.Range("C8:C8") = "-"

        'DIRECCION CLIENTE
        exHoja.Cells.Item(9, 2) = "DIRECCIÓN : "  'exHoja.Range("B9:B9") = "DIRECCIÓN : "
        exHoja.Cells.Item(9, 3) = oDtTablaCabecera.Rows(0)(10).ToString    'exHoja.Range("C9:C9") = oDtTablaCabecera.Rows(0)(10).ToString

        'IMPORTES
        rango2 = oDtTablaDetalle.Rows.Count + 17
        rango = "H" & Trim(Str(rango2))
        exHoja.Cells.Item(rango2, 8) = "TOTAL US$ : "  'exHoja.Range(rango & ":" & rango) = "TOTAL US$ : "
        exApp.Range(rango & ":" & rango).Interior.ColorIndex = 15
        exHoja.Range(rango & ":" & rango).Borders.LineStyle = 1

        rango2 = oDtTablaDetalle.Rows.Count + 17
        rango = "I" & Trim(Str(rango2))
        exHoja.Cells.Item(rango2, 9) = Importe 'exHoja.Range(rango & ":" & rango) = Importe
        exApp.Range(rango & ":" & rango).Interior.ColorIndex = 15
        exHoja.Range(rango & ":" & rango).Borders.LineStyle = 1

        'IMPORTES LETRAS
        rango2 = oDtTablaDetalle.Rows.Count + 16
        rango = "B" & Trim(Str(rango2))
        exHoja.Cells.Item(rango2, 2) = "Son : " & ImportLetra 'exHoja.Range(rango & ":" & rango) = "Son : " & ImportLetra
        exHoja.Range(rango & ":" & rango).Font.Size = "10"

        'Adicional
        rango2 = oDtTablaDetalle.Rows.Count + 13
        rango = "B" & Trim(Str(rango2))
        exHoja.Cells.Item(rango2, 2) = oDtTablaCabecera.Rows(0)(12).ToString   'exHoja.Range(rango & ":" & rango) = oDtTablaCabecera.Rows(0)(12).ToString
        exHoja.Range(rango & ":" & rango).Font.Size = "10"

        'Drawback
        rango2 = oDtTablaDetalle.Rows.Count + 14
        rango = "B" & Trim(Str(rango2))
        exHoja.Cells.Item(rango2, 2) = oDtTablaCabecera.Rows(0)(13).ToString   'exHoja.Range(rango & ":" & rango) = oDtTablaCabecera.Rows(0)(13).ToString
        exHoja.Range(rango & ":" & rango).Font.Size = "10"

        exHoja.Range("B2:G2").Select()
        exHoja.Range("B2:G2").Font.Name = "Calibri"
        exHoja.Range("B2:G2").Font.Size = "18"

        'Aplicación Visible
        exApp.Application.Visible = True
        exHoja = Nothing
        exLibro = Nothing
        exApp = Nothing

    End Sub

    Sub GeneraFacturaElectronica(vlNum_Corre As String, vlServer As String)
        Try
            Dim vlError As String
            Dim vlxCorrelativo As String
            vlxCorrelativo = ""
            Dim Val As String

            Val = InputBox("Ingrese Número de Guía que se asignara a la Factura", "Número de Guía para Factura")
            If Trim(Val) = "" Or Len(Trim(Val)) = 0 Then
                MessageBox.Show("Debe Ingresar Número de Guía..!!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            Using oCn As New SqlConnection(cCONNECT)
                Using oCmd As New SqlCommand("test", oCn)
                    With oCmd
                        .CommandType = CommandType.StoredProcedure
                        .CommandText = "SP_GENERA_FACTURA_ELECTRONICA_LOCAL"
                        .Parameters.Add("@NUM_CORRE", SqlDbType.VarChar, 15).Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                        .Parameters.Add("@NUM_GUIA", SqlDbType.VarChar, 15).Value = Val
                        .Parameters.Add("@USUARIO", SqlDbType.VarChar, 30).Value = vusu

                        With .Parameters.Add("@P_MSJ", SqlDbType.VarChar, 8000)
                            .Direction = ParameterDirection.Output
                            .Value = ""
                        End With
                        With .Parameters.Add("@XCORRELATIVO", SqlDbType.VarChar, 10)
                            .Direction = ParameterDirection.Output
                            .Value = vlxCorrelativo
                        End With
                        .Connection.Open()
                        oDtDetalle.Load(.ExecuteReader)
                    End With
                    vlError = oCmd.Parameters("@P_MSJ").Value
                    vlxCorrelativo = oCmd.Parameters("@XCORRELATIVO").Value
                End Using
            End Using

            If Strings.Left(vlError, 5) = "Error" Then
                MessageBox.Show(vlError, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            EnvioFacturaLocal(vlxCorrelativo, vlServer)
            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub EnvioFacturaLocal(Correlativo As String, vlServidor_FE_L As String)
        Dim url As String
        Dim vlsCab As String
        Dim vlsDet As String

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC MtxCabeceraFactura_Cabecera_CMT_Venta_Local"
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
        strSQL &= vbNewLine & "EXEC MtxDetalleFactura_Detalle_CMT_Venta_Local"
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
        url = IIf(vlServidor_FE_L = "http://192.168.30.4", "http://192.168.30.4:5002/ca4xml", "http://192.168.30.9:5001/ca4xml") '"http://192.168.30.9:5001/ca4xml" '"http://192.168.30.4:5002/ca4xml"
        Dim docid As String = "FF12-001"
        Dim comando As String = "emitir"
        Dim parametro As String = ""
        Dim respuesta As String = Envio.SendCA4XMLRequest(url, docid, comando, parametro, Datos)
        If (respuesta.Substring(0, 2).ToUpper = "OK") Then
            MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_Ventas_Actualiza_flg_EnviadoFE_Local"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Else
            MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

#Region "CODIGO OCULTO"

    '    '    '******************OPCIONES OCULTAS***********************
    '    'Case "MODIFICA"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    If Not ifValidaDoc Then Exit Sub
    '    '    frmAdicionaDocumVentasExport.oParent = Me
    '    '    With frmAdicionaDocumVentasExport
    '    '        .StrOption = "U"
    '    '        .Caption = "Modifica Docum Ventas"
    '    '        Carga_Data()
    '    '        .strNum_Corre = GridEX1.Value(GridEX1.Columns("Num_Corre").Index)
    '    '        .Show 1
    '    '    End With

    '    'Case "EXPORTADBF"
    '    '    If GridEX1.RowCount > 0 Then Transmitir()

    '    'Case "GENERAINFOCONT"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    GeneraInfoContable()

    '    'Case "IMPCOLOR"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    Call Reporte_COLOR()

    '    'Case "VERVOUCHER"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    MuestraVoucher2()

    '    'Case "PENALIDADES"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    LoadPenalidades()

    '    'Case "IMPRIMIRINVOICE"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    Call Reporte

    '    'Case "LDP/DDP"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    frmCompletarImportesLDPDDP.strNum_Corre = GridEX1.Value(GridEX1.Columns("Num_Corre").Index)
    '    '    frmCompletarImportesLDPDDP.txtFlete = GridEX1.Value(GridEX1.Columns("Imp_flete").Index)
    '    '    frmCompletarImportesLDPDDP.txtDesaduanaje = GridEX1.Value(GridEX1.Columns("imp_desaduanaje").Index)
    '    '    frmCompletarImportesLDPDDP.txtTransporte = GridEX1.Value(GridEX1.Columns("imp_transporte_pais_destino").Index)
    '    '    frmCompletarImportesLDPDDP.txtFob = GridEX1.Value(GridEX1.Columns("Imp_FOB").Index)
    '    '    frmCompletarImportesLDPDDP.txtCif = GridEX1.Value(GridEX1.Columns("Imp_CIF").Index)
    '    '    frmCompletarImportesLDPDDP.txtLdp = GridEX1.Value(GridEX1.Columns("Imp_LDP").Index)
    '    '    frmCompletarImportesLDPDDP.txtDdp = GridEX1.Value(GridEX1.Columns("Imp_DDP").Index)

    '    '    frmCompletarImportesLDPDDP.Show vbModal
    '    '    frmCompletarImportesLDPDDP = Nothing
    '    '    Buscar()
    '    'Case "IMPRESIONES"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    Imprimir1(GridEX1.Value(GridEX1.Columns("Num_Corre").Index), GridEX1.Value(GridEX1.Columns("Cod_TipDoc").Index))

    '    'Case "RINFCONTABLE"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    If MsgBox("Esta Seguro de Revertir Transm. Exactus de este Documento", vbYesNo, "IMPORTANTE") = vbYes Then
    '    '        'ExecuteCommandSQL cCONNECT, "CN_REVIERTE_ASIENTO_VENTAS'" & GridEX1.Value(GridEX1.Columns("Num_Corre").Index) & "'"
    '    '        ExecuteCommandSQL(cCONNECT, "VENTAS_REVIERTE_TRANSMISION_EXACTUS'" & GridEX1.Value(GridEX1.Columns("Num_Corre").Index) & "','" & vusu & "','" & ComputerName() & "'")
    '    '        Mensaje kMESSAGE_INF_PROCESS_SATISFACTO
    '    '        Buscar()
    '    '    End If

    '    'Case "FACTURACMT"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    Me.FraImprimir.Visible = True
    '    '    Me.txtGuiaImp.SetFocus()

    '    'Case "GUIACMT"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub

    '    '    Call ImprimirGuia()

    '    ''******************OPCIONES OCULTAS***********************

    '    'Case "GERMAN"
    '    '    Call ReporteGerman()

    '    'Case "REVESTENVEFACT"

    '    'Case "VERSTAFACELEC"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    Load(frmStatusFactElectro)
    '    '    frmStatusFactElectro.txtCodTipoDoc.Text = GridEX1.Value(GridEX1.Columns("Cod_TipDoc").Index)
    '    '    frmStatusFactElectro.TxtSerie.Text = GridEX1.Value(GridEX1.Columns("Serie").Index)
    '    '    frmStatusFactElectro.TxtNumero.Text = GridEX1.Value(GridEX1.Columns("Nro_Doc").Index)
    '    '    frmStatusFactElectro.dtpInicio.Value = GridEX1.Value(GridEX1.Columns("Emision").Index)
    '    '    frmStatusFactElectro.dtpFin.Value = GridEX1.Value(GridEX1.Columns("Emision").Index)
    '    '    frmStatusFactElectro.txtCodEnvio.Text = "T"
    '    '    frmStatusFactElectro.txtCodProceso.Text = "0"
    '    '    frmStatusFactElectro.CARGAR()
    '    '    frmStatusFactElectro.Show 1

    '    '    frmStatusFactElectro = Nothing

    '    'Case "FACMUEEURO"
    '    '    If GridEX1.RowCount = 0 Then Exit Sub
    '    '    ImpMuestraEurope GridEX1.Value(GridEX1.Columns("Num_Corre").Index)

    '    'Case "ACTNFOB"
    '    '    If GridEX1.RowCount > 0 Then
    '    '        actualizarNoFob()
    '    '        Buscar()
    '    '    Else
    '    '        MsgBox("Seleccione un Registro", vbExclamation, "Mensaje")
    '    '        Exit Sub
    '    '    End If

    '    ''******************OPCIONES OCULTAS***********************

    '    'Case "ACTFLEGASFOB"
    '    '    If GridEX1.RowCount > 0 Then
    '    '        'txtImpFleAer.Text = GridEX1.Value(GridEX1.Columns("Imp_Flete_Aereo").Index)
    '    '        sIMP_Opc = "F"
    '    '        Carga_DatoDDP()
    '    '        FraImpFleAer.Visible = True
    '    '    End If

    '    'Case "DECLAJUR"
    '    '    Imprimir_DeclaJurada GridEX1.Value(GridEX1.Columns("Num_Corre").Index)
#End Region

End Class