Public Class FormBajaEstablecimiento
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscEst As New BusquedaEstablecimiento()

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con


    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscEst.buscar(txtID.Text, con) Then
                txtDireccion.Text = buscEst.direccion
                txtNombre.Text = buscEst.nombre
                txtTelefono.Text = buscEst.telefono

                grupoResultado.Enabled = True
            End If

        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscEst.baja()
        txtDireccion.Clear()
        txtID.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        grupoResultado.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from establecimiento order by id"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtID.Text) And control.entradaNumerica(txtID.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function
End Class