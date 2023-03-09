Imports System.Security.Cryptography.X509Certificates
Imports Tarea_4_2do_semestre_VB.Tarea_2do_Semestre

Public Class Form1
    Dim cantidad_Per As Int16 = 0
    Dim Registrados As Int64 = 0
    Dim arreglo() As Contacto
    Private ArchivoNom As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Generamos el nombre del archivo y lo guardamos en la variable correspondiente

        ArchivoNom = My.Computer.FileSystem.SpecialDirectories.Desktop & "\contactos.txt"
        'Creamos el encabezado 
        If Not My.Computer.FileSystem.FileExists(ArchivoNom) Then
            My.Computer.FileSystem.WriteAllText(ArchivoNom, "Lista de contactos:" & vbCrLf & vbCrLf, False)
        End If
    End Sub


    Private Sub LBLFECHA_Clicker(sender As Object, e As EventArgs) Handles LBLFECHA.Click

    End Sub

    Private Sub LBLNom_Click(sender As Object, e As EventArgs) Handles LBLNom.Click

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles cantidadUpDown.ValueChanged, cantidadUpDown.ValueChanged
        cantidad_Per = cantidadUpDown.Text
        Registrados = 0
        ReDim arreglo(cantidad_Per)
    End Sub

    Private Sub BTimprimir_Click(sender As Object, e As EventArgs) Handles BTimprimir.Click
        If (Registrados < cantidad_Per) Then
            Dim contactonuevo = New Contacto
            contactonuevo._nombre = txtnombre.Text
            contactonuevo.correo_ = txtcorreo.Text
            contactonuevo._telefono = txttelefono.Text
            contactonuevo._fechaNacimineto = dtpFECHA.Value
            arreglo(Registrados) = contactonuevo
            Registrados = Registrados + 1
            Dim newline As String = contactonuevo._nombre + ", " + contactonuevo._telefono.ToString() + ", " + contactonuevo.Edad_.ToString() + ", " + contactonuevo.correo_.ToString() + Environment.NewLine
            Dim dataGridView = Datos
            Datos.Rows.Add(contactonuevo._nombre, contactonuevo.Edad_, contactonuevo._telefono, contactonuevo.correo_, contactonuevo._fechaNacimineto)


            'Agregar la cadena al final del archivo de texto
            My.Computer.FileSystem.WriteAllText(ArchivoNom, newline, True)

            arreglo(cantidad_Per) = contactonuevo

            Dim linea As String = ToString() + Environment.NewLine

            txtnombre.Clear()
            dtpFECHA.Value = DateTime.Now
            txttelefono.Clear()
            txtcorreo.Clear()



        Else
            MsgBox("Toy LLenito, Para")
        End If


    End Sub





    Private Sub Datos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Datos.CellContentClick

    End Sub
End Class
