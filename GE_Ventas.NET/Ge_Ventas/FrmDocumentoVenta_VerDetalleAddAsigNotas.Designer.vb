<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDocumentoVenta_VerDetalleAddAsigNotas
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
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FraFiltro = New Janus.Windows.EditControls.UIGroupBox()
        Me.txtNum_Docum = New System.Windows.Forms.TextBox()
        Me.txtSer_Docum = New System.Windows.Forms.TextBox()
        Me.txtDes_TipDoc = New System.Windows.Forms.TextBox()
        Me.txtCod_TipDoc = New System.Windows.Forms.TextBox()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FraFiltro.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 396)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(799, 30)
        Me.Panel2.TabIndex = 259
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(592, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(207, 30)
        Me.Panel3.TabIndex = 0
        '
        'BtnCancelar
        '
        Me.BtnCancelar.ImageKey = "48px-Crystal_Clear_action_button_cancel.png"
        Me.BtnCancelar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnCancelar.Location = New System.Drawing.Point(105, 3)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnCancelar.Size = New System.Drawing.Size(98, 24)
        Me.BtnCancelar.TabIndex = 6
        Me.BtnCancelar.Text = "&Cancelar"
        Me.BtnCancelar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'BtnAceptar
        '
        Me.BtnAceptar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnAceptar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnAceptar.Location = New System.Drawing.Point(3, 3)
        Me.BtnAceptar.Name = "BtnAceptar"
        Me.BtnAceptar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnAceptar.Size = New System.Drawing.Size(98, 24)
        Me.BtnAceptar.TabIndex = 5
        Me.BtnAceptar.Text = "&Aceptar"
        Me.BtnAceptar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.Controls.Add(Me.FraFiltro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 58)
        Me.Panel1.TabIndex = 260
        '
        'FraFiltro
        '
        Me.FraFiltro.Controls.Add(Me.txtNum_Docum)
        Me.FraFiltro.Controls.Add(Me.txtSer_Docum)
        Me.FraFiltro.Controls.Add(Me.txtDes_TipDoc)
        Me.FraFiltro.Controls.Add(Me.txtCod_TipDoc)
        Me.FraFiltro.Controls.Add(Me.BtnBuscar)
        Me.FraFiltro.Controls.Add(Me.Label2)
        Me.FraFiltro.Controls.Add(Me.Label1)
        Me.FraFiltro.Controls.Add(Me.Label7)
        Me.FraFiltro.Location = New System.Drawing.Point(6, 3)
        Me.FraFiltro.Name = "FraFiltro"
        Me.FraFiltro.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.FraFiltro.Size = New System.Drawing.Size(779, 49)
        Me.FraFiltro.TabIndex = 102
        Me.FraFiltro.Text = "Filtro de Búsqueda"
        Me.FraFiltro.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'txtNum_Docum
        '
        Me.txtNum_Docum.AcceptsReturn = True
        Me.txtNum_Docum.BackColor = System.Drawing.SystemColors.Window
        Me.txtNum_Docum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNum_Docum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNum_Docum.Location = New System.Drawing.Point(542, 19)
        Me.txtNum_Docum.MaxLength = 100
        Me.txtNum_Docum.Name = "txtNum_Docum"
        Me.txtNum_Docum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtNum_Docum.Size = New System.Drawing.Size(105, 20)
        Me.txtNum_Docum.TabIndex = 108
        '
        'txtSer_Docum
        '
        Me.txtSer_Docum.AcceptsReturn = True
        Me.txtSer_Docum.BackColor = System.Drawing.SystemColors.Window
        Me.txtSer_Docum.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSer_Docum.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtSer_Docum.Location = New System.Drawing.Point(409, 19)
        Me.txtSer_Docum.MaxLength = 100
        Me.txtSer_Docum.Name = "txtSer_Docum"
        Me.txtSer_Docum.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSer_Docum.Size = New System.Drawing.Size(50, 20)
        Me.txtSer_Docum.TabIndex = 106
        '
        'txtDes_TipDoc
        '
        Me.txtDes_TipDoc.AcceptsReturn = True
        Me.txtDes_TipDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtDes_TipDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDes_TipDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDes_TipDoc.Location = New System.Drawing.Point(140, 19)
        Me.txtDes_TipDoc.MaxLength = 100
        Me.txtDes_TipDoc.Name = "txtDes_TipDoc"
        Me.txtDes_TipDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDes_TipDoc.Size = New System.Drawing.Size(196, 20)
        Me.txtDes_TipDoc.TabIndex = 104
        '
        'txtCod_TipDoc
        '
        Me.txtCod_TipDoc.AcceptsReturn = True
        Me.txtCod_TipDoc.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_TipDoc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_TipDoc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_TipDoc.Location = New System.Drawing.Point(88, 19)
        Me.txtCod_TipDoc.MaxLength = 100
        Me.txtCod_TipDoc.Name = "txtCod_TipDoc"
        Me.txtCod_TipDoc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_TipDoc.Size = New System.Drawing.Size(50, 20)
        Me.txtCod_TipDoc.TabIndex = 99
        '
        'BtnBuscar
        '
        Me.BtnBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.BtnBuscar.ImageSize = New System.Drawing.Size(32, 32)
        Me.BtnBuscar.Location = New System.Drawing.Point(653, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(118, 30)
        Me.BtnBuscar.TabIndex = 102
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(478, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Número ............."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(354, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Serie ............."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(13, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 98
        Me.Label7.Text = "Tipo Doc ..........."
        '
        'GridEX1
        '
        Me.GridEX1.AllowColumnDrag = False
        Me.GridEX1.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX1.AlternatingColors = True
        Me.GridEX1.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX1.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX1_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GridEX1.DesignTimeLayout = GridEX1_DesignTimeLayout
        Me.GridEX1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GridEX1.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GridEX1.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX1.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX1.GroupByBoxVisible = False
        Me.GridEX1.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX1.Location = New System.Drawing.Point(0, 58)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(799, 156)
        Me.GridEX1.TabIndex = 261
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Label36
        '
        Me.Label36.BackColor = System.Drawing.Color.Gold
        Me.Label36.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label36.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label36.Font = New System.Drawing.Font("Segoe UI", 8.0!, System.Drawing.FontStyle.Bold)
        Me.Label36.ForeColor = System.Drawing.Color.Blue
        Me.Label36.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label36.Location = New System.Drawing.Point(0, 214)
        Me.Label36.Name = "Label36"
        Me.Label36.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label36.Size = New System.Drawing.Size(799, 20)
        Me.Label36.TabIndex = 262
        Me.Label36.Text = "DETALLE DE REGISTRO"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GridEX2
        '
        Me.GridEX2.AllowColumnDrag = False
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        Me.GridEX2.BorderStyle = Janus.Windows.GridEX.BorderStyle.Flat
        Me.GridEX2.DefaultFilterRowComparison = Janus.Windows.GridEX.FilterConditionOperator.Contains
        GridEX2_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" &
    "Table></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX2.EnterKeyBehavior = Janus.Windows.GridEX.EnterKeyBehavior.None
        Me.GridEX2.FilterMode = Janus.Windows.GridEX.FilterMode.Automatic
        Me.GridEX2.FilterRowUpdateMode = Janus.Windows.GridEX.FilterRowUpdateMode.WhenValueChanges
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive
        Me.GridEX2.Location = New System.Drawing.Point(0, 234)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.Size = New System.Drawing.Size(799, 162)
        Me.GridEX2.TabIndex = 262
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_VerDetalleAddAsigNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 426)
        Me.ControlBox = False
        Me.Controls.Add(Me.GridEX2)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.GridEX1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_VerDetalleAddAsigNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Adicionar"
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.FraFiltro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FraFiltro.ResumeLayout(False)
        Me.FraFiltro.PerformLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FraFiltro As Janus.Windows.EditControls.UIGroupBox
    Public WithEvents txtDes_TipDoc As TextBox
    Public WithEvents txtCod_TipDoc As TextBox
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Public WithEvents Label7 As Label
    Public WithEvents txtNum_Docum As TextBox
    Public WithEvents Label2 As Label
    Public WithEvents txtSer_Docum As TextBox
    Public WithEvents Label1 As Label
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Public WithEvents Label36 As Label
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
End Class
