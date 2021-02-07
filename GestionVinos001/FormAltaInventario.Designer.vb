<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaInventario
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
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.txtTipo)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtUnidad)
        Me.grupoDatos.Controls.Add(Me.txtStock)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 12)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(366, 92)
        Me.grupoDatos.TabIndex = 4
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Material"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(11, 50)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(232, 50)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 3
        '
        'txtStock
        '
        Me.txtStock.Location = New System.Drawing.Point(122, 50)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(129, 110)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(210, 110)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 6
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(291, 110)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'FormAltaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(404, 150)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(420, 189)
        Me.MinimumSize = New System.Drawing.Size(420, 189)
        Me.Name = "FormAltaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Inventario"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
End Class
