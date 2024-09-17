Public Class FrmDocumentoVentaExportacion_GuiaLocal
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_GuiaLocal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        DTPicker1.Value = Now.Date

        Me.ActiveControl = TxtRucTransp
    End Sub

    Private Sub TxtRucTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRucTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRUC()
        End If
    End Sub

    Private Sub TxtTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRUC()
        End If
    End Sub

    Public Sub BuscaRUC()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "EXEC SP_MUESTRA_TRANSPORTE_LOCAL_GUIA"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("RUC")
            Descripcion = oTipo.dtResultados.Rows(0)("RAZON_SOCIAL")
            TipoAdd = oTipo.dtResultados.Rows(0)("DIRECCION")
        End If

        If Codigo <> "" Then
            TxtRucTransp.Text = Codigo
            TxtTransp.Text = Descripcion
            TxtDireccionTransp.Text = TipoAdd
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            TxtDireccionTransp.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub TxtDireccionTransp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccionTransp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtPlaca.Focus()
        End If
    End Sub

    Private Sub TxtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtMarca.Focus()
        End If
    End Sub

    Private Sub TxtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtMarca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtLicencia.Focus()
        End If
    End Sub

    Private Sub TxtLicencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLicencia.KeyPress
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
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim oo As Object
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Genera_Interfase_FE_LOCALES"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@guia         = '{0}'", TxtSerie.Text & "-" & TxtNumero.Text)
            strSQL &= vbNewLine & String.Format(",@Fecha        = '{0}'", DTPicker1.Value.ToShortDateString)
            strSQL &= vbNewLine & String.Format(",@Nom_Transp   = '{0}'", TxtTransp.Text)
            strSQL &= vbNewLine & String.Format(",@Ruc_Transp   = '{0}'", TxtRucTransp.Text)
            strSQL &= vbNewLine & String.Format(",@Lic_Transp   = '{0}'", TxtLicencia.Text)
            strSQL &= vbNewLine & String.Format(",@Marca_Transp = '{0}'", TxtMarca.Text)
            strSQL &= vbNewLine & String.Format(",@Placa_Transp = '{0}'", TxtPlaca.Text)

            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\Guia_Venta_Local.xlt")
            oo.DisplayAlerts = False
            oo.Visible = True
            oo.Run("REPORTE", strSQL, cCONNECTVB6)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class