Public Class FrmDocumentoVentaExportacion_VerDetalle_RegPesos
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_VerDetalle_RegPesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtPeso_Bruto
    End Sub

    Private Sub txtPeso_Bruto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Bruto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPeso_Neto.Focus()
        Else
            ValidarSoloDecimales(txtPeso_Bruto.Text, e)
        End If
    End Sub

    Private Sub txtPeso_Neto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Neto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(txtPeso_Neto.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_VENTAS_PRENDAS_PESOS"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@SECUENCIA    =  {0} ", TxtSec.Text)
            strSQL &= vbNewLine & String.Format(",@PESO_BRUTO   = '{0}'", CDbl(txtPeso_Bruto.Text))
            strSQL &= vbNewLine & String.Format(",@PESO_NETO    = '{0}'", CDbl(txtPeso_Neto.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso culminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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