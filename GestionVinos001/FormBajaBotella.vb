Public Class FormBajaBotella
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscBot As New BusquedaBotella()
    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscBot.baja()
        txtCapacidad.Clear()
        txtCod.Clear()
        txtContenido.Clear()
        txtStock.Clear()
        grupoDatos.Enabled = False

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscBot.buscar(txtCod.Text, con) Then
                txtCapacidad.Text = buscBot.capacidad
                txtContenido.Text = buscBot.tipo
                txtStock.Text = buscBot.cantidad
                grupoDatos.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from botella order by cod_botella"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtCod.Text) And control.entradaNumerica(txtCod.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function
End Class