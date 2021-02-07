Public Class FormAltaPersonal

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
        da.SelectCommand = com

        Show()
    End Sub

    Private Sub FormAltaPersonal_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim alPer As New AltaPersonal(txtCI.Text, txtNombre.Text, txtApellido.Text, txtCargo.Text, txtTel.Text, sucursal, con)
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from personal, trabaja where ci=ci_personal and id_sucursal=" & sucursal & " order by ci"
        da.Fill(ds, "personal")
        Dim res As New Resultados(ds, "personal")

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

        If (Not control.entradaNumerica(txtCI.Text, "Int") Or Not control.comprobarLargo(txtCI.Text, 8, "Igual")) Then
            MsgBox("Ingrese una cédula válida")
            Return False
        End If

        If (Not control.entradaNumerica(txtTel.Text, "Int")) Then
            Return False
        End If

        Return True

    End Function

End Class