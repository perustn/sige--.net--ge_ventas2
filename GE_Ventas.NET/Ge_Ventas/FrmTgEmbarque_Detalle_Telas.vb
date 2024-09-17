Imports Janus.Windows.GridEX
Public Class FrmTgEmbarque_Detalle_Telas
    Public sNum_Embarque As String
    Private strSQL As String = String.Empty
    Private oHP As New clsHELPER
    Private oDT As New DataTable
    Private ColEmpresa As Color

    Private Sub FrmTgEmbarque_Detalle_Telas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oDt As DataTable = oHP.DevuelveDatos(String.Format("SELECT * FROM SEG_Empresas where cod_empresa = '{0}'", vemp), cSEGURIDAD)
        ColEmpresa = Color.FromArgb(oDt.Rows(0)("ColorFondo_R"), oDt.Rows(0)("ColorFondo_G"), oDt.Rows(0)("ColorFondo_B"))
        Panel2.BackColor = ColEmpresa
        CargaDatos()
    End Sub

    Sub CargaDatos()
        Try
            strSQL = String.Empty
            strSQL = "EXEC TG_EMBARQUES_TELAS_MUESTRA "
            strSQL &= vbNewLine & String.Format(" @NUM_EMBARQUE		= '{0}'", sNum_Embarque)

            GridEX1.RootTable.Columns.Clear()
            oDT = oHP.DevuelveDatos(strSQL, cCONNECT, True)
            GridEX1.DataSource = oDT
            CheckLayoutGridEx(GridEX1)

            With GridEX1
                .FilterMode = FilterMode.Automatic
                .DefaultFilterRowComparison = FilterConditionOperator.Contains

                With .RootTable
                    .RowHeight = 30
                    .PreviewRow = True
                    .PreviewRowMember = "Observacion"
                    .PreviewRowLines = 4

                    For Each oGridEXColumn As GridEXColumn In .Columns
                        With oGridEXColumn
                            .WordWrap = True
                            .FilterEditType = FilterEditType.Combo
                        End With
                    Next

                    .Columns("CLAVE").Visible = False
                    .Columns("NUM_EMBARQUE").Visible = False
                    .Columns("UNI_MED").Visible = False

                    With .Columns("SEC_EMBARQUE")
                        .Caption = "SEC"
                        .TextAlignment = TextAlignment.Center
                        .Width = 40
                    End With

                    With .Columns("COD_TELA")
                        .Caption = "TELA"
                        .Width = 80
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("DES_TELA")
                        .Caption = "DESCRIPCION"
                        .Width = 180
                    End With

                    With .Columns("COD_COMB")
                        .Caption = "COD"
                        .Width = 50
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("DES_COMB")
                        .Caption = "COMBO"
                        .Width = 100
                    End With

                    With .Columns("COD_COLOR")
                        .Caption = "COD COLOR"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("DES_COLOR")
                        .Caption = "COLOR"
                        .Width = 100
                    End With

                    With .Columns("COD_TALLA")
                        .Caption = "TALLA"
                        .Width = 60
                    End With

                    With .Columns("COD_CALIDAD")
                        .Caption = "CALIDAD"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With

                    With .Columns("DES_UNIMED")
                        .Caption = "UNIDAD MEDIDA"
                        .Width = 70
                        .TextAlignment = TextAlignment.Center
                    End With
                End With
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub BarraOpciones_ItemClick(sender As Object, e As Janus.Windows.ButtonBar.ItemEventArgs) Handles BarraOpciones.ItemClick
        Try
            Select Case e.Item.Key
                Case "ADICIONAR"
                    Call Adicionar("I")

                Case "MODIFICAR"
                    Dim FilaSeleccionada As Integer
                    FilaSeleccionada = GridEX1.CurrentRow.Position
                    Call Adicionar("U")
                    GridEX1.Row = FilaSeleccionada

                Case "ELIMINAR"
                    Call Eliminar

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Sub Eliminar()
        Try
            If (MessageBox.Show("¿Seguro de eliminar registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then

                strSQL = "EXEC TG_Embarque_Telas_man"
                strSQL &= vbNewLine & String.Format(" @Accion           = '{0}'", "D")
                strSQL &= vbNewLine & String.Format(",@num_embarque     =  {0} ", sNum_Embarque)
                strSQL &= vbNewLine & String.Format(",@Sec_Embarque     =  {0} ", GridEX1.GetValue(GridEX1.RootTable.Columns("Sec_Embarque").Index))
                strSQL &= vbNewLine & String.Format(",@Cod_Tela		    = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Cod_Comb         = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Cod_Color        = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Uni_Med          = '{0}'", "")
                strSQL &= vbNewLine & String.Format(",@Peso_Bruto_Prog	=  {0} ", 0)
                strSQL &= vbNewLine & String.Format(",@Peso_Neto_Prog   =  {0} ", 0)
                strSQL &= vbNewLine & String.Format(",@Rollos_Prog      =  {0} ", 0)
                strSQL &= vbNewLine & String.Format(",@Cubicaje_Prog    =  {0} ", 0)
                strSQL &= vbNewLine & String.Format(",@Kgs_Prog		    =  {0} ", 0)
                strSQL &= vbNewLine & String.Format(",@Unidades_Prog    =  {0} ", 0)

                If oHP.EjecutaOperacion(strSQL, cCONNECT) Then
                    MessageBox.Show("Se Elimino Correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    CargaDatos()
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Adicionar(sAccion As String)
        Dim Frm As New FrmTgEmbarque_Detalle_Telas_EmbarqueTelas
        With Frm
            .sAccion = sAccion
            .sNum_Embarque = sNum_Embarque
            .TxtNroEmbarque.Text = TxtNroEmbarque.Text
            If sAccion = "U" Then
                If GridEX1.RowCount = 0 Then Exit Sub
                .LabelSec.Visible = True
                .TxtSec.Visible = True
                .TxtSec.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Sec_Embarque").Index)
                .sSec_Embarque = GridEX1.GetValue(GridEX1.RootTable.Columns("Sec_Embarque").Index)
                .txtCodTela.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_tela").Index)
                .txtDesTela.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_tela").Index)
                .txtCodComb.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_comb").Index)
                .txtDesComb.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_comb").Index)
                .txtCodColor.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("cod_color").Index)
                .txtDesColor.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("des_color").Index)
                .txtCodUniMedida.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Uni_Med").Index)
                .txtDesUniMedida.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Des_UniMed").Index)
                .txtPeso_Bruto_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Bruto_Prog").Index)
                .txtPeso_Neto_Prog.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Peso_Neto_Prog").Index)
                .txtRollosProg.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Rollos_Prog").Index)
                .txtUbicajeProg.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Cubicaje_Prog").Index)
                .txtKgsProg.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Kgs_Prog").Index)
                .txtUnidadesProg.Text = GridEX1.GetValue(GridEX1.RootTable.Columns("Unidades_Prog").Index)


                'clave = GridEX1.Value(GridEX1.Columns("clave").Index)
                'fnuevo = GridEX1.Find(GridEX1.Columns("clave").Index, jgexGreaterThanOrEqualTo, clave)                        
            End If

            If .ShowDialog = DialogResult.OK Then
                CargaDatos()
            End If
        End With
    End Sub
End Class