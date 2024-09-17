Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_DocumentosAsociados
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_DocumentosAsociados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_VENTAS_MUESTRA_CN_Docum_Conceptos_Asociados_Venta"
            strSQL &= vbNewLine & String.Format(" @NUM_CORRE       = '{0}'", TxtNroCorrelativo.Text)

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

                    .Columns("ANEXO").Width = 240
                    .Columns("ANEXO").Caption = "ANEXO"
                    .Columns("COD_TIPDOC").Width = 100
                    .Columns("COD_TIPDOC").Caption = "COD. TIPO DOC."
                    .Columns("TIPO_DOC").Width = 100
                    .Columns("TIPO_DOC").Caption = "TIPO DOC."
                    .Columns("DOCUMENTO").Width = 100
                    .Columns("DOCUMENTO").Caption = "DOCUMENTO"
                    .Columns("FECHA_EMISION").Width = 100
                    .Columns("FECHA_EMISION").Caption = "FECHA EMISION"
                    .Columns("COD_CONCEPTO_ASOCIADO").Width = 120
                    .Columns("COD_CONCEPTO_ASOCIADO").Caption = "COD. CONCEP. ASOCIADO"
                    .Columns("DES_CONCEPTO_ASOCIADO").Width = 120
                    .Columns("DES_CONCEPTO_ASOCIADO").Caption = "DESC. CONCEP. ASOCIADO"
                    .Columns("IMPORTE").Width = 100
                    .Columns("IMPORTE").Caption = "IMPORTE"
                    .Columns("NOM_MONEDA").Width = 100
                    .Columns("NOM_MONEDA").Caption = "MONEDA"
                    .Columns("OBSERVACIONES").Width = 250
                    .Columns("OBSERVACIONES").Caption = "OBSERVACIONES"

                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class