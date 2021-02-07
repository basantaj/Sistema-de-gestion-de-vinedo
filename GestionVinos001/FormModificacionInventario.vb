Public Class FormModificacionInventario
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscInc As New BusquedaInventario
    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con


    End Sub
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select tiene.*,inventario.unidad from inventario,tiene where inventario.tipo=tiene.tipo and tiene.id_sucursal=" & sucursal
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "res")
        Dim re As New Resultados(ds, "res")

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscInc.buscar(txtTipo.Text, sucursal, con) Then
                txtStock.Text = buscInc.stock
                txtStock.Enabled = True
                txtUnidad.Text = buscInc.unidad
                txtUnidad.Enabled = True
                btnModificar.Enabled = True

            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscInc.modificar(txtStock.Text, txtUnidad.Text)
            txtStock.Clear()
            txtStock.Enabled = False
            txtUnidad.Clear()
            txtUnidad.Enabled = False
            btnModificar.Enabled = False
        End If

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

        If txtStock.Enabled Then
            If (control.entradaNumerica(txtStock.Text, "Dec")) Then
            Else
                Return False
            End If
        End If
        If txtUnidad.Enabled Then
            If (control.letrasSolo(txtUnidad.Text)) Then
            Else
                Return False
            End If
        End If
        Return True
    End Function



End Class