Public Class FrmDocumentoVenta_CompletarImpLDPDDP
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_CompletarImpLDPDDP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtFlete
    End Sub

    Private Sub txtFlete_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFlete.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDesaduanaje.Focus()
        End If
    End Sub

    Private Sub txtDesaduanaje_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesaduanaje.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtTransporte.Focus()
        End If
    End Sub

    Private Sub txtTransporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTransporte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFob.Focus()
        End If
    End Sub

    Private Sub txtFob_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFob.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            calcular
            txtCif.Focus()
        End If
    End Sub

    Private Sub txtCif_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCif.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtLdp.Focus()
        End If
    End Sub

    Private Sub txtLdp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLdp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            calcular
            txtDdp.Focus()
        End If
    End Sub

    Private Sub txtDdp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDdp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Sub calcular()
        txtCif.Text = Conversion.Fix(txtFob.Text) + Conversion.Fix(txtFlete.Text)
        txtLdp.Text = Conversion.Fix(txtCif.Text) + Conversion.Fix(txtDesaduanaje.Text)
        txtDdp.Text = Conversion.Fix(txtLdp.Text) + Conversion.Fix(txtTransporte.Text)
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            calcular()

            If MessageBox.Show("¿Está seguro de grabar los datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If ValidaCampos() Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC CN_VENTAS_ACTUALIZAR_PRECIOS_LDP_DDP"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE        = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@Imp_Desaduanaje  =  {0} ", CDbl(txtDesaduanaje.Text))
                    strSQL &= vbNewLine & String.Format(",@Imp_Transporte_Pais_Destino      =  {0} ", CDbl(txtTransporte.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_FOB          =  {0} ", CDbl(txtFob.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_CIF          =  {0} ", CDbl(txtCif.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_LDP          =  {0} ", CDbl(txtLdp.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_DDP          =  {0} ", CDbl(txtDdp.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_FLETE        =  {0} ", CDbl(txtFlete.Text))

                    If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                        DialogResult = DialogResult.OK
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Function ValidaCampos() As Boolean
        Dim strMsg As String
        strMsg = ""

        If Conversion.Fix(txtCif.Text) < 0 Then
            strMsg = "El valor CIF no puede ser Negativo"
        End If

        If Conversion.Fix(txtLdp.Text) < 0 Then
            strMsg = "El valor LDP no puede ser Negativo"
        End If

        If Conversion.Fix(txtDdp.Text) < 0 Then
            strMsg = "El valor DDP no puede ser Negativo"
        End If

        If strMsg <> "" Then
            MessageBox.Show(strMsg, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
            ValidaCampos = False
            Exit Function
        End If
        ValidaCampos = True
    End Function

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = DialogResult.Cancel
    End Sub
End Class