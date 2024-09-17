Public Class FrmDocumentoVentaExportacion_VerDetalle_Add
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public strNum_Corre_Detalle As String, StrOption As String, IntSencuencia As Integer, strNum_Corre_Doc_Asig As String, _
        IntSencuencia_Doc_Asig As Integer

    Private Sub FrmDocumentoVentaExportacion_VerDetalle_Add_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtDescripcion
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDescripcion_CliExt.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_CliExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion_CliExt.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_Total.Text = Strings.Format(txtCantidad.Text * txtImp_Unitario.Text, "####.00")
            txtImp_Unitario.Focus()
        End If
    End Sub

    Private Sub txtImp_Unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Unitario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_Total.Text = Strings.Format(txtCantidad.Text * txtImp_Unitario.Text, "####.00")
            txtImp_Total.Focus()
        End If
    End Sub

    Private Sub txtImp_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Total.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("¿Seguro de grabar detalle?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Ventas_Up_Man_Detalle_Nuevo"
                strSQL &= vbNewLine & String.Format(" @StrOption                = '{0}'", StrOption)
                strSQL &= vbNewLine & String.Format(",@Num_Corre                = '{0}'", strNum_Corre_Detalle)
                strSQL &= vbNewLine & String.Format(",@Secuencia                =  {0} ", IntSencuencia)
                strSQL &= vbNewLine & String.Format(",@Tipo_Item                = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Codigo_Item              = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Descripcion              = '{0}'", Des_Apos(txtDescripcion.Text))
                strSQL &= vbNewLine & String.Format(",@Unidad_Medida            = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Cantidad                 = '{0}'", txtCantidad.Text)
                strSQL &= vbNewLine & String.Format(",@Imp_Unitario             = '{0}'", txtImp_Unitario.Text)
                strSQL &= vbNewLine & String.Format(",@Imp_Total                = '{0}'", txtImp_Total.Text)
                strSQL &= vbNewLine & String.Format(",@Porcentaje_Commision     = '{0}'", 0)
                strSQL &= vbNewLine & String.Format(",@Num_Corre_Original_NCNC  = '{0}'", strNum_Corre_Doc_Asig)
                strSQL &= vbNewLine & String.Format(",@Num_Secuencia_OriginalNCND   = {0} ", IntSencuencia_Doc_Asig)
                strSQL &= vbNewLine & String.Format(",@Cantidad_Item_NC_ND      = '{0}'", 0)
                strSQL &= vbNewLine & String.Format(",@descripcion_agrupador    = '{0}'", Trim(txtDescripcion_CliExt.Text))
                strSQL &= vbNewLine & String.Format(",@Descripcion_cliente_exterior = '{0}'", Trim(txtDescripcion_CliExt.Text))

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Proceso culminado satisfactoriamente", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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