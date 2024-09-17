Public Class FrmDocumentoVenta_DatosDrawback
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_DatosDrawback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = TxtPenalidad

    End Sub

    Private Sub TxtPenalidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtPenalidad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNota_credito.Focus()
        Else
            ValidarSoloDecimales(TxtPenalidad.Text, e)
        End If
    End Sub

    Private Sub txtNota_credito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNota_credito.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtNota_Debito.Focus()
        Else
            ValidarSoloDecimales(txtNota_credito.Text, e)
        End If
    End Sub

    Private Sub TxtNota_Debito_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtNota_Debito.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Txtcomisiones.Focus()
        Else
            ValidarSoloDecimales(TxtNota_Debito.Text, e)
        End If
    End Sub

    Private Sub Txtcomisiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtcomisiones.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtAjuste.Focus()
        Else
            ValidarSoloDecimales(Txtcomisiones.Text, e)
        End If
    End Sub

    Private Sub TxtAjuste_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtAjuste.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(TxtAjuste.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MANT_VENTAS_DATOS_PROVISION_DRAWBACK"
            strSQL &= vbNewLine & String.Format(" @Num_Corre                = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Dolares_Penalidad    = '{0}'", TxtPenalidad.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Dolares_Nota_Credito = '{0}'", txtNota_credito.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Dolares_Nota_Debito  = '{0}'", TxtNota_Debito.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Dolares_Comisiones   = '{0}'", Txtcomisiones.Text)
            strSQL &= vbNewLine & String.Format(",@Imp_Dolares_Ajuste       = '{0}'", TxtAjuste.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Se Grabó correctemante", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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