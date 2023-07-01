Imports System

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()
        app.MapGet("/", Function() "Welcome to VB.ASP.NET Core")
        app.Run()
    End Sub
End Module
