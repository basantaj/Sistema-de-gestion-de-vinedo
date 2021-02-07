<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaReservas
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
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtProducto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReserva = New System.Windows.Forms.TextBox()
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
        Me.grupoResultado.Controls.Add(Me.txtCant)
        Me.grupoResultado.Controls.Add(Me.txtFecha)
        Me.grupoResultado.Controls.Add(Me.txtProducto)
        Me.grupoResultado.Controls.Add(Me.Label4)
        Me.grupoResultado.Controls.Add(Me.Label5)
        Me.grupoResultado.Controls.Add(Me.Label2)
        Me.grupoResultado.Controls.Add(Me.txtCI)
        Me.grupoResultado.Enabled = False
        Me.grupoResultado.Location = New System.Drawing.Point(134, 7)
        Me.grupoResultado.Name = "grupoResultado"
        Me.grupoResultado.Size = New System.Drawing.Size(263, 249)
        Me.grupoResultado.TabIndex = 26
        Me.grupoResultado.TabStop = False
        Me.grupoResultado.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CI:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(143, 125)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 23)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar Baja"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(22, 202)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(100, 20)
        Me.txtCant.TabIndex = 1
        Me.txtCant.TabStop = False
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(22, 151)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(100, 20)
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.TabStop = False
        '
        'txtProducto
        '
        Me.txtProducto.Location = New System.Drawing.Point(22, 98)
        Me.txtProducto.Name = "txtProducto"
        Me.txtProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtProducto.TabIndex = 1
        Me.txtProducto.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad Reservada:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Fecha de Reserva:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Producto:"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(22, 45)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(100, 20)
        Me.txtCI.TabIndex = 1
        Me.txtCI.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Nº de Reserva:"
        '
        'txtReserva
        '
        Me.txtReserva.Location = New System.Drawing.Point(16, 68)
        Me.txtReserva.Name = "txtReserva"
        Me.txtReserva.Size = New System.Drawing.Size(100, 20)
        Me.txtReserva.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(16, 160)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(16, 131)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(100, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(16, 102)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Busqueda"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FormBajaReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(413, 260)
        Me.Controls.Add(Me.grupoResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReserva)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.MaximumSize = New System.Drawing.Size(429, 299)
        Me.MinimumSize = New System.Drawing.Size(429, 299)
        Me.Name = "FormBajaReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Reservas"
        Me.grupoResultado.ResumeLayout(False)
        Me.grupoResultado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoResultado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtProducto As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtReserva As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
