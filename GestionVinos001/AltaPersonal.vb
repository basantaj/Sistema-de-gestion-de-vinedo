Public Class AltaPersonal
    Dim con As Odbc.OdbcConnection
    Dim da As New Odbc.OdbcDataAdapter
    Dim com As New Odbc.OdbcCommand
    Dim ds As New DataSet

    Dim cedula, nombre, apellido, cargo, telefono, sucursal As String

    Public Sub New(ByVal ci As String, ByVal n As String, ByVal a As String, ByVal ca As String, ByVal t As String, ByVal s As String, ByVal c As Odbc.OdbcConnection)
        cedula = ci
        nombre = n
        apellido = a
        cargo = ca
        telefono = t
        sucursal = s

        con = c
        com.Connection = con
        da.SelectCommand = com

        com.CommandText = "select * from personal where ci=" + cedula
        da.Fill(ds, "empleados")

        If ds.Tables("empleados").Rows.Count < 1 Then
            com.CommandText = "insert into personal values(" + cedula + ",'" + nombre + "','" + apellido + "','" + cargo + "'," + telefono + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        End If

        com.CommandText = "select * from trabaja where ci_personal=" + cedula + " AND id_sucursal=" + sucursal
        da.Fill(ds, "empSuc")

        If ds.Tables("empSuc").Rows.Count > 0 Then
            MsgBox("Empleado ya registrado bajo esta sucursal")
        Else
            com.CommandText = "insert into trabaja values(" + cedula + "," + sucursal + ")"
            con.Open()
            com.ExecuteNonQuery()
            con.Close()
            MsgBox("Empleado registrado. Para dar acceso a la base de datos contactar a un administrador")
        End If

    End Sub

End Class
