Public Class FrmDocumentoVenta_DespachoExtemporaneo
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public Valor As String
    Public Cod_TipDoc As String
    Public Serie As String
    Public Nro_doc As String

    Private Sub FrmDocumentoVenta_DespachoExtemporaneo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        If Valor = "N" Then
            chkDespachado.Checked = False
        Else
            chkDespachado.Checked = True
        End If

        Me.ActiveControl = chkDespachado
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Dim cadena As String
            If chkDespachado.Checked = True Then
                cadena = "S"
            Else
                cadena = "N"
            End If

            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_ActualizarFlgDespaExten"
            strSQL &= vbNewLine & String.Format(" @Cod_TipDoc       = '{0}'", Cod_TipDoc)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", Serie)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", Nro_doc)
            strSQL &= vbNewLine & String.Format(",@Valor            = '{0}'", cadena)

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