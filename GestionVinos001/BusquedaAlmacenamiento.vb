Public Class BusquedaAlmacenamiento
    Public id, material, capacidad, tipo As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal i As String, ByVal c As Odbc.OdbcConnection) As Boolean
        id = i
        con = c
        com.Connection = con
        com.CommandText = "select * from lugar where id=" & id

        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            id = ds.Tables("resultado").Rows(0).Item("id")
            material = ds.Tables("resultado").Rows(0).Item("material")
            capacidad = ds.Tables("resultado").Rows(0).Item("capacidad")
            tipo = ds.Tables("resultado").Rows(0).Item("tipo")
            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from lugar where id=" + id
        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de contenedor " & id & "exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then
                If e.Message.Contains("is still being referenced") Then

                    MsgBox("Existen registros que dependen de esta entrada")

                End If


            End If
        Finally
            con.Close()

        End Try
    End Sub

    Public Sub modificar(ByVal t As String, ByVal m As String, ByVal c As String)
        com.CommandText = "update lugar set tipo='" & t & "',material='" & m & "',capacidad=" & c & " where id=" & id
        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Entrada actualizada")
        Catch ex As Exception
            MsgBox("Error (" & ex.Message & ")")
        Finally
            con.Close()
        End Try


    End Sub

End Class
