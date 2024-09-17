Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_AdicionarCuota
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_AdicionarCuota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtMonto
    End Sub

    Private Sub txtMonto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMonto.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            btnCalcDetra.Focus()
        Else
            ValidarSoloDecimales(txtMonto.Text, e)
        End If
    End Sub

    Private Sub btnCalcDetra_Click(sender As Object, e As EventArgs) Handles btnCalcDetra.Click
        Try
            If (txtDetra.Text <> "") Then
                strSQL = "USPSET_VENTAS_CUOTAS '8','" & TxtNroCorrelativo.Text & "','',0,0,'" & txtDetra.Text & "'"
                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    Buscar()
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Function Limpiar() As Boolean
        dtPicker.Value = Now.Date
        txtMonto.Text = ""
        txtNroMonto.Text = ""
        txtDetra.Text = ""
        txtMontoDetra.Text = ""
        lblDetra.Visible = False
        lblMontoDetra.Visible = False
        txtDetra.Visible = False
        txtMontoDetra.Visible = False
        btnCalcDetra.Visible = False
    End Function

    Public Function Buscar() As Boolean
        Limpiar()
        Detracciones
        strSQL = ""
        strSQL = "USPSET_VENTAS_CUOTAS '1','" & TxtNroCorrelativo.Text & "'"

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdLista.DataSource = oDT
        CheckLayoutGridEx(GrdLista)

        With GrdLista
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 25
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next
            End With
        End With
    End Function

    Private Function Detracciones() As Boolean
        Try
            Dim Flg As String
            strSQL = ""
            strSQL = "USPSET_VENTAS_CUOTAS '6','" & TxtNroCorrelativo.Text & "'"
            Flg = oHP.DevuelveDato(strSQL, cCONNECT)

            If (Flg = "N") Then
                Exit Function
            End If

            strSQL = String.Empty
            strSQL = "USPSET_VENTAS_CUOTAS '7','" & TxtNroCorrelativo.Text & "'"
            Dim oDtResult As DataTable = oHP.EjecutaOperacionRetornaDatos2(strSQL, cCONNECT)
            txtDetra.Visible = True
            txtMontoDetra.Visible = True
            lblDetra.Visible = True
            lblMontoDetra.Visible = True
            btnCalcDetra.Visible = True
            Dim oDr As DataRow
            If Not oDtResult Is Nothing Then
                If oDtResult.Rows.Count = 0 Then Exit Function
                oDr = oDtResult.Rows(0)
                txtDetra.Text = oDr("PORCENTAJE")
                txtMontoDetra.Text = oDr("MONTO_DETRA")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "GRABAR"
                    Grabar
                    Limpiar()

                Case "ACTUALIZAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    txtNroMonto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("NRO_CUOTA").Index)
                    txtMonto.Text = GrdLista.GetValue(GrdLista.RootTable.Columns("MONTO").Index)
                    dtPicker.Value = GrdLista.GetValue(GrdLista.RootTable.Columns("FCH_VENCUOTA").Index)

                Case "ELIMINAR"
                    If GrdLista.RowCount = 0 Then Exit Sub
                    Eliminar()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Public Function Eliminar() As Boolean
        Try
            strSQL = "USPSET_VENTAS_CUOTAS '3','" & TxtNroCorrelativo.Text &
                            "','',0," & GrdLista.GetValue(GrdLista.RootTable.Columns("NRO_CUOTA").Index)
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Public Function Grabar() As Boolean
        Try
            If (txtNroMonto.Text = "") Then
                strSQL = "USPSET_VENTAS_CUOTAS '2','" & TxtNroCorrelativo.Text & "','" & dtPicker.Value.ToShortDateString & "'," & txtMonto.Text
            Else
                strSQL = "USPSET_VENTAS_CUOTAS '4','" & TxtNroCorrelativo.Text & "','" & dtPicker.Value.ToShortDateString & "'," & txtMonto.Text & "," & GrdLista.GetValue(GrdLista.RootTable.Columns("NRO_CUOTA").Index)
            End If
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                Buscar()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

End Class