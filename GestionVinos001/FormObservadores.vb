Public Class FormObservadores


    Public alerta As String = ""
    Private cedula, cargo, sucursal As String
    Dim con As New Odbc.OdbcConnection
    Dim com As New Odbc.OdbcCommand
    Dim da As New Odbc.OdbcDataAdapter
    Dim ds As New DataSet

    Public Sub New(ByVal ci As String, ByVal s As String, ByVal ca As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com
        sucursal = s
        cargo = ca
        cedula = ci

        Text = "Panel de " & cargo
        Show()
    End Sub

    Private Sub FormObservadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            com.CommandText = "select tipo, id from proceso"
            da.Fill(ds, "combo")
            cmbProcesosAObservar.DataSource = ds.Tables("combo")
            cmbProcesosAObservar.DisplayMember = "tipo"

            com.CommandText = "select * from observa where fecha_alerta=TODAY"
            da.Fill(ds, "alertas")
            If ds.Tables("alertas").Rows.Count > 0 Then
                For i As Integer = 0 To ds.Tables("alertas").Rows.Count - 1 Step 1
                    MsgBox("IMPORTANTE: " & ds.Tables("alertas").Rows(i).Item("observacion"), MsgBoxStyle.Exclamation, "ALERTA")


                Next
            End If

        Catch ex As Exception
        End Try
        If cargo = "enologo" Then
            btnAlerta.Show()
        End If



    End Sub

    Private Sub btnObservacionConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObservacionConfirmar.Click
        If comprobarEntradas() Then
            Dim obs As New Observaciones(cedula, txtIDContenedor.Text, txtIDProd.Text, ds.Tables("combo").Rows(cmbProcesosAObservar.SelectedIndex).Item("id"), _
                                         txtpH.Text, txtAzucar.Text, txtObservacion.Text, alerta, con)
        End If

    End Sub

    Private Sub btnAlerta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlerta.Click
        Dim Alerta As New FormAlerta(Me)
        Alerta.Show()

    End Sub


    Private Sub btnConsulProd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulProd.Click
        Dim consulProd As New FormConsultaProductos(sucursal, con)
        consulProd.Show()
    End Sub
    Private Sub cerrar() Handles Me.FormClosed
        FormLogin.Visible = True
    End Sub



    Private Function comprobarEntradas() As Boolean
        Dim control As New ControlesDeEntrada()

        For Each t As TextBox In Me.Controls.OfType(Of TextBox)()
            If Not (control.entradaNoVacia(t.Text)) Then
                Return False
            End If
        Next

        If Not (control.entradaNumerica(txtpH.Text, "Dec")) Then
            Return False
        End If

        If Not (control.entradaNumerica(txtAzucar.Text, "Dec")) Then
            Return False
        End If

        If Not (control.comprobarLargo(txtObservacion.Text, 100, "Menor")) Then
            Return False
        End If

        Return True
    End Function


    Private Sub btnProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesos.Click
        com.CommandText = "select p.tipo,r.* from realiza r,proceso p where p.id=r.id_proceso and fecha_fin_pro is null"

        da.Fill(ds, "proActi")
        Dim res As New Resultados(ds, "proActi")
    End Sub
End Class