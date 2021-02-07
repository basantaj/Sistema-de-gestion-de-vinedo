Public Class BusquedaBotella
    Public codigo, tipo, capacidad, cantidad, ruta As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal cod As String, ByVal c As Odbc.OdbcConnection) As Boolean
        codigo = cod
        con = c
        com.Connection = con
        com.CommandText = "select * from botella where cod_botella=" & cod

        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            codigo = ds.Tables("resultado").Rows(0).Item("cod_botella")
            tipo = ds.Tables("resultado").Rows(0).Item("tipo_producto")
            capacidad = ds.Tables("resultado").Rows(0).Item("capac_botella")
            cantidad = ds.Tables("resultado").Rows(0).Item("cantidad_botellas")
            ruta = ds.Tables("resultado").Rows(0).Item("ruta_imagen")
            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from botella where cod_botella=" + codigo
        Try
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Baja de producto " & codigo & "exitosa")
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

    Public Sub modificar(ByVal tip As String, ByVal cap As String, ByVal cant As String, ByVal rut As String)
        com.CommandText = "update botella set tipo_producto='" & tip & "',capac_botella=" & cap & _
            ",cantidad_botellas=" & cant & ", ruta_imagen='" & rut & "' where cod_botella=" & codigo
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
        