Imports System.Reflection.Metadata.Ecma335
Imports System.Xml.Serialization

Public Class WeatherForecast
    Public Property TheDate As String = Date.Now.ToString("dd MMM yyyy in K")



    Public Property TemperatureC As Integer

    Public Property TemperatureF As Integer
        Get
            Return 32 + CInt(TemperatureC / 0.5556)
        End Get
        Set(value As Integer)
            TemperatureC = CInt(value * 0.5556) - 32
        End Set
    End Property



    Public Property Summary As String
        Get
            Select Case TemperatureC
                Case >= 25 : Return "Hot"
                Case >= 15 : Return "Warm"
                Case >= 10 : Return "Cool"
                Case >= 5 : Return "Chilly"
                Case < 5 : Return "Cold"
                Case Else : Return "Nothing"
            End Select
        End Get
        Set(value As String)
            Select Case TemperatureC
                Case >= 25 : value = "Hot"
                Case >= 15 : value = "Warm"
                Case >= 10 : value = "Cool"
                Case >= 5 : value = "Chilly"
                Case < 5 : value = "Cold"
                Case Else : Return
            End Select
        End Set
    End Property


End Class
