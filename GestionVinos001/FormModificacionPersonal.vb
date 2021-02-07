Public Class FormModificacionPersonal
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscPer As New BusquedaPersonal
    Dim sucursal As String
    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from personal, trabaja where ci=ci_personal and id_sucursal=" & sucursal & " order by ci"
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscPer.buscar(sucursal, txtCI.Text, con) Then
                txtApellido.Text = buscPer.apellido
                txtApellido.Enabled = True
                txtNombre.Text = buscPer.nombre
                txtNombre.Enabled = True
                txtTelefono.Text = buscPer.telefono
                txtTelefono.Enabled = True
                btnModificar.Enabled = True
                txtCargo.Text = buscPer.cargo


            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscPer.modificar(txtNombre.Text, txtApellido.Text, txtCargo.Text, txtTelefono.Text)
            txtApellido.Clear()
            txtApellido.Enabled = False
            txtNombre.Clear()
            txtNombre.Enabled = False
            txtTelefono.Clear()
            txtTelefono.Enabled = False
            txtCargo.Clear()
            txtCargo.Enabled = False
            txtCI.Clear()
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

        If (control.entradaNumerica(txtCI.Text, "Int")) Then
        Else
            Return False
        End If

        If txtTelefono.Enabled Then
            If (control.entradaNumerica(txtTelefono.Text, "Int")) Then
            Else
                Return False
            End If
        End If

        Return True
    End Function
End Class