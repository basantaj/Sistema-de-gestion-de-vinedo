Public Class Observaciones
    Private cedula, observacion, idLugar, idProceso, idProducto, valorpH, nivelAzucar, fechaAlerta As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet
    Dim fecha As String = DateTime.Now.ToString("MM/dd/yyyy")

    Public Sub New(ByVal ced As String, ByVal idL As String, ByVal idProd As String, ByVal idProc As String, ByVal ph As String, _
                   ByVal azucar As String, ByVal ob As String, ByVal alerta As String, ByVal c As Odbc.OdbcConnection)
        cedula = ced
        observacion = ob
        idLugar = idL
        idProceso = idProc
        idProducto = idProd
        valorpH = ph
        nivelAzucar = azucar
        fechaAlerta = alerta
        con = c
        com.Connection = con
        da.SelectCommand = com

        com.CommandText = "select * from realiza where id_producto=" & idProducto & " and id_proceso=" & idProceso & _
            " and id_lugar=" & idLugar & " and fecha_fin_pro is null"
        da.Fill(ds, "procesos")
        If ds.Tables("procesos").Rows.Count > 0 Then

            com.CommandText = "insert into observa values(" & idProducto & "," & idLugar & "," & idProceso & _
                "," & cedula & ",'" & fecha & "'," & valorpH & "," & nivelAzucar & ",'" & observacion & "','" & alerta & "')"
            Try
                con.Open()
                com.ExecuteNonQuery()
                MsgBox("Observacion registrada con exito")
            Catch ex As Exception
                If ex.Message.Contains("duplicate value") Then
                    MsgBox("Ya se registro observacion para este proceso")
                Else
                    MsgBox(ex.Message)
                End If

            Finally
                con.Close()
            End Try


        Else
            MsgBox("No se encontró un proceso activo con esos datos")
        End If

    End Sub

End Class
