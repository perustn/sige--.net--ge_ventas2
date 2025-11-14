Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Text
Imports Aspose.Email.Mail
Imports Janus.Windows.GridEX

Public Class FrmBandeja_Facturacion006_CMT
    Dim strSQL As String
    Dim oHP As New clsHELPER
    Private ds As New DataTable
    Private colEmpresa As Color
    Private rs As New ADODB.Recordset
    Private EnBusqueda As Boolean = False
    Private Exito As Boolean = False
    Private ErrorEjecucion As String = ""
    Private Sub Bandeja_Facturacion006_CMT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa
        CargarGrilla()
    End Sub
    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Cn_Ventas_Facturas_CMT"
            strSQL &= vbNewLine & String.Format("@num_corre  = '{0}'", txtCorrelativo.Text)

            ds = oHP.DevuelveDatos(strSQL, cCONNECT)
            GridEX1.DataSource = ds
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

                    .Columns("cod_cliente").Visible = False
                    .Columns("nom_cliente").Width = 240
                End With
            End With
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub ButtonBar1_ItemClick_1(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles ButtonBar1.ItemClick
        Select Case e.Item.Key
            Case "PROCESAR"
                Procesar()
            Case "VERFACTURA"
                Ver_Factura()
        End Select
    End Sub

    Private Sub Ver_Factura()
        If GridEX1.RowCount = 0 Then Exit Sub
        Using oVer As New FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT
            With oVer
                .Serie_stn = txtSerie.Text
                .Nro_doc_stn = txtNumero.Text.Trim
                .TxtNroCorrelativo.Text = Me.txtCorrelativo.Text.Trim
                .TxtPO.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("po").Index).ToString.Trim
                .TxtEstilo.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("estilocliente").Index).ToString.Trim
                .CargarGrilla()
                .ShowDialog()
                CargarGrilla()
            End With
        End Using
    End Sub

    Private Sub Procesar()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Distribuye_por_Partida_Actualzia_GR_CMT_Desde_GR_Exportacion_STN"
            strSQL &= vbNewLine & String.Format(" @num_corre    = '{0}'", txtCorrelativo.Text)
            strSQL &= vbNewLine & String.Format(",@opcion       = '{0}'", "1")
            strSQL &= vbNewLine & String.Format(",@Cod_Usuario  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@Flg_Facturacion_Automatica  = '{0}'", "S")
            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                MessageBox.Show("Datos procesados correctamente", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CargarGrilla()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class