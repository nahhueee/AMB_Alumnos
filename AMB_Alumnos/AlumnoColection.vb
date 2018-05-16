Imports System.ComponentModel
Public Class AlumnoColection
    Inherits BindingList(Of Alumno)
    Protected Overrides Sub OnAddingNew(ByVal e As AddingNewEventArgs)
        e.NewObject = New Alumno()
    End Sub
End Class
