<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.BtnTabla = New System.Windows.Forms.Button()
        Me.BtnTreeView = New System.Windows.Forms.Button()
        Me.BtnBanxico = New System.Windows.Forms.Button()
        Me.BtnGrafica = New System.Windows.Forms.Button()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnTabla
        '
        Me.BtnTabla.Location = New System.Drawing.Point(103, 51)
        Me.BtnTabla.Name = "BtnTabla"
        Me.BtnTabla.Size = New System.Drawing.Size(75, 23)
        Me.BtnTabla.TabIndex = 0
        Me.BtnTabla.Text = "Tabla"
        Me.BtnTabla.UseVisualStyleBackColor = True
        '
        'BtnTreeView
        '
        Me.BtnTreeView.Location = New System.Drawing.Point(103, 80)
        Me.BtnTreeView.Name = "BtnTreeView"
        Me.BtnTreeView.Size = New System.Drawing.Size(75, 23)
        Me.BtnTreeView.TabIndex = 1
        Me.BtnTreeView.Text = "TreeView"
        Me.BtnTreeView.UseVisualStyleBackColor = True
        '
        'BtnBanxico
        '
        Me.BtnBanxico.Location = New System.Drawing.Point(103, 140)
        Me.BtnBanxico.Name = "BtnBanxico"
        Me.BtnBanxico.Size = New System.Drawing.Size(75, 23)
        Me.BtnBanxico.TabIndex = 3
        Me.BtnBanxico.Text = "Banxico"
        Me.BtnBanxico.UseVisualStyleBackColor = True
        '
        'BtnGrafica
        '
        Me.BtnGrafica.Location = New System.Drawing.Point(103, 111)
        Me.BtnGrafica.Name = "BtnGrafica"
        Me.BtnGrafica.Size = New System.Drawing.Size(75, 23)
        Me.BtnGrafica.TabIndex = 2
        Me.BtnGrafica.Text = "Grafica"
        Me.BtnGrafica.UseVisualStyleBackColor = True
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(218, 140)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 4
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Proyecto en VB"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 176)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCerrar)
        Me.Controls.Add(Me.BtnBanxico)
        Me.Controls.Add(Me.BtnGrafica)
        Me.Controls.Add(Me.BtnTreeView)
        Me.Controls.Add(Me.BtnTabla)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmMenu"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnTabla As Button
    Friend WithEvents BtnTreeView As Button
    Friend WithEvents BtnBanxico As Button
    Friend WithEvents BtnGrafica As Button
    Friend WithEvents BtnCerrar As Button
    Friend WithEvents Label1 As Label
End Class
