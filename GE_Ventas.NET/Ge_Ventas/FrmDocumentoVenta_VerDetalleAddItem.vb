Public Class FrmDocumentoVenta_VerDetalleAddItem
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private colEmpresa As Color
    Private oDT As New DataTable
    Public Codigo As String, Descripcion As String, TipoAdd As String, TipoAdd2 As String, TipoAdd3 As String

    Public oParent As Object
    Public sunidad As String

    Private Sub FrmDocumentoVenta_VerDetalleAddItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        colEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = colEmpresa
        Panel4.BackColor = colEmpresa

        Me.ActiveControl = txtDescripcion
    End Sub

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        If (Asc(e.KeyChar) = Keys.Enter) Then
            BuscaItem
        End If
    End Sub

    Public Sub BuscaItem()
        Try
            Dim oTipo As New frmBusGeneral7
            oTipo.sQuery = "VENTAS_BUSCA_ITEMS_DIVERSOS '" & Trim(txtDescripcion.Text) & "'"
            oTipo.oParent = Me
            oTipo.Cargar_Datos()
            If oTipo.dtResultados.Rows.Count = 1 Then
                txtCod_Producto.Text = Trim(oTipo.dtResultados.Rows(0)("COD_ITEM"))
                txtDescripcion.Text = Trim(oTipo.dtResultados.Rows(0)("DES_ITEM"))
                sunidad = Trim(oTipo.dtResultados.Rows(0)("COD_UNIMED"))
                BtnAceptar.Focus()
            Else
                oTipo.ShowDialog()
                If Codigo <> "" Then
                    txtCod_Producto.Text = Trim(oTipo.RegistroSeleccionado.Cells("COD_ITEM").Value)
                    txtDescripcion.Text = Trim(oTipo.RegistroSeleccionado.Cells("DES_ITEM").Value)
                    sunidad = Trim(oTipo.RegistroSeleccionado.Cells("COD_UNIMED").Value)
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
        If Trim(txtCod_Producto.Text) = "" Then
            If MessageBox.Show("¿Desea crear un nuevo Item?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Using oAdd As New FrmDocumentoVenta_VerDetalleAddItemMant
                    With oAdd
                        .oParent = Me
                        .ShowDialog()
                    End With
                End Using
            End If
        End If
        oParent.txtCod_Producto.Text = txtCod_Producto.Text
        oParent.txtDescripcion.Text = txtDescripcion.Text
        oParent.txtUnida_Medida.Text = sunidad
        Me.Close()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        If Trim(txtDescripcion.Text) = "" Or Trim(txtCod_Producto.Text) = "" Then
            If MessageBox.Show("¿Desea crear un nuevo Item?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                Using oAdd As New FrmDocumentoVenta_VerDetalleAddItemMant
                    With oAdd
                        .oParent = Me
                        .ShowDialog()
                    End With
                End Using
            Else
                Me.Close()
            End If
        Else
            Me.Close()
        End If
    End Sub
End Class