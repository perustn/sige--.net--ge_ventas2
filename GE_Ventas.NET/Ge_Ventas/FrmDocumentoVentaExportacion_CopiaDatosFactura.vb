Public Class FrmDocumentoVentaExportacion_CopiaDatosFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_CopiaDatosFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtSerFactDst
    End Sub

    Private Sub txtSerFactDst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerFactDst.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSerFactDst.Text = RellenaDeCerosEnIzquierda(txtSerFactDst.Text, 3)
            txtNumFactDst.Focus()
        End If
    End Sub

    Private Sub txtNumFactDst_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumFactDst.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNumFactDst.Text = RellenaDeCerosEnIzquierda(txtNumFactDst.Text, 8)
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("Está Seguro de Copiar Datos?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VENTAS_MAN_COPIA_DATOS_DESDE_FACTURA"
                strSQL &= vbNewLine & String.Format(" @SER_DOCUM_ORIGEN         = '{0}'", TxtSerieOrigen.Text)
                strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS_ORIGEN  = '{0}'", TxtDocumentoOrigen.Text)
                strSQL &= vbNewLine & String.Format(",@SER_DOCUM_DESTINO        = '{0}'", txtSerFactDst.Text)
                strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS_DESTINO = '{0}'", txtNumFactDst.Text)
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO              = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
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