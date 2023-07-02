Imports System
Imports System.Text

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        builder.Services.AddSingleton(Of XmlSerializationXSL)(New XmlSerializationXSL())
        Dim app = builder.Build()
        If app.Environment.IsDevelopment() = False Then
            app.UseHsts()
        End If
        app.MapGet("/GetWeather", Function(XmlSeri As XmlSerializationXSL)
                                      Dim WF As New WeatherForecast With {.TemperatureC = New Random().Next(-15, 35)}
                                      Dim TheStringResult = XmlSeri.SerializeToXmlWithXsl(WF, "StyleXmlOb.xslt")
                                      Return Results.Text(TheStringResult, "text/xml", Encoding.UTF8)
                                  End Function)
        app.UseDefaultFiles()
        app.UseHttpsRedirection()
        app.UseStaticFiles()
        app.Run()
    End Sub
End Module
