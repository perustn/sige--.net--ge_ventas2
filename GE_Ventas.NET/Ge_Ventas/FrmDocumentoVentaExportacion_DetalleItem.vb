Public Class FrmDocumentoVentaExportacion_DetalleItem
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_DetalleItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtDescripcion
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDescripcionIngles.Focus()
        End If
    End Sub

    Private Sub txtDescripcionIngles_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionIngles.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPrecio.Focus()
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If Me.txtCantidad.Text = "" Then
                MessageBox.Show("Debe ingresar cantidad", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Me.txtPrecio.Text = "" Then
                MessageBox.Show("Debe ingresar Precio Unitario", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            strSQL = String.Empty
            strSQL = "exec cn_graba_detalle_items '" & TxtNroCorrelativo.Text &
                                               "','" & Me.txtDescripcion.Text &
                                               "','" & Me.txtDescripcionIngles.Text &
                                               "', " & CDbl(Me.txtCantidad.Text) &
                                               "," & CDbl(Me.txtPrecio.Text)

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