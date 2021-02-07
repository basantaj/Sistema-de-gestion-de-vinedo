Public Class FormActividadTransporta
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Public Sub New(ByVal c As Odbc.OdbcConnection)
        InitializeComponent()

        con = c
        com.Connection = con
        da.SelectCommand = com
        cmbHr.SelectedIndex = 0
        cmbMin.SelectedIndex = 0

    End Sub


    Private Sub FormActividadTransporta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        com.CommandText = "select * from transporta where hor_llegada=''"
        ds.Clear()
        da.Fill(ds, "combo")
        If ds.Tables("combo").Rows.Count > 0 Then

            cmbMatricula.DataSource = ds.Tables("combo")
            cmbMatricula.DisplayMember = "matricula"

        Else
            MsgBox("No hay vehiculos en transito.")
            Me.Close()
        End If

    End Sub

  

    Private Sub btnVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehiculos.Click
        com.CommandText = "select e.id as id_origen,e.nombre as origen, ta.* from transporta ta, transporte te, establecimiento e " _
            & "where ta.matricula=te.matricula and " _
            & "te.id_establecimiento=e.id and ta.hor_llegada='' order by e.nombre"
        da.Fill(ds, "transportes")
        Dim res As New Resultados(ds, "transportes")
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        com.CommandText = "update transporta set hor_llegada='" & (cmbHr.Text & ":" & cmbHr.Text) & "' where matricula='" & cmbMatricula.Text & "' and hor_llegada=''"
        Try
            con.Open()
            com.ExecuteNonQuery()
            MsgBox("Registro actualizado")
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            con.Close()
        End Try


    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class