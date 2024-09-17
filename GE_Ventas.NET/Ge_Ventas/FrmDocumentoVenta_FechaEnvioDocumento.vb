Public Class FrmDocumentoVenta_FechaEnvioDocumento
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Public Cod_TipDoc As String
    Public Serie As String
    Public Nro_doc As String

    Private Sub FrmDocumentoVenta_FechaEnvioDocumento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = DTPFechaEnvio
    End Sub

    Private Sub DTPFechaEnvio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DTPFechaEnvio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If DTPFechaEnvio.Checked = False Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VN_Actualiza_FechaEnvioDocum"
                strSQL &= vbNewLine & String.Format(" @Cod_TipDoc                   = '{0}'", Cod_TipDoc)
                strSQL &= vbNewLine & String.Format(",@Ser_Docum                    = '{0}'", Serie)
                strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas             = '{0}'", Nro_doc)
                strSQL &= vbNewLine & String.Format(",@Fec_Envio_Documentos_Cobranza= '{0}'", "NULL")
            Else
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VN_Actualiza_FechaEnvioDocum"
                strSQL &= vbNewLine & String.Format(" @Cod_TipDoc                   = '{0}'", Cod_TipDoc)
                strSQL &= vbNewLine & String.Format(",@Ser_Docum                    = '{0}'", Serie)
                strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas             = '{0}'", Nro_doc)
                strSQL &= vbNewLine & String.Format(",@Fec_Envio_Documentos_Cobranza= '{0}'", DTPFechaEnvio.Value.ToShortDateString)
            End If

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class