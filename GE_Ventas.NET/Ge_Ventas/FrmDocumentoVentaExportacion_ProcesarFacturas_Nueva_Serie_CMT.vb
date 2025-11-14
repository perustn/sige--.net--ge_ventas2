Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable

    Public Serie_stn As String
    Public Nro_doc_stn As String

    Private Sub FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel1.BackColor = colEmpresa
        Panel2.BackColor = colEmpresa
    End Sub
    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC CN_MUESTRA_Ventas_Facturas_CMT_Detalle"
            strSQL &= vbNewLine & String.Format(" @num_corre   = '{0}'", TxtNroCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@COD_PURORD  = '{0}'", TxtPO.Text)
            strSQL &= vbNewLine & String.Format(",@COD_ESTCLI  = '{0}'", TxtEstilo.Text)

            oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
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
                End With
            End With

            GridEX1.FrozenColumns = 3
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnFactura_Click(sender As Object, e As EventArgs) Handles BtnFactura.Click
        Using xfmr As New FrmBandeja_Facturacion006_CMT_Envios
            With xfmr
                .Serie_guia = Serie_stn
                .Numero_Doc = Nro_doc_stn
                .NroCorrelativo = TxtNroCorrelativo.Text.ToString.Trim
                .PO = TxtPO.Text.ToString.Trim
                .Estilo = TxtEstilo.Text.ToString.Trim
                .ShowDialog()
                If .Ejecutado = True Then
                    Me.Close()
                End If
            End With
        End Using
    End Sub


End Class