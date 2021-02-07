Public Class FormAdministrativo

    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet
    Dim sucursal As String
    Public Sub New(ByVal s As String, ByVal c As Odbc.OdbcConnection)
        InitializeComponent()
        sucursal = s
        con = c
        com.Connection = con
        da.SelectCommand = com

    End Sub

    Private Sub cerra() Handles Me.FormClosed
        FormLogin.Visible = True
    End Sub
 
    Private Sub btnVehiculos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVehiculos.Click
        Dim veh As New FormActividadTransporta(con)
        veh.Show()
    End Sub

    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngreso.Click
        Dim altaP As New FormAltaProducto(sucursal, con)
        altaP.Show()
    End Sub

    Private Sub btnProduccion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProduccion.Click
        Dim producc As New FormActividadProducto(sucursal, con)
        producc.Show()
    End Sub

    Private Sub btnContenedoresVacios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnContenedoresVacios.Click
        com.CommandText = "SELECT * FROM lugar WHERE id_sucursal=" & sucursal & " and id NOT IN(SELECT id_lugar FROM ubica WHERE fecha_fin IS NULL)"
        ds.Clear()
        da.Fill(ds, "lug")
        Dim res As New Resultados(ds, "lug")

    End Sub

    Private Sub btnTransporteDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransporteDisponible.Click
        com.CommandText = "select te.id_establecimiento,te.matricula,te.capacidad from transporta ta, transporte te where te.matricula=ta.matricula and " & _
            "te.matricula not in(select matricula from transporta where hor_llegada='')"
        ds.Clear()
        da.Fill(ds, "trans")
        Dim res As New Resultados(ds, "trans")
    End Sub

    Private Sub btnReservasValidas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReservasValidas.Click
        com.CommandText = "select * from reserva where fecha between TODAY-1 and TODAY"
        ds.Clear()
        da.Fill(ds, "reserva")
        Dim res As New Resultados(ds, "reserva")
    End Sub

    Private Sub btnObservaciones_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObservaciones.Click
        com.CommandText = "select observacion,fecha,ci_personal from observa "
        ds.Clear()
        da.Fill(ds, "observaciones")
        Dim res As New Resultados(ds, "observaciones")

    End Sub

    Private Sub btnProcesosActivos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesosActivos.Click
        com.CommandText = "select p.tipo,r.* from realiza r,proceso p where p.id=r.id_proceso and fecha_fin_pro is null"
        ds.Clear()
        da.Fill(ds, "proActi")
        Dim res As New Resultados(ds, "proActi")
    End Sub

    Private Sub btnProductoDisponible_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProductoDisponible.Click
        com.CommandText = "SELECT tipo_producto, capac_botella,cantidad_botellas FROM botella " _
            & "GROUP BY tipo_producto,capac_botella,cantidad_botellas ORDER BY tipo_producto ASC, capac_botella ASC"
        ds.Clear()
        da.Fill(ds, "prodDis")
        Dim res As New Resultados(ds, "prodDis")
    End Sub

    Private Sub btnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventario.Click
        com.CommandText = " select t.tipo,stock,unidad,fecha from tiene t, inventario i where t.tipo=i.tipo and id_sucursal=" + sucursal
        ds.Clear()
        da.Fill(ds, "inven")
        Dim res As New Resultados(ds, "inven")
    End Sub

    Private Sub btnListoParaTrasiego_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListoParaTrasiego.Click
        com.CommandText = "SELECT p.id as id_producto, p.nombre as nombre_producto,l.tipo as tipo_lugar,l.id as lugar from ubica u, producto p, lugar l" _
            & " WHERE p.id=u.id_producto AND l.id=u.id_lugar AND l.tipo='Barrica'" _
            & " AND u.fecha_fin IS NULL ORDER BY l.id ASC"
        ds.Clear()
        da.Fill(ds, "listos")
        Dim res As New Resultados(ds, "listos")

    End Sub

    Private Sub btnMasReservados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMasReservados.Click
        com.CommandText = "SELECT FIRST 3 b.tipo_producto,sum(r.cantidad)AS total FROM botella b, " _
            & "reserva r  WHERE b.cod_botella = r.cod_botella And Month(r.fecha) = 10" _
            & "GROUP BY b.tipo_producto ORDER BY total DESC"
        ds.Clear()
        da.Fill(ds, "masRes")
        Dim res As New Resultados(ds, "masRes")
    End Sub

    Private Sub btnMenosStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMenosStock.Click
        com.CommandText = "SELECT FIRST 3 b.cod_botella AS Codigo_botella,b.tipo_producto, b.cantidad_botellas " & _
            "FROM trasiega t, botella b WHERE  b.cod_botella=t.cod_botella " & _
            "ORDER BY cantidad_botellas ASC"
        ds.Clear()
        da.Fill(ds, "menosProd")
        Dim res As New Resultados(ds, "menosProd")
    End Sub

    Private Sub btnModRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModRes.Click
        Dim modRes As New FormModificacionReservas(con)
        modRes.Show()
    End Sub

    Private Sub btnBajRes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBajRes.Click
        Dim bajRes As New FormBajaReservas(con)
        bajRes.Show()
    End Sub
End Class