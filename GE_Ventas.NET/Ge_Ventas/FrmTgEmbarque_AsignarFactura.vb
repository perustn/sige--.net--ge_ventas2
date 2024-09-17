Public Class FrmTgEmbarque_AsignarFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER

    Public sNum_Embarque As String
    Public sFecFac As String
    Public sFacAsig As String
    Public sSerie As String
    Public sNumero As String
    Private colEmpresa As Color

    Private Sub FrmTgEmbarque_AsignarFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel3.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        ActiveControl = txtSerie
    End Sub
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles btnGenerarFactura.Click
        Try
            If txtSerie.Text.Trim = "" Then
                MessageBox.Show("Debe ingresar un numero de serie", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtSerie.Select()
                Exit Sub
            End If

            'strSQL = "begin transaction"
            'strSQL &= "EXEC CN_INCREMENTA_VENTAS_SERIES"
            'strSQL &= vbNewLine & String.Format(" @COD_TIPDOC   = '{0}'", "FA")
            'strSQL &= vbNewLine & String.Format(",@SER_DOCUM    = '{0}'", txtSerie.Text.Trim)
            'strSQL &= "ROLLBACK"

            strSQL = "EXEC CN_INCREMENTA_VENTAS_SERIES"
            strSQL &= vbNewLine & String.Format(" @COD_TIPDOC   = '{0}'", "FA")
            strSQL &= vbNewLine & String.Format(",@SER_DOCUM    = '{0}'", txtSerie.Text.Trim)

            Dim Dt As DataTable = oHP.DevuelveDatos(strSQL, cCONNECT)

            If Dt.Rows.Count > 0 Then
                txtNumero.Text = Dt.Rows(0)("Num_Docum_Ventas")
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtSerie_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerie.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtSerie.Text.Trim = "" Then
                txtSerie.Select()
            Else
                txtNumero.Select()
            End If
        End If
    End Sub
    Private Sub txtNumero_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNumero.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If txtNumero.Text.Trim = "" Then
                txtNumero.Select()
            Else
                txtNumero.Text = RellenaDeCerosEnIzquierda(txtNumero.Text, 8)
            End If
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub btnAceptar_Click_1(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Call Procesar
    End Sub

    Sub Procesar()
        Try
            If MessageBox.Show("Esta seguro de realizar esta accion?", "AVISO", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then Exit Sub

            strSQL = "EXEC TG_EMBARQUE_MAN_ASOCIAR_FACTURA"
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE         = '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@SER_DOCUM_VENTAS     = '{0}'", Trim(txtSerie.Text))
            strSQL &= vbNewLine & String.Format(",@NUM_DOCUM_VENTAS     = '{0}'", Trim(txtNumero.Text))
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO		    = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@FEC_EMI              = '{0}'", dtpFec_Emision.Value.ToShortDateString())

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                DialogResult = Windows.Forms.DialogResult.OK
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class