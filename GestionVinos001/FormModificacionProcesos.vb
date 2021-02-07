Public Class FormModificacionProcesos

    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim busPro As New BusquedaProceso


    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click

        com.CommandText = "select * from proceso order by id"
        da.SelectCommand = com
        da.Fill(ds, "tab")
        Dim res As New Resultados(ds, "tab")

    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If busPro.buscar(txtID.Text, con) Then
                txtTipoProceso.Text = busPro.tipo
                txtTipoProceso.Enabled = True
                cmbProductos.SelectedIndex = cmbProductos.FindString(busPro.tipoproducto)
                cmbProductos.Enabled = True
                txtpH.Text = busPro.phEsperado
                txtpH.Enabled = True
                numDuracion.Value = busPro.duracionEsperada
                numDuracion.Enabled = True
                btnModificar.Enabled = True
            End If

        End If
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            busPro.modificar(txtTipoProceso.Text, txtpH.Text, numDuracion.Value, cmbProductos.Text)
            For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
                t.Enabled = False
                t.Clear()
            Next
            txtID.Enabled = True
            numDuracion.ResetText()
            numDuracion.Enabled = False
            btnModificar.Enabled = False
        End If


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


        If Not (control.entradaNumerica(txtID.Text, "Int")) Then
            Return False
        End If
        If (txtpH.Enabled) Then
            If Not (control.entradaNumerica(txtpH.Text, "Dec")) Then
                Return False
            End If
        End If

        If (numDuracion.Enabled) Then
            If Not (control.entradaNumerica(numDuracion.Value, "Dec")) Then
                Return False
            End If
        End If


        Return True
    End Function

    Private Sub FormModificacionProcesos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select * from botella"
        da.Fill(ds, "productos")
        cmbProductos.DataSource = ds.Tables("productos")
        cmbProductos.DisplayMember = "tipo_producto"
    End Sub
End Class