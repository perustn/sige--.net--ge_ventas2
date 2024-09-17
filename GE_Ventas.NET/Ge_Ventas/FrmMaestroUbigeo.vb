Public Class FrmMaestroUbigeo
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String

    Public Cod_Ubigeo As String
    Public oParent As Object

    Private Sub FrmMaestroUbigeo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        If Len(Trim(Cod_Ubigeo)) = 6 Then
            txtCod_Depar.Text = Mid(Cod_Ubigeo, 1, 2)
            txtCod_Prov.Text = Mid(Cod_Ubigeo, 3, 2)
            txtCod_Dist.Text = Mid(Cod_Ubigeo, 5, 2)
            BuscaDepar(1)
            BuscaDist(1)
            BuscaProv(1)
        End If

        Me.ActiveControl = txtCod_Depar
    End Sub

    Private Sub txtCod_Depar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Depar.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaDepar(1)
        End If
    End Sub

    Private Sub txtDes_Depar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Depar.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaDepar(2)
        End If
    End Sub

    Private Sub BuscaDepar(Opcion As Integer)
        Try
            strSQL = "SELECT cod_departamento, descripcion FROM tg_ubigeo WHERE "
            Select Case Opcion
                Case 1 : strSQL = strSQL & "cod_ubigeo LIKE '%" & Trim(txtCod_Depar.Text) & "0000%'"
                Case 2 : strSQL = strSQL & "descripcion LIKE '%" & txtDes_Depar.Text & "%'"
            End Select

            Dim oTipo As New frmBusqGeneral6
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod_Depar.Text = Trim(oTipo.dtResultados.Rows(0)("cod_departamento"))
                txtDes_Depar.Text = Trim(oTipo.dtResultados.Rows(0)("descripcion"))
                txtCod_Prov.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod_Depar.Text = Trim(oTipo.RegistroSeleccionado.Cells("cod_departamento").Value)
                    txtDes_Depar.Text = Trim(oTipo.RegistroSeleccionado.Cells("descripcion").Value)
                    txtCod_Prov.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCod_Prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Prov.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaProv(1)
        End If
    End Sub

    Private Sub txtDes_Prov_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Prov.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaProv(2)
        End If
    End Sub

    Private Sub BuscaProv(Opcion As Integer)
        Try
            strSQL = "select Cod_Provincia, descripcion from tg_ubigeo where cod_departamento = '" & Trim(txtCod_Depar.Text) & "' and Cod_Provincia != '00' and  substring(Cod_Ubigeo,5,2) = '00'  and "
            Select Case Opcion
                Case 1 : strSQL = strSQL & "cod_provincia like  '%" & Trim(txtCod_Prov.Text) & "%'"
                Case 2 : strSQL = strSQL & "descripcion LIKE '%" & txtDes_Prov.Text & "%'"
            End Select

            Dim oTipo As New frmBusqGeneral6
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod_Prov.Text = Trim(oTipo.dtResultados.Rows(0)("Cod_Provincia"))
                txtDes_Prov.Text = Trim(oTipo.dtResultados.Rows(0)("descripcion"))
                txtCod_Dist.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod_Prov.Text = Trim(oTipo.RegistroSeleccionado.Cells("Cod_Provincia").Value)
                    txtDes_Prov.Text = Trim(oTipo.RegistroSeleccionado.Cells("descripcion").Value)
                    txtCod_Dist.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtCod_Dist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCod_Dist.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaDist(1)
        End If
    End Sub

    Private Sub txtDes_Dist_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDes_Dist.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaDist(2)
        End If
    End Sub

    Private Sub BuscaDist(Opcion As Integer)
        Try
            strSQL = "select substring(cod_ubigeo,5,2) Codigo , Descripcion from TG_Ubigeo where Cod_Departamento = '" & Trim(txtCod_Depar.Text) & "' and Cod_Provincia != '00' and substring(Cod_Ubigeo,5,2) != '00' and Cod_Provincia = '" & Trim(txtCod_Prov.Text) & "' and "
            Select Case Opcion
                Case 1 : strSQL = strSQL & "substring(Cod_Ubigeo,5,2) like '%" & Trim(txtCod_Dist.Text) & "%'"
                Case 2 : strSQL = strSQL & "descripcion LIKE '%" & txtDes_Dist.Text & "%'"
            End Select

            Dim oTipo As New frmBusqGeneral6
            oTipo.sQuery = strSQL
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod_Dist.Text = Trim(oTipo.dtResultados.Rows(0)("Codigo"))
                txtDes_Dist.Text = Trim(oTipo.dtResultados.Rows(0)("Descripcion"))
                BtnAceptar.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod_Dist.Text = Trim(oTipo.RegistroSeleccionado.Cells("Codigo").Value)
                    txtDes_Dist.Text = Trim(oTipo.RegistroSeleccionado.Cells("Descripcion").Value)
                    BtnAceptar.Focus()
                End If
            End If
            Codigo = "" : Descripcion = "" : TipoAdd = ""
            oTipo = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BtnAceptar_Click(sender As Object, e As EventArgs) Handles BtnAceptar.Click
        If Len(txtCod_Depar.Text & txtCod_Prov.Text & txtCod_Dist.Text) = 6 Then
            oParent.Cod_Ubigeo = txtCod_Depar.Text & txtCod_Prov.Text & txtCod_Dist.Text
        Else
            Exit Sub
        End If
        DialogResult = DialogResult.OK
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If Len(Cod_Ubigeo) = 6 Then
            oParent.Cod_Ubigeo = Cod_Ubigeo
        Else
            oParent.Cod_Ubigeo = ""
        End If
        DialogResult = DialogResult.Cancel
    End Sub
End Class