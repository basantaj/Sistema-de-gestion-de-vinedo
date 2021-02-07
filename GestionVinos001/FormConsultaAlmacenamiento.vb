Public Class FormConsultaAlmacenamiento
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Dim sucursal As String

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con
        'SUCURSAL ES OBTENIDA DE TABLA DE USUARIO
        sucursal = s
    End Sub

    Private Sub checkCapacidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCapacidad.CheckedChanged
        If checkCapacidad.Checked Then
            txtCapacidad.Enabled = True
        Else
            txtCapacidad.Enabled = False
            txtCapacidad.Clear()
        End If
    End Sub
    Private Sub checkID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkID.CheckedChanged
        If checkID.Checked Then
            txtID.Enabled = True
        Else
            txtID.Enabled = False
            txtID.Clear()
        End If
    End Sub
    Private Sub checkTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTipo.CheckedChanged
        If checkTipo.Checked Then
            txtTipo.Enabled = True
        Else
            txtTipo.Enabled = False
            txtTipo.Clear()
        End If
    End Sub
    Private Sub checkMaterial_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkMaterial.CheckedChanged
        If checkMaterial.Checked Then
            txtMaterial.Enabled = True
        Else
            txtMaterial.Enabled = False
            txtMaterial.Clear()
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select * from lugar" & generarConsulta()
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
        If txtMaterial.Enabled Then
            If Not (control.entradaNoVacia(txtMaterial.Text)) Then
                Return False
            End If
        End If
        If txtTipo.Enabled Then
            If Not (control.entradaNoVacia(txtTipo.Text)) Then
                Return False
            End If
        End If
        If (txtID.Enabled) Then
            If Not (control.entradaNumerica(txtID.Text, "Int")) Then
                Return False
            End If
        End If
        If (txtCapacidad.Enabled) Then
            If Not (control.entradaNumerica(txtCapacidad.Text, "Dec")) Then
                Return False
            End If
        End If

        Return True

    End Function

    Private Function generarConsulta() As String
        Dim s As String = ""

        If checkCapacidad.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "

            Else
                s += " where "
            End If
            s += "capacidad=" & txtCapacidad.Text
        End If

        If checkID.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If

            s += "id=" & txtID.Text
        End If

        If checkMaterial.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "material='" & txtMaterial.Text & "'"
        End If

        If checkTipo.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "tipo='" & txtTipo.Text & "'"
        End If

        Return s

    End Function

End Class