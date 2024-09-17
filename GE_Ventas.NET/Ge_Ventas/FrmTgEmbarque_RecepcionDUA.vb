Public Class FrmTgEmbarque_RecepcionDUA
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Public sNum_Embarque As String
    Private ColEmpresa As Color

    Private Sub FrmTgEmbarque_RecepcionDUA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa
        Panel4.BackColor = ColEmpresa

        Me.ActiveControl = txtNum_Dua
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            Dim sFecRecepcionDUA As String, sFecNumeracionDua As String
            Dim sFecEmbarqueReal As String, sFecEntregaDrauBack As String

            sFecRecepcionDUA = Trim(dtpFec_RecepcionDUA.Text)
            sFecNumeracionDua = Trim(dtpFec_NumeracionDua.Text)
            sFecEmbarqueReal = Trim(dtpFec_EmbarqueReal.Text)
            sFecEntregaDrauBack = Trim(dtpEntregaDrauBack.Text)

            If sFecRecepcionDUA = "/  /" Then
                sFecRecepcionDUA = "NULL"
            Else
                sFecRecepcionDUA = "'" & sFecRecepcionDUA & "'"
            End If
            If sFecNumeracionDua = "/  /" Then
                sFecNumeracionDua = "NULL"
            Else
                sFecNumeracionDua = "'" & sFecNumeracionDua & "'"
            End If
            If sFecEmbarqueReal = "/  /" Then
                sFecEmbarqueReal = "NULL"
            Else
                sFecEmbarqueReal = "'" & sFecEmbarqueReal & "'"
            End If
            If sFecEntregaDrauBack = "/  /" Then
                sFecEntregaDrauBack = "NULL"
            Else
                sFecEntregaDrauBack = "'" & sFecEntregaDrauBack & "'"
            End If

            strSQL = "EXEC TG_EMBARQUE_DATOS_DUA"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE                                 = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@Fec_RecepcionDua                             =  {0} ", sFecRecepcionDUA)
            strSQL &= vbNewLine & String.Format(",@Num_Dua                                      = '{0}'", txtNum_Dua.Text)
            strSQL &= vbNewLine & String.Format(",@Fec_NumeracionDua	                        =  {0} ", sFecNumeracionDua)
            strSQL &= vbNewLine & String.Format(",@Fec_EmbarqueReal                             =  {0} ", sFecEmbarqueReal)
            strSQL &= vbNewLine & String.Format(",@Fec_Entrega_Contabilidad_Tramites_DrawBack   =  {0} ", sFecEntregaDrauBack)
            strSQL &= vbNewLine & String.Format(",@Imp_FOB_Dol_Dua                              = '{0}'", txtDolares.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Bill_of_Landing                          = '{0}'", txtNum_BL.Text)
            strSQL &= vbNewLine & String.Format(",@Id_NGC                                       = '{0}'", txtNGC.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class