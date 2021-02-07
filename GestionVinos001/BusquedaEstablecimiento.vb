Public Class BusquedaEstablecimiento
    Public id, direccion, nombre, telefono As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal i As String, ByVal c As Odbc.OdbcConnection) As Boolean
        id = i
        con = c
        com.Connection = con
        com.CommandText = "select * from establecimiento where id=" & id

        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            id = ds.Tables("resultado").Rows(0).Item("id")
            direccion = ds.Tables("resultado").Rows(0).Item("direccion")
            nombre = ds.Tables("resultado").Rows(0).Item("nombre")
            telefono = ds.Tables("resultado").Rows(0).Item("telefono")

            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from establecimiento where id=" + id
        Try
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Baja de establecimiento " & id & " exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub modificar(ByVal d As String, ByVal n As String, ByVal t As String)
        com.CommandText = "update establecimiento set direccion='" & d & "',nombre='" & n & "',telefono=" & t & " where id=" & id
        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Modificación exitosa")

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class
