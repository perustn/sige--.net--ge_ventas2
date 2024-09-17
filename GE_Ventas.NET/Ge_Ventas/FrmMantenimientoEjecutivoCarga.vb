Imports Janus.Windows.GridEX
Public Class FrmMantenimientoEjecutivoCarga
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Public sRuc_CfEmpTrn As String

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private Sub FrmMantenimientoModoEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtCod_AgenteCarga
    End Sub
    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub
    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC tg_muestra_AgenteCarga_Ejecutivo"
        strSQL &= vbNewLine & String.Format(" @agente_carga      = '{0}'", txtCod_AgenteCarga.Text)


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

                With .Columns("CODIGO")
                    .Width = 90
                End With

                With .Columns("NOMBRE_EJECUTIVO")
                    .Caption = "NOMBRE EJECUTIVO"
                    .Width = 285
                End With
            End With
        End With

        If GrdMntTest.RowCount > 0 Then
            GrdMntTest.Enabled = True
        Else
            GrdMntTest.Enabled = False
        End If
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
                    txtDescripcion.Focus()
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
                    txtDescripcion.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub

                    MessageBox.Show("OPCION ESTA INACTIVA")
                    Exit Sub
                    Eliminar = MsgBox("¿Esta usted seguro de eliminar el registro seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If Eliminar = MsgBoxResult.Yes Then
                        OpcionMantenimiento = "D"
                        Call SALVAR_DATOS()
                        Call CARGA_GRID()
                        OpcionMantenimiento = ""
                    End If

                Case "GRABAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub
                    vRow = GrdMntTest.Row
                    cRow = GrdMntTest.RowCount
                    Call SALVAR_DATOS()
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

    Public Sub HABILITA_DATOS(Activar As Boolean)
        txtDescripcion.Enabled = Activar
        GrdMntTest.Enabled = Not Activar
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
    End Sub
    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC AS_Man_AGENTE_CARGA_EJECUTIVO"
            strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@cod_agenteCarga  = '{0}'", txtCod_AgenteCarga.Text)
            strSQL &= vbNewLine & String.Format(",@cod_ejecutivo    = '{0}'", txtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@nom_ejecutivo    = '{0}'", txtDescripcion.Text)

            If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                CARGA_GRID()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub GrdMntTest_SelectionChanged(sender As Object, e As EventArgs) Handles GrdMntTest.SelectionChanged
        Call Me.Carga_Datos()
    End Sub
    Public Sub Carga_Datos()
        If Me.GrdMntTest.RowCount > 0 Then
            Dim dr As DataRow
            dr = ObtenerDr_DeGridEx(GrdMntTest)
            If Not dr Is Nothing Then
                txtCodigo.Text = dr("CODIGO").ToString
                txtDescripcion.Text = dr("NOMBRE_EJECUTIVO").ToString
                'txtDescripcionLarga.Text = dr("NVSDESLAR").ToString
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub
    Private Sub txtCod_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_AgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteCarga(1)
        End If
    End Sub
    Private Sub txtDes_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_AgenteCarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaAgenteCarga(2)
        End If
    End Sub
    Private Sub BuscaAgenteCarga(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un registro"
        oTipo.sQuery = "VE_TG_AGENTECARGA '" & sTipo & "','','" & Trim(txtCod_AgenteCarga.Text) & "','" & Trim(txtDes_AgenteCarga.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_AgenteCarga.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_AgenteCarga.Text = oTipo.dtResultados.Rows(0)("descripcion")
            BtnBuscar.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_AgenteCarga.Text = Trim(Codigo)
            txtDes_AgenteCarga.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            BtnBuscar.Select()
        End If
        oTipo = Nothing
    End Sub
End Class