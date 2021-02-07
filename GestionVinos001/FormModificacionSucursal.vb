Public Class FormModificacionSucursal
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscSuc As New BusquedaSucursal

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from sucursal order by id"
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscSuc.buscar(txtID.Text, con) Then
                txtDireccion.Text = buscSuc.direccion
                txtDireccion.Enabled = True
                txtNombre.Text = buscSuc.nombre
                txtNombre.Enabled = True
                txtTelefono.Text = buscSuc.telefono
                txtTelefono.Enabled = True
                btnModificar.Enabled = True

            End If
        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscSuc.modificar(txtDireccion.Text, txtNombre.Text, txtTelefono.Text)
            txtDireccion.Clear()
            txtDireccion.Enabled = False
            txtNombre.Clear()
            txtNombre.Enabled = False
            txtTelefono.Clear()
            txtTelefono.Enabled = False
            txtID.Clear()
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

        If (control.entradaNumerica(txtID.Text, "Int")) Then
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