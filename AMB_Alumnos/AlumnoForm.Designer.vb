<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlumnoForm
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
        Me.nya = New System.Windows.Forms.Label
        Me.dni = New System.Windows.Forms.Label
        Me.nacimiento = New System.Windows.Forms.Label
        Me.edad = New System.Windows.Forms.Label
        Me.mail = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.TextBox5 = New System.Windows.Forms.TextBox
        Me.Cancelar = New System.Windows.Forms.Button
        Me.Aceptar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'nya
        '
        Me.nya.AutoSize = True
        Me.nya.Location = New System.Drawing.Point(29, 16)
        Me.nya.Name = "nya"
        Me.nya.Size = New System.Drawing.Size(95, 13)
        Me.nya.TabIndex = 0
        Me.nya.Text = "Apellido y Nombre:"
        '
        'dni
        '
        Me.dni.AutoSize = True
        Me.dni.Location = New System.Drawing.Point(95, 42)
        Me.dni.Name = "dni"
        Me.dni.Size = New System.Drawing.Size(29, 13)
        Me.dni.TabIndex = 1
        Me.dni.Text = "DNI:"
        '
        'nacimiento
        '
        Me.nacimiento.AutoSize = True
        Me.nacimiento.Location = New System.Drawing.Point(13, 68)
        Me.nacimiento.Name = "nacimiento"
        Me.nacimiento.Size = New System.Drawing.Size(111, 13)
        Me.nacimiento.TabIndex = 2
        Me.nacimiento.Text = "Fecha de Nacimiento:"
        '
        'edad
        '
        Me.edad.AutoSize = True
        Me.edad.Location = New System.Drawing.Point(89, 94)
        Me.edad.Name = "edad"
        Me.edad.Size = New System.Drawing.Size(35, 13)
        Me.edad.TabIndex = 3
        Me.edad.Text = "Edad:"
        '
        'mail
        '
        Me.mail.AutoSize = True
        Me.mail.Location = New System.Drawing.Point(95, 120)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(29, 13)
        Me.mail.TabIndex = 4
        Me.mail.Text = "Mail:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(144, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(158, 20)
        Me.TextBox1.TabIndex = 5
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(144, 39)
        Me.TextBox2.MaxLength = 10
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(158, 20)
        Me.TextBox2.TabIndex = 6
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(144, 65)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(158, 20)
        Me.TextBox3.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(144, 91)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(158, 20)
        Me.TextBox4.TabIndex = 8
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(144, 117)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(158, 20)
        Me.TextBox5.TabIndex = 9
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(226, 146)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 10
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'Aceptar
        '
        Me.Aceptar.Location = New System.Drawing.Point(145, 145)
        Me.Aceptar.Name = "Aceptar"
        Me.Aceptar.Size = New System.Drawing.Size(75, 23)
        Me.Aceptar.TabIndex = 11
        Me.Aceptar.Text = "Aceptar"
        Me.Aceptar.UseVisualStyleBackColor = True
        '
        'AlumnoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 181)
        Me.Controls.Add(Me.Aceptar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.mail)
        Me.Controls.Add(Me.edad)
        Me.Controls.Add(Me.nacimiento)
        Me.Controls.Add(Me.dni)
        Me.Controls.Add(Me.nya)
        Me.Name = "AlumnoForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AlumnoForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents nya As System.Windows.Forms.Label
    Friend WithEvents dni As System.Windows.Forms.Label
    Friend WithEvents nacimiento As System.Windows.Forms.Label
    Friend WithEvents edad As System.Windows.Forms.Label
    Friend WithEvents mail As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Cancelar As System.Windows.Forms.Button
    Friend WithEvents Aceptar As System.Windows.Forms.Button

End Class
