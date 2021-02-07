Public Class FormConsultaClientes
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con


    End Sub
    Private Sub checkTelefono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTelefono.CheckedChanged
        If checkTelefono.Checked Then
            txtTelefono.Enabled = True
        Else
            txtTelefono.Enabled = False
            txtTelefono.Text = String.Empty
        End If
    End Sub
    Private Sub checkCI_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCI.CheckedChanged
        If checkCI.Checked Then
            txtCI.Enabled = True
        Else
            txtCI.Enabled = False
            txtCI.Text = String.Empty
        End If
    End Sub
    Private Sub checkApellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkApellido.CheckedChanged
        If checkApellido.Checked Then
            txtApellido.Enabled = True
        Else
            txtApellido.Enabled = False
            txtApellido.Text = String.Empty
        End If
    End Sub
    Private Sub checkNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkNombre.CheckedChanged
        If checkNombre.Checked Then
            txtNombre.Enabled = True
        Else
            txtNombre.Enabled = False
            txtNombre.Text = String.Empty
        End If
    End Sub
    Private Sub checkDireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkDireccion.CheckedChanged
        If checkDireccion.Checked Then
            txtDireccion.Enabled = True
        Else
            txtDireccion.Enabled = False
            txtDireccion.Text = String.Empty
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select * from cliente" & generarConsulta()
            da.SelectCommand = com
            ds.Clear()
            da.Fill(ds, "tab")
            dataGrid.DataSource = ds.Tables("tab")
        End If


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
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
        If txtCI.Enabled Then
            If Not (control.comprobarLargo(txtCI.Text, 8, "Igual") And control.entradaNumerica(txtCI.Text, "Int")) _
                       Then
                Return False
            End If
        End If

        If txtNombre.Enabled Then
            If Not (control.letrasSolo(txtNombre.Text)) Then
                Return False
            End If
        End If

        If txtApellido.Enabled Then
            If Not Not (control.letrasSolo(txtApellido.Text)) Then
                Return False
            End If
        End If

        If txtTelefono.Enabled Then
            If Not (control.entradaNumerica(txtTelefono.Text, "Int")) Then
                Return False
            End If
        End If
        Return True



    End Function

    Private Function generarConsulta() As String
        Dim s As String = ""

        If checkCI.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "

            Else
                s += " where "
            End If
            s += "ci=" & txtCI.Text
        End If

        If checkApellido.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If

            s += "apellido='" & txtApellido.Text & "'"
        End If

        If checkDireccion.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "direccion='" & txtDireccion.Text & "'"
        End If

        If checkNombre.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "nombre='" & txtNombre.Text & "'"
        End If

        If checkTelefono.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "telefono=" & txtTelefono.Text
        End If

        Return s

    End Function

End Class