Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_VerCobros
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVenta_VerCobros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdLista
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Cobranzas_del_Documento"
            strSQL &= vbNewLine & String.Format("@Num_Corre  = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GrdLista.RootTable.Columns.Clear()
            GrdLista.DataSource = oDT
            CheckLayoutGridEx(GrdLista)

            With GrdLista
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains
                With .RootTable
                    .HeaderLines = 2
                    .PreviewRow = False
                    .PreviewRowLines = 10
                    .RowHeight = 30
                    .TotalRow = InheritableBoolean.True
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next
                End With
            End With

            '        GridEX1.GroupFooterStyle = jgexTotalsGroupFooter
            'Set colTemp = GridEX1.Columns("importe")
            'colTemp.AggregateFunction = jgexSum
            'colTemp.TotalRowPrefix = ""

            GrdLista.FrozenColumns = 2
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class