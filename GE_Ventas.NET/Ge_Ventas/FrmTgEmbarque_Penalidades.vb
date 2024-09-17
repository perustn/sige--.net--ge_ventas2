Public Class FrmTgEmbarque_Penalidades
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Public sNum_Embarque As String
    Private ColEmpresa As Color

    Private Sub FrmTgEmbarque_Penalidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa
        Panel4.BackColor = ColEmpresa

        ActiveControl = txtImp_Flete_Aereo
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            If MessageBox.Show("Esta seguro de realizar esta accion?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            strSQL = "EXEC TG_EMBARQUE_DATOS_PENALIDAD"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE     = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@Flg_Penalidad    = '{0}'", IIf(chkIncPenalidad.Checked, "S", "N"))
            strSQL &= vbNewLine & String.Format(",@Imp_Flete_Aereo  = '{0}'", txtImp_Flete_Aereo.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class