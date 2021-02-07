<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaProceso
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
        Me.grupoDatos2 = New System.Windows.Forms.GroupBox()
        Me.cmbProductos = New System.Windows.Forms.ComboBox()
        Me.numDuracion = New System.Windows.Forms.NumericUpDown()
        Me.txtpH = New System.Windows.Forms.TextBox()
        Me.txtTipoProceso = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.grupoDatos.SuspendLayout()
        Me.grupoDatos2.SuspendLayout()
        CType(Me.numDuracion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.grupoDatos2)
        Me.grupoDatos.Controls.Add(Me.numDuracion)
        Me.grupoDatos.Controls.Add(Me.txtpH)
        Me.grupoDatos.Controls.Add(Me.txtTipoProceso)
        Me.grupoDatos.Controls.Add(Me.txtID)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Location = New System.Drawing.Point(13, 13)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(164, 287)
        Me.grupoDatos.TabIndex = 0
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos de Proceso"
        '
        'grupoDatos2
        '
        Me.grupoDatos2.Controls.Add(Me.cmbProductos)
        Me.grupoDatos2.Location = New System.Drawing.Point(9, 192)
        Me.grupoDatos2.Name = "grupoDatos2"
        Me.grupoDatos2.Size = New System.Drawing.Size(130, 86)
        Me.grupoDatos2.TabIndex = 3
        Me.grupoDatos2.TabStop = False
        Me.grupoDatos2.Text = "Producto final"
        '
        'cmbProductos
        '
        Me.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductos.FormattingEnabled = True
        Me.cmbProductos.Location = New System.Drawing.Point(3, 31)
        Me.cmbProductos.Name = "cmbProductos"
        Me.cmbProductos.Size = New System.Drawing.Size(121, 21)
        Me.cmbProductos.TabIndex = 5
        '
        'numDuracion
        '
        Me.numDuracion.Location = New System.Drawing.Point(9, 129)
        Me.numDuracion.Name = "numDuracion"
        Me.numDuracion.Size = New System.Drawing.Size(100, 20)
        Me.numDuracion.TabIndex = 3
        '
        'txtpH
        '
        Me.txtpH.Location = New System.Drawing.Point(9, 169)
        Me.txtpH.Name = "txtpH"
        Me.txtpH.Size = New System.Drawing.Size(100, 20)
        Me.txtpH.TabIndex = 4
        '
        'txtTipoProceso
        '
        Me.txtTipoProceso.Location = New System.Drawing.Point(9, 89)
        Me.txtTipoProceso.Name = "txtTipoProceso"
        Me.txtTipoProceso.Size = New System.Drawing.Size(100, 20)
        Me.txtTipoProceso.TabIndex = 2
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(9, 49)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Duración Esperada(minutos):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "pH Esperado:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
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
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(213, 99)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 6
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(213, 128)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(213, 157)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 8
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'FormAltaProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(334, 311)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(350, 350)
        Me.MinimumSize = New System.Drawing.Size(350, 350)
        Me.Name = "FormAltaProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Procesos"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.grupoDatos2.ResumeLayout(False)
        CType(Me.numDuracion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents grupoDatos2 As System.Windows.Forms.GroupBox
    Friend WithEvents numDuracion As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtpH As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoProceso As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents cmbProductos As System.Windows.Forms.ComboBox
End Class
