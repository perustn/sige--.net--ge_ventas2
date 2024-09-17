Public Class FrmTgEmbarque_SolEmbarqueMercaderia
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Public List_Emb As String
    Private colEmpresa As Color

    Private Sub FrmTgEmbarque_SolEmbarqueMercaderia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        ActiveControl = txtObservaciones
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        Call ProcesarSolicitud()
    End Sub

    Sub ProcesarSolicitud()
        Try
            Dim oXL As Object
            Dim RouteLogo As String
            Dim RouteFileXLT As String = vRuta
            Dim MethodVBA As String = "Reporte"

            StrSql = "SELECT Ruta_Logo = ISNULL(Ruta_Logo, '') From SEGURIDAD..SEG_EMPRESAS WHERE Cod_Empresa = '" & vemp & "'"
            RouteLogo = oHp.DevuelveDato(StrSql, cCONNECT)
            RouteFileXLT = RouteFileXLT & "\RepSolEmbMerca.xlt"
            oXL = CreateObject("excel.application")
            oXL.workbooks.Open(RouteFileXLT)
            oXL.DisplayAlerts = False
            oXL.Visible = True
            oXL.run(MethodVBA, cCONNECTVB6, List_Emb, vusu, txtObservaciones.Text)
            oXL.UserControl = True

            oXL = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
End Class