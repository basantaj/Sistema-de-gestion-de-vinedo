<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormObservadores
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
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbProcesosAObservar = New System.Windows.Forms.ComboBox()
        Me.btnObservacionConfirmar = New System.Windows.Forms.Button()
        Me.btnAlerta = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIDProd = New System.Windows.Forms.TextBox()
        Me.btnConsulProd = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtIDContenedor = New System.Windows.Forms.TextBox()
        Me.txtpH = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAzucar = New System.Windows.Forms.TextBox()
        Me.btnProcesos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtObservacion
        '
        Me.txtObservacion.Location = New System.Drawing.Point(26, 58)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(443, 125)
        Me.txtObservacion.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ingresar observación respecto a "
        '
        'cmbProcesosAObservar
        '
        Me.cmbProcesosAObservar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProcesosAObservar.FormattingEnabled = True
        Me.cmbProcesosAObservar.Location = New System.Drawing.Point(191, 26)
        Me.cmbProcesosAObservar.Name = "cmbProcesosAObservar"
        Me.cmbProcesosAObservar.Size = New System.Drawing.Size(121, 21)
        Me.cmbProcesosAObservar.TabIndex = 1
        '
        'btnObservacionConfirmar
        '
        Me.btnObservacionConfirmar.Location = New System.Drawing.Point(488, 200)
        Me.btnObservacionConfirmar.Name = "btnObservacionConfirmar"
        Me.btnObservacionConfirmar.Size = New System.Drawing.Size(147, 23)
        Me.btnObservacionConfirmar.TabIndex = 7
        Me.btnObservacionConfirmar.Text = "Confirmar Observación"
        Me.btnObservacionConfirmar.UseVisualStyleBackColor = True
        '
        'btnAlerta
        '
        Me.btnAlerta.Location = New System.Drawing.Point(335, 200)
        Me.btnAlerta.Name = "btnAlerta"
        Me.btnAlerta.Size = New System.Drawing.Size(147, 23)
        Me.btnAlerta.TabIndex = 8
        Me.btnAlerta.Text = "Programar como Alerta"
        Me.btnAlerta.UseVisualStyleBackColor = True
        Me.btnAlerta.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "para producto de ID "
        '
        'txtIDProd
        '
        Me.txtIDProd.Location = New System.Drawing.Point(420, 26)
        Me.txtIDProd.Name = "txtIDProd"
        Me.txtIDProd.Size = New System.Drawing.Size(49, 20)
        Me.txtIDProd.TabIndex = 2
        '
        'btnConsulProd
        '
        Me.btnConsulProd.Location = New System.Drawing.Point(26, 193)
        Me.btnConsulProd.Name = "btnConsulProd"
        Me.btnConsulProd.Size = New System.Drawing.Size(75, 36)
        Me.btnConsulProd.TabIndex = 10
        Me.btnConsulProd.Text = "Mostrar productos"
        Me.btnConsulProd.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(475, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "en contenedor de ID"
        '
        'txtIDContenedor
        '
        Me.txtIDContenedor.Location = New System.Drawing.Point(586, 26)
        Me.txtIDContenedor.Name = "txtIDContenedor"
        Me.txtIDContenedor.Size = New System.Drawing.Size(49, 20)
        Me.txtIDContenedor.TabIndex = 3
        '
        'txtpH
        '
        Me.txtpH.Location = New System.Drawing.Point(504, 77)
        Me.txtpH.Name = "txtpH"
        Me.txtpH.Size = New System.Drawing.Size(105, 20)
        Me.txtpH.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(501, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Valor de pH:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(501, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nivel de Azúcar:"
        '
        'txtAzucar
        '
        Me.txtAzucar.Location = New System.Drawing.Point(504, 116)
        Me.txtAzucar.Name = "txtAzucar"
        Me.txtAzucar.Size = New System.Drawing.Size(105, 20)
        Me.txtAzucar.TabIndex = 5
        '
        'btnProcesos
        '
        Me.btnProcesos.Location = New System.Drawing.Point(107, 193)
        Me.btnProcesos.Name = "btnProcesos"
        Me.btnProcesos.Size = New System.Drawing.Size(75, 36)
        Me.btnProcesos.TabIndex = 9
        Me.btnProcesos.Text = "Mostrar procesos activos"
        Me.btnProcesos.UseVisualStyleBackColor = True
        '
        'FormObservadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(653, 280)
        Me.Controls.Add(Me.txtAzucar)
        Me.Controls.Add(Me.txtpH)
        Me.Controls.Add(Me.txtIDContenedor)
        Me.Controls.Add(Me.txtIDProd)
        Me.Controls.Add(Me.btnProcesos)
        Me.Controls.Add(Me.btnConsulProd)
        Me.Controls.Add(Me.btnAlerta)
        Me.Controls.Add(Me.btnObservacionConfirmar)
        Me.Controls.Add(Me.cmbProcesosAObservar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtObservacion)
        Me.MaximumSize = New System.Drawing.Size(669, 319)
        Me.MinimumSize = New System.Drawing.Size(669, 319)
        Me.Name = "FormObservadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Panel de [cargo]"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbProcesosAObservar As System.Windows.Forms.ComboBox
    Friend WithEvents btnObservacionConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnAlerta As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIDProd As System.Windows.Forms.TextBox
    Friend WithEvents btnConsulProd As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtIDContenedor As System.Windows.Forms.TextBox
    Friend WithEvents txtpH As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAzucar As System.Windows.Forms.TextBox
    Friend WithEvents btnProcesos As System.Windows.Forms.Button
End Class
