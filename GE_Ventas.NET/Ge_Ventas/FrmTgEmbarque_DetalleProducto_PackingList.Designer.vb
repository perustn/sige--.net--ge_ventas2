<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTgEmbarque_DetalleProducto_PackingList
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
        Dim BarraOpciones_Group_0 As Janus.Windows.ButtonBar.ButtonBarGroup = New Janus.Windows.ButtonBar.ButtonBarGroup()
        Dim BarraOpciones_Item_0_0 As Janus.Windows.ButtonBar.ButtonBarItem = New Janus.Windows.ButtonBar.ButtonBarItem()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmTgEmbarque_DetalleProducto_PackingList))
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.BarraOpciones = New Janus.Windows.ButtonBar.ButtonBar()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txtNum_Packing = New System.Windows.Forms.TextBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TxtSec = New System.Windows.Forms.TextBox()
        Me.LabelSec = New System.Windows.Forms.Label()
        Me.TxtNroEmbarque = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GridEX1
        '
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX1.Location = New System.Drawing.Point(0, 96)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(554, 354)
        Me.GridEX1.TabIndex = 213
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'BarraOpciones
        '
        Me.BarraOpciones.Dock = System.Windows.Forms.DockStyle.Top
        BarraOpciones_Item_0_0.Image = CType(resources.GetObject("BarraOpciones_Item_0_0.Image"), System.Drawing.Image)
        BarraOpciones_Item_0_0.Key = "PROCESAR"
        BarraOpciones_Item_0_0.Text = "Procesar"
        BarraOpciones_Group_0.Items.AddRange(New Janus.Windows.ButtonBar.ButtonBarItem() {BarraOpciones_Item_0_0})
        BarraOpciones_Group_0.Key = "Group1"
        BarraOpciones_Group_0.View = Janus.Windows.ButtonBar.ButtonBarView.SmallIcons
        Me.BarraOpciones.Groups.AddRange(New Janus.Windows.ButtonBar.ButtonBarGroup() {BarraOpciones_Group_0})
        Me.BarraOpciones.HeaderGroupVisible = False
        Me.BarraOpciones.ItemAppearance = Janus.Windows.ButtonBar.ItemAppearance.Flat
        Me.BarraOpciones.LargeImageSize = New System.Drawing.Size(30, 30)
        Me.BarraOpciones.Location = New System.Drawing.Point(0, 71)
        Me.BarraOpciones.Name = "BarraOpciones"
        Me.BarraOpciones.OfficeColorScheme = Janus.Windows.ButtonBar.OfficeColorScheme.Blue
        Me.BarraOpciones.Orientation = Janus.Windows.ButtonBar.ButtonBarOrientation.Horizontal
        Me.BarraOpciones.SelectionArea = Janus.Windows.ButtonBar.SelectionArea.FullItem
        Me.BarraOpciones.ShadowOnHover = True
        Me.BarraOpciones.Size = New System.Drawing.Size(554, 25)
        Me.BarraOpciones.SmallImageSize = New System.Drawing.Size(16, 16)
        Me.BarraOpciones.TabIndex = 212
        Me.BarraOpciones.Text = "ButtonBar1"
        Me.BarraOpciones.VisualStyle = Janus.Windows.ButtonBar.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel2.Controls.Add(Me.BtnBuscar)
        Me.Panel2.Controls.Add(Me.txtNum_Packing)
        Me.Panel2.Controls.Add(Me.Label37)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 26)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(554, 45)
        Me.Panel2.TabIndex = 211
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageIndex = 12
        Me.BtnBuscar.Location = New System.Drawing.Point(433, 8)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(109, 29)
        Me.BtnBuscar.TabIndex = 87
        Me.BtnBuscar.Text = "&Realizar Búsqueda"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtNum_Packing
        '
        Me.txtNum_Packing.AcceptsReturn = True
        Me.txtNum_Packing.BackColor = System.Drawing.Color.White
        Me.txtNum_Packing.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Packing.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtNum_Packing.Location = New System.Drawing.Point(96, 12)
        Me.txtNum_Packing.MaxLength = 0
        Me.txtNum_Packing.Name = "txtNum_Packing"
        Me.txtNum_Packing.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Packing.Size = New System.Drawing.Size(99, 20)
        Me.txtNum_Packing.TabIndex = 86
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.BackColor = System.Drawing.Color.Transparent
        Me.Label37.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label37.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.Color.Blue
        Me.Label37.Location = New System.Drawing.Point(13, 16)
        Me.Label37.Name = "Label37"
        Me.Label37.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label37.Size = New System.Drawing.Size(88, 12)
        Me.Label37.TabIndex = 85
        Me.Label37.Text = "Nº PACKING ......"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TxtSec)
        Me.Panel3.Controls.Add(Me.LabelSec)
        Me.Panel3.Controls.Add(Me.TxtNroEmbarque)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(554, 26)
        Me.Panel3.TabIndex = 215
        '
        'TxtSec
        '
        Me.TxtSec.AcceptsReturn = True
        Me.TxtSec.BackColor = System.Drawing.Color.LightCyan
        Me.TxtSec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtSec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtSec.Location = New System.Drawing.Point(250, 3)
        Me.TxtSec.MaxLength = 0
        Me.TxtSec.Name = "TxtSec"
        Me.TxtSec.ReadOnly = True
        Me.TxtSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtSec.Size = New System.Drawing.Size(38, 20)
        Me.TxtSec.TabIndex = 90
        '
        'LabelSec
        '
        Me.LabelSec.AutoSize = True
        Me.LabelSec.BackColor = System.Drawing.Color.Transparent
        Me.LabelSec.Cursor = System.Windows.Forms.Cursors.Default
        Me.LabelSec.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSec.ForeColor = System.Drawing.Color.Gold
        Me.LabelSec.Location = New System.Drawing.Point(217, 7)
        Me.LabelSec.Name = "LabelSec"
        Me.LabelSec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.LabelSec.Size = New System.Drawing.Size(23, 12)
        Me.LabelSec.TabIndex = 89
        Me.LabelSec.Text = "SEC"
        '
        'TxtNroEmbarque
        '
        Me.TxtNroEmbarque.AcceptsReturn = True
        Me.TxtNroEmbarque.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroEmbarque.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroEmbarque.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroEmbarque.Location = New System.Drawing.Point(103, 3)
        Me.TxtNroEmbarque.MaxLength = 0
        Me.TxtNroEmbarque.Name = "TxtNroEmbarque"
        Me.TxtNroEmbarque.ReadOnly = True
        Me.TxtNroEmbarque.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroEmbarque.Size = New System.Drawing.Size(92, 20)
        Me.TxtNroEmbarque.TabIndex = 86
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(17, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(77, 12)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "Nº EMBARQUE"
        '
        'FrmTgEmbarque_DetalleProducto_PackingList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 450)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.BarraOpciones)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTgEmbarque_DetalleProducto_PackingList"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Producto Segun Packing List"
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraOpciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents BarraOpciones As Janus.Windows.ButtonBar.ButtonBar
    Friend WithEvents Panel2 As Panel
    Public WithEvents txtNum_Packing As TextBox
    Public WithEvents Label37 As Label
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Public WithEvents TxtSec As System.Windows.Forms.TextBox
    Public WithEvents LabelSec As System.Windows.Forms.Label
    Public WithEvents TxtNroEmbarque As System.Windows.Forms.TextBox
    Public WithEvents Label3 As System.Windows.Forms.Label
End Class
