<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBandeja_Facturacion006_CMT
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim ButtonBar1_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim ButtonBar1_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmBandeja_Facturacion006_CMT))
        Dim ButtonBar1_Item_0_1 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCorrelativo = New System.Windows.Forms.TextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSerie = New System.Windows.Forms.TextBox()
        Me.ButtonBar1 = New Janus.Windows.ButtonBar.ButtonBar()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 59)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(710, 348)
        Me.GridEX1.TabIndex = 12
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtCorrelativo)
        Me.Panel4.Controls.Add(Me.txtNumero)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.txtSerie)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(710, 37)
        Me.Panel4.TabIndex = 249
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(351, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(104, 12)
        Me.Label1.TabIndex = 123
        Me.Label1.Text = "NRO CORRELATIVO"
        '
        'txtCorrelativo
        '
        Me.txtCorrelativo.AcceptsReturn = True
        Me.txtCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.txtCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtCorrelativo.Location = New System.Drawing.Point(469, 9)
        Me.txtCorrelativo.MaxLength = 0
        Me.txtCorrelativo.Name = "txtCorrelativo"
        Me.txtCorrelativo.ReadOnly = True
        Me.txtCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.txtCorrelativo.TabIndex = 124
        '
        'txtNumero
        '
        Me.txtNumero.AcceptsReturn = True
        Me.txtNumero.BackColor = System.Drawing.Color.LightCyan
        Me.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNumero.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNumero.Location = New System.Drawing.Point(158, 9)
        Me.txtNumero.MaxLength = 0
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.ReadOnly = True
        Me.txtNumero.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNumero.Size = New System.Drawing.Size(160, 20)
        Me.txtNumero.TabIndex = 122
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(93, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO DOCUMENTO"
        '
        'txtSerie
        '
        Me.txtSerie.AcceptsReturn = True
        Me.txtSerie.BackColor = System.Drawing.Color.LightCyan
        Me.txtSerie.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSerie.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSerie.Location = New System.Drawing.Point(108, 9)
        Me.txtSerie.MaxLength = 0
        Me.txtSerie.Name = "txtSerie"
        Me.txtSerie.ReadOnly = True
        Me.txtSerie.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSerie.Size = New System.Drawing.Size(49, 20)
        Me.txtSerie.TabIndex = 121
        '
        'ButtonBar1
        '
        Me.ButtonBar1.Dock = System.Windows.Forms.DockStyle.Top
        ButtonBar1_Group_0.ImageKey = "Opciones.jpg"
        ButtonBar1_Item_0_0.Image = CType(resources.GetObject("ButtonBar1_Item_0_0.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_0.Key = "PROCESAR"
        ButtonBar1_Item_0_0.Text = "Procesar"
        ButtonBar1_Item_0_1.Image = CType(resources.GetObject("ButtonBar1_Item_0_1.Image"), System.Drawing.Image)
        ButtonBar1_Item_0_1.Key = "VERFACTURA"
        ButtonBar1_Item_0_1.Text = "Ver Factura CMT"
        ButtonBar1_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {ButtonBar1_Item_0_0, ButtonBar1_Item_0_1})
        ButtonBar1_Group_0.Key = "Group1"
        ButtonBar1_Group_0.TextAlignment = Janus.Windows.ButtonBar.Alignment.Near
        ButtonBar1_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.ButtonBar1.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {ButtonBar1_Group_0})
        Me.ButtonBar1.HeaderGroupVisible = False
        Me.ButtonBar1.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.ButtonBar1.Location = New System.Drawing.Point(0, 37)
        Me.ButtonBar1.Name = "ButtonBar1"
        Me.ButtonBar1.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.ButtonBar1.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.ButtonBar1.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.ButtonBar1.ShadowOnHover = True
        Me.ButtonBar1.Size = New System.Drawing.Size(710, 22)
        Me.ButtonBar1.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.ButtonBar1.TabIndex = 253
        Me.ButtonBar1.Text = "ButtonBar2"
        Me.ButtonBar1.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'FrmBandeja_Facturacion006_CMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 407)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.ButtonBar1)
        Me.Controls.Add(Me.Panel4)
        Me.Name = "FrmBandeja_Facturacion006_CMT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Bandeja Facturacion 006 CMT"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.ButtonBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel4 As Panel
    Public WithEvents Label1 As Label
    Public WithEvents txtCorrelativo As TextBox
    Public WithEvents txtNumero As TextBox
    Public WithEvents Label3 As Label
    Public WithEvents txtSerie As TextBox
    Friend WithEvents ButtonBar1 As Janus.Windows.ButtonBar.ButtonBar
End Class
