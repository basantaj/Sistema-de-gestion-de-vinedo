<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaProceso
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
        Me.checkTipoProceso = New System.Windows.Forms.CheckBox()
        Me.checkID = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.checkProducto = New System.Windows.Forms.CheckBox()
        Me.txtTipoProducto = New System.Windows.Forms.TextBox()
        Me.txtTipoProceso = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkTipoProceso)
        Me.grupoDatos.Controls.Add(Me.checkID)
        Me.grupoDatos.Controls.Add(Me.Label5)
        Me.grupoDatos.Controls.Add(Me.checkProducto)
        Me.grupoDatos.Controls.Add(Me.txtTipoProducto)
        Me.grupoDatos.Controls.Add(Me.txtTipoProceso)
        Me.grupoDatos.Controls.Add(Me.txtID)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 12)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(415, 97)
        Me.grupoDatos.TabIndex = 1
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos de Proceso"
        '
        'checkTipoProceso
        '
        Me.checkTipoProceso.AutoSize = True
        Me.checkTipoProceso.Location = New System.Drawing.Point(244, 52)
        Me.checkTipoProceso.Name = "checkTipoProceso"
        Me.checkTipoProceso.Size = New System.Drawing.Size(15, 14)
        Me.checkTipoProceso.TabIndex = 4
        Me.checkTipoProceso.TabStop = False
        Me.checkTipoProceso.UseVisualStyleBackColor = True
        '
        'checkID
        '
        Me.checkID.AutoSize = True
        Me.checkID.Location = New System.Drawing.Point(115, 52)
        Me.checkID.Name = "checkID"
        Me.checkID.Size = New System.Drawing.Size(15, 14)
        Me.checkID.TabIndex = 4
        Me.checkID.TabStop = False
        Me.checkID.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(262, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Producto Final:"
        '
        'checkProducto
        '
        Me.checkProducto.AutoSize = True
        Me.checkProducto.Location = New System.Drawing.Point(371, 52)
        Me.checkProducto.Name = "checkProducto"
        Me.checkProducto.Size = New System.Drawing.Size(15, 14)
        Me.checkProducto.TabIndex = 4
        Me.checkProducto.TabStop = False
        Me.checkProducto.UseVisualStyleBackColor = True
        '
        'txtTipoProducto
        '
        Me.txtTipoProducto.Enabled = False
        Me.txtTipoProducto.Location = New System.Drawing.Point(265, 49)
        Me.txtTipoProducto.Name = "txtTipoProducto"
        Me.txtTipoProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProducto.TabIndex = 3
        '
        'txtTipoProceso
        '
        Me.txtTipoProceso.Enabled = False
        Me.txtTipoProceso.Location = New System.Drawing.Point(138, 49)
        Me.txtTipoProceso.Name = "txtTipoProceso"
        Me.txtTipoProceso.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProceso.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(9, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(135, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Proceso:"
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(448, 44)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 4
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(448, 73)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 115)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(526, 172)
        Me.dataGrid.TabIndex = 24
        '
        'FormConsultaProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(550, 301)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(566, 340)
        Me.MinimumSize = New System.Drawing.Size(566, 340)
        Me.Name = "FormConsultaProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Procesos"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents checkTipoProceso As System.Windows.Forms.CheckBox
    Friend WithEvents checkID As System.Windows.Forms.CheckBox
    Friend WithEvents checkProducto As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTipoProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoProceso As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
End Class
