Public Class AltaBotella

    Dim codigo, tipo, capacidad, cantidad, ruta As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal cod As String, ByVal t As String, ByVal cap As String, ByVal cant As String, ByVal rut As String, ByVal c As Odbc.OdbcConnection)
        codigo = cod
        tipo = t
        capacidad = cap
        cantidad = cant
        ruta = rut


        con = c
        com.Connection = con
        da.SelectCommand = com
        com.CommandText = "select * from botella where cod_botella=" + codigo
        ds.Clear()
        da.Fill(ds, "botella")

        If ds.Tables("botella").Rows.Count > 0 Then
            MsgBox("Producto ya registrado")
        Else
            com.CommandText = "INSERT into botella VALUES(" + codigo + ", '" + tipo + "', " + capacidad + ", " + cantidad + ", '" + ruta + "')"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Producto registrado")
        End If


    End Sub


End Class
