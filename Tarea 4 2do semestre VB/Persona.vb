Namespace Tarea_2do_Semestre

    Friend Class Persona
        Protected nombre As String
        Protected fechaNacimiento As DateTime?
        Protected Edad As Int32

        Public Property _nombre As String
            Get
                Return nombre
            End Get
            Set(ByVal Value As String)
                nombre = Value
            End Set
        End Property

        Public Property _fechaNacimineto As DateTime?
            Get
                Return fechaNacimiento
            End Get
            Set(ByVal value As DateTime?)
                fechaNacimiento = value
            End Set
        End Property

        Public ReadOnly Property Edad_ As String
            Get
                Edad = DateTime.Today.Year - fechaNacimiento.Value.Year
                If fechaNacimiento.Value.Year > DateTime.Today.Year Then
                    Edad_ -= 1
                End If
                Dim arregloEdad As Integer() = New Integer() {Edad}
                Return Edad
            End Get
        End Property

        Public Sub New()
            nombre = String.Empty
            fechaNacimiento = Nothing
        End Sub

        Public Sub New(ByVal nombre As String, ByVal fechaNacimineto As DateTime?)
            Me.nombre = nombre
            Me.fechaNacimiento = fechaNacimiento
        End Sub

        Public Overrides Function ToString() As String
            Return nombre.ToUpper() & " " & Edad
        End Function
    End Class

End Namespace

