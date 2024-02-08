Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Diagnostics.Process

Public Class Inicio
    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conexion()
        FormProp()
        RelleCBx()
    End Sub

    Sub FormProp()
        'Form
        Text = My.Application.Info.Title
        BackColor = Color.SteelBlue
        'Controles
        DGVDatos.RowsDefaultCellStyle.BackColor = Color.LightSeaGreen
        DGVDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue
        'Enabled = False
        ButExpor.Enabled = False
    End Sub

    Private Sub ButTabla_Click(sender As Object, e As EventArgs) Handles ButTabla.Click
        SQL = "SELECT * FROM " & CBxTabla.Text
        Consulta(DGVDatos, SQL)
        ButExpor.Enabled = True
    End Sub

    Private Sub ButClear_Click(sender As Object, e As EventArgs) Handles ButClear.Click
        DGVDatos.Columns.Clear()
        ButExpor.Enabled = False
    End Sub

    Private Sub ButExpor_Click(sender As Object, e As EventArgs) Handles ButExpor.Click
        Export(DGVDatos)
    End Sub

    Sub Export(ByVal DGV As DataGridView)
        Try
            Dim ExcelApp As New Application With {.Visible = True}
            Dim WorkBook As Workbook = ExcelApp.Workbooks.Add()
            Dim WorkSheet As Worksheet = CType(WorkBook.Sheets(1), Worksheet)
            Dim ColumnCount As Integer = DGV.Columns.Count
            For i As Integer = 0 To ColumnCount - 1
                WorkSheet.Cells(1, i + 1) = DGV.Columns(i).HeaderText
            Next
            Dim RowCount As Integer = DGV.Rows.Count
            For i As Integer = 0 To RowCount - 1
                For j As Integer = 0 To ColumnCount - 1
                    WorkSheet.Cells(i + 2, j + 1) = DGV.Rows(i).Cells(j).Value
                Next
            Next
            Dim TempFile As String = Path.GetTempFileName() & ".xls"
            WorkBook.SaveAs(TempFile)
            Start(TempFile)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class