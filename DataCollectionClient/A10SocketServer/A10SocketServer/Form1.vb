Imports Wunnell.Net
Imports System.Configuration
Imports System.Linq
Imports System.Reactive.Linq
Imports System.IO


Public Class Form1
    'todo: add ability to load a text file of data

    'A10SendRule:   Endpoint=sb://a10demo-ns.servicebus.windows.net/;SharedAccessKeyName=A10SendRule;SharedAccessKey=KLQuL55wWsIvEj78Dj1DzzB8uW5lyJ7OuUk+uxNxKl8=

    'NuGet packages:

    'Microsoft Azure Service Bus
    'Microsoft Azure Configuration Manager
    'Json.NET
    'Reactive Extensions - Main Library
    'Reactive Extensions - Core Library
    'Reactive Extensions - Interfaces Library
    'Reactive Extensions - Platform Services Library
    'Reactive Extensions - Query Library

    Private WithEvents server As New MessageServer(11000)
    Dim config As New EventHubConfig

    Dim msgCount As Integer = 0
    Dim msgSent As Integer = 0
    Dim errCount As Integer = 0

    Enum Status
        red = 0
        yellow = 1
        green = 2
        blue = 3
    End Enum

    Dim hubEvent As EventHubObserver

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        server.Dispose()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        config.ConnectionString = ConfigurationManager.AppSettings("EventHubConnectionString")
        config.EventHubName = ConfigurationManager.AppSettings("EventHubName")
        UpdateCounts()

        hubEvent = New EventHubObserver(config)
    End Sub

    Private Sub server_ConnectionAccepted(sender As Object, e As ConnectionEventArgs) Handles server.ConnectionAccepted
    End Sub

    Private Sub server_ConnectionClosed(sender As Object, e As ConnectionEventArgs) Handles server.ConnectionClosed
        UpdateLog("connection closed")
    End Sub

    Private Sub server_MessageReceived(sender As Object, e As MessageReceivedEventArgs) Handles server.MessageReceived
        'e.Message is what's received

        'Dim msg As String = e.Message
        SendMessage(e.Message)

    End Sub

    Sub SendMessage(ByVal msg As String)

        UpdateLog(msg)
        msgCount += 1

        Dim sensorData As New Sensor
        '           0                       1                    2                       3            4                5                 6               7               8                
        'e.message: time = 20150525-224036; ObjectID = 16777984; name = ZSU-23-4 Shilka; country = 0; Lat = 42.198411; Long = 41.639474; Alt = 0.000000; Hdg = 4.601732; type = 2.16.105.30

        Dim data() As String = msg.Split(";")
        sensorData.EventTime = data(0).Split("=")(1).ToString.Trim
        sensorData.ObjectId = CInt(data(1).Split("=")(1))
        sensorData.ObjectTypeName = data(2).Split("=")(1).ToString.Trim
        sensorData.CountryId = CInt(data(3).Split("=")(1))
        sensorData.Latitude = CDec(data(4).Split("=")(1))
        sensorData.Longitude = CDec(data(5).Split("=")(1))
        sensorData.Altitude = CDec(data(6).Split("=")(1))

        Try
            'hubEvent.Send(sensorData)
            msgSent += 1

        Catch ex As Exception
            errCount += 1
            UpdateLog(ex.Message)

        Finally
            UpdateCounts()

        End Try

    End Sub


    Private Sub UpdateLog(ByVal text As String)
        txtLog.AppendText(text & ControlChars.NewLine)
    End Sub

    Private Sub UpdateCounts()
        lblMsg.Text = "Msg: " & msgCount
        lblSent.Text = "Tx: " & msgSent
        lblErr.Text = "Err: " & errCount
        Application.DoEvents()
    End Sub

    Private Sub btnShowLog_Click(sender As Object, e As EventArgs) Handles btnShowLog.Click
        If btnShowLog.Text = "Show Log" Then
            txtLog.Visible = True
            Me.Width = 555 '555, 531
            Me.Height = 531
            btnShowLog.Text = "Hide Log"
        Else
            Me.Width = 305 '305, 72
            Me.Height = 78
            btnShowLog.Text = "Show Log"
            txtLog.Visible = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'D:\My Documents\GitHub\StreamingDemo
        OpenFileDialog1.InitialDirectory = My.Application.Info.DirectoryPath
        OpenFileDialog1.Filter = "Log files (*.log)|*.log|All files (*.*)|*.*"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.RestoreDirectory = True

        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim sr As StreamReader = Nothing
            Try
                sr = New StreamReader(OpenFileDialog1.FileName)
                Do While sr.Peek() >= 0
                    Dim msg As String = sr.ReadLine
                    If msg = "Closing log file" Then Exit Do

                    SendMessage(msg)
                Loop

            Finally
                sr.Close()

            End Try
        End If

    End Sub
End Class
