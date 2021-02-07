<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrativo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnProduccion = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBajRes = New System.Windows.Forms.Button()
        Me.btnModRes = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnMenosStock = New System.Windows.Forms.Button()
        Me.btnMasReservados = New System.Windows.Forms.Button()
        Me.btnListoParaTrasiego = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnProductoDisponible = New System.Windows.Forms.Button()
        Me.btnProcesosActivos = New System.Windows.Forms.Button()
        Me.btnContenedoresVacios = New System.Windows.Forms.Button()
        Me.btnObservaciones = New System.Windows.Forms.Button()
        Me.btnReservasValidas = New System.Windows.Forms.Button()
        Me.btnTransporteDisponible = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngreso
        '
        Me.btnIngreso.Location = New System.Drawing.Point(33, 19)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(133, 23)
        Me.btnIngreso.TabIndex = 0
        Me.btnIngreso.Text = "Ingreso de Producto"
        Me.btnIngreso.UseVisualStyleBackColor = True
        '
        'btnVehiculos
        '
        Me.btnVehiculos.Location = New System.Drawing.Point(33, 48)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(133, 23)
        Me.btnVehiculos.TabIndex = 6
        Me.btnVehiculos.Text = "Arribo de Vehículo"
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnProduccion
        '
        Me.btnProduccion.Location = New System.Drawing.Point(33, 77)
        Me.btnProduccion.Name = "btnProduccion"
        Me.btnProduccion.Size = New System.Drawing.Size(133, 23)
        Me.btnProduccion.TabIndex = 6
        Me.btnProduccion.Text = "Etapas de Producción"
        Me.btnProduccion.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnIngreso)
        Me.GroupBox1.Controls.Add(Me.btnVehiculos)
        Me.GroupBox1.Controls.Add(Me.btnBajRes)
        Me.GroupBox1.Controls.Add(Me.btnModRes)
        Me.GroupBox1.Controls.Add(Me.btnProduccion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 175)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Gestión de Producción"
        '
        'btnBajRes
        '
        Me.btnBajRes.Location = New System.Drawing.Point(33, 135)
        Me.btnBajRes.Name = "btnBajRes"
        Me.btnBajRes.Size = New System.Drawing.Size(133, 23)
        Me.btnBajRes.TabIndex = 6
        Me.btnBajRes.Text = "Baja de Reservas"
        Me.btnBajRes.UseVisualStyleBackColor = True
        '
        'btnModRes
        '
        Me.btnModRes.Location = New System.Drawing.Point(33, 106)
        Me.btnModRes.Name = "btnModRes"
        Me.btnModRes.Size = New System.Drawing.Size(133, 23)
        Me.btnModRes.TabIndex = 6
        Me.btnModRes.Text = "Modificar Reservas"
        Me.btnModRes.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMenosStock)
        Me.GroupBox2.Controls.Add(Me.btnMasReservados)
        Me.GroupBox2.Controls.Add(Me.btnListoParaTrasiego)
        Me.GroupBox2.Controls.Add(Me.btnInventario)
        Me.GroupBox2.Controls.Add(Me.btnProductoDisponible)
        Me.GroupBox2.Controls.Add(Me.btnProcesosActivos)
        Me.GroupBox2.Controls.Add(Me.btnContenedoresVacios)
        Me.GroupBox2.Controls.Add(Me.btnObservaciones)
        Me.GroupBox2.Controls.Add(Me.btnReservasValidas)
        Me.GroupBox2.Controls.Add(Me.btnTransporteDisponible)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(223, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(253, 326)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de la Producción"
        '
        'btnMenosStock
        '
        Me.btnMenosStock.Location = New System.Drawing.Point(223, 280)
        Me.btnMenosStock.Name = "btnMenosStock"
        Me.btnMenosStock.Size = New System.Drawing.Size(24, 23)
        Me.btnMenosStock.TabIndex = 0
        Me.btnMenosStock.UseVisualStyleBackColor = True
        '
        'btnMasReservados
        '
        Me.btnMasReservados.Location = New System.Drawing.Point(223, 251)
        Me.btnMasReservados.Name = "btnMasReservados"
        Me.btnMasReservados.Size = New System.Drawing.Size(24, 23)
        Me.btnMasReservados.TabIndex = 0
        Me.btnMasReservados.UseVisualStyleBackColor = True
        '
        'btnListoParaTrasiego
        '
        Me.btnListoParaTrasiego.Location = New System.Drawing.Point(223, 222)
        Me.btnListoParaTrasiego.Name = "btnListoParaTrasiego"
        Me.btnListoParaTrasiego.Size = New System.Drawing.Size(24, 23)
        Me.btnListoParaTrasiego.TabIndex = 0
        Me.btnListoParaTrasiego.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(223, 193)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(24, 23)
        Me.btnInventario.TabIndex = 0
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnProductoDisponible
        '
        Me.btnProductoDisponible.Location = New System.Drawing.Point(223, 164)
        Me.btnProductoDisponible.Name = "btnProductoDisponible"
        Me.btnProductoDisponible.Size = New System.Drawing.Size(24, 23)
        Me.btnProductoDisponible.TabIndex = 0
        Me.btnProductoDisponible.UseVisualStyleBackColor = True
        '
        'btnProcesosActivos
        '
        Me.btnProcesosActivos.Location = New System.Drawing.Point(223, 135)
        Me.btnProcesosActivos.Name = "btnProcesosActivos"
        Me.btnProcesosActivos.Size = New System.Drawing.Size(24, 23)
        Me.btnProcesosActivos.TabIndex = 0
        Me.btnProcesosActivos.UseVisualStyleBackColor = True
        '
        'btnContenedoresVacios
        '
        Me.btnContenedoresVacios.Location = New System.Drawing.Point(223, 106)
        Me.btnContenedoresVacios.Name = "btnContenedoresVacios"
        Me.btnContenedoresVacios.Size = New System.Drawing.Size(24, 23)
        Me.btnContenedoresVacios.TabIndex = 0
        Me.btnContenedoresVacios.UseVisualStyleBackColor = True
        '
        'btnObservaciones
        '
        Me.btnObservaciones.Location = New System.Drawing.Point(223, 77)
        Me.btnObservaciones.Name = "btnObservaciones"
        Me.btnObservaciones.Size = New System.Drawing.Size(24, 23)
        Me.btnObservaciones.TabIndex = 0
        Me.btnObservaciones.UseVisualStyleBackColor = True
        '
        'btnReservasValidas
        '
        Me.btnReservasValidas.Location = New System.Drawing.Point(223, 48)
        Me.btnReservasValidas.Name = "btnReservasValidas"
        Me.btnReservasValidas.Size = New System.Drawing.Size(24, 23)
        Me.btnReservasValidas.TabIndex = 0
        Me.btnReservasValidas.UseVisualStyleBackColor = True
        '
        'btnTransporteDisponible
        '
        Me.btnTransporteDisponible.Location = New System.Drawing.Point(223, 19)
        Me.btnTransporteDisponible.Name = "btnTransporteDisponible"
        Me.btnTransporteDisponible.Size = New System.Drawing.Size(24, 23)
        Me.btnTransporteDisponible.TabIndex = 0
        Me.btnTransporteDisponible.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 285)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(137, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Productos con menor stock"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Productos más reservados"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Productos a trasiegar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 198)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Inventario de la sucursal"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(159, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cantidad de producto disponible"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 140)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Procesos siendo realizados"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Contenedores disponibles"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Observaciones de los Procesos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Reservas válidas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Transporte disponible"
        '
        'FormAdministrativo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(496, 367)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(512, 406)
        Me.MinimumSize = New System.Drawing.Size(512, 406)
        Me.Name = "FormAdministrativo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Produccion"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents btnVehiculos As System.Windows.Forms.Button
    Friend WithEvents btnProduccion As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnMenosStock As System.Windows.Forms.Button
    Friend WithEvents btnMasReservados As System.Windows.Forms.Button
    Friend WithEvents btnListoParaTrasiego As System.Windows.Forms.Button
    Friend WithEvents btnInventario As System.Windows.Forms.Button
    Friend WithEvents btnProductoDisponible As System.Windows.Forms.Button
    Friend WithEvents btnProcesosActivos As System.Windows.Forms.Button
    Friend WithEvents btnContenedoresVacios As System.Windows.Forms.Button
    Friend WithEvents btnObservaciones As System.Windows.Forms.Button
    Friend WithEvents btnReservasValidas As System.Windows.Forms.Button
    Friend WithEvents btnTransporteDisponible As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnBajRes As System.Windows.Forms.Button
    Friend WithEvents btnModRes As System.Windows.Forms.Button
End Class
