Public Class FormConsultaProductos
 Dim producto As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Dim sucursal As String

    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()


        con = c
        com.Connection = con
        da.SelectCommand = com
        sucursal = s

        com.CommandText = "select * from producto"
        da.Fill(ds, "uva")
        da.Fill(ds, "mosto")

        da.Fill(ds, "vino")
 

    End Sub
    Private Sub FormConsultaProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        radioUva.Checked = True
        producto = "Uva"
    End Sub

    Private Sub radioVino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioVino.CheckedChanged, radioMosto.CheckedChanged, radioUva.CheckedChanged
        checkAnioMosto.Checked = False
        checkAnioVino.Checked = False
        checkCepa.Checked = False

        If radioVino.Checked Then
            grupoVino.Enabled = True
            producto = "Vino"
        Else
            grupoVino.Enabled = False
        End If
        If radioMosto.Checked Then
            grupoMosto.Enabled = True
            producto = "Mosto"
        Else
            grupoMosto.Enabled = False
        End If
        If radioUva.Checked Then
            grupoMosto.Enabled = False
            grupoVino.Enabled = False
            producto = "Uva"
        End If
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnListado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListado.Click
        If comprobarEntradas() Then
            Select Case producto
                Case "Uva"
                    ds.Tables("uva").Clear()
                    com.CommandText = "select producto.nombre,producto.tipo,producto.origen, ubica.* from producto,ubica where id=id_producto " & generarConsulta()
                    da.Fill(ds, "uva")
                    dataGrid.DataSource = ds.Tables("uva")
                Case "Mosto"
                    ds.Tables("mosto").Clear()
                    com.CommandText = "select producto.nombre,producto.tipo,producto.origen, ubica.*,mosto.anio,mosto.cepa from producto,ubica,mosto where producto.id=id_producto and mosto.id=producto.id " & generarConsulta()
                    da.Fill(ds, "mosto")
                    dataGrid.DataSource = ds.Tables("mosto")
                Case "Vino"
                    ds.Tables("vino").Clear()
                    com.CommandText = "select producto.nombre,producto.tipo,producto.origen, ubica.*,vino.anio from producto,ubica,vino where producto.id=id_producto and vino.id=producto.id" & generarConsulta()
                    da.Fill(ds, "vino")
                    dataGrid.DataSource = ds.Tables("vino")
                Case Else
                    MsgBox("como hiciste")
            End Select



        End If

    End Sub


    Private Sub checkID_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkID.CheckedChanged
        If checkID.Checked Then
            txtID.Enabled = True
        Else
            txtID.Enabled = False
            txtID.Text = String.Empty
        End If
    End Sub
    Private Sub checkAnioVino_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkAnioVino.CheckedChanged
        If checkAnioVino.Checked Then
            txtAnioVino.Enabled = True
        Else
            txtAnioVino.Enabled = False
            txtAnioVino.Text = String.Empty
        End If
    End Sub
    
    Private Sub checkCepa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkCepa.CheckedChanged
        If checkCepa.Checked Then
            txtCepa.Enabled = True
        Else
            txtCepa.Enabled = False
            txtCepa.Text = String.Empty
        End If
    End Sub
    Private Sub checkTipo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkTipo.CheckedChanged
        If checkTipo.Checked Then
            txtTipo.Enabled = True
        Else
            txtTipo.Enabled = False
            txtTipo.Text = String.Empty
        End If
    End Sub
    Private Sub checkOrigen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkOrigen.CheckedChanged
        If checkOrigen.Checked Then
            txtOrigen.Enabled = True
        Else
            txtOrigen.Enabled = False
            txtOrigen.Text = String.Empty
        End If
    End Sub
    Private Sub checkNombre_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkNombre.CheckedChanged
        If checkNombre.Checked Then
            txtNom.Enabled = True
        Else
            txtNom.Enabled = False
            txtNom.Text = String.Empty
        End If
    End Sub
    Private Sub checkAnioMosto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkAnioMosto.CheckedChanged
        If checkAnioMosto.Checked Then
            txtAnioMosto.Enabled = True
        Else
            txtAnioMosto.Enabled = False
            txtAnioMosto.Text = String.Empty
        End If
    End Sub

    Private Sub checkIDContenedor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkIDContenedor.CheckedChanged
        If checkIDContenedor.Checked Then
            txtIDContenedor.Enabled = True
        Else
            txtIDContenedor.Enabled = False
            txtIDContenedor.Text = String.Empty
        End If
    End Sub


    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()
        For Each g As GroupBox In Me.Controls.OfType(Of GroupBox)()
            If g.Enabled Then
                For Each t As TextBox In g.Controls.OfType(Of TextBox)()
                    If t.Enabled Then
                        If Not (control.entradaNoVacia(t.Text)) Then
                            Return False
                        End If
                    End If

                Next
            End If
        Next

        If txtID.Enabled Then
            If Not (control.entradaNumerica(txtID.Text, "Int")) Then
                Return False

            End If
        End If

        If txtIDContenedor.Enabled Then
            If Not (control.entradaNumerica(txtIDContenedor.Text, "Int")) Then
                Return False
            End If
        End If


        Select Case producto
            Case "Vino"
                If txtAnioVino.Enabled Then
                    If Not (control.comprobarLargo(txtAnioVino.Text, 4, "Igual") _
                        And control.entradaNumerica(txtAnioVino.Text, "Int")) Then
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
                End If
                Return True

            Case Else
                Return True
        End Select



    End Function

    Private Function generarConsulta() As String
        Dim s As String = ""

        If checkID.Checked Then
            s += " And id=" & txtID.Text
        End If

        If checkNombre.Checked Then
            s += " And nombre='" & txtNom.Text & "'"
        End If

        If checkOrigen.Checked Then

            s += " And origen='" & txtOrigen.Text & "'"
        End If

        If checkTipo.Checked Then

            s += " And tipo='" & txtTipo.Text & "'"
        End If

        If checkIDContenedor.Checked Then

            s += " And id_lugar=" & txtIDContenedor.Text
        End If

        If checkAnioMosto.Checked Then

            s += " And anio=" & txtAnioMosto.Text
        End If

        If checkAnioVino.Checked Then

            s += " And anio=" & txtAnioVino.Text
        End If

        If checkCepa.Checked Then

            s += " And cepa='" & txtCepa.Text & "'"
        End If


        Return s

    End Function

End Class