Public Class FormAltaProducto


    Dim relacion, producto, sucursal As String
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        sucursal = s
        con = c
        com.Connection = con
        da.SelectCommand = com

        inicializarCombos()
    End Sub

    Private Sub FormAltaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radioNinguno.Checked = True
        cmbHr.SelectedIndex = 0
        cmbMin.SelectedIndex = 0
        radioUva.Checked = True
        producto = "uva"
    End Sub

    Private Sub radioVino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioVino.CheckedChanged, radioMosto.CheckedChanged, radioUva.CheckedChanged
        If radioVino.Checked Then
            grupoVino.Enabled = True
            producto = "vino"
        Else
            grupoVino.Enabled = False
            txtAnioVino.Text = String.Empty

        End If
        If radioMosto.Checked Then
            grupoMosto.Enabled = True
            producto = "mosto"
        Else
            grupoMosto.Enabled = False
            txtAnioMosto.Text = String.Empty
            txtCepa.Text = String.Empty
        End If
        If radioUva.Checked Then
            grupoMosto.Enabled = False
            grupoVino.Enabled = False
            producto = "uva"
        End If
    End Sub


    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click

        If comprobarEntradas() Then

            Dim alta As New AltaProducto(txtIDProducto.Text, txtNom.Text, txtOrigen.Text, comboProducto.Text, cmbIdCont.Text, txtUnidad.Text, txtCantidad.Text _
                                         , txtAnioVino.Text, txtAnioMosto.Text, txtCepa.Text, cmbMatricula.Text, _
                                         (cmbHr.Text & ":" & cmbMin.Text), txtDestino.Text, producto, relacion, con)

            inicializarCombos()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarProductos.Click
        com.CommandText = "select * from producto"

        da.Fill(ds, "producto")
        Dim res As New Resultados(ds, "producto")
    End Sub

    Private Sub btnListarContenedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarContenedores.Click
        com.CommandText = "select lugar.* from lugar,ubica where id=id_lugar and id not in (select id_lugar " _
           & "from ubica where fecha_fin is null)"

        da.Fill(ds, "lugar")
        Dim res As New Resultados(ds, "lugar")

    End Sub

    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
            If g.Enabled Then
                For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                    If (Not control.entradaNoVacia(t.Text)) Then
                        Return False
                    End If
                Next
            End If
        Next

        If Not (control.entradaNumerica(txtIDProducto.Text, "Int") ) Then
            Return False

        End If
        Select Case producto
            Case "vino"
                If Not (control.comprobarLargo(txtAnioVino.Text, 4, "Igual") _
                    And control.entradaNumerica(txtAnioVino.Text, "Int")) Then

                    Return False
                End If

            Case "mosto"
                If Not (control.comprobarLargo(txtAnioMosto.Text, 4, "Igual") _
                    And control.entradaNumerica(txtAnioMosto.Text, "Int")) Then
                    Return False
                End If


        End Select

        If relacion = "Ubica" Then
            If Not (control.entradaNumerica(txtCantidad.Text, "Dec") And control.letrasSolo(txtUnidad.Text)) Then
                Return False
            End If
        End If


        Return True
    End Function

    
    Private Sub btnVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehiculos.Click
        com.CommandText = "select distinct te.matricula,te.capacidad from transporta ta, transporte te where te.matricula=ta.matricula and " & _
            "te.matricula not in(select matricula from transporta where hor_llegada='')"
        da.Fill(ds, "resV")
        Dim res As New Resultados(ds, "resV")
    End Sub

 
    Private Sub radioNinguno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioNinguno.CheckedChanged, radioContenedor.CheckedChanged, radioVehiculo.CheckedChanged
        If radioNinguno.Checked Then
            activacionGrupos(grupoCont, "Desactivar")
            activacionGrupos(grupoVeh, "Desactivar")
            relacion = ""
        End If
        If radioVehiculo.Checked Then
            activacionGrupos(grupoVeh, "Activar")
            activacionGrupos(grupoCont, "Desactivar")
            relacion = "Transporta"
        End If
        If radioContenedor.Checked Then
            activacionGrupos(grupoCont, "Activar")
            activacionGrupos(grupoVeh, "Desactivar")
            relacion = "Ubica"
        End If

    End Sub

    Private Sub activacionGrupos(ByRef g As GroupBox, ByVal a As String)
        Select Case a
            Case "Activar"
                For Each c As Control In g.Controls
                    c.Enabled = True
                Next
                g.Enabled = True
            Case "Desactivar"
                For Each c As Control In g.Controls
                    c.Enabled = False
                Next
                g.Enabled = False
        End Select


    End Sub

    Private Sub inicializarCombos()
        ds.Clear()
        com.CommandText = "select tipo_producto, cod_botella from botella"
        da.Fill(ds, "combo")
        If ds.Tables("combo").Rows.Count > 0 Then

            comboProducto.DataSource = ds.Tables("combo")
            comboProducto.DisplayMember = "tipo_producto"
            comboProducto.SelectedIndex = 0
        End If

        com.CommandText = "select matricula from transporta where matricula not in (select matricula from transporta where hor_llegada='')"
        da.Fill(ds, "combo2")
        If ds.Tables("combo2").Rows.Count > 0 Then

            cmbMatricula.DataSource = ds.Tables("combo2")
            cmbMatricula.DisplayMember = "matricula"
            cmbMatricula.SelectedIndex = 0
        End If

        com.CommandText = "select id from lugar where id_sucursal=" & sucursal & " and id not in (select id_lugar " _
            & "from ubica where fecha_fin is null)"
        da.Fill(ds, "combo3")
        If ds.Tables("combo3").Rows.Count > 0 Then

            cmbIdCont.DataSource = ds.Tables("combo3")
            cmbIdCont.DisplayMember = "id"
            cmbIdCont.SelectedIndex = 0
        End If
    End Sub

End Class