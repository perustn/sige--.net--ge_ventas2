Public Class FrmDocumentoVentaExportacion_ActualizarPrecio
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sIMP_Opc As String

    Private Sub FrmDocumentoVentaExportacion_ActualizarPrecio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        strSQL = "VENTAS_MUESTRA_PROBABLE_PRECIO_DDP '" & TxtNroCorrelativo.Text & "'"
        Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
        Dim oDr As DataRow
        If Not oDtResult Is Nothing Then
            If oDtResult.Rows.Count = 0 Then Exit Sub
            oDr = oDtResult.Rows(0)
            txtImpFleAer.Text = oDr("IMP_FLETE_AEERO")
            txtImpFleMar.Text = oDr("IMP_FLETE_MARITIMO")
            txtImpFleDif.Text = oDr("Dif_Flete_Aereo_Menos_Maritimo")
            txtImpFleDDP.Text = oDr("IMP_DDP")
            txtImpOtrPen.Text = oDr("IMP_OTROS_PENALIDADES")
        End If

        Me.ActiveControl = txtImpFleAer
    End Sub

    Private Sub txtImpFleAer_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpFleAer.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImpOtrPen.Focus()
        End If
    End Sub

    Private Sub txtImpOtrPen_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImpOtrPen.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("Desea Actualizar Precio DDP?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                If sIMP_Opc = "D" Then
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC VENTAS_ACTUALIZA_IMP_DDP_FCR"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE            = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO          = '{0}'", vusu)
                    strSQL &= vbNewLine & String.Format(",@COD_ESTACION         = '{0}'", ComputerName())
                    strSQL &= vbNewLine & String.Format(",@IMP_FLETE_AEREO      =  {0} ", CDbl(txtImpFleAer.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_OTRAS_PENALIDADES=  {0} ", CDbl(txtImpOtrPen.Text))
                Else
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC VENTAS_ACTUALIZA_IMP_DDP_FLETEYGASTOS_FOB"
                    strSQL &= vbNewLine & String.Format(" @NUM_CORRE            = '{0}'", TxtNroCorrelativo.Text)
                    strSQL &= vbNewLine & String.Format(",@IMP_FLETE_AEREO      =  {0} ", CDbl(txtImpFleAer.Text))
                    strSQL &= vbNewLine & String.Format(",@IMP_OTRAS_PENALIDADES=  {0} ", CDbl(txtImpOtrPen.Text))
                    strSQL &= vbNewLine & String.Format(",@COD_USUARIO          = '{0}'", vusu)
                    strSQL &= vbNewLine & String.Format(",@COD_ESTACION         = '{0}'", ComputerName())
                End If

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se Actualizo con éxito...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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