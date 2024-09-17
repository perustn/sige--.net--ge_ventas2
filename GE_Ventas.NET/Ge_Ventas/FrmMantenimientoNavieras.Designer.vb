<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoNavieras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoNavieras))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtTelefono2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTelefono1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcionCorta = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDescripcionLarga = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo_Embarque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txtDes_TipoEmbarque = New System.Windows.Forms.TextBox()
        Me.txtCod_TipoEmbarque = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        Me.Panel1.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GrdMntTest)
        Me.Panel1.Controls.Add(Me.BarraOpciones)
        Me.Panel1.Controls.Add(Me.fraDatos)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 539)
        Me.Panel1.TabIndex = 0
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
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 405)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(800, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 211
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txtTelefono2)
        Me.fraDatos.Controls.Add(Me.Label6)
        Me.fraDatos.Controls.Add(Me.txtTelefono1)
        Me.fraDatos.Controls.Add(Me.Label5)
        Me.fraDatos.Controls.Add(Me.txtDireccion)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Controls.Add(Me.txtDescripcionCorta)
        Me.fraDatos.Controls.Add(Me.Label3)
        Me.fraDatos.Controls.Add(Me.txtDescripcionLarga)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.txtCodigo_Embarque)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 430)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(800, 109)
        Me.fraDatos.TabIndex = 210
        '
        'txtTelefono2
        '
        Me.txtTelefono2.AcceptsReturn = True
        Me.txtTelefono2.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono2.Enabled = False
        Me.txtTelefono2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono2.Location = New System.Drawing.Point(562, 83)
        Me.txtTelefono2.MaxLength = 50
        Me.txtTelefono2.Name = "txtTelefono2"
        Me.txtTelefono2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelefono2.Size = New System.Drawing.Size(227, 20)
        Me.txtTelefono2.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(452, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(133, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Telefono 2........................."
        '
        'txtTelefono1
        '
        Me.txtTelefono1.AcceptsReturn = True
        Me.txtTelefono1.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefono1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTelefono1.Enabled = False
        Me.txtTelefono1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTelefono1.Location = New System.Drawing.Point(562, 55)
        Me.txtTelefono1.MaxLength = 50
        Me.txtTelefono1.Name = "txtTelefono1"
        Me.txtTelefono1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTelefono1.Size = New System.Drawing.Size(227, 20)
        Me.txtTelefono1.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(452, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Telefono 1........................."
        '
        'txtDireccion
        '
        Me.txtDireccion.AcceptsReturn = True
        Me.txtDireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDireccion.Location = New System.Drawing.Point(122, 55)
        Me.txtDireccion.MaxLength = 50
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDireccion.Size = New System.Drawing.Size(308, 48)
        Me.txtDireccion.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Dirección........................."
        '
        'txtDescripcionCorta
        '
        Me.txtDescripcionCorta.AcceptsReturn = True
        Me.txtDescripcionCorta.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionCorta.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcionCorta.Enabled = False
        Me.txtDescripcionCorta.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcionCorta.Location = New System.Drawing.Point(562, 7)
        Me.txtDescripcionCorta.MaxLength = 50
        Me.txtDescripcionCorta.Name = "txtDescripcionCorta"
        Me.txtDescripcionCorta.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcionCorta.Size = New System.Drawing.Size(227, 20)
        Me.txtDescripcionCorta.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(452, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(166, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Descripción Corta........................."
        '
        'txtDescripcionLarga
        '
        Me.txtDescripcionLarga.AcceptsReturn = True
        Me.txtDescripcionLarga.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionLarga.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcionLarga.Enabled = False
        Me.txtDescripcionLarga.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcionLarga.Location = New System.Drawing.Point(122, 31)
        Me.txtDescripcionLarga.MaxLength = 50
        Me.txtDescripcionLarga.Name = "txtDescripcionLarga"
        Me.txtDescripcionLarga.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcionLarga.Size = New System.Drawing.Size(667, 20)
        Me.txtDescripcionLarga.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(168, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción Larga........................."
        '
        'txtCodigo_Embarque
        '
        Me.txtCodigo_Embarque.AcceptsReturn = True
        Me.txtCodigo_Embarque.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigo_Embarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCodigo_Embarque.Enabled = False
        Me.txtCodigo_Embarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCodigo_Embarque.Location = New System.Drawing.Point(122, 7)
        Me.txtCodigo_Embarque.MaxLength = 4
        Me.txtCodigo_Embarque.Name = "txtCodigo_Embarque"
        Me.txtCodigo_Embarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCodigo_Embarque.Size = New System.Drawing.Size(74, 20)
        Me.txtCodigo_Embarque.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Codigo Embarque.................."
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.BtnBuscar)
        Me.Panel2.Controls.Add(Me.txtDes_TipoEmbarque)
        Me.Panel2.Controls.Add(Me.txtCod_TipoEmbarque)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(800, 40)
        Me.Panel2.TabIndex = 209
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageIndex = 12
        Me.BtnBuscar.Location = New System.Drawing.Point(650, 5)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(135, 29)
        Me.BtnBuscar.TabIndex = 88
        Me.BtnBuscar.Text = "&Realizar Búsqueda"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtDes_TipoEmbarque
        '
        Me.txtDes_TipoEmbarque.AcceptsReturn = True
        Me.txtDes_TipoEmbarque.BackColor = System.Drawing.Color.White
        Me.txtDes_TipoEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_TipoEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDes_TipoEmbarque.Location = New System.Drawing.Point(223, 10)
        Me.txtDes_TipoEmbarque.MaxLength = 0
        Me.txtDes_TipoEmbarque.Name = "txtDes_TipoEmbarque"
        Me.txtDes_TipoEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_TipoEmbarque.Size = New System.Drawing.Size(242, 20)
        Me.txtDes_TipoEmbarque.TabIndex = 87
        '
        'txtCod_TipoEmbarque
        '
        Me.txtCod_TipoEmbarque.AcceptsReturn = True
        Me.txtCod_TipoEmbarque.BackColor = System.Drawing.Color.White
        Me.txtCod_TipoEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_TipoEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_TipoEmbarque.Location = New System.Drawing.Point(137, 10)
        Me.txtCod_TipoEmbarque.MaxLength = 0
        Me.txtCod_TipoEmbarque.Name = "txtCod_TipoEmbarque"
        Me.txtCod_TipoEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_TipoEmbarque.Size = New System.Drawing.Size(84, 20)
        Me.txtCod_TipoEmbarque.TabIndex = 86
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(30, 14)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(91, 12)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "TIPO EMBARQUE"
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
        Me.GrdMntTest.Size = New System.Drawing.Size(800, 365)
        Me.GrdMntTest.TabIndex = 213
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmMantenimientoNavieras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 539)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantenimientoNavieras"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Naviera"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Public WithEvents txtCod_TipoEmbarque As TextBox
    Public WithEvents Label37 As Label
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As Panel
    Public WithEvents txtDescripcionLarga As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtCodigo_Embarque As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents txtDes_TipoEmbarque As TextBox
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Public WithEvents txtDireccion As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtDescripcionCorta As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtTelefono2 As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtTelefono1 As TextBox
    Public WithEvents Label5 As Label
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
End Class
