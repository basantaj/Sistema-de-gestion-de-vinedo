Public Class FormGerenteSucursal

    Dim productoSeleccionado As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)

        InitializeComponent()
        con = c
        com.Connection = con
        da.SelectCommand = com
        sucursal = s
        Show()
    End Sub

    Private Sub cerra() Handles Me.FormClosed
        FormLogin.Visible = True
    End Sub

    Private Sub btnProduccionSucursalActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduccionSucursalActual.Click
        com.CommandText = "select * from trasiega t,botella b where t.cod_botella=b.cod_botella and " & _
        "id_lugar in(select id from lugar where id_sucursal=" & sucursal & ")"
        da.Fill(ds, "pS")
        Dim res As New Resultados(ds, "pS")
    End Sub


    Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal.Click
        com.CommandText = "select p.nombre,p.apellido,t.* from trabaja t,personal p where id_sucursal=" + sucursal

        da.Fill(ds, "personal")
        Dim res As New Resultados(ds, "personal")

    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub btnIngresarPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarPersonal.Click
        Dim alPer As New FormAltaPersonal(con, sucursal)

    End Sub

    Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
        Dim formInfor As New FormAdministrativo(sucursal, con)
        formInfor.Show()
    End Sub
End Class