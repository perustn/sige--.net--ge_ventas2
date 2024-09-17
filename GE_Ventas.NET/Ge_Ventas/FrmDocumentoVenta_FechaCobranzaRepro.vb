Public Class FrmDocumentoVenta_FechaCobranzaRepro
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_FechaCobranzaRepro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa


        Me.ActiveControl = txtFecCobRepro
    End Sub

    Private Sub txtFecCobRepro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFecCobRepro.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If Trim(txtFecCobRepro.Text) = "" Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZA_FEC_COBRANZA_REPROGRAMADA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE                    = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@Fec_Cobranza_Reprogramada    =  {0} ", "NULL")
            Else
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZA_FEC_COBRANZA_REPROGRAMADA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@@Fec_Cobranza_Reprogramada  = '{0}'", Strings.Format(txtFecCobRepro.Text, "DD/MM/YYYY"))
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