Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_GastosAsociados
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private ColEmpresa As Color
    Private oDT As New DataTable
    Public sNum_Embarque As String

    Private Sub FrmTgEmbarque_GastosAsociados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = ColEmpresa

        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_EMBARQUE_MUESTRA_CN_DOCUM "
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

                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                            .TextAlignment = TextAlignment.Center
                        End With
                    Next

                    With .Columns("DOCUMENTO")
                        .Width = 80
                    End With

                    With .Columns("DES_ANEXO")
                        .Caption = "ANEXO"
                        .Width = 80
                    End With

                    With .Columns("FEC_EMIDOC")
                        .Caption = "FECHA EMISION"
                        .Width = 120
                    End With

                    With .Columns("IMP_TOTAL")
                        .Caption = "IMPORTE TOTAL"
                        .Width = 90
                    End With

                    With .Columns("COD_MONEDA")
                        .Caption = "CODIGO MONEDA"
                        .Width = 80
                    End With

                    With .Columns("TIPO_ITEM")
                        .Caption = "TIPO ITEM"
                        .Width = 90
                    End With

                    With .Columns("PROVISION")
                        .Width = 90
                    End With
                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class