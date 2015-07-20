Imports System.Threading.Tasks
Imports System.Text
Imports Microsoft.ServiceBus
Imports Microsoft.ServiceBus.Messaging
Imports Newtonsoft.Json
Imports System.Configuration

Public Class EventHubObserver

    Private _config As EventHubConfig
    Private _eventHubClient As EventHubClient
    Private _logger As Logger

    Public Sub New(ByVal config As EventHubConfig)
        Try
            _config = config
            _eventHubClient = EventHubClient.CreateFromConnectionString(_config.ConnectionString, _config.EventHubName)
            _logger = New Logger(ConfigurationManager.AppSettings("logger_path"))

        Catch ex As Exception
            _logger.Write(ex)
            Throw ex
        End Try
    End Sub

    Public Sub Send(ByVal sensorData As Sensor)
        Try
            Dim serialisedString As String = JsonConvert.SerializeObject(sensorData)
            Dim data As New EventData(Encoding.UTF8.GetBytes(serialisedString)) With {.PartitionKey = sensorData.CountryId.ToString()}
            _eventHubClient.Send(data)

        Catch ex As Exception
            _logger.Write(ex)
            Throw ex
        End Try
    End Sub



End Class
