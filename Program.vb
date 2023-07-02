Imports System

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()

        If app.Environment.IsDevelopment() == False Then
            app.UseHsts()
        End If
        app.UseDefaultFiles()
        app.UseHttpsRedirection()
        app.UseStaticFiles()
        app.Run()
    End Sub
End Module
