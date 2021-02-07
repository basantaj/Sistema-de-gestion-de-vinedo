Public Class FormAltaProceso

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim alta As New AltaProceso(txtID.Text, txtTipoProceso.Text, numDuracion.Value, txtpH.Text, cmbProductos.Text, con)
        Else
            MsgBox("Revise los valores ingresados")
        End If


    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from proceso"
        da.SelectCommand = com

        da.Fill(ds, "procesos")
        Dim res As New Resultados(ds, "procesos")

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()

        For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
            For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                If Not control.entradaNoVacia(t.Text) Then
                    Return False
                End If
            Next
        Next

        If (control.entradaNumerica(txtID.Text, "Int") And numDuracion.Value > 0 And control.entradaNumerica(txtpH.Text, "Dec")) Then
            Return True
        Else
            Return False
        End If

    End Function

 
    Private Sub FormAltaProceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select * from botella"
        da.Fill(ds, "productos")
        cmbProductos.DataSource = ds.Tables("productos")
        cmbProductos.DisplayMember = "tipo_producto"
    End Sub
End Class