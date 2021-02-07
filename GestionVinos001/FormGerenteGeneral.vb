Public Class FormGerenteGeneral


    Dim control As New ControlesDeEntrada()
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

    Private Sub FormGerenteGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSucursal.Text = sucursal
    End Sub

    Private Sub cerra() Handles Me.FormClosed
        FormLogin.Visible = True
    End Sub

    Private Sub btnGestión_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGestión.Click
        Dim venGestion As New FormAdministrador(con, sucursal)
        venGestion.Name = "Panel de Gestión"
        venGestion.btnCancelar.Visible = True
        venGestion.Show()
    End Sub
    Private Sub btnProduccionSucursalActual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduccionSucursalActual.Click
        com.CommandText = "select * from trasiega t,botella b where t.cod_botella=b.cod_botella and " & _
        "id_lugar in(select id from lugar where id_sucursal=" & sucursal & ")"
        da.Fill(ds, "pS")
        Dim res As New Resultados(ds, "pS")
    End Sub

    Private Sub btnProduccionTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduccionTotal.Click
        com.CommandText = "select * from trasiega t,botella b where t.cod_botella=b.cod_botella"
        da.Fill(ds, "pT")
        Dim res As New Resultados(ds, "pT")
    End Sub
 
    Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal.Click

        com.CommandText = "select p.nombre,p.apellido,t.* from trabaja t,personal p where id_sucursal=" + sucursal

        da.Fill(ds, "personal")
        Dim res As New Resultados(ds, "personal")

    End Sub

    Private Sub btnCerrarSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrarSesion.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucursal.Click
        If control.entradaNumerica(txtSucursal.Text, "Int") Then
            sucursal = txtSucursal.Text
            MsgBox("Operando sobre la sucursal" + sucursal)
        Else
            MsgBox("Ingrese un numero apropiado")
            txtSucursal.Text = String.Empty
        End If
    End Sub



    Private Sub btnInformes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInformes.Click
        Dim formInfor As New FormAdministrativo(sucursal, con)
        formInfor.Show()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub
End Class