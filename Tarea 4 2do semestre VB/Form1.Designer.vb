<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        LBLFECHA = New Label()
        LBLNom = New Label()
        Label1 = New Label()
        telefono = New Label()
        Label3 = New Label()
        dtpFECHA = New DateTimePicker()
        txtcorreo = New TextBox()
        txttelefono = New TextBox()
        txtnombre = New TextBox()
        BTimprimir = New Button()
        cantidadUpDown = New NumericUpDown()
        Datos = New DataGridView()
        datoNombres = New DataGridViewTextBoxColumn()
        datoEdad = New DataGridViewTextBoxColumn()
        datoTelefono = New DataGridViewTextBoxColumn()
        datoCorreo = New DataGridViewTextBoxColumn()
        datoFecha = New DataGridViewTextBoxColumn()
        CType(cantidadUpDown, ComponentModel.ISupportInitialize).BeginInit()
        CType(Datos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' LBLFECHA
        ' 
        LBLFECHA.AutoSize = True
        LBLFECHA.Location = New Point(83, 190)
        LBLFECHA.Name = "LBLFECHA"
        LBLFECHA.Size = New Size(54, 20)
        LBLFECHA.TabIndex = 0
        LBLFECHA.Text = "FECHA"' 
        ' LBLNom
        ' 
        LBLNom.AutoSize = True
        LBLNom.Location = New Point(83, 117)
        LBLNom.Name = "LBLNom"
        LBLNom.Size = New Size(64, 20)
        LBLNom.TabIndex = 1
        LBLNom.Text = "Nombre"' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(83, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(153, 20)
        Label1.TabIndex = 2
        Label1.Text = "Cantidad de personas"' 
        ' telefono
        ' 
        telefono.AutoSize = True
        telefono.Location = New Point(83, 239)
        telefono.Name = "telefono"
        telefono.Size = New Size(67, 20)
        telefono.TabIndex = 3
        telefono.Text = "Telefono"' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(83, 284)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 4
        Label3.Text = "Correo"' 
        ' dtpFECHA
        ' 
        dtpFECHA.Location = New Point(153, 190)
        dtpFECHA.Name = "dtpFECHA"
        dtpFECHA.Size = New Size(313, 27)
        dtpFECHA.TabIndex = 5
        ' 
        ' txtcorreo
        ' 
        txtcorreo.Location = New Point(180, 284)
        txtcorreo.Name = "txtcorreo"
        txtcorreo.Size = New Size(125, 27)
        txtcorreo.TabIndex = 8
        ' 
        ' txttelefono
        ' 
        txttelefono.Location = New Point(180, 232)
        txttelefono.Name = "txttelefono"
        txttelefono.Size = New Size(125, 27)
        txttelefono.TabIndex = 9
        ' 
        ' txtnombre
        ' 
        txtnombre.Location = New Point(180, 110)
        txtnombre.Name = "txtnombre"
        txtnombre.Size = New Size(125, 27)
        txtnombre.TabIndex = 10
        ' 
        ' BTimprimir
        ' 
        BTimprimir.Location = New Point(616, 158)
        BTimprimir.Name = "BTimprimir"
        BTimprimir.Size = New Size(147, 85)
        BTimprimir.TabIndex = 11
        BTimprimir.Text = "Guardar"
        BTimprimir.UseVisualStyleBackColor = True
        ' 
        ' cantidadUpDown
        ' 
        cantidadUpDown.Location = New Point(274, 43)
        cantidadUpDown.Minimum = New [Decimal](New Integer() {2, 0, 0, 0})
        cantidadUpDown.Name = "cantidadUpDown"
        cantidadUpDown.Size = New Size(120, 27)
        cantidadUpDown.TabIndex = 13
        cantidadUpDown.Value = New [Decimal](New Integer() {2, 0, 0, 0})
        ' 
        ' Datos
        ' 
        Datos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Datos.Columns.AddRange(New DataGridViewColumn() {datoNombres, datoEdad, datoTelefono, datoCorreo, datoFecha})
        Datos.Location = New Point(83, 317)
        Datos.Name = "Datos"
        Datos.RowHeadersWidth = 51
        Datos.RowTemplate.Height = 29
        Datos.Size = New Size(680, 188)
        Datos.TabIndex = 14
        ' 
        ' datoNombres
        ' 
        datoNombres.HeaderText = "Nombes"
        datoNombres.MinimumWidth = 6
        datoNombres.Name = "datoNombres"
        datoNombres.Width = 125
        ' 
        ' datoEdad
        ' 
        datoEdad.HeaderText = "Edad"
        datoEdad.MinimumWidth = 6
        datoEdad.Name = "datoEdad"
        datoEdad.Width = 125
        ' 
        ' datoTelefono
        ' 
        datoTelefono.HeaderText = "Telefonos"
        datoTelefono.MinimumWidth = 6
        datoTelefono.Name = "datoTelefono"
        datoTelefono.Width = 125
        ' 
        ' datoCorreo
        ' 
        datoCorreo.HeaderText = "Correos"
        datoCorreo.MinimumWidth = 6
        datoCorreo.Name = "datoCorreo"
        datoCorreo.Width = 125
        ' 
        ' datoFecha
        ' 
        datoFecha.HeaderText = "Fechas"
        datoFecha.MinimumWidth = 6
        datoFecha.Name = "datoFecha"
        datoFecha.Width = 125
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(817, 450)
        Controls.Add(Datos)
        Controls.Add(cantidadUpDown)
        Controls.Add(BTimprimir)
        Controls.Add(txtnombre)
        Controls.Add(txttelefono)
        Controls.Add(txtcorreo)
        Controls.Add(dtpFECHA)
        Controls.Add(Label3)
        Controls.Add(telefono)
        Controls.Add(Label1)
        Controls.Add(LBLNom)
        Controls.Add(LBLFECHA)
        Name = "Form1"
        Text = "Form1"
        CType(cantidadUpDown, ComponentModel.ISupportInitialize).EndInit()
        CType(Datos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents LBLFECHA As Label
    Friend WithEvents LBLNom As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents telefono As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFECHA As DateTimePicker
    Friend WithEvents txtcorreo As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents BTimprimir As Button
    Friend WithEvents cantidadUpDown As NumericUpDown
    Friend WithEvents Datos As DataGridView
    Friend WithEvents datoNombres As DataGridViewTextBoxColumn
    Friend WithEvents datoEdad As DataGridViewTextBoxColumn
    Friend WithEvents datoTelefono As DataGridViewTextBoxColumn
    Friend WithEvents datoCorreo As DataGridViewTextBoxColumn
    Friend WithEvents datoFecha As DataGridViewTextBoxColumn
End Class
