Public Class FrmDocumentoVentaExportacion_ModificarPeso
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_ModificarPeso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtPesoBruMod
    End Sub

    Private Sub txtPesoBruMod_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPesoBruMod.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(txtPesoBruMod.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If Val(txtPesoBruMod.Text) <= 0 Then
                MessageBox.Show("Peso debe ser Mayor que Cero...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtPesoBruMod.Focus()
            End If

            If MessageBox.Show("Está Seguro de Modificar Pesos...?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VENTAS_MODIFICA_PESOS_FACTURA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE    = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@PESO_BRUTO   = '{0}'", txtPesoBruMod.Text)
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se Actualizo con Éxito", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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