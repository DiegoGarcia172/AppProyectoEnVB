Imports System.IO
Imports System.Runtime.CompilerServices
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports Microsoft.Office.Interop.Excel
Imports OfficeOpenXml

Public Class FrmTabla
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        DGV1.Columns.Clear()
    End Sub
    Private Function GetSeparator(fileName As String) As String
        Dim separators As String() = {",", "|"}
        Dim lines As String() = File.ReadAllLines(fileName)
        For Each separator As String In separators
            If lines.All(Function(line) line.Contains(separator)) Then
                Return separator
            End If
        Next
        Return ","
    End Function
    Private Function ReadCSV(fileName As String, separator As String) As String()()
        Dim lines As String() = File.ReadAllLines(fileName)
        Dim csvData As String()() = New String(lines.Length - 1)() {}
        For i As Integer = 0 To lines.Length - 1
            csvData(i) = lines(i).Split(separator)
        Next
        Return csvData
    End Function
    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos XLSX (*.xlsx)|*.xlsx"
        saveFileDialog.Title = "Exportar a XLSX"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExcelPackage.LicenseContext = LicenseContext.Commercial
            Using excelPackage As New ExcelPackage()
                Dim worksheet As ExcelWorksheet = excelPackage.Workbook.Worksheets.Add("Datos")
                For i As Integer = 0 To DGV1.Columns.Count - 1
                    worksheet.Cells(1, i + 1).Value = DGV1.Columns(i).HeaderText
                Next
                For i As Integer = 0 To DGV1.Rows.Count - 1
                    For j As Integer = 0 To DGV1.Columns.Count - 1
                        worksheet.Cells(i + 2, j + 1).Value = DGV1.Rows(i).Cells(j).Value
                    Next
                Next
                excelPackage.SaveAs(New FileInfo(saveFileDialog.FileName))
            End Using
            MessageBox.Show("El archivo XLSX se exportó correctamente.")
        End If
    End Sub
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Archivos CSV (*.csv)|*.csv"
        openFileDialog.Title = "Seleccionar archivo CSV"
        openFileDialog.Multiselect = False
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim fileName As String = openFileDialog.FileName
            Dim separator As String = GetSeparator(fileName)
            Dim csvData As String()() = ReadCSV(fileName, separator)
            Dim table As Data.DataTable = New Data.DataTable()
            For i As Integer = 0 To csvData(0).Length - 1
                table.Columns.Add(csvData(0)(i))
            Next
            For rowIdx As Integer = 1 To csvData.Length - 1
                Dim row As String() = csvData(rowIdx)
                table.Rows.Add(row)
            Next
            DGV1.DataSource = table
        End If
    End Sub

    Private Sub BtnExportarPDF_Click(sender As Object, e As EventArgs) Handles BtnExportarPDF.Click
        If DGV1.ColumnCount = 0 OrElse DGV1.RowCount = 0 Then
            MessageBox.Show("No hay datos en el DataGridView para exportar.")
            Return
        End If
        Dim saveDialog As New SaveFileDialog()
        saveDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveDialog.Title = "Guardar archivo PDF"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            ExportToPDF(DGV1, saveDialog.FileName)
            MessageBox.Show("Exportación completada exitosamente.")
        End If
    End Sub
    Private Sub ExportToPDF(ByVal dataGridView As DataGridView, ByVal filePath As String)
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Archivos PDF (*.pdf)|*.pdf"
        saveFileDialog.Title = "Exportar a PDF"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim doc As New Document()
            Try
                Dim writer As PdfWriter = PdfWriter.GetInstance(doc, New FileStream(saveFileDialog.FileName, FileMode.Create))
                doc.Open()
                Dim pdfTable As New PdfPTable(DGV1.Columns.Count)
                pdfTable.DefaultCell.Padding = 3
                pdfTable.WidthPercentage = 100
                pdfTable.HorizontalAlignment = Element.ALIGN_LEFT
                For Each column As DataGridViewColumn In DGV1.Columns
                    Dim cell As New PdfPCell(New Phrase(column.HeaderText))
                    pdfTable.AddCell(cell)
                Next
                For Each row As DataGridViewRow In DGV1.Rows
                    For Each cell As DataGridViewCell In row.Cells
                        pdfTable.AddCell(cell.Value.ToString())
                    Next
                Next
                doc.Add(pdfTable)
            Catch ex As Exception
                MessageBox.Show("Error al exportar a PDF: " & ex.Message)
            Finally
                doc.Close()
            End Try
            MessageBox.Show("El archivo PDF se exportó correctamente.")
        End If
    End Sub
End Class