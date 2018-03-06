<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Producto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Producto))
        Me.txbProducto = New System.Windows.Forms.TextBox()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dgProducto = New System.Windows.Forms.DataGridView()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.txbCosto = New System.Windows.Forms.TextBox()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.cmbProovedor = New System.Windows.Forms.ComboBox()
        Me.lblProovedor = New System.Windows.Forms.Label()
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txbProducto
        '
        Me.txbProducto.Location = New System.Drawing.Point(123, 58)
        Me.txbProducto.Name = "txbProducto"
        Me.txbProducto.Size = New System.Drawing.Size(369, 20)
        Me.txbProducto.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(359, 99)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar Producto"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dgProducto
        '
        Me.dgProducto.AllowUserToAddRows = False
        Me.dgProducto.AllowUserToDeleteRows = False
        Me.dgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProducto.Location = New System.Drawing.Point(12, 169)
        Me.dgProducto.Name = "dgProducto"
        Me.dgProducto.ReadOnly = True
        Me.dgProducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProducto.Size = New System.Drawing.Size(498, 291)
        Me.dgProducto.TabIndex = 4
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(6, 61)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(105, 13)
        Me.lblProducto.TabIndex = 2
        Me.lblProducto.Text = "Nombre de Producto"
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(371, 467)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(133, 23)
        Me.btnBorrar.TabIndex = 5
        Me.btnBorrar.Text = "Eliminar Producto"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbProovedor)
        Me.GroupBox1.Controls.Add(Me.lblProovedor)
        Me.GroupBox1.Controls.Add(Me.lblCosto)
        Me.GroupBox1.Controls.Add(Me.txbCosto)
        Me.GroupBox1.Controls.Add(Me.lblProducto)
        Me.GroupBox1.Controls.Add(Me.txbProducto)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 150)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Producto"
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(77, 102)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(34, 13)
        Me.lblCosto.TabIndex = 4
        Me.lblCosto.Text = "Costo"
        '
        'txbCosto
        '
        Me.txbCosto.Location = New System.Drawing.Point(123, 99)
        Me.txbCosto.Name = "txbCosto"
        Me.txbCosto.Size = New System.Drawing.Size(100, 20)
        Me.txbCosto.TabIndex = 3
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(21, 469)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(133, 23)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'cmbProovedor
        '
        Me.cmbProovedor.FormattingEnabled = True
        Me.cmbProovedor.Location = New System.Drawing.Point(123, 22)
        Me.cmbProovedor.Name = "cmbProovedor"
        Me.cmbProovedor.Size = New System.Drawing.Size(267, 21)
        Me.cmbProovedor.TabIndex = 5
        '
        'lblProovedor
        '
        Me.lblProovedor.AutoSize = True
        Me.lblProovedor.Location = New System.Drawing.Point(55, 30)
        Me.lblProovedor.Name = "lblProovedor"
        Me.lblProovedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProovedor.TabIndex = 6
        Me.lblProovedor.Text = "Proovedor"
        '
        'Producto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 508)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dgProducto)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Producto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Producto"
        CType(Me.dgProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txbProducto As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents dgProducto As System.Windows.Forms.DataGridView
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents txbCosto As System.Windows.Forms.TextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cmbProovedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblProovedor As System.Windows.Forms.Label
End Class
