Public Class FormActividadProducto

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim busRealiza As New BusqActProd
    Dim sucursal As String

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con

        com.CommandText = "select * from proceso"
        da.SelectCommand = com
        
        combos("L")



    End Sub
   

    Private Sub btnConsultaProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaProd.Click
        Dim conProd As New FormConsultaProductos(sucursal, con)
        conProd.Show()
    End Sub

    Private Sub btnConsultaProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsultaProc.Click
        Dim conProc As New FormConsultaProceso(con)
        conProc.Show()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            busRealiza.siguienteProceso(cmbCont.Text, txtCant2.Text, txtUnid2.Text, txtIDProc2.Text, txtEstado2.Text)
            limpieza()
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub






    Private Function comprobarEntradas() As Boolean

        Dim control As New ControlesDeEntrada()

        For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
            For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                If t.Enabled Then
                    If Not control.entradaNoVacia(t.Text) Then

                        Return False
                    End If
                End If
            Next
        Next


        If Not (control.entradaNumerica(txtIDProd1.Text, "Int")) Then
            Return False
        End If

        If txtIDCont1.Enabled Then
            If Not (control.entradaNumerica(txtIDCont1.Text, "Int")) Then
                Return False
            End If
        End If

        If txtCant1.Enabled Then
            If Not (control.entradaNumerica(txtCant1.Text, "Dec")) Then
                Return False
            End If
        End If
        If txtUnid1.Enabled Then
            If Not (control.letrasSolo(txtUnid1.Text)) Then
                Return False
            End If
        End If


        If txtCant2.Enabled Then
            If Not (control.entradaNumerica(txtCant2.Text, "Dec")) Then
                Return False
            End If
        End If

        If txtUnid2.Enabled Then
            If Not (control.letrasSolo(txtUnid2.Text)) Then
                Return False
            End If
        End If



        Return True

    End Function


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
       
        limpieza()

        If comprobarEntradas() Then

            If busRealiza.buscar(txtIDProd1.Text, con) Then
                txtCant1.Text = busRealiza.cantidad
                txtIDCont1.Text = busRealiza.idLugar
                txtIDProc1.Text = busRealiza.idProceso
                txtUnid1.Text = busRealiza.unidad
                txtEstado1.Text = busRealiza.estado
                txtNomproc.Text = busRealiza.tipoProceso
                combos("P")
                combos("L")
                If busRealiza.tipoLugar = "Barrica" Then
                    btnTrasiego.Enabled = True
                    cmbCont.Enabled = False
                Else
                    For Each c As Control In grupoActualizado.Controls()
                        c.Enabled = True
                    Next
                    txtIDProc2.Enabled = False
                    btnTrasiego.Enabled = False

                End If
                btnConfirmar.Enabled = True
            End If
        End If
    End Sub

    Private Sub limpieza()
        For Each t As TextBox In grupoActualizado.Controls.OfType(Of TextBox)()
            t.Enabled = False
            t.Clear()
        Next

        cmbProceso.Enabled = False

        txtCant1.Clear()
        txtIDCont1.Clear()
        txtUnid1.Clear()
        txtIDProc1.Clear()
    End Sub

    Private Sub combos(ByVal o As String)
        Select Case o
            Case "P"
                com.CommandText = "select prod.tipo as prodti,proc.id as idpro,proc.tipo as nompro from producto prod,proceso proc where prod.id=" & busRealiza.idProducto & _
          " and prod.tipo=proc.tipo_producto"
                If ds.Tables.Contains("procesos") Then
                    ds.Tables("procesos").Clear()
                End If
                Try
                    da.Fill(ds, "procesos")
                    cmbProceso.DataSource = ds.Tables("procesos")
                    cmbProceso.DisplayMember = "nompro"
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Case "L"

                com.CommandText = "select * from lugar where  id_sucursal=" & sucursal & " and id not in (select id_lugar " _
   & "from ubica where fecha_fin is null)"
                If ds.Tables.Contains("lugar") Then
                    ds.Tables("lugar").Clear()
                End If
                da.Fill(ds, "lugar")
                cmbCont.DataSource = ds.Tables("lugar")
                cmbCont.DisplayMember = "id"

        End Select
      

        

    End Sub

    Private Sub cmbProceso_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProceso.SelectedIndexChanged, cmbCont.SelectedIndexChanged
        Try
            txtIDProc2.Text = ds.Tables("procesos").Rows(cmbProceso.SelectedIndex).Item("idpro")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnContenedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContenedores.Click
        combos("L")
        Dim res As New Resultados(ds, "lugar")
    End Sub

    Private Sub btnTrasiego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTrasiego.Click
        trasiegar()
    End Sub

    Private Sub trasiegar()
        Dim tipo As String = ds.Tables("procesos").Rows(cmbProceso.SelectedIndex).Item("prodti")
        com.CommandText = "select cod_botella,capac_botella from botella where tipo_producto='" & tipo & "'"
        da.Fill(ds, "trasiego")
        Dim cantidad As Integer = Math.Round(busRealiza.cantidad / ds.Tables("trasiego").Rows(0).Item("capac_botella"))
        MsgBox(cantidad)
        Dim codBot As String = ds.Tables("trasiego").Rows(0).Item("cod_botella")

        com.CommandText = "insert into trasiega values(" & busRealiza.idLugar & "," & busRealiza.idProducto & _
            "," & codBot & ",'" & DateTime.Now.ToString("dd/MM/yyyy") & "'," & cantidad & ");" & _
            " update realiza set fecha_fin_pro=TODAY where id_producto=" & busRealiza.idProducto & " and fecha_fin_pro is null;" & _
            " update ubica set fecha_fin=TODAY where id_producto=" & busRealiza.idProducto & " and fecha_fin is null;" & _
            " update botella set cantidad_botellas=cantidad_botellas+" & cantidad & " where tipo_producto='" & tipo & "'"

        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Trasiego de " & cantidad & " botellas exitoso")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try

        
    End Sub
End Class