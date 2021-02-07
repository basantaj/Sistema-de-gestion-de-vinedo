<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaTransporte
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
        Me.cmbMinFin = New System.Windows.Forms.ComboBox()
        Me.cmbMinIn = New System.Windows.Forms.ComboBox()
        Me.cmbHrFin = New System.Windows.Forms.ComboBox()
        Me.cmbHrIn = New System.Windows.Forms.ComboBox()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEstablecimiento = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.grupoDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.cmbMinFin)
        Me.grupoDatos.Controls.Add(Me.cmbMinIn)
        Me.grupoDatos.Controls.Add(Me.cmbHrFin)
        Me.grupoDatos.Controls.Add(Me.cmbHrIn)
        Me.grupoDatos.Controls.Add(Me.txtMatricula)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label7)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.Label6)
        Me.grupoDatos.Controls.Add(Me.Label5)
        Me.grupoDatos.Controls.Add(Me.Label4)
        Me.grupoDatos.Controls.Add(Me.Label3)
        Me.grupoDatos.Controls.Add(Me.txtEstablecimiento)
        Me.grupoDatos.Controls.Add(Me.txtCapacidad)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 12)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(569, 92)
        Me.grupoDatos.TabIndex = 4
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Vehículo"
        '
        'cmbMinFin
        '
        Me.cmbMinFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinFin.FormattingEnabled = True
        Me.cmbMinFin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMinFin.Location = New System.Drawing.Point(510, 50)
        Me.cmbMinFin.Name = "cmbMinFin"
        Me.cmbMinFin.Size = New System.Drawing.Size(41, 21)
        Me.cmbMinFin.TabIndex = 7
        '
        'cmbMinIn
        '
        Me.cmbMinIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMinIn.FormattingEnabled = True
        Me.cmbMinIn.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMinIn.Location = New System.Drawing.Point(407, 50)
        Me.cmbMinIn.Name = "cmbMinIn"
        Me.cmbMinIn.Size = New System.Drawing.Size(41, 21)
        Me.cmbMinIn.TabIndex = 5
        '
        'cmbHrFin
        '
        Me.cmbHrFin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHrFin.FormattingEnabled = True
        Me.cmbHrFin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cmbHrFin.Location = New System.Drawing.Point(454, 50)
        Me.cmbHrFin.Name = "cmbHrFin"
        Me.cmbHrFin.Size = New System.Drawing.Size(41, 21)
        Me.cmbHrFin.TabIndex = 6
        '
        'cmbHrIn
        '
        Me.cmbHrIn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHrIn.FormattingEnabled = True
        Me.cmbHrIn.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23"})
        Me.cmbHrIn.Location = New System.Drawing.Point(346, 50)
        Me.cmbHrIn.Name = "cmbHrIn"
        Me.cmbHrIn.Size = New System.Drawing.Size(41, 21)
        Me.cmbHrIn.TabIndex = 4
        '
        'txtMatricula
        '
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(499, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = ":"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(119, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Capacidad:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(451, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Fin de turno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = ":"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(343, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Inicio de turno:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(229, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Establecimiento:"
        '
        'txtEstablecimiento
        '
        Me.txtEstablecimiento.Location = New System.Drawing.Point(232, 50)
        Me.txtEstablecimiento.Name = "txtEstablecimiento"
        Me.txtEstablecimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtEstablecimiento.TabIndex = 3
        '
        'txtCapacidad
        '
        Me.txtCapacidad.Location = New System.Drawing.Point(122, 50)
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCapacidad.TabIndex = 2
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(357, 115)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 9
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(438, 115)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 10
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(519, 115)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 8
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'FormAltaTransporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(605, 150)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(621, 189)
        Me.MinimumSize = New System.Drawing.Size(621, 189)
        Me.Name = "FormAltaTransporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Transporte"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtMatricula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtEstablecimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmbMinIn As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHrIn As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbMinFin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHrFin As System.Windows.Forms.ComboBox
End Class
