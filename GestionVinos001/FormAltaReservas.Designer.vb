<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaReservas
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
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.txtCI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.numUnidades = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grupoImagen = New System.Windows.Forms.GroupBox()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiarCarro = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnListadoClientes = New System.Windows.Forms.Button()
        Me.btnListadoReservas = New System.Windows.Forms.Button()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoImagen.SuspendLayout()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.txtCI)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label5)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.txtTelefono)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtApellido)
        Me.grupoDatos.Controls.Add(Me.txtDireccion)
        Me.grupoDatos.Controls.Add(Me.txtNombre)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 12)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(136, 239)
        Me.grupoDatos.TabIndex = 6
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos Personales"
        '
        'txtCI
        '
        Me.txtCI.Location = New System.Drawing.Point(11, 50)
        Me.txtCI.Name = "txtCI"
        Me.txtCI.Size = New System.Drawing.Size(100, 20)
        Me.txtCI.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CI:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 190)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Location = New System.Drawing.Point(11, 206)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dirección:"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(11, 128)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(11, 167)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(11, 89)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'comboProducto
        '
        Me.comboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(161, 12)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(121, 21)
        Me.comboProducto.TabIndex = 7
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4})
        Me.dataGrid.Location = New System.Drawing.Point(4, 19)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.RowHeadersVisible = False
        Me.dataGrid.Size = New System.Drawing.Size(319, 192)
        Me.dataGrid.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.HeaderText = "CI"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dataGrid)
        Me.GroupBox1.Location = New System.Drawing.Point(155, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(330, 217)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Carro"
        '
        'numUnidades
        '
        Me.numUnidades.Location = New System.Drawing.Point(327, 13)
        Me.numUnidades.Name = "numUnidades"
        Me.numUnidades.Size = New System.Drawing.Size(71, 20)
        Me.numUnidades.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(309, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(12, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "x"
        '
        'grupoImagen
        '
        Me.grupoImagen.Controls.Add(Me.imagen)
        Me.grupoImagen.Location = New System.Drawing.Point(491, 34)
        Me.grupoImagen.Name = "grupoImagen"
        Me.grupoImagen.Size = New System.Drawing.Size(213, 217)
        Me.grupoImagen.TabIndex = 12
        Me.grupoImagen.TabStop = False
        Me.grupoImagen.Text = "Vista Previa"
        '
        'imagen
        '
        Me.imagen.Location = New System.Drawing.Point(6, 19)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(201, 185)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen.TabIndex = 0
        Me.imagen.TabStop = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(190, 266)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(95, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCarro
        '
        Me.btnLimpiarCarro.Location = New System.Drawing.Point(291, 266)
        Me.btnLimpiarCarro.Name = "btnLimpiarCarro"
        Me.btnLimpiarCarro.Size = New System.Drawing.Size(95, 23)
        Me.btnLimpiarCarro.TabIndex = 13
        Me.btnLimpiarCarro.Text = "Limpiar Carro"
        Me.btnLimpiarCarro.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(392, 266)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(95, 23)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(404, 10)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(74, 23)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnListadoClientes
        '
        Me.btnListadoClientes.Location = New System.Drawing.Point(20, 253)
        Me.btnListadoClientes.Name = "btnListadoClientes"
        Me.btnListadoClientes.Size = New System.Drawing.Size(114, 23)
        Me.btnListadoClientes.TabIndex = 13
        Me.btnListadoClientes.Text = "Listado de Clientes"
        Me.btnListadoClientes.UseVisualStyleBackColor = True
        '
        'btnListadoReservas
        '
        Me.btnListadoReservas.Location = New System.Drawing.Point(20, 277)
        Me.btnListadoReservas.Name = "btnListadoReservas"
        Me.btnListadoReservas.Size = New System.Drawing.Size(114, 23)
        Me.btnListadoReservas.TabIndex = 13
        Me.btnListadoReservas.Text = "Listado de Reservas"
        Me.btnListadoReservas.UseVisualStyleBackColor = True
        '
        'FormAltaReservas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(733, 301)
        Me.Controls.Add(Me.btnListadoReservas)
        Me.Controls.Add(Me.btnListadoClientes)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnLimpiarCarro)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoImagen)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.numUnidades)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.comboProducto)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(990, 340)
        Me.Name = "FormAltaReservas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingresar Reserva"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.numUnidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoImagen.ResumeLayout(False)
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCI As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents comboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents numUnidades As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents grupoImagen As System.Windows.Forms.GroupBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnLimpiarCarro As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnListadoClientes As System.Windows.Forms.Button
    Friend WithEvents btnListadoReservas As System.Windows.Forms.Button
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
End Class
