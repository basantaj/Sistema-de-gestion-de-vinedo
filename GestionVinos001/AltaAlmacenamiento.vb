Public Class AltaAlmacenamiento
    Dim id, material, capacidad, tipo, sucursal As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal i As String, ByVal mat As String, ByVal cap As String, ByVal t As String, ByVal s As String, ByVal c As Odbc.OdbcConnection)

        id = i
        material = mat
        capacidad = cap
        tipo = t
        sucursal = s
        con = c
        com.Connection = con
        da.SelectCommand = com
        com.CommandText = "select * from lugar where id=" + id
        ds.Clear()
        da.Fill(ds, "lugares")

        If ds.Tables("lugares").Rows.Count > 0 Then
            MsgBox("Contenedor ya registrado")
        Else
            com.CommandText = "INSERT into lugar VALUES(" + id + ",'" + material + "'," _
                + capacidad + ",'" + tipo _
                + "'," + sucursal + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Contenedor registrado")
        End If


    End Sub
End Class
