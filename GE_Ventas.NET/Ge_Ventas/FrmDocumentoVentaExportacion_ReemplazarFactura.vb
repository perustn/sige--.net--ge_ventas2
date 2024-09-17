Public Class FrmDocumentoVentaExportacion_ReemplazarFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_ReemplazarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        DtpFecEmi.Value = Now.Date

        Me.ActiveControl = txtSerie
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSerie.Text = RellenaDeCerosEnIzquierda(txtSerie.Text, 3)
            txtNumero.Focus()
        End If
    End Sub

    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNumero.Text = RellenaDeCerosEnIzquierda(txtNumero.Text, 8)
            DtpFecEmi.Focus()
        End If
    End Sub

   Private Sub DtpFecEmi_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DtpFecEmi.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If (txtSerie.Text = "" Or txtNumero.Text = "") Then
                MessageBox.Show("Llenar la Serie y Número", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

            Dim FechaSel As String
            If DtpFecEmi.Checked = True Then
                FechaSel = "'" & DtpFecEmi.Value.ToShortDateString & "'"
            Else
                FechaSel = "NULL"
            End If

            If MessageBox.Show("Confirma Reemplazar Factura?", Me.Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC VENTAS_REEMPLAZAR_FACTURA_VENTA"
                strSQL &= vbNewLine & String.Format(" @NUM_CORRE_ORIGEN         = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@SER_DOCUM_DESTINO        = '{0}'", txtSerie.Text)
                strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS_DESTINO = '{0}'", txtNumero.Text)
                strSQL &= vbNewLine & String.Format(",@FEC_EMIDOC               =  {0} ", FechaSel)
                strSQL &= vbNewLine & String.Format(",@Cod_Usuario              = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se ha Reemplazado la Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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