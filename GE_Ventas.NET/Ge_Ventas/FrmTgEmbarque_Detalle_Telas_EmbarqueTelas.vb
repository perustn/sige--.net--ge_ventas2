Public Class FrmTgEmbarque_Detalle_Telas_EmbarqueTelas
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private colEmpresa As Color
    Public sAccion, sNum_Embarque, sSec_Embarque As String

    Private Sub FrmTgEmbarque_Detalle_Telas_EmbarqueTelas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        If sAccion = "I" Then
            txtCodUniMedida.Text = "KG"
            txtDesUniMedida.Text = oHP.DevuelveDato("select RTRIM(Des_UniMed) from tg_uniMed where Cod_UniMed = '" & txtCodUniMedida.Text & "'", cCONNECT)
        End If
       
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub txtCodTela_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodTela.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTela(1)
        End If
    End Sub

    Private Sub txtDesTela_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesTela.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaTela(2)
        End If
    End Sub

    Private Sub BuscaTela(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_TX_TELA '" & sTipo & "','" & txtCodTela.Text & "','" & txtDesTela.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodTela.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDesTela.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCodComb.Select()
            Exit Sub
        End If
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCodTela.Text = Trim(Codigo)
            txtDesTela.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCodComb.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCodComb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodComb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCombinacion(1)
        End If
    End Sub

    Private Sub txtDesComb_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesComb.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaCombinacion(2)
        End If
    End Sub

    Private Sub BuscaCombinacion(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_TX_TELACOMB '" & sTipo & "','" & txtCodTela.Text & "','" & txtCodComb.Text & "','" & txtDesComb.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodComb.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDesComb.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCodColor.Focus()
            Exit Sub
        End If
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCodComb.Text = Trim(Codigo)
            txtDesComb.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCodColor.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCodColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodColor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaColor(1)
        End If
    End Sub

    Private Sub txtDesColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesColor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaColor(2)
        End If
    End Sub

    Private Sub BuscaColor(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_lb_color '" & sTipo & "','" & txtCodColor.Text & "','" & txtDesColor.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodColor.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDesColor.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtCodUniMedida.Focus()
            Exit Sub
        End If
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCodColor.Text = Trim(Codigo)
            txtDesColor.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtCodUniMedida.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtCodUniMedida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCodUniMedida.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaUnidadMedida(1)
        End If
    End Sub

    Private Sub txtDesUniMedida_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDesUniMedida.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaUnidadMedida(2)
        End If
    End Sub

    Private Sub BuscaUnidadMedida(sTipo As Integer)

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "CF_AYUDA_tg_uniMed '" & sTipo & "','" & txtCodUniMedida.Text & "','" & txtDesUniMedida.Text & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCodUniMedida.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDesUniMedida.Text = oTipo.dtResultados.Rows(0)("descripcion")
            txtPeso_Bruto_Prog.Focus()
            Exit Sub
        End If

        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCodUniMedida.Text = Trim(Codigo)
            txtDesUniMedida.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            txtPeso_Bruto_Prog.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtPeso_Bruto_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Bruto_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtPeso_Neto_Prog.Select()
        End If
    End Sub

    Private Sub txtPeso_Neto_Prog_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPeso_Neto_Prog.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtRollosProg.Focus()
        End If
    End Sub

    Private Sub txtRollosProg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRollosProg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtUbicajeProg.Focus()
        End If
    End Sub

    Private Sub txtUbicajeProg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUbicajeProg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtKgsProg.Focus()
        End If
    End Sub

    Private Sub txtKgsProg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKgsProg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtUnidadesProg.Focus()
        End If
    End Sub

    Private Sub txtUnidadesProg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUnidadesProg.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            BtnAceptar.Focus()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarDatos()
    End Sub

    Sub ProcesarDatos()
        Try
            strSQL = "EXEC TG_Embarque_Telas_man"

            strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@num_embarque     = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@Sec_Embarque     = '{0}'", sSec_Embarque)
            strSQL &= vbNewLine & String.Format(",@Cod_Tela		    = '{0}'", Trim(txtCodTela.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Comb         = '{0}'", Trim(txtCodComb.Text))
            strSQL &= vbNewLine & String.Format(",@Cod_Color        = '{0}'", Trim(txtCodColor.Text))
            strSQL &= vbNewLine & String.Format(",@Uni_Med          = '{0}'", txtCodUniMedida.Text)
            strSQL &= vbNewLine & String.Format(",@Peso_Bruto_Prog	= '{0}'", Trim(txtPeso_Bruto_Prog.Text))
            strSQL &= vbNewLine & String.Format(",@Peso_Neto_Prog   = '{0}'", Trim(txtPeso_Neto_Prog.Text))
            strSQL &= vbNewLine & String.Format(",@Rollos_Prog      = '{0}'", Trim(txtRollosProg.Text))
            strSQL &= vbNewLine & String.Format(",@Cubicaje_Prog    = '{0}'", Trim(txtUbicajeProg.Text))
            strSQL &= vbNewLine & String.Format(",@Kgs_Prog		    = '{0}'", txtKgsProg.Text)
            strSQL &= vbNewLine & String.Format(",@Unidades_Prog    = '{0}'", txtUnidadesProg.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class