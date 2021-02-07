Public Class FormModificacionReservas
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim busRes As New BusquedaReserva

    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        da.SelectCommand = com
        con = c
        com.Connection = con
       
    End Sub
    Private Sub FormModificacionReservas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select tipo_producto, cod_botella from botella"
        ds.Clear()
        da.Fill(ds, "combo")
        If ds.Tables("combo").Rows.Count > 0 Then

            comboProducto.DataSource = ds.Tables("combo")
            comboProducto.DisplayMember = "tipo_producto"

        Else
            MsgBox("No hay productos registrados. No se podrán realizar reservas")
            Me.Close()
        End If




        comboProducto.SelectedIndex = 0
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from reserva"
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If busRes.buscar(txtReserva.Text, con) Then
                For i As Integer = 0 To ds.Tables("combo").Rows.Count - 1 Step 1
                    If ds.Tables("combo").Rows(i).Item("cod_botella") = busRes.codBotella Then
                        comboProducto.SelectedIndex = i
                        comboProducto.Enabled = True
                    End If
                Next
                numUnidades.Value = busRes.cantidad
                numUnidades.Enabled = True
            End If

            btnModificar.Enabled = True
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            Dim co As String = ds.Tables("combo").Rows(comboProducto.SelectedIndex).Item("cod_botella")
            MsgBox(co)
            busRes.modificar(Convert.ToInt32(numUnidades.Value), co, comboProducto.Text)
            numUnidades.Value = 0
            numUnidades.Enabled = False
            comboProducto.Enabled = False

        End If

        btnModificar.Enabled = False
    End Sub

    Private Sub btnLimpiarCarro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Limpia el carro")
    End Sub


    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If t.Enabled Then
                If Not control.entradaNoVacia(t.Text) Then
                    Return False
                End If
            End If
        Next

        If Not (control.entradaNumerica(txtReserva.Text, "Int")) Then
            Return False
        End If


        If numUnidades.Enabled Then
            If Not ((numUnidades.Value > 0)) Then
                Return False
            End If
        End If

        Return True
    End Function

End Class