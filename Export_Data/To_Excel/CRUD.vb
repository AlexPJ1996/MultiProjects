Imports Devart.Data.SQLite
Module CRUD
    Private ReadOnly CoString As String = "Data Source=|DataDirectory|\DB.s3db; Version=3"
    Private ReadOnly Conectar As New SQLiteConnection(CoString)
    Public SQL As String
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

    Function Rellenar(ByVal SQL As String)
        Dim DT As New DataTable
        Try
            Dim DA As New SQLiteDataAdapter(SQL, Conectar)
            DA.Fill(DT)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return DT
    End Function

    Sub RelleCBx()
        SQL = "SELECT name FROM sqlite_master WHERE type = 'table'"
        Try
            Dim DT As New DataTable
            DT = Rellenar(SQL)
            Inicio.CBxTabla.DataSource = DT
            Inicio.CBxTabla.DisplayMember = "name"
            Inicio.CBxTabla.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Module