Public Class FormModificacionTransporte

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim busTra As New BusquedaTransporte
    Dim control As New ControlesDeEntrada()

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select id_establecimiento, matricula, " & _
            "capacidad, to_char(inicio_turno, '%H:%M') as inicio_turno,to_char(fin_turno, '%H:%M') as fin_turno from transporte"
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If busTra.buscar(txtMatricula.Text, con) Then
                txtCapacidad.Text = busTra.capacidad
                txtCapacidad.Enabled = True
                txtEstablecimiento.Text = busTra.idEstablecimiento
                txtEstablecimiento.Enabled = True
                cmbHrIn.SelectedItem = control.extraerHora(busTra.inicioTurno, "Horas")
                cmbMinIn.SelectedItem = control.extraerHora(busTra.inicioTurno, "Minutos")
                cmbHrFin.SelectedItem = control.extraerHora(busTra.finTurno, "Horas")
                cmbMinFin.SelectedItem = control.extraerHora(busTra.finTurno, "Minutos")
                btnModificar.Enabled = True
            End If
        End If

    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            Dim hIni As String = cmbHrIn.Text & ":" & cmbMinIn.Text
            Dim hFin As String = cmbHrFin.Text & ":" & cmbMinFin.Text
            busTra.modificar(txtEstablecimiento.Text, txtCapacidad.Text, hIni, hFin)
            txtCapacidad.Enabled = False
            txtCapacidad.Clear()
            txtEstablecimiento.Enabled = False
            txtEstablecimiento.Clear()
            btnModificar.Enabled = False
        End If


    End Sub

    Private Function comprobarEntradas() As Boolean

        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If t.Enabled Then
                If Not control.entradaNoVacia(t.Text) Then
                    Return False
                End If
            End If
        Next

        If Not (control.comprobarLargo(txtMatricula.Text, 7, "Igual")) Then
            Return False
        End If

        If txtCapacidad.Enabled Then
            If Not (control.entradaNumerica(txtCapacidad.Text, "Dec")) Then
                Return False
            End If
        End If

        If txtEstablecimiento.Enabled Then
            If Not (control.entradaNumerica(txtEstablecimiento.Text, "Int")) Then
                Return False
            End If
        End If

        If btnModificar.Enabled Then
            If (Integer.Parse(cmbHrIn.Text) > Integer.Parse(cmbHrFin.Text)) Or (Integer.Parse(cmbHrIn.Text) = Integer.Parse(cmbHrFin.Text) _
                                                                               And (Integer.Parse(cmbMinIn.Text) > Integer.Parse(cmbMinFin.Text) Or _
                                                                                    Integer.Parse(cmbMinIn.Text) = Integer.Parse(cmbMinFin.Text))) Then
                MsgBox("Horario de trabajo incorrecto")
                Return False
            End If
        End If




        Return True
    End Function



End Class