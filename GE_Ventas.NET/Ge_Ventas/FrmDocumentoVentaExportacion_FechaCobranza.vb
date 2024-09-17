Public Class FrmDocumentoVentaExportacion_FechaCobranza
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_FechaCobranza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = DtpFecCobRepro
    End Sub

    Private Sub DtpFecCobRepro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpFecCobRepro.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim FechaSel As String
            If DtpFecCobRepro.Checked = True Then
                FechaSel = "'" & DtpFecCobRepro.Value.ToShortDateString & "'"
            Else
                FechaSel = "NULL"
            End If

            If MessageBox.Show("Está seguro que desea actualizar la Fecha?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZA_FEC_COBRANZA_REPROGRAMADA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@Fec_Cobranza_Reprogramada   =  {0} ", FechaSel)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("EL proceso se actualizó correctamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                    DialogResult = Windows.Forms.DialogResult.OK
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class