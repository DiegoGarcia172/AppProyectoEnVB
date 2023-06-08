Imports System.Net
Imports System.Runtime.Serialization.Json
Public Class FrmBanxico
    Private Sub BtnCerrar_Click(sender As Object, e As EventArgs) Handles BtnCerrar.Click
        Close()
    End Sub
    Private Sub BtnConsultar_Click(sender As Object, e As EventArgs) Handles BtnConsultar.Click
        Dim fechaDesde As String = DTPInicio.Value.ToString("yyyy-MM-dd")
        Dim fechaHasta As String = DTPFin.Value.ToString("yyyy-MM-dd")
        Dim SerR As String = TxtSerie.Text.ToString()
        Dim Token As String = TxtToken.Text.ToString()
        Dim response As Response = read(fechaDesde, fechaHasta, SerR, Token)
        consultarDatos(response)

    End Sub
    Private Sub consultarDatos(response As Response)
        Dim serie As Serie = response.seriesResponse.Series(0)
        LbSerie.Text = "Serie: " & serie.Title
        For Each dataSerie As DataSerie In serie.Data
            If dataSerie.Data.Equals("N/E") Then Continue For
            LblFecha.Text = "Fecha: " & dataSerie.Fecha
            LblPrecio.Text = "Precio: " & dataSerie.Data
        Next
    End Sub
    Private Sub Limpiar()
        TxtSerie.Clear()
        TxtToken.Clear()
        DTPInicio.Value = Now
        DTPFin.Value = Now
        LbSerie.Text = ""
        LblFecha.Text = ""
        LblPrecio.Text = ""
    End Sub
    Private Shared Function read(fechaDesde As String, fechaHasta As String, SerR As String, Token As String) As Response
        Try
            Dim url As String = "https://www.banxico.org.mx/SieAPIRest/service/v1/series/" & SerR & "/datos/" & fechaDesde & "/" & fechaHasta
            Dim request As HttpWebRequest = TryCast(WebRequest.Create(url), HttpWebRequest)
            request.Accept = "application/json"
            request.Headers("Bmx-Token") = Token.ToString()
            Dim response As HttpWebResponse = TryCast(request.GetResponse(), HttpWebResponse)
            If response.StatusCode <> HttpStatusCode.OK Then Throw New Exception(String.Format("Server error (HTTP {0}: {1}).", response.StatusCode, response.StatusDescription))
            Dim jsonSerializer As DataContractJsonSerializer = New DataContractJsonSerializer(GetType(Response))
            Dim objResponse As Object = jsonSerializer.ReadObject(response.GetResponseStream())
            Dim jsonResponse As Response = TryCast(objResponse, Response)
            Return jsonResponse
        Catch e As Exception
            Console.WriteLine(e.Message)
        End Try
        Return Nothing
    End Function
    Private Sub FrmBanxico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtPT.Text = "c7f8feab9356b0effd3e2bc0c83bdb2ccb942828a28d19eccc7a10e961fb18c4"
        TxtSer.Text = "SF43718"
        LbSerie.Text = ""
        LblFecha.Text = ""
        LblPrecio.Text = ""
    End Sub
    Private Sub BtnNuevaConsulta_Click(sender As Object, e As EventArgs) Handles BtnNuevaConsulta.Click
        Limpiar()
    End Sub
End Class
