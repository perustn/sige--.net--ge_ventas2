Imports Janus.Windows.GridEX
Public Class FrmMantenimientoNavieras
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Public sRuc_CfEmpTrn As String

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String

    Private Sub FrmMantenimientoModoEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ActiveControl = txtCod_TipoEmbarque
    End Sub

    Private Sub BtnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        CARGA_GRID()
    End Sub

    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC TG_MUESTRA_NAVIERAS"
        strSQL &= vbNewLine & String.Format(" @codigovia        = '{0}'", txtCod_TipoEmbarque.Text)


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
                    .Width = 80
                End With

                With .Columns("NAVDESLAR")
                    .Width = 200
                End With

                With .Columns("NAVDESCOR")
                    .Width = 80
                End With

                With .Columns("CODIGOVIA")
                    .Caption = "COD VIA"
                    .Width = 60
                End With

                With .Columns("CODIGOVIA_DES")
                    .Caption = "VIA"
                    .Width = 60
                End With

                With .Columns("NAVDIRECCION")
                    .Width = 120
                End With

                With .Columns("NAVTELEFONO1")
                    .Caption = "NAV TELF 1"
                    .Width = 70
                End With

                With .Columns("NAVTELEFONO2")
                    .Caption = "NAV TELF 2"
                    .Width = 70
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
        txtDireccion.Enabled = Activar
        txtTelefono1.Enabled = Activar
        txtTelefono2.Enabled = Activar
        GrdMntTest.Enabled = Not Activar
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCodigo_Embarque.Text = String.Empty
        txtDescripcionCorta.Text = String.Empty
        txtDescripcionLarga.Text = String.Empty
        txtDireccion.Text = String.Empty
        txtTelefono1.Text = String.Empty
        txtTelefono2.Text = String.Empty
    End Sub
    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC AS_MAN_NAVIERAS"
            strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@NAVCOD           = '{0}'", txtCodigo_Embarque.Text)
            strSQL &= vbNewLine & String.Format(",@NAVDESLAR        = '{0}'", txtDescripcionLarga.Text)
            strSQL &= vbNewLine & String.Format(",@NAVDESCOR        = '{0}'", txtDescripcionCorta.Text)
            strSQL &= vbNewLine & String.Format(",@CODIGOVIA        = '{0}'", txtCod_TipoEmbarque.Text)
            strSQL &= vbNewLine & String.Format(",@NAVDIRECCION     = '{0}'", txtDireccion.Text)
            strSQL &= vbNewLine & String.Format(",@NAVTELEFONO1     = '{0}'", txtTelefono1.Text)
            strSQL &= vbNewLine & String.Format(",@NAVTELEFONO2     = '{0}'", txtTelefono2.Text)

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
                txtCodigo_Embarque.Text = dr("NAVCOD").ToString
                txtDescripcionCorta.Text = dr("NAVDESCOR").ToString
                txtDescripcionLarga.Text = dr("NAVDESLAR").ToString
                txtDireccion.Text = dr("NAVDIRECCION").ToString
                txtTelefono1.Text = dr("NAVTELEFONO1").ToString
                txtTelefono2.Text = dr("NAVTELEFONO2").ToString
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub
    Private Sub txtCod_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_TipoEmbarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEmbarque(1)
        End If
    End Sub

    Private Sub txtTelefono2_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono2.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub fraDatos_Paint(sender As Object, e As PaintEventArgs) Handles fraDatos.Paint

    End Sub

    Private Sub txtDes_TipoEmbarque_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_TipoEmbarque.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            Call BuscaEmbarque(2)
        End If
    End Sub

    Private Sub BuscaEmbarque(sTipo As Integer)
        Dim oTipo As New frmBusGeneral7
        oTipo.oParent = Me

        oTipo.Text = "Seleccione un Rango de Autorización"
        oTipo.sQuery = "ve_tg_tipemb '" & sTipo & "','" & Trim(txtCod_TipoEmbarque.Text) & "','" & Trim(txtDes_TipoEmbarque.Text) & "'"

        oTipo.Cargar_Datos()
        If oTipo.dtResultados.Rows.Count = 1 Then
            txtCod_TipoEmbarque.Text = oTipo.dtResultados.Rows(0)("codigo")
            txtDes_TipoEmbarque.Text = oTipo.dtResultados.Rows(0)("descripcion")
            BtnBuscar.Select()
            Exit Sub
        End If

        oTipo.DGridLista.RootTable.Columns("codigo").Width = 100
        oTipo.DGridLista.RootTable.Columns("descripcion").Width = 300
        oTipo.Size = New Size(450, 358)
        oTipo.ShowDialog()

        If Codigo <> "" Then
            txtCod_TipoEmbarque.Text = Trim(Codigo)
            txtDes_TipoEmbarque.Text = Trim(Descripcion)
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

    Private Sub txtDescripcionLarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcionLarga.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtTelefono1.Focus()
        End If
    End Sub

    Private Sub txtTelefono1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtTelefono2.Focus()
        End If
    End Sub

    Private Sub txtTelefono2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            txtDireccion.Focus()
        End If
    End Sub
End Class