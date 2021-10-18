Imports MongoDB.Driver
Imports MongoDB.Bson
Imports System.Security

Public Class Form1

    Private server As New MongoServerAddress("Localhost", 27117)
    Private dbsettings As New MongoClientSettings
    Private client As MongoClient


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        dbsettings.Server = server
        'dbsettings.ConnectionMode = ConnectionMode.Automatic
        dbsettings.DirectConnection = True

        client = New MongoClient(dbsettings)
        Dim db As MongoDatabaseBase = client.GetDatabase("ace")
        Dim Admin As New UserAccount(1, "Admin", "randycmiller1981@gmail.com", "MyPass")

    End Sub
End Class

Public Class UserAccount
    Public _ID As Integer
    Public _Name As String
    Public _Email As String
    Public _Password As String
    Sub New(ID As String, Name As String, Email As String, Password As String)
        _ID = ID
        _Name = Name
        _Email = Email
        _Password = Password
    End Sub
End Class