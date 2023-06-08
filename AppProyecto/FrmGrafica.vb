Imports System.IO
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmGrafica
    Dim openFileDialog As New OpenFileDialog()
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub BtnGraficar_Click(sender As Object, e As EventArgs) Handles BtnGraficar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv"
        openFileDialog1.Title = "Seleccionar archivo CSV"
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim archivoCsv As String = openFileDialog1.FileName
            Dim lineas As String() = File.ReadAllLines(archivoCsv)
            Dim chart As New Chart()
            Dim chartArea As New ChartArea()
            Dim series As New Series()
            chartArea.Name = "ChartArea1"
            chart.ChartAreas.Add(chartArea)
            series.ChartType = SeriesChartType.Line
            series.Name = "Series1"
            For Each linea As String In lineas
                Dim valores As String() = linea.Split(","c)
                If valores.Length = 2 Then
                    Dim x As Double
                    Dim y As Double

                    If Double.TryParse(valores(0), x) AndAlso Double.TryParse(valores(1), y) Then
                        series.Points.AddXY(x, y)
                    End If
                End If
            Next
            chart.Series.Add(series)
            Dim chartForm As New Form()
            chartForm.Width = 800
            chartForm.Height = 600
            chart.Dock = DockStyle.Fill
            chartForm.Controls.Add(chart)
            chartForm.ShowDialog()
        End If
    End Sub
End Class
