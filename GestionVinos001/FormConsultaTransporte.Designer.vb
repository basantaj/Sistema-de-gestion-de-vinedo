<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaTransporte
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
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.checkEstablecimiento = New System.Windows.Forms.CheckBox()
        Me.checkCapacidad = New System.Windows.Forms.CheckBox()
        Me.checkMatricula = New System.Windows.Forms.CheckBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstablecimiento = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 145)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(516, 133)
        Me.dataGrid.TabIndex = 32
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Seleccione los Filtros a Emplear"
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(453, 62)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 4
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(453, 112)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkEstablecimiento)
        Me.grupoDatos.Controls.Add(Me.checkCapacidad)
        Me.grupoDatos.Controls.Add(Me.checkMatricula)
        Me.grupoDatos.Controls.Add(Me.txtMatricula)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtEstablecimiento)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 47)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(417, 92)
        Me.grupoDatos.TabIndex = 28
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Vehículo"
        '
        'checkEstablecimiento
        '
        Me.checkEstablecimiento.AutoSize = True
        Me.checkEstablecimiento.Location = New System.Drawing.Point(371, 53)
        Me.checkEstablecimiento.Name = "checkEstablecimiento"
        Me.checkEstablecimiento.Size = New System.Drawing.Size(15, 14)
        Me.checkEstablecimiento.TabIndex = 2
        Me.checkEstablecimiento.TabStop = False
        Me.checkEstablecimiento.UseVisualStyleBackColor = True
        '
        'checkCapacidad
        '
        Me.checkCapacidad.AutoSize = True
        Me.checkCapacidad.Location = New System.Drawing.Point(244, 53)
        Me.checkCapacidad.Name = "checkCapacidad"
        Me.checkCapacidad.Size = New System.Drawing.Size(15, 14)
        Me.checkCapacidad.TabIndex = 2
        Me.checkCapacidad.TabStop = False
        Me.checkCapacidad.UseVisualStyleBackColor = True
        '
        'checkMatricula
        '
        Me.checkMatricula.AutoSize = True
        Me.checkMatricula.Location = New System.Drawing.Point(117, 53)
        Me.checkMatricula.Name = "checkMatricula"
        Me.checkMatricula.Size = New System.Drawing.Size(15, 14)
        Me.checkMatricula.TabIndex = 2
        Me.checkMatricula.TabStop = False
        Me.checkMatricula.UseVisualStyleBackColor = True
        '
        'txtMatricula
        '
        Me.txtMatricula.Enabled = False
        Me.txtMatricula.Location = New System.Drawing.Point(11, 50)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(100, 20)
        Me.txtMatricula.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Matrícula:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Capacidad:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Establecimiento:"
        '
        'txtEstablecimiento
        '
        Me.txtEstablecimiento.Enabled = False
        Me.txtEstablecimiento.Location = New System.Drawing.Point(265, 50)
        Me.txtEstablecimiento.Name = "txtEstablecimiento"
        Me.txtEstablecimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtEstablecimiento.TabIndex = 3
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Enabled = False
        Me.txtCapacidad.Location = New System.Drawing.Point(138, 50)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 2
        '
        'FormConsultaTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(545, 310)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(561, 349)
        Me.MinimumSize = New System.Drawing.Size(561, 349)
        Me.Name = "FormConsultaTransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Transportes"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents checkEstablecimiento As System.Windows.Forms.CheckBox
    Friend WithEvents checkCapacidad As System.Windows.Forms.CheckBox
    Friend WithEvents checkMatricula As System.Windows.Forms.CheckBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
End Class
