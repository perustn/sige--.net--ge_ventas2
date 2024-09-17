<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMantenimientoModoEmbarque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMantenimientoModoEmbarque))
        Dim BarraOpciones_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_2 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_3 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim BarraOpciones_Item_0_4 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim GrdMntTest_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.fraDatos = New System.Windows.Forms.Panel()
        Me.txtDescripcion_Embarque = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigo_Embarque = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrdMntTest = New Janus.Windows.GridEX.GridEX()
        Me.Panel1.SuspendLayout()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.fraDatos.SuspendLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.GrdMntTest)
        Me.Panel1.Controls.Add(Me.BarraOpciones)
        Me.Panel1.Controls.Add(Me.fraDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(425, 450)
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
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 360)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(425, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 38
        Me.BarraOpciones.Text = "ButtonBar2"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'fraDatos
        '
        Me.fraDatos.BackColor = System.Drawing.Color.White
        Me.fraDatos.Controls.Add(Me.txtDescripcion_Embarque)
        Me.fraDatos.Controls.Add(Me.Label1)
        Me.fraDatos.Controls.Add(Me.txtCodigo_Embarque)
        Me.fraDatos.Controls.Add(Me.Label2)
        Me.fraDatos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.fraDatos.Location = New System.Drawing.Point(0, 385)
        Me.fraDatos.Name = "fraDatos"
        Me.fraDatos.Size = New System.Drawing.Size(425, 65)
        Me.fraDatos.TabIndex = 37
        '
        'txtDescripcion_Embarque
        '
        Me.txtDescripcion_Embarque.AcceptsReturn = True
        Me.txtDescripcion_Embarque.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion_Embarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion_Embarque.Enabled = False
        Me.txtDescripcion_Embarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDescripcion_Embarque.Location = New System.Drawing.Point(122, 30)
        Me.txtDescripcion_Embarque.MaxLength = 50
        Me.txtDescripcion_Embarque.Name = "txtDescripcion_Embarque"
        Me.txtDescripcion_Embarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion_Embarque.Size = New System.Drawing.Size(291, 20)
        Me.txtDescripcion_Embarque.TabIndex = 11
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
        Me.Label1.Size = New System.Drawing.Size(138, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Descripción........................."
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
        Me.GrdMntTest.Location = New System.Drawing.Point(0, 0)
        Me.GrdMntTest.Name = "GrdMntTest"
        Me.GrdMntTest.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GrdMntTest.RecordNavigator = True
        Me.GrdMntTest.Size = New System.Drawing.Size(425, 360)
        Me.GrdMntTest.TabIndex = 213
        Me.GrdMntTest.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmMantenimientoModoEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 450)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmMantenimientoModoEmbarque"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento Modo Embarque"
        Me.Panel1.ResumeLayout(False)
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.fraDatos.ResumeLayout(False)
        Me.fraDatos.PerformLayout()
        CType(Me.GrdMntTest, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents fraDatos As Panel
    Public WithEvents txtDescripcion_Embarque As TextBox
    Public WithEvents Label1 As Label
    Public WithEvents txtCodigo_Embarque As TextBox
    Public WithEvents Label2 As Label
    Friend WithEvents GrdMntTest As Janus.Windows.GridEX.GridEX
End Class
