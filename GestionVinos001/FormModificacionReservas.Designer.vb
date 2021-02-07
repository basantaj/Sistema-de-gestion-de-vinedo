<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormModificacionReservas
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.numUnidades = New System.Windows.Forms.NumericUpDown()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtReserva = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.Enabled = False
        Me.btnModificar.Location = New System.Drawing.Point(158, 37)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(95, 23)
        Me.btnModificar.TabIndex = 5
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(158, 87)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'numUnidades
        '
        Me.numUnidades.Enabled = False
        Me.numUnidades.Location = New System.Drawing.Point(12, 79)
        Me.numUnidades.Name = "numUnidades"
        Me.numUnidades.Size = New System.Drawing.Size(121, 20)
        Me.numUnidades.TabIndex = 4
        '
        'comboProducto
        '
        Me.comboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProducto.Enabled = False
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Items.AddRange(New Object() {"Producto"})
        Me.comboProducto.Location = New System.Drawing.Point(12, 39)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(121, 21)
        Me.comboProducto.TabIndex = 3
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.Label8)
        Me.grupoDatos.Controls.Add(Me.Label6)
        Me.grupoDatos.Controls.Add(Me.numUnidades)
        Me.grupoDatos.Controls.Add(Me.comboProducto)
        Me.grupoDatos.Controls.Add(Me.btnModificar)
        Me.grupoDatos.Controls.Add(Me.btnCancelar)
        Me.grupoDatos.Location = New System.Drawing.Point(3, 65)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(270, 152)
        Me.grupoDatos.TabIndex = 14
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos de la Reserva"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Producto:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cantidad:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 25)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Nº de Reserva:"
        '
        'txtReserva
        '
        Me.txtReserva.Location = New System.Drawing.Point(98, 22)
        Me.txtReserva.Name = "txtReserva"
        Me.txtReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtReserva.TabIndex = 1
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(216, 20)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(308, 20)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 7
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'FormModificacionReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(396, 223)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtReserva)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(412, 262)
        Me.MinimumSize = New System.Drawing.Size(412, 262)
        Me.Name = "FormModificacionReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar Reservas"
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents numUnidades As System.Windows.Forms.NumericUpDown
    Friend WithEvents comboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtReserva As System.Windows.Forms.TextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
