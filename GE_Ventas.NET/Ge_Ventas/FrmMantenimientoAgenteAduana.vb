Imports Janus.Windows.GridEX
Public Class FrmMantenimientoAgenteAduana
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Public sRuc_CfEmpTrn As String

    Public Codigo As Object
    Public Descripcion, TipoAdd, TipoAdd2 As String
    Private Sub FrmMantenimientoModoEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_GRID()
    End Sub
    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC TG_MUESTRA_AGENTEADUANA"


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
                    .Width = 80
                End With

                With .Columns("DESCRIPCION")
                    .Width = 150
                End With

                With .Columns("CONTACTO")
                    .Width = 150
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
                    Me.txtDescripcion.Focus()
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
                    Me.txtDescripcion.Focus()
                    With BarraOpciones.Groups(0)
                        .Items("ADICIONAR").Enabled = False
                        .Items("ELIMINAR").Enabled = False
                        .Items("GRABAR").Enabled = True
                        .Items("DESHACER").Enabled = True
                    End With

                Case "ELIMINAR"
                    If GrdMntTest.RowCount = 0 Then Exit Sub
                    MessageBox.Show("Opcion inhabilitada", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
        txtContacto.Enabled = Activar
        GrdMntTest.Enabled = Not Activar
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
        txtContacto.Text = String.Empty
    End Sub
    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC AS_Man_AGENTE_ADUANA"
            strSQL &= vbNewLine & String.Format(" @Accion                   = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@Cod_AgenteAduana         = '{0}'", txtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@Nom_AgenteAduana         = '{0}'", txtDescripcion.Text)
            strSQL &= vbNewLine & String.Format(",@contacto_AlmacenAduana   = '{0}'", txtContacto.Text)

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
                txtDescripcion.Text = dr("DESCRIPCION").ToString
                txtContacto.Text = dr("CONTACTO").ToString
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            txtContacto.Focus()
        End If
    End Sub
End Class