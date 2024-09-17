Public Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMTMec
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String, TipoAdd4 As String, TipoAdd5 As String
    Dim Envio As New EnvioTrama

    Private Sub FrmDocumentoVentaExportacion_GenFacturasGuiasCMTMec_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        DTPicker1.Value = Now.Date
        DTPicker2.Value = Now.Date

        Me.ActiveControl = TxtRucTransp
    End Sub

    Sub CantidadGuias()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_MuestraCantidadGuias_Mecanizada"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", TxtCodCli.Text)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD   = '{0}'", TxtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI   = '{0}'", TxtEstilo.Text)
            Dim oDtDataGuia As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)
            LblCantidad.Text = oDtDataGuia.Rows(0)(0).ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TxtRucTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRucTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRazon()
        End If
    End Sub

    Private Sub TxtTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRazon()
        End If
    End Sub

    Public Sub BuscaRazon()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT CODIGO,RUC,RAZON_SOCIAL,DIRECCION From CF_EMPRESA_TRANSPORTE"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("CODIGO")
            Descripcion = oTipo.dtResultados.Rows(0)("RUC")
            TipoAdd = oTipo.dtResultados.Rows(0)("RAZON_SOCIAL")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("DIRECCION")
        End If

        If Codigo <> "" Then
            TxtRucTransp.Text = Trim(Descripcion)
            TxtTransp.Text = Trim(TipoAdd)
            TxtDireccionTransp.Text = Trim(TipoAdd2)
            TxtPlaca.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtDireccionTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccionTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtPlaca.Focus()
        End If
    End Sub

    Private Sub TxtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaPlaca
        End If
    End Sub

    Public Sub BuscaPlaca()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT Sec_Transp, Marca, Placa, Peso, Reg_Transportista AS Cert_Inscripcion FROM CF_TRANSPORTE where Ruc_CfEmpTrn = '" & TxtRucTransp.Text & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Sec_Transp")
            Descripcion = oTipo.dtResultados.Rows(0)("Marca")
            TipoAdd = oTipo.dtResultados.Rows(0)("Placa")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("Peso")
            TipoAdd3 = oTipo.dtResultados.Rows(0)("Cert_Inscripcion")
        End If

        If Codigo <> "" Then
            TxtPlaca.Text = TipoAdd
            TxtMarca.Text = Descripcion
            TxtRegMTC.Text = TipoAdd3
            TxtChofer.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMarca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtRegMTC.Focus()
        End If
    End Sub

    Private Sub TxtRegMTC_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRegMTC.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtChofer.Focus()
        End If
    End Sub

    Private Sub TxtChofer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtChofer.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaChofer()
        End If
    End Sub

    Public Sub BuscaChofer()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT Secuencia, Nom_Conductor, Num_Licencia From Cf_Choferes Where Ruc_CfEmpTrn = '" & TxtRucTransp.Text & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Secuencia")
            Descripcion = oTipo.dtResultados.Rows(0)("Nom_Conductor")
            TipoAdd = oTipo.dtResultados.Rows(0)("Num_Licencia")
        End If

        If Codigo <> "" Then
            TxtChofer.Text = Descripcion
            TxtLicencia.Text = TipoAdd
            TxtLlegada.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtLicencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLicencia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaLicencia
        End If
    End Sub

    Public Sub BuscaLicencia()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "EXEC UP_MAN_CF_TRANSPORTE 'S','','','',0,'','" & TxtRucTransp.Text & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Sec_Transp")
            Descripcion = oTipo.dtResultados.Rows(0)("Marca")
            TipoAdd = oTipo.dtResultados.Rows(0)("Placa")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("Peso")
            TipoAdd3 = oTipo.dtResultados.Rows(0)("Reg_Transportista")
            TipoAdd4 = oTipo.dtResultados.Rows(0)("Ruc_CfEmpTrn")
        End If

        If Codigo <> "" Then
            TxtPlaca.Text = TipoAdd
            TxtMarca.Text = Descripcion
            TxtRegMTC.Text = TipoAdd3
            TxtLlegada.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtLlegada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLlegada.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtSerie.Focus()
        End If
    End Sub

    Private Sub TxtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSerie.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNumero.Focus()
        End If
    End Sub

    Private Sub TxtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNumero.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            DTPicker1.Focus()
        End If
    End Sub

    Private Sub DTPicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPicker1.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            DTPicker2.Focus()
        End If
    End Sub

    Private Sub DTPicker2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPicker2.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtSerie.Focus()
        End If
    End Sub

    Private Sub TxtCodMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodMotivo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaMotivo
        End If
    End Sub

    Private Sub TxtMotivo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMotivo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaMotivo
        End If
    End Sub

    Public Sub BuscaMotivo()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "EXEC SP_ListaMotivoTransporte"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCodMotivo.Text = Codigo
            TxtMotivo.Text = Descripcion
            BtnAceptar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim x As Integer
            Dim I As Integer
            Dim nrogui As Integer
            Dim vlNum As String
            Dim vlSerie As String
            Dim vlNumCorre As String
            Dim vlCodCli As String
            Dim vlPO As String
            Dim vlEstilo As String
            Dim NroCajas As String
            Dim dato As String
            Dim cadenaGuias As String


            x = Val(LblCantidad.Text)

            If Trim(TxtRucTransp.Text) = "" Then
                MessageBox.Show("RUC Transportista esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtTransp.Text) = "" Then
                MessageBox.Show("Razon Social Transportista esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtDireccionTransp.Text) = "" Then
                MessageBox.Show("Direccion Transportista esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtPlaca.Text) = "" Then
                MessageBox.Show("Placa esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtMarca.Text) = "" Then
                MessageBox.Show("Marca esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtLicencia.Text) = "" Then
                MessageBox.Show("Licencia esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtRegMTC.Text) = "" Then
                MessageBox.Show("Registro MTC esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtSerie.Text) = "" Then
                MessageBox.Show("Serie Guía esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtNumero.Text) = "" Then
                MessageBox.Show("Numero Guía esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If Trim(TxtCodMotivo.Text) = "" Or Trim(TxtMotivo.Text) = "" Then
                MessageBox.Show("Motivo esta vacio..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If


            nrogui = Val(TxtNumero.Text) - 1
            vlSerie = TxtSerie.Text

            For I = 1 To x
                vlNum = Strings.Right("0000000" + CStr(nrogui + I), 7)
                cadenaGuias = cadenaGuias + vlSerie + "-" + vlNum + ","
                dato = ""
                Call ImprimirGuia(I, x, dato, vlSerie + "-" + vlNum, cadenaGuias)
            Next
            MessageBox.Show("Documento(s) Impreso Correctamente..!!", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Me.Close()
            cadenaGuias = ""
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub ImprimirGuia(x As Integer, y As Integer, Cajas As String, NumGuiax As String, CadGuia As String)
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Genera_Guia_Despacho_CMT_STN_Estilo_PO_Mecanizada_04"
        strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
        strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", TxtCodCli.Text)
        strSQL &= vbNewLine & String.Format(",@COD_PURORD   = '{0}'", TxtPO.Text)
        strSQL &= vbNewLine & String.Format(",@COD_ESTCLI   = '{0}'", TxtEstilo.Text)
        strSQL &= vbNewLine & String.Format(",@INDEX        =  {0} ", CStr(x))

        Dim oo As Object
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\Rpt_New_GuiaMecanizada.xlt")
        oo.DisplayAlerts = False
        '      oo.Visible = True
        oo.Run("REPORTE", strSQL, cCONNECTVB6, Cajas, DTPicker1.Value.ToShortDateString, DTPicker2.Value.ToShortDateString, NumGuiax, Trim(TxtMotivo.Text), Trim(TxtTransp.Text), Trim(TxtDireccionTransp.Text),
        Trim(TxtRucTransp.Text), Trim(TxtPlaca.Text), Trim(TxtMarca.Text), Trim(TxtLicencia.Text), Trim(TxtRegMTC.Text), Trim(TxtLlegada.Text), x, y, CadGuia)
        oo = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnPreview_Click(sender As Object, e As EventArgs) Handles BtnPreview.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Genera_Guia_Despacho_CMT_STN_Estilo_PO_Mecanizada_PREVIEW"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", TxtCodCli.Text)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD   = '{0}'", TxtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI   = '{0}'", TxtEstilo.Text)

            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\Rpt_New_GuiaMecanizadaPreview.xlt")
            oo.DisplayAlerts = False
            oo.Visible = True
            oo.Run("REPORTE", strSQL, cCONNECTVB6)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class