<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTgEmbarque_InstruccionEmbarque
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
        Dim GridEX2_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Dim GridEX1_DesignTimeLayout As Janus.Windows.GridEX.GridEXLayout = New Janus.Windows.GridEX.GridEXLayout()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.GridEX2 = New Janus.Windows.GridEX.GridEX()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GridEX1 = New Janus.Windows.GridEX.GridEX()
        Me.UiGroupBox1 = New Janus.Windows.EditControls.UIGroupBox()
        Me.BtnBuscar = New Janus.Windows.EditControls.UIButton()
        Me.txtPO = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGenerarInstruccionEmbarque = New Janus.Windows.EditControls.UIButton()
        Me.btnQuitarPO = New Janus.Windows.EditControls.UIButton()
        Me.btnAgregarPacking = New Janus.Windows.EditControls.UIButton()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.UiGroupBox1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1110, 409)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Location = New System.Drawing.Point(560, 10)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(545, 390)
        Me.Panel4.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(321, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "LISTA DE PO PARA SIMULACION DE EMBARQUE"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.GridEX2)
        Me.Panel5.Location = New System.Drawing.Point(9, 54)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(523, 326)
        Me.Panel5.TabIndex = 1
        '
        'GridEX2
        '
        Me.GridEX2.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.[False]
        Me.GridEX2.AlternatingColors = True
        GridEX2_DesignTimeLayout.LayoutString = "<GridEXLayoutData><RootTable><GroupCondition /><HeaderLines>2</HeaderLines></Root" & _
    "Table></GridEXLayoutData>"
        Me.GridEX2.DesignTimeLayout = GridEX2_DesignTimeLayout
        Me.GridEX2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridEX2.GroupByBoxVisible = False
        Me.GridEX2.HideSelection = Janus.Windows.GridEX.HideSelection.Highlight
        Me.GridEX2.Location = New System.Drawing.Point(0, 0)
        Me.GridEX2.Name = "GridEX2"
        Me.GridEX2.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX2.RecordNavigator = True
        Me.GridEX2.Size = New System.Drawing.Size(523, 326)
        Me.GridEX2.TabIndex = 207
        Me.GridEX2.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.UiGroupBox1)
        Me.Panel2.Location = New System.Drawing.Point(5, 10)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(545, 390)
        Me.Panel2.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GridEX1)
        Me.Panel3.Location = New System.Drawing.Point(9, 54)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(523, 326)
        Me.Panel3.TabIndex = 1
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
        Me.GridEX1.Location = New System.Drawing.Point(0, 0)
        Me.GridEX1.Name = "GridEX1"
        Me.GridEX1.OfficeColorScheme = Janus.Windows.GridEX.OfficeColorScheme.Blue
        Me.GridEX1.RecordNavigator = True
        Me.GridEX1.Size = New System.Drawing.Size(523, 326)
        Me.GridEX1.TabIndex = 207
        Me.GridEX1.VisualStyle = Janus.Windows.GridEX.VisualStyle.Office2010
        '
        'UiGroupBox1
        '
        Me.UiGroupBox1.Controls.Add(Me.BtnBuscar)
        Me.UiGroupBox1.Controls.Add(Me.txtPO)
        Me.UiGroupBox1.Controls.Add(Me.Label1)
        Me.UiGroupBox1.Location = New System.Drawing.Point(9, 1)
        Me.UiGroupBox1.Name = "UiGroupBox1"
        Me.UiGroupBox1.Size = New System.Drawing.Size(523, 47)
        Me.UiGroupBox1.TabIndex = 0
        Me.UiGroupBox1.VisualStyle = Janus.Windows.UI.Dock.PanelVisualStyle.Office2010
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuscar.ImageIndex = 12
        Me.BtnBuscar.Location = New System.Drawing.Point(370, 12)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.BtnBuscar.Size = New System.Drawing.Size(123, 29)
        Me.BtnBuscar.TabIndex = 13
        Me.BtnBuscar.Text = "&Realizar Búsqueda"
        Me.BtnBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'txtPO
        '
        Me.txtPO.Location = New System.Drawing.Point(108, 15)
        Me.txtPO.MaxLength = 20
        Me.txtPO.Name = "txtPO"
        Me.txtPO.Size = New System.Drawing.Size(108, 20)
        Me.txtPO.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nº PO............."
        '
        'btnGenerarInstruccionEmbarque
        '
        Me.btnGenerarInstruccionEmbarque.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarInstruccionEmbarque.ImageIndex = 12
        Me.btnGenerarInstruccionEmbarque.Location = New System.Drawing.Point(355, 5)
        Me.btnGenerarInstruccionEmbarque.Name = "btnGenerarInstruccionEmbarque"
        Me.btnGenerarInstruccionEmbarque.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnGenerarInstruccionEmbarque.Size = New System.Drawing.Size(123, 29)
        Me.btnGenerarInstruccionEmbarque.TabIndex = 16
        Me.btnGenerarInstruccionEmbarque.Text = "Generar instruccion Embarque"
        Me.btnGenerarInstruccionEmbarque.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'btnQuitarPO
        '
        Me.btnQuitarPO.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarPO.ImageIndex = 12
        Me.btnQuitarPO.Location = New System.Drawing.Point(187, 5)
        Me.btnQuitarPO.Name = "btnQuitarPO"
        Me.btnQuitarPO.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnQuitarPO.Size = New System.Drawing.Size(123, 29)
        Me.btnQuitarPO.TabIndex = 15
        Me.btnQuitarPO.Text = "&Quitar PO"
        Me.btnQuitarPO.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'btnAgregarPacking
        '
        Me.btnAgregarPacking.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPacking.ImageIndex = 12
        Me.btnAgregarPacking.Location = New System.Drawing.Point(21, 5)
        Me.btnAgregarPacking.Name = "btnAgregarPacking"
        Me.btnAgregarPacking.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.btnAgregarPacking.Size = New System.Drawing.Size(123, 29)
        Me.btnAgregarPacking.TabIndex = 14
        Me.btnAgregarPacking.Text = "&Agregar Packing"
        Me.btnAgregarPacking.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Transparent
        Me.Panel6.Controls.Add(Me.Panel7)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 409)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1110, 38)
        Me.Panel6.TabIndex = 3
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.btnGenerarInstruccionEmbarque)
        Me.Panel7.Controls.Add(Me.btnAgregarPacking)
        Me.Panel7.Controls.Add(Me.btnQuitarPO)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel7.Location = New System.Drawing.Point(328, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(782, 38)
        Me.Panel7.TabIndex = 0
        '
        'FrmTgEmbarque_InstruccionEmbarque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1110, 447)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmTgEmbarque_InstruccionEmbarque"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instruccion de Embarque"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        CType(Me.GridEX2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.GridEX1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UiGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.UiGroupBox1.ResumeLayout(False)
        Me.UiGroupBox1.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents UiGroupBox1 As Janus.Windows.EditControls.UIGroupBox
    Friend WithEvents txtPO As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnBuscar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents GridEX2 As Janus.Windows.GridEX.GridEX
    Friend WithEvents GridEX1 As Janus.Windows.GridEX.GridEX
    Friend WithEvents btnGenerarInstruccionEmbarque As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnQuitarPO As Janus.Windows.EditControls.UIButton
    Friend WithEvents btnAgregarPacking As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
End Class
