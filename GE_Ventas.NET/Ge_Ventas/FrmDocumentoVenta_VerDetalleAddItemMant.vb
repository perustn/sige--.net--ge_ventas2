Public Class FrmDocumentoVenta_VerDetalleAddItemMant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String
    Public oParent As Object

    Private Sub FrmDocumentoVenta_VerDetalleAddItemMant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtDescripcion
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtUnida_Medida.Focus()
        End If
    End Sub

    Private Sub txtUnida_Medida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnida_Medida.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call Grabar
        oParent.txtCod_Producto.Text = oHP.DevuelveDato("SELECT COD_ITEM FROM LG_ITEM WHERE DES_ITEM='" & txtDescripcion.Text & "' AND Cod_UniMed='" & txtUnida_Medida.Text & "'", cCONNECT)
        oParent.txtDescripcion.Text = oHP.DevuelveDato("SELECT DES_ITEM   FROM LG_ITEM WHERE DES_ITEM='" & txtDescripcion.Text & "' AND Cod_UniMed='" & txtUnida_Medida.Text & "'", cCONNECT)
        oParent.sunidad = oHP.DevuelveDato("SELECT Cod_UniMed  FROM LG_ITEM WHERE DES_ITEM='" & txtDescripcion.Text & "' AND Cod_UniMed='" & txtUnida_Medida.Text & "'", cCONNECT)
        Me.Close()
    End Sub

    Sub Grabar()
        Try
            strSQL = "EXEC LG_ITEM_CREA_ITEM_DIVERSO '" & Trim(txtDescripcion.Text) & "','" & UCase(Trim(txtUnida_Medida.Text)) & "'"
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class