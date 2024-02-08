Public Class Inicio
    'Variables para SQL
    Dim SQL As String

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion()
        CreTable()
        FormProp()
        LoadRegs()
        TimeReal.Enabled = True
        TimeReal_Tick(sender, e)
    End Sub

    Sub CreTable()
        If EsCon = True Then
            SQL = "CREATE TABLE IF NOT EXISTS Ingr (Cant NUMERIC NOT NULL, Razo VARCHAR(250) NULL, Fech VARCHAR(10) NOT NULL, Hora VARCHAR(13) NOT NULL, Iden INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL);"
            Operaciones(DGVDatoE, SQL)
            SQL = "CREATE TABLE IF NOT EXISTS Egre (Cant NUMERIC NOT NULL, Razo VARCHAR(250) NULL, Fech VARCHAR(10) NOT NULL, Hora VARCHAR(13) NOT NULL, Iden INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL);"
            Operaciones(DGVDatoE, SQL)
        End If
    End Sub

    Sub FormProp()
        'Form
        MisVaris()
        Text = AppTit
        BackColor = FondoF
        TaPIngre.BackColor = FondoF
        TaPEgres.BackColor = FondoF
        'Controles
        ColorDGV()
        TxtFormt()
        'Enabled = False
        DGVSumaI.Enabled = False
        DGVSumaE.Enabled = False
        TxBIdenI.Enabled = False
        TxBIdenE.Enabled = False
        TxBSumaI.Enabled = False
        TxBSumaE.Enabled = False
    End Sub

    Sub ColorDGV()
        DGVDatoI.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen
        DGVDatoI.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        DGVDatoE.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen
        DGVDatoE.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
    End Sub

    Sub TxtFormt()
        'MaxLength
        TxBCantI.MaxLength = 15
        TxBCantE.MaxLength = 15
        RTBRazoI.MaxLength = 250
        RTBRazoE.MaxLength = 250
        'TextAlign
        TxBCantI.TextAlign = HorizontalAlignment.Right
        TxBCantE.TextAlign = HorizontalAlignment.Right
        'Format
        DTPFechI.Format = DateTimePickerFormat.Custom
        DTPFechE.Format = DateTimePickerFormat.Custom
        DTPFechI.CustomFormat = "yyyy/MM/dd"
        DTPFechE.CustomFormat = "yyyy/MM/dd"
        DTPHoraI.Format = DateTimePickerFormat.Time
        DTPHoraE.Format = DateTimePickerFormat.Time
        DTPHoraI.ShowUpDown = True
        DTPHoraE.ShowUpDown = True
    End Sub

    Sub LoadRegs()
        SQL = "SELECT * FROM Ingr ORDER BY Iden DESC"
        Consulta(DGVDatoI, SQL)
        SQL = "SELECT * FROM Egre ORDER BY Iden DESC"
        Consulta(DGVDatoE, SQL)
        SumaRegs()
        CellE()
        CellZ()
    End Sub

    Sub SumaRegs()
        SQL = "SELECT SUM(Cant) AS 'Ingresos' FROM Ingr"
        Consulta(DGVSumaI, SQL)
        If DGVSumaI.RowCount > 0 Then
            Try
                TxBSumaI.Text = DGVSumaI.CurrentRow.Cells(0).Value
            Catch ex As Exception
                TxBSumaI.Text = 0
            End Try
        End If

        SQL = "SELECT SUM(Cant) AS 'Egresos' FROM Egre"
        Consulta(DGVSumaE, SQL)
        If DGVSumaE.RowCount > 0 Then
            Try
                TxBSumaE.Text = DGVSumaE.CurrentRow.Cells(0).Value
            Catch ex As Exception
                TxBSumaE.Text = 0
            End Try
        End If
    End Sub

    Sub CellE()
        If DGVDatoI.RowCount > 0 Then
            Try
                TxBIdenI.Text = DGVDatoI.CurrentRow.Cells(4).Value
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            TxBIdenI.Clear()
        End If

        If DGVDatoE.RowCount > 0 Then
            Try
                TxBIdenE.Text = DGVDatoE.CurrentRow.Cells(4).Value
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            TxBIdenE.Clear()
        End If
        Dim VSumT As String = Val(TxBSumaI.Text) - Val(TxBSumaE.Text)
        LabTotl.Text = "Total: " & FormatCurrency((VSumT), "$ 0")
    End Sub

    Sub CellZ()
        If EsCon = True Then
            Try
                'Ingresos
                DGVDatoI.Columns(0).Width = 150
                DGVDatoI.Columns(0).HeaderText = "Cantidad"
                DGVDatoI.Columns(1).Width = 250
                DGVDatoI.Columns(1).HeaderText = "Razón"
                DGVDatoI.Columns(2).Width = 120
                DGVDatoI.Columns(2).HeaderText = "Fecha"
                DGVDatoI.Columns(3).Width = 120
                DGVDatoI.Columns(3).HeaderText = "Hora"
                DGVDatoI.Columns(4).Width = 50
                DGVDatoI.Columns(4).HeaderText = ""
                'Egresos
                DGVDatoE.Columns(0).Width = 150
                DGVDatoE.Columns(0).HeaderText = "Cantidad"
                DGVDatoE.Columns(1).Width = 250
                DGVDatoE.Columns(1).HeaderText = "Razón"
                DGVDatoE.Columns(2).Width = 120
                DGVDatoE.Columns(2).HeaderText = "Fecha"
                DGVDatoE.Columns(3).Width = 120
                DGVDatoE.Columns(3).HeaderText = "Hora"
                DGVDatoE.Columns(4).Width = 50
                DGVDatoE.Columns(4).HeaderText = ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

    Private Sub DGVDatoI_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatoI.CellEnter
        CellE()
    End Sub

    Private Sub DGVDatoE_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGVDatoE.CellEnter
        CellE()
    End Sub

    Private Sub TxBCantI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBCantI.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TxBCantE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TxBCantE.KeyPress
        OnlyNumbers(e)
    End Sub

    Private Sub TimeReal_Tick(sender As Object, e As EventArgs) Handles TimeReal.Tick
        If ChBFechI.Checked = True Then
            DTPFechI.Enabled = False
            DTPFechI.Text = Today
        Else
            DTPFechI.Enabled = True
        End If

        If ChBHoraI.Checked = True Then
            DTPHoraI.Enabled = False
            DTPHoraI.Text = TimeOfDay
        Else
            DTPHoraI.Enabled = True
        End If

        If ChBFechE.Checked = True Then
            DTPFechE.Enabled = False
            DTPFechE.Text = Today
        Else
            DTPFechE.Enabled = True
        End If

        If ChBHoraE.Checked = True Then
            DTPHoraE.Enabled = False
            DTPHoraE.Text = TimeOfDay
        Else
            DTPHoraE.Enabled = True
        End If
    End Sub

    Private Sub ButAgreI_Click(sender As Object, e As EventArgs) Handles ButAgreI.Click
        If Trim(TxBCantI.Text) = String.Empty Or Val(TxBCantI.Text) <= 0 Then
            MessageBox.Show(EMess, "Error")
            TxBCantI.Focus()
        Else
            SaveIngr()
            ButLimpT_Click(sender, e)
        End If
    End Sub

    Sub SaveIngr()
        If EsCon = True Then
            SQL = "INSERT INTO Ingr (Cant, Razo, Fech, Hora) SELECT " & Val(TxBCantI.Text) & ", '" & RTBRazoI.Text & "', '" & DTPFechI.Text & "', '" & DTPHoraI.Text & "'"
            Operaciones(DGVDatoI, SQL)
        End If
    End Sub

    Private Sub ButRemoI_Click(sender As Object, e As EventArgs) Handles ButRemoI.Click
        If DGVDatoI.RowCount > 0 Then
            If MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel) = vbOK Then
                DeleIngr()
                ButLimpT_Click(sender, e)
            Else
                TxBCantI.Focus()
            End If
        Else
            MessageBox.Show(OInva, "Error")
        End If
    End Sub

    Sub DeleIngr()
        If EsCon = True Then
            SQL = "DELETE FROM Ingr WHERE (Iden=" & TxBIdenI.Text & ")"
            Operaciones(DGVDatoI, SQL)
        End If
    End Sub

    Private Sub ButAgreE_Click(sender As Object, e As EventArgs) Handles ButAgreE.Click
        If Trim(TxBCantE.Text) = String.Empty Or Val(TxBCantE.Text) <= 0 Then
            MessageBox.Show(EMess, "Error")
            TxBCantE.Focus()
        Else
            SaveEgre()
            ButLimpT_Click(sender, e)
        End If
    End Sub

    Sub SaveEgre()
        If EsCon = True Then
            SQL = "INSERT INTO Egre (Cant, Razo, Fech, Hora) SELECT " & Val(TxBCantE.Text) & ", '" & RTBRazoE.Text & "', '" & DTPFechE.Text & "', '" & DTPHoraE.Text & "'"
            Operaciones(DGVDatoE, SQL)
        End If
    End Sub

    Private Sub ButRemoE_Click(sender As Object, e As EventArgs) Handles ButRemoE.Click
        If DGVDatoE.RowCount > 0 Then
            If MessageBox.Show("¿Eliminar registro?", "", MessageBoxButtons.OKCancel) = vbOK Then
                DeleEgre()
                ButLimpT_Click(sender, e)
            Else
                TxBCantE.Focus()
            End If
        Else
            MessageBox.Show(OInva, "Error")
        End If
    End Sub

    Sub DeleEgre()
        If EsCon = True Then
            SQL = "DELETE FROM Egre WHERE (Iden=" & TxBIdenE.Text & ")"
            Operaciones(DGVDatoE, SQL)
        End If
    End Sub

    Private Sub ButLimpT_Click(sender As Object, e As EventArgs) Handles ButLimpT.Click
        LimpiarT()
        LoadRegs()
    End Sub

    Sub LimpiarT()
        TxBCantI.Clear()
        RTBRazoI.Clear()
        DTPFechI.Text = Today
        DTPHoraI.Text = TimeOfDay
        TxBIdenI.Clear()
        TxBSumaI.Clear()

        TxBCantE.Clear()
        RTBRazoE.Clear()
        DTPFechE.Text = Today
        DTPHoraE.Text = TimeOfDay
        TxBIdenE.Clear()
        TxBSumaE.Clear()

        DGVSumaI.Columns.Clear()
        DGVSumaE.Columns.Clear()
    End Sub

    Private Sub LabTotl_Click(sender As Object, e As EventArgs) Handles LabTotl.Click
        MessageBox.Show(LabTotl.Text)
    End Sub

    Private Sub ButVacio_Click(sender As Object, e As EventArgs) Handles ButVacio.Click
        If MessageBox.Show("Eliminar todos los registros", "", MessageBoxButtons.OKCancel) = vbOK Then
            TrunIngr()
            TrunEgre()
            MessageBox.Show("Datos eliminados")
            ButLimpT_Click(sender, e)
        End If
    End Sub

    Sub TrunIngr()
        SQL = "DROP TABLE Ingr"
        Operaciones(DGVDatoE, SQL)
        SQL = "CREATE TABLE Ingr (Cant NUMERIC NOT NULL, Razo VARCHAR(250) NULL, Fech VARCHAR(10) NOT NULL, Hora VARCHAR(13) NOT NULL, Iden INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL);"
        Operaciones(DGVDatoE, SQL)
    End Sub

    Sub TrunEgre()
        SQL = "DROP TABLE Egre"
        Operaciones(DGVDatoE, SQL)
        SQL = "CREATE TABLE Egre (Cant NUMERIC NOT NULL, Razo VARCHAR(250) NULL, Fech VARCHAR(10) NOT NULL, Hora VARCHAR(13) NOT NULL, Iden INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL);"
        Operaciones(DGVDatoE, SQL)
    End Sub
End Class