Imports Janus.Windows.GridEX
Public Class FrmMantenimientoNaves
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Public sRuc_CfEmpTrn As String

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String

    Private Sub FrmMantenimientoModoEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtCod_Naviera
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub

    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC TG_Muestra_Naves"
        strSQL &= vbNewLine & String.Format(" @NAVCOD        = '{0}'", txtCod_Naviera.Text)


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

                With .Columns("NAVCOD")
                    .Visible = False
                    .Width = 80
                End With

                With .Columns("NAVDESLAR")
                    .Visible = False
                    .Width = 200
                End With

                With .Columns("NVSCOD")
                    .Width = 80
                End With

                With .Columns("NVSDESLAR")
                    .Caption = "DESCRIPCION LARGA"
                    .Width = 220
                End With

                With .Columns("NVSDESCOR")
                    .Caption = "DESCRIPCION CORTA"
                    .Width = 100
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
                    Me.txtDescripcionCorta.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("MODIFICAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "MODIFICAR"
                    OpcionMantenimiento = "U"
                    Call HABILITA_DATOS(True)
                    Me.txtDescripcionCorta.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    Eliminar = MsgBox("¿Esta usted seguro de eliminar el registro seleccionado?", MsgBoxStyle.Information + MsgBoxStyle.YesNo, "Mensaje")
                    If Eliminar = MsgBoxResult.Yes Then
                        OpcionMantenimiento = "D"
                        Call SALVAR_DATOS()
                        Call CARGA_GRID()
                        OpcionMantenimiento = ""
                    End If

                Case "GRABAR"
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
        txtDescripcionCorta.Enabled = Activar
        txtDescripcionLarga.Enabled = Activar
        GrdMntTest.Enabled = Not Activar
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCodigo.Text = String.Empty
        txtDescripcionCorta.Text = String.Empty
        txtDescripcionLarga.Text = String.Empty
    End Sub
    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC AS_MAN_NAVES"
            strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@NAVCOD           = '{0}'", txtCod_Naviera.Text)
            strSQL &= vbNewLine & String.Format(",@NVSCOD           = '{0}'", txtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@NVSDESLAR        = '{0}'", txtDescripcionLarga.Text)
            strSQL &= vbNewLine & String.Format(",@NVSDESCOR        = '{0}'", txtDescripcionCorta.Text)

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
                txtCodigo.Text = dr("NVSCOD").ToString
                txtDescripcionCorta.Text = dr("NVSDESCOR").ToString
                txtDescripcionLarga.Text = dr("NVSDESLAR").ToString
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub
    Private Sub txtCod_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Naviera.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNaviera(1)
        End If
    End Sub
    Private Sub txtDes_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Naviera.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaNaviera(2)
        End If
    End Sub
    Private Sub BuscaNaviera(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un registro"
        oTipo.sQuery = "cf_tg_navieras '" & sTipo & "','','" & Trim(txtCod_Naviera.Text) & "','" & Trim(txtDes_Naviera.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_Naviera.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_Naviera.Text = oTipo.dtResultados.Rows(0)("descripcion")
            BtnBuscar.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_Naviera.Text = Trim(Codigo)
            txtDes_Naviera.Text = Trim(Descripcion)
            Codigo = "" : Descripcion = ""
            BtnBuscar.Select()
        End If
        oTipo = Nothing
    End Sub

    Private Sub txtDescripcionCorta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionCorta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDescripcionLarga.Focus()
        End If
    End Sub
End Class