Imports System.Data.OleDb

Public Class Proveedor

#Region "Public Variables"

    Dim conn As New OleDbConnection(strProvider)
    Dim editedRow As Integer

#End Region

    Private Sub Proovedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call fillDg()
        dgProovedor.Columns(0).Visible = False 'hides id column so it cant be edited

    End Sub
    Private Sub fillDg()

        Dim sql As String = "SELECT idprov, nomProveedor as Proveedor FROM Proveedor"
        Dim dataadapter As New OleDbDataAdapter(sql, conn)
        Dim ds As New DataSet()

        conn.Open()
        dataadapter.Fill(ds, "Proovedor_table")
        conn.Close()
        dgProovedor.DataSource = ds
        dgProovedor.DataMember = "Proovedor_table"
        conn.Close()

    End Sub
    Private Sub updateDg(ByVal nom As String, ByVal idProv As Integer)
        conn.Open()
        Dim addUser As String = "update proveedor set nomproveedor = '" & nom & "' where idprov = " & idProv
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        Call fillDg()
        dgProovedor.ClearSelection()

    End Sub
    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

        conn.Open()
        Dim addUser As String = "delete from Proveedor where IdProv = " & dgProovedor.SelectedRows.Item(0).Cells(0).Value
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        Call fillDg()
        dgProovedor.Refresh()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        conn.Open()
        Dim addUser As String = "insert into Proveedor  (nomProveedor) values ('" & txbProovedor.Text & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(addUser, conn)
        cmd.ExecuteNonQuery()
        'MsgBox("User added successfully")
        conn.Close()

        txbProovedor.Text = ""

        Call fillDg()
        dgProovedor.Refresh()

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try
            Dim idProv = dgProovedor.SelectedRows.Item(0).Cells(0).Value
            editedRow = dgProovedor.CurrentCell.RowIndex.ToString()

            Dim frmUpdProovedor As New UpdateProveedor
            frmUpdProovedor.txbProovedor.Text = dgProovedor.SelectedRows.Item(0).Cells(1).Value.ToString
            frmUpdProovedor.Owner = Me
            frmUpdProovedor.ShowDialog()
            frmUpdProovedor.Close()

            Call updateDg(frmUpdProovedor.txbProovedor.Text, idProv)

            dgProovedor.Rows(editedRow).Selected = True
        Catch
            MsgBox("Seleccione un Articulo Primero")
        End Try
    End Sub

    Private Sub dgProovedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgProovedor.CellDoubleClick
        Try
            Dim idProv = dgProovedor.SelectedRows.Item(0).Cells(0).Value
            editedRow = dgProovedor.CurrentCell.RowIndex.ToString()

            Dim frmUpdProovedor As New UpdateProveedor
            frmUpdProovedor.txbProovedor.Text = dgProovedor.SelectedRows.Item(0).Cells(1).Value.ToString
            frmUpdProovedor.Owner = Me
            frmUpdProovedor.ShowDialog()
            frmUpdProovedor.Close()

            Call updateDg(frmUpdProovedor.txbProovedor.Text, idProv)

            dgProovedor.Rows(editedRow).Selected = True
        Catch
            MsgBox("Seleccione un Articulo Primero")
        End Try
    End Sub
End Class