<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDashboard
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
        GroupBox1 = New GroupBox()
        btn_usuarios = New Button()
        btn_consultas = New Button()
        btn_especialidades = New Button()
        btn_doctores = New Button()
        bnt_personas = New Button()
        btn_salir = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_usuarios)
        GroupBox1.Controls.Add(btn_consultas)
        GroupBox1.Controls.Add(btn_especialidades)
        GroupBox1.Controls.Add(btn_doctores)
        GroupBox1.Controls.Add(bnt_personas)
        GroupBox1.Location = New Point(70, 30)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(654, 335)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Seleccione una opción"
        ' 
        ' btn_usuarios
        ' 
        btn_usuarios.Location = New Point(449, 245)
        btn_usuarios.Name = "btn_usuarios"
        btn_usuarios.Size = New Size(149, 59)
        btn_usuarios.TabIndex = 4
        btn_usuarios.Text = "Personas"
        btn_usuarios.UseVisualStyleBackColor = True
        ' 
        ' btn_consultas
        ' 
        btn_consultas.Location = New Point(82, 245)
        btn_consultas.Name = "btn_consultas"
        btn_consultas.Size = New Size(149, 59)
        btn_consultas.TabIndex = 3
        btn_consultas.Text = "Personas"
        btn_consultas.UseVisualStyleBackColor = True
        ' 
        ' btn_especialidades
        ' 
        btn_especialidades.Location = New Point(252, 160)
        btn_especialidades.Name = "btn_especialidades"
        btn_especialidades.Size = New Size(149, 59)
        btn_especialidades.TabIndex = 2
        btn_especialidades.Text = "Especialidades"
        btn_especialidades.UseVisualStyleBackColor = True
        ' 
        ' btn_doctores
        ' 
        btn_doctores.Location = New Point(415, 67)
        btn_doctores.Name = "btn_doctores"
        btn_doctores.Size = New Size(149, 59)
        btn_doctores.TabIndex = 1
        btn_doctores.Text = "Doctores"
        btn_doctores.UseVisualStyleBackColor = True
        ' 
        ' bnt_personas
        ' 
        bnt_personas.Location = New Point(82, 67)
        bnt_personas.Name = "bnt_personas"
        bnt_personas.Size = New Size(149, 59)
        bnt_personas.TabIndex = 0
        bnt_personas.Text = "Personas"
        bnt_personas.UseVisualStyleBackColor = True
        ' 
        ' btn_salir
        ' 
        btn_salir.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btn_salir.Location = New Point(575, 371)
        btn_salir.Name = "btn_salir"
        btn_salir.Size = New Size(149, 59)
        btn_salir.TabIndex = 1
        btn_salir.Text = "Salir del Sistema"
        btn_salir.UseVisualStyleBackColor = False
        ' 
        ' frmDashboard
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btn_salir)
        Controls.Add(GroupBox1)
        Name = "frmDashboard"
        Text = "frmDashboard"
        GroupBox1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_usuarios As Button
    Friend WithEvents btn_consultas As Button
    Friend WithEvents btn_especialidades As Button
    Friend WithEvents btn_doctores As Button
    Friend WithEvents bnt_personas As Button
    Friend WithEvents btn_salir As Button
End Class
