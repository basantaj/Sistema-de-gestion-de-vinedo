Public Class AltaReservas
    Dim idProducto, fecha_inicio, idLugar, ciCliente, cantidad, fecha, producto As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal ci As String, ByVal nom As String, ByVal ape As String, ByVal tel As String, ByVal dir As String, ByVal carr As String(), ByVal c As Odbc.OdbcConnection)
        con = c
        com.Connection = con
        da.SelectCommand = com

        com.CommandText = "select * from cliente where ci=" + ci
        da.Fill(ds, "cliente")
        If ds.Tables("cliente").Rows.Count < 1 Then
            com.CommandText = "insert into cliente values(" + ci + ",'" + nom + "','" + ape + "','" + dir + "'," + tel + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If

        For Each s As String In carr
            If s <> String.Empty Then

                Try
                    com.CommandText = s
                    com.Connection = con
                    con.Open()
                    com.ExecuteNonQuery()
                    con.Close()
                Catch ex As Exception
                    MsgBox("Error. Es posible que la reserva ya haya sido realizada.")
                    MsgBox(ex.Message)
                    con.Close()
                End Try
            End If

        Next

        
    End Sub

End Class
