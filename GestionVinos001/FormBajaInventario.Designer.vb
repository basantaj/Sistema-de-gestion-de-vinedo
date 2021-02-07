<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaInventario
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
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
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
        Me.grupoResultado.Controls.Add(Me.txtUnidad)
        Me.grupoResultado.Controls.Add(Me.Label2)
        Me.grupoResultado.Controls.Add(Me.txtStock)
        Me.grupoResultado.Enabled = False
        Me.grupoResultado.Location = New System.Drawing.Point(129, 12)
        Me.grupoResultado.Name = "grupoResultado"
        Me.grupoResultado.Size = New System.Drawing.Size(263, 147)
        Me.grupoResultado.TabIndex = 14
        Me.grupoResultado.TabStop = False
        Me.grupoResultado.Text = "Resultado"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Stock:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(157, 72)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(100, 23)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar Baja"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(22, 98)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 1
        Me.txtUnidad.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Unidad:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(22, 45)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 1
        Me.txtStock.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Tipo de Material:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(11, 32)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(11, 136)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(11, 107)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(100, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(11, 78)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(100, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Busqueda"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FormBajaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(404, 170)
        Me.Controls.Add(Me.grupoResultado)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtTipo)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.MaximumSize = New System.Drawing.Size(420, 209)
        Me.MinimumSize = New System.Drawing.Size(420, 209)
        Me.Name = "FormBajaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Inventario"
        Me.grupoResultado.ResumeLayout(False)
        Me.grupoResultado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoResultado As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
End Class
