Public Class FrmDocumentoVenta_VerDetalleAdd
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String

    Public IntSencuencia As Integer
    Public StrOption As String
    Public strNum_Corre_Detalle As String, strNum_Corre_Doc_Asig As String,
        IntSencuencia_Doc_Asig As Integer

    Private Sub FrmDocumentoVenta_VerDetalleAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtTip_Item
    End Sub

    Private Sub txtTip_Item_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTip_Item.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If Trim(txtTip_Item.Text) = "P" Then
                cmdBuscar.Visible = True
            Else
                cmdBuscar.Visible = False
            End If
        End If
    End Sub

    Private Sub txtCod_Producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Producto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDescripcion.Focus()
        End If
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        Using oAdd As New FrmDocumentoVenta_VerDetalleAddItem
            With oAdd
                .oParent = Me
                .ShowDialog()
            End With
        End Using
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDescripcion_Agrup.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_Agrup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion_Agrup.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtDescripcion_CliExt.Focus()
        End If
    End Sub

    Private Sub txtDescripcion_CliExt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion_CliExt.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtUnida_Medida.Focus()
        End If
    End Sub

    Private Sub txtUnida_Medida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnida_Medida.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCantidad.Focus()
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_Unitario.Focus()
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        'txtImp_Total.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtImp_Unitario.Text), "####.00")
    End Sub

    Private Sub txtImp_Unitario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Unitario.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImp_Total.Focus()
        End If
    End Sub

    Private Sub txtImp_Unitario_TextChanged(sender As Object, e As EventArgs) Handles txtImp_Unitario.TextChanged
        'txtImp_Total.Text = Format(CDbl(txtCantidad.Text) * CDbl(txtImp_Unitario.Text), "####.00")
    End Sub

    Private Sub txtImp_Total_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImp_Total.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCantUniAlter.Focus()
        End If
    End Sub

    Private Sub txtCantUniAlter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantUniAlter.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtPorc_Commision.Focus()
        End If
    End Sub

    Private Sub txtPorc_Commision_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPorc_Commision.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If MessageBox.Show("Desea Grabar este Producto " & txtCod_Producto.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Ventas_Up_Man_Detalle"
                strSQL &= vbNewLine & String.Format(" @StrOption                = '{0}'", StrOption)
                strSQL &= vbNewLine & String.Format(",@Num_Corre                = '{0}'", strNum_Corre_Detalle)
                strSQL &= vbNewLine & String.Format(",@Secuencia                =  {0} ", Val(IntSencuencia))
                strSQL &= vbNewLine & String.Format(",@Tipo_Item                = '{0}'", txtTip_Item.Text)
                strSQL &= vbNewLine & String.Format(",@Codigo_Item              = '{0}'", txtCod_Producto.Text)
                strSQL &= vbNewLine & String.Format(",@Descripcion              = '{0}'", Des_Apos(txtDescripcion.Text))
                strSQL &= vbNewLine & String.Format(",@Unidad_Medida            = '{0}'", txtUnida_Medida.Text)
                strSQL &= vbNewLine & String.Format(",@Cantidad                 =  {0} ", CDbl(txtCantidad.Text))
                strSQL &= vbNewLine & String.Format(",@Imp_Unitario             =  {0} ", CDbl(txtImp_Unitario.Text))
                strSQL &= vbNewLine & String.Format(",@Imp_Total                =  {0} ", CDbl(txtImp_Total.Text))
                strSQL &= vbNewLine & String.Format(",@Porcentaje_Commision     =  {0} ", CDbl(txtPorc_Commision.Text))
                strSQL &= vbNewLine & String.Format(",@Num_Corre_Original_NCNC  = '{0}'", strNum_Corre_Doc_Asig)
                strSQL &= vbNewLine & String.Format(",@Num_Secuencia_OriginalNCND=  {0} ", IntSencuencia_Doc_Asig)
                strSQL &= vbNewLine & String.Format(",@Cantidad_Item_NC_ND      =  {0} ", CDbl(txtCantUniAlter.Text))
                strSQL &= vbNewLine & String.Format(",@descripcion_agrupador    = '{0}'", Trim(txtDescripcion_Agrup.Text))
                strSQL &= vbNewLine & String.Format(",@Descripcion_cliente_exterior= '{0}'", txtDescripcion_CliExt.Text)

                Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
                Dim oDr As DataRow
                If Not oDtResult Is Nothing Then
                    If oDtResult.Rows.Count = 0 Then Exit Sub
                    oDr = oDtResult.Rows(0)
                    IntSencuencia = oDr("Secuencia")
                    DialogResult = DialogResult.OK
                End If

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        IntSencuencia = 0
        DialogResult = DialogResult.Cancel
    End Sub
End Class