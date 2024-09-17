Public Class FrmTgEmbarque_Detalle_Packing
    Private oHP As New clsHELPER
    Private strSQL As String = String.Empty
    Public sNum_Embarque As String
    Private colEmpresa As Color

    Private Sub FrmTgEmbarque_Detalle_Packing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        ActiveControl = txtNum_Packing
    End Sub

    Private Sub txtNum_Packing_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Packing.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Select()
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            strSQL = "EXEC TG_Genera_Embarques_Prendas_por_Packing"

            strSQL &= vbNewLine & String.Format(" @num_embarque   = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@num_packing    = '{0}'", Trim(txtNum_Packing.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class