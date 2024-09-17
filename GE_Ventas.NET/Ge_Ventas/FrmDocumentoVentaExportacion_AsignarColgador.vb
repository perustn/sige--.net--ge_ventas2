Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_AsignarColgador
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Private Const K_strColCheck As String = "SEL"

    Private Sub FrmDocumentoVentaExportacion_AsignarColgador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        Panel1.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_MUESTRA_MATRIZ_COLGADORES"
            strSQL &= vbNewLine & String.Format("@Num_Corre  = '{0}'", TxtNroCorrelativo.Text)

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

                    .Columns("PO").Width = 90
                    .Columns("ESTILO").Width = 90
                    .Columns("INDICE").Visible = False
                    .Columns("COD_COLOR").Visible = False
                    .Columns("COLOR").Width = 160
                    .Columns("TALLA").Width = 70
                    .Columns("PRENDAS").Width = 80
                    .Columns("COLGADOR").Width = 130
                    .Columns("PRECIO").Width = 90

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

    Private Sub ButtonBar1_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If GrdDatos.GetCheckedRows.Length Then
                        fraGuias.Visible = True
                        TxtCodColgador.Focus()
                    Else
                        MessageBox.Show("Debe Seleccionar Al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
                Case "QUITAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If GrdDatos.GetCheckedRows.Length Then
                        QUITAR()
                    Else
                        MessageBox.Show("Debe Seleccionar Al Menos un Registro", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        Exit Sub
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub TxtCodColgador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtCodColgador.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaColgador()
        End If
    End Sub

    Private Sub TxtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaColgador()
        End If
    End Sub

    Private Sub BuscaColgador()
        Dim oTipo As New frmBusqGeneral6
        oTipo.oParent = Me
        oTipo.sQuery = "EXEC SP_MUESTRA_CODIGO_COLGADOR '" & Trim(TxtCodColgador.Text) & "'"
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count <> 1 Then
            oTipo.ShowDialog()
        Else
            Codigo = oTipo.dtResultados.Rows(0)("COD_COLGADOR")
            Descripcion = oTipo.dtResultados.Rows(0)("DESCRIPCION")
            TipoAdd = oTipo.dtResultados.Rows(0)("PRECIO")
        End If

        If Codigo <> "" Then
            TxtCodColgador.Text = Codigo
            TxtDescripcion.Text = Descripcion
            TxtPrecio.Text = TipoAdd
            Codigo = "" : Descripcion = "" : TipoAdd = "" : TipoAdd2 = ""
            BtnAceptarFactura.Focus()
        End If
        oTipo = Nothing
    End Sub

    Private Sub BtnAceptarFactura_Click(sender As Object, e As EventArgs) Handles BtnAceptarFactura.Click
        Grabar()
        Limpiar()
    End Sub

    Private Sub BtnCancelarFactura_Click(sender As Object, e As EventArgs) Handles BtnCancelarFactura.Click
        fraGuias.Visible = False
        Limpiar()
    End Sub

    Sub Limpiar()
        TxtCodColgador.Text = ""
        TxtDescripcion.Text = ""
        TxtPrecio.Text = ""
        fraGuias.Visible = False
    End Sub

    Sub Grabar()
        Try
            Dim sTodos As Integer
            sTodos = 0

            If Trim(TxtCodColgador.Text) = "" Then
                MessageBox.Show("Ingrese Codigo Colgador", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Trim(TxtPrecio.Text) = "" Or CDbl(TxtPrecio.Text) = 0 Then
                MessageBox.Show("Precio debe ser mayor a [0.00]", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If MessageBox.Show("Desea Aplicar el Código de Colgador a todas las Tallas de las PO/ESTILO/COLOR Involucrados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                sTodos = 1
            End If

            For Each oGridEXRow As GridEXRow In GrdDatos.GetCheckedRows 'recorre la lista
                strSQL = String.Empty
                strSQL &= vbNewLine & "EXEC SP_REGISTRA_COD_COLCADOR_FACTURA"
                strSQL &= vbNewLine & String.Format(" @Cod_Colgador = '{0}'", TxtCodColgador.Text)
                strSQL &= vbNewLine & String.Format(",@Num_Corre    = '{0}'", TxtNroCorrelativo.Text)
                strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", oGridEXRow.Cells("PO").Value)
                strSQL &= vbNewLine & String.Format(",@Estilo       = '{0}'", oGridEXRow.Cells("ESTILO").Value)
                strSQL &= vbNewLine & String.Format(",@CodColor     = '{0}'", oGridEXRow.Cells("COD_COLOR").Value)
                strSQL &= vbNewLine & String.Format(",@Talla        = '{0}'", oGridEXRow.Cells("TALLA").Value)
                strSQL &= vbNewLine & String.Format(",@SW           =  {0} ", CStr(sTodos))
                strSQL &= vbNewLine & String.Format(",@Cod_Usu      = '{0}'", vusu)
                strSQL &= vbNewLine & String.Format(",@OP           =  {0} ", 0)
                oHP.EjecutaOperacion(strSQL, cCONNECT)
            Next

            CargarGrilla()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub QUITAR()
        Dim sTodos As Integer
        sTodos = 0

        If MessageBox.Show("Desea Quitar el Código de Colgador a todas las Tallas de las PO/ESTILO/COLOR Involucrados?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
            sTodos = 1
        End If

        For Each oGridEXRow As GridEXRow In GrdDatos.GetCheckedRows 'recorre la lista
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC SP_REGISTRA_COD_COLCADOR_FACTURA"
            strSQL &= vbNewLine & String.Format(" @Cod_Colgador = '{0}'", TxtCodColgador.Text)
            strSQL &= vbNewLine & String.Format(",@Num_Corre    = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@PO           = '{0}'", oGridEXRow.Cells("PO").Value)
            strSQL &= vbNewLine & String.Format(",@Estilo       = '{0}'", oGridEXRow.Cells("ESTILO").Value)
            strSQL &= vbNewLine & String.Format(",@CodColor     = '{0}'", oGridEXRow.Cells("COD_COLOR").Value)
            strSQL &= vbNewLine & String.Format(",@Talla        = '{0}'", oGridEXRow.Cells("TALLA").Value)
            strSQL &= vbNewLine & String.Format(",@SW           =  {0} ", CStr(sTodos))
            strSQL &= vbNewLine & String.Format(",@Cod_Usu      = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@OP           =  {0} ", 1)
            oHP.EjecutaOperacion(strSQL, cCONNECT)
        Next

        CargarGrilla()
    End Sub
End Class