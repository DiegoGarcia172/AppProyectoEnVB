<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTabla
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
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.BtnLimpiar = New System.Windows.Forms.Button()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.BtnCargar = New System.Windows.Forms.Button()
        Me.BtnExportar = New System.Windows.Forms.Button()
        Me.BtnExportarPDF = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(793, 30)
        Me.BtnCerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(100, 28)
        Me.BtnCerrar.TabIndex = 0
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'BtnLimpiar
        '
        Me.BtnLimpiar.Location = New System.Drawing.Point(660, 30)
        Me.BtnLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnLimpiar.Name = "BtnLimpiar"
        Me.BtnLimpiar.Size = New System.Drawing.Size(100, 28)
        Me.BtnLimpiar.TabIndex = 1
        Me.BtnLimpiar.Text = "Limpiar"
        Me.BtnLimpiar.UseVisualStyleBackColor = True
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(26, 90)
        Me.DGV1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.RowHeadersWidth = 51
        Me.DGV1.Size = New System.Drawing.Size(867, 363)
        Me.DGV1.TabIndex = 2
        '
        'BtnCargar
        '
        Me.BtnCargar.Location = New System.Drawing.Point(30, 30)
        Me.BtnCargar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.Size = New System.Drawing.Size(100, 28)
        Me.BtnCargar.TabIndex = 3
        Me.BtnCargar.Text = "Cargar"
        Me.BtnCargar.UseVisualStyleBackColor = True
        '
        'BtnExportar
        '
        Me.BtnExportar.Location = New System.Drawing.Point(138, 30)
        Me.BtnExportar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(112, 28)
        Me.BtnExportar.TabIndex = 4
        Me.BtnExportar.Text = "Exportar XLSX"
        Me.BtnExportar.UseVisualStyleBackColor = True
        '
        'BtnExportarPDF
        '
        Me.BtnExportarPDF.Location = New System.Drawing.Point(258, 30)
        Me.BtnExportarPDF.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BtnExportarPDF.Name = "BtnExportarPDF"
        Me.BtnExportarPDF.Size = New System.Drawing.Size(112, 28)
        Me.BtnExportarPDF.TabIndex = 5
        Me.BtnExportarPDF.Text = "Exportar PDF"
        Me.BtnExportarPDF.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(378, 30)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(112, 28)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Exportar CSV"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'FrmTabla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(909, 465)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BtnExportarPDF)
        Me.Controls.Add(Me.BtnExportar)
        Me.Controls.Add(Me.BtnCargar)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.BtnLimpiar)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FrmTabla"
        Me.Text = "FrmTabla"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents BtnLimpiar As Button
    Friend WithEvents DGV1 As DataGridView
    Friend WithEvents BtnCargar As Button
    Friend WithEvents BtnExportar As Button
    Friend WithEvents BtnExportarPDF As Button
    Friend WithEvents Button3 As Button
End Class
