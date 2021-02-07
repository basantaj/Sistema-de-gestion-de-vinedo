Public Class FormBajaReservas
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscRes As New BusquedaReserva

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con


    End Sub
   
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from reservas"
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscRes.baja()
        txtCant.Clear()
        txtCI.Clear()
        txtFecha.Clear()
        txtProducto.Clear()
        txtReserva.Clear()
        grupoResultado.Enabled = False
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscRes.buscar(txtReserva.Text, con) Then
                txtCI.Text = buscRes.ciCliente
                txtProducto.Text = buscRes.producto
                txtCant.Text = buscRes.cantidad
                txtFecha.Text = buscRes.fecha
                grupoResultado.Enabled = True
            End If
        End If
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtReserva.Text) And control.entradaNumerica(txtReserva.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class