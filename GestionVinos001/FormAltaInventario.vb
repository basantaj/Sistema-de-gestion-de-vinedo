Imports System.Globalization

Public Class FormAltaInventario

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)
        InitializeComponent()

        con = c
        com.Connection = con
        sucursal = s
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim alta As New AltaInventario(txtStock.Text, txtTipo.Text, txtUnidad.Text, DateTime.Now.ToString("dd/MM/yyyy"), sucursal, con)
           
            MsgBox("Se ingresan los datos")
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select t.tipo,stock,unidad,fecha from tiene t, inventario i where t.tipo=i.tipo and id_sucursal=" + sucursal
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "tiene")
        Dim res As New Resultados(ds, "tiene")

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

        If (control.entradaNumerica(txtStock.Text, "Dec") And control.letrasSolo(txtUnidad.Text)) Then
            Return True
        Else
            Return False
        End If

    End Function


End Class