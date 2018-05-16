Public Class Alumno
    Dim dni_, edad_ As Integer
    Dim nacimiento_ As Date
    Dim nya_, mail_ As String
    Public Property nya() As String
        Get
            Return nya_
        End Get
        Set(ByVal value As String)
            nya_ = value
        End Set
    End Property
    Public ReadOnly Property edad() As Integer
        Get
            edad_ = DateDiff(DateInterval.Year, nacimiento_, Now.Date)
            Return edad_
        End Get
    End Property

    Public Property nacimiento() As Date
        Get
            Return nacimiento_
        End Get
        Set(ByVal value As Date)
            nacimiento_ = value
        End Set
    End Property

    Public Property mail() As String
        Get
            Return mail_
        End Get
        Set(ByVal value As String)
            mail_ = value
        End Set
    End Property

    Public Property dni() As Integer
        Get
            Return dni_
        End Get
        Set(ByVal value As Integer)
            dni_ = value
        End Set
    End Property
End Class
