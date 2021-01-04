<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class BotForm
    Inherits MetroSuite.MetroForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BotForm))
        Me.MetroTabControl1 = New MetroSuite.MetroTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lvQueue = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.MetroLabel2 = New MetroSuite.MetroLabel()
        Me.MetroButton1 = New MetroSuite.MetroButton()
        Me.MetroTextbox1 = New MetroSuite.MetroTextbox()
        Me.btnStartBot = New MetroSuite.MetroButton()
        Me.MetroLabel8 = New MetroSuite.MetroLabel()
        Me.tbMinutes = New MetroSuite.MetroTextbox()
        Me.tbSeconds = New MetroSuite.MetroTextbox()
        Me.MetroLabel7 = New MetroSuite.MetroLabel()
        Me.lbViewsGenerated = New MetroSuite.MetroLabel()
        Me.MetroLabel6 = New MetroSuite.MetroLabel()
        Me.lbTitle = New MetroSuite.MetroLabel()
        Me.MetroLabel3 = New MetroSuite.MetroLabel()
        Me.tbSongURL = New MetroSuite.MetroTextbox()
        Me.pbCover = New System.Windows.Forms.PictureBox()
        Me.btnLoadAccounts = New MetroSuite.MetroButton()
        Me.lvAccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader21 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbAccounts = New MetroSuite.MetroLabel()
        Me.MetroLabel1 = New MetroSuite.MetroLabel()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.lvSongs = New System.Windows.Forms.ListView()
        Me.MetroStatusStrip1 = New MetroSuite.MetroStatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerStart = New System.Windows.Forms.Timer(Me.components)
        Me.SongListener2 = New System.Windows.Forms.Timer(Me.components)
        Me.FlatNumeric1 = New System.Windows.Forms.NumericUpDown()
        Me.MetroControlBox1 = New MetroSuite.MetroControlBox()
        Me.ProxyCheck = New System.Windows.Forms.Timer(Me.components)
        Me.StartBringer = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MetroTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.MetroStatusStrip1.SuspendLayout()
        CType(Me.FlatNumeric1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MetroTabControl1
        '
        Me.MetroTabControl1.Appearance = System.Windows.Forms.Appearance.Normal
        Me.MetroTabControl1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTabControl1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.MetroTabControl1.Controls.Add(Me.TabPage1)
        Me.MetroTabControl1.Controls.Add(Me.TabPage3)
        Me.MetroTabControl1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroTabControl1.ForeColor = System.Drawing.Color.Black
        Me.MetroTabControl1.HasAnimation = False
        Me.MetroTabControl1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(106, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.MetroTabControl1.HeaderItemColor = System.Drawing.Color.White
        Me.MetroTabControl1.HotTrack = True
        Me.MetroTabControl1.HoverBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.HoverColor = System.Drawing.Color.White
        Me.MetroTabControl1.ItemColor = System.Drawing.Color.White
        Me.MetroTabControl1.ItemForeColor = System.Drawing.Color.Black
        Me.MetroTabControl1.ItemSize = New System.Drawing.Size(45, 120)
        Me.MetroTabControl1.Location = New System.Drawing.Point(12, 41)
        Me.MetroTabControl1.Multiline = True
        Me.MetroTabControl1.Name = "MetroTabControl1"
        Me.MetroTabControl1.SelectedBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.SelectedForeColor = System.Drawing.Color.White
        Me.MetroTabControl1.SelectedIndex = 0
        Me.MetroTabControl1.SelectedItemColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.SelectedItemLineColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTabControl1.Size = New System.Drawing.Size(841, 471)
        Me.MetroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.MetroTabControl1.TabContainerColor = System.Drawing.Color.White
        Me.MetroTabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.White
        Me.TabPage1.Controls.Add(Me.lvQueue)
        Me.TabPage1.Controls.Add(Me.MetroLabel2)
        Me.TabPage1.Controls.Add(Me.MetroButton1)
        Me.TabPage1.Controls.Add(Me.MetroTextbox1)
        Me.TabPage1.Controls.Add(Me.btnStartBot)
        Me.TabPage1.Controls.Add(Me.MetroLabel8)
        Me.TabPage1.Controls.Add(Me.tbMinutes)
        Me.TabPage1.Controls.Add(Me.tbSeconds)
        Me.TabPage1.Controls.Add(Me.MetroLabel7)
        Me.TabPage1.Controls.Add(Me.lbViewsGenerated)
        Me.TabPage1.Controls.Add(Me.MetroLabel6)
        Me.TabPage1.Controls.Add(Me.lbTitle)
        Me.TabPage1.Controls.Add(Me.MetroLabel3)
        Me.TabPage1.Controls.Add(Me.tbSongURL)
        Me.TabPage1.Controls.Add(Me.pbCover)
        Me.TabPage1.Controls.Add(Me.btnLoadAccounts)
        Me.TabPage1.Controls.Add(Me.lvAccounts)
        Me.TabPage1.Controls.Add(Me.lbAccounts)
        Me.TabPage1.Controls.Add(Me.MetroLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(124, 4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(713, 463)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "View Bot"
        '
        'lvQueue
        '
        Me.lvQueue.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.lvQueue.HideSelection = False
        Me.lvQueue.Location = New System.Drawing.Point(9, 248)
        Me.lvQueue.Name = "lvQueue"
        Me.lvQueue.Size = New System.Drawing.Size(249, 194)
        Me.lvQueue.TabIndex = 40
        Me.lvQueue.UseCompatibleStateImageBehavior = False
        Me.lvQueue.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Username"
        Me.ColumnHeader1.Width = 101
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Password"
        Me.ColumnHeader2.Width = 125
        '
        'MetroLabel2
        '
        Me.MetroLabel2.AutoSize = True
        Me.MetroLabel2.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel2.Location = New System.Drawing.Point(6, 230)
        Me.MetroLabel2.Name = "MetroLabel2"
        Me.MetroLabel2.Size = New System.Drawing.Size(111, 15)
        Me.MetroLabel2.TabIndex = 39
        Me.MetroLabel2.Text = "Accounts in Queue:"
        '
        'MetroButton1
        '
        Me.MetroButton1.BackColor = System.Drawing.Color.Transparent
        Me.MetroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroButton1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroButton1.DefaultColor = System.Drawing.Color.White
        Me.MetroButton1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroButton1.HoverColor = System.Drawing.Color.White
        Me.MetroButton1.Location = New System.Drawing.Point(621, 71)
        Me.MetroButton1.Name = "MetroButton1"
        Me.MetroButton1.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroButton1.RoundingArc = 23
        Me.MetroButton1.Size = New System.Drawing.Size(75, 23)
        Me.MetroButton1.TabIndex = 38
        Me.MetroButton1.Text = "..."
        '
        'MetroTextbox1
        '
        Me.MetroTextbox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroTextbox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.MetroTextbox1.DefaultColor = System.Drawing.Color.White
        Me.MetroTextbox1.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.MetroTextbox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroTextbox1.ForeColor = System.Drawing.Color.Black
        Me.MetroTextbox1.HideSelection = False
        Me.MetroTextbox1.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroTextbox1.Location = New System.Drawing.Point(264, 71)
        Me.MetroTextbox1.Name = "MetroTextbox1"
        Me.MetroTextbox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.MetroTextbox1.Size = New System.Drawing.Size(351, 23)
        Me.MetroTextbox1.TabIndex = 37
        Me.MetroTextbox1.Watermark = "Proxy file"
        '
        'btnStartBot
        '
        Me.btnStartBot.BackColor = System.Drawing.Color.Transparent
        Me.btnStartBot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnStartBot.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnStartBot.DefaultColor = System.Drawing.Color.White
        Me.btnStartBot.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnStartBot.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnStartBot.HoverColor = System.Drawing.Color.White
        Me.btnStartBot.Location = New System.Drawing.Point(511, 419)
        Me.btnStartBot.Name = "btnStartBot"
        Me.btnStartBot.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnStartBot.RoundingArc = 23
        Me.btnStartBot.Size = New System.Drawing.Size(185, 23)
        Me.btnStartBot.TabIndex = 36
        Me.btnStartBot.Text = "Start"
        '
        'MetroLabel8
        '
        Me.MetroLabel8.AutoSize = True
        Me.MetroLabel8.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel8.Location = New System.Drawing.Point(295, 128)
        Me.MetroLabel8.Name = "MetroLabel8"
        Me.MetroLabel8.Size = New System.Drawing.Size(10, 15)
        Me.MetroLabel8.TabIndex = 35
        Me.MetroLabel8.Text = ":"
        '
        'tbMinutes
        '
        Me.tbMinutes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbMinutes.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tbMinutes.DefaultColor = System.Drawing.Color.White
        Me.tbMinutes.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tbMinutes.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbMinutes.ForeColor = System.Drawing.Color.Black
        Me.tbMinutes.HideSelection = False
        Me.tbMinutes.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tbMinutes.IllegalChars = "abcdefghijklmnopqrstuvwxyzäöü,.-"
        Me.tbMinutes.Location = New System.Drawing.Point(305, 124)
        Me.tbMinutes.Name = "tbMinutes"
        Me.tbMinutes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMinutes.Size = New System.Drawing.Size(30, 23)
        Me.tbMinutes.TabIndex = 34
        Me.tbMinutes.Text = "00"
        Me.tbMinutes.Watermark = "00"
        '
        'tbSeconds
        '
        Me.tbSeconds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbSeconds.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tbSeconds.DefaultColor = System.Drawing.Color.White
        Me.tbSeconds.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tbSeconds.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSeconds.ForeColor = System.Drawing.Color.Black
        Me.tbSeconds.HideSelection = False
        Me.tbSeconds.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tbSeconds.IllegalChars = "abcdefghijklmnopqrstuvwxyzäöü,.-"
        Me.tbSeconds.Location = New System.Drawing.Point(265, 124)
        Me.tbSeconds.Name = "tbSeconds"
        Me.tbSeconds.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSeconds.Size = New System.Drawing.Size(30, 23)
        Me.tbSeconds.TabIndex = 33
        Me.tbSeconds.Text = "00"
        Me.tbSeconds.Watermark = "00"
        '
        'MetroLabel7
        '
        Me.MetroLabel7.AutoSize = True
        Me.MetroLabel7.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel7.Location = New System.Drawing.Point(262, 103)
        Me.MetroLabel7.Name = "MetroLabel7"
        Me.MetroLabel7.Size = New System.Drawing.Size(59, 15)
        Me.MetroLabel7.TabIndex = 32
        Me.MetroLabel7.Text = "Play until:"
        '
        'lbViewsGenerated
        '
        Me.lbViewsGenerated.AutoSize = True
        Me.lbViewsGenerated.BackColor = System.Drawing.Color.Transparent
        Me.lbViewsGenerated.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbViewsGenerated.Location = New System.Drawing.Point(610, 219)
        Me.lbViewsGenerated.Name = "lbViewsGenerated"
        Me.lbViewsGenerated.Size = New System.Drawing.Size(16, 15)
        Me.lbViewsGenerated.TabIndex = 31
        Me.lbViewsGenerated.Text = "..."
        '
        'MetroLabel6
        '
        Me.MetroLabel6.AutoSize = True
        Me.MetroLabel6.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel6.Location = New System.Drawing.Point(508, 219)
        Me.MetroLabel6.Name = "MetroLabel6"
        Me.MetroLabel6.Size = New System.Drawing.Size(96, 15)
        Me.MetroLabel6.TabIndex = 30
        Me.MetroLabel6.Text = "Views generated:"
        '
        'lbTitle
        '
        Me.lbTitle.AutoSize = True
        Me.lbTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbTitle.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbTitle.Location = New System.Drawing.Point(547, 204)
        Me.lbTitle.Name = "lbTitle"
        Me.lbTitle.Size = New System.Drawing.Size(16, 15)
        Me.lbTitle.TabIndex = 29
        Me.lbTitle.Text = "..."
        '
        'MetroLabel3
        '
        Me.MetroLabel3.AutoSize = True
        Me.MetroLabel3.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel3.Location = New System.Drawing.Point(508, 204)
        Me.MetroLabel3.Name = "MetroLabel3"
        Me.MetroLabel3.Size = New System.Drawing.Size(32, 15)
        Me.MetroLabel3.TabIndex = 28
        Me.MetroLabel3.Text = "Title:"
        '
        'tbSongURL
        '
        Me.tbSongURL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.tbSongURL.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.tbSongURL.DefaultColor = System.Drawing.Color.White
        Me.tbSongURL.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.tbSongURL.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tbSongURL.ForeColor = System.Drawing.Color.Black
        Me.tbSongURL.HideSelection = False
        Me.tbSongURL.HoverColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.tbSongURL.Location = New System.Drawing.Point(264, 42)
        Me.tbSongURL.Name = "tbSongURL"
        Me.tbSongURL.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSongURL.Size = New System.Drawing.Size(432, 23)
        Me.tbSongURL.TabIndex = 27
        Me.tbSongURL.Watermark = "Song URL"
        '
        'pbCover
        '
        Me.pbCover.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.pbCover.Location = New System.Drawing.Point(264, 204)
        Me.pbCover.Name = "pbCover"
        Me.pbCover.Size = New System.Drawing.Size(238, 238)
        Me.pbCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCover.TabIndex = 25
        Me.pbCover.TabStop = False
        '
        'btnLoadAccounts
        '
        Me.btnLoadAccounts.BackColor = System.Drawing.Color.Transparent
        Me.btnLoadAccounts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnLoadAccounts.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.btnLoadAccounts.DefaultColor = System.Drawing.Color.White
        Me.btnLoadAccounts.DisabledColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer), CType(CType(250, Byte), Integer))
        Me.btnLoadAccounts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btnLoadAccounts.HoverColor = System.Drawing.Color.White
        Me.btnLoadAccounts.Location = New System.Drawing.Point(9, 204)
        Me.btnLoadAccounts.Name = "btnLoadAccounts"
        Me.btnLoadAccounts.PressedColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnLoadAccounts.RoundingArc = 23
        Me.btnLoadAccounts.Size = New System.Drawing.Size(249, 23)
        Me.btnLoadAccounts.TabIndex = 22
        Me.btnLoadAccounts.Text = "Load accounts"
        '
        'lvAccounts
        '
        Me.lvAccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader17, Me.ColumnHeader21})
        Me.lvAccounts.HideSelection = False
        Me.lvAccounts.Location = New System.Drawing.Point(9, 42)
        Me.lvAccounts.Name = "lvAccounts"
        Me.lvAccounts.Size = New System.Drawing.Size(249, 161)
        Me.lvAccounts.TabIndex = 21
        Me.lvAccounts.UseCompatibleStateImageBehavior = False
        Me.lvAccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = "Username"
        Me.ColumnHeader17.Width = 101
        '
        'ColumnHeader21
        '
        Me.ColumnHeader21.Text = "Password"
        Me.ColumnHeader21.Width = 125
        '
        'lbAccounts
        '
        Me.lbAccounts.AutoSize = True
        Me.lbAccounts.BackColor = System.Drawing.Color.Transparent
        Me.lbAccounts.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbAccounts.Location = New System.Drawing.Point(66, 24)
        Me.lbAccounts.Name = "lbAccounts"
        Me.lbAccounts.Size = New System.Drawing.Size(13, 15)
        Me.lbAccounts.TabIndex = 1
        Me.lbAccounts.Text = "0"
        '
        'MetroLabel1
        '
        Me.MetroLabel1.AutoSize = True
        Me.MetroLabel1.BackColor = System.Drawing.Color.Transparent
        Me.MetroLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroLabel1.Location = New System.Drawing.Point(6, 24)
        Me.MetroLabel1.Name = "MetroLabel1"
        Me.MetroLabel1.Size = New System.Drawing.Size(60, 15)
        Me.MetroLabel1.TabIndex = 0
        Me.MetroLabel1.Text = "Accounts:"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.White
        Me.TabPage3.Controls.Add(Me.lvSongs)
        Me.TabPage3.Location = New System.Drawing.Point(124, 4)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(713, 463)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "My Songs"
        '
        'lvSongs
        '
        Me.lvSongs.HideSelection = False
        Me.lvSongs.Location = New System.Drawing.Point(3, 3)
        Me.lvSongs.Name = "lvSongs"
        Me.lvSongs.Size = New System.Drawing.Size(707, 457)
        Me.lvSongs.TabIndex = 22
        Me.lvSongs.UseCompatibleStateImageBehavior = False
        Me.lvSongs.View = System.Windows.Forms.View.Details
        '
        'MetroStatusStrip1
        '
        Me.MetroStatusStrip1.DefaultColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.MetroStatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MetroStatusStrip1.ForeColor = System.Drawing.Color.Black
        Me.MetroStatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.MetroStatusStrip1.Location = New System.Drawing.Point(0, 514)
        Me.MetroStatusStrip1.Name = "MetroStatusStrip1"
        Me.MetroStatusStrip1.Size = New System.Drawing.Size(865, 22)
        Me.MetroStatusStrip1.TabIndex = 1
        Me.MetroStatusStrip1.Text = "MetroStatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(122, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(16, 17)
        Me.ToolStripStatusLabel1.Text = "..."
        '
        'TimerStart
        '
        Me.TimerStart.Interval = 3000
        '
        'SongListener2
        '
        '
        'FlatNumeric1
        '
        Me.FlatNumeric1.Location = New System.Drawing.Point(883, 508)
        Me.FlatNumeric1.Name = "FlatNumeric1"
        Me.FlatNumeric1.Size = New System.Drawing.Size(41, 23)
        Me.FlatNumeric1.TabIndex = 19
        Me.FlatNumeric1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'MetroControlBox1
        '
        Me.MetroControlBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MetroControlBox1.Location = New System.Drawing.Point(757, 7)
        Me.MetroControlBox1.Name = "MetroControlBox1"
        Me.MetroControlBox1.Size = New System.Drawing.Size(96, 32)
        Me.MetroControlBox1.TabIndex = 20
        '
        'ProxyCheck
        '
        '
        'StartBringer
        '
        Me.StartBringer.Interval = 1000
        '
        'BackgroundWorker1
        '
        '
        'BotForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(865, 536)
        Me.Controls.Add(Me.MetroControlBox1)
        Me.Controls.Add(Me.FlatNumeric1)
        Me.Controls.Add(Me.MetroStatusStrip1)
        Me.Controls.Add(Me.MetroTabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BotForm"
        Me.Opacity = 0R
        Me.State = MetroSuite.MetroForm.FormState.Normal
        Me.Style = MetroSuite.Design.Style.Light
        Me.Text = "Bot.Core"
        Me.MetroTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.pbCover, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.MetroStatusStrip1.ResumeLayout(False)
        Me.MetroStatusStrip1.PerformLayout()
        CType(Me.FlatNumeric1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MetroTabControl1 As MetroSuite.MetroTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents btnStartBot As MetroSuite.MetroButton
    Friend WithEvents MetroLabel8 As MetroSuite.MetroLabel
    Friend WithEvents tbMinutes As MetroSuite.MetroTextbox
    Friend WithEvents tbSeconds As MetroSuite.MetroTextbox
    Friend WithEvents MetroLabel7 As MetroSuite.MetroLabel
    Friend WithEvents lbViewsGenerated As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel6 As MetroSuite.MetroLabel
    Friend WithEvents lbTitle As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel3 As MetroSuite.MetroLabel
    Friend WithEvents tbSongURL As MetroSuite.MetroTextbox
    Friend WithEvents pbCover As PictureBox
    Friend WithEvents btnLoadAccounts As MetroSuite.MetroButton
    Friend WithEvents lvAccounts As ListView
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents ColumnHeader21 As ColumnHeader
    Friend WithEvents lbAccounts As MetroSuite.MetroLabel
    Friend WithEvents MetroLabel1 As MetroSuite.MetroLabel
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MetroStatusStrip1 As MetroSuite.MetroStatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents lvSongs As ListView
    Friend WithEvents TimerStart As Timer
    Friend WithEvents SongListener2 As Timer
    Friend WithEvents FlatNumeric1 As NumericUpDown
    Friend WithEvents MetroControlBox1 As MetroSuite.MetroControlBox
    Friend WithEvents MetroButton1 As MetroSuite.MetroButton
    Friend WithEvents MetroTextbox1 As MetroSuite.MetroTextbox
    Friend WithEvents ProxyCheck As Timer
    Friend WithEvents StartBringer As Timer
    Friend WithEvents lvQueue As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents MetroLabel2 As MetroSuite.MetroLabel
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
