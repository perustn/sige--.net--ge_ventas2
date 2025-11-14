<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT
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
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TxtEstilo = New System.Windows.Forms.TextBox()
        Me.TxtPO = New System.Windows.Forms.TextBox()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnFactura = New Janus.Windows.EditControls.UIButton()
        Me.Panel1.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TxtEstilo)
        Me.Panel1.Controls.Add(Me.TxtPO)
        Me.Panel1.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 35)
        Me.Panel1.TabIndex = 0
        '
        'TxtEstilo
        '
        Me.TxtEstilo.AcceptsReturn = True
        Me.TxtEstilo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtEstilo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtEstilo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtEstilo.Location = New System.Drawing.Point(363, 7)
        Me.TxtEstilo.MaxLength = 0
        Me.TxtEstilo.Name = "TxtEstilo"
        Me.TxtEstilo.ReadOnly = True
        Me.TxtEstilo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtEstilo.Size = New System.Drawing.Size(90, 20)
        Me.TxtEstilo.TabIndex = 131
        '
        'TxtPO
        '
        Me.TxtPO.AcceptsReturn = True
        Me.TxtPO.BackColor = System.Drawing.Color.LightCyan
        Me.TxtPO.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtPO.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtPO.Location = New System.Drawing.Point(212, 7)
        Me.TxtPO.MaxLength = 0
        Me.TxtPO.Name = "TxtPO"
        Me.TxtPO.ReadOnly = True
        Me.TxtPO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtPO.Size = New System.Drawing.Size(90, 20)
        Me.TxtPO.TabIndex = 129
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(75, 7)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 127
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Gold
        Me.Label11.Location = New System.Drawing.Point(317, 11)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(42, 12)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "ESTILO"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Gold
        Me.Label10.Location = New System.Drawing.Point(185, 11)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(20, 12)
        Me.Label10.TabIndex = 128
        Me.Label10.Text = "PO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(13, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(58, 12)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "NRO CORR"
        '
        'GridEX1
        '
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><AllowEdit>False</AllowEdit><GroupCondition /></Root" &
    "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.Location = New System.Drawing.Point(0, 35)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(766, 261)
        Me.GridEX1.TabIndex = 1
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnFactura)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 296)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(766, 41)
        Me.Panel2.TabIndex = 2
        '
        'BtnFactura
        '
        Me.BtnFactura.Image = CType(resources.GetObject("BtnFactura.Image"), System.Drawing.Image)
        Me.BtnFactura.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnFactura.Location = New System.Drawing.Point(11, 6)
        Me.BtnFactura.Name = "BtnFactura"
        Me.BtnFactura.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnFactura.Size = New System.Drawing.Size(144, 30)
        Me.BtnFactura.TabIndex = 7
        Me.BtnFactura.Text = "Factura Electrónica"
        Me.BtnFactura.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(766, 337)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmDocumentoVentaExportacion_ProcesarFacturas_Nueva_Serie_CMT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturacion Nueva Serie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents Panel2 As Panel
    Public WithEvents TxtEstilo As TextBox
    Public WithEvents TxtPO As TextBox
    Public WithEvents TxtNroCorrelativo As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label3 As Label
    Friend WithEvents BtnFactura As Janus.Windows.EditControls.UIButton
End Class
