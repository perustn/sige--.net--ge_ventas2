Public Class FrmDocumentoVentaExportacion_MuestraGuiaRemision
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String, TipoAdd4 As String, TipoAdd5 As String
    Dim Envio As New EnvioTrama

    Public v_Tipo As String

    Private Sub FrmDocumentoVentaExportacion_MuestraGuiaRemision_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = TxtRuc
    End Sub

    Private Sub TxtRuc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRuc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRazon()
        End If
    End Sub

    Private Sub TxtRazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtRazonSocial.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaRazon()
        End If
    End Sub

    Public Sub BuscaRazon()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT Cod_Transporte as Codigo, RazonSocial, Ruc, Direccion From Tg_Transporte_Guia_Exportacion where Flg_Elim = 0"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("RazonSocial")
            TipoAdd = oTipo.dtResultados.Rows(0)("Ruc")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("Direccion")
        End If

        If Codigo <> "" Then
            TxtCod_Transporte.Text = Trim(Codigo)
            TxtRazonSocial.Text = Trim(Descripcion)
            TxtRuc.Text = Trim(TipoAdd)
            TxtDireccion.Text = Trim(TipoAdd2)
            TxtSec_Vehiculo.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDireccion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtSec_Vehiculo.Focus()
        End If
    End Sub

    Private Sub TxtSec_Vehiculo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSec_Vehiculo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Buscavehiculo()
        End If
    End Sub

    Private Sub TxtPlaca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPlaca.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Buscavehiculo()
        End If
    End Sub

    Public Sub Buscavehiculo()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "SELECT Sec_Vehiculo as Codigo, Placa, Marca From Tg_Transporte_Guia_Exportacion_Vehiculos where Cod_Transporte = '" & TxtCod_Transporte.Text & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Placa")
        End If

        If Codigo <> "" Then
            TxtSec_Vehiculo.Text = Trim(Codigo)
            TxtPlaca.Text = Trim(Descripcion)
            TxtSec_Chofer.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtSec_Chofer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtSec_Chofer.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaChofer()
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
        oTipo.sQuery = "SELECT Sec_Transportista as Codigo, Nombres, Nro_doc, Nro_Licencia From Tg_Transporte_Guia_Exportacion_Transportista where Cod_Transporte = '" & TxtCod_Transporte.Text & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Nombres")
            TipoAdd = oTipo.dtResultados.Rows(0)("Nro_doc")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("Nro_Licencia")
        End If

        If Codigo <> "" Then
            TxtSec_Chofer.Text = Trim(Codigo)
            TxtChofer.Text = Trim(Descripcion)
            TxtNombres.Text = Trim(TipoAdd)
            TxtLicencia.Text = Trim(TipoAdd2)

            Text5.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub TxtNombres_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNombres.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtLicencia.Focus()
        End If
    End Sub

    Private Sub TxtLicencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtLicencia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Text5.Focus()
        End If
    End Sub

    Private Sub Text5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text5.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaSerie()
        End If
    End Sub

    Public Sub BuscaSerie()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "exec SP_MUESTRA_SERIE_GUI_MUESTRAS '" & v_Tipo & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("SERIE")
            Descripcion = oTipo.dtResultados.Rows(0)("NUMERO")
        End If

        If Codigo <> "" Then
            Text5.Text = Trim(Codigo)
            Text1.Text = Trim(Descripcion)

            BtnAceptar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub Text1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text1.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If v_Tipo = "M" Then
            Grabar
        End If

        If v_Tipo = "C" Then
            Grabar_Courier
        End If
    End Sub

    Sub Grabar()
        Try
            Dim scadena As String
            Dim sURL As String
            Dim sResp As String

            If Trim(TxtCod_Transporte.Text) = "" Then
                Exit Sub
            End If

            If Trim(TxtSec_Vehiculo.Text) = "" Then
                Exit Sub
            End If

            If Trim(TxtSec_Chofer.Text) = "" Then
                Exit Sub
            End If

            If Trim(Text5.Text) = "" Then
                Exit Sub
            End If

            If Trim(Text1.Text) = "" Then
                Exit Sub
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_facturacion_electronica_generar_TXT_GR_Muestras"
            strSQL &= vbNewLine & String.Format(" @num_corre        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@OPCION           = '{0}'", "2")
            strSQL &= vbNewLine & String.Format(",@Cod_Transporte   = '{0}'", TxtCod_Transporte.Text)
            strSQL &= vbNewLine & String.Format(",@Sec_Vehiculo     = '{0}'", TxtSec_Vehiculo.Text)
            strSQL &= vbNewLine & String.Format(",@Sec_Transportista= '{0}'", TxtSec_Chofer.Text)
            strSQL &= vbNewLine & String.Format(",@Serie            = '{0}'", Text5.Text)
            strSQL &= vbNewLine & String.Format(",@Numero           = '{0}'", Text1.Text)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)
            Dim oDtDataGuia As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

            If oDtDataGuia.Rows.Count > 0 Then
                scadena = oDT.Rows(0)(0).ToString

                sURL = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA_GR ", cCONNECT)
                Dim Datos As String = scadena
                Dim docid As String = "FF12-001"
                Dim comando As String = "emitir"
                Dim parametro As String = ""
                Dim respuesta As String = Envio.SendCA4XMLRequest(sURL, docid, comando, parametro, Datos)
                If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                    MessageBox.Show("Envio Exitoso..!!" & vbCrLf & respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()
                Else
                    MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Grabar_Courier()
        Try
            Dim X_Serie_Numero As String
            Dim scadena As String
            Dim sURL As String
            Dim sResp As String

            If Trim(TxtCod_Transporte.Text) = "" Then
                Exit Sub
            End If

            If Trim(TxtSec_Vehiculo.Text) = "" Then
                Exit Sub
            End If

            If Trim(TxtSec_Chofer.Text) = "" Then
                Exit Sub
            End If

            If Trim(Text5.Text) = "" Then
                Exit Sub
            End If

            If Trim(Text1.Text) = "" Then
                Exit Sub
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_Genera_GR_Courier_Exportacion_Auto_GR_CMT"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_TRANSPORTE   = '{0}'", TxtCod_Transporte.Text)
            strSQL &= vbNewLine & String.Format(",@SEC_VEHICULO     = '{0}'", TxtSec_Vehiculo.Text)
            strSQL &= vbNewLine & String.Format(",@SEC_TRANSPORTISTA= '{0}'", TxtSec_Chofer.Text)
            strSQL &= vbNewLine & String.Format(",@SERIE            = '{0}'", Text5.Text)
            strSQL &= vbNewLine & String.Format(",@NUMERO           = '{0}'", Text1.Text)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)
            Dim oDtTablaData As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

            If oDtTablaData.Rows.Count > 0 Then
                For Each odr As DataRow In oDtTablaData.Rows
                    scadena = ""
                    X_Serie_Numero = ""
                    scadena = Trim(odr("TRAZA_GR"))
                    X_Serie_Numero = Trim(odr("Serie")) & "-" & Trim(odr("Numero"))
                    sURL = oHP.DevuelveDato("EXEC SP_IP_SERVER_ACEPTA_GR ", cCONNECT)
                    Dim respuesta As String = Envio.SendCA4XMLRequest(sURL, X_Serie_Numero, "emitir", "", scadena)
                    If (respuesta.Substring(0, 2).ToUpper = "OK") Then
                        If Trim(odr("Cod_Fabrica")) = "001" Then
                            MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                        Me.Close()
                    Else
                        MessageBox.Show(respuesta.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Me.Close()
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class