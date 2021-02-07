Public Class FormBajaAlmacenamiento
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscAlm As New BusquedaAlmacenamiento()

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()
        con = c
        com.Connection = con

    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If comprobarEntradas() Then
            If buscAlm.buscar(txtID.Text, con) Then
                txtCapacidad.Text = buscAlm.capacidad
                txtMaterial.Text = buscAlm.material
                txtTipo.Text = buscAlm.tipo
                grupoResultado.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscAlm.baja()
        txtCapacidad.Clear()
        txtMaterial.Clear()
        txtTipo.Clear()
        grupoResultado.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from lugar order by id"
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