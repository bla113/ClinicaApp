<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GroupBox1 = New GroupBox()
        btn_crear_cuenta = New Button()
        btn_ingresar = New Button()
        txt_password = New TextBox()
        txt_correo = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(btn_crear_cuenta)
        GroupBox1.Controls.Add(btn_ingresar)
        GroupBox1.Controls.Add(txt_password)
        GroupBox1.Controls.Add(txt_correo)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GroupBox1.Location = New Point(62, 21)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(594, 383)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Ingresar al Sistema"
        ' 
        ' btn_crear_cuenta
        ' 
        btn_crear_cuenta.Location = New Point(60, 264)
        btn_crear_cuenta.Name = "btn_crear_cuenta"
        btn_crear_cuenta.Size = New Size(226, 68)
        btn_crear_cuenta.TabIndex = 5
        btn_crear_cuenta.Text = "Creaer Cuenta"
        btn_crear_cuenta.UseVisualStyleBackColor = True
        ' 
        ' btn_ingresar
        ' 
        btn_ingresar.Location = New Point(335, 264)
        btn_ingresar.Name = "btn_ingresar"
        btn_ingresar.Size = New Size(226, 68)
        btn_ingresar.TabIndex = 4
        btn_ingresar.Text = "Ingresar"
        btn_ingresar.UseVisualStyleBackColor = True
        ' 
        ' txt_password
        ' 
        txt_password.Location = New Point(318, 194)
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(687, 450)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents txt_correo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_crear_cuenta As Button
    Friend WithEvents btn_ingresar As Button

End Class
