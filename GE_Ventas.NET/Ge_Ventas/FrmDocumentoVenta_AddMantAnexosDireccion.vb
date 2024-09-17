Imports Janus.Windows.GridEX

Public Class FrmDocumentoVenta_AddMantAnexosDireccion
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String

    Private OpcionMantenimiento As String
    Public Cod_TipAnex As String
    Public Cod_Anexo As String

    Private Sub FrmDocumentoVenta_AddMantAnexosDireccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = GrdMntTest
    End Sub

    Public Sub CARGA_GRID()
        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC LG_UP_MAN_ANEXOSCONTABLES_DIRDESTINO"
        strSQL &= vbNewLine & String.Format(" @Accion       = '{0}'", "S")
        strSQL &= vbNewLine & String.Format(",@Cod_TipAnex  = '{0}'", Cod_TipAnex)
        strSQL &= vbNewLine & String.Format(",@Cod_Anxo     = '{0}'", Cod_Anexo)

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdMntTest.DataSource = oDT
        CheckLayoutGridEx(GrdMntTest)

        With GrdMntTest
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next
            End With
        End With

        If GrdMntTest.RowCount > 0 Then
            GrdMntTest.Enabled = True
        Else
            GrdMntTest.Enabled = False
        End If
    End Sub

    Private Sub txtCod_Dir_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Dir.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Via.Focus()
        End If
    End Sub

    Private Sub txtCod_Via_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Via.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaVia(1)
        End If
    End Sub

    Private Sub txtDes_Via_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Via.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaVia(2)
        End If
    End Sub

    Private Sub BuscaVia(Opcion As Integer)
        strSQL = "SELECT Cod_Via, Des_Via FROM TG_Via WHERE "
        Select Case Opcion
            Case 1 : strSQL = strSQL & "Cod_Via LIKE '%" & txtCod_Via.Text & "%'"
            Case 2 : strSQL = strSQL & "Des_Via LIKE '%" & txtDes_Via.Text & "%'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.sQuery = strSQL
        oTipo.oParent = Me
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Via.Text = Trim(oTipo.dtResultados.Rows(0)("Cod_Via"))
            txtDes_Via.Text = Trim(oTipo.dtResultados.Rows(0)("Des_Via"))
            txtNom_Via.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCod_Via.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod_Via").Value)
                txtDes_Via.Text = Trim(oTipo.RegistroSeleccionado.Cells("Des_Via").Value)
                txtNom_Via.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtNom_Via_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Via.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Dom.Focus()
        End If
    End Sub

    Private Sub txtNum_Dom_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Dom.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtNum_Int.Focus()
        End If
    End Sub

    Private Sub txtNum_Int_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNum_Int.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Zon.Focus()
        End If
    End Sub

    Private Sub txtCod_Zon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Zon.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaZona(1)
        End If
    End Sub

    Private Sub txtDes_Zon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Zon.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaZona(2)
        End If
    End Sub

    Private Sub BuscaZona(Opcion As Integer)
        strSQL = "SELECT Cod_Zona, Des_Zona FROM TG_Zona WHERE "
        Select Case Opcion
            Case 1 : strSQL = strSQL & "Cod_Zona LIKE '%" & txtCod_Zon.Text & "%'"
            Case 2 : strSQL = strSQL & "Des_Zona LIKE '%" & txtDes_Zon.Text & "%'"
        End Select

        Dim oTipo As New frmBusqGeneral6
        oTipo.sQuery = strSQL
        oTipo.oParent = Me
        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Zon.Text = Trim(oTipo.dtResultados.Rows(0)("Cod_Zona"))
            txtDes_Zon.Text = Trim(oTipo.dtResultados.Rows(0)("Des_Zona"))
            txtNom_Zon.Focus()
        Else
            oTipo.ShowDialog()
            If Codigo <> "" Then
                txtCod_Zon.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod_Zona").Value)
                txtDes_Zon.Text = Trim(oTipo.RegistroSeleccionado.Cells("Des_Zona").Value)
                txtNom_Zon.Focus()
            End If
        End If
        Codigo = "" : Descripcion = "" : TipoAdd = ""
        oTipo = Nothing
    End Sub

    Private Sub txtNom_Zon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNom_Zon.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtCod_Ubigeo.Focus()
        End If
    End Sub

    Private Sub txtCod_Ubigeo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Ubigeo.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            CmdCodUbigeo.Focus()
        End If
    End Sub

    Private Sub CmdCodUbigeo_Click(sender As Object, e As EventArgs) Handles CmdCodUbigeo.Click
        Using oMant As New FrmMaestroUbigeo
            With oMant
                .oParent = Me
                .Cod_Ubigeo = txtCod_Ubigeo.Text
                If .ShowDialog = DialogResult.OK Then
                    txtCod_Ubigeo.Text = .Cod_Ubigeo
                End If
            End With
        End Using
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Dim Eliminar As Short
            Dim vRow As Integer
            Dim cRow As Integer
            Select Case e.Item.Key
                Case "ADICIONAR"
                    OpcionMantenimiento = "I"
                    Call LIMPIA_DATOS()
                    Call HABILITA_DATOS(True)
                    Me.txtCod_Via.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("MODIFICAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "MODIFICAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub
                    OpcionMantenimiento = "U"
                    Call HABILITA_DATOS(True)
                    Me.txtCod_Via.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub
                    Eliminar = MsgBox("¿Esta usted seguro de eliminar el registro seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If Eliminar = MsgBoxResult.Yes Then
                        OpcionMantenimiento = "D"
                        If GuardarDatos() = True Then
                            OpcionMantenimiento = ""
                        End If
                    End If

                Case "GRABAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub
                    vRow = GrdMntTest.Row
                    cRow = GrdMntTest.RowCount
                    If GuardarDatos() = True Then
                        Call HABILITA_DATOS(False)
                        With BarraOpciones.Groups(0)
                            .Items("ADICIONAR").Enabled = True
                            .Items("MODIFICAR").Enabled = True
                            .Items("ELIMINAR").Enabled = True
                            .Items("GRABAR").Enabled = False
                            .Items("DESHACER").Enabled = False
                        End With

                        If OpcionMantenimiento = "U" Then
                            GrdMntTest.Row = vRow
                        Else
                            'GrdMntMedidas.Row = cRow
                        End If
                        OpcionMantenimiento = ""
                    End If

                Case "DESHACER"
                    Call LIMPIA_DATOS()
                    Call Carga_Datos()
                    Call HABILITA_DATOS(False)
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = True
                        .Items("MODIFICAR").Enabled = True
                        .Items("ELIMINAR").Enabled = True
                        .Items("GRABAR").Enabled = False
                        .Items("DESHACER").Enabled = False
                    End With
                    OpcionMantenimiento = ""

                Case "SALIR"
                    Me.Close()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub HABILITA_DATOS(Modo As Boolean)
        txtCod_Dir.Enabled = Modo
        txtCod_Via.Enabled = Modo
        txtDes_Via.Enabled = Modo
        txtNom_Via.Enabled = Modo
        txtNum_Dom.Enabled = Modo
        txtNum_Int.Enabled = Modo
        txtCod_Zon.Enabled = Modo
        txtDes_Zon.Enabled = Modo
        txtNom_Zon.Enabled = Modo
        txtCod_Ubigeo.Enabled = Modo
        ChkDefault.Enabled = Modo
        CmdCodUbigeo.Enabled = Modo
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCod_Dir.Text = String.Empty
        txtCod_Via.Text = String.Empty
        txtDes_Via.Text = String.Empty
        txtNom_Via.Text = String.Empty
        txtNum_Dom.Text = String.Empty
        txtNum_Int.Text = String.Empty
        txtCod_Zon.Text = String.Empty
        txtDes_Zon.Text = String.Empty
        txtNom_Zon.Text = String.Empty
        txtCod_Ubigeo.Text = String.Empty
        ChkDefault.Checked = False
    End Sub
    Private Function GuardarDatos() As Boolean
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC LG_UP_MAN_ANEXOSCONTABLES_DIRDESTINO"
            strSQL &= vbNewLine & String.Format(" @Accion               = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@Cod_TipAnex          = '{0}'", Cod_TipAnex)
            strSQL &= vbNewLine & String.Format(",@Cod_Anxo             = '{0}'", Cod_Anexo)
            strSQL &= vbNewLine & String.Format(",@Cod_DirDestino       = '{0}'", txtCod_Dir.Text)
            strSQL &= vbNewLine & String.Format(",@Des_DirDestino       = '{0}'", txtNom_Via.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Via_Domicilio    = '{0}'", txtCod_Via.Text)
            strSQL &= vbNewLine & String.Format(",@Numero_Domicilio     = '{0}'", txtNum_Dom.Text)
            strSQL &= vbNewLine & String.Format(",@Interior_Domicilio   = '{0}'", txtNum_Int.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Zona_Domicilio   = '{0}'", txtCod_Zon.Text)
            strSQL &= vbNewLine & String.Format(",@Nom_Zona_Domicilio   = '{0}'", txtNom_Zon.Text)
            strSQL &= vbNewLine & String.Format(",@Cod_Ubigeo_Domicilio = '{0}'", txtCod_Ubigeo.Text)
            strSQL &= vbNewLine & String.Format(",@Flg_Default          = '{0}'", IIf(ChkDefault.Checked = True, "S", "N"))

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                GuardarDatos = True
                CARGA_GRID()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Function

    Private Sub GrdMntTest_SelectionChanged(sender As Object, e As EventArgs) Handles GrdMntTest.SelectionChanged
        Call Me.Carga_Datos()
    End Sub

    Public Sub Carga_Datos()
        If Me.GrdMntTest.RowCount > 0 Then
            Dim dr As DataRow
            dr = ObtenerDr_DeGridEx(GrdMntTest)
            If Not dr Is Nothing Then
                txtCod_Dir.Text = Trim(dr("Cod_Dirdestino"))
                txtCod_Via.Text = Trim(dr("Cod_Via_Domicilio"))
                txtDes_Via.Text = Trim(dr("Des_Via"))
                txtNom_Via.Text = Trim(dr("Des_Dirdestino"))
                txtNum_Dom.Text = Trim(dr("Numero_Domicilio"))
                txtNum_Int.Text = Trim(dr("Interior_Domicilio"))
                txtCod_Zon.Text = Trim(dr("Cod_Zona"))
                txtDes_Zon.Text = Trim(dr("Des_Zona"))
                txtNom_Zon.Text = Trim(dr("Nom_Zona_Domicilio"))
                txtCod_Ubigeo.Text = Trim(dr("Cod_Ubigeo_Domicilio"))
                ChkDefault.Checked = IIf(Trim(dr("Flg_Default")) = "S", True, False)
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub
End Class