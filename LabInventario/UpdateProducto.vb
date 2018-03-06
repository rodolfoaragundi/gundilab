Imports System.Data.OleDb
Public Class UpdateProducto
#Region "Public Variables"

    Dim conn As New OleDbConnection(strProvider)
    Dim editedRow As Integer
    Friend pcmbValue As Integer
#End Region

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

    Private Sub UpdateProducto_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call fillCmbProveedor()
        cmbProovedor.SelectedValue = pcmbValue
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.Close()
    End Sub
End Class