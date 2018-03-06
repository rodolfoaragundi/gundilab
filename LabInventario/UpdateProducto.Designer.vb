<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProducto))
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblProducto = New System.Windows.Forms.Label()
        Me.txbProducto = New System.Windows.Forms.TextBox()
        Me.lblCosto = New System.Windows.Forms.Label()
        Me.txbCosto = New System.Windows.Forms.TextBox()
        Me.cmbProovedor = New System.Windows.Forms.ComboBox()
        Me.lblProovedor = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(249, 134)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Actualizar Producto"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblProducto
        '
        Me.lblProducto.AutoSize = True
        Me.lblProducto.Location = New System.Drawing.Point(12, 64)
        Me.lblProducto.Name = "lblProducto"
        Me.lblProducto.Size = New System.Drawing.Size(105, 13)
        Me.lblProducto.TabIndex = 6
        Me.lblProducto.Text = "Nombre de Producto"
        '
        'txbProducto
        '
        Me.txbProducto.Location = New System.Drawing.Point(13, 89)
        Me.txbProducto.Name = "txbProducto"
        Me.txbProducto.Size = New System.Drawing.Size(369, 20)
        Me.txbProducto.TabIndex = 5
        '
        'lblCosto
        '
        Me.lblCosto.AutoSize = True
        Me.lblCosto.Location = New System.Drawing.Point(13, 118)
        Me.lblCosto.Name = "lblCosto"
        Me.lblCosto.Size = New System.Drawing.Size(34, 13)
        Me.lblCosto.TabIndex = 9
        Me.lblCosto.Text = "Costo"
        '
        'txbCosto
        '
        Me.txbCosto.Location = New System.Drawing.Point(12, 136)
        Me.txbCosto.Name = "txbCosto"
        Me.txbCosto.Size = New System.Drawing.Size(100, 20)
        Me.txbCosto.TabIndex = 8
        '
        'cmbProovedor
        '
        Me.cmbProovedor.FormattingEnabled = True
        Me.cmbProovedor.Location = New System.Drawing.Point(16, 34)
        Me.cmbProovedor.Name = "cmbProovedor"
        Me.cmbProovedor.Size = New System.Drawing.Size(267, 21)
        Me.cmbProovedor.TabIndex = 10
        '
        'lblProovedor
        '
        Me.lblProovedor.AutoSize = True
        Me.lblProovedor.Location = New System.Drawing.Point(13, 12)
        Me.lblProovedor.Name = "lblProovedor"
        Me.lblProovedor.Size = New System.Drawing.Size(56, 13)
        Me.lblProovedor.TabIndex = 11
        Me.lblProovedor.Text = "Proovedor"
        '
        'UpdateProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 174)
        Me.Controls.Add(Me.cmbProovedor)
        Me.Controls.Add(Me.lblProovedor)
        Me.Controls.Add(Me.lblCosto)
        Me.Controls.Add(Me.txbCosto)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblProducto)
        Me.Controls.Add(Me.txbProducto)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "UpdateProducto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents lblProducto As System.Windows.Forms.Label
    Friend WithEvents txbProducto As System.Windows.Forms.TextBox
    Friend WithEvents lblCosto As System.Windows.Forms.Label
    Friend WithEvents txbCosto As System.Windows.Forms.TextBox
    Friend WithEvents cmbProovedor As System.Windows.Forms.ComboBox
    Friend WithEvents lblProovedor As System.Windows.Forms.Label
End Class
