Public Class FormLogin

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Shared control As New ControlesDeEntrada()

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        If (control.entradaNoVacia(txtUsuario.Text) And control.entradaNoVacia(txtPass.Text)) Then

            con.ConnectionString = "FileDsn=" + Application.StartupPath + "\DSN;UID=" + txtUsuario.Text + ";PWD=" + txtPass.Text
            com.CommandText = "select * from usuarios where nomusuario='" & txtUsuario.Text & "'"
            com.Connection = con
            da.SelectCommand = com

            ds.Tables.Clear()
            Try
                da.Fill(ds, "usuarios")



                Dim suc As String = ds.Tables("usuarios").Rows(0).Item("sucursal").ToString
                Dim user As String = ds.Tables("usuarios").Rows(0).Item("nomusuario").ToString
                Dim rol As String = ds.Tables("usuarios").Rows(0).Item("rol")
                Dim ced As String = ds.Tables("usuarios").Rows(0).Item("ci")


                Select Case rol

                    Case "ampelologo", "viverista", "viticultor", "agronomo", "enologo", "observador"
                        Me.Hide()
                        Dim ob As New FormObservadores(ced, suc, rol, con)

                    Case "administrador"
                        Me.Hide()
                        Dim adm As New FormAdministrador(con, suc)

                    Case "administrativo"
                        Me.Hide()
                        Dim adm As New FormAdministrativo(suc, con)
                        adm.Show()

                    Case "gerentesuc"
                        Me.Hide()
                        Dim ger As New FormGerenteSucursal(con, suc)

                    Case "gerentegen"
                        Me.Hide()
                        Dim gerg As New FormGerenteGeneral(con, suc)

                    Case Else
                        MsgBox("No se encuentra autorizado a consultar la base de datos")
                End Select

            Catch ex As Exception
                If ex.Message.Contains("ERROR [28000]") Then
                    MsgBox("Nombre de usuario o contraseña incorrectos")
                End If
                MsgBox(ex.Message)
            End Try


        End If
    End Sub


    Private Sub btnClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClientes.Click
        con.ConnectionString = "FileDsn=" + Application.StartupPath + "\DSNObservador;UID=" + txtUsuario.Text + ";PWD=" + txtPass.Text
        Dim res As New FormAltaReservas(con)
        res.Show()
        Me.Hide()
    End Sub


End Class
