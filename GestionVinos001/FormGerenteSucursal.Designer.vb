<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGerenteSucursal
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnIngresarPersonal = New System.Windows.Forms.Button()
        Me.btnProduccionSucursalActual = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.btnInformes)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnPersonal)
        Me.GroupBox1.Controls.Add(Me.btnIngresarPersonal)
        Me.GroupBox1.Controls.Add(Me.btnProduccionSucursalActual)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 175)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Monitoreo de Producción."
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(341, 73)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(23, 23)
        Me.btnInformes.TabIndex = 3
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ingresar Personal"
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(341, 44)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(23, 23)
        Me.btnPersonal.TabIndex = 2
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnIngresarPersonal
        '
        Me.btnIngresarPersonal.Location = New System.Drawing.Point(341, 102)
        Me.btnIngresarPersonal.Name = "btnIngresarPersonal"
        Me.btnIngresarPersonal.Size = New System.Drawing.Size(23, 23)
        Me.btnIngresarPersonal.TabIndex = 5
        Me.btnIngresarPersonal.UseVisualStyleBackColor = True
        '
        'btnProduccionSucursalActual
        '
        Me.btnProduccionSucursalActual.Location = New System.Drawing.Point(341, 15)
        Me.btnProduccionSucursalActual.Name = "btnProduccionSucursalActual"
        Me.btnProduccionSucursalActual.Size = New System.Drawing.Size(23, 23)
        Me.btnProduccionSucursalActual.TabIndex = 1
        Me.btnProduccionSucursalActual.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(7, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Nómina de personal."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Historial de producción de esta sucursal."
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(398, 28)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(97, 23)
        Me.btnCerrarSesion.TabIndex = 4
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'FormGerenteSucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(504, 211)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.MaximumSize = New System.Drawing.Size(520, 250)
        Me.MinimumSize = New System.Drawing.Size(520, 250)
        Me.Name = "FormGerenteSucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Gerente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnProduccionSucursalActual As System.Windows.Forms.Button
    Friend WithEvents btnPersonal As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnIngresarPersonal As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnInformes As System.Windows.Forms.Button
End Class
