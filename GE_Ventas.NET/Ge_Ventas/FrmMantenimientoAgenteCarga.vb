Imports Janus.Windows.GridEX
Public Class FrmMantenimientoAgenteCarga
    Private strSQL As String = String.Empty
    Private oDT As New DataTable
    Private oHP As New clsHELPER
    Private OpcionMantenimiento As String
    Public sRuc_CfEmpTrn As String

    Private Sub FrmMantenimientoModoEmbarque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CARGA_GRID()
    End Sub

    Private Sub CARGA_GRID()

        strSQL = String.Empty
        strSQL &= vbNewLine & "EXEC TG_MUESTRA_AGENTECARGA"
        'strSQL &= vbNewLine & String.Format(" @ACCION        = '{0}'", "S")
        'strSQL &= vbNewLine & String.Format(",@Ruc_CfEmpTrn  = '{0}'", sRuc_CfEmpTrn)

        oDT = oHP.DevuelveDatos(strSQL, cCONNECT)
        GrdMntTest.DataSource = oDT
        CheckLayoutGridEx(GrdMntTest)

        With GrdMntTest
            With .RootTable
                .HeaderLines = 2
                .RowHeight = 30
                .PreviewRow = True
                .PreviewRowLines = 15
                .HeaderLines = 3
                .PreviewRowMember = "COMENTARIOS"

                For Each oGridEXColumn As GridEXColumn In .Columns
                    With oGridEXColumn
                        .WordWrap = True
                        .Visible = True
                        .FilterEditType = FilterEditType.Combo
                    End With
                Next

                With .Columns("COD_AGENTECARGA")
                    .Caption = "CODIGO AGENTE CARGA"
                    .Width = 70
                End With

                With .Columns("DESCRIPCION")
                    .Width = 170
                End With

                With .Columns("FLG_COURIER")
                    .Caption = "FLG COURIER"
                    .Width = 60
                End With

                With .Columns("FLG_CARGA")
                    .Caption = "FLG CARGA"
                    .Width = 60
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
        'txtCodigo_Embarque.Enabled = Activar
    End Sub
    Public Sub LIMPIA_DATOS()
        txtCodigo.Text = String.Empty
        txtDescripcion.Text = String.Empty
    End Sub
    Sub SALVAR_DATOS()
        Try
            strSQL = String.Empty
            strSQL &= vbNewLine & "EXEC AS_MAN_AGENTE_CARGA"
            strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", OpcionMantenimiento)
            strSQL &= vbNewLine & String.Format(",@Cod_AgenteCarga  = '{0}'", txtCodigo.Text)
            strSQL &= vbNewLine & String.Format(",@Des_AgenteCarga  = '{0}'", txtDescripcion.Text)
            strSQL &= vbNewLine & String.Format(",@FlgCourier       = '{0}'", IIf(chkCurrier.Checked, "S", "N"))
            strSQL &= vbNewLine & String.Format(",@FlgCarga         = '{0}'", IIf(chkCarga.Checked, "S", "N"))

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
                Me.txtCodigo.Text = dr("COD_AGENTECARGA").ToString
                Me.txtDescripcion.Text = dr("DESCRIPCION").ToString

                If Trim(dr("FLG_COURIER")) = "S" Then
                    chkCurrier.Checked = True
                Else
                    chkCurrier.Checked = False
                End If

                If Trim(dr("FLG_CARGA")) = "S" Then
                    chkCarga.Checked = True
                Else
                    chkCarga.Checked = False
                End If
            End If
        Else
            Call LIMPIA_DATOS()
        End If
    End Sub
End Class