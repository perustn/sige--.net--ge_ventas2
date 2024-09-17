Public Class FrmDocumentoVenta_ImporteFobDUA
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_ImporteFobDUA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = TxtDua
    End Sub

    Private Sub TxtDua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDua.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtFec_Numeracion.Focus()
        End If
    End Sub

    Private Sub TxtFec_Numeracion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec_Numeracion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFec_Embarque.Focus()
        End If
    End Sub

    Private Sub TxtFec_Embarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFec_Embarque.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            TxtImp_FOB_Dol_Dua.Focus()
        End If
    End Sub

    Private Sub TxtImp_FOB_Dol_Dua_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtImp_FOB_Dol_Dua.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Up_Man_Datos_Dua"
            strSQL &= vbNewLine & String.Format(" @Num_Corre        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Dua          = '{0}'", TxtDua.Text)
            strSQL &= vbNewLine & String.Format(",@Fec_NumeracionDua= '{0}'", txtFec_Numeracion.Text)
            strSQL &= vbNewLine & String.Format(",@Fec_EmbarqueReal = '{0}'", txtFec_Embarque.Text)
            strSQL &= vbNewLine & String.Format(",@imp_FOB_Dol_Dua  = '{0}'", TxtImp_FOB_Dol_Dua.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Los datos fueron procesados con éxito.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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