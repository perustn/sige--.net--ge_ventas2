Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_Detalle_VerPacking
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private oDT As New DataTable
    Private ColEmpresa As Color
    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_Detalle_VerPacking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = ColEmpresa
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_MUESTRA_EMBARQUE_PACKING "
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE		= '{0}'", sNum_Embarque)

            GridEX1.RootTable.Columns.Clear()
            oDT = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains

                With .RootTable
                    .RowHeight = 30
                    .PreviewRow = True
                    .PreviewRowMember = "Observacion"
                    .PreviewRowLines = 4
                    .HeaderLines = 3
                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                            .TextAlignment = TextAlignment.Center
                        End With
                    Next

                    With .Columns("OP")
                        .Width = 60
                    End With

                    With .Columns("COD_TEMCLI")
                        .Caption = "COD TEMP CLIENTE"
                        .Width = 70
                    End With

                    With .Columns("NUM_EMBARQUE")
                        .Caption = "Nº EMBARQUE"
                        .Width = 70
                    End With

                    With .Columns("NUM_PACKING")
                        .Caption = "Nº PACKING"
                        .Width = 70
                    End With

                    With .Columns("COD_CLIENTE")
                        .Caption = "COD CLIENTE"
                        .Width = 70
                    End With

                    With .Columns("COD_PURORD")
                        .Caption = "PO"
                        .Width = 70
                        .TextAlignment = TextAlignment.Empty
                    End With

                    With .Columns("COD_LOTPURORD")
                        .Caption = "LOTE"
                        .Width = 70
                    End With

                    With .Columns("COD_ESTCLI")
                        .Caption = "CODIGO ESTILO CLIENTE"
                        .Width = 80
                        .TextAlignment = TextAlignment.Empty
                    End With
                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ELIMINAR"
                    Call Eliminar

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Eliminar()
        Try
            If GridEX1.RowCount = 0 Then Exit Sub

            If (MessageBox.Show("¿Seguro de eliminar registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then

                strSQL = "EXEC TG_MAN_ELIMINA_PACKING_EMBARQUE"
                strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE   = '{0}'", sNum_Embarque)
                strSQL &= vbNewLine & String.Format(",@NUM_PACKING    = '{0}'", GridEX1.GetValue(GridEX1.RootTable.Columns("Num_Packing").Index))
                strSQL &= vbNewLine & String.Format(",@COD_USUARIO    = '{0}'", vusu)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se Elimino Correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargaDatos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class