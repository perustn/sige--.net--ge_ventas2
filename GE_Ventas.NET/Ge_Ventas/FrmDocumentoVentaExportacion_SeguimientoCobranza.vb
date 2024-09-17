Public Class FrmDocumentoVentaExportacion_SeguimientoCobranza
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_SeguimientoCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = TxtCod_Concepto

    End Sub

    Private Sub TxtCod_Concepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCod_Concepto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Buscar_Concepto(1)
        End If
    End Sub

    Private Sub TxtDes_Concepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDes_Concepto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Buscar_Concepto(1)
        End If
    End Sub

    Private Sub Buscar_Concepto(Opcion As Integer)
        Select Case Opcion
            Case 1 : strSQL = "SELECT Codigo,Descripcion FROM tg_tipos_tabla_detalle WHERE cod_tipo_tabla='017' and codigo like '%" & TxtCod_Concepto.Text & "%'"
            Case 2 : strSQL = "SELECT Codigo,Descripcion FROM tg_tipos_tabla_detalle WHERE cod_tipo_tabla='017' and Descripcion like '%" & TxtDes_Concepto.Text & "%'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Codigo")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            TxtCod_Concepto.Text = Codigo
            TxtDes_Concepto.Text = Descripcion
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            If TxtCod_Concepto.Text = "PRO" Then
                LabelFecha.Visible = True
                DtpFecha.Visible = True
                DtpFecha.Focus()
            Else
                LabelFecha.Visible = False
                DtpFecha.Visible = False
                BtnAceptar.Focus()
            End If
        End If
        oTipo = Nothing
    End Sub

    Private Sub DtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpFecha.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZA_GLOSA_FECHA_COBRANZA"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE                = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Tip_Glosa_Cobranza       = '{0}'", TxtCod_Concepto.Text)
            If TxtCod_Concepto.Text = "PRO" Then
                strSQL &= vbNewLine & String.Format(",@Fec_Prevista_Cancelacion = '{0}'", DtpFecha.Value.ToString)
            Else
                strSQL &= vbNewLine & String.Format(",@Fec_Prevista_Cancelacion =  {0} ", "NULL")
            End If

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("EL proceso se actualizó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class