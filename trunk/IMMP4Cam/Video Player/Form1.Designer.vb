<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IMMP4Cam
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IMMP4Cam))
        Me.FolderBrowserDialogRecordFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabelStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelFramerate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelBitrate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabelMotion = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TimerUpdateStatus = New System.Windows.Forms.Timer(Me.components)
        Me.TimerCheckMotion = New System.Windows.Forms.Timer(Me.components)
        Me.TimerRecordStop = New System.Windows.Forms.Timer(Me.components)
        Me.TimerUpdateFileList = New System.Windows.Forms.Timer(Me.components)
        Me.TabPageSettings = New System.Windows.Forms.TabPage()
        Me.ButtonRestart = New System.Windows.Forms.Button()
        Me.PanelUsernamePassword = New System.Windows.Forms.Panel()
        Me.ButtonPassword = New System.Windows.Forms.Button()
        Me.ButtonUsername = New System.Windows.Forms.Button()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.LabelPassword = New System.Windows.Forms.Label()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.PanelCameraSettings2 = New System.Windows.Forms.Panel()
        Me.NumericUpDownSaturation = New System.Windows.Forms.NumericUpDown()
        Me.LabelSaturation = New System.Windows.Forms.Label()
        Me.ButtonSetCameraParametersColours = New System.Windows.Forms.Button()
        Me.NumericUpDownContrast = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownBrightness = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownColour = New System.Windows.Forms.NumericUpDown()
        Me.LabelContrast = New System.Windows.Forms.Label()
        Me.LabelBrightness = New System.Windows.Forms.Label()
        Me.LabelColour = New System.Windows.Forms.Label()
        Me.PanelProgramSettings = New System.Windows.Forms.Panel()
        Me.CheckBoxAutoDelete = New System.Windows.Forms.CheckBox()
        Me.NumericUpDownAutoDelete = New System.Windows.Forms.NumericUpDown()
        Me.LabelAutoDelete = New System.Windows.Forms.Label()
        Me.LabelTriggerLevelOff = New System.Windows.Forms.Label()
        Me.LabelTriggerLevelOn = New System.Windows.Forms.Label()
        Me.NumericUpDownTriggerLevelOff = New System.Windows.Forms.NumericUpDown()
        Me.ButtonChangeRecordFolder = New System.Windows.Forms.Button()
        Me.ButtonChangeCameraIP = New System.Windows.Forms.Button()
        Me.ButtonChangeCameraPort = New System.Windows.Forms.Button()
        Me.ButtonChangeCameraName = New System.Windows.Forms.Button()
        Me.TextBoxCameraPort = New System.Windows.Forms.TextBox()
        Me.LabelCameraPort = New System.Windows.Forms.Label()
        Me.LabelMotionRecord = New System.Windows.Forms.Label()
        Me.TextBoxCameraIP = New System.Windows.Forms.TextBox()
        Me.TextBoxCameraName = New System.Windows.Forms.TextBox()
        Me.LabelCameraIP = New System.Windows.Forms.Label()
        Me.LabelCameraName = New System.Windows.Forms.Label()
        Me.NumericUpDownRecordDuration = New System.Windows.Forms.NumericUpDown()
        Me.LabelRecordDuration = New System.Windows.Forms.Label()
        Me.CheckBoxMotionRecord = New System.Windows.Forms.CheckBox()
        Me.TextBoxRecordFolder = New System.Windows.Forms.TextBox()
        Me.LabelRecordFolder = New System.Windows.Forms.Label()
        Me.LabelTriggerLevel = New System.Windows.Forms.Label()
        Me.NumericUpDownTriggerLevelOn = New System.Windows.Forms.NumericUpDown()
        Me.PanelCameraSettings1 = New System.Windows.Forms.Panel()
        Me.ButtonSetCameraParametersTrim = New System.Windows.Forms.Button()
        Me.NumericUpDownTrimRight = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownTrimLeft = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ButtonSetCameraParametersMotion = New System.Windows.Forms.Button()
        Me.NumericUpDownDilation = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownErosion = New System.Windows.Forms.NumericUpDown()
        Me.NumericUpDownSensitivity = New System.Windows.Forms.NumericUpDown()
        Me.LabelDilation = New System.Windows.Forms.Label()
        Me.LabelErosion = New System.Windows.Forms.Label()
        Me.LabelSensitivity = New System.Windows.Forms.Label()
        Me.TabPagePlayback = New System.Windows.Forms.TabPage()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.ButtonPanUp = New System.Windows.Forms.Button()
        Me.ButtonPanLeft = New System.Windows.Forms.Button()
        Me.ButtonPanDown = New System.Windows.Forms.Button()
        Me.ButtonPanRight = New System.Windows.Forms.Button()
        Me.ButtonZoomIn = New System.Windows.Forms.Button()
        Me.ButtonZoomOut = New System.Windows.Forms.Button()
        Me.ButtonPause = New System.Windows.Forms.Button()
        Me.PanelWMPStatus = New System.Windows.Forms.Panel()
        Me.LabelWMPTimeStatusDivider = New System.Windows.Forms.Label()
        Me.TextBoxWMPNowPlaying = New System.Windows.Forms.TextBox()
        Me.TextBoxWMPDuration = New System.Windows.Forms.TextBox()
        Me.TextBoxWMPCurrentTime = New System.Windows.Forms.TextBox()
        Me.ButtonStop = New System.Windows.Forms.Button()
        Me.ButtonPlay = New System.Windows.Forms.Button()
        Me.LabelFileListDate = New System.Windows.Forms.Label()
        Me.LabelTotalMB = New System.Windows.Forms.Label()
        Me.TextBoxTotalDiskSpace = New System.Windows.Forms.TextBox()
        Me.TextBoxTotalNumberOfFiles = New System.Windows.Forms.TextBox()
        Me.TextBoxFileListDate = New System.Windows.Forms.TextBox()
        Me.TextBoxDiskSpace = New System.Windows.Forms.TextBox()
        Me.TextBoxNumberOfFiles = New System.Windows.Forms.TextBox()
        Me.LabelTotalFiles = New System.Windows.Forms.Label()
        Me.ButtonDeleteAllFiles = New System.Windows.Forms.Button()
        Me.ButtonNextDay = New System.Windows.Forms.Button()
        Me.ButtonPreviousDay = New System.Windows.Forms.Button()
        Me.LabelMB = New System.Windows.Forms.Label()
        Me.LabelDiskSpace = New System.Windows.Forms.Label()
        Me.LabelNumberFiles = New System.Windows.Forms.Label()
        Me.ButtonFrameToStart = New System.Windows.Forms.Button()
        Me.ButtonFrameAdvance = New System.Windows.Forms.Button()
        Me.ButtonPlayAllFiles = New System.Windows.Forms.Button()
        Me.ButtonReverseFileList = New System.Windows.Forms.Button()
        Me.ButtonPlaySelectedFile = New System.Windows.Forms.Button()
        Me.LabelPlaybackSpeed = New System.Windows.Forms.Label()
        Me.NumericUpDownPlaybackSpeed = New System.Windows.Forms.NumericUpDown()
        Me.ButtonDeleteSingleFile = New System.Windows.Forms.Button()
        Me.ListBoxFileList = New System.Windows.Forms.ListBox()
        Me.PanelWMPControl = New System.Windows.Forms.Panel()
        Me.WMPControl = New AxWMPLib.AxWindowsMediaPlayer()
        Me.TabPageLiveView = New System.Windows.Forms.TabPage()
        Me.TextBoxLastTrigger = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.IMMP4Control = New AxIMMP4ControlLib.AxIMMP4Control()
        Me.PanelStatus = New System.Windows.Forms.Panel()
        Me.TextBoxDate = New System.Windows.Forms.TextBox()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.TextBoxLiveViewCameraIP = New System.Windows.Forms.TextBox()
        Me.TextBoxLiveViewCameraName = New System.Windows.Forms.TextBox()
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TimerWMPStatus = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCameraSettings3 = New System.Windows.Forms.Panel()
        Me.ButtonSetCameraParametersCompression = New System.Windows.Forms.Button()
        Me.NumericUpDownCompression = New System.Windows.Forms.NumericUpDown()
        Me.LabelCompression = New System.Windows.Forms.Label()
        Me.PanelCameraInfo = New System.Windows.Forms.Panel()
        Me.LabelOCXVersion = New System.Windows.Forms.Label()
        Me.TextBoxOCXVersion = New System.Windows.Forms.TextBox()
        Me.StatusStrip.SuspendLayout()
        Me.TabPageSettings.SuspendLayout()
        Me.PanelUsernamePassword.SuspendLayout()
        Me.PanelCameraSettings2.SuspendLayout()
        CType(Me.NumericUpDownSaturation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownContrast, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownBrightness, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownColour, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelProgramSettings.SuspendLayout()
        CType(Me.NumericUpDownAutoDelete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTriggerLevelOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownRecordDuration, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTriggerLevelOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCameraSettings1.SuspendLayout()
        CType(Me.NumericUpDownTrimRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownTrimLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownDilation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownErosion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownSensitivity, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPagePlayback.SuspendLayout()
        Me.PanelWMPStatus.SuspendLayout()
        CType(Me.NumericUpDownPlaybackSpeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelWMPControl.SuspendLayout()
        CType(Me.WMPControl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPageLiveView.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IMMP4Control, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelStatus.SuspendLayout()
        Me.TabControl.SuspendLayout()
        Me.PanelCameraSettings3.SuspendLayout()
        CType(Me.NumericUpDownCompression, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelCameraInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.AutoSize = False
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabelStatus, Me.ToolStripStatusLabelFramerate, Me.ToolStripStatusLabelBitrate, Me.ToolStripStatusLabelMotion})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 734)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(783, 25)
        Me.StatusStrip.SizingGrip = False
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'ToolStripStatusLabelStatus
        '
        Me.ToolStripStatusLabelStatus.AutoSize = False
        Me.ToolStripStatusLabelStatus.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelStatus.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelStatus.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabelStatus.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelStatus.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabelStatus.Name = "ToolStripStatusLabelStatus"
        Me.ToolStripStatusLabelStatus.Size = New System.Drawing.Size(195, 20)
        '
        'ToolStripStatusLabelFramerate
        '
        Me.ToolStripStatusLabelFramerate.AutoSize = False
        Me.ToolStripStatusLabelFramerate.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelFramerate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelFramerate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabelFramerate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelFramerate.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabelFramerate.Name = "ToolStripStatusLabelFramerate"
        Me.ToolStripStatusLabelFramerate.Size = New System.Drawing.Size(195, 20)
        '
        'ToolStripStatusLabelBitrate
        '
        Me.ToolStripStatusLabelBitrate.AutoSize = False
        Me.ToolStripStatusLabelBitrate.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelBitrate.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelBitrate.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabelBitrate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelBitrate.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabelBitrate.Name = "ToolStripStatusLabelBitrate"
        Me.ToolStripStatusLabelBitrate.Size = New System.Drawing.Size(195, 20)
        '
        'ToolStripStatusLabelMotion
        '
        Me.ToolStripStatusLabelMotion.AutoSize = False
        Me.ToolStripStatusLabelMotion.BackColor = System.Drawing.Color.Black
        Me.ToolStripStatusLabelMotion.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.ToolStripStatusLabelMotion.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenInner
        Me.ToolStripStatusLabelMotion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabelMotion.ForeColor = System.Drawing.Color.Lime
        Me.ToolStripStatusLabelMotion.Name = "ToolStripStatusLabelMotion"
        Me.ToolStripStatusLabelMotion.Size = New System.Drawing.Size(195, 20)
        '
        'TimerUpdateStatus
        '
        Me.TimerUpdateStatus.Interval = 1000
        '
        'TimerCheckMotion
        '
        Me.TimerCheckMotion.Interval = 40
        '
        'TimerRecordStop
        '
        Me.TimerRecordStop.Interval = 5000
        '
        'TimerUpdateFileList
        '
        '
        'TabPageSettings
        '
        Me.TabPageSettings.Controls.Add(Me.PanelCameraInfo)
        Me.TabPageSettings.Controls.Add(Me.PanelCameraSettings3)
        Me.TabPageSettings.Controls.Add(Me.ButtonRestart)
        Me.TabPageSettings.Controls.Add(Me.PanelUsernamePassword)
        Me.TabPageSettings.Controls.Add(Me.PanelCameraSettings2)
        Me.TabPageSettings.Controls.Add(Me.PanelProgramSettings)
        Me.TabPageSettings.Controls.Add(Me.PanelCameraSettings1)
        Me.TabPageSettings.Location = New System.Drawing.Point(4, 22)
        Me.TabPageSettings.Name = "TabPageSettings"
        Me.TabPageSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageSettings.Size = New System.Drawing.Size(753, 684)
        Me.TabPageSettings.TabIndex = 2
        Me.TabPageSettings.Text = "Settings"
        Me.TabPageSettings.UseVisualStyleBackColor = True
        '
        'ButtonRestart
        '
        Me.ButtonRestart.Location = New System.Drawing.Point(522, 633)
        Me.ButtonRestart.Name = "ButtonRestart"
        Me.ButtonRestart.Size = New System.Drawing.Size(60, 20)
        Me.ButtonRestart.TabIndex = 46
        Me.ButtonRestart.Text = "Restart"
        Me.ButtonRestart.UseVisualStyleBackColor = True
        '
        'PanelUsernamePassword
        '
        Me.PanelUsernamePassword.BackColor = System.Drawing.SystemColors.Control
        Me.PanelUsernamePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelUsernamePassword.Controls.Add(Me.ButtonPassword)
        Me.PanelUsernamePassword.Controls.Add(Me.ButtonUsername)
        Me.PanelUsernamePassword.Controls.Add(Me.TextBoxPassword)
        Me.PanelUsernamePassword.Controls.Add(Me.TextBoxUsername)
        Me.PanelUsernamePassword.Controls.Add(Me.LabelPassword)
        Me.PanelUsernamePassword.Controls.Add(Me.LabelUsername)
        Me.PanelUsernamePassword.Location = New System.Drawing.Point(390, 122)
        Me.PanelUsernamePassword.Name = "PanelUsernamePassword"
        Me.PanelUsernamePassword.Size = New System.Drawing.Size(327, 90)
        Me.PanelUsernamePassword.TabIndex = 47
        '
        'ButtonPassword
        '
        Me.ButtonPassword.Location = New System.Drawing.Point(263, 49)
        Me.ButtonPassword.Name = "ButtonPassword"
        Me.ButtonPassword.Size = New System.Drawing.Size(40, 20)
        Me.ButtonPassword.TabIndex = 41
        Me.ButtonPassword.Text = "Edit"
        Me.ButtonPassword.UseVisualStyleBackColor = True
        '
        'ButtonUsername
        '
        Me.ButtonUsername.Location = New System.Drawing.Point(264, 14)
        Me.ButtonUsername.Name = "ButtonUsername"
        Me.ButtonUsername.Size = New System.Drawing.Size(40, 20)
        Me.ButtonUsername.TabIndex = 39
        Me.ButtonUsername.Text = "Edit"
        Me.ButtonUsername.UseVisualStyleBackColor = True
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.BackColor = System.Drawing.Color.White
        Me.TextBoxPassword.Location = New System.Drawing.Point(131, 50)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.ReadOnly = True
        Me.TextBoxPassword.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxPassword.TabIndex = 29
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.BackColor = System.Drawing.Color.White
        Me.TextBoxUsername.Location = New System.Drawing.Point(131, 15)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.ReadOnly = True
        Me.TextBoxUsername.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxUsername.TabIndex = 28
        '
        'LabelPassword
        '
        Me.LabelPassword.AutoSize = True
        Me.LabelPassword.Location = New System.Drawing.Point(12, 53)
        Me.LabelPassword.Name = "LabelPassword"
        Me.LabelPassword.Size = New System.Drawing.Size(91, 13)
        Me.LabelPassword.TabIndex = 27
        Me.LabelPassword.Text = "Camera password"
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Location = New System.Drawing.Point(12, 18)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(92, 13)
        Me.LabelUsername.TabIndex = 26
        Me.LabelUsername.Text = "Camera username"
        '
        'PanelCameraSettings2
        '
        Me.PanelCameraSettings2.BackColor = System.Drawing.SystemColors.Control
        Me.PanelCameraSettings2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCameraSettings2.Controls.Add(Me.NumericUpDownSaturation)
        Me.PanelCameraSettings2.Controls.Add(Me.LabelSaturation)
        Me.PanelCameraSettings2.Controls.Add(Me.ButtonSetCameraParametersColours)
        Me.PanelCameraSettings2.Controls.Add(Me.NumericUpDownContrast)
        Me.PanelCameraSettings2.Controls.Add(Me.NumericUpDownBrightness)
        Me.PanelCameraSettings2.Controls.Add(Me.NumericUpDownColour)
        Me.PanelCameraSettings2.Controls.Add(Me.LabelContrast)
        Me.PanelCameraSettings2.Controls.Add(Me.LabelBrightness)
        Me.PanelCameraSettings2.Controls.Add(Me.LabelColour)
        Me.PanelCameraSettings2.Location = New System.Drawing.Point(390, 248)
        Me.PanelCameraSettings2.Name = "PanelCameraSettings2"
        Me.PanelCameraSettings2.Size = New System.Drawing.Size(327, 204)
        Me.PanelCameraSettings2.TabIndex = 46
        '
        'NumericUpDownSaturation
        '
        Me.NumericUpDownSaturation.Location = New System.Drawing.Point(199, 122)
        Me.NumericUpDownSaturation.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownSaturation.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownSaturation.Name = "NumericUpDownSaturation"
        Me.NumericUpDownSaturation.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownSaturation.TabIndex = 45
        Me.NumericUpDownSaturation.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'LabelSaturation
        '
        Me.LabelSaturation.AutoSize = True
        Me.LabelSaturation.Location = New System.Drawing.Point(67, 124)
        Me.LabelSaturation.Name = "LabelSaturation"
        Me.LabelSaturation.Size = New System.Drawing.Size(55, 13)
        Me.LabelSaturation.TabIndex = 44
        Me.LabelSaturation.Text = "Saturation"
        '
        'ButtonSetCameraParametersColours
        '
        Me.ButtonSetCameraParametersColours.Location = New System.Drawing.Point(131, 161)
        Me.ButtonSetCameraParametersColours.Name = "ButtonSetCameraParametersColours"
        Me.ButtonSetCameraParametersColours.Size = New System.Drawing.Size(60, 20)
        Me.ButtonSetCameraParametersColours.TabIndex = 43
        Me.ButtonSetCameraParametersColours.Text = "Set"
        Me.ButtonSetCameraParametersColours.UseVisualStyleBackColor = True
        '
        'NumericUpDownContrast
        '
        Me.NumericUpDownContrast.Location = New System.Drawing.Point(199, 88)
        Me.NumericUpDownContrast.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownContrast.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownContrast.Name = "NumericUpDownContrast"
        Me.NumericUpDownContrast.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownContrast.TabIndex = 36
        Me.NumericUpDownContrast.Value = New Decimal(New Integer() {128, 0, 0, 0})
        '
        'NumericUpDownBrightness
        '
        Me.NumericUpDownBrightness.Location = New System.Drawing.Point(199, 53)
        Me.NumericUpDownBrightness.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownBrightness.Minimum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownBrightness.Name = "NumericUpDownBrightness"
        Me.NumericUpDownBrightness.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownBrightness.TabIndex = 35
        Me.NumericUpDownBrightness.Value = New Decimal(New Integer() {80, 0, 0, 0})
        '
        'NumericUpDownColour
        '
        Me.NumericUpDownColour.Location = New System.Drawing.Point(199, 18)
        Me.NumericUpDownColour.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownColour.Name = "NumericUpDownColour"
        Me.NumericUpDownColour.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownColour.TabIndex = 34
        Me.NumericUpDownColour.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'LabelContrast
        '
        Me.LabelContrast.AutoSize = True
        Me.LabelContrast.Location = New System.Drawing.Point(67, 90)
        Me.LabelContrast.Name = "LabelContrast"
        Me.LabelContrast.Size = New System.Drawing.Size(46, 13)
        Me.LabelContrast.TabIndex = 33
        Me.LabelContrast.Text = "Contrast"
        '
        'LabelBrightness
        '
        Me.LabelBrightness.AutoSize = True
        Me.LabelBrightness.Location = New System.Drawing.Point(67, 55)
        Me.LabelBrightness.Name = "LabelBrightness"
        Me.LabelBrightness.Size = New System.Drawing.Size(56, 13)
        Me.LabelBrightness.TabIndex = 32
        Me.LabelBrightness.Text = "Brightness"
        '
        'LabelColour
        '
        Me.LabelColour.AutoSize = True
        Me.LabelColour.Location = New System.Drawing.Point(68, 20)
        Me.LabelColour.Name = "LabelColour"
        Me.LabelColour.Size = New System.Drawing.Size(37, 13)
        Me.LabelColour.TabIndex = 31
        Me.LabelColour.Text = "Colour"
        '
        'PanelProgramSettings
        '
        Me.PanelProgramSettings.BackColor = System.Drawing.SystemColors.Control
        Me.PanelProgramSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelProgramSettings.Controls.Add(Me.CheckBoxAutoDelete)
        Me.PanelProgramSettings.Controls.Add(Me.NumericUpDownAutoDelete)
        Me.PanelProgramSettings.Controls.Add(Me.LabelAutoDelete)
        Me.PanelProgramSettings.Controls.Add(Me.LabelTriggerLevelOff)
        Me.PanelProgramSettings.Controls.Add(Me.LabelTriggerLevelOn)
        Me.PanelProgramSettings.Controls.Add(Me.NumericUpDownTriggerLevelOff)
        Me.PanelProgramSettings.Controls.Add(Me.ButtonChangeRecordFolder)
        Me.PanelProgramSettings.Controls.Add(Me.ButtonChangeCameraIP)
        Me.PanelProgramSettings.Controls.Add(Me.ButtonChangeCameraPort)
        Me.PanelProgramSettings.Controls.Add(Me.ButtonChangeCameraName)
        Me.PanelProgramSettings.Controls.Add(Me.TextBoxCameraPort)
        Me.PanelProgramSettings.Controls.Add(Me.LabelCameraPort)
        Me.PanelProgramSettings.Controls.Add(Me.LabelMotionRecord)
        Me.PanelProgramSettings.Controls.Add(Me.TextBoxCameraIP)
        Me.PanelProgramSettings.Controls.Add(Me.TextBoxCameraName)
        Me.PanelProgramSettings.Controls.Add(Me.LabelCameraIP)
        Me.PanelProgramSettings.Controls.Add(Me.LabelCameraName)
        Me.PanelProgramSettings.Controls.Add(Me.NumericUpDownRecordDuration)
        Me.PanelProgramSettings.Controls.Add(Me.LabelRecordDuration)
        Me.PanelProgramSettings.Controls.Add(Me.CheckBoxMotionRecord)
        Me.PanelProgramSettings.Controls.Add(Me.TextBoxRecordFolder)
        Me.PanelProgramSettings.Controls.Add(Me.LabelRecordFolder)
        Me.PanelProgramSettings.Controls.Add(Me.LabelTriggerLevel)
        Me.PanelProgramSettings.Controls.Add(Me.NumericUpDownTriggerLevelOn)
        Me.PanelProgramSettings.Location = New System.Drawing.Point(29, 31)
        Me.PanelProgramSettings.Name = "PanelProgramSettings"
        Me.PanelProgramSettings.Size = New System.Drawing.Size(327, 326)
        Me.PanelProgramSettings.TabIndex = 45
        '
        'CheckBoxAutoDelete
        '
        Me.CheckBoxAutoDelete.AutoSize = True
        Me.CheckBoxAutoDelete.Location = New System.Drawing.Point(209, 286)
        Me.CheckBoxAutoDelete.Name = "CheckBoxAutoDelete"
        Me.CheckBoxAutoDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxAutoDelete.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxAutoDelete.TabIndex = 48
        Me.CheckBoxAutoDelete.UseVisualStyleBackColor = True
        '
        'NumericUpDownAutoDelete
        '
        Me.NumericUpDownAutoDelete.Location = New System.Drawing.Point(131, 284)
        Me.NumericUpDownAutoDelete.Maximum = New Decimal(New Integer() {365, 0, 0, 0})
        Me.NumericUpDownAutoDelete.Name = "NumericUpDownAutoDelete"
        Me.NumericUpDownAutoDelete.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownAutoDelete.TabIndex = 47
        Me.NumericUpDownAutoDelete.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'LabelAutoDelete
        '
        Me.LabelAutoDelete.AutoSize = True
        Me.LabelAutoDelete.Location = New System.Drawing.Point(11, 286)
        Me.LabelAutoDelete.Name = "LabelAutoDelete"
        Me.LabelAutoDelete.Size = New System.Drawing.Size(89, 13)
        Me.LabelAutoDelete.TabIndex = 46
        Me.LabelAutoDelete.Text = "Autodelete (days)"
        '
        'LabelTriggerLevelOff
        '
        Me.LabelTriggerLevelOff.AutoSize = True
        Me.LabelTriggerLevelOff.Location = New System.Drawing.Point(282, 167)
        Me.LabelTriggerLevelOff.Name = "LabelTriggerLevelOff"
        Me.LabelTriggerLevelOff.Size = New System.Drawing.Size(21, 13)
        Me.LabelTriggerLevelOff.TabIndex = 45
        Me.LabelTriggerLevelOff.Text = "Off"
        '
        'LabelTriggerLevelOn
        '
        Me.LabelTriggerLevelOn.AutoSize = True
        Me.LabelTriggerLevelOn.Location = New System.Drawing.Point(186, 167)
        Me.LabelTriggerLevelOn.Name = "LabelTriggerLevelOn"
        Me.LabelTriggerLevelOn.Size = New System.Drawing.Size(21, 13)
        Me.LabelTriggerLevelOn.TabIndex = 44
        Me.LabelTriggerLevelOn.Text = "On"
        '
        'NumericUpDownTriggerLevelOff
        '
        Me.NumericUpDownTriggerLevelOff.DecimalPlaces = 2
        Me.NumericUpDownTriggerLevelOff.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDownTriggerLevelOff.Location = New System.Drawing.Point(226, 163)
        Me.NumericUpDownTriggerLevelOff.Name = "NumericUpDownTriggerLevelOff"
        Me.NumericUpDownTriggerLevelOff.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownTriggerLevelOff.TabIndex = 43
        Me.NumericUpDownTriggerLevelOff.Value = New Decimal(New Integer() {200, 0, 0, 131072})
        '
        'ButtonChangeRecordFolder
        '
        Me.ButtonChangeRecordFolder.Location = New System.Drawing.Point(263, 202)
        Me.ButtonChangeRecordFolder.Name = "ButtonChangeRecordFolder"
        Me.ButtonChangeRecordFolder.Size = New System.Drawing.Size(40, 20)
        Me.ButtonChangeRecordFolder.TabIndex = 42
        Me.ButtonChangeRecordFolder.Text = "Edit"
        Me.ButtonChangeRecordFolder.UseVisualStyleBackColor = True
        '
        'ButtonChangeCameraIP
        '
        Me.ButtonChangeCameraIP.Location = New System.Drawing.Point(263, 49)
        Me.ButtonChangeCameraIP.Name = "ButtonChangeCameraIP"
        Me.ButtonChangeCameraIP.Size = New System.Drawing.Size(40, 20)
        Me.ButtonChangeCameraIP.TabIndex = 41
        Me.ButtonChangeCameraIP.Text = "Edit"
        Me.ButtonChangeCameraIP.UseVisualStyleBackColor = True
        '
        'ButtonChangeCameraPort
        '
        Me.ButtonChangeCameraPort.Location = New System.Drawing.Point(263, 83)
        Me.ButtonChangeCameraPort.Name = "ButtonChangeCameraPort"
        Me.ButtonChangeCameraPort.Size = New System.Drawing.Size(40, 20)
        Me.ButtonChangeCameraPort.TabIndex = 40
        Me.ButtonChangeCameraPort.Text = "Edit"
        Me.ButtonChangeCameraPort.UseVisualStyleBackColor = True
        '
        'ButtonChangeCameraName
        '
        Me.ButtonChangeCameraName.Location = New System.Drawing.Point(264, 14)
        Me.ButtonChangeCameraName.Name = "ButtonChangeCameraName"
        Me.ButtonChangeCameraName.Size = New System.Drawing.Size(40, 20)
        Me.ButtonChangeCameraName.TabIndex = 39
        Me.ButtonChangeCameraName.Text = "Edit"
        Me.ButtonChangeCameraName.UseVisualStyleBackColor = True
        '
        'TextBoxCameraPort
        '
        Me.TextBoxCameraPort.BackColor = System.Drawing.Color.White
        Me.TextBoxCameraPort.Location = New System.Drawing.Point(130, 84)
        Me.TextBoxCameraPort.Name = "TextBoxCameraPort"
        Me.TextBoxCameraPort.ReadOnly = True
        Me.TextBoxCameraPort.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxCameraPort.TabIndex = 38
        '
        'LabelCameraPort
        '
        Me.LabelCameraPort.AutoSize = True
        Me.LabelCameraPort.Location = New System.Drawing.Point(11, 88)
        Me.LabelCameraPort.Name = "LabelCameraPort"
        Me.LabelCameraPort.Size = New System.Drawing.Size(26, 13)
        Me.LabelCameraPort.TabIndex = 37
        Me.LabelCameraPort.Text = "Port"
        '
        'LabelMotionRecord
        '
        Me.LabelMotionRecord.AutoSize = True
        Me.LabelMotionRecord.Location = New System.Drawing.Point(11, 128)
        Me.LabelMotionRecord.Name = "LabelMotionRecord"
        Me.LabelMotionRecord.Size = New System.Drawing.Size(72, 13)
        Me.LabelMotionRecord.TabIndex = 30
        Me.LabelMotionRecord.Text = "Motion record"
        '
        'TextBoxCameraIP
        '
        Me.TextBoxCameraIP.BackColor = System.Drawing.Color.White
        Me.TextBoxCameraIP.Location = New System.Drawing.Point(131, 50)
        Me.TextBoxCameraIP.Name = "TextBoxCameraIP"
        Me.TextBoxCameraIP.ReadOnly = True
        Me.TextBoxCameraIP.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxCameraIP.TabIndex = 29
        '
        'TextBoxCameraName
        '
        Me.TextBoxCameraName.BackColor = System.Drawing.Color.White
        Me.TextBoxCameraName.Location = New System.Drawing.Point(131, 15)
        Me.TextBoxCameraName.Name = "TextBoxCameraName"
        Me.TextBoxCameraName.ReadOnly = True
        Me.TextBoxCameraName.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxCameraName.TabIndex = 28
        '
        'LabelCameraIP
        '
        Me.LabelCameraIP.AutoSize = True
        Me.LabelCameraIP.Location = New System.Drawing.Point(12, 53)
        Me.LabelCameraIP.Name = "LabelCameraIP"
        Me.LabelCameraIP.Size = New System.Drawing.Size(96, 13)
        Me.LabelCameraIP.TabIndex = 27
        Me.LabelCameraIP.Text = "Camera IP address"
        '
        'LabelCameraName
        '
        Me.LabelCameraName.AutoSize = True
        Me.LabelCameraName.Location = New System.Drawing.Point(12, 18)
        Me.LabelCameraName.Name = "LabelCameraName"
        Me.LabelCameraName.Size = New System.Drawing.Size(72, 13)
        Me.LabelCameraName.TabIndex = 26
        Me.LabelCameraName.Text = "Camera name"
        '
        'NumericUpDownRecordDuration
        '
        Me.NumericUpDownRecordDuration.Location = New System.Drawing.Point(130, 245)
        Me.NumericUpDownRecordDuration.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.NumericUpDownRecordDuration.Name = "NumericUpDownRecordDuration"
        Me.NumericUpDownRecordDuration.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownRecordDuration.TabIndex = 25
        Me.NumericUpDownRecordDuration.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'LabelRecordDuration
        '
        Me.LabelRecordDuration.AutoSize = True
        Me.LabelRecordDuration.Location = New System.Drawing.Point(11, 247)
        Me.LabelRecordDuration.Name = "LabelRecordDuration"
        Me.LabelRecordDuration.Size = New System.Drawing.Size(97, 13)
        Me.LabelRecordDuration.TabIndex = 24
        Me.LabelRecordDuration.Text = "Record duration (s)"
        '
        'CheckBoxMotionRecord
        '
        Me.CheckBoxMotionRecord.AutoSize = True
        Me.CheckBoxMotionRecord.Checked = True
        Me.CheckBoxMotionRecord.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBoxMotionRecord.Location = New System.Drawing.Point(130, 128)
        Me.CheckBoxMotionRecord.Name = "CheckBoxMotionRecord"
        Me.CheckBoxMotionRecord.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBoxMotionRecord.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMotionRecord.TabIndex = 23
        Me.CheckBoxMotionRecord.UseVisualStyleBackColor = True
        '
        'TextBoxRecordFolder
        '
        Me.TextBoxRecordFolder.BackColor = System.Drawing.Color.White
        Me.TextBoxRecordFolder.Location = New System.Drawing.Point(130, 203)
        Me.TextBoxRecordFolder.Name = "TextBoxRecordFolder"
        Me.TextBoxRecordFolder.ReadOnly = True
        Me.TextBoxRecordFolder.Size = New System.Drawing.Size(107, 20)
        Me.TextBoxRecordFolder.TabIndex = 22
        Me.TextBoxRecordFolder.Text = "C:\IMMP4Cam"
        '
        'LabelRecordFolder
        '
        Me.LabelRecordFolder.AutoSize = True
        Me.LabelRecordFolder.Location = New System.Drawing.Point(11, 206)
        Me.LabelRecordFolder.Name = "LabelRecordFolder"
        Me.LabelRecordFolder.Size = New System.Drawing.Size(71, 13)
        Me.LabelRecordFolder.TabIndex = 21
        Me.LabelRecordFolder.Text = "Record folder"
        '
        'LabelTriggerLevel
        '
        Me.LabelTriggerLevel.AutoSize = True
        Me.LabelTriggerLevel.Location = New System.Drawing.Point(11, 165)
        Me.LabelTriggerLevel.Name = "LabelTriggerLevel"
        Me.LabelTriggerLevel.Size = New System.Drawing.Size(82, 13)
        Me.LabelTriggerLevel.TabIndex = 20
        Me.LabelTriggerLevel.Text = "Trigger level (%)"
        '
        'NumericUpDownTriggerLevelOn
        '
        Me.NumericUpDownTriggerLevelOn.DecimalPlaces = 2
        Me.NumericUpDownTriggerLevelOn.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.NumericUpDownTriggerLevelOn.Location = New System.Drawing.Point(130, 163)
        Me.NumericUpDownTriggerLevelOn.Name = "NumericUpDownTriggerLevelOn"
        Me.NumericUpDownTriggerLevelOn.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownTriggerLevelOn.TabIndex = 19
        Me.NumericUpDownTriggerLevelOn.Value = New Decimal(New Integer() {200, 0, 0, 131072})
        '
        'PanelCameraSettings1
        '
        Me.PanelCameraSettings1.BackColor = System.Drawing.SystemColors.Control
        Me.PanelCameraSettings1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCameraSettings1.Controls.Add(Me.ButtonSetCameraParametersTrim)
        Me.PanelCameraSettings1.Controls.Add(Me.NumericUpDownTrimRight)
        Me.PanelCameraSettings1.Controls.Add(Me.NumericUpDownTrimLeft)
        Me.PanelCameraSettings1.Controls.Add(Me.Label2)
        Me.PanelCameraSettings1.Controls.Add(Me.Label1)
        Me.PanelCameraSettings1.Controls.Add(Me.ButtonSetCameraParametersMotion)
        Me.PanelCameraSettings1.Controls.Add(Me.NumericUpDownDilation)
        Me.PanelCameraSettings1.Controls.Add(Me.NumericUpDownErosion)
        Me.PanelCameraSettings1.Controls.Add(Me.NumericUpDownSensitivity)
        Me.PanelCameraSettings1.Controls.Add(Me.LabelDilation)
        Me.PanelCameraSettings1.Controls.Add(Me.LabelErosion)
        Me.PanelCameraSettings1.Controls.Add(Me.LabelSensitivity)
        Me.PanelCameraSettings1.Location = New System.Drawing.Point(29, 385)
        Me.PanelCameraSettings1.Name = "PanelCameraSettings1"
        Me.PanelCameraSettings1.Size = New System.Drawing.Size(327, 268)
        Me.PanelCameraSettings1.TabIndex = 44
        '
        'ButtonSetCameraParametersTrim
        '
        Me.ButtonSetCameraParametersTrim.Location = New System.Drawing.Point(131, 232)
        Me.ButtonSetCameraParametersTrim.Name = "ButtonSetCameraParametersTrim"
        Me.ButtonSetCameraParametersTrim.Size = New System.Drawing.Size(60, 20)
        Me.ButtonSetCameraParametersTrim.TabIndex = 48
        Me.ButtonSetCameraParametersTrim.Text = "Set"
        Me.ButtonSetCameraParametersTrim.UseVisualStyleBackColor = True
        '
        'NumericUpDownTrimRight
        '
        Me.NumericUpDownTrimRight.Location = New System.Drawing.Point(209, 202)
        Me.NumericUpDownTrimRight.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownTrimRight.Name = "NumericUpDownTrimRight"
        Me.NumericUpDownTrimRight.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownTrimRight.TabIndex = 47
        '
        'NumericUpDownTrimLeft
        '
        Me.NumericUpDownTrimLeft.Location = New System.Drawing.Point(209, 169)
        Me.NumericUpDownTrimLeft.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.NumericUpDownTrimLeft.Name = "NumericUpDownTrimLeft"
        Me.NumericUpDownTrimLeft.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownTrimLeft.TabIndex = 46
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 204)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Trim right"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 171)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Trim left"
        '
        'ButtonSetCameraParametersMotion
        '
        Me.ButtonSetCameraParametersMotion.Location = New System.Drawing.Point(131, 124)
        Me.ButtonSetCameraParametersMotion.Name = "ButtonSetCameraParametersMotion"
        Me.ButtonSetCameraParametersMotion.Size = New System.Drawing.Size(60, 20)
        Me.ButtonSetCameraParametersMotion.TabIndex = 43
        Me.ButtonSetCameraParametersMotion.Text = "Set"
        Me.ButtonSetCameraParametersMotion.UseVisualStyleBackColor = True
        '
        'NumericUpDownDilation
        '
        Me.NumericUpDownDilation.Location = New System.Drawing.Point(209, 86)
        Me.NumericUpDownDilation.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDownDilation.Name = "NumericUpDownDilation"
        Me.NumericUpDownDilation.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownDilation.TabIndex = 36
        '
        'NumericUpDownErosion
        '
        Me.NumericUpDownErosion.Location = New System.Drawing.Point(209, 51)
        Me.NumericUpDownErosion.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.NumericUpDownErosion.Name = "NumericUpDownErosion"
        Me.NumericUpDownErosion.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownErosion.TabIndex = 35
        '
        'NumericUpDownSensitivity
        '
        Me.NumericUpDownSensitivity.Location = New System.Drawing.Point(209, 16)
        Me.NumericUpDownSensitivity.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDownSensitivity.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDownSensitivity.Name = "NumericUpDownSensitivity"
        Me.NumericUpDownSensitivity.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownSensitivity.TabIndex = 34
        Me.NumericUpDownSensitivity.Value = New Decimal(New Integer() {20, 0, 0, 0})
        '
        'LabelDilation
        '
        Me.LabelDilation.AutoSize = True
        Me.LabelDilation.Location = New System.Drawing.Point(68, 88)
        Me.LabelDilation.Name = "LabelDilation"
        Me.LabelDilation.Size = New System.Drawing.Size(42, 13)
        Me.LabelDilation.TabIndex = 33
        Me.LabelDilation.Text = "Dilation"
        '
        'LabelErosion
        '
        Me.LabelErosion.AutoSize = True
        Me.LabelErosion.Location = New System.Drawing.Point(68, 53)
        Me.LabelErosion.Name = "LabelErosion"
        Me.LabelErosion.Size = New System.Drawing.Size(42, 13)
        Me.LabelErosion.TabIndex = 32
        Me.LabelErosion.Text = "Erosion"
        '
        'LabelSensitivity
        '
        Me.LabelSensitivity.AutoSize = True
        Me.LabelSensitivity.Location = New System.Drawing.Point(69, 18)
        Me.LabelSensitivity.Name = "LabelSensitivity"
        Me.LabelSensitivity.Size = New System.Drawing.Size(54, 13)
        Me.LabelSensitivity.TabIndex = 31
        Me.LabelSensitivity.Text = "Sensitivity"
        '
        'TabPagePlayback
        '
        Me.TabPagePlayback.Controls.Add(Me.ButtonSave)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPanUp)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPanLeft)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPanDown)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPanRight)
        Me.TabPagePlayback.Controls.Add(Me.ButtonZoomIn)
        Me.TabPagePlayback.Controls.Add(Me.ButtonZoomOut)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPause)
        Me.TabPagePlayback.Controls.Add(Me.PanelWMPStatus)
        Me.TabPagePlayback.Controls.Add(Me.ButtonStop)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPlay)
        Me.TabPagePlayback.Controls.Add(Me.LabelFileListDate)
        Me.TabPagePlayback.Controls.Add(Me.LabelTotalMB)
        Me.TabPagePlayback.Controls.Add(Me.TextBoxTotalDiskSpace)
        Me.TabPagePlayback.Controls.Add(Me.TextBoxTotalNumberOfFiles)
        Me.TabPagePlayback.Controls.Add(Me.TextBoxFileListDate)
        Me.TabPagePlayback.Controls.Add(Me.TextBoxDiskSpace)
        Me.TabPagePlayback.Controls.Add(Me.TextBoxNumberOfFiles)
        Me.TabPagePlayback.Controls.Add(Me.LabelTotalFiles)
        Me.TabPagePlayback.Controls.Add(Me.ButtonDeleteAllFiles)
        Me.TabPagePlayback.Controls.Add(Me.ButtonNextDay)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPreviousDay)
        Me.TabPagePlayback.Controls.Add(Me.LabelMB)
        Me.TabPagePlayback.Controls.Add(Me.LabelDiskSpace)
        Me.TabPagePlayback.Controls.Add(Me.LabelNumberFiles)
        Me.TabPagePlayback.Controls.Add(Me.ButtonFrameToStart)
        Me.TabPagePlayback.Controls.Add(Me.ButtonFrameAdvance)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPlayAllFiles)
        Me.TabPagePlayback.Controls.Add(Me.ButtonReverseFileList)
        Me.TabPagePlayback.Controls.Add(Me.ButtonPlaySelectedFile)
        Me.TabPagePlayback.Controls.Add(Me.LabelPlaybackSpeed)
        Me.TabPagePlayback.Controls.Add(Me.NumericUpDownPlaybackSpeed)
        Me.TabPagePlayback.Controls.Add(Me.ButtonDeleteSingleFile)
        Me.TabPagePlayback.Controls.Add(Me.ListBoxFileList)
        Me.TabPagePlayback.Controls.Add(Me.PanelWMPControl)
        Me.TabPagePlayback.Location = New System.Drawing.Point(4, 22)
        Me.TabPagePlayback.Name = "TabPagePlayback"
        Me.TabPagePlayback.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagePlayback.Size = New System.Drawing.Size(753, 684)
        Me.TabPagePlayback.TabIndex = 1
        Me.TabPagePlayback.Text = "Playback"
        Me.TabPagePlayback.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.Location = New System.Drawing.Point(128, 511)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(50, 25)
        Me.ButtonSave.TabIndex = 67
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'ButtonPanUp
        '
        Me.ButtonPanUp.Location = New System.Drawing.Point(280, 480)
        Me.ButtonPanUp.Name = "ButtonPanUp"
        Me.ButtonPanUp.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPanUp.TabIndex = 64
        Me.ButtonPanUp.Text = "↑"
        Me.ButtonPanUp.UseVisualStyleBackColor = True
        '
        'ButtonPanLeft
        '
        Me.ButtonPanLeft.Location = New System.Drawing.Point(233, 511)
        Me.ButtonPanLeft.Name = "ButtonPanLeft"
        Me.ButtonPanLeft.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPanLeft.TabIndex = 63
        Me.ButtonPanLeft.Text = "←"
        Me.ButtonPanLeft.UseVisualStyleBackColor = True
        '
        'ButtonPanDown
        '
        Me.ButtonPanDown.Location = New System.Drawing.Point(280, 542)
        Me.ButtonPanDown.Name = "ButtonPanDown"
        Me.ButtonPanDown.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPanDown.TabIndex = 62
        Me.ButtonPanDown.Text = "↓"
        Me.ButtonPanDown.UseVisualStyleBackColor = True
        '
        'ButtonPanRight
        '
        Me.ButtonPanRight.Location = New System.Drawing.Point(325, 511)
        Me.ButtonPanRight.Name = "ButtonPanRight"
        Me.ButtonPanRight.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPanRight.TabIndex = 61
        Me.ButtonPanRight.Text = "→"
        Me.ButtonPanRight.UseVisualStyleBackColor = True
        '
        'ButtonZoomIn
        '
        Me.ButtonZoomIn.Location = New System.Drawing.Point(478, 480)
        Me.ButtonZoomIn.Name = "ButtonZoomIn"
        Me.ButtonZoomIn.Size = New System.Drawing.Size(50, 25)
        Me.ButtonZoomIn.TabIndex = 59
        Me.ButtonZoomIn.Text = "+"
        Me.ButtonZoomIn.UseVisualStyleBackColor = True
        '
        'ButtonZoomOut
        '
        Me.ButtonZoomOut.Location = New System.Drawing.Point(422, 480)
        Me.ButtonZoomOut.Name = "ButtonZoomOut"
        Me.ButtonZoomOut.Size = New System.Drawing.Size(50, 25)
        Me.ButtonZoomOut.TabIndex = 58
        Me.ButtonZoomOut.Text = "-"
        Me.ButtonZoomOut.UseVisualStyleBackColor = True
        '
        'ButtonPause
        '
        Me.ButtonPause.Location = New System.Drawing.Point(72, 480)
        Me.ButtonPause.Name = "ButtonPause"
        Me.ButtonPause.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPause.TabIndex = 57
        Me.ButtonPause.Text = "Pause"
        Me.ButtonPause.UseVisualStyleBackColor = True
        '
        'PanelWMPStatus
        '
        Me.PanelWMPStatus.BackColor = System.Drawing.Color.Black
        Me.PanelWMPStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelWMPStatus.Controls.Add(Me.LabelWMPTimeStatusDivider)
        Me.PanelWMPStatus.Controls.Add(Me.TextBoxWMPNowPlaying)
        Me.PanelWMPStatus.Controls.Add(Me.TextBoxWMPDuration)
        Me.PanelWMPStatus.Controls.Add(Me.TextBoxWMPCurrentTime)
        Me.PanelWMPStatus.ForeColor = System.Drawing.Color.White
        Me.PanelWMPStatus.Location = New System.Drawing.Point(16, 430)
        Me.PanelWMPStatus.Name = "PanelWMPStatus"
        Me.PanelWMPStatus.Size = New System.Drawing.Size(516, 32)
        Me.PanelWMPStatus.TabIndex = 56
        '
        'LabelWMPTimeStatusDivider
        '
        Me.LabelWMPTimeStatusDivider.AutoSize = True
        Me.LabelWMPTimeStatusDivider.BackColor = System.Drawing.Color.Black
        Me.LabelWMPTimeStatusDivider.ForeColor = System.Drawing.Color.Lime
        Me.LabelWMPTimeStatusDivider.Location = New System.Drawing.Point(445, 8)
        Me.LabelWMPTimeStatusDivider.Name = "LabelWMPTimeStatusDivider"
        Me.LabelWMPTimeStatusDivider.Size = New System.Drawing.Size(12, 13)
        Me.LabelWMPTimeStatusDivider.TabIndex = 59
        Me.LabelWMPTimeStatusDivider.Text = "/"
        '
        'TextBoxWMPNowPlaying
        '
        Me.TextBoxWMPNowPlaying.BackColor = System.Drawing.Color.Black
        Me.TextBoxWMPNowPlaying.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxWMPNowPlaying.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWMPNowPlaying.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxWMPNowPlaying.Location = New System.Drawing.Point(22, 7)
        Me.TextBoxWMPNowPlaying.Name = "TextBoxWMPNowPlaying"
        Me.TextBoxWMPNowPlaying.Size = New System.Drawing.Size(300, 16)
        Me.TextBoxWMPNowPlaying.TabIndex = 50
        '
        'TextBoxWMPDuration
        '
        Me.TextBoxWMPDuration.BackColor = System.Drawing.Color.Black
        Me.TextBoxWMPDuration.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxWMPDuration.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWMPDuration.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxWMPDuration.Location = New System.Drawing.Point(461, 7)
        Me.TextBoxWMPDuration.Name = "TextBoxWMPDuration"
        Me.TextBoxWMPDuration.Size = New System.Drawing.Size(40, 16)
        Me.TextBoxWMPDuration.TabIndex = 52
        '
        'TextBoxWMPCurrentTime
        '
        Me.TextBoxWMPCurrentTime.BackColor = System.Drawing.Color.Black
        Me.TextBoxWMPCurrentTime.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxWMPCurrentTime.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxWMPCurrentTime.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxWMPCurrentTime.Location = New System.Drawing.Point(415, 7)
        Me.TextBoxWMPCurrentTime.Name = "TextBoxWMPCurrentTime"
        Me.TextBoxWMPCurrentTime.Size = New System.Drawing.Size(40, 16)
        Me.TextBoxWMPCurrentTime.TabIndex = 51
        '
        'ButtonStop
        '
        Me.ButtonStop.Location = New System.Drawing.Point(128, 480)
        Me.ButtonStop.Name = "ButtonStop"
        Me.ButtonStop.Size = New System.Drawing.Size(50, 25)
        Me.ButtonStop.TabIndex = 55
        Me.ButtonStop.Text = "Stop"
        Me.ButtonStop.UseVisualStyleBackColor = True
        '
        'ButtonPlay
        '
        Me.ButtonPlay.Location = New System.Drawing.Point(16, 480)
        Me.ButtonPlay.Name = "ButtonPlay"
        Me.ButtonPlay.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPlay.TabIndex = 53
        Me.ButtonPlay.Text = "Play"
        Me.ButtonPlay.UseVisualStyleBackColor = True
        '
        'LabelFileListDate
        '
        Me.LabelFileListDate.Location = New System.Drawing.Point(278, 601)
        Me.LabelFileListDate.Name = "LabelFileListDate"
        Me.LabelFileListDate.Size = New System.Drawing.Size(70, 13)
        Me.LabelFileListDate.TabIndex = 48
        Me.LabelFileListDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LabelTotalMB
        '
        Me.LabelTotalMB.AutoSize = True
        Me.LabelTotalMB.Location = New System.Drawing.Point(509, 654)
        Me.LabelTotalMB.Name = "LabelTotalMB"
        Me.LabelTotalMB.Size = New System.Drawing.Size(23, 13)
        Me.LabelTotalMB.TabIndex = 47
        Me.LabelTotalMB.Text = "MB"
        '
        'TextBoxTotalDiskSpace
        '
        Me.TextBoxTotalDiskSpace.Location = New System.Drawing.Point(444, 647)
        Me.TextBoxTotalDiskSpace.Name = "TextBoxTotalDiskSpace"
        Me.TextBoxTotalDiskSpace.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxTotalDiskSpace.TabIndex = 46
        '
        'TextBoxTotalNumberOfFiles
        '
        Me.TextBoxTotalNumberOfFiles.Location = New System.Drawing.Point(360, 647)
        Me.TextBoxTotalNumberOfFiles.Name = "TextBoxTotalNumberOfFiles"
        Me.TextBoxTotalNumberOfFiles.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxTotalNumberOfFiles.TabIndex = 45
        '
        'TextBoxFileListDate
        '
        Me.TextBoxFileListDate.BackColor = System.Drawing.Color.White
        Me.TextBoxFileListDate.Location = New System.Drawing.Point(605, 22)
        Me.TextBoxFileListDate.Name = "TextBoxFileListDate"
        Me.TextBoxFileListDate.ReadOnly = True
        Me.TextBoxFileListDate.Size = New System.Drawing.Size(74, 20)
        Me.TextBoxFileListDate.TabIndex = 42
        Me.TextBoxFileListDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxDiskSpace
        '
        Me.TextBoxDiskSpace.BackColor = System.Drawing.Color.White
        Me.TextBoxDiskSpace.Location = New System.Drawing.Point(444, 598)
        Me.TextBoxDiskSpace.Name = "TextBoxDiskSpace"
        Me.TextBoxDiskSpace.ReadOnly = True
        Me.TextBoxDiskSpace.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxDiskSpace.TabIndex = 37
        '
        'TextBoxNumberOfFiles
        '
        Me.TextBoxNumberOfFiles.BackColor = System.Drawing.Color.White
        Me.TextBoxNumberOfFiles.Location = New System.Drawing.Point(360, 598)
        Me.TextBoxNumberOfFiles.Name = "TextBoxNumberOfFiles"
        Me.TextBoxNumberOfFiles.ReadOnly = True
        Me.TextBoxNumberOfFiles.Size = New System.Drawing.Size(59, 20)
        Me.TextBoxNumberOfFiles.TabIndex = 35
        '
        'LabelTotalFiles
        '
        Me.LabelTotalFiles.AutoSize = True
        Me.LabelTotalFiles.Location = New System.Drawing.Point(317, 650)
        Me.LabelTotalFiles.Name = "LabelTotalFiles"
        Me.LabelTotalFiles.Size = New System.Drawing.Size(31, 13)
        Me.LabelTotalFiles.TabIndex = 44
        Me.LabelTotalFiles.Text = "Total"
        '
        'ButtonDeleteAllFiles
        '
        Me.ButtonDeleteAllFiles.Image = CType(resources.GetObject("ButtonDeleteAllFiles.Image"), System.Drawing.Image)
        Me.ButtonDeleteAllFiles.Location = New System.Drawing.Point(705, 637)
        Me.ButtonDeleteAllFiles.Name = "ButtonDeleteAllFiles"
        Me.ButtonDeleteAllFiles.Size = New System.Drawing.Size(30, 30)
        Me.ButtonDeleteAllFiles.TabIndex = 43
        Me.ButtonDeleteAllFiles.UseVisualStyleBackColor = True
        '
        'ButtonNextDay
        '
        Me.ButtonNextDay.Location = New System.Drawing.Point(685, 19)
        Me.ButtonNextDay.Name = "ButtonNextDay"
        Me.ButtonNextDay.Size = New System.Drawing.Size(50, 25)
        Me.ButtonNextDay.TabIndex = 41
        Me.ButtonNextDay.Text = "> 1 day"
        Me.ButtonNextDay.UseVisualStyleBackColor = True
        '
        'ButtonPreviousDay
        '
        Me.ButtonPreviousDay.Location = New System.Drawing.Point(549, 19)
        Me.ButtonPreviousDay.Name = "ButtonPreviousDay"
        Me.ButtonPreviousDay.Size = New System.Drawing.Size(50, 25)
        Me.ButtonPreviousDay.TabIndex = 40
        Me.ButtonPreviousDay.Text = "< 1 day"
        Me.ButtonPreviousDay.UseVisualStyleBackColor = True
        '
        'LabelMB
        '
        Me.LabelMB.AutoSize = True
        Me.LabelMB.Location = New System.Drawing.Point(509, 601)
        Me.LabelMB.Name = "LabelMB"
        Me.LabelMB.Size = New System.Drawing.Size(23, 13)
        Me.LabelMB.TabIndex = 39
        Me.LabelMB.Text = "MB"
        '
        'LabelDiskSpace
        '
        Me.LabelDiskSpace.AutoSize = True
        Me.LabelDiskSpace.Location = New System.Drawing.Point(441, 573)
        Me.LabelDiskSpace.Name = "LabelDiskSpace"
        Me.LabelDiskSpace.Size = New System.Drawing.Size(60, 13)
        Me.LabelDiskSpace.TabIndex = 38
        Me.LabelDiskSpace.Text = "Disk space"
        '
        'LabelNumberFiles
        '
        Me.LabelNumberFiles.AutoSize = True
        Me.LabelNumberFiles.Location = New System.Drawing.Point(357, 573)
        Me.LabelNumberFiles.Name = "LabelNumberFiles"
        Me.LabelNumberFiles.Size = New System.Drawing.Size(28, 13)
        Me.LabelNumberFiles.TabIndex = 36
        Me.LabelNumberFiles.Text = "Files"
        '
        'ButtonFrameToStart
        '
        Me.ButtonFrameToStart.Location = New System.Drawing.Point(16, 511)
        Me.ButtonFrameToStart.Name = "ButtonFrameToStart"
        Me.ButtonFrameToStart.Size = New System.Drawing.Size(50, 25)
        Me.ButtonFrameToStart.TabIndex = 33
        Me.ButtonFrameToStart.Text = "<<"
        Me.ButtonFrameToStart.UseVisualStyleBackColor = True
        '
        'ButtonFrameAdvance
        '
        Me.ButtonFrameAdvance.Location = New System.Drawing.Point(72, 511)
        Me.ButtonFrameAdvance.Name = "ButtonFrameAdvance"
        Me.ButtonFrameAdvance.Size = New System.Drawing.Size(50, 25)
        Me.ButtonFrameAdvance.TabIndex = 32
        Me.ButtonFrameAdvance.Text = ">"
        Me.ButtonFrameAdvance.UseVisualStyleBackColor = True
        '
        'ButtonPlayAllFiles
        '
        Me.ButtonPlayAllFiles.Image = CType(resources.GetObject("ButtonPlayAllFiles.Image"), System.Drawing.Image)
        Me.ButtonPlayAllFiles.Location = New System.Drawing.Point(670, 637)
        Me.ButtonPlayAllFiles.Name = "ButtonPlayAllFiles"
        Me.ButtonPlayAllFiles.Size = New System.Drawing.Size(30, 30)
        Me.ButtonPlayAllFiles.TabIndex = 31
        Me.ButtonPlayAllFiles.UseVisualStyleBackColor = True
        '
        'ButtonReverseFileList
        '
        Me.ButtonReverseFileList.Image = CType(resources.GetObject("ButtonReverseFileList.Image"), System.Drawing.Image)
        Me.ButtonReverseFileList.Location = New System.Drawing.Point(549, 637)
        Me.ButtonReverseFileList.Name = "ButtonReverseFileList"
        Me.ButtonReverseFileList.Size = New System.Drawing.Size(30, 30)
        Me.ButtonReverseFileList.TabIndex = 30
        Me.ButtonReverseFileList.UseVisualStyleBackColor = True
        '
        'ButtonPlaySelectedFile
        '
        Me.ButtonPlaySelectedFile.Image = CType(resources.GetObject("ButtonPlaySelectedFile.Image"), System.Drawing.Image)
        Me.ButtonPlaySelectedFile.Location = New System.Drawing.Point(585, 637)
        Me.ButtonPlaySelectedFile.Name = "ButtonPlaySelectedFile"
        Me.ButtonPlaySelectedFile.Size = New System.Drawing.Size(30, 30)
        Me.ButtonPlaySelectedFile.TabIndex = 29
        Me.ButtonPlaySelectedFile.UseVisualStyleBackColor = True
        '
        'LabelPlaybackSpeed
        '
        Me.LabelPlaybackSpeed.AutoSize = True
        Me.LabelPlaybackSpeed.Location = New System.Drawing.Point(167, 650)
        Me.LabelPlaybackSpeed.Name = "LabelPlaybackSpeed"
        Me.LabelPlaybackSpeed.Size = New System.Drawing.Size(83, 13)
        Me.LabelPlaybackSpeed.TabIndex = 28
        Me.LabelPlaybackSpeed.Text = "Playback speed"
        '
        'NumericUpDownPlaybackSpeed
        '
        Me.NumericUpDownPlaybackSpeed.DecimalPlaces = 1
        Me.NumericUpDownPlaybackSpeed.Increment = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownPlaybackSpeed.Location = New System.Drawing.Point(256, 648)
        Me.NumericUpDownPlaybackSpeed.Maximum = New Decimal(New Integer() {32, 0, 0, 0})
        Me.NumericUpDownPlaybackSpeed.Minimum = New Decimal(New Integer() {1, 0, 0, 65536})
        Me.NumericUpDownPlaybackSpeed.Name = "NumericUpDownPlaybackSpeed"
        Me.NumericUpDownPlaybackSpeed.Size = New System.Drawing.Size(41, 20)
        Me.NumericUpDownPlaybackSpeed.TabIndex = 27
        Me.NumericUpDownPlaybackSpeed.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'ButtonDeleteSingleFile
        '
        Me.ButtonDeleteSingleFile.Image = CType(resources.GetObject("ButtonDeleteSingleFile.Image"), System.Drawing.Image)
        Me.ButtonDeleteSingleFile.Location = New System.Drawing.Point(621, 637)
        Me.ButtonDeleteSingleFile.Name = "ButtonDeleteSingleFile"
        Me.ButtonDeleteSingleFile.Size = New System.Drawing.Size(30, 30)
        Me.ButtonDeleteSingleFile.TabIndex = 26
        Me.ButtonDeleteSingleFile.UseVisualStyleBackColor = True
        '
        'ListBoxFileList
        '
        Me.ListBoxFileList.FormattingEnabled = True
        Me.ListBoxFileList.Location = New System.Drawing.Point(549, 58)
        Me.ListBoxFileList.Name = "ListBoxFileList"
        Me.ListBoxFileList.Size = New System.Drawing.Size(186, 563)
        Me.ListBoxFileList.TabIndex = 25
        '
        'PanelWMPControl
        '
        Me.PanelWMPControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PanelWMPControl.Controls.Add(Me.WMPControl)
        Me.PanelWMPControl.Location = New System.Drawing.Point(16, 19)
        Me.PanelWMPControl.Name = "PanelWMPControl"
        Me.PanelWMPControl.Size = New System.Drawing.Size(516, 412)
        Me.PanelWMPControl.TabIndex = 60
        '
        'WMPControl
        '
        Me.WMPControl.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.WMPControl.Enabled = True
        Me.WMPControl.Location = New System.Drawing.Point(0, 0)
        Me.WMPControl.Name = "WMPControl"
        Me.WMPControl.OcxState = CType(resources.GetObject("WMPControl.OcxState"), System.Windows.Forms.AxHost.State)
        Me.WMPControl.Size = New System.Drawing.Size(516, 412)
        Me.WMPControl.TabIndex = 24
        '
        'TabPageLiveView
        '
        Me.TabPageLiveView.Controls.Add(Me.TextBoxLastTrigger)
        Me.TabPageLiveView.Controls.Add(Me.PictureBox1)
        Me.TabPageLiveView.Controls.Add(Me.IMMP4Control)
        Me.TabPageLiveView.Controls.Add(Me.PanelStatus)
        Me.TabPageLiveView.Location = New System.Drawing.Point(4, 22)
        Me.TabPageLiveView.Name = "TabPageLiveView"
        Me.TabPageLiveView.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageLiveView.Size = New System.Drawing.Size(753, 684)
        Me.TabPageLiveView.TabIndex = 0
        Me.TabPageLiveView.Text = "Live View"
        Me.TabPageLiveView.UseVisualStyleBackColor = True
        '
        'TextBoxLastTrigger
        '
        Me.TextBoxLastTrigger.BackColor = System.Drawing.Color.White
        Me.TextBoxLastTrigger.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBoxLastTrigger.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLastTrigger.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TextBoxLastTrigger.Location = New System.Drawing.Point(548, 670)
        Me.TextBoxLastTrigger.Name = "TextBoxLastTrigger"
        Me.TextBoxLastTrigger.ReadOnly = True
        Me.TextBoxLastTrigger.Size = New System.Drawing.Size(185, 15)
        Me.TextBoxLastTrigger.TabIndex = 36
        Me.TextBoxLastTrigger.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Red
        Me.PictureBox1.Location = New System.Drawing.Point(29, 637)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(16, 16)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'IMMP4Control
        '
        Me.IMMP4Control.Enabled = True
        Me.IMMP4Control.Location = New System.Drawing.Point(15, 91)
        Me.IMMP4Control.Name = "IMMP4Control"
        Me.IMMP4Control.OcxState = CType(resources.GetObject("IMMP4Control.OcxState"), System.Windows.Forms.AxHost.State)
        Me.IMMP4Control.Size = New System.Drawing.Size(720, 576)
        Me.IMMP4Control.TabIndex = 34
        '
        'PanelStatus
        '
        Me.PanelStatus.BackColor = System.Drawing.SystemColors.Control
        Me.PanelStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelStatus.Controls.Add(Me.TextBoxDate)
        Me.PanelStatus.Controls.Add(Me.TextBoxTime)
        Me.PanelStatus.Controls.Add(Me.TextBoxLiveViewCameraIP)
        Me.PanelStatus.Controls.Add(Me.TextBoxLiveViewCameraName)
        Me.PanelStatus.Location = New System.Drawing.Point(15, 17)
        Me.PanelStatus.Name = "PanelStatus"
        Me.PanelStatus.Size = New System.Drawing.Size(720, 58)
        Me.PanelStatus.TabIndex = 33
        '
        'TextBoxDate
        '
        Me.TextBoxDate.BackColor = System.Drawing.Color.Black
        Me.TextBoxDate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxDate.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxDate.Location = New System.Drawing.Point(553, 16)
        Me.TextBoxDate.Name = "TextBoxDate"
        Me.TextBoxDate.ReadOnly = True
        Me.TextBoxDate.Size = New System.Drawing.Size(150, 25)
        Me.TextBoxDate.TabIndex = 32
        Me.TextBoxDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxTime
        '
        Me.TextBoxTime.BackColor = System.Drawing.Color.Black
        Me.TextBoxTime.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTime.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxTime.Location = New System.Drawing.Point(371, 16)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.ReadOnly = True
        Me.TextBoxTime.Size = New System.Drawing.Size(150, 25)
        Me.TextBoxTime.TabIndex = 31
        Me.TextBoxTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLiveViewCameraIP
        '
        Me.TextBoxLiveViewCameraIP.BackColor = System.Drawing.Color.Black
        Me.TextBoxLiveViewCameraIP.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLiveViewCameraIP.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxLiveViewCameraIP.Location = New System.Drawing.Point(193, 16)
        Me.TextBoxLiveViewCameraIP.Name = "TextBoxLiveViewCameraIP"
        Me.TextBoxLiveViewCameraIP.ReadOnly = True
        Me.TextBoxLiveViewCameraIP.Size = New System.Drawing.Size(150, 25)
        Me.TextBoxLiveViewCameraIP.TabIndex = 30
        Me.TextBoxLiveViewCameraIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TextBoxLiveViewCameraName
        '
        Me.TextBoxLiveViewCameraName.BackColor = System.Drawing.Color.Black
        Me.TextBoxLiveViewCameraName.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxLiveViewCameraName.ForeColor = System.Drawing.Color.Lime
        Me.TextBoxLiveViewCameraName.Location = New System.Drawing.Point(13, 16)
        Me.TextBoxLiveViewCameraName.Name = "TextBoxLiveViewCameraName"
        Me.TextBoxLiveViewCameraName.ReadOnly = True
        Me.TextBoxLiveViewCameraName.Size = New System.Drawing.Size(150, 25)
        Me.TextBoxLiveViewCameraName.TabIndex = 29
        Me.TextBoxLiveViewCameraName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPageLiveView)
        Me.TabControl.Controls.Add(Me.TabPagePlayback)
        Me.TabControl.Controls.Add(Me.TabPageSettings)
        Me.TabControl.Location = New System.Drawing.Point(12, 12)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(761, 710)
        Me.TabControl.TabIndex = 24
        Me.TabControl.Tag = ""
        '
        'TimerWMPStatus
        '
        Me.TimerWMPStatus.Interval = 40
        '
        'PanelCameraSettings3
        '
        Me.PanelCameraSettings3.BackColor = System.Drawing.SystemColors.Control
        Me.PanelCameraSettings3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCameraSettings3.Controls.Add(Me.ButtonSetCameraParametersCompression)
        Me.PanelCameraSettings3.Controls.Add(Me.NumericUpDownCompression)
        Me.PanelCameraSettings3.Controls.Add(Me.LabelCompression)
        Me.PanelCameraSettings3.Location = New System.Drawing.Point(390, 484)
        Me.PanelCameraSettings3.Name = "PanelCameraSettings3"
        Me.PanelCameraSettings3.Size = New System.Drawing.Size(327, 91)
        Me.PanelCameraSettings3.TabIndex = 48
        '
        'ButtonSetCameraParametersCompression
        '
        Me.ButtonSetCameraParametersCompression.Location = New System.Drawing.Point(131, 53)
        Me.ButtonSetCameraParametersCompression.Name = "ButtonSetCameraParametersCompression"
        Me.ButtonSetCameraParametersCompression.Size = New System.Drawing.Size(60, 20)
        Me.ButtonSetCameraParametersCompression.TabIndex = 43
        Me.ButtonSetCameraParametersCompression.Text = "Set"
        Me.ButtonSetCameraParametersCompression.UseVisualStyleBackColor = True
        '
        'NumericUpDownCompression
        '
        Me.NumericUpDownCompression.Location = New System.Drawing.Point(199, 18)
        Me.NumericUpDownCompression.Maximum = New Decimal(New Integer() {16, 0, 0, 0})
        Me.NumericUpDownCompression.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDownCompression.Name = "NumericUpDownCompression"
        Me.NumericUpDownCompression.Size = New System.Drawing.Size(50, 20)
        Me.NumericUpDownCompression.TabIndex = 34
        Me.NumericUpDownCompression.Value = New Decimal(New Integer() {8, 0, 0, 0})
        '
        'LabelCompression
        '
        Me.LabelCompression.AutoSize = True
        Me.LabelCompression.Location = New System.Drawing.Point(68, 20)
        Me.LabelCompression.Name = "LabelCompression"
        Me.LabelCompression.Size = New System.Drawing.Size(67, 13)
        Me.LabelCompression.TabIndex = 31
        Me.LabelCompression.Text = "Compression"
        '
        'PanelCameraInfo
        '
        Me.PanelCameraInfo.BackColor = System.Drawing.SystemColors.Control
        Me.PanelCameraInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelCameraInfo.Controls.Add(Me.TextBoxOCXVersion)
        Me.PanelCameraInfo.Controls.Add(Me.LabelOCXVersion)
        Me.PanelCameraInfo.Location = New System.Drawing.Point(390, 31)
        Me.PanelCameraInfo.Name = "PanelCameraInfo"
        Me.PanelCameraInfo.Size = New System.Drawing.Size(327, 56)
        Me.PanelCameraInfo.TabIndex = 49
        '
        'LabelOCXVersion
        '
        Me.LabelOCXVersion.AutoSize = True
        Me.LabelOCXVersion.Location = New System.Drawing.Point(12, 20)
        Me.LabelOCXVersion.Name = "LabelOCXVersion"
        Me.LabelOCXVersion.Size = New System.Drawing.Size(67, 13)
        Me.LabelOCXVersion.TabIndex = 31
        Me.LabelOCXVersion.Text = "OCX Version"
        '
        'TextBoxOCXVersion
        '
        Me.TextBoxOCXVersion.BackColor = System.Drawing.Color.White
        Me.TextBoxOCXVersion.Location = New System.Drawing.Point(131, 17)
        Me.TextBoxOCXVersion.Name = "TextBoxOCXVersion"
        Me.TextBoxOCXVersion.ReadOnly = True
        Me.TextBoxOCXVersion.Size = New System.Drawing.Size(172, 20)
        Me.TextBoxOCXVersion.TabIndex = 32
        '
        'IMMP4Cam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 759)
        Me.Controls.Add(Me.TabControl)
        Me.Controls.Add(Me.StatusStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "IMMP4Cam"
        Me.Text = "IMMP4Cam"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.TabPageSettings.ResumeLayout(False)
        Me.PanelUsernamePassword.ResumeLayout(False)
        Me.PanelUsernamePassword.PerformLayout()
        Me.PanelCameraSettings2.ResumeLayout(False)
        Me.PanelCameraSettings2.PerformLayout()
        CType(Me.NumericUpDownSaturation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownContrast, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownBrightness, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownColour, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelProgramSettings.ResumeLayout(False)
        Me.PanelProgramSettings.PerformLayout()
        CType(Me.NumericUpDownAutoDelete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTriggerLevelOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownRecordDuration, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTriggerLevelOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCameraSettings1.ResumeLayout(False)
        Me.PanelCameraSettings1.PerformLayout()
        CType(Me.NumericUpDownTrimRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownTrimLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownDilation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownErosion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownSensitivity, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPagePlayback.ResumeLayout(False)
        Me.TabPagePlayback.PerformLayout()
        Me.PanelWMPStatus.ResumeLayout(False)
        Me.PanelWMPStatus.PerformLayout()
        CType(Me.NumericUpDownPlaybackSpeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelWMPControl.ResumeLayout(False)
        CType(Me.WMPControl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPageLiveView.ResumeLayout(False)
        Me.TabPageLiveView.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IMMP4Control, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelStatus.ResumeLayout(False)
        Me.PanelStatus.PerformLayout()
        Me.TabControl.ResumeLayout(False)
        Me.PanelCameraSettings3.ResumeLayout(False)
        Me.PanelCameraSettings3.PerformLayout()
        CType(Me.NumericUpDownCompression, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelCameraInfo.ResumeLayout(False)
        Me.PanelCameraInfo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FolderBrowserDialogRecordFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabelStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelFramerate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelBitrate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabelMotion As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TimerUpdateStatus As System.Windows.Forms.Timer
    Friend WithEvents TimerCheckMotion As System.Windows.Forms.Timer
    Friend WithEvents TimerRecordStop As System.Windows.Forms.Timer
    Friend WithEvents TimerUpdateFileList As System.Windows.Forms.Timer
    Friend WithEvents TabPageSettings As System.Windows.Forms.TabPage
    Friend WithEvents PanelProgramSettings As System.Windows.Forms.Panel
    Friend WithEvents CheckBoxAutoDelete As System.Windows.Forms.CheckBox
    Friend WithEvents NumericUpDownAutoDelete As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelAutoDelete As System.Windows.Forms.Label
    Friend WithEvents LabelTriggerLevelOff As System.Windows.Forms.Label
    Friend WithEvents LabelTriggerLevelOn As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownTriggerLevelOff As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonChangeRecordFolder As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeCameraIP As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeCameraPort As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeCameraName As System.Windows.Forms.Button
    Friend WithEvents TextBoxCameraPort As System.Windows.Forms.TextBox
    Friend WithEvents LabelCameraPort As System.Windows.Forms.Label
    Friend WithEvents LabelMotionRecord As System.Windows.Forms.Label
    Friend WithEvents TextBoxCameraIP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxCameraName As System.Windows.Forms.TextBox
    Friend WithEvents LabelCameraIP As System.Windows.Forms.Label
    Friend WithEvents LabelCameraName As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownRecordDuration As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelRecordDuration As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMotionRecord As System.Windows.Forms.CheckBox
    Friend WithEvents TextBoxRecordFolder As System.Windows.Forms.TextBox
    Friend WithEvents LabelRecordFolder As System.Windows.Forms.Label
    Friend WithEvents LabelTriggerLevel As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownTriggerLevelOn As System.Windows.Forms.NumericUpDown
    Friend WithEvents PanelCameraSettings1 As System.Windows.Forms.Panel
    Friend WithEvents ButtonSetCameraParametersMotion As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownDilation As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownErosion As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownSensitivity As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelDilation As System.Windows.Forms.Label
    Friend WithEvents LabelErosion As System.Windows.Forms.Label
    Friend WithEvents LabelSensitivity As System.Windows.Forms.Label
    Friend WithEvents TabPagePlayback As System.Windows.Forms.TabPage
    Friend WithEvents LabelTotalMB As System.Windows.Forms.Label
    Friend WithEvents TextBoxTotalDiskSpace As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTotalNumberOfFiles As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxFileListDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxDiskSpace As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxNumberOfFiles As System.Windows.Forms.TextBox
    Friend WithEvents LabelTotalFiles As System.Windows.Forms.Label
    Friend WithEvents ButtonDeleteAllFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonNextDay As System.Windows.Forms.Button
    Friend WithEvents ButtonPreviousDay As System.Windows.Forms.Button
    Friend WithEvents LabelMB As System.Windows.Forms.Label
    Friend WithEvents LabelDiskSpace As System.Windows.Forms.Label
    Friend WithEvents LabelNumberFiles As System.Windows.Forms.Label
    Friend WithEvents ButtonFrameToStart As System.Windows.Forms.Button
    Friend WithEvents ButtonFrameAdvance As System.Windows.Forms.Button
    Friend WithEvents ButtonPlayAllFiles As System.Windows.Forms.Button
    Friend WithEvents ButtonReverseFileList As System.Windows.Forms.Button
    Friend WithEvents ButtonPlaySelectedFile As System.Windows.Forms.Button
    Friend WithEvents LabelPlaybackSpeed As System.Windows.Forms.Label
    Friend WithEvents NumericUpDownPlaybackSpeed As System.Windows.Forms.NumericUpDown
    Friend WithEvents ButtonDeleteSingleFile As System.Windows.Forms.Button
    Friend WithEvents ListBoxFileList As System.Windows.Forms.ListBox
    Friend WithEvents TabPageLiveView As System.Windows.Forms.TabPage
    Friend WithEvents PanelStatus As System.Windows.Forms.Panel
    Friend WithEvents TextBoxDate As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxTime As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLiveViewCameraIP As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxLiveViewCameraName As System.Windows.Forms.TextBox
    Friend WithEvents TabControl As System.Windows.Forms.TabControl
    Friend WithEvents LabelFileListDate As System.Windows.Forms.Label
    Friend WithEvents ButtonPlay As System.Windows.Forms.Button
    Friend WithEvents ButtonStop As System.Windows.Forms.Button
    Friend WithEvents PanelWMPStatus As System.Windows.Forms.Panel
    Friend WithEvents TextBoxWMPNowPlaying As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWMPDuration As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxWMPCurrentTime As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPause As System.Windows.Forms.Button
    Friend WithEvents TimerWMPStatus As System.Windows.Forms.Timer
    Friend WithEvents LabelWMPTimeStatusDivider As System.Windows.Forms.Label
    Friend WithEvents ButtonZoomIn As System.Windows.Forms.Button
    Friend WithEvents ButtonZoomOut As System.Windows.Forms.Button
    Friend WithEvents PanelWMPControl As System.Windows.Forms.Panel
    Friend WithEvents WMPControl As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents ButtonPanUp As System.Windows.Forms.Button
    Friend WithEvents ButtonPanLeft As System.Windows.Forms.Button
    Friend WithEvents ButtonPanDown As System.Windows.Forms.Button
    Friend WithEvents ButtonPanRight As System.Windows.Forms.Button
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents IMMP4Control As AxIMMP4ControlLib.AxIMMP4Control
    Friend WithEvents PanelCameraSettings2 As System.Windows.Forms.Panel
    Friend WithEvents NumericUpDownSaturation As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelSaturation As System.Windows.Forms.Label
    Friend WithEvents ButtonSetCameraParametersColours As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownContrast As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownBrightness As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownColour As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelContrast As System.Windows.Forms.Label
    Friend WithEvents LabelBrightness As System.Windows.Forms.Label
    Friend WithEvents LabelColour As System.Windows.Forms.Label
    Friend WithEvents PanelUsernamePassword As System.Windows.Forms.Panel
    Friend WithEvents ButtonPassword As System.Windows.Forms.Button
    Friend WithEvents ButtonUsername As System.Windows.Forms.Button
    Friend WithEvents TextBoxPassword As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxUsername As System.Windows.Forms.TextBox
    Friend WithEvents LabelPassword As System.Windows.Forms.Label
    Friend WithEvents LabelUsername As System.Windows.Forms.Label
    Friend WithEvents ButtonRestart As System.Windows.Forms.Button
    Friend WithEvents ButtonSetCameraParametersTrim As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownTrimRight As System.Windows.Forms.NumericUpDown
    Friend WithEvents NumericUpDownTrimLeft As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TextBoxLastTrigger As System.Windows.Forms.TextBox
    Friend WithEvents PanelCameraSettings3 As System.Windows.Forms.Panel
    Friend WithEvents ButtonSetCameraParametersCompression As System.Windows.Forms.Button
    Friend WithEvents NumericUpDownCompression As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelCompression As System.Windows.Forms.Label
    Friend WithEvents PanelCameraInfo As System.Windows.Forms.Panel
    Friend WithEvents LabelOCXVersion As System.Windows.Forms.Label
    Friend WithEvents TextBoxOCXVersion As System.Windows.Forms.TextBox

End Class
