<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDocumentoVenta_VerDetalleAdd
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
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNroCorrelativo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtnCancelar = New Janus.Windows.EditControls.UIButton()
        Me.BtnAceptar = New Janus.Windows.EditControls.UIButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtCod_Producto = New System.Windows.Forms.TextBox()
        Me.txtTip_Item = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescripcion_Agrup = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescripcion_CliExt = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtUnida_Medida = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtImp_Total = New System.Windows.Forms.TextBox()
        Me.txtImp_Unitario = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCantUniAlter = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPorc_Commision = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmdBuscar = New Janus.Windows.EditControls.UIButton()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.TxtNroCorrelativo)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(693, 28)
        Me.Panel4.TabIndex = 256
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Gold
        Me.Label3.Location = New System.Drawing.Point(10, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(104, 12)
        Me.Label3.TabIndex = 120
        Me.Label3.Text = "NRO CORRELATIVO"
        '
        'TxtNroCorrelativo
        '
        Me.TxtNroCorrelativo.AcceptsReturn = True
        Me.TxtNroCorrelativo.BackColor = System.Drawing.Color.LightCyan
        Me.TxtNroCorrelativo.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtNroCorrelativo.ForeColor = System.Drawing.SystemColors.WindowText
        Me.TxtNroCorrelativo.Location = New System.Drawing.Point(122, 4)
        Me.TxtNroCorrelativo.MaxLength = 0
        Me.TxtNroCorrelativo.Name = "TxtNroCorrelativo"
        Me.TxtNroCorrelativo.ReadOnly = True
        Me.TxtNroCorrelativo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.TxtNroCorrelativo.Size = New System.Drawing.Size(101, 20)
        Me.TxtNroCorrelativo.TabIndex = 121
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 422)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(693, 30)
        Me.Panel2.TabIndex = 258
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtnCancelar)
        Me.Panel3.Controls.Add(Me.BtnAceptar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(486, 0)
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
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.cmdBuscar)
        Me.Panel1.Controls.Add(Me.txtPorc_Commision)
        Me.Panel1.Controls.Add(Me.txtCantUniAlter)
        Me.Panel1.Controls.Add(Me.txtImp_Total)
        Me.Panel1.Controls.Add(Me.txtImp_Unitario)
        Me.Panel1.Controls.Add(Me.txtCantidad)
        Me.Panel1.Controls.Add(Me.txtUnida_Medida)
        Me.Panel1.Controls.Add(Me.txtDescripcion_CliExt)
        Me.Panel1.Controls.Add(Me.txtDescripcion_Agrup)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCod_Producto)
        Me.Panel1.Controls.Add(Me.txtTip_Item)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 28)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(693, 394)
        Me.Panel1.TabIndex = 259
        '
        'txtCod_Producto
        '
        Me.txtCod_Producto.AcceptsReturn = True
        Me.txtCod_Producto.BackColor = System.Drawing.SystemColors.Window
        Me.txtCod_Producto.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCod_Producto.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCod_Producto.Location = New System.Drawing.Point(178, 29)
        Me.txtCod_Producto.MaxLength = 100
        Me.txtCod_Producto.Name = "txtCod_Producto"
        Me.txtCod_Producto.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCod_Producto.Size = New System.Drawing.Size(104, 20)
        Me.txtCod_Producto.TabIndex = 103
        '
        'txtTip_Item
        '
        Me.txtTip_Item.AcceptsReturn = True
        Me.txtTip_Item.BackColor = System.Drawing.SystemColors.Window
        Me.txtTip_Item.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTip_Item.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTip_Item.Location = New System.Drawing.Point(178, 6)
        Me.txtTip_Item.MaxLength = 100
        Me.txtTip_Item.Name = "txtTip_Item"
        Me.txtTip_Item.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTip_Item.Size = New System.Drawing.Size(45, 20)
        Me.txtTip_Item.TabIndex = 101
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(8, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(179, 13)
        Me.Label1.TabIndex = 102
        Me.Label1.Text = "Código de Producto ........................."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(8, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 100
        Me.Label2.Text = "Tipo Item (P/D) ................................."
        '
        'txtDescripcion
        '
        Me.txtDescripcion.AcceptsReturn = True
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion.Location = New System.Drawing.Point(178, 52)
        Me.txtDescripcion.MaxLength = 100
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion.Size = New System.Drawing.Size(505, 71)
        Me.txtDescripcion.TabIndex = 105
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(8, 52)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(177, 13)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "Descripción ....................................."
        '
        'txtDescripcion_Agrup
        '
        Me.txtDescripcion_Agrup.AcceptsReturn = True
        Me.txtDescripcion_Agrup.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion_Agrup.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion_Agrup.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion_Agrup.Location = New System.Drawing.Point(178, 126)
        Me.txtDescripcion_Agrup.MaxLength = 100
        Me.txtDescripcion_Agrup.Multiline = True
        Me.txtDescripcion_Agrup.Name = "txtDescripcion_Agrup"
        Me.txtDescripcion_Agrup.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion_Agrup.Size = New System.Drawing.Size(505, 71)
        Me.txtDescripcion_Agrup.TabIndex = 107
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(8, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(178, 13)
        Me.Label5.TabIndex = 106
        Me.Label5.Text = "Descripción Agrupador ...................."
        '
        'txtDescripcion_CliExt
        '
        Me.txtDescripcion_CliExt.AcceptsReturn = True
        Me.txtDescripcion_CliExt.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion_CliExt.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDescripcion_CliExt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDescripcion_CliExt.Location = New System.Drawing.Point(178, 200)
        Me.txtDescripcion_CliExt.MaxLength = 100
        Me.txtDescripcion_CliExt.Multiline = True
        Me.txtDescripcion_CliExt.Name = "txtDescripcion_CliExt"
        Me.txtDescripcion_CliExt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDescripcion_CliExt.Size = New System.Drawing.Size(505, 71)
        Me.txtDescripcion_CliExt.TabIndex = 109
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(199, 13)
        Me.Label6.TabIndex = 108
        Me.Label6.Text = "Descripción Cliente Exterior ...................."
        '
        'txtCantidad
        '
        Me.txtCantidad.AcceptsReturn = True
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantidad.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantidad.Location = New System.Drawing.Point(178, 297)
        Me.txtCantidad.MaxLength = 100
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantidad.Size = New System.Drawing.Size(104, 20)
        Me.txtCantidad.TabIndex = 113
        Me.txtCantidad.Text = "0.00"
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtUnida_Medida
        '
        Me.txtUnida_Medida.AcceptsReturn = True
        Me.txtUnida_Medida.BackColor = System.Drawing.SystemColors.Window
        Me.txtUnida_Medida.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUnida_Medida.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtUnida_Medida.Location = New System.Drawing.Point(178, 274)
        Me.txtUnida_Medida.MaxLength = 100
        Me.txtUnida_Medida.Name = "txtUnida_Medida"
        Me.txtUnida_Medida.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUnida_Medida.Size = New System.Drawing.Size(45, 20)
        Me.txtUnida_Medida.TabIndex = 111
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(8, 304)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Cantidad ........................................."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(8, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(193, 13)
        Me.Label8.TabIndex = 110
        Me.Label8.Text = "Unidad Medida ....................................."
        '
        'txtImp_Total
        '
        Me.txtImp_Total.AcceptsReturn = True
        Me.txtImp_Total.BackColor = System.Drawing.SystemColors.Window
        Me.txtImp_Total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImp_Total.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImp_Total.Location = New System.Drawing.Point(178, 343)
        Me.txtImp_Total.MaxLength = 100
        Me.txtImp_Total.Name = "txtImp_Total"
        Me.txtImp_Total.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImp_Total.Size = New System.Drawing.Size(104, 20)
        Me.txtImp_Total.TabIndex = 117
        Me.txtImp_Total.Text = "0.00"
        Me.txtImp_Total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtImp_Unitario
        '
        Me.txtImp_Unitario.AcceptsReturn = True
        Me.txtImp_Unitario.BackColor = System.Drawing.SystemColors.Window
        Me.txtImp_Unitario.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtImp_Unitario.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtImp_Unitario.Location = New System.Drawing.Point(178, 320)
        Me.txtImp_Unitario.MaxLength = 100
        Me.txtImp_Unitario.Name = "txtImp_Unitario"
        Me.txtImp_Unitario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtImp_Unitario.Size = New System.Drawing.Size(104, 20)
        Me.txtImp_Unitario.TabIndex = 115
        Me.txtImp_Unitario.Text = "0.00"
        Me.txtImp_Unitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(8, 350)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(180, 13)
        Me.Label9.TabIndex = 116
        Me.Label9.Text = "Importe Total ...................................."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(8, 327)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(174, 13)
        Me.Label10.TabIndex = 114
        Me.Label10.Text = "Importe Unitario .............................."
        '
        'txtCantUniAlter
        '
        Me.txtCantUniAlter.AcceptsReturn = True
        Me.txtCantUniAlter.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantUniAlter.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtCantUniAlter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtCantUniAlter.Location = New System.Drawing.Point(178, 366)
        Me.txtCantUniAlter.MaxLength = 100
        Me.txtCantUniAlter.Name = "txtCantUniAlter"
        Me.txtCantUniAlter.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCantUniAlter.Size = New System.Drawing.Size(104, 20)
        Me.txtCantUniAlter.TabIndex = 119
        Me.txtCantUniAlter.Text = "0.00"
        Me.txtCantUniAlter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(8, 373)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(178, 13)
        Me.Label11.TabIndex = 118
        Me.Label11.Text = "Cantidad en Unidad Alternativa ......."
        '
        'txtPorc_Commision
        '
        Me.txtPorc_Commision.AcceptsReturn = True
        Me.txtPorc_Commision.BackColor = System.Drawing.SystemColors.Window
        Me.txtPorc_Commision.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPorc_Commision.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtPorc_Commision.Location = New System.Drawing.Point(579, 320)
        Me.txtPorc_Commision.MaxLength = 100
        Me.txtPorc_Commision.Name = "txtPorc_Commision"
        Me.txtPorc_Commision.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPorc_Commision.Size = New System.Drawing.Size(104, 20)
        Me.txtPorc_Commision.TabIndex = 121
        Me.txtPorc_Commision.Text = "0.00"
        Me.txtPorc_Commision.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(462, 327)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(121, 13)
        Me.Label12.TabIndex = 120
        Me.Label12.Text = "Comisión ......................."
        '
        'cmdBuscar
        '
        Me.cmdBuscar.ImageKey = "48px-Crystal_Clear_action_apply.png"
        Me.cmdBuscar.ImageSize = New System.Drawing.Size(32, 32)
        Me.cmdBuscar.Location = New System.Drawing.Point(285, 26)
        Me.cmdBuscar.Name = "cmdBuscar"
        Me.cmdBuscar.OfficeColorScheme = Janus.Windows.UI.OfficeColorScheme.Blue
        Me.cmdBuscar.Size = New System.Drawing.Size(25, 24)
        Me.cmdBuscar.TabIndex = 122
        Me.cmdBuscar.Text = "..."
        Me.cmdBuscar.VisualStyle = Janus.Windows.UI.VisualStyle.Office2010
        '
        'FrmDocumentoVenta_VerDetalleAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 452)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "FrmDocumentoVenta_VerDetalleAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mantenimiento Detalle"
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel4 As Panel
    Public WithEvents Label3 As Label
    Public WithEvents TxtNroCorrelativo As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtnCancelar As Janus.Windows.EditControls.UIButton
    Friend WithEvents BtnAceptar As Janus.Windows.EditControls.UIButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents cmdBuscar As Janus.Windows.EditControls.UIButton
    Public WithEvents txtPorc_Commision As TextBox
    Public WithEvents txtCantUniAlter As TextBox
    Public WithEvents txtImp_Total As TextBox
    Public WithEvents txtImp_Unitario As TextBox
    Public WithEvents txtCantidad As TextBox
    Public WithEvents txtUnida_Medida As TextBox
    Public WithEvents txtDescripcion_CliExt As TextBox
    Public WithEvents txtDescripcion_Agrup As TextBox
    Public WithEvents txtDescripcion As TextBox
    Public WithEvents txtCod_Producto As TextBox
    Public WithEvents txtTip_Item As TextBox
    Public WithEvents Label11 As Label
    Public WithEvents Label9 As Label
    Public WithEvents Label10 As Label
    Public WithEvents Label7 As Label
    Public WithEvents Label8 As Label
    Public WithEvents Label12 As Label
    Public WithEvents Label6 As Label
    Public WithEvents Label5 As Label
    Public WithEvents Label4 As Label
    Public WithEvents Label1 As Label
    Public WithEvents Label2 As Label
End Class
