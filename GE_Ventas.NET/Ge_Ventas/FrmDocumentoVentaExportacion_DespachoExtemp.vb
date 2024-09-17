Public Class FrmDocumentoVentaExportacion_DespachoExtemp
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public Valor As String
    Public oParent As Object
    Public Cod_TipDoc As String

    Private Sub FrmDocumentoVentaExportacion_DespachoExtemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = ChkDespacho
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_ActualizarFlgDespaExten"
            strSQL &= vbNewLine & String.Format(" @Cod_TipDoc       = '{0}'", Cod_TipDoc)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", TxtSerie.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", TxtDocumento.Text)
            strSQL &= vbNewLine & String.Format(",@Valor            = '{0}'", IIf(ChkDespacho.Checked = True, "S", "N"))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Proceso realizado correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
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