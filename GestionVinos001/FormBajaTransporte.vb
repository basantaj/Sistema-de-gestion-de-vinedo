Public Class FormBajaTransporte
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscTrans As New BusquedaTransporte

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con


    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscTrans.buscar(txtMatricula.Text, con) Then
                txtCapacidad.Text = buscTrans.capacidad
                txtEstablecimiento.Text = buscTrans.idEstablecimiento
                grupoResultado.Enabled = True
            End If

        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscTrans.baja()
        txtCapacidad.Clear()
        txtEstablecimiento.Clear()
        txtMatricula.Clear()

        grupoResultado.Enabled = False
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select id_establecimiento, matricula, " & _
            "capacidad, to_char(inicio_turno, '%H:%M') as inicio_turno,to_char(fin_turno, '%H:%M') as fin_turno from transporte order by matricula"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "tab")
        Dim res As New Resultados(ds, "tab")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtMatricula.Text)) Then
            If control.comprobarLargo(txtMatricula.Text, 7, "Igual") Then
                Return True
            End If
            Return False
        Else
            Return False
        End If


    End Function

End Class