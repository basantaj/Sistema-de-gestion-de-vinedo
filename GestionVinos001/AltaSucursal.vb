Public Class AltaSucursal
    Dim id, direccion, nombre, telefono As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal i As String, ByVal d As String, ByVal n As String, ByVal t As String, ByVal c As Odbc.OdbcConnection)

        id = i
        direccion = d
        nombre = n
        telefono = t
        con = c
        com.Connection = con
        da.SelectCommand = com
        com.CommandText = "select * from sucursal where id=" + id
        ds.Clear()
        da.Fill(ds, "sucursales")

        If ds.Tables("sucursales").Rows.Count > 0 Then
            MsgBox("Sucursal ya registrado")
        Else
            Try
                com.CommandText = "INSERT into sucursal VALUES(" & id & ",'" & nombre & "'," & telefono & ",'" & direccion & "')"
                con.Open()
                com.ExecuteNonQuery()

                MsgBox("Sucursal registrada")
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                con.Close()
            End Try

        End If


    End Sub
End Class
