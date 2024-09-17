Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_OtrosGastos
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String
    Private FilaSeleccionada As Integer

    Private Sub FrmDocumentoVentaExportacion_OtrosGastos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC Ventas_Muestra_Otros_Cargos_Descuentos"
            strSQL &= vbNewLine & String.Format("@num_CORRE  = '{0}'", TxtNroCorrelativo.Text)

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

                    .Columns("TIP_CONCEPTO").Visible = False

                    With .Columns("SECUENCIA")
                        .Caption = "SEC"
                        .Width = 50
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("DES_TIP_CONCEPTO")
                        .Caption = "TIPO CONCEPTO"
                        .Width = 110
                    End With

                    With .Columns("DES_CONCEPTO")
                        .Caption = "CONCEPTO"
                        .Width = 200
                    End With

                    With .Columns("IMPORTE")
                        .Width = 90
                        .TextAlignment = TextAlignment.Far
                    End With

                    With .Columns("COD_USUARIO")
                        .Caption = "USUARIO"
                        .Width = 90
                    End With
                    With .Columns("COD_ESTACION")
                        .Caption = "PC"
                        .Width = 100
                    End With
                    With .Columns("FEC_CREACION")
                        .Caption = "FECHA CREACION"
                        .Width = 90
                        .TextAlignment = TextAlignment.Center
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
                    Using oAdd As New FrmDocumentoVentaExportacion_OtrosGastos_Mant
                        With oAdd
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .LabelSec.Visible = False
                            .TxtSec.Visible = False
                            .sAccion = "I"
                            .sSecuencia = 0
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                            End If
                        End With
                    End Using

                Case "MODIFICAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    FilaSeleccionada = GrdDatos.CurrentRow.Position
                    Using oAdd As New FrmDocumentoVentaExportacion_OtrosGastos_Mant
                        With oAdd
                            .TxtNroCorrelativo.Text = TxtNroCorrelativo.Text
                            .TxtSec.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index)
                            .sAccion = "U"
                            .sSecuencia = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index)
                            .txtCod_TipConp.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Tip_Concepto").Index)
                            .txtDes_TipConp.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("DES_TIP_CONCEPTO").Index)
                            .txtConcepto.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Des_Concepto").Index)
                            .txtImporte.Text = GrdDatos.GetValue(GrdDatos.RootTable.Columns("Importe").Index)
                            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                                CargarGrilla()
                                GrdDatos.Row = FilaSeleccionada
                            End If
                        End With
                    End Using

                Case "ELIMINAR"
                    If GrdDatos.RowCount = 0 Then Exit Sub
                    If MessageBox.Show("¿Está seguro de eliminar?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                        strSQL = String.Empty
                        strSQL &= vbNewLine & "EXEC Ventas_MAN_Otros_Cargos_Descuentos"
                        strSQL &= vbNewLine & String.Format(" @accion           = '{0}'", "D")
                        strSQL &= vbNewLine & String.Format(",@Num_Corre        = '{0}'", TxtNroCorrelativo.Text)
                        strSQL &= vbNewLine & String.Format(",@Secuencia        =  {0} ", GrdDatos.GetValue(GrdDatos.RootTable.Columns("Secuencia").Index))
                        strSQL &= vbNewLine & String.Format(",@Tip_Concepto     = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@Des_Concepto     = '{0}'", "")
                        strSQL &= vbNewLine & String.Format(",@Importe          =  {0} ", 0)
                        strSQL &= vbNewLine & String.Format(",@cod_usuario      = '{0}'", vusu)
                        strSQL &= vbNewLine & String.Format(",@cod_estacion     = '{0}'", ComputerName())

                        If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                            MessageBox.Show("Se eliminó correctamente...", Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)
                            CargarGrilla()
                        End If
                    End If
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class