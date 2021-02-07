Public Class BusquedaReserva
    Public numero, codBotella, ciCliente, cantidad, fecha, producto As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal n As String, ByVal c As Odbc.OdbcConnection) As Boolean
        numero = n
        con = c
        com.Connection = con
        com.CommandText = "select * from reserva where num_reserva=" & numero

        da.SelectCommand = com
        ds.Clear()

        'Try
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            codBotella = ds.Tables("resultado").Rows(0).Item("cod_botella")
            ciCliente = ds.Tables("resultado").Rows(0).Item("ci_cliente")
            cantidad = ds.Tables("resultado").Rows(0).Item("cantidad")
            fecha = ds.Tables("resultado").Rows(0).Item("fecha")
            producto = ds.Tables("resultado").Rows(0).Item("producto")

            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If
        ' Catch ex As Exception

        ' End Try

    End Function

    Public Sub baja()
        com.CommandText = "delete from reserva where num_reserva=" & numero
        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de reserva exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub modificar(ByVal can As String, ByVal cod As String, ByVal pro As String)
        com.CommandText = "update reserva set cod_botella=" & cod & ",producto='" & pro & "',cantidad=" & can & " where num_reserva=" & numero
        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Actualizacion exitosa")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

End Class
