Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_AgruparFacturas
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Const K_strColCheck As String = "SEL"

    Private Sub FrmDocumentoVentaExportacion_AgruparFacturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        dtpFecha.Value = Now.Date

        Me.ActiveControl = txtCod_Organizacion
    End Sub

    Private Sub txtCod_Organizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Organizacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaOrganizacion(1)
        End If
    End Sub

    Private Sub txtNom_Organizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Organizacion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaOrganizacion(2)
        End If
    End Sub

    Public Sub BuscaOrganizacion(Opcion As String)
        strSQL = "exec TG_Lista_Organizacion "
        Select Case Opcion
            Case 1 : strSQL = strSQL & "'" & txtCod_Organizacion.Text & "', ''"
            Case 2 : strSQL = strSQL & "','" & txtNom_Organizacion.Text & "'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = strSQL
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod_Organizacion")
            Descripcion = oTipo.dtResultados.Rows(0)("Nom_Organizacion")
        End If

        If Codigo <> "" Then
            txtCod_Organizacion.Text = Codigo
            txtNom_Organizacion.Text = Descripcion
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            dtpFecha.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub dtpFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtpFecha.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BtnBuscar.Focus()
        End If
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CargarGrilla()
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC cn_Ventas_Facturas_x_agrupar"
            strSQL &= vbNewLine & String.Format(" @Cod_Organización = '{0}'", txtCod_Organizacion.Text)
            strSQL &= vbNewLine & String.Format(",@Fecha            = '{0}'", dtpFecha.Value.ToShortDateString)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdDatos.RootTable.Columns.Clear()
            GrdDatos.DataSource = oDT
            CheckLayoutGridEx(GrdDatos)

            With GrdDatos
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 30
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("Ser_docum").Width = 80
                    .Columns("Ser_docum").Caption = "SERIE"
                    .Columns("Num_docum").Width = 120
                    .Columns("Num_docum").Caption = "NRO DOCUMENTO"
                    .Columns("Fecha").Width = 100
                    .Columns("cliente").Width = 250
                    .Columns("Moneda").Width = 70
                    .Columns("Imp_total").Width = 100
                    .Columns("Imp_total").Caption = "IMP TOTAL"
                    .Columns("num_corre").Visible = False
                    .Columns("Fecha").FormatString = "dd/MM/yyyy"

                    With .Columns(K_strColCheck)
                        .Caption = "SEL"
                        .Visible = True
                        .ColumnType = ColumnType.CheckBox
                        .EditType = EditType.CheckBox
                        .ActAsSelector = True
                        .Width = 25
                        .Caption = String.Empty
                        .Position = 0
                    End With

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If GrdDatos.GetCheckedRows.Length Then
            FraFactura.Visible = True
            Me.txtFacturaAgrupada.Text = ""
            Me.txtFacturaAgrupada.Focus()
        Else
            MessageBox.Show("Debe Seleccionar Al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub txtSerieAgrupada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSerieAgrupada.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtSerieAgrupada.Text = RellenaDeCerosEnIzquierda(txtSerieAgrupada.Text, 3)
            Me.txtFacturaAgrupada.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtFacturaAgrupada_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFacturaAgrupada.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtFacturaAgrupada.Text = RellenaDeCerosEnIzquierda(txtFacturaAgrupada.Text, 8)
            Me.BtnAceptarFactura.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub BtnAceptarFactura_Click(sender As Object, e As EventArgs) Handles BtnAceptarFactura.Click
        Try
            If MessageBox.Show("¿Está seguro de agrupar facturas?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                For Each oGridEXRow As GridEXRow In GrdDatos.GetCheckedRows 'recorre la lista
                    strSQL = String.Empty
                    strSQL &= vbNewLine & "EXEC cn_Ventas_Actualiza_FacturaAgrupada"
                    strSQL &= vbNewLine & String.Format(" @facturaAgrupada  = '{0}'", Me.txtSerieAgrupada.Text & Me.txtFacturaAgrupada.Text)
                    strSQL &= vbNewLine & String.Format(",@num_corre        = '{0}'", oGridEXRow.Cells("num_corre").Value)
                    oHP.EjecutaOperacion(strSQL, cCONNECT)
                Next

                Call ImprimirSTN_Agrupada(Me.txtSerieAgrupada.Text & Me.txtFacturaAgrupada.Text)
                CargarGrilla()
            End If
            FraFactura.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnCancelarFactura_Click(sender As Object, e As EventArgs) Handles BtnCancelarFactura.Click
        Me.FraFactura.Visible = False
    End Sub

    Private Sub ImprimirSTN_Agrupada(ByVal sFacturaAgrupada As String)
        Try
            Dim oo As Object
            oo = CreateObject("excel.application")
            oo.Workbooks.Open(vRuta & "\rptFacturaSTN.XLT")
            oo.Visible = True
            oo.DisplayAlerts = False
            oo.Run("reporte", "Ventas_Exportacion_Vineyard_Vince_Cabecera_Agrupada '" & sFacturaAgrupada & "'", "Ventas_Exportaciones_Genera_Lineas_Factura_Agrupada '" & sFacturaAgrupada & "'", "Ventas_Exportacion_Vineyard_Vince_Trailer_Agrupada  '" & sFacturaAgrupada & "'", sFacturaAgrupada, cCONNECTVB6)
            oo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class