Public Class FormModificacionProducto
    Dim producto As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet
    Dim buscProd As New BusquedaProducto
    Dim sucursal As String

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con


    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

        If comprobarEntradas() Then
            buscProd.limpieza()
            limpieza()
            If buscProd.buscar(txtIDProducto.Text, con) Then
                txtAnioMosto.Text = buscProd.anioM
                txtAnioVino.Text = buscProd.anioV
                txtCepa.Text = buscProd.cepa
                txtNom.Text = buscProd.nombre
                txtOrigen.Text = buscProd.origen
                txtTipo.Text = buscProd.tipoProd
                For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
                    For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                        If Not (String.IsNullOrEmpty(t.Text)) Then
                            t.Enabled = True
                            g.Enabled = True
                        End If

                    Next
                Next
                btnModificar.Enabled = True
            End If
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        Dim conProd As New FormConsultaProductos(sucursal, con)
        conProd.Show()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        If comprobarEntradas() Then
            buscProd.modificar(txtNom.Text, txtOrigen.Text, txtTipo.Text, txtAnioMosto.Text, txtAnioVino.Text, txtCepa.Text)
            limpieza()
            buscProd.limpieza()
        End If

        btnModificar.Enabled = False
    End Sub

    Private Sub btnListarContenedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MsgBox("Muestra los contenedores registrados")
    End Sub

    Private Sub limpieza()

        txtAnioMosto.Enabled = False
        txtAnioMosto.Clear()
        txtAnioVino.Enabled = False
        txtAnioVino.Clear()
        txtCepa.Enabled = False
        txtCepa.Clear()
        txtOrigen.Enabled = False
        txtOrigen.Clear()
        txtNom.Enabled = False
        txtNom.Clear()
        txtTipo.Enabled = False
        txtTipo.Clear()
    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
            If g.Enabled Then
                For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                    If t.Enabled Then
                        If (Not control.entradaNoVacia(t.Text)) Then
                            Return False
                        End If
                    End If
                Next
            End If
        Next

        If Not (control.entradaNumerica(txtIDProducto.Text, "Int")) Then
            Return False
        End If


        Select Case producto
            Case "Vino"
                If txtAnioVino.Enabled Then
                    If Not (control.comprobarLargo(txtAnioVino.Text, 4, "Igual") _
                        And control.entradaNumerica(txtAnioVino.Text, "Int") _
                        ) Then
                        Return False
                    End If
                End If
                Return True
            Case "Mosto"
                If txtAnioMosto.Enabled Then
                    If Not (control.comprobarLargo(txtAnioMosto.Text, 4, "Igual") _
                        And control.entradaNumerica(txtAnioMosto.Text, "Int")) Then
                        Return False
                    End If
                    Return True
                End If

                If txtCepa.Enabled Then
                    If String.IsNullOrEmpty(txtCepa.Text) Then
                        Return False
                    End If
                End If
                Return True
            Case Else
                Return True
        End Select



    End Function

End Class