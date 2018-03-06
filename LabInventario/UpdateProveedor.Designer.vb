<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateProveedor))
        Me.txbProovedor = New System.Windows.Forms.TextBox()
        Me.lblProovedor = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txbProovedor
        '
        Me.txbProovedor.Location = New System.Drawing.Point(13, 55)
        Me.txbProovedor.Name = "txbProovedor"
        Me.txbProovedor.Size = New System.Drawing.Size(369, 20)
        Me.txbProovedor.TabIndex = 2
        '
        'lblProovedor
        '
        Me.lblProovedor.AutoSize = True
        Me.lblProovedor.Location = New System.Drawing.Point(12, 30)
        Me.lblProovedor.Name = "lblProovedor"
        Me.lblProovedor.Size = New System.Drawing.Size(111, 13)
        Me.lblProovedor.TabIndex = 3
        Me.lblProovedor.Text = "Nombre de Proovedor"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(249, 96)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(133, 23)
        Me.btnGuardar.TabIndex = 4
        Me.btnGuardar.Text = "Actualizar Proveedor"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'UpdateProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 131)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblProovedor)
        Me.Controls.Add(Me.txbProovedor)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "UpdateProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modificar Proveedor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txbProovedor As System.Windows.Forms.TextBox
    Friend WithEvents lblProovedor As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
End Class
