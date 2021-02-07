Imports System.Globalization

Public Class ControlesDeEntrada

    Public Function entradaNoVacia(ByVal str As String) As Boolean
        If (str <> String.Empty) Then
            Return True
        Else
            MsgBox("No deje espacios vacíos")
            Return False
        End If

    End Function

    Public Function entradaNumerica(ByRef str As String, ByVal tipo As String) As Boolean
        Select Case tipo
            Case "Int"
                Try
                    Integer.Parse(str)
                    Return True
                Catch ex As System.FormatException
                    str = "Solo Nºs Enteros"
                    Return False
                Catch ex As System.OverflowException
                    MsgBox(str + " Muy largo!")
                End Try
            Case "Dec"
                Try
                    str = Replace(str, ",", ".")
                    Decimal.Parse(str)
                    Return True
                Catch ex As System.FormatException
                    str = "Solo valores decimales"
                    Return False
                End Try
            Case Else
                Return False
        End Select
        Return False
    End Function

    Public Function comprobarLargo(ByVal str As String, ByVal num As Integer, ByVal calculo As String) As Boolean
        Select Case calculo
            Case "Mayor"
                If (str.Length > num) Then
                    Return True
                Else
                    MsgBox(str & " - cantidad de caracteres erronea")
                    Return False
                End If
            Case "Menor"
                If (str.Length < num) Then
                    Return True
                Else
                    MsgBox(str & " - cantidad de caracteres erronea")
                    Return False
                End If
            Case "Igual"
                If (str.Length = num) Then
                    Return True
                Else
                    MsgBox(str & " - cantidad de caracteres erronea")
                    Return False
                End If
            Case Else
                MsgBox("Error de opcion")
                Return False
        End Select
    End Function

    Public Function comprobarFecha(ByRef str As String) As Boolean
        Try
            DateTime.ParseExact(str, "dd/MM/yyyy", CultureInfo.CurrentCulture)
            Return True
        Catch ex As System.FormatException
            str = "dd/MM/yyyy es el formato apropiado"
            Return False
        End Try
    End Function

    Public Function nombreUsuario(ByRef str As String) As Boolean
        Dim permitidos As String = "abcdefghijklmnopqrstuvwxyz0123456789"
        For Each c As Char In str
            If Not permitidos.Contains(c.ToString.ToLower) Then
                str = "Caracteres invalidos"
                Return False
            End If

        Next
        Return True

    End Function

    Public Function letrasSolo(ByRef str As String) As Boolean
        Dim permitidos As String = "abcdefghijklmnopqrstuvwxyz_"
        Dim strAux As String = str.ToLower
        For Each c As Char In strAux
            If Not permitidos.Contains(c) Then
                str = "Se encontraron caracteres no permitidos"
                Return False
            End If

        Next
        Return True

    End Function

    Public Function extraerHora(ByVal hora As String, ByVal operacion As String) As String
        Dim horario() As String = hora.Split(":")
        Select Case operacion
            Case "Horas"
                Return horario(0)
            Case "Minutos"
                Return horario(1)
        End Select
        Return Nothing
    End Function

End Class
