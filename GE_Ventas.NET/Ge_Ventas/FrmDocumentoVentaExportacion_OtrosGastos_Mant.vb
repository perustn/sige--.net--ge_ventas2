Public Class FrmDocumentoVentaExportacion_OtrosGastos_Mant
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sAccion As String
    Public sSecuencia As Integer

    Private Sub FrmDocumentoVentaExportacion_OtrosGastos_Mant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtCod_TipConp
    End Sub

    Private Sub txtCod_TipConp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipConp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion(1)
        End If
    End Sub

    Private Sub txtDes_TipConp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipConp.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion(2)
        End If
    End Sub

    Sub Busca_Opcion(Opcion As Integer)
        Select Case Opcion
            Case 1 : strSQL = "Select Tip_Concepto AS Cod,Des_Tip_Concepto as Descripcion from CN_Ventas_Tipos_Concepto Where Tip_Concepto Like '%" & txtCod_TipConp.Text & "%'"
            Case 2 : strSQL = "Select Tip_Concepto AS Cod,Des_Tip_Concepto as Descripcion from CN_Ventas_Tipos_Concepto Where Des_Tip_Concepto Like '%" & txtDes_TipConp.Text & "%'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_TipConp.Text = Codigo
            txtDes_TipConp.Text = Descripcion
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            txtConcepto.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtImporte.Focus()
        End If
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        Else
            ValidarSoloDecimales(txtImporte.Text, e)
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_MAN_Otros_Cargos_Descuentos"
            strSQL &= vbNewLine & String.Format(" @accion           = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@Secuencia        =  {0} ", sSecuencia)
            strSQL &= vbNewLine & String.Format(",@Tip_Concepto     = '{0}'", txtCod_TipConp.Text)
            strSQL &= vbNewLine & String.Format(",@Des_Concepto     = '{0}'", txtConcepto.Text)
            strSQL &= vbNewLine & String.Format(",@Importe          =  {0} ", CDbl(txtImporte.Text))
            strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())

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