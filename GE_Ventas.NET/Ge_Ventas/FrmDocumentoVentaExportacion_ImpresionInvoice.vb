Imports Janus.Windows.GridEX

Public Class FrmDocumentoVentaExportacion_ImpresionInvoice
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Public sCodCliente As String
    Public Tipo As String

    Public lNum_Embarque As Long

    Private Sub FrmDocumentoVentaExportacion_ImpresionInvoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdDatos
    End Sub

    Sub CargarGrilla()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC TG_CLIENTE_INVOICE_FORMATOS_MANT"
            strSQL &= vbNewLine & String.Format(" @ACCION       = '{0}'", "P")
            strSQL &= vbNewLine & String.Format(",@COD_CLIENTE  = '{0}'", sCodCliente)
            strSQL &= vbNewLine & String.Format(",@ID_FORMATO   =  {0} ", lNum_Embarque)
            strSQL &= vbNewLine & String.Format(",@COD_USUARIO  = '{0}'", vusu)
            strSQL &= vbNewLine & String.Format(",@TIPO         = '{0}'", Tipo)


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

                    .Columns("ID_Formato").Caption = "ID"
                    .Columns("ID_Formato").Width = 70
                    .Columns("Plantilla_XLT").Visible = False
                    .Columns("descripcion").Width = 300
                    .Columns("Flg_Generico").Caption = "¿ES GENÉRICO?"
                    .Columns("Flg_Generico").Width = 200
                End With
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Try
            Call ImprimirVistaPreliminar(lNum_Embarque, TxtNroCorrelativo.Text, GrdDatos.GetValue(GrdDatos.RootTable.Columns("Plantilla_XLT").Index))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub ImprimirVistaPreliminar(ByVal sEmbarque As Long, ByVal sCorrelativo As String, ByVal Plantilla As String)
        Dim oo As Object
        Dim strSQL As String
        Dim sRutaLogo As String
        strSQL = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
        sRutaLogo = oHP.DevuelveDato(strSQL, cSEGURIDAD)
        oo = CreateObject("excel.application")
        oo.Workbooks.Open(vRuta & "\" & Plantilla)
        oo.Visible = True
        If Tipo = "P" Then
            oo.Run("App.Run", cCONNECTVB6, "", sEmbarque, Tipo)
        ElseIf Tipo = "I" Then
            oo.Run("App.Run", cCONNECTVB6, "", sCorrelativo, Tipo)
        End If
        oo = Nothing
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub
End Class