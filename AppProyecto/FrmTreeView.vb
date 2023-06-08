Imports System.IO
Imports System.Windows.Forms
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmTreeView
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub BtnLimpiar_Click(sender As Object, e As EventArgs) Handles BtnLimpiar.Click
        TV1.Nodes.Clear()
    End Sub
    Private Sub BtnCargar_Click(sender As Object, e As EventArgs) Handles BtnCargar.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Archivos CSV (*.csv)|*.csv|Todos los archivos (*.*)|*.*"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True
        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim extension As String = Path.GetExtension(openFileDialog1.FileName)
            If extension.ToLower() = ".csv" Then
                CargarDatosCSV(openFileDialog1.FileName)
            Else
                MessageBox.Show("Extensión de archivo no válida. Por favor, seleccione un archivo CSV.", "Error de extensión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub CargarDatosCSV(rutaArchivo As String)
        TV1.Nodes.Clear()
        Dim lineas As String() = File.ReadAllLines(rutaArchivo)
        If lineas.Length > 0 Then
            For i As Integer = 0 To lineas.Length - 1
                Dim columnas As String() = lineas(i).Split("|"c)
                Dim nodoPadre As TreeNode = Nothing
                For j As Integer = 0 To columnas.Length - 1
                    Dim nodoHijo As New TreeNode(columnas(j))
                    If j = 0 Then
                        TV1.Nodes.Add(nodoHijo)
                        nodoPadre = nodoHijo
                    Else
                        nodoPadre.Nodes.Add(nodoHijo)
                        nodoPadre = nodoHijo
                    End If
                Next
            Next
            TV1.ExpandAll()
            MessageBox.Show("Datos cargados exitosamente.", "Carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("El archivo CSV está vacío.", "Carga de datos", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class