<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormGerenteGeneral
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.btnInformes = New System.Windows.Forms.Button()
        Me.btnGestión = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnProduccionTotal = New System.Windows.Forms.Button()
        Me.btnProduccionSucursalActual = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCerrarSesion = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(221, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(176, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Se está actuando sobre la sucursal:"
        '
        'txtSucursal
        '
        Me.txtSucursal.Location = New System.Drawing.Point(403, 6)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(35, 20)
        Me.txtSucursal.TabIndex = 1
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(444, 4)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(65, 23)
        Me.btnSucursal.TabIndex = 2
        Me.btnSucursal.Text = "Cambiar"
        Me.btnSucursal.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnPersonal)
        Me.GroupBox1.Controls.Add(Me.btnInformes)
        Me.GroupBox1.Controls.Add(Me.btnGestión)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnProduccionTotal)
        Me.GroupBox1.Controls.Add(Me.btnProduccionSucursalActual)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(384, 191)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informes"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Monitoreo de Producción."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(5, 142)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(147, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Abrir Panel de Administración."
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(341, 79)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(23, 23)
        Me.btnPersonal.TabIndex = 3
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'btnInformes
        '
        Me.btnInformes.Location = New System.Drawing.Point(341, 108)
        Me.btnInformes.Name = "btnInformes"
        Me.btnInformes.Size = New System.Drawing.Size(23, 23)
        Me.btnInformes.TabIndex = 4
        Me.btnInformes.UseVisualStyleBackColor = True
        '
        'btnGestión
        '
        Me.btnGestión.Location = New System.Drawing.Point(341, 137)
        Me.btnGestión.Name = "btnGestión"
        Me.btnGestión.Size = New System.Drawing.Size(23, 23)
        Me.btnGestión.TabIndex = 5
        Me.btnGestión.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nómina de personal."
        '
        'btnProduccionTotal
        '
        Me.btnProduccionTotal.Location = New System.Drawing.Point(341, 50)
        Me.btnProduccionTotal.Name = "btnProduccionTotal"
        Me.btnProduccionTotal.Size = New System.Drawing.Size(23, 23)
        Me.btnProduccionTotal.TabIndex = 2
        Me.btnProduccionTotal.UseVisualStyleBackColor = True
        '
        'btnProduccionSucursalActual
        '
        Me.btnProduccionSucursalActual.Location = New System.Drawing.Point(341, 21)
        Me.btnProduccionSucursalActual.Name = "btnProduccionSucursalActual"
        Me.btnProduccionSucursalActual.Size = New System.Drawing.Size(23, 23)
        Me.btnProduccionSucursalActual.TabIndex = 1
        Me.btnProduccionSucursalActual.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(186, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Historial de producción de la sucursal."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Historial de producción total."
        '
        'btnCerrarSesion
        '
        Me.btnCerrarSesion.Location = New System.Drawing.Point(412, 62)
        Me.btnCerrarSesion.Name = "btnCerrarSesion"
        Me.btnCerrarSesion.Size = New System.Drawing.Size(97, 23)
        Me.btnCerrarSesion.TabIndex = 5
        Me.btnCerrarSesion.Text = "Cerrar Sesión"
        Me.btnCerrarSesion.UseVisualStyleBackColor = True
        '
        'FormGerenteGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(535, 250)
        Me.Controls.Add(Me.btnCerrarSesion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSucursal)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(551, 289)
        Me.MinimumSize = New System.Drawing.Size(551, 289)
        Me.Name = "FormGerenteGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de Gerente General"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents btnSucursal As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnProduccionTotal As System.Windows.Forms.Button
    Friend WithEvents btnProduccionSucursalActual As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnPersonal As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnGestión As System.Windows.Forms.Button
    Friend WithEvents btnCerrarSesion As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnInformes As System.Windows.Forms.Button
End Class
