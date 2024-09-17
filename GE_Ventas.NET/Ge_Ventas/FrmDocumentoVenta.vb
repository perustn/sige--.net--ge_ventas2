Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta
    Private strSQL As String = String.Empty
    Private strSQLTrazaImp As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private oBtnSeguridad As New ClsBtnSeguridad

    Private Const K_strColCheck As String = "SEL"
    Private FilaSeleccionada As Integer
    Public OpcionFiltroBusqueda As String = "C"
    Private Cod_Cliente As String
    Public sCod_Usuario As String
    Public sCod_Tipdoc As String
    Public sFEC_ULT_ENVIO As Date
    Public sFlg_Baja As String
    Dim Nom_Archivo As String
    Public strCod_Anexo As String

    Private Sub FrmDocumentoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDtColor As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDtColor.Rows(0)("ColorFondo_R"), oDtColor.Rows(0)("ColorFondo_G"), oDtColor.Rows(0)("ColorFondo_B"))
        Panel5.BackColor = colEmpresa

        dtpFecEmiIni.Value = Now.Date
        dtpFecEmiFin.Value = Now.Date

        'oBtnSeguridad.GetBotonesJanus(vper, vemp, Me.Name, ButtonBar1, "")
        'oBtnSeguridad.GetBotonesJanus(vper, vemp, Me.Name, ButtonBar2, "")

        OpcionFiltroBusqueda = "C"
        'grbAnexo.Visible = True
        Me.ActiveControl = txtNum_Ruc
    End Sub

    Private Sub FondoDegrade(sender As Object, e As PaintEventArgs) Handles PanelGuia.Paint
        FondoDegradeDiagonalEnPanel(sender, e, colEmpresa)
    End Sub

    Private Sub OpcionesFiltroBusqueda(sender As Object, e As EventArgs) Handles OptCliente.Click,
                                                                                 OptAnioMes.Click,
                                                                                 OptNroDocumento.Click,
                                                                                 OptCorrelativo.Click,
                                                                                 OptClienteComercial.Click
        LimpiarTextos()
        Select Case (sender.TAG)
            Case "1"    'Por Anexo
                grbAnexo.Visible = True
                OpcionFiltroBusqueda = "C"
                txtNum_Ruc.Focus()

            Case "2"    'Por Año-Mes
                grbAnioMes.Visible = True
                OpcionFiltroBusqueda = "A"
                txtAno.Focus()

            Case "3"    'Por Nro Documento
                grbNroDocumento.Visible = True
                OpcionFiltroBusqueda = "N"
                txtCod_TipDoc.Focus()

            Case "4"    'Por Correlativo
                grbCorrelativo.Visible = True
                OpcionFiltroBusqueda = "O"
                txtNum_Corre.Focus()

            Case "5"    'Por Cliente Comercial
                grbClienteComercial.Visible = True
                OpcionFiltroBusqueda = "5"
                txtAbr_Cliente.Focus()
        End Select
    End Sub

    Public Sub LimpiarTextos()
        grbAnexo.Visible = False
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
    End Sub

    Private Sub txtNum_Ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Ruc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion_Anexo("Num_Ruc", "Des_Anexo", " Cn_AnexosContables Where cod_tipanex ='" & Trim(txtCod_TipAnxo.Text) & "' and ", txtNum_Ruc, txtDes_Anexo, 1, Me)
        End If
    End Sub

    Private Sub txtDes_Anexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Anexo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion_Anexo("Num_Ruc", "Des_Anexo", " Cn_AnexosContables Where cod_tipanex ='" & Trim(txtCod_TipAnxo.Text) & "' and ", txtNum_Ruc, txtDes_Anexo, 2, Me)
        End If
    End Sub

    Public Sub Busca_Opcion_Anexo(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "select Cod_Anxo as Cod,Des_Anexo as Nombre,Num_Ruc as Ruc from " & StrTabla
        'strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod.Text = Trim(oTipo.dtResultados.Rows(0)("Ruc"))
            txtDes.Text = Trim(oTipo.dtResultados.Rows(0)("Nombre"))
            strCod_Anexo = Trim(oTipo.dtResultados.Rows(0)("Cod"))
        ElseIf oTipo.dtResultados.Rows.Count > 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCod.Text = Trim(oTipo.RegistroSeleccionado.Cells("Ruc").Value)
                txtDes.Text = Trim(oTipo.RegistroSeleccionado.Cells("Nombre").Value)
                strCod_Anexo = Trim(oTipo.RegistroSeleccionado.Cells("Cod").Value)
            End If
        End If
        txtCod_TipAnxo.Focus()
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtCod_TipAnxo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipAnxo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Busca_Opcion("Cod_TipAnex", "Des_Tipanex", "CN_TipoAnexoContable where ", txtCod_TipAnxo, txtDes_TipDoc, 1, Me)
        End If
    End Sub

    Public Sub Busca_Opcion(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod.Text = Trim(oTipo.dtResultados.Rows(0)("Cod"))
            txtDes.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
        ElseIf oTipo.dtResultados.Rows.Count > 1 Then
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCod.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod").Value)
                txtDes.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
            End If
        End If
        BtnBuscar.Focus()
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
            Call Busca_Opcion2("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 1, Me)
        End If
    End Sub

    Private Sub txtDes_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion2("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 2, Me)
        End If
    End Sub

    Public Sub Busca_Opcion2(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
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
            If IsNumeric(txtSer_Docum.Text) Then
                txtSer_Docum.Text = RellenaDeCerosEnIzquierda(txtSer_Docum.Text, 3)
            End If
            txtNum_Docum.Focus()
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
            BuscaClienteComercial(1)
        End If
    End Sub

    Private Sub txtNom_Cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Cliente.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaClienteComercial(2)
        End If
    End Sub

    Private Sub BuscaClienteComercial(Opcion As Integer)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "SELECT Abr_Cliente, Nom_Cliente, Cod_Cliente FROM TG_CLIENTE WHERE "
        Select Case Opcion
            Case 1 : oTipo.sQuery = strSQL & "Abr_Cliente LIKE '%" & txtAbr_Cliente.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & "Nom_Cliente LIKE '%" & txtNom_Cliente.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        oTipo.ShowDialog()
        If Codigo <> "" Then
            txtAbr_Cliente.Text = Codigo
            txtNom_Cliente.Text = Descripcion
            Cod_Cliente = TipoAdd
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            BtnBuscar.Focus()
        End If
        oTipo = Nothing
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
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Doc_Ventas"
            strSQL &= vbNewLine & String.Format(" @StrOpcion        = '{0}'", OpcionFiltroBusqueda)
            strSQL &= vbNewLine & String.Format(",@FecIni           = '{0}'", dtpFecEmiIni.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@FecFin           = '{0}'", dtpFecEmiFin.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@Cod_Tipanex      = '{0}'", "C")
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo         = '{0}'", strCod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Ano_Registro     = '{0}'", txtAno.Text)
            strSQL &= vbNewLine & String.Format(",@Mes_Registro     = '{0}'", txtMes.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", txtNum_Corre.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_TipDoc       = '{0}'", txtCod_TipDoc.Text)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", txtSer_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", txtNum_Docum.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Cod_Cliente      = '{0}'", Cod_Cliente)

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

                    .Columns("NUM_DUA").Width = 114
                    .Columns("NUM_DUA").Caption = "NUM_DUA"
                    .Columns("FEC_NUMERACIONDUA").Width = 114
                    .Columns("FEC_NUMERACIONDUA").Caption = "FEC_NUMERACIONDUA"
                    .Columns("FEC_EMBARQUEREAL").Width = 114
                    .Columns("FEC_EMBARQUEREAL").Caption = "FEC_EMBARQUEREAL"
                    .Columns("IMP_FOB_DOL_DUA").Width = 114
                    .Columns("IMP_FOB_DOL_DUA").Caption = "IMP_FOB_DOL_DUA"

                    .Columns("Emision").FormatString = "dd/MM/yyyy"
                    .Columns("Registro").FormatString = "dd/MM/yyyy"
                    .Columns("Vencimiento").FormatString = "dd/MM/yyyy"
                    .Columns("Cancelado").FormatString = "dd/MM/yyyy"
                    .Columns("Fec_NumeracionDua").FormatString = "dd/MM/yyyy"
                    .Columns("Fec_EmbarqueReal").FormatString = "dd/MM/yyyy"
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Using oAdd As New FrmDocumentoVenta_Add
                        With oAdd
                            .StrOption = "I"
                            .inpFec_EmiDoc.Text = Now.Date
                            .InpFec_RegDoc.Text = Now.Date
                            .txtCod_Flete.Text = "NN"
                            .txtDes_Flete.Text = "NINGUNO"
                            .txtCod_Termino_Venta.Text = "000"
                            .txtDes_Termino_Venta.Text = "NO APLICABLE"
                            If .ShowDialog = DialogResult.OK Then
                                If .strNum_Corre <> "" Then
                                    OptCorrelativo.Checked = True
                                    txtNum_Corre.Text = .strNum_Corre
                                    CargarGrilla()
drpsiguiente:

                                    If GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) = "NC" Or GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) = "ND" Then
                                        Using oAsig As New FrmDocumentoVenta_VerDetalleAddAsigNotas    'frmAdicionaDetalleDocumAsigNotas
                                            With oAsig
                                                .Text = "Adicion " + GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) & " Nro " & GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & "-" & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index) & " Del Cliente " & GrdLista.GetValue(GrdLista.RootTable.Columns("Anexo").Index)
                                                .strNum_Corre_Ori = txtNum_Corre.Text
                                                .ShowDialog()
                                            End With
                                        End Using
                                    Else
                                        Using oAdddet As New FrmDocumentoVenta_VerDetalleAdd   'frmAdicionaDetalleDocum
                                            With oAdddet
                                                .Text = "Adicion " + GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) & " Nro " & GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & "-" & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index) & " Del Cliente " & GrdLista.GetValue(GrdLista.RootTable.Columns("Anexo").Index)
                                                .TxtNroCorrelativo.Text = txtNum_Corre.Text
                                                .strNum_Corre_Detalle = txtNum_Corre.Text
                                                .IntSencuencia = 0
                                                .StrOption = "I"
                                                .ShowDialog()
                                            End With
                                        End Using
                                    End If

                                    If FrmDocumentoVenta_VerDetalleAdd.IntSencuencia <> 0 Then
                                        GoTo drpsiguiente
                                    Else
                                        VerDetalleVentas()
                                    End If
                                End If
                            End If
                        End With
                    End Using

                Case "MODIFICA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oMod As New FrmDocumentoVenta_Add
                        With oMod
                            .StrOption = "U"
                            If oHP.DevuelveDato("Select dbo.ventas_Valida_Documento_Manuales_Cabrezera('" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')", cCONNECT) <> "" Then
                                MessageBox.Show("Documento cerrado.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                                .PanelMain.Enabled = False
                                .frExportacion.Enabled = False
                                .BtnAceptar.Visible = False
                                .StrOption = "A"
                            End If
                            .Text = "Modifica Docum Ventas"

                            strSQL = String.Empty
                            strSQL &= vbNewLine & "EXEC Ventas_Up_Man"
                            strSQL &= vbNewLine & String.Format(" @StrOption   = '{0}'", "V")
                            strSQL &= vbNewLine & String.Format(",@Num_Corre   = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                            Dim oDr As DataRow
                            If Not oDtResult Is Nothing Then
                                If oDtResult.Rows.Count = 0 Then Exit Sub
                                oDr = oDtResult.Rows(0)

                                .txtCod_TipDoc.Text = oDr("Cod_TipDoc")
                                .txtDes_TipDoc.Text = oDr("Des_TipDoc")
                                .txtCod_TipVenta.Text = oDr("Cod_Tipo_Venta")
                                .txtDes_TipVenta.Text = oDr("Des_Tipo_Vent")
                                .txtSer_Docum.Text = oDr("Ser_Docum")
                                .txtNum_Docum.Text = oDr("Num_Docum_Ventas")
                                .strCod_Anxo = oDr("Cod_Anxo")
                                .txtDes_TipAne.Text = oDr("DES_ANEXO")
                                .txtNum_Ruc.Text = oDr("Num_Ruc")
                                .inpFec_EmiDoc.Text = oDr("Fec_EmiDoc")
                                .InpFec_RegDoc.Text = oDr("Fec_RegDoc")
                                .TxtTipo_Cambio.Text = oDr("Tipo_Cambio")
                                .txtCod_Moneda.Text = oDr("Cod_Moneda")
                                .txtDes_Moneda.Text = oDr("Nom_Moneda")
                                .txtCod_ConPag.Text = oDr("Cod_CondVent")
                                .txtDes_ConPag.Text = oDr("Des_CondVent")
                                .txtNro_Guias.Text = oDr("Guias")
                                .txtNro_Ordener.Text = oDr("Pedidos")
                                .txtNro_DocInter.Text = oDr("Partes")
                                .Imp_Gastos_Finacieros.Text = oDr("Imp_Gastos_Financieros")
                                .Imp_Otros.Text = oDr("Imp_Otros")
                                .txtGlosa.Text = oDr("Glosa")
                                .txtCod_TipDoc.Enabled = False
                                .txtDes_TipDoc.Enabled = False
                                .txtSer_Docum.Enabled = False
                                .txtNum_Docum.Enabled = False
                                .chkExportacion.Checked = IIf(oDr("Flg_Exportacion") <> "S", False, True)
                                .chkFlete.Checked = IIf(oDr("Flg_Inc_Flete_Export") <> "S", False, True)
                                .chkSeguro.Checked = IIf(oDr("Flg_Inc_Seguro_Export") <> "S", False, True)
                                .chkDetraccion.Checked = IIf(oDr("Flg_Retencion_IGV") <> "S", False, True)
                                .chkExonerado.Checked = IIf(oDr("Flg_Exonerado_IGV") <> "S", False, True)
                                .chkGuiaFact.Checked = IIf(oDr("Flg_Guia_Factura") <> "S", False, True)
                                .txtCod_DocPar.Text = oDr("Cod_DirPartida")
                                .txtCod_DocLle.Text = oDr("Cod_DirLlegada")
                                .txtCod_Transporte.Text = oDr("Sec_Transp")
                                .txtCod_Chofer.Text = oDr("Sec_Chofer")
                                .txtEmbarque_Cod.Text = oDr("Tip_Embarque")
                                .txtEmbarque_Des.Text = oDr("Des_TipEmbarque")
                                .Imp_Flete.Text = oDr("Imp_Flete")
                                .txtReferencia.Text = oDr("Glosa_Documento_Referencia")
                                .txtObservacion.Text = oDr("Observacion")
                                .txtCod_Destino.Text = oDr("Cod_Destino")
                                .txtDes_Destino.Text = oDr("Des_Destino")
                                .txtCod_Flete.Text = oDr("Cod_Flete")
                                .txtDes_Flete.Text = oDr("Des_Flete")
                                .txtCod_Termino_Venta.Text = oDr("Cod_Termino_Venta")
                                .txtDes_Termino_Venta.Text = oDr("Des_Termino_Venta")
                                .txtShip_Date.Text = oDr("Ship_Date")
                                .txtImp_Seguro.Text = oDr("imp_Seguro")
                                .txtCod_NotaAbono.Text = oDr("Cod_Mot_Nota")
                                .txtDes_NotaAbono.Text = IIf(IsDBNull(oDr("Des_MotAbono")), "", oDr("Des_MotAbono"))
                                .txtDua.Text = oDr("Num_Dua")
                                If oDr("Fec_NumeracionDua") = "01/01/1900" Then
                                    .txtFec_Numeracion.Text = ""
                                Else
                                    .txtFec_Numeracion.Text = oDr("Fec_NumeracionDua")
                                End If
                                If oDr("Fec_EmbarqueReal") = "01/01/1900" Then
                                    .txtFec_Embarque.Text = ""
                                Else
                                    .txtFec_Embarque.Text = oDr("Fec_NumeracionDua")
                                End If
                                .txtImp_FOB_Dol_Dua.Text = oDr("Imp_FOB_Dol_Dua")
                                    .txtcajas.Text = oDr("Num_Cajas")
                                    .Cambio_FR()
                                    .txtPeso_Bruto.Text = oDr("Peso_Bruto")
                                    .txtPeso_Neto.Text = oDr("Peso_Neto")
                                    .txtNum_Bulto.Text = oDr("Num_Bultos")
                                End If
                                .strNum_Corre = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            If .ShowDialog = DialogResult.OK Then
                                If .strNum_Corre <> "" Then
                                    OptCorrelativo.Checked = True
                                    txtNum_Corre.Text = .strNum_Corre
                                    CargarGrilla()
                                End If
                            End If
                        End With
                    End Using

                Case "IMPRESIONES"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oImp As New FrmDocumentoVenta_Impresiones
                        With oImp
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .SImp_Total = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Total").Index)
                            .sCod_Tipdoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .sCod_Cliente = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_Cliente").Index)
                            .sFlgExp = GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Exportacion").Index)
                            .ShowDialog()
                        End With
                    End Using

                Case "VERDETALLE"
                    VerDetalleVentas

                Case "VERVOUCHER"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    MuestraVoucher2()
                    CargarGrilla()

                Case "ANULAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Anula_Documento()

                Case "REVIERTEDOCUM"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está Seguro de Revertir este Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_Revierte_Docum"
                        strSQL &= vbNewLine & String.Format(" @Num_Corre_Ventas = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@user_crea        = '{0}'", vusu)

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                            'GrdLista.Row = FilaSeleccionada
                        End If
                    End If

                Case "DESPACHO_EXTEMPORANE"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDesp As New FrmDocumentoVenta_DespachoExtemporaneo
                        With oDesp
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & " - " & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .Cod_TipDoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .Serie = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .Nro_doc = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "LDPDDP"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oComp As New FrmDocumentoVenta_CompletarImpLDPDDP
                        With oComp
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .txtFlete.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_flete").Index)
                            .txtDesaduanaje.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("imp_desaduanaje").Index)
                            .txtTransporte.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("imp_transporte_pais_destino").Index)
                            .txtFob.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_FOB").Index)
                            .txtCif.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_CIF").Index)
                            .txtLdp.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_LDP").Index)
                            .txtDdp.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_DDP").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "IMPORTEFOBDUA"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oImp As New FrmDocumentoVenta_ImporteFobDUA
                        With oImp
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .TxtDua.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Dua").Index)
                            .txtFec_Numeracion.Text = IIf(IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_NumeracionDua").Index)), "", GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_NumeracionDua").Index))
                            .txtFec_Embarque.Text = IIf(IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_EmbarqueReal").Index)), "", GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_EmbarqueReal").Index))
                            .TxtImp_FOB_Dol_Dua.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_FOB_Dol_Dua").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "REDONDEAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oRend As New FrmDocumentoVenta_Redondear
                        With oRend
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .Cod_TipDocSel = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .SerieSel = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .Nro_docSel = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .txtImporteNeto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Neto").Index)
                            .txtImporteIgv.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Igv").Index)
                            .txtImporteTotal.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Total").Index)
                            .txtImpTotalActual.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Total").Index)
                            .txtImporteGastosFinan.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Gastos_Financieros").Index)
                            .txtImporteDscto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_descuento").Index)
                            .ValorActualIGV = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Igv").Index)
                            .ValorActualImporteNeto = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Neto").Index)
                            .ValorActualImporteTotalR = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Total").Index)
                            .ValorActualImporteTotal = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Total").Index)
                            .txtImporteOtros.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Imp_Otros").Index)
                            .porcIGV = GrdLista.GetValue(GrdLista.RootTable.Columns("porc_igv").Index)
                            .ShowDialog()
                            CargarGrilla()
                        End With
                    End Using

                Case "GENERAINFOCONT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    GeneraInfoContable()

                Case "RINFCONTABLE"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está Seguro de Revertir Ifx Contable de este Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC CN_REVIERTE_ASIENTO_VENTAS"
                        strSQL &= vbNewLine & String.Format(" @Num_Corre        = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                        strSQL &= vbNewLine & String.Format(",@Flg_Transaction  = '{0}'", "S")
                        strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
                        strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                            'GrdLista.Row = FilaSeleccionada
                        End If
                    End If

                Case "FECDOC"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oFechaEnvioDoc As New FrmDocumentoVenta_FechaEnvioDocumento
                        With oFechaEnvioDoc
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & " - " & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .Cod_TipDoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .Serie = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .Nro_doc = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If Not IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Envio_Documentos_Cobranza").Index)) Then
                                .DTPFechaEnvio.Checked = True
                                .DTPFechaEnvio.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Envio_Documentos_Cobranza").Index)
                            End If

                            If .ShowDialog() = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "FECCOBREPRO"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCob As New FrmDocumentoVenta_FechaCobranzaRepro
                        With oCob
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            If IsDBNull(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Cobranza_Reprogramada").Index)) Then
                                .txtFecCobRepro.Text = ""
                            Else
                                .txtFecCobRepro.Text = RellenaDeCerosEnIzquierda(GrdLista.GetValue(GrdLista.RootTable.Columns("Fec_Cobranza_Reprogramada").Index), 10)
                            End If
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "APLICANCALGO"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Call AplicaNotaCreditoAlgolimsa()

                Case "VERCOBROS"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDocum As New FrmDocumentoVenta_VerCobros
                        With oDocum
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "ELIMFANULADA"
                    Using oElimFact As New FrmDocumentoVenta_ReactivaFactAnulada
                        With oElimFact
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "ACTNFOB"
                    If GrdLista.RowCount > 0 Then
                        actualizarNoFob()
                    Else
                        MessageBox.Show("Seleccione un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub VerDetalleVentas()
        If GrdLista.RowCount = 0 Then Exit Sub
        Using oDet As New FrmDocumentoVenta_VerDetalle
            With oDet
                .Text = "Ver Detalle: " & GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) & " Nro " & GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & "-" & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index) & " Del Cliente " & GrdLista.GetValue(GrdLista.RootTable.Columns("Anexo").Index)
                .strCod_TipDoc = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                .CARGA_GRID()
                .ShowDialog()
                CargarGrilla()
            End With
        End Using
    End Sub

    Private Sub MuestraVoucher2()
        Try
            If RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("num_registro").Index)) = "" Then
                MessageBox.Show("No se le ha Generado Voucher", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using oVouc As New FrmDocumentoVenta_VerVoucher
                With oVouc
                    .TxtRegistro.Text = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Registro").Index))
                    .sCod_TipoDiario = RTrim(oHP.DevuelveDato("select Cod_TipodiarioVentas  from cn_control ", cCONNECT))
                    .sano = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Ano_Registro").Index))
                    .smes = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Mes_registro").Index))
                    .lNum_Registro = RTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Registro").Index))
                    .Num_Corre = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                    .CARGA_GRID()
                    .ShowDialog()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Anula_Documento()
        Try
            If MessageBox.Show("Está Seguro de Anular este Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Ventas_Man_Anula_Docum"
                strSQL &= vbNewLine & String.Format(" @Num_Corre    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                strSQL &= vbNewLine & String.Format(",@cod_usuario  = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                    'GrdLista.Row = FilaSeleccionada
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub GeneraInfoContable()
        Try
            If MessageBox.Show("¿Confirma Generación Contable de Documento?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_GENERA_ASIENTO_VENTAS"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                    'GrdLista.Row = FilaSeleccionada
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub AplicaNotaCreditoAlgolimsa()
        Try
            If MessageBox.Show("¿Seguro que desea aplicar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VENTAS_APLICACION_NC_ALGOLIMSA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                    'GrdLista.Row = FilaSeleccionada
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub actualizarNoFob()
        Try
            If MessageBox.Show("¿Desea Actualizar al estado NO FOB?", "Actualizar Factura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZA_IMPORTE_NO_FOB"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Transacción Realizada con Exito....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                    'GrdLista.Row = FilaSeleccionada
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ButtonBar2_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar2.ItemClick
        Try
            Select Case e.Item.Key
                Case "MOVTELATENIDA"
                    Reporte

                Case "DRAWBACK"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDraw As New FrmDocumentoVenta_DatosDrawback
                        With oDraw
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            strSQL = String.Empty
                            strSQL &= vbNewLine & "EXEC CN_Muestra_ventas_datos_provision_drawback"
                            strSQL &= vbNewLine & String.Format(" @num_corre      = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                            Dim oDr As DataRow
                            If Not oDtResult Is Nothing Then
                                If oDtResult.Rows.Count = 0 Then Exit Sub
                                oDr = oDtResult.Rows(0)
                                .TxtPenalidad.Text = oDr("Imp_Dolares_Penalidad")
                                .txtNota_credito.Text = oDr("Imp_Dolares_Nota_Credito")
                                .TxtNota_Debito.Text = oDr("Imp_Dolares_Nota_Debito")
                                .Txtcomisiones.Text = oDr("Imp_Dolares_Comisiones")
                                .TxtAjuste.Text = oDr("Imp_Dolares_Ajuste")
                            End If
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "DOCUMASO"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oDocum As New FrmDocumentoVenta_DocumentosAsociados
                        With oDocum
                            .TxtNroCorrelativo.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index)
                            .CargarGrilla()
                            .ShowDialog()
                        End With
                    End Using

                Case "COPIADATFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oCopia As New FrmDocumentoVenta_CopiaDatosFactura
                        With oCopia
                            .TxtDocumento.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) & " - " & GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .SerieDocum = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .NumeroDocum = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            If .ShowDialog = DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "ENVDOCEFACT"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está Seguro de Enviar el Documento?", "Enviando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        FraEnvioEfact.Visible = True
                        ENVIAR()
                    End If

                Case "VERSTAFACELEC"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Using oStat As New FrmDocumentoVenta_VerStatusFact
                        With oStat
                            .TxtCodTipoDoc.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)
                            .txtSerie.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index)
                            .txtNumero.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("Nro_Doc").Index)
                            .dtpInicio.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Emision").Index)
                            .dtpFin.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("Emision").Index)
                            .txtCodEnvio.Text = "T"
                            .txtCodProceso.Text = "0"
                            .CARGA_GRID()
                            .ShowDialog()
                        End With
                    End Using
                    '************************* OPCIONES OCULTAS ***********************************************

                Case "EXPORTADBF"
                    'If GridEX1.RowCount > 0 Then Transmitir
                    'Buscar

                Case "GENERABAUCHER"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Genera_Voucher()

                Case "RAIMPRECION"
                    'If GridEX1.RowCount = 0 Then Exit Sub
                    'Buscar
                    'Imprimir GridEX1.Value(GridEX1.Columns("Num_Corre").Index), GridEX1.Value(GridEX1.Columns("Imp_Total").Index), False, GridEX1.Value(GridEX1.Columns("Cod_TipDoc").Index)

                Case "IMPEXP"
                    '                If GridEX1.RowCount = 0 Then Exit Sub
                    '                ' Imprimir_Exp GridEX1.Value(GridEX1.Columns("Num_Corre").Index), GridEX1.Value(GridEX1.Columns("Cod_TipDoc").Index), GridEX1.Value(GridEX1.Columns("Imp_Total").Index)
                    '                Imprimir_Exp GridEX1.Value(GridEX1.Columns("Num_Corre").Index), GridEX1.Value(GridEX1.Columns("Cod_TipDoc").Index), GridEX1.Value(GridEX1.Columns("Imp_Total").Index)
                    'Buscar
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Reporte()
        If Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("num_corre").Index)) <> "" Then
            Dim oo As Object
            Dim sRutaLogo As String
            strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            sRutaLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC VENTAS_MUESTRA_MOVS_TELA_TENIDA_SEGUN_FACTURA"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then
                    MessageBox.Show("No se han encontrado datos para la impresión.....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If
            End If

            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptMovTelaTenidaV1.XLT")
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("reporte", sRutaLogo, strSQL, cCONNECTVB6, Trim(GrdLista.GetValue(GrdLista.RootTable.Columns("num_corre").Index)))
            oo = Nothing
            Exit Sub
        Else
            MessageBox.Show("Seleccione un Documento", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ENVIAR()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_VALIDA_ACTUALIZA_ESTADO_VENTAS_FACTURAS_ELECTRONICAS_SEGURIDAD"
            strSQL &= vbNewLine & String.Format(" @COD_USUARIO      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@COD_ESTACION     = '{0}'", ComputerName())
            strSQL &= vbNewLine & String.Format(",@COD_TIPDOC       = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index))
            strSQL &= vbNewLine & String.Format(",@FEC_ULT_ENVIO    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Emision").Index))
            strSQL &= vbNewLine & String.Format(",@Flg_Baja         = '{0}'", "N")

            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            Dim oDr As DataRow
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then Exit Sub
                oDr = oDtResult.Rows(0)
                If oDr("FLG_ESTADO") = "S" Then
                    Procesar()
                Else
                    MessageBox.Show("Usted no Tiene Acceso.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FraEnvioEfact.Visible = False
                    Exit Sub
                End If
            End If
            FraEnvioEfact.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Procesar_New()
        Try
            Dim sEstatus As String
            Dim strSqlElectronico As String
            Dim NombreTxt As String
            Dim RS1 As New DataTable

            Call CarpetaExist()

            sCod_Tipdoc = RTrim(LTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index)))
            sCod_Usuario = vusu
            sEstatus = oHP.DevuelveDato("SELECT  Flg_Status_Envio_Facturacion_Electronica FROM  CN_VENTAS WHERE Num_Corre = '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)

            If (sEstatus = "S") Then
                MessageBox.Show("Documento ya esta migrado a Digiflow.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            If sCod_Tipdoc = "FA" Then
                If GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) = "FS01" Or GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) = "FS17" Then
                    strSqlElectronico = "EXEC SET_INSERTA_FACTURA_LOCAL '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "','" & sCod_Usuario & "',1"
                End If
            End If

            If sCod_Tipdoc = "BV" Then
                'strSQL = "EXEC CN_VENTAS_FACTURAS_ELECTRONICAS_BV '" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "','" & GridEX1.Value(GridEX1.Columns("Num_Corre").Index) & "'"
                If RTrim(LTrim(GrdLista.GetValue(GrdLista.RootTable.Columns("Flg_Exportacion").Index))) = "N" Then
                    strSqlElectronico = "EXEC SET_INSERTA_FACTURA_LOCAL '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "','" & sCod_Usuario & "',1"
                End If
            End If

            If sCod_Tipdoc = "NC" Or sCod_Tipdoc = "ND" Then
                If GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) = "FCS1" Or GrdLista.GetValue(GrdLista.RootTable.Columns("Serie").Index) = "FDS1" Then
                    strSqlElectronico = "EXEC SET_INSERTA_NOTA_CREDITO_LOCAL '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "','" & sCod_Usuario & "',1"
                Else
                    strSqlElectronico = "EXEC SET_INSERTA_NOTA_CREDITO '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "','" & sCod_Usuario & "',1"
                End If
            End If

            If (Len(strSqlElectronico) > 0) Then
                NombreTxt = oHP.DevuelveDato("EXEC USPGET_NOMBRE_TXT_FACT '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'", cCONNECT)
                RS1 = oHP.EjecutaOperacionRetornaDatos(strSqlElectronico, cCONNECT)

                Dim RutaLocal As String
                RutaLocal = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                RutaLocal = RutaLocal & "\txt_docum_temporal\"

                If Not System.IO.Directory.Exists(RutaLocal) Then
                    System.IO.Directory.CreateDirectory(RutaLocal)
                End If

                RutaLocal = RutaLocal & NombreTxt & ".txt"
                Dim SW As New System.IO.StreamWriter(RutaLocal)
                If RS1.Rows.Count > 0 Then
                    For i = 0 To RS1.Rows.Count - 1
                        SW.WriteLine(RS1.Rows(i)("CODIGO_FACTURACION").ToString.Trim)
                    Next

                    Call MoverTxt(NombreTxt)

                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC VENTAS_ACTUALIZAR_ESTADO_ENVIO"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
                    strSQL &= vbNewLine & String.Format(",@COD_ESTACION = '{0}'", Trim(ComputerName()))
                    oHP.EjecutaOperacion(strSqlElectronico, cCONNECT)

                    RS1 = Nothing
                    SW.Close()
                End If
            End If
            Exit Sub

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub Procesar()
        Try
            'Dim xRs As ADODB.Recordset
            'Dim xRs2 As ADODB.Recordset
            Dim strSQL As String
            Dim sArchivoEnCola As String

            strSQL = "EXEC CN_MUESTRA_VENTAS_FACTURAS_ELECTRONICAS_SEGURIDAD '" & Trim(ComputerName()) & "','" & GrdLista.GetValue(GrdLista.RootTable.Columns("Cod_TipDoc").Index) & "'"
            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            Dim oDr As DataRow
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then
                    Label24.Text = "Usuario no Autorizado"
                    Label25.Text = ""
                    Label26.Text = ""
                    Label27.Text = ""
                    Label28.Text = ""
                    Exit Sub
                Else
                    oDr = oDtResult.Rows(0)
                    sCod_Usuario = Trim(oDr("COD_USUARIO"))
                    sCod_Tipdoc = Trim(oDr("COD_TIPDOC"))
                    sFEC_ULT_ENVIO = Strings.Format(oDr("FEC_ULT_ENVIO"), "dd/MM/yyyy")
                    sFlg_Baja = Trim(oDr("Flg_Baja"))
                    Label24.Text = "Acceso Concedido para Generar Información"
                    Label25.Text = ""
                    Label26.Text = ""
                    Label27.Text = ""
                    Label28.Text = ""
                End If
            End If

            If sFlg_Baja = "S" Then
                strSQL = "EXEC CN_VENTAS_FACTURAS_ELECTRONICAS_COMUNICACION_BAJA '" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "'"
            Else

                If sCod_Tipdoc = "FA" Then
                    strSQL = "EXEC CN_VENTAS_FACTURAS_ELECTRONICAS_FA '" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "','" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'"
                End If

                If sCod_Tipdoc = "BV" Then
                    strSQL = "EXEC CN_VENTAS_FACTURAS_ELECTRONICAS_BV '" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "','" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'"
                End If

                If sCod_Tipdoc = "NC" Or sCod_Tipdoc = "ND" Then
                    strSQL = "EXEC CN_VENTAS_FACTURAS_ELECTRONICAS_NC_ND '" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "','" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "'"
                End If
            End If
            Dim oDtResul2t As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            Dim oDr2 As DataRow
            If Not oDtResul2t Is Nothing Then
                If oDtResul2t.Rows.Count = 0 Then
                    Label25.Text = "No Existe Información a Enviar"
                    Label26.Text = ""
                    Label27.Text = ""
                    Label28.Text = ""
                    Exit Sub
                Else
                    oDr2 = oDtResul2t.Rows(0)
                    Label25.Text = "Información Encontrada para Transmitir"
                    Label26.Text = ""
                    Label27.Text = ""
                    Label28.Text = ""
                End If
            End If

            strSQL = "Select dbo.CN_OBTIENE_RUTA_CSV_FACTURAS_ELECTRONICAS('" & sFEC_ULT_ENVIO & "','" & sCod_Usuario & "','" & Trim(ComputerName()) & "','" & sCod_Tipdoc & "',0,'" & sFlg_Baja & "','" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "')"
            Nom_Archivo = oHP.DevuelveDato(strSQL, cCONNECT)

            If Len(Nom_Archivo) > 0 Then
                Label26.Text = "Se Obtuvo Correctamente el Nombre del Archivo Csv"
                Label27.Text = ""
                Label28.Text = ""
            Else
                Label26.Text = "No Existe Nombre del Archivo"
                Label27.Text = ""
                Label28.Text = ""
                Exit Sub
            End If


            '***********************++CORREGIR
            'If Exportar_ADO_Csv(Nom_Archivo, xRs2) Then
            '    MessageBox.Show("Se Exporto Corremente" & vbCrLf & Nom_Archivo, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            '    Label27.Text = "Archivo CSV Generado Correctamente"
            '    Label28.Text = ""
            '    CommonDialog1.FileName = Replace(Nom_Archivo, ".CSV", ".")
            '    CommonDialog1.DefaultExt = ".csv"
            '    CommonDialog1.Filter = Nom_Archivo
            'Else
            '    Label27.Text = "ERROR ARCHIVO NO GENERADO. REITENTAR"
            '    Label28.Text = ""
            '    Exit Sub
            'End If

            'sArchivoEnCola = Replace(Nom_Archivo, "OUTPUT", "COLA")
            'sArchivoEnCola = Strings.Left(sArchivoEnCola, Len(sArchivoEnCola) - 4)

            'Open(sArchivoEnCola For Output As #1)
            'Close #1

            strSQL = "VENTAS_ACTUALIZAR_ESTADO_ENVIO '" & GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index) & "','" & vusu & "','" & Trim(ComputerName()) & "'"
            oHP.EjecutaOperacion(strSQL, cCONNECT)

            Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error en Generación de Arhcivo Csv", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Function Exportar_ADO_Csv(sOutputPathXLS As String, xRss As ADODB.Recordset) As Boolean
        Try
            'Dim cn          As New ADODB.Connection
            Dim Rs As New ADODB.Recordset
            Dim Excel As Object
            Dim Libro As Object
            Dim Hoja As Object
            Dim arrData As Object
            Dim iRs As Long
            Dim iCol As Integer
            Dim iRow As Integer
            Dim sSql As String

            Me.Enabled = False

            ' -- Abrir la base
            'cn.Open "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & sPathDB & ";"

            ' -- Abrir el Recordset pasándole la cadena sql
            'rec.Open Sql, cn

            'ssql = "VENTAS_REPORTE_RESUMEN_VENTAS '" & dtpFecIni.Value & "','" & dtpFecFin.Value & "','" & txtCodCliente.Tag & "','" & sValChk & "', 3"
            Rs = xRss

            ' -- Crear los objetos para utilizar el Excel
            Excel = CreateObject("Excel.Application")
            Libro = Excel.Workbooks.Add

            ' -- Hacer referencia a la hoja
            Hoja = Libro.Worksheets(1)

            'Excel.Visible = True
            Excel.UserControl = True

            iCol = Rs.Fields.Count
            If Val(Mid(Excel.Version, 1, InStr(1, Excel.Version, ".") - 1)) > 8 Then
                Hoja.Cells(1, 1).CopyFromRecordset(Rs)
            Else
                MessageBox.Show("Versión de Excel incorrecta para enviar archivos a SUNAT. Versión Excel debe ser mayor a 8.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exportar_ADO_Csv = False
                Exit Function
            End If

            Excel.Selection.CurrentRegion.Columns.AutoFit
            Excel.Selection.CurrentRegion.Rows.AutoFit

            ' -- Cierra el recordset y la base de datos y los objetos ADO
            Rs.Close()
            'cn.Close

            Rs = Nothing

            Libro.WebOptions.encoding = 65001 'msoEncodingUTF8

            ' -- guardar el libro
            Libro.SaveAs(sOutputPathXLS, FileFormat:=6, TextCodepage:=42)

            'Libro.Close
            Libro.Close(SaveChanges:=False)

            Dim ByteArray
            ByteArray = CreateObject("ScriptUtils.ByteArray")

            'Read file with source code page.
            ByteArray.ReadFrom(sOutputPathXLS)

            'Set right code page for the bytearray
            ByteArray.Charset = "windows-1250"

            'Convert the data to a destination code page and save them to a second file
            ByteArray.CharSetConvert("utf-8").SaveAs(sOutputPathXLS, 2)

            ByteArray = Nothing

            Call Reemplazar_Texto(sOutputPathXLS, "Åƒ", "Ã‘")

            ' -- Elimina las referencias Xls
            Hoja = Nothing
            Libro = Nothing
            Excel.Quit
            Excel = Nothing

            Me.Enabled = True
            Exportar_ADO_Csv = True
            Exit Function
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exportar_ADO_Csv = False
            Me.Enabled = True
        End Try
    End Function

    Private Sub Reemplazar_Texto(ByVal El_Archivo As String,
                            ByVal La_cadena As String,
                            ByVal Nueva_Cadena As String)

        Try
            Dim F As Integer
            Dim Contenido As String
            Dim LineaTexto As String

            '        F = FreeFile()

            '        'Abre el archivo para leer los datos
            '        Open El_Archivo For Input As F

            ''carga el contenido del archivo en la variable
            '        Contenido = Input$(LOF(F), #F)

            '        'Cierra el archivo
            '        Close #F

            '' Ejecuta la función Replace, pasandole los datos
            'Contenido = Replace(Contenido, La_cadena, Nueva_Cadena)

            '        If Right$(Trim(Contenido), 2) = vbCrLf Then
            '            Contenido = Left$(Trim(Contenido), Len(Trim(Contenido)) - 2)
            '        End If

            '        F = FreeFile()
            '        'Abre un nuevo archivo
            '        Open El_Archivo For Output As F
            ''Graba los nuevos datos
            '        Print #F, RTrim(Contenido)

            ''cierra el archivo
            '        Close #F
            '  Close()
            '        '    MsgBox " Archivo modificado ", vbInformation
            '        Exit Sub
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click

    End Sub

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

    Private Sub Genera_Voucher()
        Try
            If MessageBox.Show("Genera Voucher De Ventas...?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_GENERA_VOUCHER_VENTAS"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", GrdLista.GetValue(GrdLista.RootTable.Columns("Num_Corre").Index))
                strSQL &= vbNewLine & String.Format(",@cod_usuario  = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("El proceso se realizó correctamente....", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargarGrilla()
                    'GrdLista.Row = FilaSeleccionada
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class