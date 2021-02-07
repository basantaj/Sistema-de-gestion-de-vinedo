Public Class FormConsultaTransporte
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet



    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con


    End Sub
    Private Sub checkEstablecimiento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkEstablecimiento.CheckedChanged
        If checkEstablecimiento.Checked Then
            txtEstablecimiento.Enabled = True
        Else
            txtEstablecimiento.Enabled = False
            txtEstablecimiento.Text = String.Empty
        End If
    End Sub
    Private Sub checkCapacidad_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCapacidad.CheckedChanged
        If checkCapacidad.Checked Then
            txtCapacidad.Enabled = True
        Else
            txtCapacidad.Enabled = False
            txtCapacidad.Text = String.Empty
        End If
    End Sub
    Private Sub checkMatricula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkMatricula.CheckedChanged
        If checkMatricula.Checked Then
            txtMatricula.Enabled = True
        Else
            txtMatricula.Enabled = False
            txtMatricula.Text = String.Empty
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select id_establecimiento, matricula, " & _
            "capacidad, inicio_turno,fin_turno from transporte  order by id_establecimiento"
            da.SelectCommand = com
            ds.Clear()
            da.Fill(ds, "tab")
            For i As Integer = 0 To (ds.Tables("tab").Rows.Count - 1) Step 1
                Dim a As String = ds.Tables("tab").Rows(i).Item("inicio_turno") = ds.Tables("tab").Rows(i).Item("inicio_turno")
                ds.Tables("tab").Rows(i).Item("inicio_turno") = a
            Next
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
                If Not (control.entradaNoVacia(t.Text)) Then
                    Return False
                End If
            End If

        Next

        If txtMatricula.Enabled Then
            If Not (control.comprobarLargo(txtMatricula.Text, 7, "Igual")) Then
                Return False
            End If
        End If
        
        If txtCapacidad.Enabled Then
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

        If checkEstablecimiento.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If

            s += "id_establecimiento=" & txtEstablecimiento.Text
        End If

        If checkMatricula.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "matricula='" & txtMatricula.Text & "'"
        End If


        Return s

    End Function

End Class