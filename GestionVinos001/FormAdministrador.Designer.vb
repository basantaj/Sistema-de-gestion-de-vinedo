<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdministrador
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
        Me.radioAlta = New System.Windows.Forms.RadioButton()
        Me.radioBaja = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.radioListado = New System.Windows.Forms.RadioButton()
        Me.radioModificacion = New System.Windows.Forms.RadioButton()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnAlmacenamiento = New System.Windows.Forms.Button()
        Me.btnInventario = New System.Windows.Forms.Button()
        Me.btnTransporte = New System.Windows.Forms.Button()
        Me.btnEstablecimiento = New System.Windows.Forms.Button()
        Me.btnBotellas = New System.Windows.Forms.Button()
        Me.btnProcesos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnSucursal = New System.Windows.Forms.Button()
        Me.btnPersonal = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenido."
        '
        'radioAlta
        '
        Me.radioAlta.AutoSize = True
        Me.radioAlta.Location = New System.Drawing.Point(107, 3)
        Me.radioAlta.Name = "radioAlta"
        Me.radioAlta.Size = New System.Drawing.Size(43, 17)
        Me.radioAlta.TabIndex = 1
        Me.radioAlta.TabStop = True
        Me.radioAlta.Text = "&Alta"
        Me.radioAlta.UseVisualStyleBackColor = True
        '
        'radioBaja
        '
        Me.radioBaja.AutoSize = True
        Me.radioBaja.Location = New System.Drawing.Point(156, 3)
        Me.radioBaja.Name = "radioBaja"
        Me.radioBaja.Size = New System.Drawing.Size(46, 17)
        Me.radioBaja.TabIndex = 1
        Me.radioBaja.TabStop = True
        Me.radioBaja.Text = "&Baja"
        Me.radioBaja.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.radioListado)
        Me.Panel1.Controls.Add(Me.radioModificacion)
        Me.Panel1.Controls.Add(Me.radioBaja)
        Me.Panel1.Controls.Add(Me.radioAlta)
        Me.Panel1.Location = New System.Drawing.Point(44, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 26)
        Me.Panel1.TabIndex = 2
        '
        'radioListado
        '
        Me.radioListado.AutoSize = True
        Me.radioListado.Location = New System.Drawing.Point(35, 3)
        Me.radioListado.Name = "radioListado"
        Me.radioListado.Size = New System.Drawing.Size(66, 17)
        Me.radioListado.TabIndex = 1
        Me.radioListado.TabStop = True
        Me.radioListado.Text = "&Consulta"
        Me.radioListado.UseVisualStyleBackColor = True
        '
        'radioModificacion
        '
        Me.radioModificacion.AutoSize = True
        Me.radioModificacion.Location = New System.Drawing.Point(208, 3)
        Me.radioModificacion.Name = "radioModificacion"
        Me.radioModificacion.Size = New System.Drawing.Size(85, 17)
        Me.radioModificacion.TabIndex = 1
        Me.radioModificacion.TabStop = True
        Me.radioModificacion.Text = "&Modificacion"
        Me.radioModificacion.UseVisualStyleBackColor = True
        '
        'btnProducto
        '
        Me.btnProducto.Location = New System.Drawing.Point(44, 115)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(102, 23)
        Me.btnProducto.TabIndex = 1
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnAlmacenamiento
        '
        Me.btnAlmacenamiento.Location = New System.Drawing.Point(152, 115)
        Me.btnAlmacenamiento.Name = "btnAlmacenamiento"
        Me.btnAlmacenamiento.Size = New System.Drawing.Size(102, 23)
        Me.btnAlmacenamiento.TabIndex = 2
        Me.btnAlmacenamiento.Text = "Almacenamiento"
        Me.btnAlmacenamiento.UseVisualStyleBackColor = True
        '
        'btnInventario
        '
        Me.btnInventario.Location = New System.Drawing.Point(260, 115)
        Me.btnInventario.Name = "btnInventario"
        Me.btnInventario.Size = New System.Drawing.Size(102, 23)
        Me.btnInventario.TabIndex = 3
        Me.btnInventario.Text = "Inventario"
        Me.btnInventario.UseVisualStyleBackColor = True
        '
        'btnTransporte
        '
        Me.btnTransporte.Location = New System.Drawing.Point(44, 144)
        Me.btnTransporte.Name = "btnTransporte"
        Me.btnTransporte.Size = New System.Drawing.Size(102, 23)
        Me.btnTransporte.TabIndex = 4
        Me.btnTransporte.Text = "Transporte"
        Me.btnTransporte.UseVisualStyleBackColor = True
        '
        'btnEstablecimiento
        '
        Me.btnEstablecimiento.Location = New System.Drawing.Point(152, 144)
        Me.btnEstablecimiento.Name = "btnEstablecimiento"
        Me.btnEstablecimiento.Size = New System.Drawing.Size(102, 23)
        Me.btnEstablecimiento.TabIndex = 5
        Me.btnEstablecimiento.Text = "Establecimiento"
        Me.btnEstablecimiento.UseVisualStyleBackColor = True
        '
        'btnBotellas
        '
        Me.btnBotellas.Location = New System.Drawing.Point(260, 144)
        Me.btnBotellas.Name = "btnBotellas"
        Me.btnBotellas.Size = New System.Drawing.Size(102, 23)
        Me.btnBotellas.TabIndex = 6
        Me.btnBotellas.Text = "Producto final"
        Me.btnBotellas.UseVisualStyleBackColor = True
        '
        'btnProcesos
        '
        Me.btnProcesos.Location = New System.Drawing.Point(44, 173)
        Me.btnProcesos.Name = "btnProcesos"
        Me.btnProcesos.Size = New System.Drawing.Size(102, 23)
        Me.btnProcesos.TabIndex = 7
        Me.btnProcesos.Text = "Procesos"
        Me.btnProcesos.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(290, 12)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        Me.btnCancelar.Visible = False
        '
        'btnSucursal
        '
        Me.btnSucursal.Location = New System.Drawing.Point(152, 175)
        Me.btnSucursal.Name = "btnSucursal"
        Me.btnSucursal.Size = New System.Drawing.Size(102, 23)
        Me.btnSucursal.TabIndex = 8
        Me.btnSucursal.Text = "Sucursal"
        Me.btnSucursal.UseVisualStyleBackColor = True
        '
        'btnPersonal
        '
        Me.btnPersonal.Location = New System.Drawing.Point(260, 173)
        Me.btnPersonal.Name = "btnPersonal"
        Me.btnPersonal.Size = New System.Drawing.Size(102, 23)
        Me.btnPersonal.TabIndex = 9
        Me.btnPersonal.Text = "Personal"
        Me.btnPersonal.UseVisualStyleBackColor = True
        '
        'FormAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(411, 239)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnProcesos)
        Me.Controls.Add(Me.btnPersonal)
        Me.Controls.Add(Me.btnSucursal)
        Me.Controls.Add(Me.btnBotellas)
        Me.Controls.Add(Me.btnEstablecimiento)
        Me.Controls.Add(Me.btnTransporte)
        Me.Controls.Add(Me.btnInventario)
        Me.Controls.Add(Me.btnAlmacenamiento)
        Me.Controls.Add(Me.btnProducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.MaximumSize = New System.Drawing.Size(427, 278)
        Me.MinimumSize = New System.Drawing.Size(427, 278)
        Me.Name = "FormAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radioAlta As System.Windows.Forms.RadioButton
    Friend WithEvents radioBaja As System.Windows.Forms.RadioButton
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents radioListado As System.Windows.Forms.RadioButton
    Friend WithEvents btnProducto As System.Windows.Forms.Button
    Friend WithEvents radioModificacion As System.Windows.Forms.RadioButton
    Friend WithEvents btnAlmacenamiento As System.Windows.Forms.Button
    Friend WithEvents btnInventario As System.Windows.Forms.Button
    Friend WithEvents btnTransporte As System.Windows.Forms.Button
    Friend WithEvents btnEstablecimiento As System.Windows.Forms.Button
    Friend WithEvents btnBotellas As System.Windows.Forms.Button
    Friend WithEvents btnProcesos As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnSucursal As System.Windows.Forms.Button
    Friend WithEvents btnPersonal As System.Windows.Forms.Button
End Class
