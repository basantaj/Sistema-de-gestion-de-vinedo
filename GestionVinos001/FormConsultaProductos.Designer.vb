<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaProductos
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.radioVino = New System.Windows.Forms.RadioButton()
        Me.radioUva = New System.Windows.Forms.RadioButton()
        Me.radioMosto = New System.Windows.Forms.RadioButton()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grupoVino = New System.Windows.Forms.GroupBox()
        Me.checkAnioVino = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAnioVino = New System.Windows.Forms.TextBox()
        Me.grupoMosto = New System.Windows.Forms.GroupBox()
        Me.checkCepa = New System.Windows.Forms.CheckBox()
        Me.checkAnioMosto = New System.Windows.Forms.CheckBox()
        Me.txtCepa = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAnioMosto = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.checkIDContenedor = New System.Windows.Forms.CheckBox()
        Me.checkTipo = New System.Windows.Forms.CheckBox()
        Me.checkOrigen = New System.Windows.Forms.CheckBox()
        Me.checkNombre = New System.Windows.Forms.CheckBox()
        Me.checkID = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtOrigen = New System.Windows.Forms.TextBox()
        Me.txtIDContenedor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupoVino.SuspendLayout()
        Me.grupoMosto.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dataGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.dataGrid.Location = New System.Drawing.Point(9, 306)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dataGrid.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dataGrid.Size = New System.Drawing.Size(686, 198)
        Me.dataGrid.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(152, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(209, 17)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Seleccione los Filtros a Emplear"
        '
        'radioVino
        '
        Me.radioVino.AutoSize = True
        Me.radioVino.Location = New System.Drawing.Point(21, 220)
        Me.radioVino.Name = "radioVino"
        Me.radioVino.Size = New System.Drawing.Size(46, 17)
        Me.radioVino.TabIndex = 12
        Me.radioVino.TabStop = True
        Me.radioVino.Text = "Vino"
        Me.radioVino.UseVisualStyleBackColor = True
        '
        'radioUva
        '
        Me.radioUva.AutoSize = True
        Me.radioUva.Location = New System.Drawing.Point(21, 174)
        Me.radioUva.Name = "radioUva"
        Me.radioUva.Size = New System.Drawing.Size(45, 17)
        Me.radioUva.TabIndex = 8
        Me.radioUva.TabStop = True
        Me.radioUva.Text = "Uva"
        Me.radioUva.UseVisualStyleBackColor = True
        '
        'radioMosto
        '
        Me.radioMosto.AutoSize = True
        Me.radioMosto.Location = New System.Drawing.Point(21, 197)
        Me.radioMosto.Name = "radioMosto"
        Me.radioMosto.Size = New System.Drawing.Size(54, 17)
        Me.radioMosto.TabIndex = 9
        Me.radioMosto.TabStop = True
        Me.radioMosto.Text = "Mosto"
        Me.radioMosto.UseVisualStyleBackColor = True
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(508, 194)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 6
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(508, 242)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grupoVino
        '
        Me.grupoVino.Controls.Add(Me.checkAnioVino)
        Me.grupoVino.Controls.Add(Me.Label7)
        Me.grupoVino.Controls.Add(Me.txtAnioVino)
        Me.grupoVino.Location = New System.Drawing.Point(124, 232)
        Me.grupoVino.Name = "grupoVino"
        Me.grupoVino.Size = New System.Drawing.Size(312, 68)
        Me.grupoVino.TabIndex = 32
        Me.grupoVino.TabStop = False
        Me.grupoVino.Text = "Vino"
        '
        'checkAnioVino
        '
        Me.checkAnioVino.AutoSize = True
        Me.checkAnioVino.Location = New System.Drawing.Point(205, 37)
        Me.checkAnioVino.Name = "checkAnioVino"
        Me.checkAnioVino.Size = New System.Drawing.Size(15, 14)
        Me.checkAnioVino.TabIndex = 2
        Me.checkAnioVino.TabStop = False
        Me.checkAnioVino.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(99, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(29, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Año:"
        '
        'txtAnioVino
        '
        Me.txtAnioVino.Enabled = False
        Me.txtAnioVino.Location = New System.Drawing.Point(99, 32)
        Me.txtAnioVino.Name = "txtAnioVino"
        Me.txtAnioVino.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioVino.TabIndex = 13
        '
        'grupoMosto
        '
        Me.grupoMosto.Controls.Add(Me.checkCepa)
        Me.grupoMosto.Controls.Add(Me.checkAnioMosto)
        Me.grupoMosto.Controls.Add(Me.txtCepa)
        Me.grupoMosto.Controls.Add(Me.Label5)
        Me.grupoMosto.Controls.Add(Me.Label6)
        Me.grupoMosto.Controls.Add(Me.txtAnioMosto)
        Me.grupoMosto.Location = New System.Drawing.Point(124, 158)
        Me.grupoMosto.Name = "grupoMosto"
        Me.grupoMosto.Size = New System.Drawing.Size(312, 68)
        Me.grupoMosto.TabIndex = 31
        Me.grupoMosto.TabStop = False
        Me.grupoMosto.Text = "Mosto"
        '
        'checkCepa
        '
        Me.checkCepa.AutoSize = True
        Me.checkCepa.Location = New System.Drawing.Point(273, 39)
        Me.checkCepa.Name = "checkCepa"
        Me.checkCepa.Size = New System.Drawing.Size(15, 14)
        Me.checkCepa.TabIndex = 2
        Me.checkCepa.TabStop = False
        Me.checkCepa.UseVisualStyleBackColor = True
        '
        'checkAnioMosto
        '
        Me.checkAnioMosto.AutoSize = True
        Me.checkAnioMosto.Location = New System.Drawing.Point(137, 41)
        Me.checkAnioMosto.Name = "checkAnioMosto"
        Me.checkAnioMosto.Size = New System.Drawing.Size(15, 14)
        Me.checkAnioMosto.TabIndex = 2
        Me.checkAnioMosto.TabStop = False
        Me.checkAnioMosto.UseVisualStyleBackColor = True
        '
        'txtCepa
        '
        Me.txtCepa.Enabled = False
        Me.txtCepa.Location = New System.Drawing.Point(167, 36)
        Me.txtCepa.Name = "txtCepa"
        Me.txtCepa.Size = New System.Drawing.Size(100, 20)
        Me.txtCepa.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(31, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Año:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(164, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Cepa:"
        '
        'txtAnioMosto
        '
        Me.txtAnioMosto.Enabled = False
        Me.txtAnioMosto.Location = New System.Drawing.Point(31, 36)
        Me.txtAnioMosto.Name = "txtAnioMosto"
        Me.txtAnioMosto.Size = New System.Drawing.Size(100, 20)
        Me.txtAnioMosto.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtNom)
        Me.GroupBox1.Controls.Add(Me.checkIDContenedor)
        Me.GroupBox1.Controls.Add(Me.checkTipo)
        Me.GroupBox1.Controls.Add(Me.checkOrigen)
        Me.GroupBox1.Controls.Add(Me.checkNombre)
        Me.GroupBox1.Controls.Add(Me.checkID)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtOrigen)
        Me.GroupBox1.Controls.Add(Me.txtIDContenedor)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(651, 100)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General"
        '
        'txtNom
        '
        Me.txtNom.Enabled = False
        Me.txtNom.Location = New System.Drawing.Point(131, 56)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(100, 20)
        Me.txtNom.TabIndex = 2
        '
        'checkIDContenedor
        '
        Me.checkIDContenedor.AutoSize = True
        Me.checkIDContenedor.Location = New System.Drawing.Point(602, 60)
        Me.checkIDContenedor.Name = "checkIDContenedor"
        Me.checkIDContenedor.Size = New System.Drawing.Size(15, 14)
        Me.checkIDContenedor.TabIndex = 2
        Me.checkIDContenedor.TabStop = False
        Me.checkIDContenedor.UseVisualStyleBackColor = True
        '
        'checkTipo
        '
        Me.checkTipo.AutoSize = True
        Me.checkTipo.Location = New System.Drawing.Point(478, 60)
        Me.checkTipo.Name = "checkTipo"
        Me.checkTipo.Size = New System.Drawing.Size(15, 14)
        Me.checkTipo.TabIndex = 2
        Me.checkTipo.TabStop = False
        Me.checkTipo.UseVisualStyleBackColor = True
        '
        'checkOrigen
        '
        Me.checkOrigen.AutoSize = True
        Me.checkOrigen.Location = New System.Drawing.Point(355, 60)
        Me.checkOrigen.Name = "checkOrigen"
        Me.checkOrigen.Size = New System.Drawing.Size(15, 14)
        Me.checkOrigen.TabIndex = 2
        Me.checkOrigen.TabStop = False
        Me.checkOrigen.UseVisualStyleBackColor = True
        '
        'checkNombre
        '
        Me.checkNombre.AutoSize = True
        Me.checkNombre.Location = New System.Drawing.Point(234, 60)
        Me.checkNombre.Name = "checkNombre"
        Me.checkNombre.Size = New System.Drawing.Size(15, 14)
        Me.checkNombre.TabIndex = 2
        Me.checkNombre.TabStop = False
        Me.checkNombre.UseVisualStyleBackColor = True
        '
        'checkID
        '
        Me.checkID.AutoSize = True
        Me.checkID.Location = New System.Drawing.Point(112, 60)
        Me.checkID.Name = "checkID"
        Me.checkID.Size = New System.Drawing.Size(15, 14)
        Me.checkID.TabIndex = 2
        Me.checkID.TabStop = False
        Me.checkID.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(496, 40)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "ID de Contenedor:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Tipo:"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(9, 56)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 20)
        Me.txtID.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(249, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Origen:"
        '
        'txtOrigen
        '
        Me.txtOrigen.Enabled = False
        Me.txtOrigen.Location = New System.Drawing.Point(252, 56)
        Me.txtOrigen.Name = "txtOrigen"
        Me.txtOrigen.Size = New System.Drawing.Size(100, 20)
        Me.txtOrigen.TabIndex = 3
        '
        'txtIDContenedor
        '
        Me.txtIDContenedor.Enabled = False
        Me.txtIDContenedor.Location = New System.Drawing.Point(499, 56)
        Me.txtIDContenedor.Name = "txtIDContenedor"
        Me.txtIDContenedor.Size = New System.Drawing.Size(100, 20)
        Me.txtIDContenedor.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(128, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(375, 56)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.Size = New System.Drawing.Size(100, 20)
        Me.txtTipo.TabIndex = 4
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
        'FormConsultaProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(710, 514)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.radioVino)
        Me.Controls.Add(Me.radioUva)
        Me.Controls.Add(Me.radioMosto)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoVino)
        Me.Controls.Add(Me.grupoMosto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(726, 553)
        Me.MinimumSize = New System.Drawing.Size(726, 553)
        Me.Name = "FormConsultaProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Productos"
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupoVino.ResumeLayout(False)
        Me.grupoVino.PerformLayout()
        Me.grupoMosto.ResumeLayout(False)
        Me.grupoMosto.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents radioVino As System.Windows.Forms.RadioButton
    Friend WithEvents radioUva As System.Windows.Forms.RadioButton
    Friend WithEvents radioMosto As System.Windows.Forms.RadioButton
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grupoVino As System.Windows.Forms.GroupBox
    Friend WithEvents checkAnioVino As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAnioVino As System.Windows.Forms.TextBox
    Friend WithEvents grupoMosto As System.Windows.Forms.GroupBox
    Friend WithEvents checkCepa As System.Windows.Forms.CheckBox
    Friend WithEvents checkAnioMosto As System.Windows.Forms.CheckBox
    Friend WithEvents txtCepa As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAnioMosto As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNom As System.Windows.Forms.TextBox
    Friend WithEvents checkIDContenedor As System.Windows.Forms.CheckBox
    Friend WithEvents checkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents checkOrigen As System.Windows.Forms.CheckBox
    Friend WithEvents checkNombre As System.Windows.Forms.CheckBox
    Friend WithEvents checkID As System.Windows.Forms.CheckBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtOrigen As System.Windows.Forms.TextBox
    Friend WithEvents txtIDContenedor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
