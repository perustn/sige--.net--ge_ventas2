Public Class FrmDocumentoVentaExportacion_AnularFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_AnularFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        dtpReactiva.Value = Now.Date

        Me.ActiveControl = txtCod_TipDoc2
    End Sub

    Private Sub txtCod_TipDoc2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipDoc2.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSer_Docum2.Focus()
        End If
    End Sub

    Private Sub txtSer_Docum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSer_Docum2.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Docum2.Focus()
        End If
    End Sub

    Private Sub txtNum_Docum2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Docum2.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Docum2.Text = RellenaDeCerosEnIzquierda(txtNum_Docum2.Text, 8)
            dtpReactiva.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtNum_Docum2_LostFocus(sender As Object, e As EventArgs) Handles txtNum_Docum2.LostFocus
        txtNum_Docum2.Text = RellenaDeCerosEnIzquierda(txtNum_Docum2.Text, 8)
    End Sub

    Private Sub dtpReactiva_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpReactiva.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("Confirma Anulación de Factura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VENTAS_ANULACION_MANUAL_FACTURA"
                strSQL &= vbNewLine & String.Format(" @COD_TIPDOC       = '{0}'", txtCod_TipDoc2.Text)
                strSQL &= vbNewLine & String.Format(",@SER_DOCUM        = '{0}'", txtSer_Docum2.Text)
                strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS = '{0}'", txtNum_Docum2.Text)
                strSQL &= vbNewLine & String.Format(",@FEC_ANULACION    = '{0}'", dtpReactiva.Value.ToShortDateString)
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO      = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    DialogResult = Windows.Forms.DialogResult.OK
                End IF
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class