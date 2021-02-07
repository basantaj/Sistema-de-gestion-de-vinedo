Public Class FormAltaReservas
    Dim filas As Integer = 1
    Dim carro(0) As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet
    Dim hoy As String = Date.Now.ToString("dd/MM/yyyy")


    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com


    End Sub



    Private Sub FormAltaReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select ruta_imagen,tipo_producto, cod_botella, cantidad_botellas from botella"

        da.Fill(ds, "combo")
        If ds.Tables("combo").Rows.Count > 0 Then

            comboProducto.DataSource = ds.Tables("combo")
            comboProducto.DisplayMember = "tipo_producto"
            comboProducto.SelectedIndex = 0
        Else
            MsgBox("No hay productos registrados. No se podrán realizar reservas")
            Me.Close()
        End If



    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If carro.Length > 1 Then
            Dim altaRes As New AltaReservas(txtCI.Text, txtNombre.Text, txtApellido.Text, txtTelefono.Text, txtDireccion.Text, carro, con)
            filas = 0
            dataGrid.Rows.Clear()
        End If
        com.CommandText = "select ruta_imagen,tipo_producto, cod_botella, cantidad_botellas from botella"
        ds.Clear()
        da.Fill(ds, "combo")
        numUnidades.Maximum = ds.Tables("combo").Rows(comboProducto.SelectedIndex).Item("cantidad_botellas")
    End Sub

    Private Sub btnLimpiarCarro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarCarro.Click
        dataGrid.Rows.Clear()
        ReDim carro(0)
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If Not control.entradaNoVacia(t.Text) Then
                Return False
            End If
        Next
      
        If (control.comprobarLargo(txtCI.Text, 8, "Igual") And control.entradaNumerica(txtCI.Text, "Int") _
            And control.letrasSolo(txtNombre.Text) And control.letrasSolo(txtApellido.Text) _
            And control.entradaNumerica(txtTelefono.Text, "Int")) Then
            Return True
        Else
            Return False
        End If

    End Function

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        
        If comprobarEntradas() Then
            If numUnidades.Value > 0 Then

                com.CommandText = "select * from reserva"
                da.Fill(ds, "cuenta")

                filas = ds.Tables("cuenta").Rows.Count + dataGrid.RowCount + 1

                If (ds.Tables("cuenta").Rows.Count + dataGrid.RowCount > filas) Then
                    filas = ds.Tables("cuenta").Rows.Count + dataGrid.RowCount


                End If

                com.CommandText = "select cod_botella,tipo_producto from botella  where cod_botella=" _
                    & ds.Tables("combo").Rows(comboProducto.SelectedIndex).Item("cod_botella")


                da.Fill(ds, "tab")



                Dim cod As String = ds.Tables("tab").Rows(0).Item("cod_botella")
                Dim nom As String = ds.Tables("tab").Rows(0).Item("tipo_producto")



                dataGrid.Rows.Add(txtCI.Text, ds.Tables("tab").Rows(0).Item("tipo_producto"), numUnidades.Value)
                carro(carro.Length - 1) = "insert into reserva values(" & filas & "," _
            & cod & "," & txtCI.Text & "," & numUnidades.Value & ",'" & hoy & _
            "','" & nom & "'); update botella set cantidad_botellas=cantidad_botellas-" & numUnidades.Value & _
            "where cod_botella=" & cod

                ReDim Preserve carro(carro.Length)




                ds.Tables("tab").Clear()
                ds.Tables("cuenta").Clear()


            Else
                MsgBox("Seleccione una cantidad de producto a reservar")
            End If

        End If
        
    End Sub

    
    
    
    Private Sub comboProducto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles comboProducto.SelectedIndexChanged
        Try
            Dim rutImg As String = ds.Tables("combo").Rows(comboProducto.SelectedIndex).Item("ruta_imagen")
      
        imagen.Image = Nothing
        If Not String.IsNullOrEmpty(rutImg) Then

            imagen.Image = Image.FromFile(Application.StartupPath & "\Recursos\" & rutImg)

        End If
     
        numUnidades.Maximum = ds.Tables("combo").Rows(comboProducto.SelectedIndex).Item("cantidad_botellas")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnListadoReservas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoReservas.Click
        com.CommandText = "select * from reserva"
        da.Fill(ds, "reservas")
        Dim res As New Resultados(ds, "reservas")
    End Sub

    Private Sub btnListadoClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListadoClientes.Click
        Dim conCli As New FormConsultaClientes(con)
        conCli.Show()

    End Sub
End Class