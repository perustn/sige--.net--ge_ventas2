<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_AddMantAnexosDireccion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVenta_AddMantAnexosDireccion))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtAnexoContable = New System.Windows.Forms.TextBox()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtCod_Via = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCod_Dir = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        Me.txtDes_Via = New System.Windows.Forms.TextBox()
        Me.txtNom_Via = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNum_Dom = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNum_Int = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDes_Zon = New System.Windows.Forms.TextBox()
        Me.txtCod_Zon = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCod_Ubigeo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtNom_Zon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CmdCodUbigeo = New Janus.Windows.EditControls.UIButton()
        Me.ChkDefault = New Janus.Windows.EditControls.UICheckBox()
        Me.Panel4.SuspendLayout()
        Me.fraDatos.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtAnexoContable)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(574, 30)
        Me.Panel4.TabIndex = 255
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(98, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "ANEXO CONTABLE"
        '
        'TxtAnexoContable
        '
        Me.TxtAnexoContable.AcceptsReturn = True
        Me.TxtAnexoContable.BackColor = System.Drawing.Color.LightCyan
        Me.TxtAnexoContable.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtAnexoContable.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtAnexoContable.Location = New System.Drawing.Point(116, 5)
        Me.TxtAnexoContable.MaxLength = 0
        Me.TxtAnexoContable.Name = "TxtAnexoContable"
        Me.TxtAnexoContable.ReadOnly = True
        Me.TxtAnexoContable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtAnexoContable.Size = New System.Drawing.Size(364, 20)
        Me.TxtAnexoContable.TabIndex = 121
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.ChkDefault)
        Me.fraDatos.Controls.Add(Me.CmdCodUbigeo)
        Me.fraDatos.Controls.Add(Me.txtCod_Ubigeo)
        Me.fraDatos.Controls.Add(Me.Label8)
        Me.fraDatos.Controls.Add(Me.txtNom_Zon)
        Me.fraDatos.Controls.Add(Me.Label9)
        Me.fraDatos.Controls.Add(Me.txtDes_Zon)
        Me.fraDatos.Controls.Add(Me.txtCod_Zon)
        Me.fraDatos.Controls.Add(Me.Label7)
        Me.fraDatos.Controls.Add(Me.txtNum_Int)
        Me.fraDatos.Controls.Add(Me.Label6)
        Me.fraDatos.Controls.Add(Me.txtNum_Dom)
        Me.fraDatos.Controls.Add(Me.Label5)
        Me.fraDatos.Controls.Add(Me.txtNom_Via)
        Me.fraDatos.Controls.Add(Me.Label4)
        Me.fraDatos.Controls.Add(Me.txtDes_Via)
        Me.fraDatos.Controls.Add(Me.txtCod_Via)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.txtCod_Dir)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 307)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(574, 176)
        Me.fraDatos.TabIndex = 256
        '
        'txtCod_Via
        '
        Me.txtCod_Via.AcceptsReturn = True
        Me.txtCod_Via.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Via.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Via.Enabled = False
        Me.txtCod_Via.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Via.Location = New System.Drawing.Point(122, 30)
        Me.txtCod_Via.MaxLength = 50
        Me.txtCod_Via.Name = "txtCod_Via"
        Me.txtCod_Via.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Via.Size = New System.Drawing.Size(74, 20)
        Me.txtCod_Via.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(12, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Vía ................................."
        '
        'txtCod_Dir
        '
        Me.txtCod_Dir.AcceptsReturn = True
        Me.txtCod_Dir.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Dir.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Dir.Enabled = False
        Me.txtCod_Dir.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Dir.Location = New System.Drawing.Point(122, 7)
        Me.txtCod_Dir.MaxLength = 4
        Me.txtCod_Dir.Name = "txtCod_Dir"
        Me.txtCod_Dir.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Dir.Size = New System.Drawing.Size(74, 20)
        Me.txtCod_Dir.TabIndex = 7
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
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Código ..........................."
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
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 282)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(574, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 257
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'GrdMntTest
        '
        Me.GrdMntTest.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GrdMntTest.AlternatingColors = True
        GrdMntTest_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GrdMntTest.DesignTimeLayout = GrdMntTest_DesignTimeLayout
        Me.GrdMntTest.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdMntTest.GroupByBoxVisible = False
        Me.GrdMntTest.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GrdMntTest.Location = New System.Drawing.Point(0, 30)
        Me.GrdMntTest.Name = "GrdMntTest"
        Me.GrdMntTest.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdMntTest.RecordNavigator = True
        Me.GrdMntTest.Size = New System.Drawing.Size(574, 252)
        Me.GrdMntTest.TabIndex = 258
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'txtDes_Via
        '
        Me.txtDes_Via.AcceptsReturn = True
        Me.txtDes_Via.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Via.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Via.Enabled = False
        Me.txtDes_Via.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDes_Via.Location = New System.Drawing.Point(197, 30)
        Me.txtDes_Via.MaxLength = 50
        Me.txtDes_Via.Name = "txtDes_Via"
        Me.txtDes_Via.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Via.Size = New System.Drawing.Size(363, 20)
        Me.txtDes_Via.TabIndex = 13
        '
        'txtNom_Via
        '
        Me.txtNom_Via.AcceptsReturn = True
        Me.txtNom_Via.BackColor = System.Drawing.SystemColors.Window
        Me.txtNom_Via.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom_Via.Enabled = False
        Me.txtNom_Via.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNom_Via.Location = New System.Drawing.Point(122, 53)
        Me.txtNom_Via.MaxLength = 50
        Me.txtNom_Via.Name = "txtNom_Via"
        Me.txtNom_Via.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNom_Via.Size = New System.Drawing.Size(438, 20)
        Me.txtNom_Via.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(12, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(124, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Nombre Vía ..................."
        '
        'txtNum_Dom
        '
        Me.txtNum_Dom.AcceptsReturn = True
        Me.txtNum_Dom.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Dom.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Dom.Enabled = False
        Me.txtNum_Dom.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum_Dom.Location = New System.Drawing.Point(122, 76)
        Me.txtNum_Dom.MaxLength = 50
        Me.txtNum_Dom.Name = "txtNum_Dom"
        Me.txtNum_Dom.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Dom.Size = New System.Drawing.Size(74, 20)
        Me.txtNum_Dom.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(12, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(128, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Número Domicilio ............"
        '
        'txtNum_Int
        '
        Me.txtNum_Int.AcceptsReturn = True
        Me.txtNum_Int.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Int.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Int.Enabled = False
        Me.txtNum_Int.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum_Int.Location = New System.Drawing.Point(354, 76)
        Me.txtNum_Int.MaxLength = 50
        Me.txtNum_Int.Name = "txtNum_Int"
        Me.txtNum_Int.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Int.Size = New System.Drawing.Size(74, 20)
        Me.txtNum_Int.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(274, 83)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Interior ..........................."
        '
        'txtDes_Zon
        '
        Me.txtDes_Zon.AcceptsReturn = True
        Me.txtDes_Zon.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_Zon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_Zon.Enabled = False
        Me.txtDes_Zon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDes_Zon.Location = New System.Drawing.Point(197, 99)
        Me.txtDes_Zon.MaxLength = 50
        Me.txtDes_Zon.Name = "txtDes_Zon"
        Me.txtDes_Zon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_Zon.Size = New System.Drawing.Size(363, 20)
        Me.txtDes_Zon.TabIndex = 22
        '
        'txtCod_Zon
        '
        Me.txtCod_Zon.AcceptsReturn = True
        Me.txtCod_Zon.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Zon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Zon.Enabled = False
        Me.txtCod_Zon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Zon.Location = New System.Drawing.Point(122, 99)
        Me.txtCod_Zon.MaxLength = 50
        Me.txtCod_Zon.Name = "txtCod_Zon"
        Me.txtCod_Zon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Zon.Size = New System.Drawing.Size(74, 20)
        Me.txtCod_Zon.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(12, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(125, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Zona Domicilio ..............."
        '
        'txtCod_Ubigeo
        '
        Me.txtCod_Ubigeo.AcceptsReturn = True
        Me.txtCod_Ubigeo.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Ubigeo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Ubigeo.Enabled = False
        Me.txtCod_Ubigeo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCod_Ubigeo.Location = New System.Drawing.Point(122, 145)
        Me.txtCod_Ubigeo.MaxLength = 50
        Me.txtCod_Ubigeo.Name = "txtCod_Ubigeo"
        Me.txtCod_Ubigeo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Ubigeo.Size = New System.Drawing.Size(149, 20)
        Me.txtCod_Ubigeo.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(12, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(134, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Ubigeo .............................."
        '
        'txtNom_Zon
        '
        Me.txtNom_Zon.AcceptsReturn = True
        Me.txtNom_Zon.BackColor = System.Drawing.SystemColors.Window
        Me.txtNom_Zon.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNom_Zon.Enabled = False
        Me.txtNom_Zon.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNom_Zon.Location = New System.Drawing.Point(122, 122)
        Me.txtNom_Zon.MaxLength = 50
        Me.txtNom_Zon.Name = "txtNom_Zon"
        Me.txtNom_Zon.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNom_Zon.Size = New System.Drawing.Size(438, 20)
        Me.txtNom_Zon.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(12, 129)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(135, 13)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Nombre Zona ...................."
        '
        'CmdCodUbigeo
        '
        Me.CmdCodUbigeo.Enabled = False
        Me.CmdCodUbigeo.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.CmdCodUbigeo.ImageSize = New System.Drawing.Size(32, 32)
        Me.CmdCodUbigeo.Location = New System.Drawing.Point(274, 145)
        Me.CmdCodUbigeo.Name = "CmdCodUbigeo"
        Me.CmdCodUbigeo.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.CmdCodUbigeo.Size = New System.Drawing.Size(27, 20)
        Me.CmdCodUbigeo.TabIndex = 416
        Me.CmdCodUbigeo.Text = "..."
        Me.CmdCodUbigeo.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'ChkDefault
        '
        Me.ChkDefault.AutoSize = True
        Me.ChkDefault.Enabled = False
        Me.ChkDefault.Location = New System.Drawing.Point(505, 149)
        Me.ChkDefault.Name = "ChkDefault"
        Me.ChkDefault.Size = New System.Drawing.Size(55, 17)
        Me.ChkDefault.TabIndex = 417
        Me.ChkDefault.Text = "Default"
        Me.ChkDefault.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_AddMantAnexosDireccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 483)
        Me.Controls.Add(Me.GrdMntTest)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.fraDatos)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmDocumentoVenta_AddMantAnexosDireccion"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento de Anexos por Direccion"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtAnexoContable As TextBox
    Friend WithEvents fraDatos As Panel
    Public WithEvents txtCod_Via As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtCod_Dir As TextBox
    Public WithEvents Label2 As Label
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Public WithEvents txtCod_Ubigeo As TextBox
    Public WithEvents Label8 As Label
    Public WithEvents txtNom_Zon As TextBox
    Public WithEvents Label9 As Label
    Public WithEvents txtDes_Zon As TextBox
    Public WithEvents txtCod_Zon As TextBox
    Public WithEvents Label7 As Label
    Public WithEvents txtNum_Int As TextBox
    Public WithEvents Label6 As Label
    Public WithEvents txtNum_Dom As TextBox
    Public WithEvents Label5 As Label
    Public WithEvents txtNom_Via As TextBox
    Public WithEvents Label4 As Label
    Public WithEvents txtDes_Via As TextBox
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
    Friend WithEvents CmdCodUbigeo As Janus.Windows.EditControls.UIButton
    Friend WithEvents ChkDefault As Janus.Windows.EditControls.UICheckBox
End Class
