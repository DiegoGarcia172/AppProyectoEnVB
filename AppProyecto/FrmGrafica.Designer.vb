<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmGrafica
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnGraficar = New System.Windows.Forms.Button()
        Me.CH1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.CH1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(334, 23)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(100, 28)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnGraficar
        '
        Me.BtnGraficar.Location = New System.Drawing.Point(34, 23)
        Me.BtnGraficar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnGraficar.Name = "BtnGraficar"
        Me.BtnGraficar.Size = New System.Drawing.Size(100, 28)
        Me.BtnGraficar.TabIndex = 2
        Me.BtnGraficar.Text = "Graficar"
        Me.BtnGraficar.UseVisualStyleBackColor = True
        '
        'CH1
        '
        ChartArea2.Name = "ChartArea1"
        Me.CH1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.CH1.Legends.Add(Legend2)
        Me.CH1.Location = New System.Drawing.Point(34, 59)
        Me.CH1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CH1.Name = "CH1"
        Me.CH1.Size = New System.Drawing.Size(400, 369)
        Me.CH1.TabIndex = 3
        Me.CH1.Text = "CH1"
        '
        'FrmGrafica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(463, 450)
        Me.Controls.Add(Me.CH1)
        Me.Controls.Add(Me.BtnGraficar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmGrafica"
        Me.Text = "FrmGrafica"
        CType(Me.CH1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnGraficar As Button
    Public WithEvents CH1 As DataVisualization.Charting.Chart
End Class
