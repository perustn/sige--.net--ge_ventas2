Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_VerPacking
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private Sub FrmDocumentoVentaExportacion_VerPacking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CARGA_GRID()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC VENTAS_Muestra_PackingList"
            strSQL &= vbNewLine & String.Format("@NUM_CORRE  = '{0}'", TxtNroCorrelativo.Text)

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
                    .RowHeight = 25
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("ABR_CLIENTE").Visible = False

                    With .Columns("NUM_PACKING")
                        .Caption = "NRO PACKING"
                        .Width = 80
                    End With

                    With .Columns("NOM_CLIENTE")
                        .Caption = "CLIENTE"
                        .Width = 190
                    End With

                    With .Columns("FEC_DESPACHO")
                        .Caption = "FECHA DESPACHO"
                        .Width = 110
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("FEC_CONGELADO")
                        .Caption = "FECHA CONGELADO"
                        .Width = 110
                        .TextAlignment = TextAlignment.Center
                    End With
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class