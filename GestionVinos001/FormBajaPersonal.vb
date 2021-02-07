Public Class FormBajaPersonal
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscPer As New BusquedaPersonal
    Dim sucursal As String
    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com

        sucursal = s

    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscPer.buscar(sucursal, txtCI.Text, con) Then
                txtNombre.Text = buscPer.nombre
                txtApellido.Text = buscPer.apellido
                txtTelefono.Text = buscPer.telefono
                txtCargo.Text = buscPer.cargo

                grupoResultado.Enabled = True
            End If

        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscPer.baja()
        txtApellido.Clear()
        txtCI.Clear()
        txtNombre.Clear()
        txtTelefono.Clear()
        txtCargo.Clear()
        grupoResultado.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from personal, trabaja where ci=ci_personal and id_sucursal=" & sucursal & " order by ci"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtCI.Text) And control.entradaNumerica(txtCI.Text, "Int") And control.comprobarLargo(txtCI.Text, 8, "Igual")) Then
            Return True
        Else
            Return False
        End If


    End Function

End Class