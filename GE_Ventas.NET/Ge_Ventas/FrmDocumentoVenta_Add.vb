Public Class FrmDocumentoVenta_Add
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String

    Public strCod_Anxo As String
    Public MarcaVehiculo, CertificadoInscripcionVehiculo, LicenciaVehiculo As String
    Public strNum_Corre As String
    Public StrOption As String

    Private Sub FrmDocumentoVenta_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtCod_TipDoc
    End Sub

    Sub Cambio_FR()
        Imp_Gastos_Finacieros.Text = 0
        Imp_Otros.Text = 0
        Imp_Flete.Text = 0
        txtPeso_Bruto.Text = 0
        txtShip_Date.Text = ""
        txtPeso_Neto.Text = 0
        txtNum_Bulto.Text = 0
        chkFlete.Checked = False
        chkSeguro.Checked = False
        frOtros.Visible = False
        frExportacion.Visible = False
        frReferencia.Visible = False
        frGuiaFact.Visible = False


        If txtCod_TipDoc.Text = "NC" Or txtCod_TipDoc.Text = "ND" Then
            frReferencia.Visible = True
        End If

        If chkExportacion.Checked = True Then
            frExportacion.Visible = True
            frOtros.Visible = False
            frGuiaFact.Visible = False
        End If

        If chkExonerado.Checked = True Then
            frExportacion.Visible = False
            frOtros.Visible = True
            frGuiaFact.Visible = False
        End If

        If chkDetraccion.Checked = True Then
            frExportacion.Visible = False
            frOtros.Visible = True
            frGuiaFact.Visible = False
        End If

        If chkGuiaFact.Checked = True Then
            frExportacion.Visible = False
            frOtros.Visible = False
            frGuiaFact.Visible = True
        End If
    End Sub

    Private Sub txtCod_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 1)
            Cambio_FR()
            If txtCod_TipDoc.Text = "BV" Then txtCod_TipAne.Text = ""
            txtCod_TipVenta.Focus()
        End If
    End Sub

    Private Sub txtDes_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 2)
            Cambio_FR()
            txtCod_TipVenta.Focus()
        End If
    End Sub

    Private Sub txtCod_TipVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipVenta.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Tipo_Venta", "Descripcion", "Cn_Tipos_Venta where ", txtCod_TipVenta, txtDes_TipVenta, 1)
            txtSer_Docum.Focus()
        End If
    End Sub

    Private Sub txtDes_TipVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipVenta.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Tipo_Venta", "Descripcion", "Cn_Tipos_Venta where ", txtCod_TipVenta, txtDes_TipVenta, 2)
            txtSer_Docum.Focus()
        End If
    End Sub

    Private Sub txtSer_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSer_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSer_Docum.Text = RellenaDeCerosEnIzquierda(txtSer_Docum.Text, 3)
            Call BUSCA_SERIE
        End If
    End Sub

    Public Sub BUSCA_SERIE()
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me
        oTipo.SQuery = "EXEC CF_AYUDA_CN_VENTAS_SERIES '" & txtCod_TipDoc.Text & "'"
        oTipo.Cargar_Datos
        oTipo.ShowDialog()
        If Codigo <> "" Then
            Me.txtSer_Docum.Text = Trim(Codigo)
            Me.txtNum_Docum.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtNum_Docum.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtNum_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Docum.Text = RellenaDeCerosEnIzquierda(txtNum_Docum.Text, 8)
            txtCod_TipAne.Focus()
        End If
    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Call ImcrementaCorrelativo
    End Sub

    Sub ImcrementaCorrelativo()
        Try
            If (Trim(txtSer_Docum.Text) <> "") Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_INCREMENTA_VENTAS_SERIES"
                strSQL &= vbNewLine & String.Format(" @COD_TIPDOC   = '{0}'", txtCod_TipDoc.Text)
                strSQL &= vbNewLine & String.Format(",@SER_DOCUM    = '{0}'", txtSer_Docum.Text)
                Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                Dim oDr As DataRow
                If Not oDtResult Is Nothing Then
                    If oDtResult.Rows.Count = 0 Then Exit Sub
                    oDr = oDtResult.Rows(0)
                    txtNum_Docum.Text = IIf(IsDBNull(oDr("Num_Docum_Ventas")), "", oDr("Num_Docum_Ventas"))
                End If
            Else
                MessageBox.Show("Debe Ingresar un Número de Serie", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub txtCod_TipAne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipAne.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_TipAnex", "Des_Tipanex", "CN_TipoAnexoContable where ", txtCod_TipAne, txtDes_TipAne, 1)
            txtNum_Ruc.Focus()
        End If
    End Sub

    Private Sub txtDes_TipAne_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipAne.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion_Anexo1("Num_Ruc", "Des_Anexo", txtCod_TipAne.Text, txtNum_Ruc, txtDes_TipAne, txtCod_TipAne, 2, Me)
            txtNum_Ruc.Focus()
        End If
    End Sub

    Private Sub txtNum_Ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Ruc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion_Anexo1("Num_Ruc", "Des_Anexo", txtCod_TipAne.Text, txtNum_Ruc, txtDes_TipAne, txtCod_TipAne, 1, Me)
            inpFec_EmiDoc.Focus()
        End If
    End Sub

    Sub Busca_Opcion_Anexo1(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, txtTipo As TextBox, Opcion As Integer, frmME As Form)
        Try
            strSQL = "select cod_tipanex as Tipo,Cod_Anxo as Cod,Des_Anexo as Nombre,Num_Ruc as Ruc from cn_anexoscontables where cod_tipanex like '%" & StrTabla & "%' and "
            Select Case Opcion
                Case 1 : strSQL = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
                Case 2 : strSQL = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
            End Select

            txtCod.Text = ""
            txtDes.Text = ""
            txtTipo.Text = ""

            Dim oTipo As New frmBusGeneral7
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()

            oTipo.DGridLista.RootTable.Columns("Cod").Visible = False
            oTipo.DGridLista.RootTable.Columns("Tipo").Width = 60
            oTipo.DGridLista.RootTable.Columns("Nombre").Width = 200
            oTipo.DGridLista.RootTable.Columns("RUC").Width = 120

            If oTipo.dtResultados.Rows.Count = 1 Then
                strCod_Anxo = Trim(oTipo.dtResultados.Rows(0)("Cod"))
                txtCod.Text = Trim(oTipo.dtResultados.Rows(0)("Ruc"))
                txtDes.Text = Trim(oTipo.dtResultados.Rows(0)("Nombre"))
                txtTipo.Text = Trim(oTipo.dtResultados.Rows(0)("Tipo"))
                inpFec_EmiDoc.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    strCod_Anxo = Trim(oTipo.RegistroSeleccionado.Cells("Cod").Value)
                    txtCod.Text = Trim(oTipo.RegistroSeleccionado.Cells("Ruc").Value)
                    txtDes.Text = Trim(oTipo.RegistroSeleccionado.Cells("Nombre").Value)
                    txtTipo.Text = Trim(oTipo.RegistroSeleccionado.Cells("Tipo").Value)
                    inpFec_EmiDoc.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub inpFec_EmiDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inpFec_EmiDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            InpFec_RegDoc.Focus()
        End If
    End Sub

    Private Sub inpFec_EmiDoc_LostFocus(sender As Object, e As EventArgs) Handles inpFec_EmiDoc.LostFocus
        TxtTipo_Cambio.Text = oHP.DevuelveDato("select Tipo_Venta from cn_tipocambio where fecha = '" & inpFec_EmiDoc.Text & "'", cCONNECT)
    End Sub

    Private Sub InpFec_RegDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles InpFec_RegDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtTipo_Cambio.Focus()
        End If
    End Sub

    Private Sub TxtTipo_Cambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTipo_Cambio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Moneda.Focus()
        End If
    End Sub

    Private Sub txtCod_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Moneda", "Nom_Moneda", "TG_Moneda where ", txtCod_Moneda, txtDes_Moneda, 1)
            txtCod_ConPag.Focus()
        End If
    End Sub

    Private Sub txtDes_Moneda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Moneda.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Moneda", "Nom_Moneda", "TG_Moneda where ", txtCod_Moneda, txtDes_Moneda, 2)
            txtCod_ConPag.Focus()
        End If
    End Sub

    Private Sub txtCod_ConPag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_ConPag.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_CondVent", "Des_CondVent", "Lg_CondVent where ", txtCod_ConPag, txtDes_ConPag, 1)
            txtNro_Guias.Focus()
        End If
    End Sub

    Private Sub txtDes_ConPag_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_ConPag.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_CondVent", "Des_CondVent", "Lg_CondVent where ", txtCod_ConPag, txtDes_ConPag, 2)
            txtNro_Guias.Focus()
        End If
    End Sub

    Private Sub txtNro_Guias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNro_Guias.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNro_Ordener.Focus()
        End If
    End Sub

    Private Sub txtNro_Ordener_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNro_Ordener.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNro_DocInter.Focus()
        End If
    End Sub

    Private Sub txtNro_DocInter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNro_DocInter.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtObservacion.Focus()
        End If
    End Sub

    Private Sub txtObservacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtObservacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Flete.Focus()
        End If
    End Sub

    Private Sub txtCod_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Flete.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Flete", "Des_Flete", "Tg_TipoFlete where ", txtCod_Flete, txtDes_Flete, 1)
            txtCod_Termino_Venta.Focus()
        End If
    End Sub

    Private Sub txtDes_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Flete.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Termino_Venta.Focus()
        End If
    End Sub

    Private Sub txtCod_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Termino_Venta.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaTerminoVent(1)
        End If
    End Sub

    Private Sub txtDes_Termino_Venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Termino_Venta.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaTerminoVent(2)
        End If
    End Sub

    Public Sub BuscaTerminoVent(Opcion As Integer)
        Try
            strSQL = "SELECT Cod_Termino_Venta, Des_Termino_Venta FROM CN_Termino_Venta WHERE "
            Select Case Opcion
                Case 1 : strSQL = strSQL & "Cod_Termino_Venta like '%" & txtCod_Termino_Venta.Text & "%'"
                Case 2 : strSQL = strSQL & "Des_Termino_Venta LIKE '%" & txtDes_Termino_Venta.Text & "%'"
            End Select

            Dim oTipo As New frmBusqGeneral6
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod_Termino_Venta.Text = Trim(oTipo.dtResultados.Rows(0)("Cod_Termino_Venta"))
                txtDes_Termino_Venta.Text = Trim(oTipo.dtResultados.Rows(0)("Des_Termino_Venta"))
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod_Termino_Venta.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod_Termino_Venta").Value)
                    txtDes_Termino_Venta.Text = Trim(oTipo.RegistroSeleccionado.Cells("Des_Termino_Venta").Value)
                End If
            End If
            If frReferencia.Visible = True Then
                txtCod_NotaAbono.Focus()
            Else
                txtPeso_Bruto.Focus()
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCod_NotaAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_NotaAbono.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Mot_Nota", "Descripcion", "Cn_Ventas_Motivos_Notas_Abonos where Cod_TipDoc ='" & txtCod_TipDoc.Text & "' and ", txtCod_NotaAbono, txtDes_NotaAbono, 1)
            txtReferencia.Focus()
        End If
    End Sub

    Private Sub txtDes_NotaAbono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_NotaAbono.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Mot_Nota", "Descripcion", "Cn_Ventas_Motivos_Notas_Abonos where Cod_TipDoc ='" & txtCod_TipDoc.Text & "' and ", txtCod_NotaAbono, txtDes_NotaAbono, 2)
            txtReferencia.Focus()
        End If
    End Sub

    Private Sub txtReferencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReferencia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            inpFec_RefDoc.Focus()
        End If
    End Sub

    Private Sub inpFec_RefDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles inpFec_RefDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPeso_Bruto.Focus()
        End If
    End Sub

    Private Sub txtPeso_Bruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Bruto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPeso_Neto.Focus()
        End If
    End Sub

    Private Sub txtPeso_Neto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Neto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Bulto.Focus()
        End If
    End Sub

    Private Sub txtNum_Bulto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Bulto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then

        End If
    End Sub

    Private Sub txtCod_Destino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Destino.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Destino", "Des_Destino", "tg_destino where ", txtCod_Destino, txtDes_Destino, 1)
            txtShip_Date.Focus()
        End If
    End Sub

    Private Sub txtDes_Destino_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Destino.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_Destino", "Des_Destino", "tg_destino where ", txtCod_Destino, txtDes_Destino, 2)
            txtShip_Date.Focus()
        End If
    End Sub

    Private Sub txtShip_Date_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtShip_Date.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_Seguro.Focus()
        End If
    End Sub

    Private Sub txtImp_Seguro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Seguro.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtEmbarque_Cod.Focus()
        End If
    End Sub

    Private Sub txtEmbarque_Cod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmbarque_Cod.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Tip_Embarque", "Des_TipEmbarque", "TG_TipoEmbarque where ", txtEmbarque_Cod, txtEmbarque_Des, 1)
            Imp_Flete.Focus()
        End If
    End Sub

    Private Sub txtEmbarque_Des_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmbarque_Des.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Tip_Embarque", "Des_TipEmbarque", "TG_TipoEmbarque where ", txtEmbarque_Cod, txtEmbarque_Des, 1)
            Imp_Flete.Focus()
        End If
    End Sub

    Private Sub Imp_Flete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Imp_Flete.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDua.Focus()
        End If
    End Sub

    Private Sub txtDua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDua.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFec_Numeracion.Focus()
        End If
    End Sub

    Private Sub txtFec_Numeracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec_Numeracion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFec_Embarque.Focus()
        End If
    End Sub

    Private Sub txtFec_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec_Embarque.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_FOB_Dol_Dua.Focus()
        End If
    End Sub

    Private Sub txtImp_FOB_Dol_Dua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_FOB_Dol_Dua.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtcajas.Focus()
        End If
    End Sub

    Private Sub txtcajas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcajas.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNotify.Focus()
        End If
    End Sub

    Private Sub txtNotify_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNotify.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtGlosa.Focus()
        End If
    End Sub

    Private Sub CheckSel(sender As Object, e As EventArgs) Handles chkDetraccion.Click, chkGuiaFact.Click, chkExportacion.Click, chkExonerado.Click
        Cambio_FR()
    End Sub

    Private Sub txtCod_DocPar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_DocPar.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_DirDestino", "Des_DirDestino", "LG_PROVEEDOR_DIRDESTINO WHERE Cod_Proveedor = '000000000001' AND ", txtCod_DocPar, txtDes_DocPar, 1)
            txtCod_DocLle.Focus()
        End If
    End Sub

    Private Sub txtDes_DocPar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_DocPar.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_DocLle.Focus()
        End If
    End Sub

    Private Sub txtCod_DocLle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_DocLle.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_DirDestino", "Des_DirDestino", "CN_ANEXOSCONTABLES_DIRDESTINO WHERE COD_TIPANEX = 'C' AND COD_ANXO = '" & strCod_Anxo & "' AND ", txtCod_DocLle, txtDes_DocLle, 1)
            CmdCodUbigeo.Focus()
        End If
    End Sub

    Private Sub txtDes_DocLle_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_DocLle.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Transporte.Focus()
        End If
    End Sub

    Private Sub CmdCodUbigeo_Click(sender As Object, e As EventArgs) Handles CmdCodUbigeo.Click
        Using oDir As New FrmDocumentoVenta_AddMantAnexosDireccion
            With oDir
                .TxtAnexoContable.Text = txtCod_TipAne.Text & " - " & strCod_Anxo & " - " & Trim(txtDes_TipAne.Text)
                .Cod_TipAnex = txtCod_TipAne.Text
                .Cod_Anexo = strCod_Anxo
                .CARGA_GRID()
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub txtCod_Transporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Transporte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion2("Sec_Transp", "Marca", "Placa", "LG_TRANSPORTE where ", txtCod_Transporte, txtDes_Transporte, 1)
            txtCod_Chofer.Focus()
        End If
    End Sub

    Private Sub txtDes_Transporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Transporte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion2("Sec_Transp", "Marca", "Placa", "LG_TRANSPORTE where ", txtCod_Transporte, txtDes_Transporte, 2)
            txtCod_Chofer.Focus()
        End If
    End Sub

    Sub Busca_Opcion2(strCampo1 As String, strCampo2 As String, strCampo3 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, Opcion As Integer)
        Try
            strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion, " & strCampo3 & " from " & StrTabla
            Select Case Opcion
                Case 1 : strSQL = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
                Case 2 : strSQL = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
            End Select

            txtCod.Text = ""
            txtDes.Text = ""

            Dim oTipo As New frmBusGeneral7
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod.Text = Trim(oTipo.dtResultados.Rows(0)("Cod"))
                txtDes.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
                txtCod_Chofer.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod").Value)
                    txtDes.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                    txtCod_Chofer.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmdTransportista_Click(sender As Object, e As EventArgs) Handles CmdTransportista.Click
        Call Me.BUSCA_TRANSPORTISTA(3)
    End Sub

    Public Sub BUSCA_TRANSPORTISTA(Tipo As Integer)
        MarcaVehiculo = ""
        CertificadoInscripcionVehiculo = ""
        LicenciaVehiculo = ""

        Select Case Tipo
            Case 1
                strSQL = "Select nom_conductor as Descripcion from Lg_Transportista where secuencia='" & Trim(Me.txtCod_Transporte.Text) & "'"
                Me.txtDes_Transporte.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                strSQL = "SELECT LTRIM(Placa) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                Me.TxtPlaca.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                strSQL = "SELECT LTRIM(Marca) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                MarcaVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                strSQL = "SELECT LTRIM(Reg_Transportista) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                CertificadoInscripcionVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                strSQL = "SELECT LTRIM(Num_Licencia) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                LicenciaVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))

            Case 2, 3
                Dim oTipo As New frmBusqGeneral6
                oTipo.oParent = Me
                If Tipo = 2 Then
                    oTipo.SQuery = "Select secuencia as Codigo,nom_conductor as Descripcion from lg_transportista Where nom_conductor like '%" & Trim(Me.txtDes_Transporte.Text) & "%' order by 2"
                Else
                    oTipo.SQuery = "Select secuencia as Codigo,nom_conductor as Descripcion from lg_transportista order by 2"
                End If
                oTipo.Cargar_Datos
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    Me.txtCod_Transporte.Text = Trim(Codigo)
                    Me.txtDes_Transporte.Text = Trim(Descripcion)
                    strSQL = "SELECT LTRIM(Placa) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                    Me.TxtPlaca.Text = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                    strSQL = "SELECT LTRIM(Marca) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                    MarcaVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                    strSQL = "SELECT LTRIM(Reg_Transportista) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                    CertificadoInscripcionVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                    strSQL = "SELECT LTRIM(Num_Licencia) FROM lg_transportista WHERE secuencia='" & Trim(Codigo) & "'"
                    LicenciaVehiculo = Trim(oHP.DevuelveDato(strSQL, cCONNECT))
                    Codigo = "" : Descripcion = "" : TipoAdd = ""
                End If
                oTipo = Nothing
        End Select
    End Sub

    Private Sub Command1_Click(sender As Object, e As EventArgs) Handles Command1.Click
        'frmManTransportistas.Show 1
    End Sub

    Private Sub txtCod_Chofer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Chofer.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Secuencia", "Nom_Conductor", "LG_CHOFERES where ", txtCod_Chofer, txtDes_Chofer, 1)
            TxtPlaca.Focus()
        End If
    End Sub

    Private Sub txtDes_Chofer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Chofer.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Secuencia", "Nom_Conductor", "LG_CHOFERES where ", txtCod_Chofer, txtDes_Chofer, 2)
            TxtPlaca.Focus()
        End If
    End Sub

    Private Sub TxtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtGlosa.Focus()
        End If
    End Sub

    Private Sub cmdTrans_Click(sender As Object, e As EventArgs) Handles cmdTrans.Click
        'FrmManTransporteNuevo.Show vbModal
    End Sub

    Private Sub Imp_Gastos_Finacieros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Imp_Gastos_Finacieros.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Imp_Otros.Focus()
        End If
    End Sub

    Private Sub Imp_Otros_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Imp_Otros.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtGlosa.Focus()
        End If
    End Sub

    Private Sub txtGlosa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGlosa.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Sub Busca_Opcion(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, Opcion As Integer)
        Try
            strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
            Select Case Opcion
                Case 1 : strSQL = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
                Case 2 : strSQL = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
            End Select

            txtCod.Text = ""
            txtDes.Text = ""

            Dim oTipo As New frmBusqGeneral6
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod.Text = Trim(oTipo.dtResultados.Rows(0)("Cod"))
                txtDes.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
                'BtnAceptar.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod").Value)
                    txtDes.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                    'BtnAceptar.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("Desea Grabar esta Grabar la Factura " & txtSer_Docum.Text & "-" & txtNum_Docum.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Ventas_Up_Man"
                strSQL &= vbNewLine & String.Format(" @StrOption                = '{0}'", StrOption)
                strSQL &= vbNewLine & String.Format(",@Num_Corre                = '{0}'", strNum_Corre)
                strSQL &= vbNewLine & String.Format(",@Cod_TipDoc               = '{0}'", txtCod_TipDoc.Text)
                strSQL &= vbNewLine & String.Format(",@Ser_Docum                = '{0}'", txtSer_Docum.Text)
                strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas         = '{0}'", txtNum_Docum.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Tipanex              = '{0}'", txtCod_TipAne.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Anxo                 = '{0}'", strCod_Anxo)
                strSQL &= vbNewLine & String.Format(",@Cod_CondVent             = '{0}'", txtCod_ConPag.Text)
                strSQL &= vbNewLine & String.Format(",@Fec_EmiDoc               = '{0}'", inpFec_EmiDoc.Text)
                strSQL &= vbNewLine & String.Format(",@Fec_RegDoc               = '{0}'", InpFec_RegDoc.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Moneda               = '{0}'", txtCod_Moneda.Text)
                strSQL &= vbNewLine & String.Format(",@Imp_Gastos_Financieros   =  {0} ", Imp_Gastos_Finacieros.Text)
                strSQL &= vbNewLine & String.Format(",@Imp_Otros                =  {0} ", Imp_Otros.Text)
                strSQL &= vbNewLine & String.Format(",@Glosa                    = '{0}'", Des_Apos(txtGlosa.Text))
                strSQL &= vbNewLine & String.Format(",@Cod_Usuario_Registro     = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@Guias                    = '{0}'", txtNro_Guias.Text)
                strSQL &= vbNewLine & String.Format(",@Pedidos                  = '{0}'", txtNro_Ordener.Text)
                strSQL &= vbNewLine & String.Format(",@Partes                   = '{0}'", txtNro_DocInter.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Tipo_Venta           = '{0}'", txtCod_TipVenta.Text)
                strSQL &= vbNewLine & String.Format(",@Flg_Exportacion          = '{0}'", IIf(chkExportacion.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@Imp_Flete                =  {0} ", Imp_Flete.Text)
                strSQL &= vbNewLine & String.Format(",@Tipo_Cambio              =  {0} ", Val(TxtTipo_Cambio.Text))
                strSQL &= vbNewLine & String.Format(",@Flg_Inc_Flete_Export     = '{0}'", IIf(chkFlete.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@Glosa_Documento_Referencia  = '{0}'", Des_Apos(txtReferencia.Text))
                strSQL &= vbNewLine & String.Format(",@Observacion              = '{0}'", Des_Apos(txtObservacion.Text))
                strSQL &= vbNewLine & String.Format(",@Cod_Destino              = '{0}'", txtCod_Destino.Text)
                strSQL &= vbNewLine & String.Format(",@Ship_Date                = '{0}'", IIf(txtShip_Date.Text = "  /  /", "", txtShip_Date.Text))
                strSQL &= vbNewLine & String.Format(",@Peso_Bruto               =  {0} ", txtPeso_Bruto.Text)
                strSQL &= vbNewLine & String.Format(",@Peso_Neto                =  {0} ", txtPeso_Neto.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Mot_Nota             = '{0}'", txtCod_NotaAbono.Text)
                strSQL &= vbNewLine & String.Format(",@Imp_Seguro               =  {0} ", CDbl(If(txtImp_Seguro.Text = "", 0, txtImp_Seguro.Text)))
                strSQL &= vbNewLine & String.Format(",@Tip_Embarque             = '{0}'", txtEmbarque_Cod.Text)
                strSQL &= vbNewLine & String.Format(",@Num_Dua                  = '{0}'", txtDua.Text)
                strSQL &= vbNewLine & String.Format(",@Fec_NumeracionDua        = '{0}'", IIf(txtFec_Numeracion.Text = "  /  /", "", txtFec_Numeracion.Text))
                strSQL &= vbNewLine & String.Format(",@Fec_EmbarqueReal         = '{0}'", IIf(txtFec_Embarque.Text = "  /  /", "", txtFec_Embarque.Text))
                strSQL &= vbNewLine & String.Format(",@Flg_Inc_Seguro_Export    = '{0}'", IIf(chkSeguro.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@Flg_Retencion_IGV        = '{0}'", IIf(chkDetraccion.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@imp_FOB_Dol_Dua          = '{0}'", CDbl(If(txtImp_FOB_Dol_Dua.Text = "", 0, txtImp_FOB_Dol_Dua.Text)))
                strSQL &= vbNewLine & String.Format(",@Num_Cajas                =  {0} ", Val(txtcajas.Text))
                strSQL &= vbNewLine & String.Format(",@Flg_Exonerado_IGV        = '{0}'", IIf(chkExonerado.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@cod_flete                = '{0}'", txtCod_Flete.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_Termino_Venta        = '{0}'", txtCod_Termino_Venta.Text)
                strSQL &= vbNewLine & String.Format(",@Flg_Guia_Factura         = '{0}'", IIf(chkGuiaFact.Checked = True, "S", "N"))
                strSQL &= vbNewLine & String.Format(",@Cod_DirPartida           = '{0}'", txtCod_DocPar.Text)
                strSQL &= vbNewLine & String.Format(",@Cod_DirLlegada           = '{0}'", txtCod_DocLle.Text)
                strSQL &= vbNewLine & String.Format(",@Sec_Transp               = '{0}'", txtCod_Transporte.Text)
                strSQL &= vbNewLine & String.Format(",@Sec_Chofer               = '{0}'", txtCod_Chofer.Text)
                strSQL &= vbNewLine & String.Format(",@Notify_Asociado          = '{0}'", txtNotify.Text)
                strSQL &= vbNewLine & String.Format(",@Num_Bultos               =  {0} ", Val(txtNum_Bulto.Text))
                'strSQL &= vbNewLine & String.Format(",@FLG_TRANACCION           = '{0}'", "S")
                'strSQL &= vbNewLine & String.Format(",@Fec_RefDoc               = '{0}'", IIf(inpFec_RefDoc.Text = "  /  /", "", inpFec_RefDoc.Text))

                Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                Dim oDr As DataRow
                If Not oDtResult Is Nothing Then
                    If oDtResult.Rows.Count = 0 Then Exit Sub
                    oDr = oDtResult.Rows(0)
                    strNum_Corre = oDr("Num_Corre")
                    DialogResult = DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub


End Class