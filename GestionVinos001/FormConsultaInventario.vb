Public Class FormConsultaInventario
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con


    End Sub
    
    Private Sub checkStock_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkStock.CheckedChanged
        If checkStock.Checked Then
            txtStock.Enabled = True
        Else
            txtStock.Enabled = False
            txtStock.Text = String.Empty
        End If
    End Sub
    Private Sub checkTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTipo.CheckedChanged
        If checkTipo.Checked Then
            txtTipo.Enabled = True
        Else
            txtTipo.Enabled = False
            txtTipo.Text = String.Empty
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select tiene.*,inventario.unidad from inventario,tiene where inventario.tipo=tiene.tipo and tiene.id_sucursal=" & sucursal & generarConsulta()
            da.SelectCommand = com
            ds.Clear()
            da.Fill(ds, "res")
            dataGrid.DataSource = ds.Tables("res")
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If t.Enabled Then
                If Not (control.entradaNoVacia(t.Text)) Then
                    Return False
                End If
            End If

        Next
        If txtStock.Enabled Then
            If Not (control.entradaNumerica(txtStock.Text, "Int")) Then
                Return False

            End If
        End If
       
        Return True
    End Function

    Private Function generarConsulta() As String
        Dim s As String = ""

        If checkStock.Checked Then

            s += " And tiene.stock=" & txtStock.Text
        End If

        If checkTipo.Checked Then

            s += " And tiene.tipo='" & txtTipo.Text & "'"

        End If


        Return s

    End Function


End Class