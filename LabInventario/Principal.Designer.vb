<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Principal))
        Me.btnCrearProductos = New System.Windows.Forms.Button()
        Me.btnCrearProveedor = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txbCantidadSalida = New System.Windows.Forms.TextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.lblCheque = New System.Windows.Forms.Label()
        Me.lblFactura = New System.Windows.Forms.Label()
        Me.txbCheque = New System.Windows.Forms.TextBox()
        Me.txbFactura = New System.Windows.Forms.TextBox()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txbCantidadEntrada = New System.Windows.Forms.TextBox()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.cmbProovedor = New System.Windows.Forms.ComboBox()
        Me.lblTipo = New System.Windows.Forms.Label()
        Me.dpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cmbProducto = New System.Windows.Forms.ComboBox()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.lblProovedor = New System.Windows.Forms.Label()
        Me.dgExistencia = New System.Windows.Forms.DataGridView()
        Me.lblExistencias = New System.Windows.Forms.Label()
        Me.btnDetalle = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgExistencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCrearProductos
        '
        Me.btnCrearProductos.Location = New System.Drawing.Point(656, 19)
        Me.btnCrearProductos.Name = "btnCrearProductos"
        Me.btnCrearProductos.Size = New System.Drawing.Size(143, 23)
        Me.btnCrearProductos.TabIndex = 13
        Me.btnCrearProductos.Text = "Crear Productos"
        Me.btnCrearProductos.UseVisualStyleBackColor = True
        '
        'btnCrearProveedor
        '
        Me.btnCrearProveedor.Location = New System.Drawing.Point(496, 19)
        Me.btnCrearProveedor.Name = "btnCrearProveedor"
        Me.btnCrearProveedor.Size = New System.Drawing.Size(143, 23)
        Me.btnCrearProveedor.TabIndex = 12
        Me.btnCrearProveedor.Text = "Crear Proveedor"
        Me.btnCrearProveedor.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txbCantidadSalida)
        Me.GroupBox1.Controls.Add(Me.cmbTipo)
        Me.GroupBox1.Controls.Add(Me.lblCheque)
        Me.GroupBox1.Controls.Add(Me.lblFactura)
        Me.GroupBox1.Controls.Add(Me.txbCheque)
        Me.GroupBox1.Controls.Add(Me.txbFactura)
        Me.GroupBox1.Controls.Add(Me.btnCrearProductos)
        Me.GroupBox1.Controls.Add(Me.lblCantidad)
        Me.GroupBox1.Controls.Add(Me.btnCrearProveedor)
        Me.GroupBox1.Controls.Add(Me.txbCantidadEntrada)
        Me.GroupBox1.Controls.Add(Me.btnBorrar)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.cmbProovedor)
        Me.GroupBox1.Controls.Add(Me.lblTipo)
        Me.GroupBox1.Controls.Add(Me.dpFecha)
        Me.GroupBox1.Controls.Add(Me.cmbProducto)
        Me.GroupBox1.Controls.Add(Me.lblProducto)
        Me.GroupBox1.Controls.Add(Me.lblProovedor)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 245)
        Me.GroupBox1.TabIndex = 99
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Control de Inventario"
        '
        'txbCantidadSalida
        '
        Me.txbCantidadSalida.Location = New System.Drawing.Point(139, 156)
        Me.txbCantidadSalida.Name = "txbCantidadSalida"
        Me.txbCantidadSalida.Size = New System.Drawing.Size(100, 20)
        Me.txbCantidadSalida.TabIndex = 18
        Me.txbCantidadSalida.Visible = False
        '
        'cmbTipo
        '
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Items.AddRange(New Object() {"Entrada", "Salida"})
        Me.cmbTipo.Location = New System.Drawing.Point(139, 51)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipo.TabIndex = 0
        '
        'lblCheque
        '
        Me.lblCheque.AutoSize = True
        Me.lblCheque.Location = New System.Drawing.Point(261, 188)
        Me.lblCheque.Name = "lblCheque"
        Me.lblCheque.Size = New System.Drawing.Size(44, 13)
        Me.lblCheque.TabIndex = 17
        Me.lblCheque.Text = "Cheque"
        Me.lblCheque.Visible = False
        '
        'lblFactura
        '
        Me.lblFactura.AutoSize = True
        Me.lblFactura.Location = New System.Drawing.Point(90, 189)
        Me.lblFactura.Name = "lblFactura"
        Me.lblFactura.Size = New System.Drawing.Size(43, 13)
        Me.lblFactura.TabIndex = 16
        Me.lblFactura.Text = "Factura"
        Me.lblFactura.Visible = False
        '
        'txbCheque
        '
        Me.txbCheque.Location = New System.Drawing.Point(139, 182)
        Me.txbCheque.Name = "txbCheque"
        Me.txbCheque.Size = New System.Drawing.Size(100, 20)
        Me.txbCheque.TabIndex = 5
        Me.txbCheque.Visible = False
        '
        'txbFactura
        '
        Me.txbFactura.Location = New System.Drawing.Point(306, 182)
        Me.txbFactura.Name = "txbFactura"
        Me.txbFactura.Size = New System.Drawing.Size(100, 20)
        Me.txbFactura.TabIndex = 6
        Me.txbFactura.Visible = False
        '
        'lblCantidad
        '
        Me.lblCantidad.AutoSize = True
        Me.lblCantidad.Location = New System.Drawing.Point(84, 161)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(49, 13)
        Me.lblCantidad.TabIndex = 11
        Me.lblCantidad.Text = "Cantidad"
        '
        'txbCantidadEntrada
        '
        Me.txbCantidadEntrada.Location = New System.Drawing.Point(139, 156)
        Me.txbCantidadEntrada.Name = "txbCantidadEntrada"
        Me.txbCantidadEntrada.Size = New System.Drawing.Size(100, 20)
        Me.txbCantidadEntrada.TabIndex = 4
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(658, 216)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(141, 23)
        Me.btnBorrar.TabIndex = 8
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(498, 216)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(37, 84)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(96, 13)
        Me.lblFecha.TabIndex = 8
        Me.lblFecha.Text = "Fecha del Registro"
        '
        'cmbProovedor
        '
        Me.cmbProovedor.Enabled = False
        Me.cmbProovedor.FormattingEnabled = True
        Me.cmbProovedor.Location = New System.Drawing.Point(139, 102)
        Me.cmbProovedor.Name = "cmbProovedor"
        Me.cmbProovedor.Size = New System.Drawing.Size(267, 21)
        Me.cmbProovedor.TabIndex = 2
        '
        'lblTipo
        '
        Me.lblTipo.AutoSize = True
        Me.lblTipo.Location = New System.Drawing.Point(48, 55)
        Me.lblTipo.Name = "lblTipo"
        Me.lblTipo.Size = New System.Drawing.Size(85, 13)
        Me.lblTipo.TabIndex = 7
        Me.lblTipo.Text = "Tipo de Registro"
        '
        'dpFecha
        '
        Me.dpFecha.Location = New System.Drawing.Point(139, 78)
        Me.dpFecha.Name = "dpFecha"
        Me.dpFecha.Size = New System.Drawing.Size(200, 20)
        Me.dpFecha.TabIndex = 1
        '
        'cmbProducto
        '
        Me.cmbProducto.FormattingEnabled = True
        Me.cmbProducto.Items.AddRange(New Object() {"seleccione uno"})
        Me.cmbProducto.Location = New System.Drawing.Point(139, 129)
        Me.cmbProducto.Name = "cmbProducto"
        Me.cmbProducto.Size = New System.Drawing.Size(267, 21)
        Me.cmbProducto.TabIndex = 3
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(83, 137)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(50, 13)
        Me.lblProducto.TabIndex = 5
        Me.lblProducto.Text = "Producto"
        '
        'lblProovedor
        '
        Me.lblProovedor.AutoSize = True
        Me.lblProovedor.Location = New System.Drawing.Point(77, 110)
        Me.lblProovedor.Name = "lblProovedor"
        Me.lblProovedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProovedor.TabIndex = 4
        Me.lblProovedor.Text = "Proovedor"
        '
        'dgExistencia
        '
        Me.dgExistencia.AllowUserToAddRows = False
        Me.dgExistencia.AllowUserToDeleteRows = False
        Me.dgExistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgExistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgExistencia.Location = New System.Drawing.Point(12, 289)
        Me.dgExistencia.Name = "dgExistencia"
        Me.dgExistencia.ReadOnly = True
        Me.dgExistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgExistencia.Size = New System.Drawing.Size(805, 336)
        Me.dgExistencia.TabIndex = 15
        '
        'lblExistencias
        '
        Me.lblExistencias.AutoSize = True
        Me.lblExistencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExistencias.Location = New System.Drawing.Point(13, 264)
        Me.lblExistencias.Name = "lblExistencias"
        Me.lblExistencias.Size = New System.Drawing.Size(60, 13)
        Me.lblExistencias.TabIndex = 16
        Me.lblExistencias.Text = "Existencias"
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(668, 631)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(143, 23)
        Me.btnDetalle.TabIndex = 100
        Me.btnDetalle.Text = "Ver Detalle "
        Me.btnDetalle.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(829, 658)
        Me.Controls.Add(Me.btnDetalle)
        Me.Controls.Add(Me.lblExistencias)
        Me.Controls.Add(Me.dgExistencia)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(845, 697)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgExistencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCrearProveedor As System.Windows.Forms.Button
    Friend WithEvents btnCrearProductos As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCantidad As System.Windows.Forms.Label
    Friend WithEvents txbCantidadEntrada As System.Windows.Forms.TextBox
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents cmbProovedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblTipo As System.Windows.Forms.Label
    Friend WithEvents dpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbProducto As System.Windows.Forms.ComboBox
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents lblProovedor As System.Windows.Forms.Label
    Friend WithEvents txbFactura As System.Windows.Forms.TextBox
    Friend WithEvents lblCheque As System.Windows.Forms.Label
    Friend WithEvents lblFactura As System.Windows.Forms.Label
    Friend WithEvents txbCheque As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipo As System.Windows.Forms.ComboBox
    Friend WithEvents dgExistencia As System.Windows.Forms.DataGridView
    Friend WithEvents lblExistencias As System.Windows.Forms.Label
    Friend WithEvents txbCantidadSalida As System.Windows.Forms.TextBox
    Friend WithEvents btnDetalle As System.Windows.Forms.Button

End Class
