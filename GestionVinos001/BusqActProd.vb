Public Class BusqActProd
    Public idProducto, idLugar, idProceso, cantidad, fecIniProceso, fecFinProceso, estado, unidad, tipoProceso, tipoLugar As String
    Private ubica, realiza As Boolean

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim hoy As String = DateTime.Now.ToString("dd/MM/yyyy")

    Public Sub New()

    End Sub

    Public Function buscar(ByVal idP As String, ByVal c As Odbc.OdbcConnection) As Boolean
        reset()
        idProducto = idP
        con = c
        da.SelectCommand = com
        com.Connection = con
        com.CommandText = "select * from producto where id=" & idProducto & " "
        ds.Clear()
        da.Fill(ds, "producto")

        If ds.Tables("producto").Rows.Count > 0 Then

            com.CommandText = "select * from ubica where id_producto=" & idProducto & " and fecha_fin is null"
            da.Fill(ds, "ubica")

            If ds.Tables("ubica").Rows.Count > 0 Then
                ubica = True
                idLugar = ds.Tables("ubica").Rows(0).Item("id_lugar")
                cantidad = ds.Tables("ubica").Rows(0).Item("cantidad")
                unidad = ds.Tables("ubica").Rows(0).Item("unidad")
                fecIniProceso = ds.Tables("ubica").Rows(0).Item("fecha_inicio")


                com.CommandText = "select * from realiza where id_lugar=" & idLugar & " and id_producto=" & idProducto _
                    & " and fecha_fin_pro is null"
                da.Fill(ds, "realiza")

                If ds.Tables("realiza").Rows.Count > 0 Then
                    realiza = True
                    idProceso = ds.Tables("realiza").Rows(0).Item("id_proceso")
                    fecIniProceso = ds.Tables("realiza").Rows(0).Item("fecha_ini_pro")
                    estado = ds.Tables("realiza").Rows(0).Item("estado")
                    com.CommandText = "select tipo from proceso where id=" & idProceso
                    da.Fill(ds, "idproceso")
                    tipoProceso = ds.Tables("idproceso").Rows(0).Item("tipo")
                    com.CommandText = "select tipo from lugar where id=" & idLugar
                    da.Fill(ds, "lugar")
                    tipoLugar = ds.Tables("lugar").Rows(0).Item("tipo")

                End If

            End If
        Else
            MsgBox("Producto no existe")
            Return False
        End If
        Return True
    End Function


    Private Sub reset()
        ubica = False
        realiza = False
        idProducto = ""
        idLugar = ""
        idProceso = ""
        cantidad = ""
        fecIniProceso = ""
        fecFinProceso = ""
        estado = ""
        unidad = ""
        idProceso = ""
        tipoLugar = ""
    End Sub


    Public Sub siguienteProceso(ByVal idL As String, ByVal cant As String, ByVal unid As String, ByVal idproc As String, ByVal est As String)
        If ubica Then
            com.CommandText = "update ubica set fecha_fin='" & hoy & "' where id_lugar=" & idLugar & " and id_producto=" & idProducto
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If
        If realiza Then
            com.CommandText = "update realiza set fecha_fin_pro='" & hoy & "' where id_lugar=" & idLugar _
                & " and id_producto=" & idProducto & " and id_proceso=" & idProceso
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If

        com.CommandText = "insert into ubica values(" & idL & "," & idProducto & ",'" & unid & "'," & cant & ",'" & hoy & "','');" _
            & "insert into realiza values('" & est & "','" & hoy & "',''," & idProducto & "," & idL & "," & idproc & "," & cant & ",'" & unid & "')"
        Try
            con.Open()
            com.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class
