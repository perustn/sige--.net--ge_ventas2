Public Class FrmDocumentoVenta_Redondear
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Dim flag As Boolean
    Private maxRedondeo As Double
    Public porcIGV As Double
    Public ValorActualIGV As String
    Public ValorActualImporteTotal As String
    Public ValorActualImporteNeto As String
    Public ValorActualImporteTotalR As String
    Public Cod_TipDocSel As String
    Public SerieSel As String
    Public Nro_docSel As String

    Private Sub FrmDocumentoVenta_Redondear_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        flag = False
        txtValorRedondeo.Enabled = False
        strSQL = "select max_redondeo from cn_control"
        maxRedondeo = oHP.DevuelveDato(strSQL, cCONNECT)

        Me.ActiveControl = txtImporteTotal
    End Sub

    Private Sub chkRedondeo_Click(sender As Object, e As EventArgs) Handles chkRedondeo.Click
        If Not flag Then
            txtValorRedondeo.Enabled = True
            cmdSuma.Enabled = True
            cmdResta.Enabled = True
            flag = True
        Else
            txtValorRedondeo.Enabled = False
            cmdSuma.Enabled = False
            cmdResta.Enabled = False
            flag = False
        End If
    End Sub

    Private Sub cmdSuma_Click(sender As Object, e As EventArgs) Handles cmdSuma.Click
        If maxRedondeo > CDbl(txtValorRedondeo.Text) And (CDbl(txtValorRedondeo.Text)) > 0 Then
            'txtImporteNeto = CDbl(ValorActualImporteNeto) + CDbl(txtValorRedondeo.Text)
            txtImporteNeto.Text = CDbl(txtImporteNeto.Text) + CDbl(txtValorRedondeo.Text)
            txtImporteIgv.Text = IIf(ValorActualIGV = 0, 0, Math.Round(CDbl(txtImporteNeto.Text) * 0.19, 2))
            txtImporteTotal.Text = CDbl(txtImporteNeto.Text) + CDbl(IIf(txtImporteIgv.Text = "", 0, txtImporteIgv.Text)) + CDbl(IIf(txtImporteGastosFinan.Text = "", 0, txtImporteGastosFinan.Text)) - CDbl(IIf(txtImporteDscto.Text = "", 0, txtImporteDscto.Text))
        Else
            MessageBox.Show("El valor de Redondeo debe ser menor a : " & maxRedondeo, "Redondear Importe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmdResta_Click(sender As Object, e As EventArgs) Handles cmdResta.Click
        If maxRedondeo > CDbl(txtValorRedondeo.Text) And (CDbl(txtValorRedondeo.Text)) > 0 Then
            'txtImporteNeto = CDbl(ValorActualImporteNeto) - CDbl(txtValorRedondeo.Text)
            txtImporteNeto.Text = CDbl(txtImporteNeto.Text) - CDbl(txtValorRedondeo.Text)
            txtImporteIgv.Text = IIf(ValorActualIGV = 0, 0, Math.Round(CDbl(txtImporteNeto.Text) * 0.19, 2))
            txtImporteTotal.Text = CDbl(txtImporteNeto.Text) + CDbl(IIf(txtImporteIgv.Text = "", 0, txtImporteIgv.Text)) + CDbl(IIf(txtImporteGastosFinan.Text = "", 0, txtImporteGastosFinan.Text)) - CDbl(IIf(txtImporteDscto.Text = "", 0, txtImporteDscto.Text))
            'ValorActualImporteNeto = txtImporteNeto
        Else
            MessageBox.Show("El valor de Redondeo debe ser menor a : " & maxRedondeo, "Redondear Importe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub cmdRecalcular_Click(sender As Object, e As EventArgs) Handles cmdRecalcular.Click
        Try
            Dim Valor As Double

            txtValorRedondeo.Enabled = False
            cmdSuma.Enabled = False
            cmdResta.Enabled = False
            chkRedondeo.Checked = False
            If chkRedondeo.Checked = True Then chkRedondeo_Click(1, e)

            Valor = Math.Round(CDbl(txtImporteTotal.Text) - CDbl(ValorActualImporteTotal), 2)
            If Valor < 0 Then Valor = Valor * -1
            If maxRedondeo > Valor Then
                If txtImporteDscto.Text <> "0" Then
                    If txtImporteIgv.Text <> "0" Then
                        Valor = CDbl(txtImporteTotal.Text) + CDbl(txtImporteDscto.Text)
                        'txtImporteNeto = Round(valor / 1.19, 2)
                        txtImporteNeto.Text = Math.Round(Valor / (1 + porcIGV / 100), 2)
                    Else
                        txtImporteNeto.Text = Math.Round(CDbl(txtImporteTotal.Text) + CDbl(txtImporteDscto.Text), 2)
                        Exit Sub
                    End If
                Else
                    If txtImporteOtros.Text <> "0" Then
                        txtImporteNeto.Text = Math.Round(CDbl(txtImporteTotal.Text) - CDbl(txtImporteOtros.Text), 2)
                        Exit Sub
                    End If
                    If txtImporteGastosFinan.Text <> "0" Then
                        txtImporteNeto.Text = Math.Round((CDbl(txtImporteTotal.Text) - CDbl(txtImporteGastosFinan.Text)) / (1 + porcIGV / 100), 2)
                        txtImporteIgv.Text = CDbl(txtImporteTotal.Text) - CDbl(txtImporteNeto.Text) - CDbl(txtImporteGastosFinan.Text)
                        Exit Sub
                    End If

                    txtImporteNeto.Text = Math.Round(CDbl(txtImporteTotal.Text) / (1 + porcIGV / 100), 2)
                    txtImporteIgv.Text = CDbl(txtImporteTotal.Text) - CDbl(txtImporteNeto.Text)
                End If

            Else
                MessageBox.Show("El valor de Redondeo debe ser menor a : " & maxRedondeo, "Redondear Importe", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If MessageBox.Show("Desea Redondear el Documento " & Cod_TipDocSel & "-" & Nro_docSel, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            GuardarRedondeo()
        End If
    End Sub

    Private Sub GuardarRedondeo()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC UP_MAN_VENTAS_REDONDEO"
            strSQL &= vbNewLine & String.Format(" @Cod_TipDoc       = '{0}'", Cod_TipDocSel)
            strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", SerieSel)
            strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", Nro_docSel)
            strSQL &= vbNewLine & String.Format(",@Imp_Total        =  {0} ", CDbl(txtImporteTotal.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_Neto         =  {0} ", CDbl(txtImporteNeto.Text))
            strSQL &= vbNewLine & String.Format(",@Imp_IGV          =  {0} ", CDbl(txtImporteIgv.Text))
            strSQL &= vbNewLine & String.Format(",@redondeo         =  {0} ", CDbl(txtImpTotalActual.Text - txtImporteTotal.Text))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnDesHacer_Click(sender As Object, e As EventArgs) Handles BtnDesHacer.Click
        txtImporteNeto.Text = ValorActualImporteNeto
        txtImporteIgv.Text = ValorActualIGV
        txtImporteTotal.Text = ValorActualImporteTotal
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class