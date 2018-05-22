Public Class AlumnoForm
    Dim operacion_ As String
    Dim mialumno As New Alumno
    Public Property operacion() As String
        Get
            Return operacion_
        End Get
        Set(ByVal value As String)
            operacion_ = value
        End Set
    End Property
    Dim indice_ As Byte
    Public Property indice() As Byte
        Get
            Return indice_
        End Get
        Set(ByVal value As Byte)
            indice_ = value
        End Set
    End Property
    Private Sub Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Aceptar.Click
        mialumno.nya = TextBox1.Text
        mialumno.dni = CInt(TextBox2.Text)
        mialumno.nacimiento = CDate(TextBox3.Text)
        mialumno.mail = TextBox5.Text


        Select Case operacion_
            Case "nuevo"
                lst.Add(mialumno)
            Case "elimina"
                lst.RemoveAt(indice_)
            Case "modifica"
                lst.Item(indice_) = mialumno

                AlumnoGrid.DataGridView1.Refresh()
        End Select
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
        End If
        TextBox1.Focus()
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
            Exit Sub
            End
        End If

        Dim pos As Integer = TextBox2.SelectionStart()
        If e.KeyChar = "." And pos <> 2 And pos <> 6 Then e.Handled = True
        If Not Char.IsControl(e.KeyChar) And e.KeyChar <> "." And (pos = 2 Or pos = 6) Then
            e.Handled = True
            Exit Sub
        End If
        TextBox2.Focus()
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsControl(e.KeyChar) Or e.KeyChar = "/" Then
            e.Handled = False
        Else
            e.Handled = True
            Exit Sub
        End If
        Dim pos As Integer = TextBox3.SelectionStart
        If e.KeyChar = "/" And pos <> 2 And pos <> 5 Then
            e.Handled = True
            Exit Sub
        End If
        If Char.IsNumber(e.KeyChar) And (pos = 2 Or pos = 5) Then
            e.Handled = True
            Exit Sub
        End If


    End Sub

    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.LostFocus
        Dim dia As Integer = CInt(TextBox3.Text.Substring(0, 2))
        Dim mes As Integer = CInt(TextBox3.Text.Substring(3, 2))
        Dim año As Integer = CInt(TextBox3.Text.Substring(6, 4))


        If año < 1980 Or año > 2018 Then
            MsgBox("año no válido")
            TextBox1.Focus()
            Exit Sub
        End If

        If mes < 1 Or mes > 12 Then
            MsgBox("Mes no válido")
            TextBox1.Focus()
            Exit Sub
        End If

        Select Case mes
            Case 1, 3, 5, 7, 8, 10, 12
                If dia < 1 Or dia > 31 Then
                    MsgBox("Dia no válido")
                    TextBox1.Focus()
                    Exit Sub
                End If

            Case 4, 6, 9, 11
                If dia < 1 Or dia > 30 Then
                    MsgBox("Dia no válido")
                    TextBox1.Focus()
                    Exit Sub
                End If

            Case 2
                If año Mod 4 = 0 Then
                    If dia < 1 Or dia > 29 Then
                        MsgBox("Dia no válido")
                        TextBox1.Focus()
                        Exit Sub
                    End If
                Else
                    If dia < 1 Or dia > 28 Then
                        MsgBox("Dia no válido")
                        TextBox1.Focus()
                        Exit Sub
                    End If
                End If
        End Select


        TextBox4.Text = DateDiff(DateInterval.Year, CDate(TextBox3.Text), Now.Date)


    End Sub


    Private Sub AlumnoForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox4.Enabled = False
        TextBox4.ReadOnly = True
    End Sub
End Class
