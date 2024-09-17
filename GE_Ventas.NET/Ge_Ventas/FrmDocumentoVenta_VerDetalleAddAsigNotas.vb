Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_VerDetalleAddAsigNotas
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String

    Public strNum_Corre_Ori As String

    Private Sub FrmDocumentoVenta_VerDetalleAddAsigNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa

        Me.ActiveControl = txtCod_TipDoc
    End Sub

    Private Sub txtCod_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 1, Me)
        End If
    End Sub

    Private Sub txtCod_TipDoc_TextChanged(sender As Object, e As EventArgs) Handles txtCod_TipDoc.TextChanged
        Call LimpiarGrilla()
    End Sub

    Private Sub txtDes_TipDoc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipDoc.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            Call Busca_Opcion("Cod_TipDoc", "Des_TipDoc", "CN_TiposDocum where Flg_Doc_Ventas = '*' and ", txtCod_TipDoc, txtDes_TipDoc, 1, Me)
        End If
    End Sub

    Public Sub Busca_Opcion(strCampo1 As String, strCampo2 As String, StrTabla As String, txtCod As TextBox, txtDes As TextBox, opcion As Integer, frmME As Form)
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        strSQL = "Select " & strCampo1 & " AS Cod," & strCampo2 & " as Descripcion from " & StrTabla
        Select Case opcion
            Case 1 : oTipo.sQuery = strSQL & strCampo1 & " like '%" & txtCod.Text & "%'"
            Case 2 : oTipo.sQuery = strSQL & strCampo2 & " like '%" & txtDes.Text & "%'"
        End Select
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("Cod")
            Descripcion = oTipo.dtResultados.Rows(0)("Descripcion")
        End If

        If Codigo <> "" Then
            txtCod_TipDoc.Text = Trim(Codigo)
            txtDes_TipDoc.Text = Trim(Descripcion)
            BtnBuscar.Focus()
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
        oTipo = Nothing
    End Sub

    Private Sub txtSer_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSer_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            If IsNumeric(txtSer_Docum.Text) Then
                txtSer_Docum.Text = RellenaDeCerosEnIzquierda(txtSer_Docum.Text, 3)
            End If
            txtNum_Docum.Focus()
        End If
    End Sub

    Private Sub txtSer_Docum_TextChanged(sender As Object, e As EventArgs) Handles txtSer_Docum.TextChanged
        Call LimpiarGrilla()
    End Sub

    Private Sub txtNum_Docum_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Docum.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Docum.Text = RellenaDeCerosEnIzquierda(txtNum_Docum.Text, 8)
            BtnBuscar.Focus()
        Else
            ValidarSoloNumeros(e)
        End If
    End Sub

    Private Sub txtNum_Docum_TextChanged(sender As Object, e As EventArgs) Handles txtNum_Docum.TextChanged
        Call LimpiarGrilla()
    End Sub

    Private Sub GridEX1_SelectionChanged(sender As Object, e As EventArgs) Handles GridEX1.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.GridEX1.RowCount > 0 Then
            Dim dr As DataRow
            dr = ObtenerDr_DeGridEx(GridEX1)
            If Not dr Is Nothing Then
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC Ventas_Muestras_Facturas_por_Asignar_Item"
                strSQL &= vbNewLine & String.Format(" @Num_Corre        = '{0}'", dr("Num_Corre"))

                oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
                GridEX2.DataSource = oDT
                CheckLayoutGridEx(GridEX2)

                With GridEX2
                    .FilterMode = FilterMode.None
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

                        .Columns("Codigo_Item").Width = 150
                        .Columns("Descripcion").Width = 200
                        .Columns("Cantidad").Width = 76
                        .Columns("Imp_Total").Width = 84
                        .Columns("Tipo").Width = 45
                        .Columns("secuencia").Visible = False

                    End With
                End With
            End If
        Else
            Call LimpiarGrilla()
        End If
    End Sub

    Private Sub LimpiarGrilla()
        GridEX1.RootTable.Columns.Clear()
        GridEX2.RootTable.Columns.Clear()
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub

    Public Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC Ventas_Muestras_Facturas_por_Asignar"
        strSQL &= vbNewLine & String.Format(" @Num_Corre        = '{0}'", strNum_Corre_Ori)
        strSQL &= vbNewLine & String.Format(",@Cod_TipDoc       = '{0}'", txtCod_TipDoc.Text)
        strSQL &= vbNewLine & String.Format(",@Ser_Docum        = '{0}'", txtSer_Docum.Text)
        strSQL &= vbNewLine & String.Format(",@Num_Docum_Ventas = '{0}'", txtNum_Docum.Text)

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GridEX1.DataSource = oDT
        CheckLayoutGridEx(GridEX1)

        With GridEX1
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
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

                .Columns("COD_TIPDOC").Width = 49
                .Columns("COD_TIPDOC").Caption = "TIP"
                .Columns("SER_DOCUM").Width = 52
                .Columns("SER_DOCUM").Caption = "SERIE"
                .Columns("NUM_DOCUM_VENTAS").Width = 88
                .Columns("NUM_DOCUM_VENTAS").Caption = "NRO_DOC"
                .Columns("FECHA").Width = 120
                .Columns("COD_MONEDA").Width = 105
                .Columns("ANO_REGISTRO").Width = 108
                .Columns("MES_REGISTRO").Width = 118
                .Columns("FECHA").Caption = "EMISION"
                .Columns("FECHA").FormatString = "dd/MM/yyyy"
                .Columns("NUM_CORRE").Visible = False
                .Columns("IMP_TOTAL").Width = 150
            End With
        End With
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            If GridEX1.RowCount = 0 Or GridEX2.RowCount = 0 Then
                MessageBox.Show("Seleccione un Item de Factura", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If

            Using oAdddet As New FrmDocumentoVenta_VerDetalleAdd   'frmAdicionaDetalleDocum
                With oAdddet
                    .strNum_Corre_Detalle = strNum_Corre_Ori
                    .IntSencuencia = 0
                    .StrOption = "I"
                    .strNum_Corre_Doc_Asig = GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Corre").Index)
                    .IntSencuencia_Doc_Asig = GridEX2.GetValue(GridEX2.RootTable.Columns("Secuencia").Index)
                    .txtTip_Item.Text = "P"
                    .txtCod_Producto.Text = GridEX2.GetValue(GridEX2.RootTable.Columns("Codigo_Item").Index)
                    .txtDescripcion.Text = GridEX2.GetValue(GridEX2.RootTable.Columns("Descripcion").Index)
                    .txtCantidad.Text = GridEX2.GetValue(GridEX2.RootTable.Columns("Cantidad").Index)
                    .txtImp_Unitario.Text = GridEX2.GetValue(GridEX2.RootTable.Columns("Imp_Unitario").Index)
                    .txtImp_Total.Text = GridEX2.GetValue(GridEX2.RootTable.Columns("Imp_Total").Index)
                    Me.Visible = False
                    .ShowDialog()
                    Me.Close()
                End With
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Visible = False
        Me.Close()
    End Sub
End Class