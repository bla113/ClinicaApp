Imports System.Security.Cryptography
Imports System.Text
Imports MySql.Data.MySqlClient
Public Class Form1
    Dim conexion As New Conexion()
    Private Sub btn_crear_cuenta_Click(sender As Object, e As EventArgs) Handles btn_crear_cuenta.Click
        frmCrearCuenta.Show()
        Me.Hide()
    End Sub

    Private Sub btn_ingresar_Click(sender As Object, e As EventArgs) Handles btn_ingresar.Click

        Dim conn = conexion.Abrir() 'INSTANCIA (INTANCIAR) UN OBJETO de la clase Conexion para abrir la conexión a la base de datos

        If conn IsNot Nothing Then
            Dim correo As String = txt_correo.Text.Trim()
            Dim passoword As String = txt_password.Text.Trim()
            If String.IsNullOrEmpty(correo) Or String.IsNullOrEmpty(passoword) Then
                MessageBox.Show("Por favor, ingrese usuario y contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
            Dim hashContrasena As String = HashSHA256(passoword) 'SE HASHEA LA CONTRASEÑA PARA COMPARARLA CON LA BASE DE DATOS
            Dim query As String = "SELECT * FROM usuarios WHERE correo = @correo AND password = @password"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@correo", correo)
                cmd.Parameters.AddWithValue("@password", hashContrasena)
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then 'si existe // si es verdadero //
                        frmDashboard.Show() ' Mostrar el formulario del dashboard
                        Me.Hide() ' Cerrar el formulario de inicio de sesión
                        ' MessageBox.Show("Inicio de sesión exitoso.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        ' Aquí puedes redirigir al usuario a la siguiente pantalla
                    Else
                        MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Using
            End Using
            conexion.Cerrar()
        Else
            MessageBox.Show("No se pudo conectar a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Function HashSHA256(texto As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texto)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Return BitConverter.ToString(hash).Replace("-", "").ToLower()
        End Using
    End Function
End Class
