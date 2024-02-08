Imports System.Data.SQLite
Module CRUD
    Private Cadena As String = "Data Source=|DataDirectory|\DB.s3db; Version=3"
    Private Conectar As New SQLiteConnection(Cadena)
    Public EsCon As Boolean

    Sub Conexion()
        EsCon = False
        While EsCon = False
            Try
                Conectar.Open()
                EsCon = True
                Conectar.Close()
            Catch ex As Exception
                EsCon = False
                If MessageBox.Show(ex.Message & vbCrLf & "" & vbCrLf & "¿Desea reintentar la conexión?", "Error", MessageBoxButtons.OKCancel) = vbCancel Then
                    End
                End If
            End Try
        End While
    End Sub

    Sub Consulta(ByVal Tabla As DataGridView, ByVal SQL As String)
        Try
            Dim DA As New SQLiteDataAdapter(SQL, Conectar)
            Dim DT As New DataTable
            DA.Fill(DT)
            Tabla.DataSource = DT
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub Operaciones(ByVal Tabla As DataGridView, ByVal SQL As String)
        Conectar.Open()
        Try
            Dim CMD As New SQLiteCommand(SQL, Conectar)
            CMD.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Conectar.Close()
    End Sub
End Module
