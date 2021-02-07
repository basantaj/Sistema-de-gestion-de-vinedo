Public Class AltaEstablecimiento
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
        com.CommandText = "select * from establecimiento where id=" + id
        ds.Clear()
        da.Fill(ds, "establecimientos")

        If ds.Tables("establecimientos").Rows.Count > 0 Then
            MsgBox("Establecimiento ya registrado")
        Else
            com.CommandText = "INSERT into establecimiento VALUES(" + id + ",'" + direccion + "','" _
                + nombre + "'," + telefono + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Establecimiento registrado")
        End If


    End Sub
End Class
