Public Class FormAdministrador

    Private operacion As String
    Dim con As New Odbc.OdbcConnection
    Dim sucursal As String

    Public Sub New(ByVal c As Odbc.OdbcConnection, ByVal s As String)
        InitializeComponent()
        con = c
        sucursal = s
        Show()

    End Sub


    Private Sub radioListado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioListado.CheckedChanged
        operacion = "Listado"
        activarBotones()
    End Sub

    Private Sub radioAlta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioAlta.CheckedChanged
        operacion = "Alta"
        activarBotones()

    End Sub

    Private Sub radioBaja_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioBaja.CheckedChanged
        operacion = "Baja"
        activarBotones()
    End Sub

    Private Sub radioModificacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioModificacion.CheckedChanged
        operacion = "Modificacion"
        activarBotones()

    End Sub

    Private Sub btnCierraSesion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub activarBotones()
        btnAlmacenamiento.Enabled = True
        btnEstablecimiento.Enabled = True
        btnInventario.Enabled = True
        btnProducto.Enabled = True
        btnBotellas.Enabled = True
        btnTransporte.Enabled = True
        btnProcesos.Enabled = True
    End Sub



    Private Sub btnProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProducto.Click
        Select Case operacion
            Case "Alta"
                Dim altaProd As New FormAltaProducto(sucursal, con)
                altaProd.Show()
            Case "Baja"
                Dim bajaProd As New FormBajaProducto(con)
                bajaProd.Show()
            Case "Modificacion"
                Dim modProd As New FormModificacionProducto(sucursal, con)
                modProd.Show()
            Case "Listado"
                Dim conProd As New FormConsultaProductos(sucursal, con)
                conProd.Show()



        End Select
    End Sub

    Private Sub btnAlmacenamiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlmacenamiento.Click
        Select Case operacion
            Case "Alta"
                Dim altaAlmac As New FormAltaAlmacenamiento(sucursal, con)
                altaAlmac.Show()
            Case "Baja"
                Dim bajaAlmac As New FormBajaAlmacenamiento(con)
                bajaAlmac.Show()
            Case "Modificacion"
                Dim modAlmac As New FormModificacionAlmacenamiento(con)
                modAlmac.Show()
            Case "Listado"
                Dim conAlmac As New FormConsultaAlmacenamiento(sucursal, con)
                conAlmac.Show()
        End Select
    End Sub

    Private Sub btnInventario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInventario.Click
        Select Case operacion
            Case "Alta"
                Dim altaInv As New FormAltaInventario(con, sucursal)
                altaInv.Show()
            Case "Baja"
                Dim bajaInv As New FormBajaInventario(con, sucursal)
                bajaInv.Show()
            Case "Modificacion"
                Dim modInv As New FormModificacionInventario(con, sucursal)
                modInv.Show()
            Case "Listado"
                Dim conInv As New FormConsultaInventario(con, sucursal)
                conInv.Show()
        End Select
    End Sub

    Private Sub btnTransporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransporte.Click
        Select Case operacion
            Case "Alta"
                Dim altaTran As New FormAltaTransporte(con)
                altaTran.Show()
            Case "Baja"
                Dim bajaTran As New FormBajaTransporte(con)
                bajaTran.Show()
            Case "Modificacion"
                Dim modTran As New FormModificacionTransporte(con)
                modTran.Show()
            Case "Listado"
                Dim conTran As New FormConsultaTransporte(con)
                conTran.Show()

        End Select
    End Sub

    Private Sub btnEstablecimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstablecimiento.Click
        Select Case operacion
            Case "Alta"
                Dim altaEstab As New FormAltaEstablecimiento(con)
                altaEstab.Show()
            Case "Baja"
                Dim bajaEstab As New FormBajaEstablecimiento(con)
                bajaEstab.Show()
            Case "Modificacion"
                Dim modEstab As New FormModificacionEstablecimiento(con)
                modEstab.Show()
            Case "Listado"
                Dim conEstab As New FormConsultaEstablecimiento(con)
                conEstab.Show()
        End Select
    End Sub

    Private Sub btnBotellas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBotellas.Click
        Select Case operacion
            Case "Alta"
                Dim altaBotella As New FormAltaBotella(con)
                altaBotella.Show()
            Case "Baja"
                Dim bajaBotella As New FormBajaBotella(con)
                bajaBotella.Show()
            Case "Modificacion"
                Dim modBotella As New FormModificacionBotella(con)
                modBotella.Show()
            Case "Listado"
                Dim conBotella As New FormConsultaBotella(con)
                conBotella.Show()
        End Select
    End Sub

    Private Sub btnProcesos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProcesos.Click
        Select Case operacion
            Case "Alta"
                Dim altaProceso As New FormAltaProceso(con)
                altaProceso.Show()
            Case "Baja"
                Dim bajaProceso As New FormBajaProceso(con)
                bajaProceso.Show()
            Case "Modificacion"
                Dim modProceso As New FormModificacionProcesos(con)
                modProceso.Show()
            Case "Listado"
                Dim conProceso As New FormConsultaProceso(con)
                conProceso.Show()
        End Select
    End Sub

    Private Sub btnActividades_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim menAct As New FormAdministrativo(sucursal, con)
        menAct.Show()
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub cerra() Handles Me.FormClosed
        FormLogin.Visible = True
    End Sub

    Private Sub btnSucursal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSucursal.Click
        Select Case operacion
            Case "Alta"
                Dim alSuc As New FormAltaSucursal(con)
                alSuc.Show()
            Case "Baja"
                Dim baSuc As New FormBajaSucursal(con)
                baSuc.Show()
            Case "Modificacion"
                Dim moSuc As New FormModificacionSucursal(con)
                moSuc.Show()
            Case "Listado"
                Dim conSuc As New FormConsultaSucursal(con)
                conSuc.Show()
        End Select
    End Sub



    Private Sub btnPersonal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPersonal.Click
        Select Case operacion
            Case "Alta"
                Dim alPer As New FormAltaPersonal(con, sucursal)
                alPer.Show()
            Case "Baja"
                Dim baPer As New FormBajaPersonal(sucursal, con)
                baPer.Show()
            Case "Modificacion"
                Dim moPer As New FormModificacionPersonal(sucursal, con)
                moPer.Show()
            Case "Listado"
                Dim conPer As New FormConsultaPersonal(sucursal, con)
                conPer.Show()
        End Select
    End Sub
End Class