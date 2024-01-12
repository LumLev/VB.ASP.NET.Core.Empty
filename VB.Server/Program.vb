Imports System
Imports Microsoft.AspNetCore.Builder

Module Program
    Sub Main(args As String())
        Dim WebBuilder = WebApplication.CreateBuilder()
        Dim WebApp = WebBuilder.Build()

        WebApp.MapFallbackToFile("index.html")
        WebApp.Run()
    End Sub
End Module
