Public Class FormBajaProducto
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscProd As New BusquedaProducto

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con


    End Sub
   
  
    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        buscProd.baja()
        txtID.Clear()
        txtNombre.Clear()
        txtOrigen.Clear()
        txtTipo.Clear()
        grupoResultado.Enabled = False
    End Sub
    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If comprobarEntradas() Then
            If buscProd.buscar(txtID.Text, con) Then
                txtNombre.Text = buscProd.nombre
                txtOrigen.Text = buscProd.origen
                txtTipo.Text = buscProd.tipoProd
                grupoResultado.Enabled = True
            End If
        End If

    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from producto order by id"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "tab")
        Dim res As New Resultados(ds, "tab")
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        If (control.entradaNoVacia(txtID.Text) And control.entradaNumerica(txtID.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub checkTotal_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTotal.CheckedChanged
        If checkTotal.Checked Then
            btnTotal.Enabled = True
        Else
            btnTotal.Enabled = False
        End If
    End Sub

    Private Sub btnTotal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTotal.Click
        Dim res As Integer = MessageBox.Show("¿Borrar todas las entradas relacionadas a este producto?", "Confirmar", MessageBoxButtons.YesNo)
        If res = DialogResult.Yes Then
            com.CommandText = "delete from trasiega where id_producto=" & txtID.Text & _
                ";delete from transporta where id_producto=" & txtID.Text & _
                ";delete from observa where id_producto=" & txtID.Text & _
                ";delete from realiza where id_producto=" & txtID.Text & _
                ";delete from ubica where id_producto=" & txtID.Text & _
                ";delete from producto where id=" & txtID.Text
            Try
                con.Open()
                com.ExecuteNonQuery()

            Catch ex As Exception
                MsgBox("Error " & ex.Message)
            Finally
                con.Close()
                txtID.Clear()
                txtNombre.Clear()
                txtOrigen.Clear()
                txtTipo.Clear()
                checkTotal.Checked = False
                grupoResultado.Enabled = False
            End Try



        End If
    End Sub
End Class