Public Class FormBajaInventario
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscInv As New BusquedaInventario()
    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscInv.buscar(txtTipo.Text, sucursal, con) Then
                txtStock.Text = buscInv.stock
                txtUnidad.Text = buscInv.unidad
                grupoResultado.Enabled = True
            End If

        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscInv.baja()
        txtStock.Clear()
        txtTipo.Clear()
        txtUnidad.Clear()

        grupoResultado.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select tiene.*,inventario.unidad from inventario,tiene where inventario.tipo=tiene.tipo and tiene.id_sucursal=" & sucursal
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtTipo.Text)) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class