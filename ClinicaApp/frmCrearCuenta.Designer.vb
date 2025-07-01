<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCrearCuenta
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
        cbo_tipo_usuario = New ComboBox()
        Label4 = New Label()
        txt_nombre = New TextBox()
        Label3 = New Label()
        btn_guardar = New Button()
        btn_regresar = New Button()
        txt_password = New TextBox()
        txt_correo = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(cbo_tipo_usuario)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(txt_nombre)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(btn_guardar)
        GroupBox1.Controls.Add(btn_regresar)
        GroupBox1.Controls.Add(txt_password)
        GroupBox1.Controls.Add(txt_correo)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(103, 119)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(594, 469)
        GroupBox1.TabIndex = 1
        GroupBox1.TabStop = False
        GroupBox1.Text = "Crear Cuente"
        ' 
        ' cbo_tipo_usuario
        ' 
        cbo_tipo_usuario.FormattingEnabled = True
        cbo_tipo_usuario.Items.AddRange(New Object() {"Administrador", "Paciente", "Doctor", "Soporte"})
        cbo_tipo_usuario.Location = New Point(313, 277)
        cbo_tipo_usuario.Name = "cbo_tipo_usuario"
        cbo_tipo_usuario.Size = New Size(248, 45)
        cbo_tipo_usuario.TabIndex = 9
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(77, 277)
        Label4.Name = "Label4"
        Label4.Size = New Size(231, 38)
        Label4.TabIndex = 8
        Label4.Text = "Tipo de Usuario:"
        ' 
        ' txt_nombre
        ' 
        txt_nombre.Location = New Point(318, 55)
        txt_nombre.Name = "txt_nombre"
        txt_nombre.Size = New Size(243, 43)
        txt_nombre.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(179, 60)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 38)
        Label3.TabIndex = 6
        Label3.Text = "Nombre:"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Location = New Point(313, 350)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(248, 68)
        btn_guardar.TabIndex = 5
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' btn_regresar
        ' 
        btn_regresar.Location = New Point(60, 350)
        btn_regresar.Name = "btn_regresar"
        btn_regresar.Size = New Size(226, 68)
        btn_regresar.TabIndex = 4
        btn_regresar.Text = "Regresar"
        btn_regresar.UseVisualStyleBackColor = True
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(318, 199)
        txt_password.Name = "txt_password"
        txt_password.PasswordChar = "*"c
        txt_password.Size = New Size(243, 43)
        txt_password.TabIndex = 3
        ' 
        ' txt_correo
        ' 
        txt_correo.Location = New Point(318, 125)
        txt_correo.Name = "txt_correo"
        txt_correo.Size = New Size(243, 43)
        txt_correo.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 199)
        Label2.Name = "Label2"
        Label2.Size = New Size(287, 38)
        Label2.TabIndex = 1
        Label2.Text = "Ingresar Contraseña:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(84, 128)
        Label1.Name = "Label1"
        Label1.Size = New Size(228, 38)
        Label1.TabIndex = 0
        Label1.Text = "Ingresar Correo:"
        ' 
        ' frmCrearCuenta
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 620)
        Controls.Add(GroupBox1)
        Name = "frmCrearCuenta"
        Text = "frmCrearCuenta"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_regresar As Button
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cbo_tipo_usuario As ComboBox
End Class
