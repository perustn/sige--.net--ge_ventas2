Option Strict Off
Option Explicit On
Imports Janus.Windows.GridEX
Friend Class frmBusqGeneral4
    Inherits System.Windows.Forms.Form

    Public dtResultados As DataTable
    Public oParent As Object
    Public sQuery As String

    Private oHP As New clsHELPER
    Private strSql As String
    Private oDr As DataRow


    Private Sub frmBusqGeneral_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Try
            If DGridLista.RootTable.Columns.Count > 2 Then
                DGridLista.RootTable.Columns(0).Width = 100
                DGridLista.RootTable.Columns(0).Caption = "Código"
                DGridLista.RootTable.Columns(1).Width = 280
                DGridLista.RootTable.Columns(1).Caption = "Descripción"
                DGridLista.RootTable.Columns(2).Caption = "Tipo"
                DGridLista.RootTable.Columns(2).Visible = False
            Else
                DGridLista.RootTable.Columns(0).Width = 100
                DGridLista.RootTable.Columns(0).Caption = "Código"
                DGridLista.RootTable.Columns(1).Width = 280
                DGridLista.RootTable.Columns(1).Caption = "Descripción"
            End If
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


    Private Sub DGridLista_DoubleClick(sender As Object, e As EventArgs) Handles DGridLista.DoubleClick
        Try
            BtnAceptar_Click(BtnAceptar, New EventArgs)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub dgListado_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DGridLista.KeyPress
        Dim keyascii As Short = Asc(e.KeyChar)
        If keyascii = 13 Then
            DGridLista_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub frmBusqGeneral4_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
        If (e.KeyCode = Keys.Escape) Then
            Me.Close()
        End If
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If DGridLista.RowCount = 0 Then Return
        With oParent
            .CODIGO = DGridLista.CurrentRow.Cells(0).Value
            .DESCRIPCION = DGridLista.CurrentRow.Cells(1).Value
            If DGridLista.RootTable.Columns.Count = 3 Then
                .TipoAdd = DGridLista.CurrentRow.Cells(2).Value
            End If
        End With
        DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        oParent.CODIGO = ""
        DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

End Class