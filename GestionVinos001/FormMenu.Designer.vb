<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormMenu
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
        Me.btnExpertos = New System.Windows.Forms.Button()
        Me.btnAdministradores = New System.Windows.Forms.Button()
        Me.btnGerenteSucursal = New System.Windows.Forms.Button()
        Me.btnGerenteGeneral = New System.Windows.Forms.Button()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnEnologo = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExpertos
        '
        Me.btnExpertos.Location = New System.Drawing.Point(8, 59)
        Me.btnExpertos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExpertos.Name = "btnExpertos"
        Me.btnExpertos.Size = New System.Drawing.Size(267, 28)
        Me.btnExpertos.TabIndex = 0
        Me.btnExpertos.Text = "Formulario de Expertos"
        Me.btnExpertos.UseVisualStyleBackColor = True
        '
        'btnAdministradores
        '
        Me.btnAdministradores.Location = New System.Drawing.Point(8, 130)
        Me.btnAdministradores.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdministradores.Name = "btnAdministradores"
        Me.btnAdministradores.Size = New System.Drawing.Size(267, 28)
        Me.btnAdministradores.TabIndex = 0
        Me.btnAdministradores.Text = "Formulario de Administradores"
        Me.btnAdministradores.UseVisualStyleBackColor = True
        '
        'btnGerenteSucursal
        '
        Me.btnGerenteSucursal.Location = New System.Drawing.Point(8, 166)
        Me.btnGerenteSucursal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGerenteSucursal.Name = "btnGerenteSucursal"
        Me.btnGerenteSucursal.Size = New System.Drawing.Size(267, 28)
        Me.btnGerenteSucursal.TabIndex = 0
        Me.btnGerenteSucursal.Text = "Formulario de Gerentes de Sucursal"
        Me.btnGerenteSucursal.UseVisualStyleBackColor = True
        '
        'btnGerenteGeneral
        '
        Me.btnGerenteGeneral.Location = New System.Drawing.Point(8, 202)
        Me.btnGerenteGeneral.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnGerenteGeneral.Name = "btnGerenteGeneral"
        Me.btnGerenteGeneral.Size = New System.Drawing.Size(267, 28)
        Me.btnGerenteGeneral.TabIndex = 0
        Me.btnGerenteGeneral.Text = "Formulario de Gerentes Generales"
        Me.btnGerenteGeneral.UseVisualStyleBackColor = True
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(8, 23)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(267, 28)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Formulario de Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLogin)
        Me.GroupBox1.Controls.Add(Me.btnEnologo)
        Me.GroupBox1.Controls.Add(Me.btnExpertos)
        Me.GroupBox1.Controls.Add(Me.btnGerenteGeneral)
        Me.GroupBox1.Controls.Add(Me.btnAdministradores)
        Me.GroupBox1.Controls.Add(Me.btnGerenteSucursal)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 16)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(293, 246)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formularios"
        '
        'btnEnologo
        '
        Me.btnEnologo.Location = New System.Drawing.Point(8, 95)
        Me.btnEnologo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEnologo.Name = "btnEnologo"
        Me.btnEnologo.Size = New System.Drawing.Size(267, 28)
        Me.btnEnologo.TabIndex = 0
        Me.btnEnologo.Text = "Formulario de Expertos(enólogo)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.btnEnologo.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(25, 270)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(267, 28)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Cerrar"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'FormMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(323, 314)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnSalir)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximumSize = New System.Drawing.Size(341, 359)
        Me.MinimumSize = New System.Drawing.Size(341, 359)
        Me.Name = "FormMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Provisorio"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnExpertos As System.Windows.Forms.Button
    Friend WithEvents btnAdministradores As System.Windows.Forms.Button
    Friend WithEvents btnGerenteSucursal As System.Windows.Forms.Button
    Friend WithEvents btnGerenteGeneral As System.Windows.Forms.Button
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnEnologo As System.Windows.Forms.Button
End Class
