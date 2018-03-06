Imports System.Data.OleDb
Public Class Producto

#Region "Public Variables"

    Dim conn As New OleDbConnection(strProvider)
    Dim editedRow As Integer

#End Region

    Private Sub Proovedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call fillDg()
        Call fillCmbProveedor()
        cmbProovedor.SelectedIndex = -1
        dgProducto.Columns(0).Visible = False 'hides id column so it cant be edited
        dgProducto.Columns(1).Visible = False

    End Sub
    Private Sub fillDg()

        Dim sql As String = "SELECT producto.idproduct, producto.idProv, proveedor.nomproveedor as Proveedor, producto.producto, producto.costo  FROM producto, proveedor where producto.idprov = proveedor.idprov"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "Producto_table")
        conn.Close()
        dgProducto.DataSource = ds
        dgProducto.DataMember = "Producto_table"

    End Sub
    Private Sub fillCmbProveedor()

        Dim sql As String = "SELECT idprov, nomProveedor FROM Proveedor"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "Proveedor_table")
        conn.Close()
        cmbProovedor.DataSource = ds.Tables(0)
        cmbProovedor.ValueMember = "idProv"
        cmbProovedor.DisplayMember = "nomProveedor"
        conn.Close()

    End Sub
    Private Sub updateDg(ByVal nom As String, ByVal costo As String, ByVal idprov As Integer, ByVal idProd As Integer)
        conn.Open()
        Dim addUser As String = "update producto set producto = '" & nom & "', costo = '" & costo & "' , idprov ='" & idprov & "' where idproduct = " & idProd
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        Call fillDg()
        dgProducto.ClearSelection()

    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        conn.Open()
        Dim addUser As String = "delete from Producto where IdProduct = " & dgProducto.SelectedRows.Item(0).Cells(0).Value
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        Call fillDg()
        dgProducto.Refresh()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        conn.Open()
        Dim addUser As String = "insert into Producto  (costo, producto, idprov) values ('" & txbCosto.Text & "', '" & txbProducto.Text & "', " & cmbProovedor.SelectedValue & ")"
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        txbProducto.Text = ""
        txbCosto.Text = ""
        cmbProovedor.SelectedIndex = -1

        Call fillDg()
        dgProducto.Refresh()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

        Try

            Dim idProd = dgProducto.SelectedRows.Item(0).Cells(0).Value
            editedRow = dgProducto.CurrentCell.RowIndex.ToString()

            Dim frmUpdProducto As New UpdateProducto
            frmUpdProducto.txbProducto.Text = dgProducto.SelectedRows.Item(0).Cells(3).Value.ToString
            frmUpdProducto.txbCosto.Text = dgProducto.SelectedRows.Item(0).Cells(4).Value.ToString
            'frmUpdProducto.cmbProovedor.SelectedValue = dgProducto.SelectedRows.Item(0).Cells(1).Value.ToString
            frmUpdProducto.pcmbValue = (dgProducto.SelectedRows.Item(0).Cells(1).Value.ToString)
            frmUpdProducto.Owner = Me
            frmUpdProducto.ShowDialog()
            frmUpdProducto.Close()

            Call updateDg(frmUpdProducto.txbProducto.Text, frmUpdProducto.txbCosto.Text, frmUpdProducto.cmbProovedor.SelectedValue, idProd)

            dgProducto.Rows(editedRow).Selected = True
        Catch
            MsgBox("Seleccione un Articulo Primero")
        End Try


    End Sub

    Private Sub dgProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProducto.CellDoubleClick

        Try

            Dim idProd = dgProducto.SelectedRows.Item(0).Cells(0).Value
            editedRow = dgProducto.CurrentCell.RowIndex.ToString()

            Dim frmUpdProducto As New UpdateProducto
            frmUpdProducto.txbProducto.Text = dgProducto.SelectedRows.Item(0).Cells(3).Value.ToString
            frmUpdProducto.txbCosto.Text = dgProducto.SelectedRows.Item(0).Cells(4).Value.ToString
            'frmUpdProducto.cmbProovedor.SelectedValue = dgProducto.SelectedRows.Item(0).Cells(1).Value.ToString
            frmUpdProducto.pcmbValue = (dgProducto.SelectedRows.Item(0).Cells(1).Value.ToString)
            frmUpdProducto.Owner = Me
            frmUpdProducto.ShowDialog()
            frmUpdProducto.Close()

            Call updateDg(frmUpdProducto.txbProducto.Text, frmUpdProducto.txbCosto.Text, frmUpdProducto.cmbProovedor.SelectedValue, idProd)

            dgProducto.Rows(editedRow).Selected = True
        Catch
            MsgBox("Seleccione un Articulo Primero")
        End Try

    End Sub

End Class