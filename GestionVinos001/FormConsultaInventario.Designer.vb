﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConsultaInventario
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
        Me.btnListado = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.grupoDatos = New System.Windows.Forms.GroupBox()
        Me.checkStock = New System.Windows.Forms.CheckBox()
        Me.checkTipo = New System.Windows.Forms.CheckBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dataGrid = New System.Windows.Forms.DataGridView()
        Me.grupoDatos.SuspendLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnListado
        '
        Me.btnListado.Location = New System.Drawing.Point(182, 76)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(75, 23)
        Me.btnListado.TabIndex = 3
        Me.btnListado.Text = "Listado"
        Me.btnListado.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(182, 126)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 4
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'grupoDatos
        '
        Me.grupoDatos.Controls.Add(Me.checkStock)
        Me.grupoDatos.Controls.Add(Me.checkTipo)
        Me.grupoDatos.Controls.Add(Me.txtTipo)
        Me.grupoDatos.Controls.Add(Me.Label1)
        Me.grupoDatos.Controls.Add(Me.Label2)
        Me.grupoDatos.Controls.Add(Me.txtStock)
        Me.grupoDatos.Location = New System.Drawing.Point(12, 47)
        Me.grupoDatos.Name = "grupoDatos"
        Me.grupoDatos.Size = New System.Drawing.Size(151, 136)
        Me.grupoDatos.TabIndex = 23
        Me.grupoDatos.TabStop = False
        Me.grupoDatos.Text = "Datos del Material"
        '
        'checkStock
        '
        Me.checkStock.AutoSize = True
        Me.checkStock.Location = New System.Drawing.Point(117, 92)
        Me.checkStock.Name = "checkStock"
        Me.checkStock.Size = New System.Drawing.Size(15, 14)
        Me.checkStock.TabIndex = 2
        Me.checkStock.UseVisualStyleBackColor = True
        '
        'checkTipo
        '
        Me.checkTipo.AutoSize = True
        Me.checkTipo.Location = New System.Drawing.Point(117, 53)
        Me.checkTipo.Name = "checkTipo"
        Me.checkTipo.Size = New System.Drawing.Size(15, 14)
        Me.checkTipo.TabIndex = 2
        Me.checkTipo.UseVisualStyleBackColor = True
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
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
        Me.Label2.Location = New System.Drawing.Point(8, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Stock:"
        '
        'txtStock
        '
        Me.txtStock.Enabled = False
        Me.txtStock.Location = New System.Drawing.Point(11, 89)
        Me.txtStock.Name = "txtStock"
        Me.txtStock.Size = New System.Drawing.Size(100, 20)
        Me.txtStock.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(209, 17)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Seleccione los Filtros a Emplear"
        '
        'dataGrid
        '
        Me.dataGrid.AllowUserToAddRows = False
        Me.dataGrid.AllowUserToDeleteRows = False
        Me.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonShadow
        Me.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataGrid.Location = New System.Drawing.Point(12, 189)
        Me.dataGrid.Name = "dataGrid"
        Me.dataGrid.ReadOnly = True
        Me.dataGrid.Size = New System.Drawing.Size(509, 160)
        Me.dataGrid.TabIndex = 27
        '
        'FormConsultaInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(533, 360)
        Me.Controls.Add(Me.dataGrid)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnListado)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.grupoDatos)
        Me.MaximumSize = New System.Drawing.Size(549, 399)
        Me.MinimumSize = New System.Drawing.Size(549, 399)
        Me.Name = "FormConsultaInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultar Inventario"
        Me.grupoDatos.ResumeLayout(False)
        Me.grupoDatos.PerformLayout()
        CType(Me.dataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnListado As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents grupoDatos As System.Windows.Forms.GroupBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtStock As System.Windows.Forms.TextBox
    Friend WithEvents checkStock As System.Windows.Forms.CheckBox
    Friend WithEvents checkTipo As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dataGrid As System.Windows.Forms.DataGridView
End Class