Public Class AltaProducto

    Dim idProd, nombre, origen, tipo, idCont, unidad, cantidad, anioMosto, anioVino, cepa, matVehiculo, horSalida, destino As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal prod As String, ByVal n As String, ByVal o As String, ByVal t As String, ByVal cont As String, ByVal u As String, ByVal cant As String, ByVal aV As String _
                   , ByVal aM As String, ByVal cep As String, ByVal mV As String, ByVal hS As String, ByVal des As String, ByVal operacion As String, ByVal relacion As String, ByVal c As Odbc.OdbcConnection)
        idProd = prod
        nombre = n
        origen = o
        tipo = t
        idCont = cont
        unidad = u
        cantidad = cant
        anioMosto = aM
        anioVino = aV
        cepa = cep
        matVehiculo = mV
        horSalida = hS
        destino = des


        con = c
        com.Connection = con
        da.SelectCommand = com
        com.CommandText = "select * from producto where id='" + idProd + "'"
        ds.Clear()
        da.Fill(ds, "productos")
        If ds.Tables("productos").Rows.Count > 0 Then
            MsgBox("Producto " + idProd + " ya existe.")
        Else
            com.CommandText = "insert into producto values(" + idProd + ",'" + nombre + "','" + origen + "','" + tipo + "');"
            Try
                con.Open()
                com.ExecuteNonQuery()


                ingresarACategoria(operacion, relacion)

                MsgBox("Producto ingresado")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                con.Close()
            End Try


        End If




    End Sub

    Private Sub ingresarACategoria(ByVal t As String, ByVal r As String)
        Select Case t
            Case "uva"
                com.CommandText = "insert into uva values(" + idProd + ")"

                com.ExecuteNonQuery()

            Case "mosto"
                com.CommandText = "insert into mosto values(" + idProd + ",'" + cepa + "'," + anioMosto + ")"

                com.ExecuteNonQuery()

            Case "vino"
                com.CommandText = "insert into vino values(" + idProd + "," + anioVino + ")"

                com.ExecuteNonQuery()



        End Select

        Select Case r
            Case "Transporta"
                com.CommandText = "insert into transporta values(" & idProd & ",'" & matVehiculo & "','" & DateTime.Now.ToString("dd/MM/yyyy") & _
                    "','" & destino & "','" & horSalida & "','')"
                com.ExecuteNonQuery()
            Case "Ubica"
                com.CommandText = " insert into ubica " + _
                         "values(" + idCont + "," + idProd + ",'" + unidad + "'," + cantidad + ",'" + Date.Now.ToString("dd/MM/yyyy") + "','')"
                com.ExecuteNonQuery()

        End Select


    End Sub


End Class
