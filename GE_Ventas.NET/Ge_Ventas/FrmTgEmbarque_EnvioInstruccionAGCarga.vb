Public Class FrmTgEmbarque_EnvioInstruccionAGCarga
    Private oHP As New clsHELPER

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private ColEmpresa As Color
    Private strSQL As String = String.Empty

    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_EnvioInstruccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = ColEmpresa
        Panel4.BackColor = ColEmpresa

        'DtpFec_EnvioInstruccionesalAgenteCarga.Value = Now
        'DtpFecEmbPre.Value = Now
        ActiveControl = txtObs_EnvioInstruccionesalAgenteCarga
    End Sub

    Private Sub txtCod_AlmacenAduana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_AlmacenAduana.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAlmacenAduana(1)
        End If
    End Sub

    Private Sub txtNom_AlmacenAduana_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_AlmacenAduana.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAlmacenAduana(2)
        End If
    End Sub

    Private Sub BuscaAlmacenAduana(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "cf_ayuda_cf_almacen_aduana '" & sTipo & "','" & txtCod_AlmacenAduana.Text & "','" & txtNom_AlmacenAduana.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_AlmacenAduana.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtNom_AlmacenAduana.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtNotFinal.Select()
            Exit Sub
        End If

        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_AlmacenAduana.Text = Trim(Codigo)
            txtNom_AlmacenAduana.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtNotFinal.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            strSQL = "EXEC TG_EMBARQUE_ENVIOAGENTE_CARGA"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE                         = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@FEC_ENVIO_DOC                        = '{0}'", DtpFec_EnvioInstruccionesalAgenteCarga.Value.ToShortDateString())
            strSQL &= vbNewLine & String.Format(",@OBS_ENVIO_DOC                        = '{0}'", txtObs_EnvioInstruccionesalAgenteCarga.Text)
            strSQL &= vbNewLine & String.Format(",@NOTIFY		                        = '{0}'", txtNotify.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ALMACENADUANA                    = '{0}'", txtCod_AlmacenAduana.Text)
            strSQL &= vbNewLine & String.Format(",@PIE_PAGINA                           = '{0}'", txtNotFinal.Text)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO                          = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@CONSIGNATARIO                        = '{0}'", txtConsignatario.Text)
            strSQL &= vbNewLine & String.Format(",@Fec_Embarque_Prevista                = '{0}'", DtpFecEmbPre.Value.ToShortDateString())
            strSQL &= vbNewLine & String.Format(",@Informacion_Adicional_Guia_Aerea     = '{0}'", txtInfAdiGuiAre.Text)

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