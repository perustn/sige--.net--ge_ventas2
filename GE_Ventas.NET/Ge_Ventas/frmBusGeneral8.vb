Option Strict Off
Option Explicit On
Friend Class frmBusGeneral8

	Inherits System.Windows.Forms.Form

	Public dtResultados As DataTable
	Public oParent As Object
	Public sQuery As String

	Private oHP As New clsHELPER
	Private strSql As String
	Private oDr As DataRow


	Private Sub frmBusGeneral7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Try
			DGridLista.Select()
			DGridLista.Focus()
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Carga Datos", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Sub Cargar_Datos()
		Try
			dtResultados = oHP.DevuelveDatos(sQuery, cCONNECT)
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

	Private Sub frmBusGeneral7_KeyUp(sender As Object, e As KeyEventArgs) Handles MyBase.KeyUp
		If (e.KeyCode = Keys.Escape) Then
			Me.Close()
		End If
	End Sub

	Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
		Try
			If DGridLista.RowCount = 0 Then Exit Sub
			oDr = ObtenerDr_DeGridEx(DGridLista)
			With oParent
				.CODIGO = oDr(0).ToString
				.DESCRIPCION = oDr(1).ToString
				If DGridLista.RootTable.Columns.Count = 3 Then
					.TipoAdd = oDr(2).ToString
				End If
				If DGridLista.RootTable.Columns.Count = 4 Then
					.TipoAdd = oDr(2).ToString
					.TipoAdd2 = oDr(3).ToString
				End If
				If DGridLista.RootTable.Columns.Count > 4 Then
					.TipoAdd = oDr(2).ToString
					.TipoAdd2 = oDr(3).ToString
				End If
			End With
			DialogResult = Windows.Forms.DialogResult.OK
		Catch ex As Exception
			MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
		End Try
	End Sub

	Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
		oParent.CODIGO = ""
		DialogResult = Windows.Forms.DialogResult.Cancel
	End Sub
End Class