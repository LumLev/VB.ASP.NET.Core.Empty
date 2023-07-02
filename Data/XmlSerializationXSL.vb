Imports System.Security.Cryptography.X509Certificates
Imports System.Text
Imports System.Xml
Imports System.Xml.Serialization

Public Class XmlSerializationXSL
    Private settings As XmlWriterSettings
    Public Class TheStringWriter
        Inherits StringWriter

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Encoding.UTF8
            End Get
        End Property
    End Class

    Public Sub XmlSerializationXSL()
        settings = New XmlWriterSettings With
            {.Indent = True, .IndentChars = "\t", .Encoding = Encoding.UTF8}

    End Sub


    Public Function SerializeToXmlWithXsl(Of T)(obj As T, XslPath As String) As String
        Dim XS As XmlSerializer = New XmlSerializer(GetType(T))
        Using SW As New StringWriter()
            Using XW As XmlWriter = XmlWriter.Create(SW, settings)
                XW.WriteStartDocument()
                XW.WriteProcessingInstruction("xml-stylesheet", $"type=""text/xsl"" href=""{XslPath}""")
                XS.Serialize(XW, obj)
            End Using
            Return SW.ToString()
        End Using
    End Function

End Class
