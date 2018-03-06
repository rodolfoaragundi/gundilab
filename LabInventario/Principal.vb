Imports System.Data.OleDb
Public Class Principal

#Region "Public Variables"

    Dim conn As New OleDbConnection(strProvider)
    Dim editedRow As Integer
    Dim vCosto As String

#End Region


    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles Me.Load
        fillCmbProduct()
        fillCmbProveedor()
        fillDg()


        cmbTipo.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1
        cmbProovedor.SelectedIndex = -1
    End Sub
    Private Sub fillDg()


        Dim sql As String = "SELECT Movimientos.nomproveedor as Proveedor,Movimientos.Producto, Movimientos.Costo, Existencias.CantidadEx as Cantidad from Existencias, Movimientos where existencias.idproduct = movimientos.idproduct group by Movimientos.nomproveedor ,Movimientos.Producto, Movimientos.Costo, Existencias.CantidadEx"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim dsDg As New DataSet()

        Try
            dsDg.Clear()
        Catch ex As Exception

        End Try

        conn.Open()
        dataadapter.Fill(dsDg, "Movimientos_table")
        conn.Close()

        dgExistencia.DataSource = dsDg
        dgExistencia.DataMember = "Movimientos_table"

    End Sub
    Private Sub fillCmbProduct()

        Dim sql As String = "SELECT idproduct, Producto  FROM Producto"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "Producto_table")
        conn.Close()
        cmbProducto.DataSource = ds.Tables(0)
        cmbProducto.ValueMember = "idproduct"
        cmbProducto.DisplayMember = "producto"
        conn.Close()

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
    Private Sub getCostoValue()
        Dim sql As String = "SELECT costo FROM Producto where idProduct = " & cmbProducto.SelectedValue
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "costo_table")
        conn.Close()

        vCosto = ds.Tables(0).Rows(0).Item("costo").ToString


    End Sub

    Private Sub setProveedorCmb()
        Dim sql As String = "SELECT idprov FROM Producto where idProduct = " & cmbProducto.SelectedValue
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "costo_table")
        conn.Close()

        cmbProovedor.SelectedValue = ds.Tables(0).Rows(0).Item("idProv").ToString

    End Sub

    Private Sub btnCrearProveedor_Click(sender As Object, e As EventArgs) Handles btnCrearProveedor.Click
        Proveedor.Owner = Me
        Proveedor.ShowDialog()

        fillCmbProduct()
        fillCmbProveedor()
        cmbProducto.SelectedIndex = -1
        cmbProovedor.SelectedIndex = -1
    End Sub

    Private Sub btnCrearProductos_Click(sender As Object, e As EventArgs) Handles btnCrearProductos.Click
        Producto.Owner = Me
        Producto.ShowDialog()

        fillCmbProduct()
        fillCmbProveedor()
        cmbProducto.SelectedIndex = -1
        cmbProovedor.SelectedIndex = -1
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        conn.Open()

        If txbCantidadEntrada.Text = "" Then txbCantidadEntrada.Text = 0
        If txbCantidadSalida.Text = "" Then txbCantidadSalida.Text = 0

        Dim addUser As String = "insert into movimientos  (idproduct, idprov,costo,producto,nomproveedor,tipo, fecha, cantidadEntrada, cantidadSalida, factura,cheque ) values ('" & cmbProducto.SelectedValue & "', '" & _
            cmbProovedor.SelectedValue & "', '" & vCosto & "', '" & cmbProducto.Text & "', '" & cmbProovedor.Text & "', '" & cmbTipo.Text & "', '" & _
            dpFecha.Value.ToString("dd/MM/yyyy") & "', " & txbCantidadEntrada.Text & ", " & txbCantidadSalida.Text & ", '" & txbFactura.Text & "', '" & txbCheque.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        'check if the item exists in the existencias table
        Dim sql As String = "SELECT idProduct, CantidadEx FROM existencias where idProduct = " & cmbProducto.SelectedValue
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "existencia_table")
        conn.Close()

        Dim vProdExist As String
        Try
            vProdExist = ds.Tables(0).Rows(0).Item("idproduct").ToString
        Catch
            vProdExist = ""
        End Try

        Dim vProdExistCant As Integer
        Try
            vProdExistCant = ds.Tables(0).Rows(0).Item("CantidadEx").ToString()
        Catch
            vProdExistCant = 0
        End Try


        'cantidad depending if its entrada or salida
        Dim CantEx As Integer
        If cmbTipo.Text = "Entrada" Then
            CantEx = txbCantidadEntrada.Text
        Else
            CantEx = txbCantidadSalida.Text
        End If


        conn.Open()
        'Update or Insert into Existencias
        If vProdExist <> "" Then

            If cmbTipo.Text = "Entrada" Then
                addUser = "Update Existencias set CantidadEx = " & vProdExistCant + CantEx & " where idProduct = " & cmbProducto.SelectedValue
                Dim cmdUpd As OleDbCommand = New OleDbCommand(addUser, conn)
                cmdUpd.ExecuteNonQuery()
            Else
                addUser = "Update Existencias set CantidadEx = " & vProdExistCant - CantEx & " where idProduct = " & cmbProducto.SelectedValue
                Dim cmdUpd As OleDbCommand = New OleDbCommand(addUser, conn)
                cmdUpd.ExecuteNonQuery()
            End If
        Else
            addUser = "insert into existencias (idProduct, CantidadEx) values ('" & cmbProducto.SelectedValue & "', " & CantEx & ")"
            Dim cmdUpd As OleDbCommand = New OleDbCommand(addUser, conn)
            cmdUpd.ExecuteNonQuery()
        End If
        conn.Close()

        'clean form
        cmbTipo.SelectedIndex = -1
        cmbProducto.SelectedIndex = -1
        cmbProovedor.SelectedIndex = -1
        txbCantidadEntrada.Text = ""
        txbCantidadSalida.Text = ""
        txbCheque.Text = ""
        txbFactura.Text = ""


        'Try
        '    dgExistencia.DataSource = Nothing
        'Catch

        'End Try

        Call fillDg()
        'dgExistencia.Refresh()


    End Sub



    Private Sub cmbProducto_LostFocus(sender As Object, e As EventArgs) Handles cmbProducto.LostFocus
        If cmbProducto.SelectedIndex <> -1 Then
            Call getCostoValue()
            Call setProveedorCmb()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipo.SelectedIndexChanged
        If cmbTipo.Text = "Entrada" Then
            lblCheque.Visible = True
            lblFactura.Visible = True
            txbCheque.Visible = True
            txbFactura.Visible = True
            txbCantidadEntrada.Visible = True
            txbCantidadSalida.Visible = False
        Else
            lblCheque.Visible = False
            lblFactura.Visible = False
            txbCheque.Visible = False
            txbFactura.Visible = False
            txbCantidadSalida.Visible = True
            txbCantidadEntrada.Visible = False
        End If
    End Sub

    Private Sub btnDetalle_Click(sender As Object, e As EventArgs) Handles btnDetalle.Click
        Detalle.Owner = Me
        Detalle.ShowDialog()
    End Sub
End Class
