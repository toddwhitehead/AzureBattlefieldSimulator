Imports System.IO

Public Class Logger

    Public logPath As String

    Public Sub New(ByVal pth As String)
        logPath = pth
        Dim folder As String = Path.GetDirectoryName(logPath)
        If Directory.Exists(folder) = False Then
            Directory.CreateDirectory(folder)
        End If
    End Sub

    Public Sub Write(ByVal msg As String)
        Dim s As String = String.Format("[{0}] {1}{2}", Now.ToString, msg, Environment.NewLine)
        File.AppendAllText(logPath, s)
    End Sub

    Public Sub Write(ByVal e As Exception)
        Dim s As String = String.Format("[{0}] Exception - {1}{2}{3}{4}", Now.ToString, e.Message, e.StackTrace, Environment.NewLine)
    End Sub

End Class
