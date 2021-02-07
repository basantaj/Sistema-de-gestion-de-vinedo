Imports System.Globalization

Public Class AltaInventario
    Dim stock, tipo, unidad, fecha, sucursal As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal sto As String, ByVal t As String, ByVal u As String, ByVal f As String, ByVal suc As String, ByVal c As Odbc.OdbcConnection)
        stock = sto
        tipo = t
        unidad = u
        fecha = f
        sucursal = suc

        con = c
        com.Connection = con
        com.CommandText = "select * from inventario where tipo='" + tipo + "'"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "inventario")
        If ds.Tables("inventario").Rows.Count > 0 Then
            MsgBox("Producto " + tipo + " ya existe.")
        Else
            com.CommandText = "insert into inventario values('" + tipo + "','" + unidad + "')"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If
        com.CommandText = "select * from tiene where tipo='" + tipo + "' and id_sucursal=" + sucursal
        da.Fill(ds, "tiene")
        If ds.Tables("tiene").Rows.Count > 0 Then
            MsgBox("Ya existe un registo de " + tipo + " en la sucursal.")

        Else
            com.CommandText = "insert into tiene values(" + sucursal + ",'" + tipo + "','" + DateTime.Now.ToString("dd/MM/yyyy") + "'," + stock + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Inventario ingresado")
        End If



    End Sub


End Class
