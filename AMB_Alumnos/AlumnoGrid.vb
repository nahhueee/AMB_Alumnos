Public Class AlumnoGrid

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click

    End Sub

    Private Sub elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elimina.Click

    End Sub

    Private Sub modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifica.Click

    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click

    End Sub

    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Lst
    End Sub

End Class