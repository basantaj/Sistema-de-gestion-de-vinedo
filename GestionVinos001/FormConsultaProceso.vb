Public Class FormConsultaProceso


    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet



    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con


    End Sub

    Private Sub checkID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkID.CheckedChanged
        If checkID.Checked Then
            txtID.Enabled = True
        Else
            txtID.Enabled = False
            txtID.Text = String.Empty
        End If
    End Sub
   
    
    
    Private Sub checkTipoProceso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTipoProceso.CheckedChanged
        If checkTipoProceso.Checked Then
            txtTipoProceso.Enabled = True
        Else
            txtTipoProceso.Enabled = False
            txtTipoProceso.Text = String.Empty
        End If
    End Sub

    Private Sub checkProducto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkProducto.CheckedChanged
        If checkProducto.Checked Then
            txtTipoProducto.Enabled = True
        Else
            txtTipoProducto.Enabled = False
            txtTipoProducto.Clear()
        End If
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            com.CommandText = "select * from proceso" & generarConsulta()
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
                If Not (control.entradaNoVacia(t.Text)) Then
                    Return False
                End If
            End If

        Next

        If txtTipoProducto.Enabled Then
            If Not (control.entradaNoVacia(txtTipoProducto.Text)) Then
                Return False
            End If
        End If
        If txtID.Enabled Then
            If Not (control.entradaNumerica(txtID.Text, "Int")) Then
                Return False
            End If
        End If

        Return True
    End Function
    Private Function generarConsulta() As String
        Dim s As String = ""

        If checkID.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "

            Else
                s += " where "
            End If
            s += "id=" & txtID.Text
        End If

        If checkProducto.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If

            s += "tipo_producto='" & txtTipoProducto.Text & "'"
        End If

        If checkTipoProceso.Checked Then
            If Not String.IsNullOrWhiteSpace(s) Then
                s += " And "
            Else
                s += " where "
            End If
            s += "tipo='" & txtTipoProceso.Text & "'"
        End If


        Return s

    End Function
End Class