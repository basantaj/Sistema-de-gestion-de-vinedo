<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaPersonal
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
        Me.grupoResultado = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grupoResultado.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoResultado
        '
        Me.grupoResultado.Controls.Add(Me.Label3)
        Me.grupoResultado.Controls.Add(Me.btnConfirmar)
        Me.grupoResultado.Controls.Add(Me.txtTelefono)
        Me.grupoResultado.Controls.Add(Me.txtCargo)
        Me.grupoResultado.Controls.Add(Me.txtApellido)
        Me.grupoResultado.Controls.Add(Me.Label5)
        Me.grupoResultado.Controls.Add(Me.Label4)
        Me.grupoResultado.Controls.Add(Me.Label2)
        Me.grupoResultado.Controls.Add(Me.txtNombre)
        Me.grupoResultado.Enabled = False
        Me.grupoResultado.Location = New System.Drawing.Point(133, 5)
        Me.grupoResultado.Name = "grupoResultado"
        Me.grupoResultado.Size = New System.Drawing.Size(263, 244)
        Me.grupoResultado.TabIndex = 26
        Me.grupoResultado.TabStop = False
        Me.grupoResultado.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(147, 95)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 23)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar Baja"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(22, 204)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 1
        Me.txtTelefono.TabStop = False
        '
        'txtCargo
        '
        Me.txtCargo.Location = New System.Drawing.Point(22, 151)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 1
        Me.txtCargo.TabStop = False
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(22, 98)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 1
        Me.txtApellido.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cargo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(22, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "ID de Empleado:"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(15, 25)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(100, 20)
        Me.txtCI.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(15, 116)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(15, 87)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(100, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(15, 58)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Busqueda"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FormBajaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(424, 261)
        Me.Controls.Add(Me.grupoResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCI)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.MaximumSize = New System.Drawing.Size(440, 300)
        Me.MinimumSize = New System.Drawing.Size(440, 300)
        Me.Name = "FormBajaPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Personal"
        Me.grupoResultado.ResumeLayout(False)
        Me.grupoResultado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoResultado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
