Public Class FormAltaBotella
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


    Private Sub btnBuscarImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarImagen.Click
        OpenFileDialog1.Filter = "Imágenes(.jpg)|*.jpg|Imágenes(.jpeg)|*.jpeg | Imágenes(.png) | *.png"
        OpenFileDialog1.InitialDirectory = Application.StartupPath & "\Recursos\"
        Dim resultado As DialogResult = OpenFileDialog1.ShowDialog()


        If resultado = Windows.Forms.DialogResult.OK Then
            rutaImg.Text = OpenFileDialog1.SafeFileName
            imagen.SizeMode = PictureBoxSizeMode.Zoom
            imagen.Image = Image.FromFile(Application.StartupPath & "\Recursos\" & OpenFileDialog1.SafeFileName)
        End If

    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each t As TextBox In grupoDatos.Controls.OfType(Of TextBox)()
            If Not control.entradaNoVacia(t.Text) Then
                Return False
            End If
        Next

        If (control.entradaNumerica(txtCod.Text, "Int") And control.entradaNumerica(txtCapacidad.Text, "Dec") _
            And control.entradaNumerica(txtStock.Text, "Int")) Then
            Return True
        Else
            Return False
        End If


    End Function

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        com.CommandText = "select * from botella order by cod_botella asc"
        da.SelectCommand = com
        ds.Clear()
        da.Fill(ds, "botellas")
        Dim res As New Resultados(ds, "botellas")
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If comprobarEntradas() Then
            Dim altaBot As New AltaBotella(txtCod.Text, txtContenido.Text, txtCapacidad.Text, txtStock.Text, rutaImg.Text, con)

        End If
    End Sub
End Class