Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_VistaPreliminar
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private ColEmpresa As Color
    Public sAccion, sCod_Cliente, sNum_Embarque, sTipo As String
    Public sCorrelativo As String = ""
    Private Sub FrmTgEmbarque_VistaPreliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))

        Panel2.BackColor = ColEmpresa
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_CLIENTE_INVOICE_FORMATOS_MANT "
            strSQL &= vbNewLine & String.Format(" @ACCION		    = '{0}'", sAccion)
            strSQL &= vbNewLine & String.Format(",@COD_CLIENTE		= '{0}'", sCod_Cliente)
            strSQL &= vbNewLine & String.Format(",@ID_FORMATO		= '{0}'", sNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO		= '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@TIPO		        = '{0}'", sTipo)

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

                    With .Columns("ID_FORMATO")
                        .Caption = "ID FORMATO"
                        .Width = 70
                    End With

                    With .Columns("DESCRIPCION")
                        .Width = 180
                    End With

                    With .Columns("FLG_GENERICO")
                        .Caption = "FLG GENERICO"
                        .Width = 100
                    End With

                    With .Columns("PLANTILLA_XLT")
                        .Width = 330
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
                Case "IMPRIMIR"
                    Call Imprimir(sNum_Embarque, sCorrelativo, GridEX1.GetValue(GridEX1.RootTable.Columns("Plantilla_XLT").Index))

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Imprimir(sEmbarque As String, sCorrelativo As String, sPlantilla As String)
        Try
            Dim oXL As Object
            Dim RouteLogo As String
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "App.Run"

            strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            RouteLogo = oHP.DevuelveDato(strSQL, cCONNECT)

            RouteFileXLT = RouteFileXLT & "\" & sPlantilla

            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True

            If sTipo = "P" Then
                'oo.Run "App.Run", cCONNECT, "", sEmbarque, Tipo
                oXL.run(MethodVBA, cCONNECTVB6, "", sEmbarque, sTipo)
            ElseIf sTipo = "I" Then
                'oo.Run "App.Run", cCONNECT, "", sCorrelativo, Tipo
                oXL.run(MethodVBA, cCONNECTVB6, "", sCorrelativo, sTipo)
            End If

            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class