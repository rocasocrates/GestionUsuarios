Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion()
        'llenarGrid()
    End Sub

    Private Sub insertar_Click_1(sender As Object, e As EventArgs) Handles insertar.Click
        If (Me.codigo.Text = "") Then
            MsgBox("El campo codigo no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.codigo.Select()
        Else
            Dim codigoaux As String = ""
            Dim nombreaux As String = ""
            Dim passaux As String = ""
            Dim correoaux As String = ""

            codigoaux = Me.codigo.Text
            nombreaux = Me.nombre.Text
            passaux = Me.pass.Text
            correoaux = Me.correo.Text
            Dim co As Boolean = correoValido(correo.Text.ToString)
            If co Then

            Else
                MsgBox("El correo no es valido")
            End If



            cmd.CommandType = CommandType.Text
            cmd.Connection = con


            sql = "Insert into Usuarios ([Codigo], [Nombre], [Password], [Correo])"
            sql += "VALUES('" & codigoaux & "','" & nombreaux & "' ,'" & passaux & "','" & correoaux & "')"

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                MsgBox("Registro insertado correctamente", MsgBoxStyle.Information, "Información")
            Catch ex As Exception
                If (ex.ToString.Contains("valores duplicados")) Then
                    MsgBox("El Codigo existe en la base de datos", MsgBoxStyle.Critical, "Atención")

                ElseIf ex.ToString.Contains("longitud cero") Then
                    MsgBox("Hay campo vacio", MsgBoxStyle.Critical, "Atencion")
                Else
                    MsgBox(ex.ToString)
                End If

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Me.codigo2.Text = "") Then
            MsgBox("El campo codigo no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.codigo1.Select()
        Else
            Dim codigoaux As String = ""
            codigoaux = Me.codigo2.Text

            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            Dim sql As String = "DELETE FROM Usuarios "

            sql += " where [Codigo]= '" & codigoaux & "'"

            cmd.CommandText = sql

            Try
                cmd.ExecuteNonQuery()
                Me.codigo2.Text = ""
                Me.nombre2.Text = ""
                Me.pass2.Text = ""
                Me.correo2.Text = ""
                MsgBox("Registro eliminado correctamente", MsgBoxStyle.Information, "Información")

            Catch ex As Exception

                MsgBox(ex.ToString)


            End Try
        End If
    End Sub

    Private Sub codigo1_Leave(sender As Object, e As EventArgs) Handles codigo1.Leave

        If Me.codigo1.Text <> "" Then
            consultarUsuario(Me.codigo1.Text)
            If dr.Read Then
                Me.nombre1.Text = dr(1).ToString
                Me.pass1.Text = dr(2).ToString
                Me.correo1.Text = dr(3).ToString


                Me.Button1.Enabled = True
            Else
                Me.codigo1.Text = ""
                Me.nombre1.Text = ""
                Me.pass1.Text = ""
                Me.correo1.Text = ""
                MsgBox("No existe el registro en la base de datos")

                Me.Button1.Enabled = False
            End If
        Else
            Me.Button1.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub codigo2_Leave(sender As Object, e As EventArgs) Handles codigo2.Leave
        If Me.codigo2.Text <> "" Then
            consultarUsuario(Me.codigo2.Text)
            If dr.Read Then
                Me.nombre2.Text = dr(1).ToString
                Me.pass2.Text = dr(2).ToString
                Me.correo2.Text = dr(3).ToString


                Me.Button2.Enabled = True
            Else
                Me.codigo2.Text = ""
                Me.nombre2.Text = ""
                Me.pass2.Text = ""
                Me.correo2.Text = ""
                MsgBox("No existe el registro en la base de datos")

                Me.Button2.Enabled = False
            End If
        Else
            Me.Button2.Enabled = False
        End If
        dr.Close()
    End Sub

    Private Sub todo_Click(sender As Object, e As EventArgs) Handles todo.Click

        llenarGrid()


    End Sub
    Private Sub llenarGrid()
        Dim ds As New DataSet
        Dim dt As New DataTable
        Dim strSql As String = "SELECT Codigo, Nombre, Password, Correo  FROM Usuarios"
        Dim adp As New OleDb.OleDbDataAdapter(strSql, con)

        ds.Tables.Add("tabla")
        adp.Fill(ds.Tables("tabla"))

        Me.listar.DataSource = ds.Tables("tabla")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim identificador As String

        identificador = codigo3.Text

        consultar(identificador)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Me.codigo1.Text = "") Then
            MsgBox("El campo codigo no puede estar vacio", MsgBoxStyle.Critical, "Atención")
            Me.codigo1.Select()
        Else
            Dim codigoaux As String = ""
            Dim nombreaux As String = ""
            Dim passaux As String = ""
            Dim correoaux As String = ""

            codigoaux = Me.codigo1.Text
            nombreaux = Me.nombre1.Text
            passaux = Me.pass1.Text
            Dim co As Boolean = correoValido(correo1.Text.ToString)
            If co Then
                correoaux = Me.correo1.Text
            Else
                MsgBox("El correo no es valido")
            End If


            cmd.CommandType = CommandType.Text
            cmd.Connection = con

            Dim sqldos As String = "UPDATE Usuarios SET "
            sqldos += "[Codigo]= '" & codigoaux & "',[Nombre]= '" & nombreaux & "',[Password]= '" & passaux & "',[Correo]= '" & correoaux & "'"
            sqldos += " where [Codigo]= '" & codigoaux & "'"

            cmd.CommandText = sqldos

            Try
                cmd.ExecuteNonQuery()

                Me.codigo1.Text = ""
                Me.nombre1.Text = ""
                Me.pass1.Text = ""
                Me.correo1.Text = ""

                MsgBox("Registro actualizado correctamente", MsgBoxStyle.Information, "Información")

            Catch ex As Exception
                If ex.ToString.Contains("longitud cero") Then
                    MsgBox("El campo esta vacio", MsgBoxStyle.Critical, "Atencion")
                Else
                    MsgBox(ex.ToString)
                End If

            End Try
        End If
    End Sub

    Function correoValido(ByVal correo As String)
        Return Regex.IsMatch(correo, "[0-9a-zA-Z]([-.w]*[0-9a-zA-Z_+])*@([0-9a-zA-Z][-w]*[0-9a-zA-Z].)+[a-zA-Z]{2,9}$")
    End Function


End Class
