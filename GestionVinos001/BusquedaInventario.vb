Public Class BusquedaInventario
    Public tipo, unidad, stock, sucursal As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal t As String, ByVal s As String, ByVal c As Odbc.OdbcConnection) As Boolean
        sucursal = s
        tipo = t
        con = c
        com.Connection = con
        com.CommandText = "select tiene.*,inventario.unidad from inventario,tiene where inventario.tipo=tiene.tipo and inventario.tipo='" _
            & tipo & "' and tiene.id_sucursal=" & sucursal

        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            tipo = ds.Tables("resultado").Rows(0).Item("tipo")
            unidad = ds.Tables("resultado").Rows(0).Item("unidad")
            stock = ds.Tables("resultado").Rows(0).Item("stock")
            sucursal = ds.Tables("resultado").Rows(0).Item("id_sucursal")
            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from tiene where tipo='" & tipo & "' ; delete from inventario where tipo='" & tipo & "'"
        Try
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Baja de inventario " & tipo & " exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        End Try
    End Sub

    Public Sub modificar(ByVal s As String, ByVal u As String)
        com.CommandText = "update inventario set unidad='" & u & "' where tipo='" & tipo & "'; update tiene set " _
            & "stock=" & s & ", fecha='" & Date.Now.ToString("dd/MM/yyyy") & "' where tipo='" & tipo & "' and id_sucursal=" & sucursal
        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Actualización exitosa")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
