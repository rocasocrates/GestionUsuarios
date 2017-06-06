<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.insertar = New System.Windows.Forms.Button()
        Me.correo = New System.Windows.Forms.TextBox()
        Me.pass = New System.Windows.Forms.TextBox()
        Me.nombre = New System.Windows.Forms.TextBox()
        Me.codigo = New System.Windows.Forms.TextBox()
        Me.Actualizar = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.correo1 = New System.Windows.Forms.TextBox()
        Me.pass1 = New System.Windows.Forms.TextBox()
        Me.nombre1 = New System.Windows.Forms.TextBox()
        Me.codigo1 = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.correo2 = New System.Windows.Forms.TextBox()
        Me.pass2 = New System.Windows.Forms.TextBox()
        Me.nombre2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.codigo2 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.listar = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.codigo3 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.todo = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Actualizar.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.listar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.Actualizar)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(289, 259)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.insertar)
        Me.TabPage1.Controls.Add(Me.correo)
        Me.TabPage1.Controls.Add(Me.pass)
        Me.TabPage1.Controls.Add(Me.nombre)
        Me.TabPage1.Controls.Add(Me.codigo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(281, 233)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Insertar"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Correo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Codigo"
        '
        'insertar
        '
        Me.insertar.Location = New System.Drawing.Point(109, 203)
        Me.insertar.Name = "insertar"
        Me.insertar.Size = New System.Drawing.Size(75, 23)
        Me.insertar.TabIndex = 4
        Me.insertar.Text = "Insertar"
        Me.insertar.UseVisualStyleBackColor = True
        '
        'correo
        '
        Me.correo.Location = New System.Drawing.Point(109, 167)
        Me.correo.Name = "correo"
        Me.correo.Size = New System.Drawing.Size(100, 20)
        Me.correo.TabIndex = 3
        '
        'pass
        '
        Me.pass.Location = New System.Drawing.Point(109, 121)
        Me.pass.Name = "pass"
        Me.pass.Size = New System.Drawing.Size(100, 20)
        Me.pass.TabIndex = 2
        '
        'nombre
        '
        Me.nombre.Location = New System.Drawing.Point(109, 80)
        Me.nombre.Name = "nombre"
        Me.nombre.Size = New System.Drawing.Size(100, 20)
        Me.nombre.TabIndex = 1
        '
        'codigo
        '
        Me.codigo.Location = New System.Drawing.Point(109, 39)
        Me.codigo.Name = "codigo"
        Me.codigo.Size = New System.Drawing.Size(100, 20)
        Me.codigo.TabIndex = 0
        '
        'Actualizar
        '
        Me.Actualizar.Controls.Add(Me.Label5)
        Me.Actualizar.Controls.Add(Me.Label6)
        Me.Actualizar.Controls.Add(Me.Label7)
        Me.Actualizar.Controls.Add(Me.Label8)
        Me.Actualizar.Controls.Add(Me.Button1)
        Me.Actualizar.Controls.Add(Me.correo1)
        Me.Actualizar.Controls.Add(Me.pass1)
        Me.Actualizar.Controls.Add(Me.nombre1)
        Me.Actualizar.Controls.Add(Me.codigo1)
        Me.Actualizar.Location = New System.Drawing.Point(4, 22)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Padding = New System.Windows.Forms.Padding(3)
        Me.Actualizar.Size = New System.Drawing.Size(281, 233)
        Me.Actualizar.TabIndex = 1
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Correo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Contraseña"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(44, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Nombre"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 24)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Codigo"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(95, 172)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Actualizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'correo1
        '
        Me.correo1.Location = New System.Drawing.Point(95, 135)
        Me.correo1.Name = "correo1"
        Me.correo1.Size = New System.Drawing.Size(100, 20)
        Me.correo1.TabIndex = 12
        '
        'pass1
        '
        Me.pass1.Location = New System.Drawing.Point(95, 99)
        Me.pass1.Name = "pass1"
        Me.pass1.Size = New System.Drawing.Size(100, 20)
        Me.pass1.TabIndex = 11
        '
        'nombre1
        '
        Me.nombre1.Location = New System.Drawing.Point(95, 58)
        Me.nombre1.Name = "nombre1"
        Me.nombre1.Size = New System.Drawing.Size(100, 20)
        Me.nombre1.TabIndex = 10
        '
        'codigo1
        '
        Me.codigo1.Location = New System.Drawing.Point(95, 21)
        Me.codigo1.Name = "codigo1"
        Me.codigo1.Size = New System.Drawing.Size(100, 20)
        Me.codigo1.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.correo2)
        Me.TabPage2.Controls.Add(Me.pass2)
        Me.TabPage2.Controls.Add(Me.nombre2)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.codigo2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(281, 233)
        Me.TabPage2.TabIndex = 2
        Me.TabPage2.Text = "Eliminar"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Correo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 112)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Contraseña"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 71)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Nombre"
        '
        'correo2
        '
        Me.correo2.Enabled = False
        Me.correo2.Location = New System.Drawing.Point(95, 141)
        Me.correo2.Name = "correo2"
        Me.correo2.Size = New System.Drawing.Size(100, 20)
        Me.correo2.TabIndex = 20
        '
        'pass2
        '
        Me.pass2.Enabled = False
        Me.pass2.Location = New System.Drawing.Point(95, 105)
        Me.pass2.Name = "pass2"
        Me.pass2.Size = New System.Drawing.Size(100, 20)
        Me.pass2.TabIndex = 19
        '
        'nombre2
        '
        Me.nombre2.Enabled = False
        Me.nombre2.Location = New System.Drawing.Point(95, 64)
        Me.nombre2.Name = "nombre2"
        Me.nombre2.Size = New System.Drawing.Size(100, 20)
        Me.nombre2.TabIndex = 18
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(95, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "Eliminar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Codigo"
        '
        'codigo2
        '
        Me.codigo2.Location = New System.Drawing.Point(95, 27)
        Me.codigo2.Name = "codigo2"
        Me.codigo2.Size = New System.Drawing.Size(100, 20)
        Me.codigo2.TabIndex = 15
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.listar)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.codigo3)
        Me.TabPage3.Controls.Add(Me.Button3)
        Me.TabPage3.Controls.Add(Me.todo)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(281, 233)
        Me.TabPage3.TabIndex = 3
        Me.TabPage3.Text = "Consultar"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'listar
        '
        Me.listar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.listar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listar.Location = New System.Drawing.Point(9, 92)
        Me.listar.Name = "listar"
        Me.listar.Size = New System.Drawing.Size(241, 148)
        Me.listar.TabIndex = 16
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Codigo"
        '
        'codigo3
        '
        Me.codigo3.Location = New System.Drawing.Point(49, 21)
        Me.codigo3.Name = "codigo3"
        Me.codigo3.Size = New System.Drawing.Size(100, 20)
        Me.codigo3.TabIndex = 2
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(169, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 23)
        Me.Button3.TabIndex = 1
        Me.Button3.Text = "Consultar usuario"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'todo
        '
        Me.todo.Location = New System.Drawing.Point(9, 63)
        Me.todo.Name = "todo"
        Me.todo.Size = New System.Drawing.Size(100, 23)
        Me.todo.TabIndex = 0
        Me.todo.Text = "Listar usuarios"
        Me.todo.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.Actualizar.ResumeLayout(False)
        Me.Actualizar.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.listar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Actualizar As TabPage
    Friend WithEvents correo As TextBox
    Friend WithEvents pass As TextBox
    Friend WithEvents nombre As TextBox
    Friend WithEvents codigo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents insertar As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents correo1 As TextBox
    Friend WithEvents pass1 As TextBox
    Friend WithEvents nombre1 As TextBox
    Friend WithEvents codigo1 As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Button2 As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents codigo2 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents correo2 As TextBox
    Friend WithEvents pass2 As TextBox
    Friend WithEvents nombre2 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents todo As Button
    Friend WithEvents listar As DataGridView
    Friend WithEvents Label13 As Label
    Friend WithEvents codigo3 As TextBox
    Friend WithEvents Button3 As Button
End Class
