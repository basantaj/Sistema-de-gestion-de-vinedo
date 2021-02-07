Public Class FormAltaEstablecimiento

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet



    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con


    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim altaEst As New AltaEstablecimiento(txtID.Text, txtDireccion.Text, txtNombre.Text, txtTelefono.Text, con)
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from establecimiento order by id"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "tab")
        Dim res As New Resultados(ds, "tab")

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If Not control.entradaNoVacia(t.Text) Then
                Return False
            End If
        Next

        If (control.entradaNumerica(txtID.Text, "Int") And control.entradaNumerica(txtTelefono.Text, "Int")) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class