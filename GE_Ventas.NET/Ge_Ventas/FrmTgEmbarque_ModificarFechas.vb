Public Class FrmTgEmbarque_ModificarFechas
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private ColEmpresa As Color
    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_ModificarFechas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa
        Panel4.BackColor = ColEmpresa

        Me.ActiveControl = dtpFec_RecepcionDUA1

    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            Dim sFecRecepcionDUA1 As String, sFecEntregaDrauBack1 As String
            sFecRecepcionDUA1 = Trim(dtpFec_RecepcionDUA1.Text)
            sFecEntregaDrauBack1 = Trim(dtpEntregaDrauBack1.Text)

            If sFecRecepcionDUA1 = "/  /" Then
                sFecRecepcionDUA1 = "NULL"
            Else
                sFecRecepcionDUA1 = "'" & sFecRecepcionDUA1 & "'"
            End If
            If sFecEntregaDrauBack1 = "/  /" Then
                sFecEntregaDrauBack1 = "NULL"
            Else
                sFecEntregaDrauBack1 = "'" & sFecEntregaDrauBack1 & "'"
            End If

            strSQL = "EXEC TG_EMBARQUE_DATOS_DUA_FECHAS"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE                                 = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@Fec_RecepcionDua                             =  {0} ", sFecRecepcionDUA1)
            strSQL &= vbNewLine & String.Format(",@Fec_Entrega_Contabilidad_Tramites_DrawBack   =  {0} ", sFecEntregaDrauBack1)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class