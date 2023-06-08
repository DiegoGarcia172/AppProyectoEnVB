<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmBanxico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnCerrar = New System.Windows.Forms.Button()
        Me.DTPInicio = New System.Windows.Forms.DateTimePicker()
        Me.DTPFin = New System.Windows.Forms.DateTimePicker()
        Me.LblInicio = New System.Windows.Forms.Label()
        Me.LblFin = New System.Windows.Forms.Label()
        Me.BtnConsultar = New System.Windows.Forms.Button()
        Me.LbSerie = New System.Windows.Forms.Label()
        Me.LblFecha = New System.Windows.Forms.Label()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.TxtSerie = New System.Windows.Forms.TextBox()
        Me.LblSerie = New System.Windows.Forms.Label()
        Me.LblToken = New System.Windows.Forms.Label()
        Me.TxtToken = New System.Windows.Forms.TextBox()
        Me.TxtPT = New System.Windows.Forms.TextBox()
        Me.TxtSer = New System.Windows.Forms.TextBox()
        Me.BtnNuevaConsulta = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Location = New System.Drawing.Point(263, 12)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.BtnCerrar.TabIndex = 1
        Me.BtnCerrar.Text = "Cerrar"
        Me.BtnCerrar.UseVisualStyleBackColor = True
        '
        'DTPInicio
        '
        Me.DTPInicio.Location = New System.Drawing.Point(73, 120)
        Me.DTPInicio.Name = "DTPInicio"
        Me.DTPInicio.Size = New System.Drawing.Size(200, 20)
        Me.DTPInicio.TabIndex = 2
        '
        'DTPFin
        '
        Me.DTPFin.Location = New System.Drawing.Point(73, 146)
        Me.DTPFin.Name = "DTPFin"
        Me.DTPFin.Size = New System.Drawing.Size(200, 20)
        Me.DTPFin.TabIndex = 3
        '
        'LblInicio
        '
        Me.LblInicio.AutoSize = True
        Me.LblInicio.Location = New System.Drawing.Point(8, 120)
        Me.LblInicio.Name = "LblInicio"
        Me.LblInicio.Size = New System.Drawing.Size(35, 13)
        Me.LblInicio.TabIndex = 4
        Me.LblInicio.Text = "Inicio:"
        '
        'LblFin
        '
        Me.LblFin.AutoSize = True
        Me.LblFin.Location = New System.Drawing.Point(12, 146)
        Me.LblFin.Name = "LblFin"
        Me.LblFin.Size = New System.Drawing.Size(24, 13)
        Me.LblFin.TabIndex = 5
        Me.LblFin.Text = "Fin:"
        '
        'BtnConsultar
        '
        Me.BtnConsultar.Location = New System.Drawing.Point(12, 12)
        Me.BtnConsultar.Name = "BtnConsultar"
        Me.BtnConsultar.Size = New System.Drawing.Size(75, 23)
        Me.BtnConsultar.TabIndex = 6
        Me.BtnConsultar.Text = "Consultar"
        Me.BtnConsultar.UseVisualStyleBackColor = True
        '
        'LbSerie
        '
        Me.LbSerie.AutoSize = True
        Me.LbSerie.Location = New System.Drawing.Point(8, 190)
        Me.LbSerie.Name = "LbSerie"
        Me.LbSerie.Size = New System.Drawing.Size(39, 13)
        Me.LbSerie.TabIndex = 7
        Me.LbSerie.Text = "Label1"
        '
        'LblFecha
        '
        Me.LblFecha.AutoSize = True
        Me.LblFecha.Location = New System.Drawing.Point(8, 218)
        Me.LblFecha.Name = "LblFecha"
        Me.LblFecha.Size = New System.Drawing.Size(39, 13)
        Me.LblFecha.TabIndex = 8
        Me.LblFecha.Text = "Label2"
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(8, 240)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(39, 13)
        Me.LblPrecio.TabIndex = 9
        Me.LblPrecio.Text = "Label3"
        '
        'TxtSerie
        '
        Me.TxtSerie.Location = New System.Drawing.Point(73, 92)
        Me.TxtSerie.Name = "TxtSerie"
        Me.TxtSerie.Size = New System.Drawing.Size(100, 20)
        Me.TxtSerie.TabIndex = 10
        '
        'LblSerie
        '
        Me.LblSerie.AutoSize = True
        Me.LblSerie.Location = New System.Drawing.Point(8, 95)
        Me.LblSerie.Name = "LblSerie"
        Me.LblSerie.Size = New System.Drawing.Size(34, 13)
        Me.LblSerie.TabIndex = 11
        Me.LblSerie.Text = "Serie:"
        '
        'LblToken
        '
        Me.LblToken.AutoSize = True
        Me.LblToken.Location = New System.Drawing.Point(8, 59)
        Me.LblToken.Name = "LblToken"
        Me.LblToken.Size = New System.Drawing.Size(41, 13)
        Me.LblToken.TabIndex = 13
        Me.LblToken.Text = "Token:"
        '
        'TxtToken
        '
        Me.TxtToken.Location = New System.Drawing.Point(73, 56)
        Me.TxtToken.Name = "TxtToken"
        Me.TxtToken.Size = New System.Drawing.Size(265, 20)
        Me.TxtToken.TabIndex = 12
        '
        'TxtPT
        '
        Me.TxtPT.Location = New System.Drawing.Point(344, 2)
        Me.TxtPT.Name = "TxtPT"
        Me.TxtPT.Size = New System.Drawing.Size(500, 20)
        Me.TxtPT.TabIndex = 14
        '
        'TxtSer
        '
        Me.TxtSer.Location = New System.Drawing.Point(344, 28)
        Me.TxtSer.Name = "TxtSer"
        Me.TxtSer.Size = New System.Drawing.Size(100, 20)
        Me.TxtSer.TabIndex = 15
        '
        'BtnNuevaConsulta
        '
        Me.BtnNuevaConsulta.Location = New System.Drawing.Point(98, 12)
        Me.BtnNuevaConsulta.Name = "BtnNuevaConsulta"
        Me.BtnNuevaConsulta.Size = New System.Drawing.Size(119, 23)
        Me.BtnNuevaConsulta.TabIndex = 16
        Me.BtnNuevaConsulta.Text = "Nueva Consulta"
        Me.BtnNuevaConsulta.UseVisualStyleBackColor = True
        '
        'FrmBanxico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1039, 263)
        Me.Controls.Add(Me.BtnNuevaConsulta)
        Me.Controls.Add(Me.TxtSer)
        Me.Controls.Add(Me.TxtPT)
        Me.Controls.Add(Me.LblToken)
        Me.Controls.Add(Me.TxtToken)
        Me.Controls.Add(Me.LblSerie)
        Me.Controls.Add(Me.TxtSerie)
        Me.Controls.Add(Me.LblPrecio)
        Me.Controls.Add(Me.LblFecha)
        Me.Controls.Add(Me.LbSerie)
        Me.Controls.Add(Me.BtnConsultar)
        Me.Controls.Add(Me.LblFin)
        Me.Controls.Add(Me.LblInicio)
        Me.Controls.Add(Me.DTPFin)
        Me.Controls.Add(Me.DTPInicio)
        Me.Controls.Add(Me.BtnCerrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmBanxico"
        Me.Text = "FrmBanxico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCerrar As Button
    Friend WithEvents DTPInicio As DateTimePicker
    Friend WithEvents DTPFin As DateTimePicker
    Friend WithEvents LblInicio As Label
    Friend WithEvents LblFin As Label
    Friend WithEvents BtnConsultar As Button
    Friend WithEvents LbSerie As Label
    Friend WithEvents LblFecha As Label
    Friend WithEvents LblPrecio As Label
    Friend WithEvents TxtSerie As TextBox
    Friend WithEvents LblSerie As Label
    Friend WithEvents LblToken As Label
    Friend WithEvents TxtToken As TextBox
    Friend WithEvents TxtPT As TextBox
    Friend WithEvents TxtSer As TextBox
    Friend WithEvents BtnNuevaConsulta As Button
End Class
