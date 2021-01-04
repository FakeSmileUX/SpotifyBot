Imports OpenQA.Selenium
Imports OpenQA.Selenium.Chrome
Imports OpenQA.Selenium.Firefox
Imports OpenQA.Selenium.Support.UI
Imports Microsoft.VisualBasic.CompilerServices
Imports System.IO
Imports System.Net
Imports System.Runtime.CompilerServices
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports Skin
Public Class BotForm

    Dim Bot As IWebDriver
    Dim Bot2 As IWebDriver
    Dim Bot3 As IWebDriver
    Dim Bot4 As IWebDriver
    Dim Bot5 As IWebDriver
    Dim Bot6 As IWebDriver
    Dim Bot7 As IWebDriver
    Dim Bot8 As IWebDriver
    Dim Bot9 As IWebDriver
    Dim Bot10 As IWebDriver



    Public Function RandomUserAgent() As String

        Dim rng As New System.Random()

        Dim RAND(15) As String

        RAND(0) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.61 Safari/537.36"
        RAND(1) = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.61 Safari/537.36"
        RAND(2) = "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/83.0.4103.61 Safari/537.36"
        RAND(3) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/70.0.3538.77 Safari/537.36"
        RAND(4) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.169 Safari/537.36"
        RAND(5) = "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36"
        RAND(6) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/74.0.3729.157 Safari/537.36"
        RAND(7) = "Mozilla/5.0 (Windows NT 10.0) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.121 Safari/537.36"
        RAND(8) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36"
        RAND(9) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36"
        RAND(10) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/78.0.3904.108 Safari/537.36"
        RAND(11) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.130 Safari/537.36"
        RAND(12) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.132 Safari/537.36"
        RAND(13) = "Mozilla/5.0 (Windows NT 6.1; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/79.0.3945.88 Safari/537.36"
        RAND(14) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/81.0.4044.138 Safari/537.36"
        RAND(15) = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/64.0.3282.186 Safari/537.36"

        Return RAND(rng.Next(RAND.Count())) + GetRandom(500, 2000).ToString()


    End Function




    Private bool_3 As Boolean
    Private httpWebResponse_0 As HttpWebResponse
    Private int_1 As Integer
    Private int_3 As Integer
    Private list_0 As List(Of String)
    Private ruAqsQojY As String
    Private string_0 As String
    Private string_1 As String
    Private utf8Encoding_0 As UTF8Encoding
    Public pass As String
    Public user As String
    Dim L As String
    Dim Views As Integer = 0
    Public Cap2 As Match
    Friend Delegate Sub VBAnonymousDelegate_0()
    Dim Inireader As New INIDatei
    Dim CurrentSongID As String
    Dim GeneratedPW As String
    Dim GeneratedEmail As String
    Dim AccsGenerated As Integer

    Dim TempAccountList As New ListView
    Dim TempAccountList2 As New ListView


    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private rdm As New Random
    Private Function GetRandomIPNr(max As Integer) As Integer
        'rdm.Next(minValue, maxValue) returns a random number greater than or equal to minValue and less than maxValue.
        Return rdm.Next(0, max)
    End Function


    Public Function GetAllSongs()
        Try
            While lvSongs.Items.Count > 0
                lvSongs.Items.Remove(lvSongs.Items(0))
                lvSongs.Columns.Remove(lvSongs.Columns(0))
            End While
        Catch
        End Try

        If Directory.GetFiles(My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\").Length = 0 Then
            lvSongs.Columns.Add("Cover", 53, HorizontalAlignment.Left)
            lvSongs.Columns.Add("Title", 145, HorizontalAlignment.Left) '163
            lvSongs.Columns.Add("Views", 245, HorizontalAlignment.Left) '163
            lvSongs.AllowColumnReorder = True
            lvSongs.Columns(1).DisplayIndex = 1

            Dim index As Integer = 0
            Dim lvi As New ListViewItem
            lvi.ImageIndex = index
            lvi.SubItems.Add("No songs")
            lvi.SubItems.Add("No songs")
            lvSongs.Items.Add(lvi)
        Else

            lvSongs.Columns.Add("Cover", 100, HorizontalAlignment.Left)
            lvSongs.Columns.Add("Title", 145, HorizontalAlignment.Left) '163
            lvSongs.Columns.Add("Views", 145, HorizontalAlignment.Left) '163
            Dim di As New DirectoryInfo(My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\")
            Dim fiArr As FileInfo() = di.GetFiles()
            Dim fri As FileInfo

            Dim imgList As New ImageList

            lvSongs.AllowColumnReorder = True
            lvSongs.Columns(1).DisplayIndex = 1
            imgList.ImageSize = New Size(70, 70)
            lvSongs.SmallImageList = imgList
            Dim index As Integer = 0

            For Each fri In fiArr
                Dim Covername As String = My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Covers\" & Inireader.WertLesen("Details", "ID", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & fri.Name)
                Dim Trackname As String = Inireader.WertLesen("Details", "TrackName", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & fri.Name)
                Dim Views As String = Inireader.WertLesen("Details", "Views", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & fri.Name)

                imgList.Images.Add("Cover", Image.FromFile(Covername & ".jpg"))

                Dim lvi As New ListViewItem
                lvi.ImageIndex = index

                'Increase the index
                index += 1

                lvi.SubItems.Add(Trackname)
                lvi.SubItems.Add(Views)
                lvSongs.Items.Add(lvi)
            Next fri
        End If
    End Function

    Public Function CountClicks()
        lbViewsGenerated.Text = Views

        Dim CurrentViews = Inireader.WertLesen("Details", "Views", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & CurrentSongID & ".ini", "0")

        Inireader.WertSchreiben("Details", "Views", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & CurrentSongID & ".ini", Convert.ToInt32(Views) + Convert.ToInt32(CurrentViews))
    End Function

    Public Function CountGeneratedAccs()
        '  lbTitle.Text = AccsGenerated

    End Function


    Public Sub New()
        Me.utf8Encoding_0 = New UTF8Encoding()
        Me.list_0 = New List(Of String)()
        Me.InitializeComponent()
    End Sub

    Public Function GetClosedText(ByVal source As String, ByVal opener As String, ByVal closer As String) As String
        Dim indexOfOpener = source.IndexOf(opener)
        Dim result As String = ""
        If indexOfOpener >= 0 Then ' default is -1 and indices start with 0
            indexOfOpener += opener.Length ' now look behind the opener
            Dim indexOfCloser = source.IndexOf(closer, indexOfOpener)
            If indexOfCloser >= 0 Then
                result = source.Substring(indexOfOpener, indexOfCloser - indexOfOpener)
            Else
                result = source.Substring(indexOfOpener) ' takes the rest behind the opener
            End If
        End If
        Return result
    End Function

    Private Sub tbSongURL_TextChanged(sender As Object, e As EventArgs) Handles tbSongURL.TextChanged
        If tbSongURL.Text.Contains("https://open.spotify.com/track/") Then
            Dim URL As String = tbSongURL.Text
            Dim ID = GetClosedText(URL, "/track/", "?si=")
            CurrentSongID = ID
            Dim request As HttpWebRequest
            Dim response As HttpWebResponse = Nothing
            Dim reader As StreamReader
            request = DirectCast(WebRequest.Create("https://embed.spotify.com/oembed?url=spotify:track:" & ID), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            Dim ImageUrl = GetClosedText(rawresp, "thumbnail_url" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & "," & ControlChars.Quote & "thumbnail_width")
            Dim tClient As WebClient = New WebClient
            Dim tImage As Bitmap = Bitmap.FromStream(New MemoryStream(tClient.DownloadData(ImageUrl)))
            pbCover.Image = tImage
            lbTitle.Text = GetClosedText(rawresp, "title" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & "," & ControlChars.Quote & "thumbnail_url")


            Dim web_client As WebClient = New WebClient

            ' Download the file.
            If Not (My.Computer.FileSystem.FileExists(My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Covers\" & ID & ".jpg")) Then
                web_client.DownloadFile(ImageUrl,
                My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Covers\" & ID & ".jpg")
            End If
            Inireader.WertSchreiben("Details", "ID", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", ID)
            Inireader.WertSchreiben("Details", "URL", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", URL)
            Inireader.WertSchreiben("Details", "TrackName", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", GetClosedText(rawresp, "title" & ControlChars.Quote & ":" & ControlChars.Quote, ControlChars.Quote & "," & ControlChars.Quote & "thumbnail_url"))
            Inireader.WertSchreiben("Details", "Views", My.Computer.FileSystem.CurrentDirectory & "\BotFiles\Songs\" & ID & ".ini", 0)
        End If


        GetAllSongs()
    End Sub

    Private Sub btnStartBot_Click(sender As Object, e As EventArgs) Handles btnStartBot.Click


        'If (FlatCheckBox3.Checked = True) Then
        'OptionOn.AddArguments("--headless")
        'End If
        'OptionOn.AddArguments("--proxy-server='direct://'")
        'OptionOn.AddArguments("--proxy-bypass-list=*")







        If btnStartBot.Text = "Start" Then

                If Not Convert.ToInt32(lbAccounts.Text) < 10 Then
                    ToolStripStatusLabel1.Text = "Bot started!"

                    '  For Each itemss As ListViewItem In TempAccountList2.Items
                    ' MsgBox(itemss.SubItems(0).Text)
                    ' Next

                    StartBringer.Enabled = True
                    Views = 0
                    btnStartBot.Text = "Stop"

                Else
                    MsgBox("Please use at least 10 accounts!")
                End If




            ElseIf btnStartBot.Text = "Stop" Then

                ToolStripStatusLabel1.Text = "Bot stopped!"
                StartBringer.Enabled = False
                TimerStart.Enabled = False
                btnStartBot.Text = "Start"


                Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
                For Each driver In AllDriver
                    Try
                        driver.Quit()

                    Catch
                    End Try
                Next
            End If

    End Sub

    Private Sub TimerStart_Tick(sender As Object, e As EventArgs) Handles TimerStart.Tick


        '  For value As Integer = 0 To FlatLabel10.Text - 1





        Dim PasswordTBFound As Boolean = False





        Dim I As Integer = 0

        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
            For Each driver In AllDriver

                Dim random As New Random()
            I = I + 1

            Try

                Try
                        If driver.FindElement(By.XPath("//*[@id=" & ControlChars.Quote & "app" & ControlChars.Quote & "]/body/div[1]/div[2]/div/form/div[3]/div[1]/div/label")).Displayed = True Then
                            PasswordTBFound = True
                        End If
                    Catch
                    End Try
                    If (PasswordTBFound = True) Then
                        Dim SavePW As IWebElement = driver.FindElement(By.XPath("//*[@id=" & ControlChars.Quote & "app" & ControlChars.Quote & "]/body/div[1]/div[2]/div/form/div[3]/div[1]/div/label"))
                        SavePW.Click()
                        'FILL USERNAME
                        Dim UserName As IWebElement = driver.FindElement(By.XPath("//*[@id=" & ControlChars.Quote & "login-username" & ControlChars.Quote & "]"))
                        UserName.Click()
                    UserName.SendKeys(lvQueue.Items(I).SubItems(0).Text)
                    ToolStripStatusLabel1.Text = "Login: " & lvQueue.Items(I).SubItems(0).Text
                    'FILL PASSWORD
                    Dim PW As IWebElement = driver.FindElement(By.XPath("//*[@id=" & ControlChars.Quote & "login-password" & ControlChars.Quote & "]"))
                        PW.Click()
                    PW.SendKeys(lvQueue.Items(I).SubItems(1).Text)
                    Try
                            'PRESS LOGIN
                            Dim LoginButton As IWebElement = driver.FindElement(By.XPath("//*[@id=" & ControlChars.Quote & "login-button" & ControlChars.Quote & "]"))
                            LoginButton.Click()

                            ToolStripStatusLabel1.Text = "Accounts connected!"
                        Catch
                        End Try


                    End If


                Catch
                End Try
            Next



            System.Threading.Thread.Sleep(2000)


            Dim AllDriver2() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
        ToolStripStatusLabel1.Text = "Open song: " & lbTitle.Text
        For Each driver In AllDriver2
            Try

                driver.Navigate().GoToUrl(tbSongURL.Text)
                Views = Views + 1
            Catch
            End Try
        Next






        CountClicks()





            Dim Interval = tbSeconds.Text * 60000
            Interval = Interval + tbMinutes.Text * 1000
        SongListener2.Interval = Interval + 5000
        TimerStart.Enabled = False
            SongListener2.Enabled = True

        '  If value = FlatLabel10.Text Then

        'Exit For
        'End If





    End Sub

    Private Sub SongListener2_Tick(sender As Object, e As EventArgs) Handles SongListener2.Tick


        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10} 'GGF DAS WIEDER IN BLOCK
        For Each driver In AllDriver
                Try

                    driver.Quit()


            Catch
                End Try
            Next
        Debug.Print("Driver beendet")


        TimerStart.Enabled = False
        SongListener2.Enabled = False
        ProxyCheck.Enabled = False
        Debug.Print("Bot restart")
        StartBringer.Enabled = True
        ToolStripStatusLabel1.Text = "Restarting Bot"
    End Sub








    Private Sub btnLoadAccounts_Click(sender As Object, e As EventArgs) Handles btnLoadAccounts.Click
        Dim Counter As Integer = 0
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
        openFileDialog.RestoreDirectory = True
        openFileDialog.Multiselect = False
        openFileDialog.Filter = "txt files (*.txt)|*.txt"
        openFileDialog.FilterIndex = 1
        openFileDialog.ShowDialog()
        Dim flag As Boolean = Operators.CompareString(openFileDialog.FileName, Nothing, False) > 0
        If flag Then
            Dim list As List(Of String) = New List(Of String)()
            Using streamReader As StreamReader = New StreamReader(openFileDialog.FileName)
                While streamReader.Peek() <> -1
                    list.Add(streamReader.ReadLine())
                End While
            End Using
            Try
                For Each item As String In list
                    Try
                        Counter = Counter + 1
                        Dim lvi As New ListViewItem
                        lvi.Text = item.Split(" - ")(0)
                        lvi.SubItems.Add(item.Split(" - ")(2))
                        lvAccounts.Items.Add(lvi)
                    Catch ex As Exception
                    End Try
                Next
                lbAccounts.Text = Counter
            Finally
            End Try

        End If
    End Sub

    Private Sub BotForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim W As New WebClient
        Dim Lic As String = W.DownloadString("http://biku-software.com/Spotify/Lic.php")
        L = Lic

        If (L = 1) Then
            Me.Opacity = 100
        Else
            Me.Opacity = 0
            Me.Close()

        End If
        GetAllSongs()
        ToolStripStatusLabel1.Text = "Welcome!"
    End Sub



    Public Sub CleanOfflineProxies(ByVal Treiber As IWebDriver)
        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
        For Each driver In AllDriver
            Try
                Dim ErrorMessage As IWebElement = driver.FindElement(By.ClassName("error-code"))
                If (ErrorMessage.Text = "ERR_PROXY_CONNECTION_FAILED") Then
                    driver.Quit()
                End If
            Catch
            End Try
            Try
                Dim ErrorMessage As IWebElement = driver.FindElement(By.ClassName("error-code"))
                If (ErrorMessage.Text = "ERR_TUNNEL_CONNECTION_FAILED") Then
                    driver.Quit()
                End If
            Catch
            End Try




        Next
    End Sub
    Private Sub ProxyCheck_Tick(sender As Object, e As EventArgs) Handles ProxyCheck.Tick
        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
        For Each driver In AllDriver
            Try
                CleanOfflineProxies(driver)
            Catch
            End Try
        Next
    End Sub

    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Dim OpenFileDialog1 As New OpenFileDialog
        OpenFileDialog1.Filter = "Alle Dateien (*.*)|*.*"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            MetroTextbox1.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub BotForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
        For Each driver In AllDriver
            Try
                driver.Quit()
            Catch
            End Try
        Next
    End Sub




    Public Sub MachAnDenBums()
        Debug.Print("Dispose Objects")
        Try
            '  Bot.Dispose()
            ' Bot2.Dispose()
            '  Bot3.Dispose()
            '  Bot4.Dispose()
            '  Bot5.Dispose()
            '  Bot6.Dispose()
            '  Bot7.Dispose()
            '  Bot8.Dispose()
            '  Bot9.Dispose()
            '  Bot10.Dispose()
        Catch
        End Try
        Debug.Print("Disposed")

        Dim OptionOn As New ChromeOptions
        Dim OptionOn2 As New ChromeOptions
        Dim OptionOn3 As New ChromeOptions
        Dim OptionOn4 As New ChromeOptions
        Dim OptionOn5 As New ChromeOptions
        Dim OptionOn6 As New ChromeOptions
        Dim OptionOn7 As New ChromeOptions
        Dim OptionOn8 As New ChromeOptions
        Dim OptionOn9 As New ChromeOptions
        Dim OptionOn10 As New ChromeOptions


        Debug.Print("New ChromeOptions")





        lvQueue.Items.Clear()
        TempAccountList.Items.Clear()
        TempAccountList2.Items.Clear()

        For Each item2c As ListViewItem In lvAccounts.Items
            Dim lvi2 As ListViewItem = item2c.Clone()
            TempAccountList.Items.Add(lvi2)
        Next







        For value As Integer = 0 To 9

            Dim random As New Random()
            Dim I As Integer = random.Next(0, (TempAccountList.Items.Count))
            TempAccountList2.Items.Add(TempAccountList.Items.Item(I).Clone)
            lvQueue.Items.Add(TempAccountList.Items.Item(I).Clone)
            TempAccountList.Items.RemoveAt(I)
        Next





        Debug.Print("Hier 1")
        Dim AllOptions() As ChromeOptions = {OptionOn, OptionOn2, OptionOn3, OptionOn4, OptionOn5, OptionOn6, OptionOn7, OptionOn8, OptionOn9, OptionOn10}

        If Not (MetroTextbox1.Text = "") Then

            Dim IpAddresses() As String = File.ReadAllLines(MetroTextbox1.Text)
            Dim RandomIpAddress As String = IpAddresses(GetRandomIPNr(IpAddresses.Length))
            For Each OptionOns In AllOptions
                If Not (OptionOns.Arguments.Count > 1) Then
                    OptionOns.AddArguments("--window-size=1920,1080")
                    OptionOns.AddArguments("--disable-gpu")
                    OptionOns.AddArguments("--disable-extensions")
                    OptionOns.AddArguments("--proxy-server=" & RandomIpAddress)
                    OptionOns.AddArguments("--no-sandbox")
                    OptionOns.AddArguments("--start-maximized")
                    OptionOns.AddArguments("--disable-web-security")
                    OptionOns.AddArguments("--no-sandbox")
                    OptionOns.AddArguments("--disable-plugins-discovery")
                    OptionOns.AddArguments("--disable-blink-features=AutomationControlled")
                    OptionOn.AddArguments("--user-agent=" & RandomUserAgent())

                    ' OptionOns.AddArguments("--mute-audio")
                End If
            Next

        Else ' KEIN PROXY


            For Each OptionOns In AllOptions
                If Not (OptionOns.Arguments.Count > 1) Then
                    OptionOns.AddArguments("--window-size=1920,1080")
                    OptionOns.AddArguments("--disable-gpu")
                    OptionOns.AddArguments("--disable-extensions")
                    OptionOns.AddArguments("--proxy-server='direct://'")
                    OptionOns.AddArguments("--proxy-bypass-list=*")
                    OptionOns.AddArguments("--no-sandbox")
                    OptionOns.AddArguments("--start-maximized")
                    OptionOns.AddArguments("--disable-web-security")
                    OptionOns.AddArguments("--no-sandbox")
                    OptionOns.AddArguments("--disable-blink-features=AutomationControlled")
                    OptionOn.AddArguments("--user-agent=" & RandomUserAgent())

                    ' OptionOns.AddArguments("--mute-audio")

                End If
            Next


        End If






        Debug.Print("Hier 2")
        Bot = New ChromeDriver(OptionOn)
        Bot2 = New ChromeDriver(OptionOn2)
        Bot3 = New ChromeDriver(OptionOn3)
        Bot4 = New ChromeDriver(OptionOn4)
        Bot5 = New ChromeDriver(OptionOn5)
        Bot6 = New ChromeDriver(OptionOn6)
        Bot7 = New ChromeDriver(OptionOn7)
        Bot8 = New ChromeDriver(OptionOn8)
        Bot9 = New ChromeDriver(OptionOn9)
        Bot10 = New ChromeDriver(OptionOn10)

        Debug.Print("Bot objekte erstellt")

        Dim AllDriver() As IWebDriver = {Bot, Bot2, Bot3, Bot4, Bot5, Bot6, Bot7, Bot8, Bot9, Bot10}
        For Each driver In AllDriver
            Try
                driver.Manage.Timeouts.PageLoad = TimeSpan.FromMinutes(1)
            Catch
            End Try
        Next






        'Dim js As IJavaScriptExecutor = TryCast(Bot, IJavaScriptExecutor)





        For Each driver In AllDriver
            Try
                driver.Manage().Cookies.DeleteAllCookies()

            Catch
            End Try
        Next



        Debug.Print("5")

        For Each driver In AllDriver
            Try
                driver.Navigate().GoToUrl("https://accounts.spotify.com/de/login/?continue=https:%2F%2Fwww.spotify.com%2Fus%2Faccount%2Foverview%2F&_locale=en-US")
            Catch
            End Try
        Next

        Debug.Print("6")
        ProxyCheck.Enabled = True







        '  StartBringer.Enabled = False

        TimerStart.Enabled = True

        btnStartBot.Text = "Stop"

        StartBringer.Enabled = False

    End Sub


    Private Sub StartBringer_Tick(sender As Object, e As EventArgs) Handles StartBringer.Tick
        ToolStripStatusLabel1.Text = "Bot started!"
        Debug.Print("Bot restarted")
        MachAnDenBums()
        StartBringer.Enabled = False
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim IpAddresses() As String = File.ReadAllLines(MetroTextbox1.Text)
        Dim RandomIpAddress As String = IpAddresses(GetRandomIPNr(IpAddresses.Length))
        Dim OptionOn As New ChromeOptions
        OptionOn.AddArguments("--window-size=1920,1080")
        OptionOn.AddArguments("--disable-gpu")
        OptionOn.AddArguments("--disable-extensions")
        OptionOn.AddArguments("--proxy-server=" & RandomIpAddress)
        OptionOn.AddArguments("--no-sandbox")
        OptionOn.AddArguments("--start-maximized")
        OptionOn.AddArguments("--disable-web-security")
        OptionOn.AddArguments("--no-sandbox")
        OptionOn.AddArguments("--disable-plugins-discovery")
        OptionOn.AddArguments("--disable-blink-features=AutomationControlled")
        OptionOn.AddArguments("--user-agent=" & RandomUserAgent())
        Bot = New ChromeDriver(OptionOn)

        Bot.Navigate().GoToUrl("https://www.wieistmeineip.de/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Dim ErrorMessage As IWebElement = Bot.FindElement(By.ClassName("error-code"))
        MsgBox(ErrorMessage)
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

    End Sub


End Class
