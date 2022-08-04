<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BtnRojo = New System.Windows.Forms.Button()
        Me.BtnNaranja = New System.Windows.Forms.Button()
        Me.BtnVerde = New System.Windows.Forms.Button()
        Me.BtnAmarillo = New System.Windows.Forms.Button()
        Me.BtnAzul = New System.Windows.Forms.Button()
        Me.TxtColores = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnRojo
        '
        Me.BtnRojo.BackColor = System.Drawing.Color.Red
        Me.BtnRojo.Location = New System.Drawing.Point(39, 33)
        Me.BtnRojo.Name = "BtnRojo"
        Me.BtnRojo.Size = New System.Drawing.Size(139, 67)
        Me.BtnRojo.TabIndex = 0
        Me.BtnRojo.Text = "Rojo"
        Me.BtnRojo.UseVisualStyleBackColor = False
        '
        'BtnNaranja
        '
        Me.BtnNaranja.BackColor = System.Drawing.Color.Orange
        Me.BtnNaranja.Location = New System.Drawing.Point(39, 106)
        Me.BtnNaranja.Name = "BtnNaranja"
        Me.BtnNaranja.Size = New System.Drawing.Size(139, 67)
        Me.BtnNaranja.TabIndex = 1
        Me.BtnNaranja.Text = "Naranja"
        Me.BtnNaranja.UseVisualStyleBackColor = False
        '
        'BtnVerde
        '
        Me.BtnVerde.BackColor = System.Drawing.Color.Green
        Me.BtnVerde.Location = New System.Drawing.Point(39, 179)
        Me.BtnVerde.Name = "BtnVerde"
        Me.BtnVerde.Size = New System.Drawing.Size(139, 67)
        Me.BtnVerde.TabIndex = 2
        Me.BtnVerde.Text = "Verde"
        Me.BtnVerde.UseVisualStyleBackColor = False
        '
        'BtnAmarillo
        '
        Me.BtnAmarillo.BackColor = System.Drawing.Color.Yellow
        Me.BtnAmarillo.Location = New System.Drawing.Point(39, 252)
        Me.BtnAmarillo.Name = "BtnAmarillo"
        Me.BtnAmarillo.Size = New System.Drawing.Size(139, 67)
        Me.BtnAmarillo.TabIndex = 3
        Me.BtnAmarillo.Text = "Amarillo"
        Me.BtnAmarillo.UseVisualStyleBackColor = False
        '
        'BtnAzul
        '
        Me.BtnAzul.BackColor = System.Drawing.Color.Blue
        Me.BtnAzul.Location = New System.Drawing.Point(39, 325)
        Me.BtnAzul.Name = "BtnAzul"
        Me.BtnAzul.Size = New System.Drawing.Size(139, 67)
        Me.BtnAzul.TabIndex = 4
        Me.BtnAzul.Text = "Azul"
        Me.BtnAzul.UseVisualStyleBackColor = False
        '
        'TxtColores
        '
        Me.TxtColores.Location = New System.Drawing.Point(215, 62)
        Me.TxtColores.Multiline = True
        Me.TxtColores.Name = "TxtColores"
        Me.TxtColores.Size = New System.Drawing.Size(543, 303)
        Me.TxtColores.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkSalmon
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TxtColores)
        Me.Controls.Add(Me.BtnAzul)
        Me.Controls.Add(Me.BtnAmarillo)
        Me.Controls.Add(Me.BtnVerde)
        Me.Controls.Add(Me.BtnNaranja)
        Me.Controls.Add(Me.BtnRojo)
        Me.Name = "Form1"
        Me.Text = "Colores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRojo As Button
    Friend WithEvents BtnNaranja As Button
    Friend WithEvents BtnVerde As Button
    Friend WithEvents BtnAmarillo As Button
    Friend WithEvents BtnAzul As Button
    Friend WithEvents TxtColores As TextBox
End Class
