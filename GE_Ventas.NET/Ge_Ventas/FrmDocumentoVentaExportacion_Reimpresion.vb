Public Class FrmDocumentoVentaExportacion_Reimpresion
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public NombreXLT As String

    Private Sub FrmDocumentoVentaExportacion_Reimpresion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtCodigoSecuencia
    End Sub

    Private Sub txtCodigoSecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodigoSecuencia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaCliente(1)
        End If
    End Sub

    Private Sub txtDescripcionSecuencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionSecuencia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaCliente(2)
        End If
    End Sub

    Public Sub BuscaCliente(Opcion As String)
        strSQL = "select * from dbo.[TG_Tipo_Invoice] "
        If Trim(txtCodigoSecuencia.Text) <> "" Then
            strSQL = strSQL & "WHERE Secuencia='" & txtCodigoSecuencia.Text & "'"
        End If
        Select Case Opcion
            Case 1 : strSQL = strSQL
            Case 2 : strSQL = strSQL & "WHERE Descripcion LIKE '%" & txtDescripcionSecuencia.Text & "%'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        oTipo.DGridLista.RootTable.Columns("id_formato_invoice").Visible = False
        oTipo.DGridLista.RootTable.Columns("nom_plantilla_xlt").Visible = False
        oTipo.DGridLista.RootTable.Columns("Secuencia").Width = 100
        oTipo.DGridLista.RootTable.Columns("Descripcion").Width = 237

        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Id_Formato_Invoice")
            Descripcion = oTipo.dtResultados.Rows(0)("Secuencia")
            TipoAdd = oTipo.dtResultados.Rows(0)("Descripcion")
            TipoAdd2 = oTipo.dtResultados.Rows(0)("Nom_Plantilla_XLT")
        End If

        If Codigo <> "" Then
            txtCodigoSecuencia.Tag = Codigo
            txtCodigoSecuencia.Text = Descripcion
            txtDescripcionSecuencia.Text = TipoAdd
            NombreXLT = TipoAdd2
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            BtnAceptar.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Trim(txtCodigoSecuencia.Text) = "" Or Trim(txtDescripcionSecuencia.Text) = "" Then
            MessageBox.Show("Debe Buscar un Formato", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class