<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBajaBotella
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.txtContenido = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.txtCod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.btnConfirmar)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtStock)
        Me.grupoDatos.Controls.Add(Me.txtContenido)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Enabled = False
        Me.grupoDatos.Location = New System.Drawing.Point(156, 12)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(312, 119)
        Me.grupoDatos.TabIndex = 6
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Resultado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 69)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Stock:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(165, 82)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(115, 23)
        Me.btnConfirmar.TabIndex = 3
        Me.btnConfirmar.Text = "Confirmar Baja"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(162, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Capacidad de la botella:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Contenido de la botella:"
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(10, 85)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(115, 20)
        Me.txtStock.TabIndex = 1
        Me.txtStock.TabStop = False
        '
        'txtContenido
        '
        Me.txtContenido.Location = New System.Drawing.Point(10, 35)
        Me.txtContenido.Name = "txtContenido"
        Me.txtContenido.Size = New System.Drawing.Size(115, 20)
        Me.txtContenido.TabIndex = 1
        Me.txtContenido.TabStop = False
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(165, 35)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(115, 20)
        Me.txtCapacidad.TabIndex = 1
        Me.txtCapacidad.TabStop = False
        '
        'txtCod
        '
        Me.txtCod.Location = New System.Drawing.Point(15, 25)
        Me.txtCod.Name = "txtCod"
        Me.txtCod.Size = New System.Drawing.Size(115, 20)
        Me.txtCod.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de Botella:"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(15, 115)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(115, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(15, 86)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(115, 23)
        Me.btnListado.TabIndex = 5
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(15, 54)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(115, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Busqueda"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'FormBajaBotella
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(482, 159)
        Me.Controls.Add(Me.txtCod)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(498, 198)
        Me.MinimumSize = New System.Drawing.Size(498, 198)
        Me.Name = "FormBajaBotella"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Producto final"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtCod As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents txtContenido As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
End Class
