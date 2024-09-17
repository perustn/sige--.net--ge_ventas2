<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoEjecutivoCarga
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoEjecutivoCarga))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txtDes_AgenteCarga = New System.Windows.Forms.TextBox()
        Me.txtCod_AgenteCarga = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Bottom
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "ADICIONAR"
        BarraOpciones_Item_0_0.SmallImageIndex = 42
        BarraOpciones_Item_0_0.Text = "&Adicionar"
        BarraOpciones_Item_0_1.Image = CType(resources.GetObject("BarraOpciones_Item_0_1.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_1.Key = "MODIFICAR"
        BarraOpciones_Item_0_1.SmallImageIndex = 40
        BarraOpciones_Item_0_1.Text = "&Modificar"
        BarraOpciones_Item_0_2.Image = CType(resources.GetObject("BarraOpciones_Item_0_2.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_2.Key = "ELIMINAR"
        BarraOpciones_Item_0_2.LargeImageIndex = 17
        BarraOpciones_Item_0_2.SmallImageIndex = 39
        BarraOpciones_Item_0_2.Text = "&Eliminar"
        BarraOpciones_Item_0_3.Image = CType(resources.GetObject("BarraOpciones_Item_0_3.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_3.Key = "GRABAR"
        BarraOpciones_Item_0_3.LargeImageIndex = 22
        BarraOpciones_Item_0_3.SmallImageIndex = 45
        BarraOpciones_Item_0_3.Text = "&Grabar"
        BarraOpciones_Item_0_4.Image = CType(resources.GetObject("BarraOpciones_Item_0_4.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_4.Key = "DESHACER"
        BarraOpciones_Item_0_4.LargeImageIndex = 21
        BarraOpciones_Item_0_4.SmallImageIndex = 44
        BarraOpciones_Item_0_4.Text = "&Deshacer"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0, BarraOpciones_Item_0_1, BarraOpciones_Item_0_2, BarraOpciones_Item_0_3, BarraOpciones_Item_0_4})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 357)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(406, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 6
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txtDescripcion)
        Me.fraDatos.Controls.Add(Me.Label3)
        Me.fraDatos.Controls.Add(Me.txtCodigo)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 382)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(406, 70)
        Me.fraDatos.TabIndex = 7
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion.Location = New System.Drawing.Point(122, 36)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.Size = New System.Drawing.Size(229, 20)
        Me.txtDescripcion.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(12, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(141, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Descripción ........................."
        '
        'txtCodigo
        '
        Me.txtCodigo.AcceptsReturn = True
        Me.txtCodigo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo.Location = New System.Drawing.Point(122, 10)
        Me.txtCodigo.MaxLength = 4
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(115, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo ........................"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.BtnBuscar)
        Me.Panel2.Controls.Add(Me.txtDes_AgenteCarga)
        Me.Panel2.Controls.Add(Me.txtCod_AgenteCarga)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 40)
        Me.Panel2.TabIndex = 4
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageIndex = 12
        Me.BtnBuscar.Location = New System.Drawing.Point(303, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(94, 29)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "&Realizar Búsqueda"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtDes_AgenteCarga
        '
        Me.txtDes_AgenteCarga.AcceptsReturn = True
        Me.txtDes_AgenteCarga.BackColor = System.Drawing.Color.White
        Me.txtDes_AgenteCarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_AgenteCarga.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDes_AgenteCarga.Location = New System.Drawing.Point(134, 10)
        Me.txtDes_AgenteCarga.MaxLength = 0
        Me.txtDes_AgenteCarga.Name = "txtDes_AgenteCarga"
        Me.txtDes_AgenteCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_AgenteCarga.Size = New System.Drawing.Size(160, 20)
        Me.txtDes_AgenteCarga.TabIndex = 3
        '
        'txtCod_AgenteCarga
        '
        Me.txtCod_AgenteCarga.AcceptsReturn = True
        Me.txtCod_AgenteCarga.BackColor = System.Drawing.Color.White
        Me.txtCod_AgenteCarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_AgenteCarga.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_AgenteCarga.Location = New System.Drawing.Point(94, 10)
        Me.txtCod_AgenteCarga.MaxLength = 0
        Me.txtCod_AgenteCarga.Name = "txtCod_AgenteCarga"
        Me.txtCod_AgenteCarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_AgenteCarga.Size = New System.Drawing.Size(38, 20)
        Me.txtCod_AgenteCarga.TabIndex = 2
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(7, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(84, 12)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "AGENTE CARGA"
        '
        'GrdMntTest
        '
        Me.GrdMntTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdMntTest.AlternatingColors = True
        GrdMntTest_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GrdMntTest.DesignTimeLayout = GrdMntTest_DesignTimeLayout
        Me.GrdMntTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdMntTest.GroupByBoxVisible = False
        Me.GrdMntTest.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GrdMntTest.Location = New System.Drawing.Point(0, 40)
        Me.GrdMntTest.Name = "GrdMntTest"
        Me.GrdMntTest.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdMntTest.RecordNavigator = True
        Me.GrdMntTest.Size = New System.Drawing.Size(406, 317)
        Me.GrdMntTest.TabIndex = 214
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmMantenimientoEjecutivoCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 452)
        Me.Controls.Add(Me.GrdMntTest)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantenimientoEjecutivoCarga"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Ejecutivo Carga"
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As Panel
    Public WithEvents txtDescripcion As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtCodigo As TextBox
    Public WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Public WithEvents txtDes_AgenteCarga As TextBox
    Public WithEvents txtCod_AgenteCarga As TextBox
    Public WithEvents Label37 As Label
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
End Class
