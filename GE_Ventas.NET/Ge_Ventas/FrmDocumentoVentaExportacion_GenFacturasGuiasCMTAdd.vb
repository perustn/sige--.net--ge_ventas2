Public Class FrmDocumentoVentaExportacion_GenFacturasGuiasCMTAdd
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Public scliente As String, sPO As String, sEstiloCliente As String

    Private Sub FrmDocumentoVentaExportacion_GenFacturasGuiasCMTAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtGuia
    End Sub

    Private Sub txtGuia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGuia.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFactura.Focus()
        End If
    End Sub

    Private Sub txtFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactura.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Distribuye_por_Partida_Muestra_Partidas_Estilo_PO"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", scliente)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD   = '{0}'", sPO)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI   = '{0}'", sEstiloCliente)
            strSQL &= vbNewLine & String.Format(",@num_guia     = '{0}'", txtGuia.Text)
            strSQL &= vbNewLine & String.Format(",@factura      = '{0}'", txtFactura.Text)
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
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