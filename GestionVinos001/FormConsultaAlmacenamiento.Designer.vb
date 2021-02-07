<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaAlmacenamiento
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
        Me.btnListado = New System.Windows.Forms.Button()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.checkCapacidad = New System.Windows.Forms.CheckBox()
        Me.checkMaterial = New System.Windows.Forms.CheckBox()
        Me.checkTipo = New System.Windows.Forms.CheckBox()
        Me.checkID = New System.Windows.Forms.CheckBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(566, 70)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkCapacidad)
        Me.grupoDatos.Controls.Add(Me.checkMaterial)
        Me.grupoDatos.Controls.Add(Me.checkTipo)
        Me.grupoDatos.Controls.Add(Me.checkID)
        Me.grupoDatos.Controls.Add(Me.txtID)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.txtMaterial)
        Me.grupoDatos.Controls.Add(Me.txtTipo)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 46)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(533, 109)
        Me.grupoDatos.TabIndex = 19
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Contenedor"
        '
        'checkCapacidad
        '
        Me.checkCapacidad.AutoSize = True
        Me.checkCapacidad.Location = New System.Drawing.Point(498, 53)
        Me.checkCapacidad.Name = "checkCapacidad"
        Me.checkCapacidad.Size = New System.Drawing.Size(15, 14)
        Me.checkCapacidad.TabIndex = 2
        Me.checkCapacidad.TabStop = False
        Me.checkCapacidad.UseVisualStyleBackColor = True
        '
        'checkMaterial
        '
        Me.checkMaterial.AutoSize = True
        Me.checkMaterial.Location = New System.Drawing.Point(371, 53)
        Me.checkMaterial.Name = "checkMaterial"
        Me.checkMaterial.Size = New System.Drawing.Size(15, 14)
        Me.checkMaterial.TabIndex = 2
        Me.checkMaterial.TabStop = False
        Me.checkMaterial.UseVisualStyleBackColor = True
        '
        'checkTipo
        '
        Me.checkTipo.AutoSize = True
        Me.checkTipo.Location = New System.Drawing.Point(244, 53)
        Me.checkTipo.Name = "checkTipo"
        Me.checkTipo.Size = New System.Drawing.Size(15, 14)
        Me.checkTipo.TabIndex = 2
        Me.checkTipo.TabStop = False
        Me.checkTipo.UseVisualStyleBackColor = True
        '
        'checkID
        '
        Me.checkID.AutoSize = True
        Me.checkID.Location = New System.Drawing.Point(117, 53)
        Me.checkID.Name = "checkID"
        Me.checkID.Size = New System.Drawing.Size(15, 14)
        Me.checkID.TabIndex = 2
        Me.checkID.TabStop = False
        Me.checkID.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(11, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Material:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Enabled = False
        Me.txtCapacidad.Location = New System.Drawing.Point(392, 50)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(389, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Capacidad:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Enabled = False
        Me.txtMaterial.Location = New System.Drawing.Point(265, 50)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterial.TabIndex = 3
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(138, 50)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(566, 99)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Seleccione los Filtros a Emplear"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 171)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(533, 187)
        Me.dataGrid.TabIndex = 23
        '
        'FormConsultaAlmacenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(653, 366)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(669, 405)
        Me.MinimumSize = New System.Drawing.Size(669, 405)
        Me.Name = "FormConsultaAlmacenamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Contenedores"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents checkCapacidad As System.Windows.Forms.CheckBox
    Friend WithEvents checkMaterial As System.Windows.Forms.CheckBox
    Friend WithEvents checkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents checkID As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
End Class
