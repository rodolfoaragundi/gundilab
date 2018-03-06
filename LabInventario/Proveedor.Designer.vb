<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblProovedor = New System.Windows.Forms.Label()
        Me.txbProovedor = New System.Windows.Forms.TextBox()
        Me.dgProovedor = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgProovedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(371, 439)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(133, 23)
        Me.btnBorrar.TabIndex = 2
        Me.btnBorrar.Text = "Eliminar Proveedor"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(359, 79)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 23)
        Me.btnGuardar.TabIndex = 0
        Me.btnGuardar.Text = "Guardar Proveedor"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblProovedor)
        Me.GroupBox1.Controls.Add(Me.txbProovedor)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 123)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Proovedor"
        '
        'lblProovedor
        '
        Me.lblProovedor.AutoSize = True
        Me.lblProovedor.Location = New System.Drawing.Point(6, 41)
        Me.lblProovedor.Name = "lblProovedor"
        Me.lblProovedor.Size = New System.Drawing.Size(111, 13)
        Me.lblProovedor.TabIndex = 2
        Me.lblProovedor.Text = "Nombre de Proovedor"
        '
        'txbProovedor
        '
        Me.txbProovedor.Location = New System.Drawing.Point(123, 38)
        Me.txbProovedor.Name = "txbProovedor"
        Me.txbProovedor.Size = New System.Drawing.Size(369, 20)
        Me.txbProovedor.TabIndex = 1
        '
        'dgProovedor
        '
        Me.dgProovedor.AllowUserToAddRows = False
        Me.dgProovedor.AllowUserToDeleteRows = False
        Me.dgProovedor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgProovedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProovedor.Location = New System.Drawing.Point(12, 141)
        Me.dgProovedor.Name = "dgProovedor"
        Me.dgProovedor.ReadOnly = True
        Me.dgProovedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgProovedor.Size = New System.Drawing.Size(498, 291)
        Me.dgProovedor.TabIndex = 1
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(21, 438)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(133, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 477)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.dgProovedor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Proveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgProovedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblProovedor As System.Windows.Forms.Label
    Friend WithEvents txbProovedor As System.Windows.Forms.TextBox
    Friend WithEvents dgProovedor As System.Windows.Forms.DataGridView
    Friend WithEvents btnModificar As System.Windows.Forms.Button
End Class
