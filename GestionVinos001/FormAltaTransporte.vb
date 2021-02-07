Public Class FormAltaTransporte

    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com


    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim altaTrans As New AltaTransporte(txtMatricula.Text, txtEstablecimiento.Text, txtCapacidad.Text, cmbHrIn.Text + ":" + cmbMinIn.Text, _
                                                cmbHrFin.Text + ":" + cmbMinFin.Text, con)
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select id_establecimiento, matricula, " & _
            "capacidad, to_char(inicio_turno, '%H:%M') as inicio_turno,to_char(fin_turno, '%H:%M') as fin_turno from transporte order by matricula"
        da.Fill(ds, "transportes")
        Dim res As New Resultados(ds, "transportes")

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If Not control.entradaNoVacia(t.Text) Then
                Return False
            End If
        Next

        If (control.comprobarLargo(txtMatricula.Text, 7, "Igual") And control.entradaNumerica(txtCapacidad.Text, "Dec") And control.entradaNumerica(txtEstablecimiento.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function

  

    Private Sub FormAltaTransporte_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each cmb As ComboBox In grupoDatos.Controls.OfType(Of ComboBox)()
            cmb.SelectedIndex = 0
        Next
    End Sub
End Class