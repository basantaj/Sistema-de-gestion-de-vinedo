<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaBotella
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
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.checkCapacidad = New System.Windows.Forms.CheckBox()
        Me.checkContenido = New System.Windows.Forms.CheckBox()
        Me.checkCodigo = New System.Windows.Forms.CheckBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.imagen = New System.Windows.Forms.PictureBox()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Seleccione los Filtros a Emplear"
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkCapacidad)
        Me.grupoDatos.Controls.Add(Me.checkContenido)
        Me.grupoDatos.Controls.Add(Me.checkCodigo)
        Me.grupoDatos.Controls.Add(Me.txtCodigo)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Controls.Add(Me.txtContenido)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 58)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(411, 106)
        Me.grupoDatos.TabIndex = 32
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Producto"
        '
        'checkCapacidad
        '
        Me.checkCapacidad.AutoSize = True
        Me.checkCapacidad.Location = New System.Drawing.Point(369, 53)
        Me.checkCapacidad.Name = "checkCapacidad"
        Me.checkCapacidad.Size = New System.Drawing.Size(15, 14)
        Me.checkCapacidad.TabIndex = 2
        Me.checkCapacidad.TabStop = False
        Me.checkCapacidad.UseVisualStyleBackColor = True
        '
        'checkContenido
        '
        Me.checkContenido.AutoSize = True
        Me.checkContenido.Location = New System.Drawing.Point(242, 53)
        Me.checkContenido.Name = "checkContenido"
        Me.checkContenido.Size = New System.Drawing.Size(15, 14)
        Me.checkContenido.TabIndex = 2
        Me.checkContenido.TabStop = False
        Me.checkContenido.UseVisualStyleBackColor = True
        '
        'checkCodigo
        '
        Me.checkCodigo.AutoSize = True
        Me.checkCodigo.Location = New System.Drawing.Point(115, 53)
        Me.checkCodigo.Name = "checkCodigo"
        Me.checkCodigo.Size = New System.Drawing.Size(15, 14)
        Me.checkCodigo.TabIndex = 2
        Me.checkCodigo.TabStop = False
        Me.checkCodigo.UseVisualStyleBackColor = True
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(9, 50)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de botella:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Contenido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(260, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Capacidad:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Enabled = False
        Me.txtCapacidad.Location = New System.Drawing.Point(263, 50)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 3
        '
        'txtContenido
        '
        Me.txtContenido.Enabled = False
        Me.txtContenido.Location = New System.Drawing.Point(136, 50)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(100, 20)
        Me.txtContenido.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(488, 117)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(488, 87)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 4
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 170)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(411, 173)
        Me.dataGrid.TabIndex = 35
        '
        'imagen
        '
        Me.imagen.Location = New System.Drawing.Point(429, 170)
        Me.imagen.Name = "imagen"
        Me.imagen.Size = New System.Drawing.Size(192, 173)
        Me.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagen.TabIndex = 37
        Me.imagen.TabStop = False
        '
        'FormConsultaBotella
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(633, 362)
        Me.Controls.Add(Me.imagen)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.grupoDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Name = "FormConsultaBotella"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Productos Finales"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents checkCapacidad As System.Windows.Forms.CheckBox
    Friend WithEvents checkContenido As System.Windows.Forms.CheckBox
    Friend WithEvents checkCodigo As System.Windows.Forms.CheckBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents imagen As System.Windows.Forms.PictureBox
End Class
