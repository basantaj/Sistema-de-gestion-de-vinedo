<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActividadTransporta
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.cmbHr = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbMatricula = New System.Windows.Forms.ComboBox()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMin)
        Me.GroupBox1.Controls.Add(Me.cmbHr)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.cmbMatricula)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del transporte:"
        '
        'cmbMin
        '
        Me.cmbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMin.FormattingEnabled = True
        Me.cmbMin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMin.Location = New System.Drawing.Point(189, 32)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(41, 21)
        Me.cmbMin.TabIndex = 5
        '
        'cmbHr
        '
        Me.cmbHr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHr.FormattingEnabled = True
        Me.cmbHr.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cmbHr.Location = New System.Drawing.Point(133, 32)
        Me.cmbHr.Name = "cmbHr"
        Me.cmbHr.Size = New System.Drawing.Size(41, 21)
        Me.cmbHr.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(178, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matrícula del vehículo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Horario de llegada:"
        '
        'cmbMatricula
        '
        Me.cmbMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatricula.FormattingEnabled = True
        Me.cmbMatricula.Location = New System.Drawing.Point(6, 32)
        Me.cmbMatricula.Name = "cmbMatricula"
        Me.cmbMatricula.Size = New System.Drawing.Size(121, 21)
        Me.cmbMatricula.TabIndex = 1
        '
        'btnVehiculos
        '
        Me.btnVehiculos.Location = New System.Drawing.Point(12, 87)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(75, 45)
        Me.btnVehiculos.TabIndex = 1
        Me.btnVehiculos.Text = "Detalle de Vehículos "
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(174, 87)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 45)
        Me.btnConfirmar.TabIndex = 1
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(93, 87)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 45)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FormActividadTransporta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(291, 153)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnVehiculos)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximumSize = New System.Drawing.Size(307, 192)
        Me.MinimumSize = New System.Drawing.Size(307, 192)
        Me.Name = "FormActividadTransporta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Arribo de Vehículos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbMatricula As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHr As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVehiculos As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
