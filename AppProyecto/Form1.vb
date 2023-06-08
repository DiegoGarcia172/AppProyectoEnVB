Public Class FrmMenu
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Application.Exit()
    End Sub
    Private Sub BtnTabla_Click(sender As Object, e As EventArgs) Handles BtnTabla.Click
        Dim Frm As FrmTabla = New FrmTabla()
        Frm.Show()
    End Sub
    Private Sub BtnTreeView_Click(sender As Object, e As EventArgs) Handles BtnTreeView.Click
        Dim Frm As FrmTreeView = New FrmTreeView()
        Frm.Show()
    End Sub
    Private Sub BtnGrafica_Click(sender As Object, e As EventArgs) Handles BtnGrafica.Click
        Dim Frm As FrmGrafica = New FrmGrafica()
        Frm.Show()
    End Sub
    Private Sub BtnBanxico_Click(sender As Object, e As EventArgs) Handles BtnBanxico.Click
        Dim Frm As FrmBanxico = New FrmBanxico()
        Frm.Show()
    End Sub
End Class
