<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormActividadProducto
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
        Me.txtIDProd1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIDCont1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDProc1 = New System.Windows.Forms.TextBox()
        Me.grupoActual = New System.Windows.Forms.GroupBox()
        Me.txtNomproc = New System.Windows.Forms.TextBox()
        Me.txtEstado1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtUnid1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCant1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grupoActualizado = New System.Windows.Forms.GroupBox()
        Me.cmbCont = New System.Windows.Forms.ComboBox()
        Me.cmbProceso = New System.Windows.Forms.ComboBox()
        Me.txtEstado2 = New System.Windows.Forms.TextBox()
        Me.txtIDProc2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUnid2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCant2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnConsultaProd = New System.Windows.Forms.Button()
        Me.btnConsultaProc = New System.Windows.Forms.Button()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnTrasiego = New System.Windows.Forms.Button()
        Me.btnContenedores = New System.Windows.Forms.Button()
        Me.grupoActual.SuspendLayout()
        Me.grupoActualizado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID de Producto:"
        '
        'txtIDProd1
        '
        Me.txtIDProd1.Location = New System.Drawing.Point(9, 44)
        Me.txtIDProd1.Name = "txtIDProd1"
        Me.txtIDProd1.Size = New System.Drawing.Size(100, 20)
        Me.txtIDProd1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "ID de Contenedor:"
        '
        'txtIDCont1
        '
        Me.txtIDCont1.Enabled = False
        Me.txtIDCont1.Location = New System.Drawing.Point(8, 84)
        Me.txtIDCont1.Name = "txtIDCont1"
        Me.txtIDCont1.Size = New System.Drawing.Size(100, 20)
        Me.txtIDCont1.TabIndex = 90
        Me.txtIDCont1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ID de Proceso:"
        '
        'txtIDProc1
        '
        Me.txtIDProc1.Enabled = False
        Me.txtIDProc1.Location = New System.Drawing.Point(11, 202)
        Me.txtIDProc1.Name = "txtIDProc1"
        Me.txtIDProc1.Size = New System.Drawing.Size(100, 20)
        Me.txtIDProc1.TabIndex = 1
        Me.txtIDProc1.TabStop = False
        '
        'grupoActual
        '
        Me.grupoActual.Controls.Add(Me.Label1)
        Me.grupoActual.Controls.Add(Me.txtNomproc)
        Me.grupoActual.Controls.Add(Me.txtEstado1)
        Me.grupoActual.Controls.Add(Me.txtIDProc1)
        Me.grupoActual.Controls.Add(Me.Label5)
        Me.grupoActual.Controls.Add(Me.txtUnid1)
        Me.grupoActual.Controls.Add(Me.Label4)
        Me.grupoActual.Controls.Add(Me.txtCant1)
        Me.grupoActual.Controls.Add(Me.Label2)
        Me.grupoActual.Controls.Add(Me.txtIDCont1)
        Me.grupoActual.Controls.Add(Me.Label12)
        Me.grupoActual.Controls.Add(Me.Label3)
        Me.grupoActual.Controls.Add(Me.Label11)
        Me.grupoActual.Controls.Add(Me.txtIDProd1)
        Me.grupoActual.Location = New System.Drawing.Point(12, 12)
        Me.grupoActual.Name = "grupoActual"
        Me.grupoActual.Size = New System.Drawing.Size(126, 277)
        Me.grupoActual.TabIndex = 2
        Me.grupoActual.TabStop = False
        Me.grupoActual.Text = "Estado Actual:"
        '
        'txtNomproc
        '
        Me.txtNomproc.Enabled = False
        Me.txtNomproc.Location = New System.Drawing.Point(12, 163)
        Me.txtNomproc.Name = "txtNomproc"
        Me.txtNomproc.Size = New System.Drawing.Size(100, 20)
        Me.txtNomproc.TabIndex = 1
        Me.txtNomproc.TabStop = False
        '
        'txtEstado1
        '
        Me.txtEstado1.Enabled = False
        Me.txtEstado1.Location = New System.Drawing.Point(9, 241)
        Me.txtEstado1.Name = "txtEstado1"
        Me.txtEstado1.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado1.TabIndex = 1
        Me.txtEstado1.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(64, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Unidad:"
        '
        'txtUnid1
        '
        Me.txtUnid1.Enabled = False
        Me.txtUnid1.Location = New System.Drawing.Point(67, 124)
        Me.txtUnid1.Name = "txtUnid1"
        Me.txtUnid1.Size = New System.Drawing.Size(41, 20)
        Me.txtUnid1.TabIndex = 90
        Me.txtUnid1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Cantidad:"
        '
        'txtCant1
        '
        Me.txtCant1.Enabled = False
        Me.txtCant1.Location = New System.Drawing.Point(9, 124)
        Me.txtCant1.Name = "txtCant1"
        Me.txtCant1.Size = New System.Drawing.Size(41, 20)
        Me.txtCant1.TabIndex = 90
        Me.txtCant1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 225)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Estado del Producto:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(8, 147)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Nombre de Proceso:"
        '
        'grupoActualizado
        '
        Me.grupoActualizado.Controls.Add(Me.cmbCont)
        Me.grupoActualizado.Controls.Add(Me.cmbProceso)
        Me.grupoActualizado.Controls.Add(Me.txtEstado2)
        Me.grupoActualizado.Controls.Add(Me.txtIDProc2)
        Me.grupoActualizado.Controls.Add(Me.Label7)
        Me.grupoActualizado.Controls.Add(Me.txtUnid2)
        Me.grupoActualizado.Controls.Add(Me.Label8)
        Me.grupoActualizado.Controls.Add(Me.txtCant2)
        Me.grupoActualizado.Controls.Add(Me.Label9)
        Me.grupoActualizado.Controls.Add(Me.Label13)
        Me.grupoActualizado.Controls.Add(Me.Label10)
        Me.grupoActualizado.Controls.Add(Me.Label6)
        Me.grupoActualizado.Location = New System.Drawing.Point(188, 39)
        Me.grupoActualizado.Name = "grupoActualizado"
        Me.grupoActualizado.Size = New System.Drawing.Size(126, 234)
        Me.grupoActualizado.TabIndex = 2
        Me.grupoActualizado.TabStop = False
        Me.grupoActualizado.Text = "Estado actualizado:"
        '
        'cmbCont
        '
        Me.cmbCont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCont.Enabled = False
        Me.cmbCont.FormattingEnabled = True
        Me.cmbCont.Location = New System.Drawing.Point(9, 43)
        Me.cmbCont.Name = "cmbCont"
        Me.cmbCont.Size = New System.Drawing.Size(101, 21)
        Me.cmbCont.TabIndex = 3
        '
        'cmbProceso
        '
        Me.cmbProceso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProceso.Enabled = False
        Me.cmbProceso.FormattingEnabled = True
        Me.cmbProceso.Location = New System.Drawing.Point(9, 123)
        Me.cmbProceso.Name = "cmbProceso"
        Me.cmbProceso.Size = New System.Drawing.Size(101, 21)
        Me.cmbProceso.TabIndex = 6
        '
        'txtEstado2
        '
        Me.txtEstado2.Enabled = False
        Me.txtEstado2.Location = New System.Drawing.Point(10, 201)
        Me.txtEstado2.Name = "txtEstado2"
        Me.txtEstado2.Size = New System.Drawing.Size(100, 20)
        Me.txtEstado2.TabIndex = 8
        '
        'txtIDProc2
        '
        Me.txtIDProc2.Enabled = False
        Me.txtIDProc2.Location = New System.Drawing.Point(10, 162)
        Me.txtIDProc2.Name = "txtIDProc2"
        Me.txtIDProc2.Size = New System.Drawing.Size(100, 20)
        Me.txtIDProc2.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(65, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Unidad:"
        '
        'txtUnid2
        '
        Me.txtUnid2.Enabled = False
        Me.txtUnid2.Location = New System.Drawing.Point(68, 84)
        Me.txtUnid2.Name = "txtUnid2"
        Me.txtUnid2.Size = New System.Drawing.Size(41, 20)
        Me.txtUnid2.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Cantidad:"
        '
        'txtCant2
        '
        Me.txtCant2.Enabled = False
        Me.txtCant2.Location = New System.Drawing.Point(10, 84)
        Me.txtCant2.Name = "txtCant2"
        Me.txtCant2.Size = New System.Drawing.Size(41, 20)
        Me.txtCant2.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 27)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(94, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "ID de Contenedor:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 185)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(106, 13)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Estado del Producto:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 146)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "ID de Proceso:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Nombre de Proceso:"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Enabled = False
        Me.btnConfirmar.Location = New System.Drawing.Point(337, 94)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 9
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(337, 152)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnConsultaProd
        '
        Me.btnConsultaProd.Location = New System.Drawing.Point(12, 324)
        Me.btnConsultaProd.Name = "btnConsultaProd"
        Me.btnConsultaProd.Size = New System.Drawing.Size(75, 39)
        Me.btnConsultaProd.TabIndex = 12
        Me.btnConsultaProd.Text = "Consultar Pro&ductos"
        Me.btnConsultaProd.UseVisualStyleBackColor = True
        '
        'btnConsultaProc
        '
        Me.btnConsultaProc.Location = New System.Drawing.Point(93, 324)
        Me.btnConsultaProc.Name = "btnConsultaProc"
        Me.btnConsultaProc.Size = New System.Drawing.Size(75, 39)
        Me.btnConsultaProc.TabIndex = 13
        Me.btnConsultaProc.Text = "Consultar &Procesos"
        Me.btnConsultaProc.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(337, 65)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnTrasiego
        '
        Me.btnTrasiego.Enabled = False
        Me.btnTrasiego.Location = New System.Drawing.Point(337, 123)
        Me.btnTrasiego.Name = "btnTrasiego"
        Me.btnTrasiego.Size = New System.Drawing.Size(75, 23)
        Me.btnTrasiego.TabIndex = 11
        Me.btnTrasiego.Text = "Trasiego"
        Me.btnTrasiego.UseVisualStyleBackColor = True
        '
        'btnContenedores
        '
        Me.btnContenedores.Location = New System.Drawing.Point(174, 324)
        Me.btnContenedores.Name = "btnContenedores"
        Me.btnContenedores.Size = New System.Drawing.Size(82, 39)
        Me.btnContenedores.TabIndex = 14
        Me.btnContenedores.Text = "Consultar &Contenedores"
        Me.btnContenedores.UseVisualStyleBackColor = True
        '
        'FormActividadProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(424, 375)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnContenedores)
        Me.Controls.Add(Me.btnConsultaProc)
        Me.Controls.Add(Me.btnConsultaProd)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnTrasiego)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.grupoActualizado)
        Me.Controls.Add(Me.grupoActual)
        Me.MaximumSize = New System.Drawing.Size(440, 414)
        Me.MinimumSize = New System.Drawing.Size(440, 414)
        Me.Name = "FormActividadProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Movimiento de Productos"
        Me.grupoActual.ResumeLayout(False)
        Me.grupoActual.PerformLayout()
        Me.grupoActualizado.ResumeLayout(False)
        Me.grupoActualizado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtIDProd1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIDCont1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDProc1 As System.Windows.Forms.TextBox
    Friend WithEvents grupoActual As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUnid1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCant1 As System.Windows.Forms.TextBox
    Friend WithEvents grupoActualizado As System.Windows.Forms.GroupBox
    Friend WithEvents txtIDProc2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtUnid2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCant2 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnConsultaProd As System.Windows.Forms.Button
    Friend WithEvents btnConsultaProc As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtNomproc As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbProceso As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtEstado1 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtEstado2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnTrasiego As System.Windows.Forms.Button
    Friend WithEvents btnContenedores As System.Windows.Forms.Button
    Friend WithEvents cmbCont As System.Windows.Forms.ComboBox
End Class
