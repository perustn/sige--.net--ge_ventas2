Public Class FrmTgEmbarque_CambiarInstruccionFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Public sNum_Embarque As String
    Private colEmpresa As Color

    Private Sub FrmTgEmbarque_CambiarInstruccionFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtSerie
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtSerie.Text.Trim = "" Then
                txtSerie.Select()
            Else
                txtNumero.Select()
            End If
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtNumero.Text.Trim = "" Then
                txtNumero.Select()
            Else
                txtNumero.Text = RellenaDeCerosEnIzquierda(txtNumero.Text, 8)
            End If
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Call Procesar()
    End Sub

    Sub Procesar()
        Try
            If MessageBox.Show("Confirma Copiado de factura?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            strSQL = "EXEC TG_EMBARQUE_MAN_COPIA_INSTRUCCION"
            strSQL &= vbNewLine & String.Format(" @SER_DOCUM_ORIGEN         = '{0}'", txtSerie.Text)
            strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS_ORIGEN  = '{0}'", Trim(txtNumero.Text))
            strSQL &= vbNewLine & String.Format(",@NUM_EMBARQUE_DESTINO     = '{0}'", sNum_Embarque)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class