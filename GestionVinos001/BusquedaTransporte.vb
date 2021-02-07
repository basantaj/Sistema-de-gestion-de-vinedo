Public Class BusquedaTransporte
    Public capacidad, idEstablecimiento, matricula, inicioTurno, finTurno As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Function buscar(ByVal m As String, ByVal c As Odbc.OdbcConnection) As Boolean
        matricula = m
        con = c
        com.Connection = con
        com.CommandText = "select id_establecimiento, matricula, " & _
            "capacidad, to_char(inicio_turno, '%H:%M') as inicio_turno,to_char(fin_turno, '%H:%M') as fin_turno from transporte " _
        & "where matricula='" & matricula & "'"


        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "resultado")
        If ds.Tables("resultado").Rows.Count > 0 Then

            capacidad = ds.Tables("resultado").Rows(0).Item("capacidad")
            idEstablecimiento = ds.Tables("resultado").Rows(0).Item("id_establecimiento")
            matricula = ds.Tables("resultado").Rows(0).Item("matricula")
            inicioTurno = ds.Tables("resultado").Rows(0).Item("inicio_turno")
            finTurno = ds.Tables("resultado").Rows(0).Item("fin_turno")
            

            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText = "delete from transporte where matricula='" & matricula & "'"
        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de transporte exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub modificar(ByVal idE As String, ByVal capac As String, ByVal iniT As String, ByVal finT As String)
        com.CommandText = "update transporte set id_establecimiento=" & idE & ",capacidad= " & capac & _
            ",inicio_turno='" & iniT & "',fin_turno='" & finT & "' where matricula='" _
            & matricula & "'"

        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Actualizacion exitosa")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try

    End Sub

End Class
