Module FuncionesDb

    Public con As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Usuarios.mdb;Persist Security Info=False")
    Public cmd As New OleDb.OleDbCommand
    Public dr As OleDb.OleDbDataReader
    Public sql As String = ""
    Public Sub conexion()
        Try
            con.Open()
            MsgBox("Conectado exitosamente")
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultar(ByRef identificador As String)
        cmd.Connection = con
        cmd.CommandType = CommandType.Text

        If identificador <> "" Then
            cmd.CommandText = "SELECT Codigo, Nombre, Password, Correo FROM Usuarios WHERE Codigo='" + identificador + "'"
        Else
            cmd.CommandText = "SELECT Codigo, Nombre, Password, Correo FROM Usuarios"
        End If
        Try
            dr = cmd.ExecuteReader()

            If dr.HasRows Then
                While dr.Read()
                    MsgBox(dr(0).ToString + " " + dr(1).ToString + " " + dr(2).ToString + " " + dr(3).ToString)
                End While
            Else
                MsgBox("No existe registro para la consulta")
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Public Sub consultarUsuario(ByRef identificador As String)

        cmd.Connection = con
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT Codigo, Nombre, Password, Correo FROM Usuarios WHERE Codigo='" + identificador + "'"
        Try
            dr = cmd.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub



End Module
