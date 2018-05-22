<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoGrid
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.nuevo = New System.Windows.Forms.Button
        Me.elimina = New System.Windows.Forms.Button
        Me.salir = New System.Windows.Forms.Button
        Me.modifica = New System.Windows.Forms.Button
        Me.NyaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NacimientoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AlumnoColectionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AlumnoColectionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NyaDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.NacimientoDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.DniDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.AlumnoColectionBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(544, 212)
        Me.DataGridView1.TabIndex = 0
        '
        'nuevo
        '
        Me.nuevo.Location = New System.Drawing.Point(232, 230)
        Me.nuevo.Name = "nuevo"
        Me.nuevo.Size = New System.Drawing.Size(75, 23)
        Me.nuevo.TabIndex = 1
        Me.nuevo.Text = "Nuevo"
        Me.nuevo.UseVisualStyleBackColor = True
        '
        'elimina
        '
        Me.elimina.Location = New System.Drawing.Point(313, 230)
        Me.elimina.Name = "elimina"
        Me.elimina.Size = New System.Drawing.Size(75, 23)
        Me.elimina.TabIndex = 2
        Me.elimina.Text = "Elimina"
        Me.elimina.UseVisualStyleBackColor = True
        '
        'salir
        '
        Me.salir.Location = New System.Drawing.Point(475, 230)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(75, 23)
        Me.salir.TabIndex = 3
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = True
        '
        'modifica
        '
        Me.modifica.Location = New System.Drawing.Point(394, 230)
        Me.modifica.Name = "modifica"
        Me.modifica.Size = New System.Drawing.Size(75, 23)
        Me.modifica.TabIndex = 4
        Me.modifica.Text = "Modifica"
        Me.modifica.UseVisualStyleBackColor = True
        '
        'NyaDataGridViewTextBoxColumn
        '
        Me.NyaDataGridViewTextBoxColumn.DataPropertyName = "nya"
        Me.NyaDataGridViewTextBoxColumn.HeaderText = "nya"
        Me.NyaDataGridViewTextBoxColumn.Name = "NyaDataGridViewTextBoxColumn"
        Me.NyaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NacimientoDataGridViewTextBoxColumn
        '
        Me.NacimientoDataGridViewTextBoxColumn.DataPropertyName = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.HeaderText = "nacimiento"
        Me.NacimientoDataGridViewTextBoxColumn.Name = "NacimientoDataGridViewTextBoxColumn"
        Me.NacimientoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DniDataGridViewTextBoxColumn
        '
        Me.DniDataGridViewTextBoxColumn.DataPropertyName = "dni"
        Me.DniDataGridViewTextBoxColumn.HeaderText = "dni"
        Me.DniDataGridViewTextBoxColumn.Name = "DniDataGridViewTextBoxColumn"
        Me.DniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AlumnoColectionBindingSource
        '
        Me.AlumnoColectionBindingSource.DataSource = GetType(AMB_Alumnos.AlumnoColection)
        '
        'AlumnoGrid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 267)
        Me.Controls.Add(Me.modifica)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.elimina)
        Me.Controls.Add(Me.nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "AlumnoGrid"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grilla Alumnos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AlumnoColectionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents nuevo As System.Windows.Forms.Button
    Friend WithEvents elimina As System.Windows.Forms.Button
    Friend WithEvents salir As System.Windows.Forms.Button
    Friend WithEvents modifica As System.Windows.Forms.Button
    Friend WithEvents NyaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NacimientoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlumnoColectionBindingSource As System.Windows.Forms.BindingSource
End Class
