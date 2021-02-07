Public Class BusquedaPersonal
    Public cedula, nombre, apellido, cargo, telefono, sucursal As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal s As String, ByVal ce As String, ByVal c As Odbc.OdbcConnection) As Boolean
        sucursal = s
        cedula = ce
        con = c
        com.Connection = con
        com.CommandText = "select * from personal,trabaja where ci=ci_personal and ci=" & cedula & " and id_sucursal=" & sucursal


        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            nombre = ds.Tables("resultado").Rows(0).Item("nombre")
            apellido = ds.Tables("resultado").Rows(0).Item("apellido")
            cargo = ds.Tables("resultado").Rows(0).Item("cargo")
            telefono = ds.Tables("resultado").Rows(0).Item("telefono")


            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from trabaja where ci_personal=" & cedula & " and id_sucursal=" & sucursal & ";" & _
            "delete from observa where ci_personal=" & cedula & ";" & _
            "delete from personal where ci=" & cedula & ";"

        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de empleado exitosa")
        Catch e As Exception
            MsgBox(e.Message)

        Finally
            con.Close()
        End Try
    End Sub

    Public Sub modificar(ByVal no As String, ByVal ape As String, ByVal car As String, ByVal tel As String)
        com.CommandText = "update personal set nombre='" & no & "',apellido='" & ape & _
            "',cargo='" & car & "',telefono=" & tel & " where ci=" & cedula

        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Actualizacion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub
End Class
