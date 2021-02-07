Public Class AltaTransporte
    Dim matricula, idEstablecimiento, capacidad, iniTurno, finTurno As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal mat As String, ByVal est As String, ByVal cap As String, ByVal iT As String, ByVal fT As String, ByVal c As Odbc.OdbcConnection)

        matricula = mat
        idEstablecimiento = est
        capacidad = cap
        iniTurno = iT
        finTurno = fT

        con = c
        com.Connection = con
        da.SelectCommand = com
        com.CommandText = "select * from transporte where matricula='" + matricula + "'"
        ds.Clear()
        da.Fill(ds, "transportes")

        If ds.Tables("transportes").Rows.Count > 0 Then
            MsgBox("Transporte ya está registrado")
        Else
            com.CommandText = "insert into transporte values(" & capacidad & "," + idEstablecimiento & ",'" & matricula & "','" & iniTurno & "','" & finTurno & "')"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Transporte registrado")
        End If


    End Sub



End Class
