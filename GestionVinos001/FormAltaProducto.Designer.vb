<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAltaProducto
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
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.comboProducto = New System.Windows.Forms.ComboBox()
        Me.radioMosto = New System.Windows.Forms.RadioButton()
        Me.radioVino = New System.Windows.Forms.RadioButton()
        Me.grupoMosto = New System.Windows.Forms.GroupBox()
        Me.txtCepa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnioMosto = New System.Windows.Forms.TextBox()
        Me.grupoVino = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnioVino = New System.Windows.Forms.TextBox()
        Me.radioUva = New System.Windows.Forms.RadioButton()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnListarProductos = New System.Windows.Forms.Button()
        Me.grupoCont = New System.Windows.Forms.GroupBox()
        Me.cmbIdCont = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnListarContenedores = New System.Windows.Forms.Button()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtUnidad = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.grupoVeh = New System.Windows.Forms.GroupBox()
        Me.cmbMin = New System.Windows.Forms.ComboBox()
        Me.cmbHr = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbMatricula = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnVehiculos = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtDestino = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.radioContenedor = New System.Windows.Forms.RadioButton()
        Me.radioVehiculo = New System.Windows.Forms.RadioButton()
        Me.radioNinguno = New System.Windows.Forms.RadioButton()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.grupoMosto.SuspendLayout()
        Me.grupoVino.SuspendLayout()
        Me.grupoCont.SuspendLayout()
        Me.grupoVeh.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Location = New System.Drawing.Point(9, 56)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(100, 20)
        Me.txtIDProducto.TabIndex = 1
        '
        'txtNom
        '
        Me.txtNom.Location = New System.Drawing.Point(115, 56)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(112, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(218, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Origen:"
        '
        'txtOrigen
        '
        Me.txtOrigen.Location = New System.Drawing.Point(221, 56)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(100, 20)
        Me.txtOrigen.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(324, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Producto final:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.comboProducto)
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtIDProducto)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrigen)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(431, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'comboProducto
        '
        Me.comboProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboProducto.FormattingEnabled = True
        Me.comboProducto.Location = New System.Drawing.Point(327, 56)
        Me.comboProducto.Name = "comboProducto"
        Me.comboProducto.Size = New System.Drawing.Size(100, 21)
        Me.comboProducto.TabIndex = 4
        '
        'radioMosto
        '
        Me.radioMosto.AutoSize = True
        Me.radioMosto.Location = New System.Drawing.Point(21, 154)
        Me.radioMosto.Name = "radioMosto"
        Me.radioMosto.Size = New System.Drawing.Size(54, 17)
        Me.radioMosto.TabIndex = 19
        Me.radioMosto.TabStop = True
        Me.radioMosto.Text = "Mosto"
        Me.radioMosto.UseVisualStyleBackColor = True
        '
        'radioVino
        '
        Me.radioVino.AutoSize = True
        Me.radioVino.Location = New System.Drawing.Point(21, 177)
        Me.radioVino.Name = "radioVino"
        Me.radioVino.Size = New System.Drawing.Size(46, 17)
        Me.radioVino.TabIndex = 22
        Me.radioVino.TabStop = True
        Me.radioVino.Text = "Vino"
        Me.radioVino.UseVisualStyleBackColor = True
        '
        'grupoMosto
        '
        Me.grupoMosto.Controls.Add(Me.txtCepa)
        Me.grupoMosto.Controls.Add(Me.Label5)
        Me.grupoMosto.Controls.Add(Me.Label6)
        Me.grupoMosto.Controls.Add(Me.txtAnioMosto)
        Me.grupoMosto.Location = New System.Drawing.Point(127, 119)
        Me.grupoMosto.Name = "grupoMosto"
        Me.grupoMosto.Size = New System.Drawing.Size(312, 68)
        Me.grupoMosto.TabIndex = 4
        Me.grupoMosto.TabStop = False
        Me.grupoMosto.Text = "Mosto"
        '
        'txtCepa
        '
        Me.txtCepa.Location = New System.Drawing.Point(169, 32)
        Me.txtCepa.Name = "txtCepa"
        Me.txtCepa.Size = New System.Drawing.Size(100, 20)
        Me.txtCepa.TabIndex = 21
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(63, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(166, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cepa:"
        '
        'txtAnioMosto
        '
        Me.txtAnioMosto.Location = New System.Drawing.Point(63, 32)
        Me.txtAnioMosto.Name = "txtAnioMosto"
        Me.txtAnioMosto.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioMosto.TabIndex = 20
        '
        'grupoVino
        '
        Me.grupoVino.Controls.Add(Me.Label7)
        Me.grupoVino.Controls.Add(Me.txtAnioVino)
        Me.grupoVino.Location = New System.Drawing.Point(127, 193)
        Me.grupoVino.Name = "grupoVino"
        Me.grupoVino.Size = New System.Drawing.Size(312, 68)
        Me.grupoVino.TabIndex = 4
        Me.grupoVino.TabStop = False
        Me.grupoVino.Text = "Vino"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 15)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Año:"
        '
        'txtAnioVino
        '
        Me.txtAnioVino.Location = New System.Drawing.Point(106, 31)
        Me.txtAnioVino.Name = "txtAnioVino"
        Me.txtAnioVino.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioVino.TabIndex = 23
        '
        'radioUva
        '
        Me.radioUva.AutoSize = True
        Me.radioUva.Location = New System.Drawing.Point(21, 131)
        Me.radioUva.Name = "radioUva"
        Me.radioUva.Size = New System.Drawing.Size(45, 17)
        Me.radioUva.TabIndex = 17
        Me.radioUva.TabStop = True
        Me.radioUva.Text = "Uva"
        Me.radioUva.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(616, 282)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 15
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(535, 282)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnListarProductos
        '
        Me.btnListarProductos.Location = New System.Drawing.Point(21, 214)
        Me.btnListarProductos.Name = "btnListarProductos"
        Me.btnListarProductos.Size = New System.Drawing.Size(75, 47)
        Me.btnListarProductos.TabIndex = 5
        Me.btnListarProductos.Text = "Listado de Productos"
        Me.btnListarProductos.UseVisualStyleBackColor = True
        '
        'grupoCont
        '
        Me.grupoCont.Controls.Add(Me.cmbIdCont)
        Me.grupoCont.Controls.Add(Me.Label11)
        Me.grupoCont.Controls.Add(Me.btnListarContenedores)
        Me.grupoCont.Controls.Add(Me.txtCantidad)
        Me.grupoCont.Controls.Add(Me.Label10)
        Me.grupoCont.Controls.Add(Me.txtUnidad)
        Me.grupoCont.Controls.Add(Me.Label9)
        Me.grupoCont.Enabled = False
        Me.grupoCont.Location = New System.Drawing.Point(450, 13)
        Me.grupoCont.Name = "grupoCont"
        Me.grupoCont.Size = New System.Drawing.Size(121, 208)
        Me.grupoCont.TabIndex = 6
        Me.grupoCont.TabStop = False
        Me.grupoCont.Text = "En Contenedor"
        '
        'cmbIdCont
        '
        Me.cmbIdCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbIdCont.FormattingEnabled = True
        Me.cmbIdCont.Location = New System.Drawing.Point(6, 54)
        Me.cmbIdCont.Name = "cmbIdCont"
        Me.cmbIdCont.Size = New System.Drawing.Size(100, 21)
        Me.cmbIdCont.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 117)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Cantidad:"
        '
        'btnListarContenedores
        '
        Me.btnListarContenedores.Location = New System.Drawing.Point(9, 159)
        Me.btnListarContenedores.Name = "btnListarContenedores"
        Me.btnListarContenedores.Size = New System.Drawing.Size(95, 38)
        Me.btnListarContenedores.TabIndex = 5
        Me.btnListarContenedores.Text = "Contenedores Disponibles"
        Me.btnListarContenedores.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(6, 133)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 20)
        Me.txtCantidad.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Unidad:"
        '
        'txtUnidad
        '
        Me.txtUnidad.Location = New System.Drawing.Point(6, 94)
        Me.txtUnidad.Name = "txtUnidad"
        Me.txtUnidad.Size = New System.Drawing.Size(100, 20)
        Me.txtUnidad.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 39)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(95, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "ID del contenedor:"
        '
        'grupoVeh
        '
        Me.grupoVeh.Controls.Add(Me.cmbMin)
        Me.grupoVeh.Controls.Add(Me.cmbHr)
        Me.grupoVeh.Controls.Add(Me.Label14)
        Me.grupoVeh.Controls.Add(Me.cmbMatricula)
        Me.grupoVeh.Controls.Add(Me.Label8)
        Me.grupoVeh.Controls.Add(Me.btnVehiculos)
        Me.grupoVeh.Controls.Add(Me.Label12)
        Me.grupoVeh.Controls.Add(Me.txtDestino)
        Me.grupoVeh.Controls.Add(Me.Label13)
        Me.grupoVeh.Enabled = False
        Me.grupoVeh.Location = New System.Drawing.Point(577, 13)
        Me.grupoVeh.Name = "grupoVeh"
        Me.grupoVeh.Size = New System.Drawing.Size(121, 208)
        Me.grupoVeh.TabIndex = 6
        Me.grupoVeh.TabStop = False
        Me.grupoVeh.Text = "En Vehiculo"
        '
        'cmbMin
        '
        Me.cmbMin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMin.FormattingEnabled = True
        Me.cmbMin.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cmbMin.Location = New System.Drawing.Point(65, 133)
        Me.cmbMin.Name = "cmbMin"
        Me.cmbMin.Size = New System.Drawing.Size(41, 21)
        Me.cmbMin.TabIndex = 14
        '
        'cmbHr
        '
        Me.cmbHr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHr.FormattingEnabled = True
        Me.cmbHr.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.cmbHr.Location = New System.Drawing.Point(9, 133)
        Me.cmbHr.Name = "cmbHr"
        Me.cmbHr.Size = New System.Drawing.Size(41, 21)
        Me.cmbHr.TabIndex = 13
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(54, 136)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(10, 13)
        Me.Label14.TabIndex = 10
        Me.Label14.Text = ":"
        '
        'cmbMatricula
        '
        Me.cmbMatricula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMatricula.FormattingEnabled = True
        Me.cmbMatricula.Location = New System.Drawing.Point(9, 54)
        Me.cmbMatricula.Name = "cmbMatricula"
        Me.cmbMatricula.Size = New System.Drawing.Size(100, 21)
        Me.cmbMatricula.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 117)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Horario de Salida:"
        '
        'btnVehiculos
        '
        Me.btnVehiculos.Location = New System.Drawing.Point(9, 159)
        Me.btnVehiculos.Name = "btnVehiculos"
        Me.btnVehiculos.Size = New System.Drawing.Size(95, 38)
        Me.btnVehiculos.TabIndex = 5
        Me.btnVehiculos.Text = "Vehiculos Disponibles"
        Me.btnVehiculos.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 78)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(46, 13)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "Destino:"
        '
        'txtDestino
        '
        Me.txtDestino.Location = New System.Drawing.Point(6, 94)
        Me.txtDestino.Name = "txtDestino"
        Me.txtDestino.Size = New System.Drawing.Size(100, 20)
        Me.txtDestino.TabIndex = 12
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 39)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(113, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Matricula del vehiculo:"
        '
        'radioContenedor
        '
        Me.radioContenedor.AutoSize = True
        Me.radioContenedor.Location = New System.Drawing.Point(6, 19)
        Me.radioContenedor.Name = "radioContenedor"
        Me.radioContenedor.Size = New System.Drawing.Size(80, 17)
        Me.radioContenedor.TabIndex = 7
        Me.radioContenedor.TabStop = True
        Me.radioContenedor.Text = "Contenedor"
        Me.radioContenedor.UseVisualStyleBackColor = True
        '
        'radioVehiculo
        '
        Me.radioVehiculo.AutoSize = True
        Me.radioVehiculo.Location = New System.Drawing.Point(92, 19)
        Me.radioVehiculo.Name = "radioVehiculo"
        Me.radioVehiculo.Size = New System.Drawing.Size(66, 17)
        Me.radioVehiculo.TabIndex = 6
        Me.radioVehiculo.TabStop = True
        Me.radioVehiculo.Text = "Vehiculo"
        Me.radioVehiculo.UseVisualStyleBackColor = True
        '
        'radioNinguno
        '
        Me.radioNinguno.AutoSize = True
        Me.radioNinguno.Location = New System.Drawing.Point(164, 19)
        Me.radioNinguno.Name = "radioNinguno"
        Me.radioNinguno.Size = New System.Drawing.Size(65, 17)
        Me.radioNinguno.TabIndex = 5
        Me.radioNinguno.TabStop = True
        Me.radioNinguno.Text = "Ninguno"
        Me.radioNinguno.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.radioContenedor)
        Me.GroupBox4.Controls.Add(Me.radioNinguno)
        Me.GroupBox4.Controls.Add(Me.radioVehiculo)
        Me.GroupBox4.Location = New System.Drawing.Point(459, 227)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(237, 49)
        Me.GroupBox4.TabIndex = 8
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Producto en"
        '
        'FormAltaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(724, 317)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grupoVeh)
        Me.Controls.Add(Me.grupoCont)
        Me.Controls.Add(Me.btnListarProductos)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grupoVino)
        Me.Controls.Add(Me.grupoMosto)
        Me.Controls.Add(Me.radioVino)
        Me.Controls.Add(Me.radioUva)
        Me.Controls.Add(Me.radioMosto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Location = New System.Drawing.Point(560, 330)
        Me.Name = "FormAltaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingreso de Producto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grupoMosto.ResumeLayout(False)
        Me.grupoMosto.PerformLayout()
        Me.grupoVino.ResumeLayout(False)
        Me.grupoVino.PerformLayout()
        Me.grupoCont.ResumeLayout(False)
        Me.grupoCont.PerformLayout()
        Me.grupoVeh.ResumeLayout(False)
        Me.grupoVeh.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtIDProducto As System.Windows.Forms.TextBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents radioMosto As System.Windows.Forms.RadioButton
    Friend WithEvents radioVino As System.Windows.Forms.RadioButton
    Friend WithEvents grupoMosto As System.Windows.Forms.GroupBox
    Friend WithEvents txtCepa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnioMosto As System.Windows.Forms.TextBox
    Friend WithEvents grupoVino As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAnioVino As System.Windows.Forms.TextBox
    Friend WithEvents radioUva As System.Windows.Forms.RadioButton
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnListarProductos As System.Windows.Forms.Button
    Friend WithEvents grupoCont As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtUnidad As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnListarContenedores As System.Windows.Forms.Button
    Friend WithEvents comboProducto As System.Windows.Forms.ComboBox
    Friend WithEvents grupoVeh As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnVehiculos As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtDestino As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbMatricula As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMin As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHr As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents radioContenedor As System.Windows.Forms.RadioButton
    Friend WithEvents radioVehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents radioNinguno As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbIdCont As System.Windows.Forms.ComboBox
End Class
