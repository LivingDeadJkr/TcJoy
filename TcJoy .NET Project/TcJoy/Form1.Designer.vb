﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
		Me.TabControl = New System.Windows.Forms.TabControl()
		Me.TabPage_LiveStatus = New System.Windows.Forms.TabPage()
		Me.ProgressBar_RightShoulderAnalog = New TcJoy.MyVerticalProgessBar()
		Me.ProgressBar_LeftShoulderAnalog = New TcJoy.MyVerticalProgessBar()
		Me.ProgressBar_LeftStickYMinus = New TcJoy.MyVerticalProgessBarMinus()
		Me.ProgressBar_RightStickYMinus = New TcJoy.MyVerticalProgessBarMinus()
		Me.ProgressBar_RightStickYPlus = New TcJoy.MyVerticalProgessBar()
		Me.ProgressBar_LeftStickYPlus = New TcJoy.MyVerticalProgessBar()
		Me.Label_LeftShoulderVal = New System.Windows.Forms.Label()
		Me.Label_RightShoulderVal = New System.Windows.Forms.Label()
		Me.Label_RightStickYNeg = New System.Windows.Forms.Label()
		Me.Label_RightStickYPos = New System.Windows.Forms.Label()
		Me.Label_LeftStickYPos = New System.Windows.Forms.Label()
		Me.Label_LeftStickYNeg = New System.Windows.Forms.Label()
		Me.Label_RightStickXPos = New System.Windows.Forms.Label()
		Me.Label_RightStickXNeg = New System.Windows.Forms.Label()
		Me.Label_LeftStickXPos = New System.Windows.Forms.Label()
		Me.Label_LeftStickXNeg = New System.Windows.Forms.Label()
		Me.CheckBox_RightShoulderBtn = New System.Windows.Forms.CheckBox()
		Me.CheckBox_LeftShoulderBtn = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DPadLeft = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DPadRight = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DPadDown = New System.Windows.Forms.CheckBox()
		Me.CheckBox_DPadUp = New System.Windows.Forms.CheckBox()
		Me.CheckBox_BackBtn = New System.Windows.Forms.CheckBox()
		Me.CheckBox_StartBtn = New System.Windows.Forms.CheckBox()
		Me.CheckBox_XButton = New System.Windows.Forms.CheckBox()
		Me.CheckBox_BButton = New System.Windows.Forms.CheckBox()
		Me.CheckBox_AButton = New System.Windows.Forms.CheckBox()
		Me.CheckBox_YButton = New System.Windows.Forms.CheckBox()
		Me.ProgressBar_RightStickXMinus = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar_RightStickXPlus = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar_LeftStickXMinus = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar_LeftStickXPlus = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar_Controller0Battery = New System.Windows.Forms.ProgressBar()
		Me.Label18 = New System.Windows.Forms.Label()
		Me.Label_Controller0_Connection = New System.Windows.Forms.Label()
		Me.Label_JoyActiveFromPLC = New System.Windows.Forms.Label()
		Me.ProgressBar_ADSBad = New System.Windows.Forms.ProgressBar()
		Me.ProgressBar_ADSGood = New System.Windows.Forms.ProgressBar()
		Me.TextBox_ADSDataRateAchieved = New System.Windows.Forms.TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.TextBox_ADSConnectionStatus2 = New System.Windows.Forms.TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.TabPage_Connection = New System.Windows.Forms.TabPage()
		Me.GroupBox_Controller = New System.Windows.Forms.GroupBox()
		Me.Label16 = New System.Windows.Forms.Label()
		Me.Label17 = New System.Windows.Forms.Label()
		Me.TextBox_ShoulderDeadzone = New System.Windows.Forms.TextBox()
		Me.Label15 = New System.Windows.Forms.Label()
		Me.Label14 = New System.Windows.Forms.Label()
		Me.TextBox_AnalogDeadzone = New System.Windows.Forms.TextBox()
		Me.GroupBox_PLC = New System.Windows.Forms.GroupBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.TextBox_ADSWatchdogDeadDuration = New System.Windows.Forms.TextBox()
		Me.Label13 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.TextBox_ADSWatchdog = New System.Windows.Forms.TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Button_ADSDisconnect = New System.Windows.Forms.Button()
		Me.TextBox_TcJoyPath = New System.Windows.Forms.TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.TextBox_ADSRate = New System.Windows.Forms.TextBox()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.TextBox_ADSNetID = New System.Windows.Forms.TextBox()
		Me.TextBox_TcJoyFunctionBlockStatus = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.TextBox_ADSPort = New System.Windows.Forms.TextBox()
		Me.TextBox_ADSConnectionStatus = New System.Windows.Forms.TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Button_ADSConnect = New System.Windows.Forms.Button()
		Me.CheckBox_AutoConnectOnOpen = New System.Windows.Forms.CheckBox()
		Me.TabPage_Help = New System.Windows.Forms.TabPage()
		Me.RichTextBox_Help = New System.Windows.Forms.RichTextBox()
		Me.TabPage1 = New System.Windows.Forms.TabPage()
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.Label33 = New System.Windows.Forms.Label()
		Me.Label32 = New System.Windows.Forms.Label()
		Me.Label31 = New System.Windows.Forms.Label()
		Me.Label30 = New System.Windows.Forms.Label()
		Me.Label27 = New System.Windows.Forms.Label()
		Me.Label29 = New System.Windows.Forms.Label()
		Me.TextBox9 = New System.Windows.Forms.TextBox()
		Me.Label24 = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.Button8 = New System.Windows.Forms.Button()
		Me.Label28 = New System.Windows.Forms.Label()
		Me.TextBox10 = New System.Windows.Forms.TextBox()
		Me.Label26 = New System.Windows.Forms.Label()
		Me.Label25 = New System.Windows.Forms.Label()
		Me.Button3 = New System.Windows.Forms.Button()
		Me.Button7 = New System.Windows.Forms.Button()
		Me.Button6 = New System.Windows.Forms.Button()
		Me.TextBox7 = New System.Windows.Forms.TextBox()
		Me.Button12 = New System.Windows.Forms.Button()
		Me.Button11 = New System.Windows.Forms.Button()
		Me.Button10 = New System.Windows.Forms.Button()
		Me.Button9 = New System.Windows.Forms.Button()
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TextBox6 = New System.Windows.Forms.TextBox()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.TextBox4 = New System.Windows.Forms.TextBox()
		Me.Button4 = New System.Windows.Forms.Button()
		Me.TextBox2 = New System.Windows.Forms.TextBox()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.TextBox5 = New System.Windows.Forms.TextBox()
		Me.Button5 = New System.Windows.Forms.Button()
		Me.TextBox3 = New System.Windows.Forms.TextBox()
		Me.Label19 = New System.Windows.Forms.Label()
		Me.TextBox1 = New System.Windows.Forms.TextBox()
		Me.Label21 = New System.Windows.Forms.Label()
		Me.Label23 = New System.Windows.Forms.Label()
		Me.Label22 = New System.Windows.Forms.Label()
		Me.Label20 = New System.Windows.Forms.Label()
		Me.TextBox13 = New System.Windows.Forms.TextBox()
		Me.TextBox11 = New System.Windows.Forms.TextBox()
		Me.DataGridView1 = New System.Windows.Forms.DataGridView()
		Me.PositionNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Jerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Accel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Decel = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.Dwell = New System.Windows.Forms.DataGridViewTextBoxColumn()
		Me.SameDeCel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
		Me.TextBox12 = New System.Windows.Forms.TextBox()
		Me.TextBox8 = New System.Windows.Forms.TextBox()
		Me.TabControl.SuspendLayout()
		Me.TabPage_LiveStatus.SuspendLayout()
		Me.TabPage_Connection.SuspendLayout()
		Me.GroupBox_Controller.SuspendLayout()
		Me.GroupBox_PLC.SuspendLayout()
		Me.TabPage_Help.SuspendLayout()
		Me.TabPage1.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBox1.SuspendLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'TabControl
		'
		Me.TabControl.Controls.Add(Me.TabPage1)
		Me.TabControl.Controls.Add(Me.TabPage_LiveStatus)
		Me.TabControl.Controls.Add(Me.TabPage_Connection)
		Me.TabControl.Controls.Add(Me.TabPage_Help)
		Me.TabControl.Location = New System.Drawing.Point(3, 5)
		Me.TabControl.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabControl.Name = "TabControl"
		Me.TabControl.SelectedIndex = 0
		Me.TabControl.Size = New System.Drawing.Size(1820, 1037)
		Me.TabControl.TabIndex = 0
		'
		'TabPage_LiveStatus
		'
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightShoulderAnalog)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftShoulderAnalog)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickYMinus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickYMinus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickYPlus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickYPlus)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftShoulderVal)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightShoulderVal)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickYNeg)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickYPos)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickYPos)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickYNeg)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickXPos)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_RightStickXNeg)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickXPos)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_LeftStickXNeg)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_RightShoulderBtn)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_LeftShoulderBtn)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_DPadLeft)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_DPadRight)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_DPadDown)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_DPadUp)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_BackBtn)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_StartBtn)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_XButton)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_BButton)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_AButton)
		Me.TabPage_LiveStatus.Controls.Add(Me.CheckBox_YButton)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickXMinus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_RightStickXPlus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickXMinus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_LeftStickXPlus)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_Controller0Battery)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label18)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_Controller0_Connection)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label_JoyActiveFromPLC)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_ADSBad)
		Me.TabPage_LiveStatus.Controls.Add(Me.ProgressBar_ADSGood)
		Me.TabPage_LiveStatus.Controls.Add(Me.TextBox_ADSDataRateAchieved)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label6)
		Me.TabPage_LiveStatus.Controls.Add(Me.TextBox_ADSConnectionStatus2)
		Me.TabPage_LiveStatus.Controls.Add(Me.Label5)
		Me.TabPage_LiveStatus.Location = New System.Drawing.Point(4, 29)
		Me.TabPage_LiveStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_LiveStatus.Name = "TabPage_LiveStatus"
		Me.TabPage_LiveStatus.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_LiveStatus.Size = New System.Drawing.Size(762, 1004)
		Me.TabPage_LiveStatus.TabIndex = 0
		Me.TabPage_LiveStatus.Text = "Live Status"
		Me.TabPage_LiveStatus.UseVisualStyleBackColor = True
		'
		'ProgressBar_RightShoulderAnalog
		'
		Me.ProgressBar_RightShoulderAnalog.Location = New System.Drawing.Point(544, 135)
		Me.ProgressBar_RightShoulderAnalog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_RightShoulderAnalog.Maximum = 255
		Me.ProgressBar_RightShoulderAnalog.Name = "ProgressBar_RightShoulderAnalog"
		Me.ProgressBar_RightShoulderAnalog.Size = New System.Drawing.Size(15, 69)
		Me.ProgressBar_RightShoulderAnalog.TabIndex = 58
		Me.ProgressBar_RightShoulderAnalog.Value = 255
		'
		'ProgressBar_LeftShoulderAnalog
		'
		Me.ProgressBar_LeftShoulderAnalog.Location = New System.Drawing.Point(152, 135)
		Me.ProgressBar_LeftShoulderAnalog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_LeftShoulderAnalog.Maximum = 255
		Me.ProgressBar_LeftShoulderAnalog.Name = "ProgressBar_LeftShoulderAnalog"
		Me.ProgressBar_LeftShoulderAnalog.Size = New System.Drawing.Size(15, 69)
		Me.ProgressBar_LeftShoulderAnalog.TabIndex = 57
		Me.ProgressBar_LeftShoulderAnalog.Value = 255
		'
		'ProgressBar_LeftStickYMinus
		'
		Me.ProgressBar_LeftStickYMinus.Location = New System.Drawing.Point(153, 391)
		Me.ProgressBar_LeftStickYMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_LeftStickYMinus.Maximum = 32768
		Me.ProgressBar_LeftStickYMinus.Name = "ProgressBar_LeftStickYMinus"
		Me.ProgressBar_LeftStickYMinus.Size = New System.Drawing.Size(14, 69)
		Me.ProgressBar_LeftStickYMinus.TabIndex = 56
		'
		'ProgressBar_RightStickYMinus
		'
		Me.ProgressBar_RightStickYMinus.Location = New System.Drawing.Point(498, 572)
		Me.ProgressBar_RightStickYMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_RightStickYMinus.Maximum = 32768
		Me.ProgressBar_RightStickYMinus.Name = "ProgressBar_RightStickYMinus"
		Me.ProgressBar_RightStickYMinus.Size = New System.Drawing.Size(14, 69)
		Me.ProgressBar_RightStickYMinus.TabIndex = 55
		'
		'ProgressBar_RightStickYPlus
		'
		Me.ProgressBar_RightStickYPlus.Location = New System.Drawing.Point(498, 478)
		Me.ProgressBar_RightStickYPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_RightStickYPlus.Maximum = 32768
		Me.ProgressBar_RightStickYPlus.Name = "ProgressBar_RightStickYPlus"
		Me.ProgressBar_RightStickYPlus.Size = New System.Drawing.Size(15, 69)
		Me.ProgressBar_RightStickYPlus.TabIndex = 54
		Me.ProgressBar_RightStickYPlus.Value = 32768
		'
		'ProgressBar_LeftStickYPlus
		'
		Me.ProgressBar_LeftStickYPlus.Location = New System.Drawing.Point(153, 302)
		Me.ProgressBar_LeftStickYPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_LeftStickYPlus.Maximum = 32768
		Me.ProgressBar_LeftStickYPlus.Name = "ProgressBar_LeftStickYPlus"
		Me.ProgressBar_LeftStickYPlus.Size = New System.Drawing.Size(15, 69)
		Me.ProgressBar_LeftStickYPlus.TabIndex = 51
		Me.ProgressBar_LeftStickYPlus.Value = 32768
		'
		'Label_LeftShoulderVal
		'
		Me.Label_LeftShoulderVal.AutoSize = True
		Me.Label_LeftShoulderVal.Location = New System.Drawing.Point(168, 165)
		Me.Label_LeftShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_LeftShoulderVal.Name = "Label_LeftShoulderVal"
		Me.Label_LeftShoulderVal.Size = New System.Drawing.Size(49, 20)
		Me.Label_LeftShoulderVal.TabIndex = 49
		Me.Label_LeftShoulderVal.Text = "L Val:"
		'
		'Label_RightShoulderVal
		'
		Me.Label_RightShoulderVal.AutoSize = True
		Me.Label_RightShoulderVal.Location = New System.Drawing.Point(492, 165)
		Me.Label_RightShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_RightShoulderVal.Name = "Label_RightShoulderVal"
		Me.Label_RightShoulderVal.Size = New System.Drawing.Size(52, 20)
		Me.Label_RightShoulderVal.TabIndex = 48
		Me.Label_RightShoulderVal.Text = "R Val:"
		'
		'Label_RightStickYNeg
		'
		Me.Label_RightStickYNeg.AutoSize = True
		Me.Label_RightStickYNeg.Location = New System.Drawing.Point(480, 648)
		Me.Label_RightStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_RightStickYNeg.Name = "Label_RightStickYNeg"
		Me.Label_RightStickYNeg.Size = New System.Drawing.Size(55, 20)
		Me.Label_RightStickYNeg.TabIndex = 43
		Me.Label_RightStickYNeg.Text = "Y Val: "
		'
		'Label_RightStickYPos
		'
		Me.Label_RightStickYPos.AutoSize = True
		Me.Label_RightStickYPos.Location = New System.Drawing.Point(478, 452)
		Me.Label_RightStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_RightStickYPos.Name = "Label_RightStickYPos"
		Me.Label_RightStickYPos.Size = New System.Drawing.Size(55, 20)
		Me.Label_RightStickYPos.TabIndex = 42
		Me.Label_RightStickYPos.Text = "Y Val: "
		'
		'Label_LeftStickYPos
		'
		Me.Label_LeftStickYPos.AutoSize = True
		Me.Label_LeftStickYPos.Location = New System.Drawing.Point(134, 278)
		Me.Label_LeftStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_LeftStickYPos.Name = "Label_LeftStickYPos"
		Me.Label_LeftStickYPos.Size = New System.Drawing.Size(55, 20)
		Me.Label_LeftStickYPos.TabIndex = 41
		Me.Label_LeftStickYPos.Text = "Y Val: "
		'
		'Label_LeftStickYNeg
		'
		Me.Label_LeftStickYNeg.AutoSize = True
		Me.Label_LeftStickYNeg.Location = New System.Drawing.Point(132, 465)
		Me.Label_LeftStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_LeftStickYNeg.Name = "Label_LeftStickYNeg"
		Me.Label_LeftStickYNeg.Size = New System.Drawing.Size(55, 20)
		Me.Label_LeftStickYNeg.TabIndex = 40
		Me.Label_LeftStickYNeg.Text = "Y Val: "
		'
		'Label_RightStickXPos
		'
		Me.Label_RightStickXPos.AutoSize = True
		Me.Label_RightStickXPos.Location = New System.Drawing.Point(532, 571)
		Me.Label_RightStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_RightStickXPos.Name = "Label_RightStickXPos"
		Me.Label_RightStickXPos.Size = New System.Drawing.Size(55, 20)
		Me.Label_RightStickXPos.TabIndex = 39
		Me.Label_RightStickXPos.Text = "X Val: "
		'
		'Label_RightStickXNeg
		'
		Me.Label_RightStickXNeg.AutoSize = True
		Me.Label_RightStickXNeg.Location = New System.Drawing.Point(423, 571)
		Me.Label_RightStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_RightStickXNeg.Name = "Label_RightStickXNeg"
		Me.Label_RightStickXNeg.Size = New System.Drawing.Size(55, 20)
		Me.Label_RightStickXNeg.TabIndex = 38
		Me.Label_RightStickXNeg.Text = "X Val: "
		'
		'Label_LeftStickXPos
		'
		Me.Label_LeftStickXPos.AutoSize = True
		Me.Label_LeftStickXPos.Location = New System.Drawing.Point(184, 394)
		Me.Label_LeftStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_LeftStickXPos.Name = "Label_LeftStickXPos"
		Me.Label_LeftStickXPos.Size = New System.Drawing.Size(55, 20)
		Me.Label_LeftStickXPos.TabIndex = 37
		Me.Label_LeftStickXPos.Text = "X Val: "
		'
		'Label_LeftStickXNeg
		'
		Me.Label_LeftStickXNeg.AutoSize = True
		Me.Label_LeftStickXNeg.Location = New System.Drawing.Point(75, 394)
		Me.Label_LeftStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_LeftStickXNeg.Name = "Label_LeftStickXNeg"
		Me.Label_LeftStickXNeg.Size = New System.Drawing.Size(55, 20)
		Me.Label_LeftStickXNeg.TabIndex = 36
		Me.Label_LeftStickXNeg.Text = "X Val: "
		'
		'CheckBox_RightShoulderBtn
		'
		Me.CheckBox_RightShoulderBtn.AutoSize = True
		Me.CheckBox_RightShoulderBtn.Location = New System.Drawing.Point(480, 240)
		Me.CheckBox_RightShoulderBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_RightShoulderBtn.Name = "CheckBox_RightShoulderBtn"
		Me.CheckBox_RightShoulderBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_RightShoulderBtn.Size = New System.Drawing.Size(170, 24)
		Me.CheckBox_RightShoulderBtn.TabIndex = 33
		Me.CheckBox_RightShoulderBtn.Text = "Right Shoulder Btn"
		Me.CheckBox_RightShoulderBtn.UseVisualStyleBackColor = True
		'
		'CheckBox_LeftShoulderBtn
		'
		Me.CheckBox_LeftShoulderBtn.AutoSize = True
		Me.CheckBox_LeftShoulderBtn.Location = New System.Drawing.Point(80, 240)
		Me.CheckBox_LeftShoulderBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_LeftShoulderBtn.Name = "CheckBox_LeftShoulderBtn"
		Me.CheckBox_LeftShoulderBtn.Size = New System.Drawing.Size(156, 24)
		Me.CheckBox_LeftShoulderBtn.TabIndex = 32
		Me.CheckBox_LeftShoulderBtn.Text = "LeftShoulder Btn"
		Me.CheckBox_LeftShoulderBtn.UseVisualStyleBackColor = True
		'
		'CheckBox_DPadLeft
		'
		Me.CheckBox_DPadLeft.AutoSize = True
		Me.CheckBox_DPadLeft.Location = New System.Drawing.Point(120, 549)
		Me.CheckBox_DPadLeft.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_DPadLeft.Name = "CheckBox_DPadLeft"
		Me.CheckBox_DPadLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_DPadLeft.Size = New System.Drawing.Size(63, 24)
		Me.CheckBox_DPadLeft.TabIndex = 31
		Me.CheckBox_DPadLeft.Text = "Left"
		Me.CheckBox_DPadLeft.UseVisualStyleBackColor = True
		'
		'CheckBox_DPadRight
		'
		Me.CheckBox_DPadRight.AutoSize = True
		Me.CheckBox_DPadRight.Location = New System.Drawing.Point(242, 549)
		Me.CheckBox_DPadRight.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_DPadRight.Name = "CheckBox_DPadRight"
		Me.CheckBox_DPadRight.Size = New System.Drawing.Size(73, 24)
		Me.CheckBox_DPadRight.TabIndex = 30
		Me.CheckBox_DPadRight.Text = "Right"
		Me.CheckBox_DPadRight.UseVisualStyleBackColor = True
		'
		'CheckBox_DPadDown
		'
		Me.CheckBox_DPadDown.AutoSize = True
		Me.CheckBox_DPadDown.Location = New System.Drawing.Point(202, 591)
		Me.CheckBox_DPadDown.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_DPadDown.Name = "CheckBox_DPadDown"
		Me.CheckBox_DPadDown.Size = New System.Drawing.Size(76, 24)
		Me.CheckBox_DPadDown.TabIndex = 29
		Me.CheckBox_DPadDown.Text = "Down"
		Me.CheckBox_DPadDown.UseVisualStyleBackColor = True
		'
		'CheckBox_DPadUp
		'
		Me.CheckBox_DPadUp.AutoSize = True
		Me.CheckBox_DPadUp.Location = New System.Drawing.Point(165, 512)
		Me.CheckBox_DPadUp.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_DPadUp.Name = "CheckBox_DPadUp"
		Me.CheckBox_DPadUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_DPadUp.Size = New System.Drawing.Size(56, 24)
		Me.CheckBox_DPadUp.TabIndex = 28
		Me.CheckBox_DPadUp.Text = "Up"
		Me.CheckBox_DPadUp.UseVisualStyleBackColor = True
		'
		'CheckBox_BackBtn
		'
		Me.CheckBox_BackBtn.AutoSize = True
		Me.CheckBox_BackBtn.Location = New System.Drawing.Point(278, 374)
		Me.CheckBox_BackBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_BackBtn.Name = "CheckBox_BackBtn"
		Me.CheckBox_BackBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_BackBtn.Size = New System.Drawing.Size(71, 24)
		Me.CheckBox_BackBtn.TabIndex = 27
		Me.CheckBox_BackBtn.Text = "Back"
		Me.CheckBox_BackBtn.UseVisualStyleBackColor = True
		'
		'CheckBox_StartBtn
		'
		Me.CheckBox_StartBtn.AutoSize = True
		Me.CheckBox_StartBtn.Location = New System.Drawing.Point(414, 374)
		Me.CheckBox_StartBtn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_StartBtn.Name = "CheckBox_StartBtn"
		Me.CheckBox_StartBtn.Size = New System.Drawing.Size(70, 24)
		Me.CheckBox_StartBtn.TabIndex = 26
		Me.CheckBox_StartBtn.Text = "Start"
		Me.CheckBox_StartBtn.UseVisualStyleBackColor = True
		'
		'CheckBox_XButton
		'
		Me.CheckBox_XButton.AutoSize = True
		Me.CheckBox_XButton.Location = New System.Drawing.Point(519, 374)
		Me.CheckBox_XButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_XButton.Name = "CheckBox_XButton"
		Me.CheckBox_XButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_XButton.Size = New System.Drawing.Size(46, 24)
		Me.CheckBox_XButton.TabIndex = 25
		Me.CheckBox_XButton.Text = "X"
		Me.CheckBox_XButton.UseVisualStyleBackColor = True
		'
		'CheckBox_BButton
		'
		Me.CheckBox_BButton.AutoSize = True
		Me.CheckBox_BButton.Location = New System.Drawing.Point(624, 374)
		Me.CheckBox_BButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_BButton.Name = "CheckBox_BButton"
		Me.CheckBox_BButton.Size = New System.Drawing.Size(46, 24)
		Me.CheckBox_BButton.TabIndex = 24
		Me.CheckBox_BButton.Text = "B"
		Me.CheckBox_BButton.UseVisualStyleBackColor = True
		'
		'CheckBox_AButton
		'
		Me.CheckBox_AButton.AutoSize = True
		Me.CheckBox_AButton.Location = New System.Drawing.Point(585, 412)
		Me.CheckBox_AButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_AButton.Name = "CheckBox_AButton"
		Me.CheckBox_AButton.Size = New System.Drawing.Size(46, 24)
		Me.CheckBox_AButton.TabIndex = 23
		Me.CheckBox_AButton.Text = "A"
		Me.CheckBox_AButton.UseVisualStyleBackColor = True
		'
		'CheckBox_YButton
		'
		Me.CheckBox_YButton.AutoSize = True
		Me.CheckBox_YButton.Location = New System.Drawing.Point(558, 334)
		Me.CheckBox_YButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_YButton.Name = "CheckBox_YButton"
		Me.CheckBox_YButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.CheckBox_YButton.Size = New System.Drawing.Size(46, 24)
		Me.CheckBox_YButton.TabIndex = 22
		Me.CheckBox_YButton.Text = "Y"
		Me.CheckBox_YButton.UseVisualStyleBackColor = True
		'
		'ProgressBar_RightStickXMinus
		'
		Me.ProgressBar_RightStickXMinus.Location = New System.Drawing.Point(417, 551)
		Me.ProgressBar_RightStickXMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_RightStickXMinus.MarqueeAnimationSpeed = 0
		Me.ProgressBar_RightStickXMinus.Maximum = 32768
		Me.ProgressBar_RightStickXMinus.Name = "ProgressBar_RightStickXMinus"
		Me.ProgressBar_RightStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ProgressBar_RightStickXMinus.RightToLeftLayout = True
		Me.ProgressBar_RightStickXMinus.Size = New System.Drawing.Size(69, 15)
		Me.ProgressBar_RightStickXMinus.TabIndex = 21
		'
		'ProgressBar_RightStickXPlus
		'
		Me.ProgressBar_RightStickXPlus.Location = New System.Drawing.Point(528, 551)
		Me.ProgressBar_RightStickXPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_RightStickXPlus.MarqueeAnimationSpeed = 0
		Me.ProgressBar_RightStickXPlus.Maximum = 32768
		Me.ProgressBar_RightStickXPlus.Name = "ProgressBar_RightStickXPlus"
		Me.ProgressBar_RightStickXPlus.Size = New System.Drawing.Size(69, 15)
		Me.ProgressBar_RightStickXPlus.TabIndex = 20
		'
		'ProgressBar_LeftStickXMinus
		'
		Me.ProgressBar_LeftStickXMinus.Location = New System.Drawing.Point(70, 374)
		Me.ProgressBar_LeftStickXMinus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_LeftStickXMinus.MarqueeAnimationSpeed = 0
		Me.ProgressBar_LeftStickXMinus.Maximum = 32768
		Me.ProgressBar_LeftStickXMinus.Name = "ProgressBar_LeftStickXMinus"
		Me.ProgressBar_LeftStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ProgressBar_LeftStickXMinus.RightToLeftLayout = True
		Me.ProgressBar_LeftStickXMinus.Size = New System.Drawing.Size(69, 15)
		Me.ProgressBar_LeftStickXMinus.TabIndex = 19
		'
		'ProgressBar_LeftStickXPlus
		'
		Me.ProgressBar_LeftStickXPlus.Location = New System.Drawing.Point(178, 374)
		Me.ProgressBar_LeftStickXPlus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_LeftStickXPlus.MarqueeAnimationSpeed = 0
		Me.ProgressBar_LeftStickXPlus.Maximum = 32768
		Me.ProgressBar_LeftStickXPlus.Name = "ProgressBar_LeftStickXPlus"
		Me.ProgressBar_LeftStickXPlus.Size = New System.Drawing.Size(69, 15)
		Me.ProgressBar_LeftStickXPlus.TabIndex = 18
		'
		'ProgressBar_Controller0Battery
		'
		Me.ProgressBar_Controller0Battery.Location = New System.Drawing.Point(528, 43)
		Me.ProgressBar_Controller0Battery.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_Controller0Battery.MarqueeAnimationSpeed = 1
		Me.ProgressBar_Controller0Battery.Name = "ProgressBar_Controller0Battery"
		Me.ProgressBar_Controller0Battery.Size = New System.Drawing.Size(210, 15)
		Me.ProgressBar_Controller0Battery.TabIndex = 17
		'
		'Label18
		'
		Me.Label18.AutoSize = True
		Me.Label18.Location = New System.Drawing.Point(456, 38)
		Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label18.Name = "Label18"
		Me.Label18.Size = New System.Drawing.Size(64, 20)
		Me.Label18.TabIndex = 16
		Me.Label18.Text = "Battery:"
		'
		'Label_Controller0_Connection
		'
		Me.Label_Controller0_Connection.BackColor = System.Drawing.Color.Transparent
		Me.Label_Controller0_Connection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label_Controller0_Connection.Location = New System.Drawing.Point(460, 9)
		Me.Label_Controller0_Connection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_Controller0_Connection.Name = "Label_Controller0_Connection"
		Me.Label_Controller0_Connection.Size = New System.Drawing.Size(278, 29)
		Me.Label_Controller0_Connection.TabIndex = 15
		Me.Label_Controller0_Connection.Text = "Controller 0 Connection"
		Me.Label_Controller0_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'Label_JoyActiveFromPLC
		'
		Me.Label_JoyActiveFromPLC.BackColor = System.Drawing.Color.Transparent
		Me.Label_JoyActiveFromPLC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Label_JoyActiveFromPLC.Location = New System.Drawing.Point(106, 891)
		Me.Label_JoyActiveFromPLC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label_JoyActiveFromPLC.Name = "Label_JoyActiveFromPLC"
		Me.Label_JoyActiveFromPLC.Size = New System.Drawing.Size(177, 35)
		Me.Label_JoyActiveFromPLC.TabIndex = 14
		Me.Label_JoyActiveFromPLC.Text = "Latency Status"
		Me.Label_JoyActiveFromPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		'
		'ProgressBar_ADSBad
		'
		Me.ProgressBar_ADSBad.Location = New System.Drawing.Point(460, 891)
		Me.ProgressBar_ADSBad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_ADSBad.MarqueeAnimationSpeed = 0
		Me.ProgressBar_ADSBad.Name = "ProgressBar_ADSBad"
		Me.ProgressBar_ADSBad.Size = New System.Drawing.Size(158, 35)
		Me.ProgressBar_ADSBad.TabIndex = 13
		'
		'ProgressBar_ADSGood
		'
		Me.ProgressBar_ADSGood.Location = New System.Drawing.Point(303, 891)
		Me.ProgressBar_ADSGood.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.ProgressBar_ADSGood.MarqueeAnimationSpeed = 0
		Me.ProgressBar_ADSGood.Name = "ProgressBar_ADSGood"
		Me.ProgressBar_ADSGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes
		Me.ProgressBar_ADSGood.RightToLeftLayout = True
		Me.ProgressBar_ADSGood.Size = New System.Drawing.Size(158, 35)
		Me.ProgressBar_ADSGood.TabIndex = 12
		'
		'TextBox_ADSDataRateAchieved
		'
		Me.TextBox_ADSDataRateAchieved.Enabled = False
		Me.TextBox_ADSDataRateAchieved.Location = New System.Drawing.Point(303, 851)
		Me.TextBox_ADSDataRateAchieved.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSDataRateAchieved.Name = "TextBox_ADSDataRateAchieved"
		Me.TextBox_ADSDataRateAchieved.Size = New System.Drawing.Size(314, 26)
		Me.TextBox_ADSDataRateAchieved.TabIndex = 11
		Me.TextBox_ADSDataRateAchieved.TabStop = False
		Me.TextBox_ADSDataRateAchieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(102, 855)
		Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(194, 20)
		Me.Label6.TabIndex = 10
		Me.Label6.Text = "ADS Data Rate Achieved:"
		'
		'TextBox_ADSConnectionStatus2
		'
		Me.TextBox_ADSConnectionStatus2.Enabled = False
		Me.TextBox_ADSConnectionStatus2.Location = New System.Drawing.Point(303, 932)
		Me.TextBox_ADSConnectionStatus2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSConnectionStatus2.Name = "TextBox_ADSConnectionStatus2"
		Me.TextBox_ADSConnectionStatus2.Size = New System.Drawing.Size(314, 26)
		Me.TextBox_ADSConnectionStatus2.TabIndex = 9
		Me.TextBox_ADSConnectionStatus2.TabStop = False
		Me.TextBox_ADSConnectionStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(102, 937)
		Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(187, 20)
		Me.Label5.TabIndex = 8
		Me.Label5.Text = "ADS Connection Status: "
		'
		'TabPage_Connection
		'
		Me.TabPage_Connection.Controls.Add(Me.GroupBox_Controller)
		Me.TabPage_Connection.Controls.Add(Me.GroupBox_PLC)
		Me.TabPage_Connection.Location = New System.Drawing.Point(4, 29)
		Me.TabPage_Connection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_Connection.Name = "TabPage_Connection"
		Me.TabPage_Connection.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_Connection.Size = New System.Drawing.Size(762, 1004)
		Me.TabPage_Connection.TabIndex = 1
		Me.TabPage_Connection.Text = "Connection"
		Me.TabPage_Connection.UseVisualStyleBackColor = True
		'
		'GroupBox_Controller
		'
		Me.GroupBox_Controller.Controls.Add(Me.Label16)
		Me.GroupBox_Controller.Controls.Add(Me.Label17)
		Me.GroupBox_Controller.Controls.Add(Me.TextBox_ShoulderDeadzone)
		Me.GroupBox_Controller.Controls.Add(Me.Label15)
		Me.GroupBox_Controller.Controls.Add(Me.Label14)
		Me.GroupBox_Controller.Controls.Add(Me.TextBox_AnalogDeadzone)
		Me.GroupBox_Controller.Location = New System.Drawing.Point(9, 468)
		Me.GroupBox_Controller.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox_Controller.Name = "GroupBox_Controller"
		Me.GroupBox_Controller.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox_Controller.Size = New System.Drawing.Size(740, 517)
		Me.GroupBox_Controller.TabIndex = 11
		Me.GroupBox_Controller.TabStop = False
		Me.GroupBox_Controller.Text = "Game Controller"
		'
		'Label16
		'
		Me.Label16.AutoSize = True
		Me.Label16.Location = New System.Drawing.Point(340, 120)
		Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label16.Name = "Label16"
		Me.Label16.Size = New System.Drawing.Size(131, 20)
		Me.Label16.TabIndex = 23
		Me.Label16.Text = "counts (255 max)"
		'
		'Label17
		'
		Me.Label17.AutoSize = True
		Me.Label17.Location = New System.Drawing.Point(39, 120)
		Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label17.Name = "Label17"
		Me.Label17.Size = New System.Drawing.Size(211, 20)
		Me.Label17.TabIndex = 24
		Me.Label17.Text = "Analog Shoulder Dead Zone"
		'
		'TextBox_ShoulderDeadzone
		'
		Me.TextBox_ShoulderDeadzone.Location = New System.Drawing.Point(260, 114)
		Me.TextBox_ShoulderDeadzone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ShoulderDeadzone.Name = "TextBox_ShoulderDeadzone"
		Me.TextBox_ShoulderDeadzone.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_ShoulderDeadzone.TabIndex = 7
		Me.TextBox_ShoulderDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label15
		'
		Me.Label15.AutoSize = True
		Me.Label15.Location = New System.Drawing.Point(340, 80)
		Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label15.Name = "Label15"
		Me.Label15.Size = New System.Drawing.Size(149, 20)
		Me.Label15.TabIndex = 22
		Me.Label15.Text = "counts (32767 max)"
		'
		'Label14
		'
		Me.Label14.AutoSize = True
		Me.Label14.Location = New System.Drawing.Point(39, 80)
		Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label14.Name = "Label14"
		Me.Label14.Size = New System.Drawing.Size(182, 20)
		Me.Label14.TabIndex = 22
		Me.Label14.Text = "Analog Stick Dead Zone"
		'
		'TextBox_AnalogDeadzone
		'
		Me.TextBox_AnalogDeadzone.Location = New System.Drawing.Point(260, 74)
		Me.TextBox_AnalogDeadzone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_AnalogDeadzone.Name = "TextBox_AnalogDeadzone"
		Me.TextBox_AnalogDeadzone.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_AnalogDeadzone.TabIndex = 6
		Me.TextBox_AnalogDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'GroupBox_PLC
		'
		Me.GroupBox_PLC.Controls.Add(Me.Label12)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSWatchdogDeadDuration)
		Me.GroupBox_PLC.Controls.Add(Me.Label13)
		Me.GroupBox_PLC.Controls.Add(Me.Label10)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSWatchdog)
		Me.GroupBox_PLC.Controls.Add(Me.Label11)
		Me.GroupBox_PLC.Controls.Add(Me.Button_ADSDisconnect)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_TcJoyPath)
		Me.GroupBox_PLC.Controls.Add(Me.Label9)
		Me.GroupBox_PLC.Controls.Add(Me.Label8)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSRate)
		Me.GroupBox_PLC.Controls.Add(Me.Label7)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSNetID)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_TcJoyFunctionBlockStatus)
		Me.GroupBox_PLC.Controls.Add(Me.Label1)
		Me.GroupBox_PLC.Controls.Add(Me.Label4)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSPort)
		Me.GroupBox_PLC.Controls.Add(Me.TextBox_ADSConnectionStatus)
		Me.GroupBox_PLC.Controls.Add(Me.Label2)
		Me.GroupBox_PLC.Controls.Add(Me.Label3)
		Me.GroupBox_PLC.Controls.Add(Me.Button_ADSConnect)
		Me.GroupBox_PLC.Controls.Add(Me.CheckBox_AutoConnectOnOpen)
		Me.GroupBox_PLC.Location = New System.Drawing.Point(9, 9)
		Me.GroupBox_PLC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox_PLC.Name = "GroupBox_PLC"
		Me.GroupBox_PLC.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.GroupBox_PLC.Size = New System.Drawing.Size(740, 449)
		Me.GroupBox_PLC.TabIndex = 10
		Me.GroupBox_PLC.TabStop = False
		Me.GroupBox_PLC.Text = "PLC"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.Location = New System.Drawing.Point(298, 197)
		Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(30, 20)
		Me.Label12.TabIndex = 21
		Me.Label12.Text = "ms"
		'
		'TextBox_ADSWatchdogDeadDuration
		'
		Me.TextBox_ADSWatchdogDeadDuration.Location = New System.Drawing.Point(219, 192)
		Me.TextBox_ADSWatchdogDeadDuration.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSWatchdogDeadDuration.Name = "TextBox_ADSWatchdogDeadDuration"
		Me.TextBox_ADSWatchdogDeadDuration.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_ADSWatchdogDeadDuration.TabIndex = 4
		Me.TextBox_ADSWatchdogDeadDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label13
		'
		Me.Label13.AutoSize = True
		Me.Label13.Location = New System.Drawing.Point(33, 197)
		Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label13.Name = "Label13"
		Me.Label13.Size = New System.Drawing.Size(186, 20)
		Me.Label13.TabIndex = 20
		Me.Label13.Text = "ADS WD Dead Duration:"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(298, 158)
		Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(30, 20)
		Me.Label10.TabIndex = 18
		Me.Label10.Text = "ms"
		'
		'TextBox_ADSWatchdog
		'
		Me.TextBox_ADSWatchdog.Location = New System.Drawing.Point(219, 154)
		Me.TextBox_ADSWatchdog.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSWatchdog.Name = "TextBox_ADSWatchdog"
		Me.TextBox_ADSWatchdog.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_ADSWatchdog.TabIndex = 3
		Me.TextBox_ADSWatchdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(33, 158)
		Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(124, 20)
		Me.Label11.TabIndex = 17
		Me.Label11.Text = "ADS Watchdog:"
		'
		'Button_ADSDisconnect
		'
		Me.Button_ADSDisconnect.Location = New System.Drawing.Point(494, 112)
		Me.Button_ADSDisconnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button_ADSDisconnect.Name = "Button_ADSDisconnect"
		Me.Button_ADSDisconnect.Size = New System.Drawing.Size(207, 35)
		Me.Button_ADSDisconnect.TabIndex = 10
		Me.Button_ADSDisconnect.Text = "Disconnect"
		Me.Button_ADSDisconnect.UseVisualStyleBackColor = True
		'
		'TextBox_TcJoyPath
		'
		Me.TextBox_TcJoyPath.Location = New System.Drawing.Point(219, 231)
		Me.TextBox_TcJoyPath.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_TcJoyPath.Name = "TextBox_TcJoyPath"
		Me.TextBox_TcJoyPath.Size = New System.Drawing.Size(504, 26)
		Me.TextBox_TcJoyPath.TabIndex = 5
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(33, 235)
		Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(150, 20)
		Me.Label9.TabIndex = 14
		Me.Label9.Text = "FB_TcJoy Instance:"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(298, 122)
		Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(30, 20)
		Me.Label8.TabIndex = 12
		Me.Label8.Text = "ms"
		'
		'TextBox_ADSRate
		'
		Me.TextBox_ADSRate.Location = New System.Drawing.Point(219, 115)
		Me.TextBox_ADSRate.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSRate.Name = "TextBox_ADSRate"
		Me.TextBox_ADSRate.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_ADSRate.TabIndex = 2
		Me.TextBox_ADSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(33, 120)
		Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(86, 20)
		Me.Label7.TabIndex = 11
		Me.Label7.Text = "ADS Rate:"
		'
		'TextBox_ADSNetID
		'
		Me.TextBox_ADSNetID.Location = New System.Drawing.Point(219, 32)
		Me.TextBox_ADSNetID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSNetID.Name = "TextBox_ADSNetID"
		Me.TextBox_ADSNetID.Size = New System.Drawing.Size(206, 26)
		Me.TextBox_ADSNetID.TabIndex = 0
		Me.TextBox_ADSNetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'TextBox_TcJoyFunctionBlockStatus
		'
		Me.TextBox_TcJoyFunctionBlockStatus.Enabled = False
		Me.TextBox_TcJoyFunctionBlockStatus.Location = New System.Drawing.Point(290, 409)
		Me.TextBox_TcJoyFunctionBlockStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_TcJoyFunctionBlockStatus.Name = "TextBox_TcJoyFunctionBlockStatus"
		Me.TextBox_TcJoyFunctionBlockStatus.Size = New System.Drawing.Size(314, 26)
		Me.TextBox_TcJoyFunctionBlockStatus.TabIndex = 9
		Me.TextBox_TcJoyFunctionBlockStatus.TabStop = False
		Me.TextBox_TcJoyFunctionBlockStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(33, 34)
		Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(93, 20)
		Me.Label1.TabIndex = 1
		Me.Label1.Text = "ADS NetID:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(93, 414)
		Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(163, 20)
		Me.Label4.TabIndex = 8
		Me.Label4.Text = "TcJoy Function Block:"
		'
		'TextBox_ADSPort
		'
		Me.TextBox_ADSPort.Location = New System.Drawing.Point(219, 75)
		Me.TextBox_ADSPort.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSPort.Name = "TextBox_ADSPort"
		Me.TextBox_ADSPort.Size = New System.Drawing.Size(70, 26)
		Me.TextBox_ADSPort.TabIndex = 1
		Me.TextBox_ADSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
		'
		'TextBox_ADSConnectionStatus
		'
		Me.TextBox_ADSConnectionStatus.Enabled = False
		Me.TextBox_ADSConnectionStatus.Location = New System.Drawing.Point(290, 371)
		Me.TextBox_ADSConnectionStatus.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TextBox_ADSConnectionStatus.Name = "TextBox_ADSConnectionStatus"
		Me.TextBox_ADSConnectionStatus.Size = New System.Drawing.Size(314, 26)
		Me.TextBox_ADSConnectionStatus.TabIndex = 7
		Me.TextBox_ADSConnectionStatus.TabStop = False
		Me.TextBox_ADSConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(33, 77)
		Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(80, 20)
		Me.Label2.TabIndex = 3
		Me.Label2.Text = "ADS Port:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(93, 375)
		Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(187, 20)
		Me.Label3.TabIndex = 6
		Me.Label3.Text = "ADS Connection Status: "
		'
		'Button_ADSConnect
		'
		Me.Button_ADSConnect.Location = New System.Drawing.Point(494, 68)
		Me.Button_ADSConnect.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Button_ADSConnect.Name = "Button_ADSConnect"
		Me.Button_ADSConnect.Size = New System.Drawing.Size(207, 35)
		Me.Button_ADSConnect.TabIndex = 9
		Me.Button_ADSConnect.Text = "Connect"
		Me.Button_ADSConnect.UseVisualStyleBackColor = True
		'
		'CheckBox_AutoConnectOnOpen
		'
		Me.CheckBox_AutoConnectOnOpen.AutoSize = True
		Me.CheckBox_AutoConnectOnOpen.Location = New System.Drawing.Point(494, 32)
		Me.CheckBox_AutoConnectOnOpen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.CheckBox_AutoConnectOnOpen.Name = "CheckBox_AutoConnectOnOpen"
		Me.CheckBox_AutoConnectOnOpen.Size = New System.Drawing.Size(197, 24)
		Me.CheckBox_AutoConnectOnOpen.TabIndex = 8
		Me.CheckBox_AutoConnectOnOpen.Text = "Auto Connect On Start"
		Me.CheckBox_AutoConnectOnOpen.UseVisualStyleBackColor = True
		'
		'TabPage_Help
		'
		Me.TabPage_Help.Controls.Add(Me.RichTextBox_Help)
		Me.TabPage_Help.Location = New System.Drawing.Point(4, 29)
		Me.TabPage_Help.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_Help.Name = "TabPage_Help"
		Me.TabPage_Help.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.TabPage_Help.Size = New System.Drawing.Size(762, 1004)
		Me.TabPage_Help.TabIndex = 2
		Me.TabPage_Help.Text = "Help"
		Me.TabPage_Help.UseVisualStyleBackColor = True
		'
		'RichTextBox_Help
		'
		Me.RichTextBox_Help.Location = New System.Drawing.Point(9, 9)
		Me.RichTextBox_Help.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.RichTextBox_Help.Name = "RichTextBox_Help"
		Me.RichTextBox_Help.Size = New System.Drawing.Size(738, 976)
		Me.RichTextBox_Help.TabIndex = 0
		Me.RichTextBox_Help.Text = resources.GetString("RichTextBox_Help.Text")
		'
		'TabPage1
		'
		Me.TabPage1.Controls.Add(Me.PictureBox1)
		Me.TabPage1.Controls.Add(Me.Label33)
		Me.TabPage1.Controls.Add(Me.Label32)
		Me.TabPage1.Controls.Add(Me.Label31)
		Me.TabPage1.Controls.Add(Me.Label30)
		Me.TabPage1.Controls.Add(Me.Label27)
		Me.TabPage1.Controls.Add(Me.Label29)
		Me.TabPage1.Controls.Add(Me.TextBox9)
		Me.TabPage1.Controls.Add(Me.Label24)
		Me.TabPage1.Controls.Add(Me.GroupBox2)
		Me.TabPage1.Controls.Add(Me.Button12)
		Me.TabPage1.Controls.Add(Me.Button11)
		Me.TabPage1.Controls.Add(Me.Button10)
		Me.TabPage1.Controls.Add(Me.Button9)
		Me.TabPage1.Controls.Add(Me.GroupBox1)
		Me.TabPage1.Controls.Add(Me.TextBox13)
		Me.TabPage1.Controls.Add(Me.TextBox11)
		Me.TabPage1.Controls.Add(Me.DataGridView1)
		Me.TabPage1.Controls.Add(Me.TextBox12)
		Me.TabPage1.Controls.Add(Me.TextBox8)
		Me.TabPage1.Location = New System.Drawing.Point(4, 29)
		Me.TabPage1.Name = "TabPage1"
		Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
		Me.TabPage1.Size = New System.Drawing.Size(1812, 1004)
		Me.TabPage1.TabIndex = 4
		Me.TabPage1.Text = "Hank Rig Controls"
		Me.TabPage1.UseVisualStyleBackColor = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Location = New System.Drawing.Point(102, 198)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(365, 315)
		Me.PictureBox1.TabIndex = 10
		Me.PictureBox1.TabStop = False
		'
		'Label33
		'
		Me.Label33.AutoSize = True
		Me.Label33.Location = New System.Drawing.Point(599, 535)
		Me.Label33.Name = "Label33"
		Me.Label33.Size = New System.Drawing.Size(216, 20)
		Me.Label33.TabIndex = 9
		Me.Label33.Text = "Automatic Sequence Paused"
		'
		'Label32
		'
		Me.Label32.AutoSize = True
		Me.Label32.Location = New System.Drawing.Point(599, 493)
		Me.Label32.Name = "Label32"
		Me.Label32.Size = New System.Drawing.Size(143, 20)
		Me.Label32.TabIndex = 9
		Me.Label32.Text = "Manual Step mode"
		'
		'Label31
		'
		Me.Label31.AutoSize = True
		Me.Label31.Location = New System.Drawing.Point(599, 457)
		Me.Label31.Name = "Label31"
		Me.Label31.Size = New System.Drawing.Size(222, 20)
		Me.Label31.TabIndex = 9
		Me.Label31.Text = "Running Automatic Sequence"
		'
		'Label30
		'
		Me.Label30.AutoSize = True
		Me.Label30.Location = New System.Drawing.Point(539, 148)
		Me.Label30.Name = "Label30"
		Me.Label30.Size = New System.Drawing.Size(211, 20)
		Me.Label30.TabIndex = 8
		Me.Label30.Text = "Time Elapsed / Position Time"
		'
		'Label27
		'
		Me.Label27.AutoSize = True
		Me.Label27.Location = New System.Drawing.Point(588, 102)
		Me.Label27.Name = "Label27"
		Me.Label27.Size = New System.Drawing.Size(178, 20)
		Me.Label27.TabIndex = 8
		Me.Label27.Text = "Current PositionNumber"
		'
		'Label29
		'
		Me.Label29.AutoSize = True
		Me.Label29.Location = New System.Drawing.Point(633, 64)
		Me.Label29.Name = "Label29"
		Me.Label29.Size = New System.Drawing.Size(107, 20)
		Me.Label29.TabIndex = 7
		Me.Label29.Text = "User Position:"
		'
		'TextBox9
		'
		Me.TextBox9.Location = New System.Drawing.Point(774, 61)
		Me.TextBox9.Name = "TextBox9"
		Me.TextBox9.Size = New System.Drawing.Size(100, 26)
		Me.TextBox9.TabIndex = 3
		Me.TextBox9.Text = "0.000m"
		'
		'Label24
		'
		Me.Label24.AutoSize = True
		Me.Label24.Location = New System.Drawing.Point(1027, 28)
		Me.Label24.Name = "Label24"
		Me.Label24.Size = New System.Drawing.Size(202, 20)
		Me.Label24.TabIndex = 6
		Me.Label24.Text = "Loaded Test Program data:"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.GroupBox3)
		Me.GroupBox2.Controls.Add(Me.Label26)
		Me.GroupBox2.Controls.Add(Me.Label25)
		Me.GroupBox2.Controls.Add(Me.Button3)
		Me.GroupBox2.Controls.Add(Me.Button7)
		Me.GroupBox2.Controls.Add(Me.Button6)
		Me.GroupBox2.Controls.Add(Me.TextBox7)
		Me.GroupBox2.Location = New System.Drawing.Point(537, 653)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(463, 343)
		Me.GroupBox2.TabIndex = 5
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Setup Functions"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.Button8)
		Me.GroupBox3.Controls.Add(Me.Label28)
		Me.GroupBox3.Controls.Add(Me.TextBox10)
		Me.GroupBox3.Location = New System.Drawing.Point(23, 151)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(387, 138)
		Me.GroupBox3.TabIndex = 8
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Position Offset"
		'
		'Button8
		'
		Me.Button8.Location = New System.Drawing.Point(36, 69)
		Me.Button8.Name = "Button8"
		Me.Button8.Size = New System.Drawing.Size(96, 63)
		Me.Button8.TabIndex = 0
		Me.Button8.Text = "Set User Position"
		Me.Button8.UseVisualStyleBackColor = True
		'
		'Label28
		'
		Me.Label28.AutoSize = True
		Me.Label28.Location = New System.Drawing.Point(19, 33)
		Me.Label28.Name = "Label28"
		Me.Label28.Size = New System.Drawing.Size(187, 20)
		Me.Label28.TabIndex = 7
		Me.Label28.Text = "New User Position Value:"
		'
		'TextBox10
		'
		Me.TextBox10.Location = New System.Drawing.Point(212, 30)
		Me.TextBox10.Name = "TextBox10"
		Me.TextBox10.Size = New System.Drawing.Size(100, 26)
		Me.TextBox10.TabIndex = 3
		Me.TextBox10.Text = "0.000m"
		'
		'Label26
		'
		Me.Label26.AutoSize = True
		Me.Label26.Location = New System.Drawing.Point(31, 310)
		Me.Label26.Name = "Label26"
		Me.Label26.Size = New System.Drawing.Size(122, 20)
		Me.Label26.TabIndex = 7
		Me.Label26.Text = "System Position"
		'
		'Label25
		'
		Me.Label25.AutoSize = True
		Me.Label25.Location = New System.Drawing.Point(35, 106)
		Me.Label25.Name = "Label25"
		Me.Label25.Size = New System.Drawing.Size(249, 20)
		Me.Label25.TabIndex = 1
		Me.Label25.Text = "Routine status info displayed here"
		'
		'Button3
		'
		Me.Button3.Location = New System.Drawing.Point(35, 35)
		Me.Button3.Name = "Button3"
		Me.Button3.Size = New System.Drawing.Size(79, 48)
		Me.Button3.TabIndex = 0
		Me.Button3.Text = "Level Routine"
		Me.Button3.UseVisualStyleBackColor = True
		'
		'Button7
		'
		Me.Button7.Location = New System.Drawing.Point(308, 36)
		Me.Button7.Name = "Button7"
		Me.Button7.Size = New System.Drawing.Size(79, 48)
		Me.Button7.TabIndex = 0
		Me.Button7.Text = "Power ON / OFF"
		Me.Button7.UseVisualStyleBackColor = True
		'
		'Button6
		'
		Me.Button6.Location = New System.Drawing.Point(155, 36)
		Me.Button6.Name = "Button6"
		Me.Button6.Size = New System.Drawing.Size(79, 48)
		Me.Button6.TabIndex = 0
		Me.Button6.Text = "Home"
		Me.Button6.UseVisualStyleBackColor = True
		'
		'TextBox7
		'
		Me.TextBox7.Location = New System.Drawing.Point(159, 307)
		Me.TextBox7.Name = "TextBox7"
		Me.TextBox7.Size = New System.Drawing.Size(100, 26)
		Me.TextBox7.TabIndex = 3
		Me.TextBox7.Text = "0.029m"
		'
		'Button12
		'
		Me.Button12.Location = New System.Drawing.Point(596, 354)
		Me.Button12.Name = "Button12"
		Me.Button12.Size = New System.Drawing.Size(169, 48)
		Me.Button12.TabIndex = 0
		Me.Button12.Text = "Jump to Position Number:"
		Me.Button12.UseVisualStyleBackColor = True
		'
		'Button11
		'
		Me.Button11.Location = New System.Drawing.Point(597, 290)
		Me.Button11.Name = "Button11"
		Me.Button11.Size = New System.Drawing.Size(169, 48)
		Me.Button11.TabIndex = 0
		Me.Button11.Text = "Automatic Step Forward"
		Me.Button11.UseVisualStyleBackColor = True
		'
		'Button10
		'
		Me.Button10.Location = New System.Drawing.Point(597, 227)
		Me.Button10.Name = "Button10"
		Me.Button10.Size = New System.Drawing.Size(84, 48)
		Me.Button10.TabIndex = 0
		Me.Button10.Text = "Step Back"
		Me.Button10.UseVisualStyleBackColor = True
		'
		'Button9
		'
		Me.Button9.Location = New System.Drawing.Point(687, 227)
		Me.Button9.Name = "Button9"
		Me.Button9.Size = New System.Drawing.Size(79, 48)
		Me.Button9.TabIndex = 0
		Me.Button9.Text = "Step Forward"
		Me.Button9.UseVisualStyleBackColor = True
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBox6)
		Me.GroupBox1.Controls.Add(Me.Button1)
		Me.GroupBox1.Controls.Add(Me.TextBox4)
		Me.GroupBox1.Controls.Add(Me.Button4)
		Me.GroupBox1.Controls.Add(Me.TextBox2)
		Me.GroupBox1.Controls.Add(Me.Button2)
		Me.GroupBox1.Controls.Add(Me.TextBox5)
		Me.GroupBox1.Controls.Add(Me.Button5)
		Me.GroupBox1.Controls.Add(Me.TextBox3)
		Me.GroupBox1.Controls.Add(Me.Label19)
		Me.GroupBox1.Controls.Add(Me.TextBox1)
		Me.GroupBox1.Controls.Add(Me.Label21)
		Me.GroupBox1.Controls.Add(Me.Label23)
		Me.GroupBox1.Controls.Add(Me.Label22)
		Me.GroupBox1.Controls.Add(Me.Label20)
		Me.GroupBox1.Location = New System.Drawing.Point(6, 653)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(515, 343)
		Me.GroupBox1.TabIndex = 4
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Manual Control"
		'
		'TextBox6
		'
		Me.TextBox6.Location = New System.Drawing.Point(391, 151)
		Me.TextBox6.Name = "TextBox6"
		Me.TextBox6.Size = New System.Drawing.Size(100, 26)
		Me.TextBox6.TabIndex = 3
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(265, 282)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(79, 48)
		Me.Button1.TabIndex = 0
		Me.Button1.Text = "Lower"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'TextBox4
		'
		Me.TextBox4.Location = New System.Drawing.Point(393, 107)
		Me.TextBox4.Name = "TextBox4"
		Me.TextBox4.Size = New System.Drawing.Size(100, 26)
		Me.TextBox4.TabIndex = 3
		'
		'Button4
		'
		Me.Button4.Location = New System.Drawing.Point(393, 282)
		Me.Button4.Name = "Button4"
		Me.Button4.Size = New System.Drawing.Size(79, 48)
		Me.Button4.TabIndex = 0
		Me.Button4.Text = "Lower"
		Me.Button4.UseVisualStyleBackColor = True
		'
		'TextBox2
		'
		Me.TextBox2.Location = New System.Drawing.Point(393, 67)
		Me.TextBox2.Name = "TextBox2"
		Me.TextBox2.Size = New System.Drawing.Size(100, 26)
		Me.TextBox2.TabIndex = 3
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(265, 228)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(79, 48)
		Me.Button2.TabIndex = 0
		Me.Button2.Text = "Raise"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'TextBox5
		'
		Me.TextBox5.Location = New System.Drawing.Point(262, 151)
		Me.TextBox5.Name = "TextBox5"
		Me.TextBox5.Size = New System.Drawing.Size(100, 26)
		Me.TextBox5.TabIndex = 3
		'
		'Button5
		'
		Me.Button5.Location = New System.Drawing.Point(393, 228)
		Me.Button5.Name = "Button5"
		Me.Button5.Size = New System.Drawing.Size(79, 48)
		Me.Button5.TabIndex = 0
		Me.Button5.Text = "Raise"
		Me.Button5.UseVisualStyleBackColor = True
		'
		'TextBox3
		'
		Me.TextBox3.Location = New System.Drawing.Point(264, 107)
		Me.TextBox3.Name = "TextBox3"
		Me.TextBox3.Size = New System.Drawing.Size(100, 26)
		Me.TextBox3.TabIndex = 3
		'
		'Label19
		'
		Me.Label19.AutoSize = True
		Me.Label19.Location = New System.Drawing.Point(111, 68)
		Me.Label19.Name = "Label19"
		Me.Label19.Size = New System.Drawing.Size(134, 20)
		Me.Label19.TabIndex = 2
		Me.Label19.Text = "Actuator Position:"
		'
		'TextBox1
		'
		Me.TextBox1.Location = New System.Drawing.Point(264, 68)
		Me.TextBox1.Name = "TextBox1"
		Me.TextBox1.Size = New System.Drawing.Size(100, 26)
		Me.TextBox1.TabIndex = 3
		'
		'Label21
		'
		Me.Label21.AutoSize = True
		Me.Label21.Location = New System.Drawing.Point(300, 25)
		Me.Label21.Name = "Label21"
		Me.Label21.Size = New System.Drawing.Size(20, 20)
		Me.Label21.TabIndex = 2
		Me.Label21.Text = "A"
		'
		'Label23
		'
		Me.Label23.AutoSize = True
		Me.Label23.Location = New System.Drawing.Point(22, 154)
		Me.Label23.Name = "Label23"
		Me.Label23.Size = New System.Drawing.Size(234, 20)
		Me.Label23.TabIndex = 2
		Me.Label23.Text = "Tension/Compression Force: kN"
		'
		'Label22
		'
		Me.Label22.AutoSize = True
		Me.Label22.Location = New System.Drawing.Point(426, 25)
		Me.Label22.Name = "Label22"
		Me.Label22.Size = New System.Drawing.Size(20, 20)
		Me.Label22.TabIndex = 2
		Me.Label22.Text = "B"
		'
		'Label20
		'
		Me.Label20.AutoSize = True
		Me.Label20.Location = New System.Drawing.Point(111, 107)
		Me.Label20.Name = "Label20"
		Me.Label20.Size = New System.Drawing.Size(128, 20)
		Me.Label20.TabIndex = 2
		Me.Label20.Text = "Actuator Torque:"
		'
		'TextBox13
		'
		Me.TextBox13.Location = New System.Drawing.Point(774, 148)
		Me.TextBox13.Name = "TextBox13"
		Me.TextBox13.Size = New System.Drawing.Size(100, 26)
		Me.TextBox13.TabIndex = 3
		Me.TextBox13.Text = "45ms"
		'
		'TextBox11
		'
		Me.TextBox11.Location = New System.Drawing.Point(880, 148)
		Me.TextBox11.Name = "TextBox11"
		Me.TextBox11.Size = New System.Drawing.Size(100, 26)
		Me.TextBox11.TabIndex = 3
		Me.TextBox11.Text = "100ms"
		'
		'DataGridView1
		'
		Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PositionNumber, Me.Position, Me.Speed, Me.Jerk, Me.Accel, Me.Decel, Me.Dwell, Me.SameDeCel})
		Me.DataGridView1.Location = New System.Drawing.Point(1031, 63)
		Me.DataGridView1.Name = "DataGridView1"
		Me.DataGridView1.RowHeadersWidth = 62
		Me.DataGridView1.RowTemplate.Height = 28
		Me.DataGridView1.Size = New System.Drawing.Size(1263, 933)
		Me.DataGridView1.TabIndex = 1
		'
		'PositionNumber
		'
		Me.PositionNumber.HeaderText = "PositionNumber"
		Me.PositionNumber.MinimumWidth = 8
		Me.PositionNumber.Name = "PositionNumber"
		Me.PositionNumber.Width = 150
		'
		'Position
		'
		Me.Position.HeaderText = "Position"
		Me.Position.MinimumWidth = 8
		Me.Position.Name = "Position"
		Me.Position.Width = 150
		'
		'Speed
		'
		Me.Speed.HeaderText = "Velocity"
		Me.Speed.MinimumWidth = 8
		Me.Speed.Name = "Speed"
		Me.Speed.Width = 150
		'
		'Jerk
		'
		Me.Jerk.HeaderText = "Jerk"
		Me.Jerk.MinimumWidth = 8
		Me.Jerk.Name = "Jerk"
		Me.Jerk.Width = 150
		'
		'Accel
		'
		Me.Accel.HeaderText = "Accel"
		Me.Accel.MinimumWidth = 8
		Me.Accel.Name = "Accel"
		Me.Accel.Width = 150
		'
		'Decel
		'
		Me.Decel.HeaderText = "Decel"
		Me.Decel.MinimumWidth = 8
		Me.Decel.Name = "Decel"
		Me.Decel.Width = 150
		'
		'Dwell
		'
		Me.Dwell.HeaderText = "Dwell Time"
		Me.Dwell.MinimumWidth = 8
		Me.Dwell.Name = "Dwell"
		Me.Dwell.Width = 150
		'
		'SameDeCel
		'
		Me.SameDeCel.HeaderText = "SameDecel"
		Me.SameDeCel.MinimumWidth = 8
		Me.SameDeCel.Name = "SameDeCel"
		Me.SameDeCel.Width = 150
		'
		'TextBox12
		'
		Me.TextBox12.Location = New System.Drawing.Point(790, 365)
		Me.TextBox12.Name = "TextBox12"
		Me.TextBox12.Size = New System.Drawing.Size(181, 26)
		Me.TextBox12.TabIndex = 3
		Me.TextBox12.Text = "Target Position number"
		'
		'TextBox8
		'
		Me.TextBox8.Location = New System.Drawing.Point(772, 102)
		Me.TextBox8.Name = "TextBox8"
		Me.TextBox8.Size = New System.Drawing.Size(100, 26)
		Me.TextBox8.TabIndex = 3
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(1872, 1042)
		Me.Controls.Add(Me.TabControl)
		Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
		Me.Name = "Form1"
		Me.Text = "TcJoy by Jensen Mechatronics"
		Me.TabControl.ResumeLayout(False)
		Me.TabPage_LiveStatus.ResumeLayout(False)
		Me.TabPage_LiveStatus.PerformLayout()
		Me.TabPage_Connection.ResumeLayout(False)
		Me.GroupBox_Controller.ResumeLayout(False)
		Me.GroupBox_Controller.PerformLayout()
		Me.GroupBox_PLC.ResumeLayout(False)
		Me.GroupBox_PLC.PerformLayout()
		Me.TabPage_Help.ResumeLayout(False)
		Me.TabPage1.ResumeLayout(False)
		Me.TabPage1.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBox3.PerformLayout()
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents TabControl As TabControl
    Friend WithEvents TabPage_LiveStatus As TabPage
    Friend WithEvents TabPage_Connection As TabPage
    Friend WithEvents TabPage_Help As TabPage
    Friend WithEvents Button_ADSConnect As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_ADSPort As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_ADSNetID As TextBox
    Friend WithEvents CheckBox_AutoConnectOnOpen As CheckBox
    Friend WithEvents TextBox_TcJoyFunctionBlockStatus As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox_ADSConnectionStatus As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_ADSConnectionStatus2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox_PLC As GroupBox
    Friend WithEvents GroupBox_Controller As GroupBox
    Friend WithEvents TextBox_ADSDataRateAchieved As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_ADSRate As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox_TcJoyPath As TextBox
    Friend WithEvents Button_ADSDisconnect As Button
    Friend WithEvents ProgressBar_ADSBad As ProgressBar
    Friend WithEvents ProgressBar_ADSGood As ProgressBar
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox_ADSWatchdog As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label_JoyActiveFromPLC As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox_ADSWatchdogDeadDuration As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label_Controller0_Connection As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox_AnalogDeadzone As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TextBox_ShoulderDeadzone As TextBox
    Friend WithEvents ProgressBar_Controller0Battery As ProgressBar
    Friend WithEvents Label18 As Label
    Friend WithEvents ProgressBar_LeftStickXMinus As ProgressBar
    Friend WithEvents ProgressBar_LeftStickXPlus As ProgressBar
    Friend WithEvents ProgressBar_RightStickXMinus As ProgressBar
    Friend WithEvents ProgressBar_RightStickXPlus As ProgressBar
    Friend WithEvents CheckBox_XButton As CheckBox
    Friend WithEvents CheckBox_BButton As CheckBox
    Friend WithEvents CheckBox_AButton As CheckBox
    Friend WithEvents CheckBox_YButton As CheckBox
    Friend WithEvents CheckBox_BackBtn As CheckBox
    Friend WithEvents CheckBox_StartBtn As CheckBox
    Friend WithEvents CheckBox_RightShoulderBtn As CheckBox
    Friend WithEvents CheckBox_LeftShoulderBtn As CheckBox
    Friend WithEvents CheckBox_DPadLeft As CheckBox
    Friend WithEvents CheckBox_DPadRight As CheckBox
    Friend WithEvents CheckBox_DPadDown As CheckBox
    Friend WithEvents CheckBox_DPadUp As CheckBox
    Friend WithEvents RichTextBox_Help As RichTextBox
    Friend WithEvents Label_RightStickXPos As Label
    Friend WithEvents Label_RightStickXNeg As Label
    Friend WithEvents Label_LeftStickXPos As Label
    Friend WithEvents Label_LeftStickXNeg As Label
    Friend WithEvents Label_RightStickYNeg As Label
    Friend WithEvents Label_RightStickYPos As Label
    Friend WithEvents Label_LeftStickYPos As Label
    Friend WithEvents Label_LeftStickYNeg As Label
    Friend WithEvents Label_LeftShoulderVal As Label
    Friend WithEvents Label_RightShoulderVal As Label
    Friend WithEvents ProgressBar_LeftStickYPlus As MyVerticalProgessBar
    Friend WithEvents ProgressBar_RightStickYPlus As MyVerticalProgessBar
    Friend WithEvents ProgressBar_LeftStickYMinus As MyVerticalProgessBarMinus
    Friend WithEvents ProgressBar_RightStickYMinus As MyVerticalProgessBarMinus
    Friend WithEvents ProgressBar_RightShoulderAnalog As MyVerticalProgessBar
    Friend WithEvents ProgressBar_LeftShoulderAnalog As MyVerticalProgessBar
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents Label24 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Button12 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents PositionNumber As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Speed As DataGridViewTextBoxColumn
    Friend WithEvents Jerk As DataGridViewTextBoxColumn
    Friend WithEvents Accel As DataGridViewTextBoxColumn
    Friend WithEvents Decel As DataGridViewTextBoxColumn
    Friend WithEvents Dwell As DataGridViewTextBoxColumn
    Friend WithEvents SameDeCel As DataGridViewCheckBoxColumn
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox8 As TextBox
End Class
