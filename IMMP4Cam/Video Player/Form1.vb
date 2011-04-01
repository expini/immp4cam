Imports System.IO
Imports System.Drawing.Imaging
Imports System.Net

Public Class IMMP4Cam

    Public mcount As Decimal = 0
    Public lcount As Decimal = 0
    Public rstart As Boolean = False
    Public lselect As Integer = -1
    Public achange As Boolean = False
    Public listrev As Boolean = False
    Public playday As Integer = 0

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    Dim exist As Object = GetSetting("IMMP4Cam", "Settings", "Camera name")
    Dim exist2 As Object = GetSetting("IMMP4Cam", "Settings", "Camera IP address")
    Dim exist3 As Object = GetSetting("IMMP4Cam", "Settings", "Camera port")

        If exist = Nothing Or exist2 = Nothing Or exist3 = Nothing Then

            Do

                TextBoxCameraName.Text = InputBox("Enter camera name", "Camera name", "Camera 1")

            Loop Until TextBoxCameraName.Text <> ""

            Do

                TextBoxCameraIP.Text = InputBox("Enter camera IP address", "Camera IP address", "0.0.0.0")

            Loop Until System.Text.RegularExpressions.Regex.IsMatch(TextBoxCameraIP.Text, "^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$")

            Do

                TextBoxCameraPort.Text = InputBox("Enter camera port", "Camera port", "80")

            Loop Until System.Text.RegularExpressions.Regex.IsMatch(TextBoxCameraPort.Text, "^(6553[0-5]|655[0-2]\d|65[0-4]\d\d|6[0-4]\d{3}|[1-5]\d{4}|[1-9]\d{0,3}|0)$")

            SaveSetting("IMMP4Cam", "Settings", "Camera name", TextBoxCameraName.Text)
            SaveSetting("IMMP4Cam", "Settings", "Camera IP address", TextBoxCameraIP.Text)
            SaveSetting("IMMP4Cam", "Settings", "Camera port", TextBoxCameraPort.Text)
            SaveSetting("IMMP4Cam", "Settings", "Motion record", True)
            SaveSetting("IMMP4Cam", "Settings", "Trigger level (%) on", 2)
            SaveSetting("IMMP4Cam", "Settings", "Trigger level (%) off", 2)
            SaveSetting("IMMP4Cam", "Settings", "Record folder", "C:\IMMP4Cam")
            SaveSetting("IMMP4Cam", "Settings", "Record duration (s)", 5)
            SaveSetting("IMMP4Cam", "Settings", "Playback speed", 4)
            SaveSetting("IMMP4Cam", "Settings", "Sensitivity", 20)
            SaveSetting("IMMP4Cam", "Settings", "Erosion", 0)
            SaveSetting("IMMP4Cam", "Settings", "Dilation", 0)
            SaveSetting("IMMP4Cam", "Settings", "Autodelete (days)", 7)
            SaveSetting("IMMP4Cam", "Settings", "Auto delete", False)
            SaveSetting("IMMP4Cam", "Settings", "Camera username", TextBoxUsername.Text)
            SaveSetting("IMMP4Cam", "Settings", "Camera password", TextBoxPassword.Text)
            SaveSetting("IMMP4Cam", "Settings", "Brightness", 80)
            SaveSetting("IMMP4Cam", "Settings", "Contrast", 128)
            SaveSetting("IMMP4Cam", "Settings", "Saturation", 128)
            SaveSetting("IMMP4Cam", "Settings", "Trim left", 0)
            SaveSetting("IMMP4Cam", "Settings", "Trim right", 0)
            SaveSetting("IMMP4Cam", "Settings", "Compression", 8)

        Else

            TextBoxCameraName.Text = GetSetting("IMMP4Cam", "Settings", "Camera name")
            TextBoxCameraIP.Text = GetSetting("IMMP4Cam", "Settings", "Camera IP address")
            TextBoxCameraPort.Text = GetSetting("IMMP4Cam", "Settings", "Camera port")
            CheckBoxMotionRecord.Checked = GetSetting("IMMP4Cam", "Settings", "Motion record")
            NumericUpDownTriggerLevelOn.Value = GetSetting("IMMP4Cam", "Settings", "Trigger level (%) on")
            NumericUpDownTriggerLevelOff.Value = GetSetting("IMMP4Cam", "Settings", "Trigger level (%) off")
            TextBoxRecordFolder.Text = GetSetting("IMMP4Cam", "Settings", "Record folder")
            NumericUpDownRecordDuration.Value = GetSetting("IMMP4Cam", "Settings", "Record duration (s)")
            NumericUpDownPlaybackSpeed.Value = GetSetting("IMMP4Cam", "Settings", "Playback speed")
            NumericUpDownSensitivity.Value = GetSetting("IMMP4Cam", "Settings", "Sensitivity")
            NumericUpDownErosion.Value = GetSetting("IMMP4Cam", "Settings", "Erosion")
            NumericUpDownDilation.Value = GetSetting("IMMP4Cam", "Settings", "Dilation")
            NumericUpDownAutoDelete.Value = GetSetting("IMMP4Cam", "Settings", "Autodelete (days)")
            CheckBoxAutoDelete.Checked = GetSetting("IMMP4Cam", "Settings", "Auto delete")
            TextBoxUsername.Text = GetSetting("IMMP4Cam", "Settings", "Camera username")
            TextBoxPassword.Text = GetSetting("IMMP4Cam", "Settings", "Camera password")
            NumericUpDownBrightness.Value = GetSetting("IMMP4Cam", "Settings", "Brightness")
            NumericUpDownContrast.Value = GetSetting("IMMP4Cam", "Settings", "Contrast")
            NumericUpDownSaturation.Value = GetSetting("IMMP4Cam", "Settings", "Saturation")
            NumericUpDownTrimLeft.Value = GetSetting("IMMP4Cam", "Settings", "Trim left")
            NumericUpDownTrimRight.Value = GetSetting("IMMP4Cam", "Settings", "Trim right")
            NumericUpDownCompression.Value = GetSetting("IMMP4Cam", "Settings", "Compression")

        End If

        If (Not System.IO.Directory.Exists(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text)) Then

            System.IO.Directory.CreateDirectory(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text)

        End If

        TextBoxLiveViewCameraName.Text = TextBoxCameraName.Text
        TextBoxLiveViewCameraIP.Text = TextBoxCameraIP.Text + ":" + TextBoxCameraPort.Text

        TextBoxOCXVersion.Text = IMMP4Control.Name + " " + IMMP4Control.OcxVer

        WMPControl.uiMode = "none"
        WMPControl.settings.volume = 0
        WMPControl.settings.mute = True

        LabelWMPTimeStatusDivider.Hide()

        If IMMP4Control.CheckConnection(TextBoxCameraIP.Text, TextBoxCameraPort.Text, 1000) = 1 Then

            IMMP4Control.Source = "http://" + TextBoxCameraIP.Text + ":" + TextBoxCameraPort.Text + "/vdata.v"

            IMMP4Control.SetCutPixels(NumericUpDownTrimLeft.Value, NumericUpDownTrimRight.Value, 0, 0, 0, 0, 0, 0)

            IMMP4Control.Play()

            IMMP4Control.MotionDetection(1, NumericUpDownSensitivity.Value, NumericUpDownErosion.Value, NumericUpDownDilation.Value)

            ToolStripStatusLabelStatus.Text = "Status: Playing"

            TimerUpdateStatus.Enabled = True
            TimerCheckMotion.Enabled = True

        Else

            MsgBox("No stream found! - Check settings")

        End If

        refreshlistbox()

    End Sub

    Private Sub Form1_Closing(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing

        If CheckBoxMotionRecord.Checked = True Then

            If MessageBox.Show("Are you sure? Motion record in progress!", "Exit", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then

                e.Cancel = True

            End If

        End If

        SaveSetting("IMMP4Cam", "Settings", "Camera name", TextBoxCameraName.Text)
        SaveSetting("IMMP4Cam", "Settings", "Camera IP address", TextBoxCameraIP.Text)
        SaveSetting("IMMP4Cam", "Settings", "Camera port", TextBoxCameraPort.Text)
        SaveSetting("IMMP4Cam", "Settings", "Motion record", CheckBoxMotionRecord.Checked)
        SaveSetting("IMMP4Cam", "Settings", "Trigger level (%) on", NumericUpDownTriggerLevelOn.Value)
        SaveSetting("IMMP4Cam", "Settings", "Trigger level (%) off", NumericUpDownTriggerLevelOff.Value)
        SaveSetting("IMMP4Cam", "Settings", "Record folder", TextBoxRecordFolder.Text)
        SaveSetting("IMMP4Cam", "Settings", "Record duration (s)", NumericUpDownRecordDuration.Value)
        SaveSetting("IMMP4Cam", "Settings", "Playback speed", NumericUpDownPlaybackSpeed.Value)
        SaveSetting("IMMP4Cam", "Settings", "Sensitivity", NumericUpDownSensitivity.Value)
        SaveSetting("IMMP4Cam", "Settings", "Erosion", NumericUpDownErosion.Value)
        SaveSetting("IMMP4Cam", "Settings", "Dilation", NumericUpDownDilation.Value)
        SaveSetting("IMMP4Cam", "Settings", "Autodelete (days)", NumericUpDownAutoDelete.Value)
        SaveSetting("IMMP4Cam", "Settings", "Auto delete", CheckBoxAutoDelete.Checked)
        SaveSetting("IMMP4Cam", "Settings", "Camera username", TextBoxUsername.Text)
        SaveSetting("IMMP4Cam", "Settings", "Camera password", TextBoxPassword.Text)
        SaveSetting("IMMP4Cam", "Settings", "Brightness", NumericUpDownBrightness.Value)
        SaveSetting("IMMP4Cam", "Settings", "Contrast", NumericUpDownContrast.Value)
        SaveSetting("IMMP4Cam", "Settings", "Saturation", NumericUpDownSaturation.Value)
        SaveSetting("IMMP4Cam", "Settings", "Trim left", NumericUpDownTrimLeft.Value)
        SaveSetting("IMMP4Cam", "Settings", "Trim right", NumericUpDownTrimRight.Value)
        SaveSetting("IMMP4Cam", "Settings", "Compression", NumericUpDownCompression.Value)

    End Sub

    Private Sub showStatus()

        Dim time As DateTime = DateTime.Now
        Dim format As String = time.ToString("HH:mm:ss")

        TextBoxTime.Text = format

        If format = "00:00:00" And CheckBoxAutoDelete.Checked = True Then autodelete()

        format = time.ToString("dd/MM/yy")
        TextBoxDate.Text = format

        Dim x As Integer = IMMP4Control.BitRate
        Dim y As Integer = IMMP4Control.FrameRate

        Dim fr = System.Convert.ToString(y)

        ToolStripStatusLabelFramerate.Text = "Framerate: " + fr + "fps"

        Dim br = System.Convert.ToString(x)

        br = Math.Ceiling(((x * 8) / 1024))
        ToolStripStatusLabelBitrate.Text = "Bitrate: " + br + "kbps"

        If WMPControl.currentPlaylist.count = 0 Then

            TimerWMPStatus.Enabled = False

        End If

    End Sub

    Private Sub detectmotion()

        If CheckBoxMotionRecord.Checked = True Then

            mcount = IMMP4Control.MotionCount()
            mcount = (mcount / 6480) * 100 * 10
            mcount = Math.Round(mcount, 2)

            If (mcount > 900) Then mcount = 0

            If (mcount > 100) Then mcount = 100

            If (mcount <> lcount) Then

                If (mcount >= NumericUpDownTriggerLevelOn.Value) And (rstart = False) Then

                    TextBoxLastTrigger.Text = "Last trigger: " + TextBoxDate.Text + " at " + TextBoxTime.Text

                    rstart = True
                    timedrecord()

                End If

            Else

                mcount = 0

            End If

            If (mcount <> 0) Then lcount = mcount

            If mcount >= NumericUpDownTriggerLevelOn.Value Then

                ToolStripStatusLabelMotion.ForeColor = Color.Red

            Else

                ToolStripStatusLabelMotion.ForeColor = Color.Lime

            End If

            Dim mc = System.Convert.ToString(mcount)

            ToolStripStatusLabelMotion.Text = "Motion: " + mc + "%"

        End If

    End Sub

    Private Sub timedrecord()

        PictureBox1.Show()

        IMMP4Control.SaveAvi = 1

        Dim vname As String = TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\video"

        IMMP4Control.Record(1, vname, 0)

        ToolStripStatusLabelStatus.ForeColor = Color.Red
        ToolStripStatusLabelStatus.Text = "Status: Recording"

        TimerRecordStop.Interval = (NumericUpDownRecordDuration.Value * 1000)
        TimerRecordStop.Enabled = True

    End Sub

    Private Sub recordstop()

        PictureBox1.Hide()

        Dim vname As String = TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\video"

        IMMP4Control.Record(0, vname, 0)

        ToolStripStatusLabelStatus.ForeColor = Color.Lime
        ToolStripStatusLabelStatus.Text = "Status: Playing"

        rstart = False

        refreshlistbox()

        TimerRecordStop.Enabled = False

    End Sub

    Private Sub refreshlistbox()

        Dim curselect As String = ListBoxFileList.SelectedItem

        ListBoxFileList.Items.Clear()

        TextBoxFileListDate.Text = DateTime.Today.AddDays(playday)
        LabelFileListDate.Text = TextBoxFileListDate.Text

        Dim totalsize As Decimal = 0
        Dim completesize As Decimal = 0
        Dim totalfiles As Integer = 0

        Dim Directory As New IO.DirectoryInfo(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text)

        If Directory.GetFiles.Count() > 0 Then

            Dim allFiles As IO.FileInfo() = Directory.GetFiles("*.*")

            Dim singleFile As IO.FileInfo

            For Each singleFile In allFiles

                If singleFile.LastWriteTime.Date = DateTime.Today.AddDays(playday) Then

                    Dim curfile As String

                    curfile = singleFile.Name

                    ListBoxFileList.Items.Add(curfile)

                    Dim FileSize As Long = singleFile.Length

                    totalsize = totalsize + FileSize

                End If

                completesize = completesize + singleFile.Length
                totalfiles = totalfiles + 1

            Next

            ListBoxFileList.SelectedItem = curselect
            lselect = ListBoxFileList.SelectedIndex
            If listrev = True Then reverselistbox()

        End If

        TextBoxNumberOfFiles.Text = ListBoxFileList.Items.Count
        TextBoxTotalNumberOfFiles.Text = totalfiles

        totalsize = totalsize / 1024 / 1024
        totalsize = Math.Round(totalsize, 2)

        TextBoxDiskSpace.Text = (totalsize)

        completesize = completesize / 1024 / 1024
        completesize = Math.Round(completesize, 2)

        TextBoxTotalDiskSpace.Text = (completesize)

    End Sub

    Private Sub reverselistbox()

        Dim curselect As String = ListBoxFileList.SelectedItem

        If ListBoxFileList.Items.Count > 0 Then

            Dim myLBitems As New List(Of String)

            For Each item As String In ListBoxFileList.Items

                myLBitems.Add(item)

            Next

            ListBoxFileList.Items.Clear()

            For i As Integer = myLBitems.Count - 1 To 0 Step -1

                ListBoxFileList.Items.Add(myLBitems(i))

            Next

            If lselect <> -1 Then

                ListBoxFileList.SelectedItem = curselect
                lselect = ListBoxFileList.SelectedIndex

            End If

        End If

    End Sub

    Private Sub autodelete()

        Dim Directory As New IO.DirectoryInfo(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text)

        If Directory.GetFiles.Count() > 0 Then

            Dim allFiles As IO.FileInfo() = Directory.GetFiles("*.*")

            Dim singleFile As IO.FileInfo

            For Each singleFile In allFiles

                If singleFile.LastWriteTime.Date < DateTime.Today.Date.AddDays(NumericUpDownAutoDelete.Value * -1) Then

                    Try

                        singleFile.Delete()

                    Catch ex As Exception

                        MsgBox("Auto Delete Failed - File in use!")

                    End Try

                End If

            Next

        End If

    End Sub

    Private Sub ButtonChangeCameraName_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChangeCameraName.Click

        Dim cn As String = TextBoxCameraName.Text

        Do

            TextBoxCameraName.Text = InputBox("Enter camera name", "Camera name", TextBoxCameraName.Text)

            If Len(TextBoxCameraName.Text) = 0 Then Exit Do

        Loop Until TextBoxCameraName.Text <> ""

        If Len(TextBoxCameraName.Text) = 0 Then

            TextBoxCameraName.Text = cn

        Else

            Application.Restart()

        End If

    End Sub

    Private Sub ButtonChangeCameraIP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChangeCameraIP.Click

        Dim ci As String = TextBoxCameraIP.Text

        Do

            TextBoxCameraIP.Text = InputBox("Enter camera IP address", "Camera IP address", TextBoxCameraIP.Text)

            If Len(TextBoxCameraIP.Text) = 0 Then Exit Do

        Loop Until System.Text.RegularExpressions.Regex.IsMatch(TextBoxCameraIP.Text, "^([1-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])(\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])){3}$")

        If Len(TextBoxCameraIP.Text) = 0 Then

            TextBoxCameraIP.Text = ci

        Else

            Application.Restart()

        End If

    End Sub

    Private Sub ButtonChangeCameraPort_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChangeCameraPort.Click

        Dim cp As String = TextBoxCameraPort.Text

        Do

            TextBoxCameraPort.Text = InputBox("Enter camera port", "Camera port", TextBoxCameraPort.Text)

            If Len(TextBoxCameraPort.Text) = 0 Then Exit Do

        Loop Until System.Text.RegularExpressions.Regex.IsMatch(TextBoxCameraPort.Text, "^(6553[0-5]|655[0-2]\d|65[0-4]\d\d|6[0-4]\d{3}|[1-5]\d{4}|[1-9]\d{0,3}|0)$")

        If Len(TextBoxCameraPort.Text) = 0 Then

            TextBoxCameraPort.Text = cp

        Else

            Application.Restart()

        End If

    End Sub

    Private Sub ButtonChangeRecordFolder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonChangeRecordFolder.Click

        Dim sp As String = TextBoxRecordFolder.Text

        With (FolderBrowserDialogRecordFolder)

            .RootFolder = Environment.SpecialFolder.Desktop
            .SelectedPath = TextBoxRecordFolder.Text
            .Description = "Select record folder"

            If .ShowDialog = DialogResult.OK And .SelectedPath <> sp Then

                TextBoxRecordFolder.Text = (.SelectedPath)
                Application.Restart()

            End If

        End With

    End Sub

    Private Sub ButtonSetCameraParametersMotion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetCameraParametersMotion.Click

        IMMP4Control.MotionDetection(1, NumericUpDownSensitivity.Value, NumericUpDownErosion.Value, NumericUpDownDilation.Value)

    End Sub

    Private Sub ButtonSetCameraParametersTrim_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetCameraParametersTrim.Click

        IMMP4Control.SetCutPixels(NumericUpDownTrimLeft.Value, NumericUpDownTrimRight.Value, 0, 0, 0, 0, 0, 0)

    End Sub

    Private Sub ButtonSetCameraParametersColours_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetCameraParametersColours.Click

        Dim open As String = "http://" + TextBoxCameraIP.Text + ":" + TextBoxCameraPort.Text + "/video_e.html?" + "V_Br=" + NumericUpDownBrightness.Value.ToString + "&V_Co=" + NumericUpDownContrast.Value.ToString + "&V_Sa=" + NumericUpDownSaturation.Value.ToString

        Try

            Dim myWebRequest As WebRequest = WebRequest.Create(open)

            myWebRequest.PreAuthenticate = True

            Dim UserName As String = TextBoxUsername.Text
            Dim Password As String = TextBoxPassword.Text

            Dim networkCredential As New NetworkCredential(UserName, Password)

            myWebRequest.Credentials = networkCredential

            Dim myWebResponse As WebResponse = myWebRequest.GetResponse()

            myWebResponse.Close()

        Catch

            MsgBox("Settings failed - Authentication error!")

        End Try

    End Sub

    Private Sub ButtonSetCameraParametersCompression_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSetCameraParametersCompression.Click

        Dim open As String = "http://" + TextBoxCameraIP.Text + ":" + TextBoxCameraPort.Text + "/video_e.html?" + "V_Cm=" + NumericUpDownCompression.Value.ToString

        Try

            Dim myWebRequest As WebRequest = WebRequest.Create(open)

            myWebRequest.PreAuthenticate = True

            Dim UserName As String = TextBoxUsername.Text
            Dim Password As String = TextBoxPassword.Text

            Dim networkCredential As New NetworkCredential(UserName, Password)

            myWebRequest.Credentials = networkCredential

            Dim myWebResponse As WebResponse = myWebRequest.GetResponse()

            myWebResponse.Close()

        Catch

            MsgBox("Settings failed - Authentication error!")

        End Try

    End Sub

    Private Sub ButtonRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonRestart.Click

        Dim result As DialogResult = MessageBox.Show("Restart camera - Are you sure?", "Restart", MessageBoxButtons.OKCancel)

        If result = Windows.Forms.DialogResult.OK Then

            Dim open As String = "http://" + TextBoxCameraIP.Text + ":" + TextBoxCameraPort.Text + "/index1_e.html?SYS_Restart=yes"

            Try

                Dim myWebRequest As WebRequest = WebRequest.Create(open)

                myWebRequest.PreAuthenticate = True

                Dim UserName As String = TextBoxUsername.Text
                Dim Password As String = TextBoxPassword.Text

                Dim networkCredential As New NetworkCredential(UserName, Password)

                myWebRequest.Credentials = networkCredential

                Dim myWebResponse As WebResponse = myWebRequest.GetResponse()

                myWebResponse.Close()

            Catch

                MsgBox("Restart failed - Authentication error!")

            End Try

        End If

    End Sub

    Private Sub ButtonUsername_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonUsername.Click

        Dim un As String = TextBoxUsername.Text

        Do

            TextBoxUsername.Text = InputBox("Enter camera username", "Camera username", TextBoxUsername.Text)

            If Len(TextBoxUsername.Text) = 0 Then Exit Do

        Loop Until TextBoxUsername.Text <> ""

        If Len(TextBoxUsername.Text) = 0 Then

            TextBoxUsername.Text = un

        End If

    End Sub

    Private Sub ButtonPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPassword.Click

        Dim up As String = TextBoxPassword.Text

        Do

            TextBoxPassword.Text = InputBox("Enter camera password", "Camera password", TextBoxPassword.Text)

            If Len(TextBoxPassword.Text) = 0 Then Exit Do

        Loop Until TextBoxPassword.Text <> ""

        If Len(TextBoxPassword.Text) = 0 Then

            TextBoxPassword.Text = up

        End If

    End Sub

    Private Sub ButtonPlaySelectedFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlaySelectedFile.Click

        If ListBoxFileList.SelectedIndex <> -1 Then

            TimerWMPStatus.Enabled = True

            WMPControl.currentPlaylist.clear()

            Dim song = WMPControl.newMedia(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\" + ListBoxFileList.SelectedItem)

            WMPControl.currentPlaylist.appendItem(song)

            WMPControl.settings.rate = NumericUpDownPlaybackSpeed.Value

            If WMPControl.Size.Width > 516 And WMPControl.Size.Height > 412 Then

                WMPControl.Width = 516
                WMPControl.Height = 412
                Dim x = ((WMPControl.Size.Width / 516) - 1) * -258
                Dim y = ((WMPControl.Size.Height / 412) - 1) * -206
                WMPControl.Location = New System.Drawing.Point(x, y)

            End If

            WMPControl.Ctlcontrols.play()

        End If

    End Sub

    Private Sub ButtonPlayAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlayAllFiles.Click

        If ListBoxFileList.Items.Count > 0 Then

            TimerWMPStatus.Enabled = True

            WMPControl.currentPlaylist.clear()

            If lselect = -1 Then lselect = 0

            achange = True
            TimerUpdateFileList.Enabled = True

            Do

                ListBoxFileList.SelectedIndex = lselect

                Dim curfile As String = ListBoxFileList.SelectedItem

                Dim songs = WMPControl.newMedia(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\" + curfile)

                WMPControl.currentPlaylist.appendItem(songs)

                lselect = lselect + 1

                If lselect > ListBoxFileList.Items.Count Then End

            Loop Until lselect = ListBoxFileList.Items.Count

            WMPControl.settings.rate = NumericUpDownPlaybackSpeed.Value

            If WMPControl.Size.Width > 516 And WMPControl.Size.Height > 412 Then

                WMPControl.Width = 516
                WMPControl.Height = 412
                Dim x = ((WMPControl.Size.Width / 516) - 1) * -258
                Dim y = ((WMPControl.Size.Height / 412) - 1) * -206
                WMPControl.Location = New System.Drawing.Point(x, y)

            End If

            WMPControl.Ctlcontrols.play()

        End If

    End Sub

    Private Sub ButtonDeleteSingleFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteSingleFile.Click

        If ListBoxFileList.SelectedIndex <> -1 Then

            WMPControl.close()

            Dim fi As New FileInfo(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\" + ListBoxFileList.SelectedItem)

            Try

                fi.Delete()

            Catch ex As Exception

                MsgBox("File Delete Failed - File in use!")

            End Try

            If ListBoxFileList.Items.Count > 1 Then

                If lselect <> (ListBoxFileList.Items.Count - 1) Then

                    lselect = lselect + 1
                    ListBoxFileList.SelectedIndex = lselect

                Else

                    lselect = 0
                    ListBoxFileList.SelectedIndex = lselect

                End If

            End If

            refreshlistbox()

            If achange = True Then

                WMPControl.Ctlcontrols.play()

            End If

        End If

    End Sub

    Private Sub ButtonDeleteAllFiles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDeleteAllFiles.Click

        Dim result As DialogResult = MessageBox.Show("Delete all - Are you sure?", "Delete", MessageBoxButtons.OKCancel)

        If result = Windows.Forms.DialogResult.OK Then

            If ListBoxFileList.Items.Count > 0 Then

                WMPControl.close()
                WMPControl.currentPlaylist.clear()

                Dim n As Integer = 0

                Do Until n = ListBoxFileList.Items.Count

                    ListBoxFileList.SelectedIndex = n

                    Dim fi As New FileInfo(TextBoxRecordFolder.Text + "\" + TextBoxCameraName.Text + "\" + ListBoxFileList.SelectedItem)

                    Try

                        fi.Delete()

                    Catch ex As Exception

                        MsgBox("Multiple Files Delete Failed - File in use!")

                    End Try

                    n = n + 1

                Loop

                If achange = True Then

                    achange = False
                    TimerUpdateFileList.Enabled = False
                    WMPControl.currentPlaylist.clear()

                End If

                refreshlistbox()

            End If

        End If

    End Sub

    Private Sub ButtonReverseFileList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonReverseFileList.Click

        If listrev = False Then

            listrev = True

        Else

            listrev = False

        End If

        reverselistbox()

    End Sub

    Private Sub ButtonPlay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPlay.Click

        WMPControl.settings.rate = 1

        WMPControl.Ctlcontrols.play()

    End Sub

    Private Sub ButtonStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonStop.Click

        WMPControl.Ctlcontrols.stop()
        achange = False
        TimerUpdateFileList.Enabled = False
        WMPControl.currentPlaylist.clear()

    End Sub

    Private Sub ButtonPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPause.Click

        If WMPControl.settings.rate <> 1 Then

            WMPControl.Ctlcontrols.currentPosition = 0
            WMPControl.settings.rate = 1

        End If

        WMPControl.Ctlcontrols.pause()

    End Sub

    Private Sub ButtonFrameToStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFrameToStart.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            WMPControl.Ctlcontrols.currentPosition = 0

        End If

    End Sub

    Private Sub ButtonFrameToEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If WMPControl.playState.ToString = "wmppsPaused" Then

            WMPControl.Ctlcontrols.currentPosition = WMPControl.currentMedia.duration - (2 * (1 / WMPControl.network.encodedFrameRate))

        End If

    End Sub

    Private Sub ButtonFrameReverse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If WMPControl.playState.ToString = "wmppsPaused" Then

            WMPControl.Ctlcontrols.currentPosition = WMPControl.Ctlcontrols.currentPosition - (1 / WMPControl.network.encodedFrameRate)

        End If

    End Sub

    Private Sub ButtonFrameAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFrameAdvance.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            WMPControl.Ctlcontrols.play()
            WMPControl.Ctlcontrols.pause()

        End If

    End Sub

    Private Sub ButtonPreviousDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPreviousDay.Click

        If DateTime.Today.Date.AddDays(playday) > "01/01/1970" Then

            playday = playday - 1

            WMPControl.close()
            WMPControl.currentPlaylist.clear()

            If achange = True Then

                achange = False
                TimerUpdateFileList.Enabled = False
                WMPControl.currentPlaylist.clear()

            End If

            refreshlistbox()

        End If

    End Sub

    Private Sub ButtonNextDay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonNextDay.Click

        If playday < 0 Then

            playday = playday + 1

            WMPControl.close()
            WMPControl.currentPlaylist.clear()

            If achange = True Then

                achange = False
                TimerUpdateFileList.Enabled = False
                WMPControl.currentPlaylist.clear()

            End If

            refreshlistbox()

        End If

    End Sub

    Private Sub ButtonZoomOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZoomOut.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            If WMPControl.Size.Width > 516 And WMPControl.Size.Height > 412 Then

                WMPControl.Width *= 0.5
                WMPControl.Height *= 0.5
                Dim x = ((WMPControl.Size.Width / 516) - 1) * -258
                Dim y = ((WMPControl.Size.Height / 412) - 1) * -206
                WMPControl.Location = New System.Drawing.Point(x, y)

            End If

        End If

    End Sub

    Private Sub ButtonZoomIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonZoomIn.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            If WMPControl.Size.Width < 2064 And WMPControl.Size.Height < 1648 Then

                WMPControl.stretchToFit = True
                WMPControl.Width *= 2
                WMPControl.Height *= 2
                Dim x = ((WMPControl.Size.Width / 516) - 1) * -258
                Dim y = ((WMPControl.Size.Height / 412) - 1) * -206
                WMPControl.Location = New System.Drawing.Point(x, y)

            End If

        End If

    End Sub

    Private Sub ButtonPanRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPanRight.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            Dim x = WMPControl.Location.X
            Dim y = WMPControl.Location.Y

            x = x - 25

            If x < (WMPControl.Width - 516) * -1 Then x = (WMPControl.Width - 516) * -1

            WMPControl.Location = New System.Drawing.Point(x, y)

        End If

    End Sub

    Private Sub ButtonPanLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPanLeft.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            Dim x = WMPControl.Location.X
            Dim y = WMPControl.Location.Y

            x = x + 25

            If x > 0 Then x = 0

            WMPControl.Location = New System.Drawing.Point(x, y)

        End If

    End Sub

    Private Sub ButtonPanUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPanUp.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            Dim x = WMPControl.Location.X
            Dim y = WMPControl.Location.Y

            y = y + 25

            If y > 0 Then y = 0

            WMPControl.Location = New System.Drawing.Point(x, y)

        End If

    End Sub

    Private Sub ButtonPanDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPanDown.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            Dim x = WMPControl.Location.X
            Dim y = WMPControl.Location.Y

            y = y - 25

            If y < (WMPControl.Height - 412) * -1 Then y = (WMPControl.Height - 412) * -1

            WMPControl.Location = New System.Drawing.Point(x, y)

        End If

    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click

        If WMPControl.playState.ToString = "wmppsPaused" Then

            Dim m = IMMP4Control

            Dim bmp = New Bitmap(516, 412, PixelFormat.Format32bppArgb)
            Dim g = Graphics.FromImage(bmp)

            Dim mLoc = m.PointToScreen(m.Location)

            g.CopyFromScreen(mLoc.X - 14, mLoc.Y - 163, 0, 0, m.Size, CopyPixelOperation.SourceCopy)

            Dim time As DateTime = DateTime.Now
            Dim format As String = time.ToString("yyyy-MM-dd-HH-mm-ss")

            bmp.Save(TextBoxRecordFolder.Text + "/" + TextBoxCameraName.Text + "/photo-" + format + ".bmp")
            g.Dispose()

            refreshlistbox()

        End If

    End Sub

    Private Sub CheckBoxMotionRecord_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMotionRecord.CheckedChanged

        If CheckBoxMotionRecord.Checked = False Then

            ToolStripStatusLabelMotion.Text = "Motion: Disabled"
            TextBoxLastTrigger.Clear()

        End If

    End Sub

    Private Sub ListBoxFileList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxFileList.SelectedIndexChanged

        lselect = ListBoxFileList.SelectedIndex

    End Sub

    Private Sub TimerUpdateStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdateStatus.Tick

        showStatus()

    End Sub

    Private Sub TimerCheckMotion_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerCheckMotion.Tick

        detectmotion()

    End Sub

    Private Sub TimerRecordStop_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerRecordStop.Tick

        If (mcount <= NumericUpDownTriggerLevelOff.Value) Then

            recordstop()

        End If

    End Sub

    Private Sub TimerUpdateFileList_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerUpdateFileList.Tick

        If WMPControl.playState.ToString = "wmppsStopped" Or WMPControl.playState.ToString = "wmppsReady" Then

            achange = False
            TimerUpdateFileList.Enabled = False
            WMPControl.currentPlaylist.clear()

            If lselect < ListBoxFileList.Items.Count Then

                ListBoxFileList.SelectedIndex = lselect

            Else

                lselect = lselect - 1

            End If

        End If

        If achange = True Then

            Dim fnPeices() As String = (WMPControl.currentMedia.sourceURL).Split("\")
            Dim fileName As String = ""

            fileName = fnPeices(fnPeices.Length - 1)
            ListBoxFileList.SelectedItem = fileName

        End If

    End Sub

    Private Sub TimerWMPStatus_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerWMPStatus.Tick

        If WMPControl.currentPlaylist.count > 0 Then

            TextBoxWMPNowPlaying.Text = WMPControl.currentMedia.name
            TextBoxWMPCurrentTime.Text = WMPControl.Ctlcontrols.currentPositionString
            If TextBoxWMPCurrentTime.Text = "" Then TextBoxWMPCurrentTime.Text = "00:00"

            LabelWMPTimeStatusDivider.Show()

            TextBoxWMPDuration.Text = WMPControl.currentMedia.durationString

        Else

            TextBoxWMPNowPlaying.Clear()
            TextBoxWMPCurrentTime.Clear()
            TextBoxWMPDuration.Clear()

            LabelWMPTimeStatusDivider.Hide()

        End If

    End Sub

End Class



