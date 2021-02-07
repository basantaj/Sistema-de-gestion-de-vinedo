Public Class FormAltaAlmacenamiento


    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Dim sucursal As String

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con
        sucursal = s
    End Sub



    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim altaAlmac As New AltaAlmacenamiento(txtID.Text, txtMaterial.Text, txtCapacidad.Text, txtTipo.Text, sucursal, con)
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from lugar where id_sucursal= " + sucursal + "order by id asc"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "lugares")
        Dim res As New Resultados(ds, "lugares")

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

        If (control.entradaNumerica(txtID.Text, "Int") And control.entradaNumerica(txtCapacidad.Text, "Dec")) Then
            Return True
        Else
            Return False
        End If


    End Function



End Class