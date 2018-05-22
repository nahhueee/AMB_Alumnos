Public Class AlumnoGrid

    Private Sub nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nuevo.Click
        AlumnoForm.operacion = "nuevo"
        AlumnoForm.Text = "Nuevo alumno"
        AlumnoForm.Show()
    End Sub

    Private Sub elimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles elimina.Click
        AlumnoForm.operacion = "elimina"
        AlumnoForm.Text = "Elimina Alumno"
        AlumnoForm.indice = DataGridView1.CurrentRow.Index
        Llenarform()
        AlumnoForm.Show()
    End Sub
    Private Sub Llenarform()
        AlumnoForm.TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        AlumnoForm.TextBox2.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        AlumnoForm.TextBox3.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        AlumnoForm.TextBox4.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        AlumnoForm.TextBox5.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
    End Sub

    Private Sub modifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles modifica.Click
        AlumnoForm.operacion = "modifica"
        AlumnoForm.Text = "Modifica Alumno"
        AlumnoForm.indice = DataGridView1.CurrentRow.Index
        Llenarform()
        AlumnoForm.Show()
    End Sub

    Private Sub salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles salir.Click
        Me.Close()
    End Sub

    Private Sub AlumnoGrid_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DataGridView1.DataSource = Lst
    End Sub

End Class