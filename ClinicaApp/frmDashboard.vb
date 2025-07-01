Public Class frmDashboard
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btn_especialidades_Click(sender As Object, e As EventArgs) Handles btn_especialidades.Click
        frmEspecialidades.Show()
        Me.Hide()
    End Sub
End Class