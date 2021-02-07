<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaPersonal
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.checkCargo = New System.Windows.Forms.CheckBox()
        Me.checkTelefono = New System.Windows.Forms.CheckBox()
        Me.checkApellido = New System.Windows.Forms.CheckBox()
        Me.checkNombre = New System.Windows.Forms.CheckBox()
        Me.checkID = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCargo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Seleccione los Filtros a Emplear"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(15, 151)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(536, 171)
        Me.dataGrid.TabIndex = 35
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(682, 63)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 6
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkCargo)
        Me.grupoDatos.Controls.Add(Me.checkTelefono)
        Me.grupoDatos.Controls.Add(Me.checkApellido)
        Me.grupoDatos.Controls.Add(Me.checkNombre)
        Me.grupoDatos.Controls.Add(Me.checkID)
        Me.grupoDatos.Controls.Add(Me.txtID)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label6)
        Me.grupoDatos.Controls.Add(Me.txtCargo)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.txtTelefono)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtApellido)
        Me.grupoDatos.Controls.Add(Me.txtNombre)
        Me.grupoDatos.Location = New System.Drawing.Point(15, 39)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(661, 94)
        Me.grupoDatos.TabIndex = 32
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Personal:"
        '
        'checkCargo
        '
        Me.checkCargo.AutoSize = True
        Me.checkCargo.Location = New System.Drawing.Point(496, 53)
        Me.checkCargo.Name = "checkCargo"
        Me.checkCargo.Size = New System.Drawing.Size(15, 14)
        Me.checkCargo.TabIndex = 2
        Me.checkCargo.TabStop = False
        Me.checkCargo.UseVisualStyleBackColor = True
        '
        'checkTelefono
        '
        Me.checkTelefono.AutoSize = True
        Me.checkTelefono.Location = New System.Drawing.Point(623, 53)
        Me.checkTelefono.Name = "checkTelefono"
        Me.checkTelefono.Size = New System.Drawing.Size(15, 14)
        Me.checkTelefono.TabIndex = 2
        Me.checkTelefono.TabStop = False
        Me.checkTelefono.UseVisualStyleBackColor = True
        '
        'checkApellido
        '
        Me.checkApellido.AutoSize = True
        Me.checkApellido.Location = New System.Drawing.Point(369, 53)
        Me.checkApellido.Name = "checkApellido"
        Me.checkApellido.Size = New System.Drawing.Size(15, 14)
        Me.checkApellido.TabIndex = 2
        Me.checkApellido.TabStop = False
        Me.checkApellido.UseVisualStyleBackColor = True
        '
        'checkNombre
        '
        Me.checkNombre.AutoSize = True
        Me.checkNombre.Location = New System.Drawing.Point(242, 53)
        Me.checkNombre.Name = "checkNombre"
        Me.checkNombre.Size = New System.Drawing.Size(15, 14)
        Me.checkNombre.TabIndex = 2
        Me.checkNombre.TabStop = False
        Me.checkNombre.UseVisualStyleBackColor = True
        '
        'checkID
        '
        Me.checkID.AutoSize = True
        Me.checkID.Location = New System.Drawing.Point(115, 53)
        Me.checkID.Name = "checkID"
        Me.checkID.Size = New System.Drawing.Size(15, 14)
        Me.checkID.TabIndex = 2
        Me.checkID.TabStop = False
        Me.checkID.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(9, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CI:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nombre:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cargo:"
        '
        'txtCargo
        '
        Me.txtCargo.Enabled = False
        Me.txtCargo.Location = New System.Drawing.Point(390, 50)
        Me.txtCargo.Name = "txtCargo"
        Me.txtCargo.Size = New System.Drawing.Size(100, 20)
        Me.txtCargo.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(514, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Telefono:"
        '
        'txtTelefono
        '
        Me.txtTelefono.Enabled = False
        Me.txtTelefono.Location = New System.Drawing.Point(517, 50)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(100, 20)
        Me.txtTelefono.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Apellido:"
        '
        'txtApellido
        '
        Me.txtApellido.Enabled = False
        Me.txtApellido.Location = New System.Drawing.Point(263, 50)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(100, 20)
        Me.txtApellido.TabIndex = 3
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Location = New System.Drawing.Point(136, 50)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 20)
        Me.txtNombre.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(682, 93)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormConsultaPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(796, 343)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.grupoDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.MaximumSize = New System.Drawing.Size(812, 382)
        Me.MinimumSize = New System.Drawing.Size(812, 382)
        Me.Name = "FormConsultaPersonal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Personal"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents checkCargo As System.Windows.Forms.CheckBox
    Friend WithEvents checkTelefono As System.Windows.Forms.CheckBox
    Friend WithEvents checkApellido As System.Windows.Forms.CheckBox
    Friend WithEvents checkNombre As System.Windows.Forms.CheckBox
    Friend WithEvents checkID As System.Windows.Forms.CheckBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCargo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
