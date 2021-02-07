Public Class FormModificacionAlmacenamiento
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
    
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from lugar order by id"
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscAlm.buscar(txtID.Text, con) Then
                txtCapacidad.Text = buscAlm.capacidad
                txtCapacidad.Enabled = True
                txtMaterial.Text = buscAlm.material
                txtMaterial.Enabled = True
                txtTipo.Text = buscAlm.tipo
                txtTipo.Enabled = True
                btnModificar.Enabled = True
                
            End If
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscAlm.modificar(txtTipo.Text, txtMaterial.Text, txtCapacidad.Text)
        End If
        txtID.Clear()
        txtCapacidad.Clear()
        txtCapacidad.Enabled = False
        txtMaterial.Clear()
        txtMaterial.Enabled = False
        txtTipo.Clear()
        txtTipo.Enabled = False
        btnModificar.Enabled = False
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

        If txtID.Enabled Then
            If (control.entradaNumerica(txtID.Text, "Int")) Then

            Else
                Return False
            End If
        End If
        If txtCapacidad.Enabled Then
            If (control.entradaNumerica(txtCapacidad.Text, "Dec")) Then

            Else
                Return False
            End If
        End If

        Return True
    End Function



End Class