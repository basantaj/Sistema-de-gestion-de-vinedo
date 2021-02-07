Public Class AltaProceso
    Dim idProceso, tipo, duracion, phEsperado, producto As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal id As String, ByVal t As String, ByVal d As String, ByVal ph As String, ByVal pr As String, ByVal c As Odbc.OdbcConnection)
        idProceso = id
        tipo = t
        duracion = d
        phEsperado = ph
        producto = pr
        con = c

        con = c
        com.Connection = con
        com.CommandText = "select * from proceso where id=" + idProceso
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "procesos")
        If ds.Tables("procesos").Rows.Count > 0 Then
            MsgBox("ID de proceso " + idProceso + "  ya está registrada.")
        Else
            com.CommandText = "insert into proceso values(" + idProceso + ",'" + tipo + "'," + phEsperado + "," + duracion + ",'" + producto + "')"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If


    End Sub



End Class
