Public Class FormModificacionBotella
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscBot As New BusquedaBotella

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub

   
    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from botella order by cod_botella"
        ds.Clear()
        da.Fill(ds, "res")
        Dim res As New Resultados(ds, "res")
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        imagen.Image = Nothing
        If comprobarEntradas() Then
            If buscBot.buscar(txtCodigo.Text, con) Then
                txtCapacidad.Text = buscBot.capacidad
                txtCapacidad.Enabled = True
                txtContenido.Text = buscBot.tipo
                txtContenido.Enabled = True
                txtStock.Text = buscBot.cantidad
                txtStock.Enabled = True
                btnModificar.Enabled = True
                If Not String.IsNullOrWhiteSpace(buscBot.ruta) Then
                    imagen.Image = Image.FromFile(Application.StartupPath & "\Recursos\" & buscBot.ruta)
                    rutaImg.Text = buscBot.ruta
                End If

            End If
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

        If txtCodigo.Enabled Then
            If (control.entradaNumerica(txtCodigo.Text, "Int")) Then
            Else
                Return False
            End If
        End If
        If txtCapacidad.Enabled Then
            If (control.entradaNumerica(txtCapacidad.Text, "Dec")) Then
            Else
                Return False
            End If
        End If

        If txtStock.Enabled Then
            If (control.entradaNumerica(txtStock.Text, "Int")) Then
            Else
                Return False
            End If
        End If



        Return True
    End Function

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscBot.modificar(txtContenido.Text, txtCapacidad.Text, txtStock.Text, rutaImg.Text)
        End If
    End Sub

    Private Sub btnBuscarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarImagen.Click
        OpenFileDialog1.Filter = "Imágenes(.jpg)|*.jpg|Imágenes(.jpeg)|*.jpeg | Imágenes(.png) | *.png"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\Recursos\"
        Dim resultado As DialogResult = OpenFileDialog1.ShowDialog()


        If resultado = Windows.Forms.DialogResult.OK Then
            rutaImg.Text = OpenFileDialog1.SafeFileName
            imagen.Image = Image.FromFile(Application.StartupPath & "\Recursos\" & OpenFileDialog1.SafeFileName)
        End If

    End Sub
End Class