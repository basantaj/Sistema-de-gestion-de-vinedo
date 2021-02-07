Public Class BusquedaProducto
    Public idProd, nombre, origen, tipoProd, anioM, anioV, cepa As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Sub limpieza()
        idProd = ""
        nombre = ""
        origen = ""
        tipoProd = ""
        anioM = ""
        anioV = ""
        cepa = ""
    End Sub

    Public Function buscar(ByVal id As String, ByVal c As Odbc.OdbcConnection) As Boolean
        idProd = id
        con = c
        com.Connection = con
        com.CommandText = "select * from producto where id=" & idProd

        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "producto")
        com.CommandText = "select * from mosto where id=" & idProd
        da.Fill(ds, "mosto")
        com.CommandText = "select * from vino where id=" & idProd
        da.Fill(ds, "vino")
        If ds.Tables("producto").Rows.Count > 0 Then

            idProd = ds.Tables("producto").Rows(0).Item("id")
            nombre = ds.Tables("producto").Rows(0).Item("nombre")
            tipoProd = ds.Tables("producto").Rows(0).Item("tipo")
            origen = ds.Tables("producto").Rows(0).Item("origen")
            

            If ds.Tables("vino").Rows.Count > 0 Then
                anioV = ds.Tables("vino").Rows(0).Item("anio")
            ElseIf ds.Tables("mosto").Rows.Count > 0 Then
                anioM = ds.Tables("mosto").Rows(0).Item("anio")
                cepa = ds.Tables("mosto").Rows(0).Item("cepa")
            End If

            Return True
        Else
            MsgBox("Entrada no encontrada")
            Return False
        End If

    End Function

    Public Sub baja()
        com.CommandText ="delete from mosto where id=" & idProd & _
            ";delete from vino where id=" & idProd & _
            ";delete from producto where id=" & idProd & "; "
        Try
            con.Open()
            com.ExecuteNonQuery()

            MsgBox("Baja de producto " & nombre & " " & idProd & " exitosa")
        Catch e As Exception
            If e.Message.Contains("is still being referenced") Then

                MsgBox("Existen registros que dependen de esta entrada")

            End If
        Finally
            con.Close()
        End Try
    End Sub

    Public Sub modificar(ByVal nom As String, ByVal ori As String, ByVal tipoP As String, ByVal aM As String, ByVal aV As String, ByVal cep As String)

        com.CommandText = "update producto set nombre='" & nom & "',origen='" & ori & "',tipo='" & tipoP & "' where id=" & idProd
        Try
            con.Open()
            com.ExecuteNonQuery()
            If Not (String.IsNullOrEmpty(anioM)) Or Not (String.IsNullOrEmpty(cepa)) Then
                com.CommandText = "update mosto set anio=" & aM & ", cepa='" & cep & "' where id=" & idProd
                com.ExecuteNonQuery()
            End If
            If Not (String.IsNullOrEmpty(anioV)) Then
                com.CommandText = " update vino set anio=" & aV & " where id=" & idProd
                com.ExecuteNonQuery()
            End If

            MsgBox("Actualizacion exitosa")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

End Class
