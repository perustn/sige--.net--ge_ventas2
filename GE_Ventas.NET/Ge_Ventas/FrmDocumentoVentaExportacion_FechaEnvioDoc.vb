Public Class FrmDocumentoVentaExportacion_FechaEnvioDoc
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public Cod_TipDoc As String

    Private Sub FrmDocumentoVentaExportacion_FechaEnvioDoc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = DTPFecha
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim FechaSel As String
            If DTPFecha.Checked = True Then
                FechaSel = "'" & DTPFecha.Value.ToShortDateString & "'"
            Else
                FechaSel = "NULL"
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC VN_Actualiza_FechaEnvioDocum"
            strSQL &= vbNewLine & String.Format(" @Cod_TipDoc       = '{0}'", Cod_TipDoc)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", TxtSerie.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", TxtDocumento.Text)
            strSQL &= vbNewLine & String.Format(",@Fec_Envio_Documentos_Cobranza   =  {0} ", FechaSel)

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