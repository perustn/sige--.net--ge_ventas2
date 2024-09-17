Public Class FrmTgEmbarque_DatosdeZarpe
    Private oHP As New clsHELPER
    Private strSQL As String = String.Empty
    Public sNum_Embarque As String
    Private colEmpresa As Color

    Private Sub FrmTgEmbarque_DatosdeZarpe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        ActiveControl = dtpEmbarqueReal
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            Dim sFecEmbarqueReal As String, sFecLlegadaEmbarque As String
            sFecEmbarqueReal = Trim(dtpEmbarqueReal.Text)
            sFecLlegadaEmbarque = Trim(dtpLlegadaEmbarque.Text)

            If sFecEmbarqueReal = "/  /" Then
                sFecEmbarqueReal = "NULL"
            Else
                sFecEmbarqueReal = "'" & sFecEmbarqueReal & "'"
            End If
            If sFecLlegadaEmbarque = "/  /" Then
                sFecLlegadaEmbarque = "NULL"
            Else
                sFecLlegadaEmbarque = "'" & sFecLlegadaEmbarque & "'"
            End If

            strSQL = "EXEC CN_EMBARQUE_DATOS_ZARTE"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE             = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@FEC_EMBARQUE_REAL        =  {0} ", sFecEmbarqueReal)
            strSQL &= vbNewLine & String.Format(",@FEC_LLEGADA_EMBARQUE     =  {0} ", sFecLlegadaEmbarque)
            strSQL &= vbNewLine & String.Format(",@NUM_GUIA_AEREA           = '{0}'", txtNumGuiaArea.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Se actualizó los datos correctamente.", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtNumGuiaArea_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumGuiaArea.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Select()
        End If
    End Sub
End Class