Public Class FormConsultaBotella
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim busc As New BusquedaBotella

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con


    End Sub

    Private Sub checkCapacidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCapacidad.CheckedChanged
        If checkCapacidad.Checked Then
            txtCapacidad.Enabled = True
        Else
            txtCapacidad.Enabled = False
            txtCapacidad.Clear()
        End If
    End Sub

    Private Sub checkCodigo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCodigo.CheckedChanged
        If checkCodigo.Checked Then
            txtCodigo.Enabled = True
        Else
            txtCodigo.Enabled = False
            txtCodigo.Clear()
        End If
    End Sub

    Private Sub checkContenido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkContenido.CheckedChanged
        If checkContenido.Checked Then
            txtContenido.Enabled = True
        Else
            txtContenido.Enabled = False
            txtContenido.Clear()
        End If
    End Sub


    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If txtCapacidad.Enabled Then
            If Not (control.entradaNumerica(txtCapacidad.Text, "Dec")) Then
                Return False
            End If
        End If
        If txtCodigo.Enabled Then
            If Not (control.entradaNumerica(txtCodigo.Text, "Int")) Then
                Return False
            End If
        End If
        If (txtContenido.Enabled) Then
            If Not (control.entradaNoVacia(txtContenido.Text)) Then
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
            s += "capac_botella=" & txtCapacidad.Text
        End If

        If checkCodigo.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If

            s += "cod_botella=" & txtCodigo.Text
        End If

        If checkContenido.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "tipo_producto='" & txtContenido.Text & "'"
        End If


        Return s

    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select cod_botella,capac_botella,tipo_producto,cantidad_botellas as stock from botella" & generarConsulta()
            da.SelectCommand = com
            ds.Clear()
            da.Fill(ds, "tab")
            dataGrid.DataSource = ds.Tables("tab")
        End If
    End Sub

    Private Sub dGrid_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGrid.CellClick
        Try

            If busc.buscar(dataGrid.Item("cod_botella", e.RowIndex).Value, con) Then
                imagen.Image = Image.FromFile(Application.StartupPath & "\Recursos\" & busc.ruta)
            End If
        Catch ex As Exception

        End Try
    End Sub

End Class