Imports System.Threading
Imports System.Threading.Tasks

Imports Google
Imports Google.Apis.Auth.OAuth2
Imports Google.Apis.Drive.v2
Imports Google.Apis.Drive.v2.Data
Imports Google.Apis.Services

Imports Google.Apis.Auth
Imports Google.Apis.Download






Public Class Frontendform

    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Response.Redirect("GmailPage.html")
    End Sub


    Protected Sub Button2_Click1(sender As Object, e As EventArgs) Handles Button2.Click
        CreateService()
        UploadFile()
    End Sub
    Private Sub UploadFile()
        Throw New NotImplementedException()
    End Sub
    Private Service As DriveService = New DriveService
    Private Cursors As Object
    Public Property Cursor As Object

    Private Sub CreateService()

        Dim ClientId = "client id"
        Dim ClientSecret = "client secret"
        Dim MyUserCredential As UserCredential = GoogleWebAuthorizationBroker.AuthorizeAsync(New ClientSecrets() With {.ClientId = ClientId, .ClientSecret = ClientSecret}, {DriveService.Scope.Drive}, "user", CancellationToken.None).Result
            Service = New DriveService(New BaseClientService.Initializer() With {.HttpClientInitializer = MyUserCredential, .ApplicationName = "Google Drive VB Dot Net"})

    End Sub

    Private Sub UploadFile(FilePath As String)
        Me.Cursor = Cursors.WaitCursor
        If Service.ApplicationName <> "Google Drive VB Dot Net" Then CreateService()

        Dim TheFile As New File()
        TheFile.Title = "My document"
        TheFile.Description = "A test document"
        TheFile.MimeType = "text/plain"

        Dim ByteArray As Byte() = System.IO.File.ReadAllBytes(FilePath)
        Dim Stream As New System.IO.MemoryStream(ByteArray)

        Dim UploadRequest As FilesResource.InsertMediaUpload = Service.Files.Insert(TheFile, Stream, TheFile.MimeType)

        Me.Cursor = Cursors.Default
        MsgBox("Upload Finished")
    End Sub


End Class
