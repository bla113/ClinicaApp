<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEspecialidades
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
        lbl_id = New Label()
        btn_guardar = New Button()
        txt_especialidad = New TextBox()
        Label1 = New Label()
        btn_regresar = New Button()
        dgv_especialidades = New DataGridView()
        btn_guardar_cambios = New Button()
        btn_eliminar = New Button()
        GroupBox1.SuspendLayout()
        CType(dgv_especialidades, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(lbl_id)
        GroupBox1.Controls.Add(btn_guardar)
        GroupBox1.Controls.Add(txt_especialidad)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(82, 31)
        GroupBox1.Margin = New Padding(4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(4)
        GroupBox1.Size = New Size(576, 335)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Agregar especialidades"
        ' 
        ' lbl_id
        ' 
        lbl_id.AutoSize = True
        lbl_id.Location = New Point(82, 169)
        lbl_id.Name = "lbl_id"
        lbl_id.Size = New Size(33, 28)
        lbl_id.TabIndex = 6
        lbl_id.Text = "ID"
        ' 
        ' btn_guardar
        ' 
        btn_guardar.Location = New Point(365, 153)
        btn_guardar.Name = "btn_guardar"
        btn_guardar.Size = New Size(140, 61)
        btn_guardar.TabIndex = 2
        btn_guardar.Text = "Guardar"
        btn_guardar.UseVisualStyleBackColor = True
        ' 
        ' txt_especialidad
        ' 
        txt_especialidad.Location = New Point(165, 112)
        txt_especialidad.Margin = New Padding(4)
        txt_especialidad.Name = "txt_especialidad"
        txt_especialidad.Size = New Size(340, 34)
        txt_especialidad.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(28, 115)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 28)
        Label1.TabIndex = 0
        Label1.Text = "Especialidad"
        ' 
        ' btn_regresar
        ' 
        btn_regresar.Location = New Point(665, 40)
        btn_regresar.Name = "btn_regresar"
        btn_regresar.Size = New Size(140, 61)
        btn_regresar.TabIndex = 3
        btn_regresar.Text = "Regresar"
        btn_regresar.UseVisualStyleBackColor = True
        ' 
        ' dgv_especialidades
        ' 
        dgv_especialidades.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_especialidades.Location = New Point(82, 439)
        dgv_especialidades.Name = "dgv_especialidades"
        dgv_especialidades.RowHeadersWidth = 51
        dgv_especialidades.Size = New Size(576, 188)
        dgv_especialidades.TabIndex = 4
        ' 
        ' btn_guardar_cambios
        ' 
        btn_guardar_cambios.Location = New Point(665, 130)
        btn_guardar_cambios.Name = "btn_guardar_cambios"
        btn_guardar_cambios.Size = New Size(140, 107)
        btn_guardar_cambios.TabIndex = 3
        btn_guardar_cambios.Text = "Guardar Cambios"
        btn_guardar_cambios.UseVisualStyleBackColor = True
        ' 
        ' btn_eliminar
        ' 
        btn_eliminar.Location = New Point(665, 259)
        btn_eliminar.Name = "btn_eliminar"
        btn_eliminar.Size = New Size(140, 107)
        btn_eliminar.TabIndex = 5
        btn_eliminar.Text = "Eliminar Registro"
        btn_eliminar.UseVisualStyleBackColor = True
        ' 
        ' frmEspecialidades
        ' 
        AutoScaleDimensions = New SizeF(12F, 28F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(847, 704)
        Controls.Add(btn_eliminar)
        Controls.Add(btn_guardar_cambios)
        Controls.Add(dgv_especialidades)
        Controls.Add(btn_regresar)
        Controls.Add(GroupBox1)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "frmEspecialidades"
        Text = "frmEspecialidades"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(dgv_especialidades, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_especialidad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_regresar As Button
    Friend WithEvents dgv_especialidades As DataGridView
    Friend WithEvents btn_guardar_cambios As Button
    Friend WithEvents btn_eliminar As Button
    Friend WithEvents lbl_id As Label
End Class
