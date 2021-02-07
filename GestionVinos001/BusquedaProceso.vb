Public Class BusquedaProceso
    Public id, tipo, phEsperado, duracionEsperada, tipoproducto As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal i As String, ByVal c As Odbc.OdbcConnection) As Boolean
        id = i
        con = c
        com.Connection = con
        com.CommandText = "select * from proceso where id=" & id
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            id = ds.Tables("resultado").Rows(0).Item("id")
            tipo = ds.Tables("resultado").Rows(0).Item("tipo")
            phEsperado = ds.Tables("resultado").Rows(0).Item("ph_esperado")
            duracionEsperada = ds.Tables("resultado").Rows(0).Item("duracion_esperada")
            tipoproducto = ds.Tables("resultado").Rows(0).Item("tipo_producto")
            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from proceso where id=" & id
        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de proceso " & tipo & "(" & id & ") exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        End Try
    End Sub

    Public Sub modificar(ByVal t As String, ByVal ph As String, ByVal dur As String, ByVal prod As String)
        com.CommandText = "update proceso set tipo='" & t & "', ph_esperado=" & ph & ", duracion_esperada=" & dur & _
            ",tipo_producto='" & prod & "' where id=" & id
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
