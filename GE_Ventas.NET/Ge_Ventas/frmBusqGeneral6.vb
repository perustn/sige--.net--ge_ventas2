Option Strict Off
Option Explicit On
Imports Janus.Windows.GridEX
Friend Class frmBusqGeneral6
    Inherits System.Windows.Forms.Form


    Property RegistroSeleccionado As GridEXRow

    Dim oHP As clsHELPER = New clsHELPER
    Public dtResultados As New DataTable
    Dim strSql As String
    Dim oDr As DataRow

    Public oParent As Object
    Public sQuery As String
    'Dim Rs_Carga As ADODB.Recordset
    Private Sub frmBusqGeneral_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            If DGridLista.RootTable.Columns.Count > 2 And DGridLista.RootTable.Columns.Count < 4 Then
                DGridLista.RootTable.Columns(0).Width = 100
                DGridLista.RootTable.Columns(0).Caption = "Código"
                DGridLista.RootTable.Columns(1).Width = 300
                DGridLista.RootTable.Columns(1).Caption = "Descripción"
                DGridLista.RootTable.Columns(2).Caption = "Tipo"
                DGridLista.RootTable.Columns(2).Visible = False
            ElseIf DGridLista.RootTable.Columns.Count = 2 Then
                DGridLista.RootTable.Columns(0).Width = 100
                DGridLista.RootTable.Columns(0).Caption = "Código"
                DGridLista.RootTable.Columns(1).Width = 300
                DGridLista.RootTable.Columns(1).Caption = "Descripción"
            End If
            DGridLista.Col = 1
            DGridLista.Row = DGridLista.FilterRow.Position
            DGridLista.Select()
            DGridLista.Focus()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Cargar_Datos()
        Try
            dtResultados = oHP.DevuelveDatos(sQuery, cconnect)
            DGridLista.DataSource = dtResultados
            CheckLayoutGridEx(DGridLista)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Carga Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub frmBusqGeneral_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'Rs_Carga = Nothing
    End Sub

    Private Sub DGridLista_DoubleClick(sender As Object, e As EventArgs) Handles DGridLista.DoubleClick
        Try
            If DGridLista.RowCount = 0 Then Exit Sub
            oDr = ObtenerDr_DeGridEx(DGridLista)
            If oDr Is Nothing Then Exit Sub
            With oParent
                .CODIGO = oDr(0).ToString
                If DGridLista.RootTable.Columns.Count = 2 Then
                    .DESCRIPCION = oDr(1).ToString
                End If
                If DGridLista.RootTable.Columns.Count = 3 Then
                    .DESCRIPCION = oDr(1).ToString
                    .TipoAdd = oDr(2).ToString
                End If
                If DGridLista.RootTable.Columns.Count = 4 Then
                    .DESCRIPCION = oDr(1).ToString
                    .TipoAdd = oDr(2).ToString
                    .TipoAdd2 = oDr(3).ToString
                End If
                If DGridLista.RootTable.Columns.Count = 5 Then
                    .DESCRIPCION = oDr(1).ToString
                    .TipoAdd = oDr(2).ToString
                    .TipoAdd2 = oDr(3).ToString
                    .TipoAdd3 = oDr(4).ToString
                End If
            End With

            RegistroSeleccionado = DGridLista.CurrentRow
            DialogResult = Windows.Forms.DialogResult.OK
        Catch ex As Exception
            RegistroSeleccionado = Nothing
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgListado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGridLista.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If keyascii = 13 Then
            DGridLista_DoubleClick(sender, e)
        End If

    End Sub

    Private Sub frmBusqGeneral6_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        DGridLista_DoubleClick(sender, e)
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        oParent.CODIGO = ""
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub
End Class