Public Class FormConsultaPersonal
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim sucursal As String


    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        sucursal = s
        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub
    Private Sub checkTelefono_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTelefono.CheckedChanged
        If checkTelefono.Checked Then
            txtTelefono.Enabled = True
        Else
            txtTelefono.Enabled = False
            txtTelefono.Text = String.Empty
        End If
    End Sub
    Private Sub checkDireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkApellido.CheckedChanged
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
    Private Sub checkID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkID.CheckedChanged
        If checkID.Checked Then
            txtID.Enabled = True
        Else
            txtID.Enabled = False
            txtID.Text = String.Empty
        End If
    End Sub


    Private Sub checkCargo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCargo.CheckedChanged
        If checkCargo.Checked Then
            txtCargo.Enabled = True
        Else
            txtCargo.Enabled = False
            txtCargo.Text = String.Empty
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select * from personal,trabaja " & generarConsulta() & " ci=ci_personal And id_sucursal=" & sucursal
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

        If txtID.Enabled Then
            If Not (control.entradaNumerica(txtID.Text, "Int")) Then
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

        If checkApellido.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then

            Else
                s += " where "
            End If
            s += "apellido='" & txtApellido.Text & "' and "
        End If

        If checkID.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
            Else
                s += " where "
            End If

            s += "id=" & txtID.Text & " and "
        End If

        If checkNombre.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
            Else
                s += " where "
            End If
            s += "nombre='" & txtNombre.Text & "' and "
        End If

        If checkTelefono.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
            Else
                s += " where "
            End If
            s += "telefono=" & txtTelefono.Text & " and "
        End If

        If checkCargo.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
            Else
                s += " where "
            End If
            s += "cargo='" & txtCargo.Text & "' and "
        End If

        If String.IsNullOrEmpty(s) Then
            s += " where "
        End If


        Return s

    End Function

    
End Class