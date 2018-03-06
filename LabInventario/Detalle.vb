Imports System.Data.OleDb
Public Class Detalle
#Region "Public Variables"

    Dim conn As New OleDbConnection(strProvider)
    Dim editedRow As Integer
    Dim vCosto As String

#End Region

    Private Sub Detalle_Load(sender As Object, e As EventArgs) Handles Me.Load
        fillDg()
    End Sub

    Private Sub fillDg()
        Dim sql As String

        If chbTodos.Checked = True Then
            sql = "SELECT NomProveedor as Proveedor, Producto, Tipo as [Tipo de Movimiento], Fecha, CantidadEntrada + CantidadSalida as Cantidad, Factura, Cheque from Movimientos where year(fecha) = " & Now.Year
        Else
            sql = "SELECT NomProveedor as Proveedor, Producto, Tipo , Fecha, CantidadEntrada + CantidadSalida as Cantidad, Factura, Cheque from Movimientos where day(fecha) & '/' & month(fecha) & '/' & year(fecha) between '" & DpDesde.Value.ToString("dd/MM/yyyy") & "' and '" & DpHasta.Value.ToString("dd/MM/yyyy") & "'"
        End If

        Dim dataadapter As New OleDbDataAdapter(Sql, conn)
        Dim dsDg As New DataSet()

        Try
            dsDg.Clear()
        Catch ex As Exception

        End Try

        conn.Open()
        dataadapter.Fill(dsDg, "Movimientos_table")
        conn.Close()

        dgDetalle.DataSource = dsDg
        dgDetalle.DataMember = "Movimientos_table"

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        fillDg()
    End Sub
End Class