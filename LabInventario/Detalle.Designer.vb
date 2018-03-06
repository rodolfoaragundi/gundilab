<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalle
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
        Me.dgDetalle = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DpHasta = New System.Windows.Forms.DateTimePicker()
        Me.DpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnExportar = New System.Windows.Forms.Button()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.chbTodos = New System.Windows.Forms.CheckBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgDetalle
        '
        Me.dgDetalle.AllowUserToAddRows = False
        Me.dgDetalle.AllowUserToDeleteRows = False
        Me.dgDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgDetalle.Location = New System.Drawing.Point(19, 66)
        Me.dgDetalle.Name = "dgDetalle"
        Me.dgDetalle.ReadOnly = True
        Me.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgDetalle.Size = New System.Drawing.Size(1094, 547)
        Me.dgDetalle.TabIndex = 16
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.chbTodos)
        Me.GroupBox1.Controls.Add(Me.lblDesde)
        Me.GroupBox1.Controls.Add(Me.lblHasta)
        Me.GroupBox1.Controls.Add(Me.DpHasta)
        Me.GroupBox1.Controls.Add(Me.DpDesde)
        Me.GroupBox1.Controls.Add(Me.btnExportar)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1106, 635)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Entradas y Salidas"
        '
        'DpHasta
        '
        Me.DpHasta.Location = New System.Drawing.Point(351, 27)
        Me.DpHasta.Name = "DpHasta"
        Me.DpHasta.Size = New System.Drawing.Size(200, 20)
        Me.DpHasta.TabIndex = 103
        '
        'DpDesde
        '
        Me.DpDesde.Location = New System.Drawing.Point(70, 27)
        Me.DpDesde.Name = "DpDesde"
        Me.DpDesde.Size = New System.Drawing.Size(200, 20)
        Me.DpDesde.TabIndex = 102
        '
        'btnExportar
        '
        Me.btnExportar.Location = New System.Drawing.Point(957, 606)
        Me.btnExportar.Name = "btnExportar"
        Me.btnExportar.Size = New System.Drawing.Size(143, 23)
        Me.btnExportar.TabIndex = 101
        Me.btnExportar.Text = "Exportar a Excel"
        Me.btnExportar.UseVisualStyleBackColor = True
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(310, 27)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 104
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(25, 27)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 105
        Me.lblDesde.Text = "Desde"
        '
        'chbTodos
        '
        Me.chbTodos.AutoSize = True
        Me.chbTodos.Location = New System.Drawing.Point(862, 27)
        Me.chbTodos.Name = "chbTodos"
        Me.chbTodos.Size = New System.Drawing.Size(238, 17)
        Me.chbTodos.TabIndex = 106
        Me.chbTodos.Text = "Buscar Todos los Registros del año Presente"
        Me.chbTodos.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(571, 24)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 107
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1131, 660)
        Me.Controls.Add(Me.dgDetalle)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Detalle"
        CType(Me.dgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgDetalle As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DpHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents DpDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnExportar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents chbTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents lblHasta As System.Windows.Forms.Label
End Class
