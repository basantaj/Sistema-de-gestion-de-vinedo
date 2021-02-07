<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaClientes
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
        Me.checkTelefono = New System.Windows.Forms.CheckBox()
        Me.checkDireccion = New System.Windows.Forms.CheckBox()
        Me.checkApellido = New System.Windows.Forms.CheckBox()
        Me.checkNombre = New System.Windows.Forms.CheckBox()
        Me.checkCI = New System.Windows.Forms.CheckBox()
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkTelefono)
        Me.grupoDatos.Controls.Add(Me.checkDireccion)
        Me.grupoDatos.Controls.Add(Me.checkApellido)
        Me.grupoDatos.Controls.Add(Me.checkNombre)
        Me.grupoDatos.Controls.Add(Me.checkCI)
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
        Me.grupoDatos.Location = New System.Drawing.Point(12, 41)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(646, 118)
        Me.grupoDatos.TabIndex = 7
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos Personales"
        '
        'checkTelefono
        '
        Me.checkTelefono.AutoSize = True
        Me.checkTelefono.Location = New System.Drawing.Point(625, 56)
        Me.checkTelefono.Name = "checkTelefono"
        Me.checkTelefono.Size = New System.Drawing.Size(15, 14)
        Me.checkTelefono.TabIndex = 34
        Me.checkTelefono.TabStop = False
        Me.checkTelefono.UseVisualStyleBackColor = True
        '
        'checkDireccion
        '
        Me.checkDireccion.AutoSize = True
        Me.checkDireccion.Location = New System.Drawing.Point(498, 56)
        Me.checkDireccion.Name = "checkDireccion"
        Me.checkDireccion.Size = New System.Drawing.Size(15, 14)
        Me.checkDireccion.TabIndex = 34
        Me.checkDireccion.TabStop = False
        Me.checkDireccion.UseVisualStyleBackColor = True
        '
        'checkApellido
        '
        Me.checkApellido.AutoSize = True
        Me.checkApellido.Location = New System.Drawing.Point(371, 56)
        Me.checkApellido.Name = "checkApellido"
        Me.checkApellido.Size = New System.Drawing.Size(15, 14)
        Me.checkApellido.TabIndex = 34
        Me.checkApellido.TabStop = False
        Me.checkApellido.UseVisualStyleBackColor = True
        '
        'checkNombre
        '
        Me.checkNombre.AutoSize = True
        Me.checkNombre.Location = New System.Drawing.Point(244, 56)
        Me.checkNombre.Name = "checkNombre"
        Me.checkNombre.Size = New System.Drawing.Size(15, 14)
        Me.checkNombre.TabIndex = 34
        Me.checkNombre.TabStop = False
        Me.checkNombre.UseVisualStyleBackColor = True
        '
        'checkCI
        '
        Me.checkCI.AutoSize = True
        Me.checkCI.Location = New System.Drawing.Point(117, 53)
        Me.checkCI.Name = "checkCI"
        Me.checkCI.Size = New System.Drawing.Size(15, 14)
        Me.checkCI.TabIndex = 34
        Me.checkCI.TabStop = False
        Me.checkCI.UseVisualStyleBackColor = True
        '
        'txtCI
        '
        Me.txtCI.Enabled = False
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
        Me.Label5.Location = New System.Drawing.Point(262, 37)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Apellido:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(516, 37)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Teléfono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(519, 53)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(389, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Dirección:"
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(265, 53)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtDireccion
        '
        Me.txtDireccion.Enabled = False
        Me.txtDireccion.Location = New System.Drawing.Point(392, 53)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(100, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(138, 53)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(209, 17)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Seleccione los Filtros a Emplear"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(673, 118)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(673, 75)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 165)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(646, 203)
        Me.dataGrid.TabIndex = 37
        '
        'FormConsultaClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(757, 380)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grupoDatos)
        Me.Location = New System.Drawing.Point(773, 419)
        Me.MinimumSize = New System.Drawing.Size(773, 419)
        Me.Name = "FormConsultaClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Clientes"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents checkTelefono As System.Windows.Forms.CheckBox
    Friend WithEvents checkDireccion As System.Windows.Forms.CheckBox
    Friend WithEvents checkApellido As System.Windows.Forms.CheckBox
    Friend WithEvents checkNombre As System.Windows.Forms.CheckBox
    Friend WithEvents checkCI As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
End Class
