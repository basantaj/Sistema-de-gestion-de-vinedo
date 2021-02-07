<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaAlmacenamiento
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
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
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(11, 50)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Tipo:"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(122, 50)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Material:"
        '
        'txtMaterial
        '
        Me.txtMaterial.Location = New System.Drawing.Point(232, 50)
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(100, 20)
        Me.txtMaterial.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(338, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Capacidad:"
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(341, 50)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 4
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(372, 114)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(291, 114)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 7
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(210, 114)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 6
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.txtID)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.txtMaterial)
        Me.grupoDatos.Controls.Add(Me.txtTipo)
        Me.grupoDatos.Location = New System.Drawing.Point(6, 6)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(453, 92)
        Me.grupoDatos.TabIndex = 3
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Contenedor"
        '
        'FormAltaAlmacenamiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(473, 150)
        Me.Controls.Add(Me.grupoDatos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnConfirmar)
        Me.MaximumSize = New System.Drawing.Size(489, 189)
        Me.MinimumSize = New System.Drawing.Size(489, 189)
        Me.Name = "FormAltaAlmacenamiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Contenedores"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaterial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
End Class
