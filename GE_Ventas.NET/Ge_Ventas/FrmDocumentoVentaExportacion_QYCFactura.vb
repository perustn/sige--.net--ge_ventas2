Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_QYCFactura
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_QYCFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_Muestra_QYC_Por_Factura"
            strSQL &= vbNewLine & String.Format(" @Num_Corre       = '{0}'", TxtNroCorrelativo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
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

                    .Columns("ORDENES").Width = 80
                    .Columns("ORDENES").Caption = "OP"
                    .Columns("COD_PRESENT").Width = 100
                    .Columns("COD_PRESENT").Caption = "PRESENTACIÓN"
                    .Columns("COD_ORDTRA").Width = 80
                    .Columns("COD_ORDTRA").Caption = "COD. ORDTRA"
                    .Columns("KGS_TELA_REALES").Width = 90
                    .Columns("KGS_TELA_REALES").Caption = "KGS. TELA REALES"
                    .Columns("COD_ITEM").Width = 120
                    .Columns("COD_ITEM").Caption = "ITEM"
                    .Columns("CONS_REQUERIDO").Width = 100
                    .Columns("CONS_REQUERIDO").Caption = "CONSUMO REQUERIDO"
                    .Columns("CONS_ATENDIDO").Width = 100
                    .Columns("CONS_ATENDIDO").Caption = "CONSUMO ATENDIDO"

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class