﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HMI
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
        Me.TabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.cb_SoftwareEnable = New System.Windows.Forms.CheckBox()
        Me.cbServosHalted = New System.Windows.Forms.CheckBox()
        Me.cb_GearedIn = New System.Windows.Forms.CheckBox()
        Me.cbServo2Faulted = New System.Windows.Forms.CheckBox()
        Me.cbServo2Enabled = New System.Windows.Forms.CheckBox()
        Me.CbServo1Faulted = New System.Windows.Forms.CheckBox()
        Me.cbServo1Enabled = New System.Windows.Forms.CheckBox()
        Me.btnFaultReset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnSetUserPos = New System.Windows.Forms.Button()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtNewUserPos = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.lblRoutineStatus = New System.Windows.Forms.Label()
        Me.btnLevel = New System.Windows.Forms.Button()
        Me.btnPower = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.lblSystemPos = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_JogModeToggle = New System.Windows.Forms.Button()
        Me.txtTFB = New System.Windows.Forms.TextBox()
        Me.btnLowerA = New System.Windows.Forms.Button()
        Me.txtATB = New System.Windows.Forms.TextBox()
        Me.btnLowerB = New System.Windows.Forms.Button()
        Me.txtAPB = New System.Windows.Forms.TextBox()
        Me.btnRaiseA = New System.Windows.Forms.Button()
        Me.txtTFA = New System.Windows.Forms.TextBox()
        Me.btnRaiseB = New System.Windows.Forms.Button()
        Me.txtATA = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAPA = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabPage_LiveStatus = New System.Windows.Forms.TabPage()
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
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.toolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnLoad = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnAddChart = New System.Windows.Forms.ToolStripButton()
        Me.btnAddAxis = New System.Windows.Forms.ToolStripButton()
        Me.btnAddChannel = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnStart = New System.Windows.Forms.ToolStripButton()
        Me.btnStop = New System.Windows.Forms.ToolStripButton()
        Me.btnSave = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnRun = New System.Windows.Forms.ToolStripButton()
        Me.btnPause = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnDelChart = New System.Windows.Forms.ToolStripButton()
        Me.ScopeProjectPanel1 = New TwinCAT.Measurement.Scope.Control.ScopeProjectPanel()
        Me.ProgressBar_RightShoulderAnalog = New TcJoy.MyVerticalProgessBar()
        Me.ProgressBar_LeftShoulderAnalog = New TcJoy.MyVerticalProgessBar()
        Me.ProgressBar_LeftStickYMinus = New TcJoy.MyVerticalProgessBarMinus()
        Me.ProgressBar_RightStickYMinus = New TcJoy.MyVerticalProgessBarMinus()
        Me.ProgressBar_RightStickYPlus = New TcJoy.MyVerticalProgessBar()
        Me.ProgressBar_LeftStickYPlus = New TcJoy.MyVerticalProgessBar()
        Me.cb_GeneralFault = New System.Windows.Forms.CheckBox()
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage_LiveStatus.SuspendLayout()
        Me.TabPage_Connection.SuspendLayout()
        Me.GroupBox_Controller.SuspendLayout()
        Me.GroupBox_PLC.SuspendLayout()
        Me.TabPage_Help.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.toolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage_LiveStatus)
        Me.TabControl.Controls.Add(Me.TabPage_Connection)
        Me.TabControl.Controls.Add(Me.TabPage_Help)
        Me.TabControl.Controls.Add(Me.TabPage2)
        Me.TabControl.Location = New System.Drawing.Point(3, 4)
        Me.TabControl.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1618, 830)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.cb_SoftwareEnable)
        Me.TabPage1.Controls.Add(Me.cbServosHalted)
        Me.TabPage1.Controls.Add(Me.cb_GearedIn)
        Me.TabPage1.Controls.Add(Me.cbServo2Faulted)
        Me.TabPage1.Controls.Add(Me.cbServo2Enabled)
        Me.TabPage1.Controls.Add(Me.cb_GeneralFault)
        Me.TabPage1.Controls.Add(Me.CbServo1Faulted)
        Me.TabPage1.Controls.Add(Me.cbServo1Enabled)
        Me.TabPage1.Controls.Add(Me.btnFaultReset)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1610, 801)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Hank Rig Controls"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'cb_SoftwareEnable
        '
        Me.cb_SoftwareEnable.AutoSize = True
        Me.cb_SoftwareEnable.Location = New System.Drawing.Point(387, 90)
        Me.cb_SoftwareEnable.Name = "cb_SoftwareEnable"
        Me.cb_SoftwareEnable.Size = New System.Drawing.Size(207, 21)
        Me.cb_SoftwareEnable.TabIndex = 16
        Me.cb_SoftwareEnable.Text = "Software EnableServosFinal"
        Me.cb_SoftwareEnable.UseVisualStyleBackColor = True
        '
        'cbServosHalted
        '
        Me.cbServosHalted.AutoSize = True
        Me.cbServosHalted.Location = New System.Drawing.Point(387, 63)
        Me.cbServosHalted.Name = "cbServosHalted"
        Me.cbServosHalted.Size = New System.Drawing.Size(123, 21)
        Me.cbServosHalted.TabIndex = 16
        Me.cbServosHalted.Text = "Servos_Halted"
        Me.cbServosHalted.UseVisualStyleBackColor = True
        '
        'cb_GearedIn
        '
        Me.cb_GearedIn.AutoSize = True
        Me.cb_GearedIn.Location = New System.Drawing.Point(387, 36)
        Me.cb_GearedIn.Name = "cb_GearedIn"
        Me.cb_GearedIn.Size = New System.Drawing.Size(93, 21)
        Me.cb_GearedIn.TabIndex = 16
        Me.cb_GearedIn.Text = "Geared In"
        Me.cb_GearedIn.UseVisualStyleBackColor = True
        '
        'cbServo2Faulted
        '
        Me.cbServo2Faulted.AutoSize = True
        Me.cbServo2Faulted.Location = New System.Drawing.Point(225, 64)
        Me.cbServo2Faulted.Name = "cbServo2Faulted"
        Me.cbServo2Faulted.Size = New System.Drawing.Size(126, 21)
        Me.cbServo2Faulted.TabIndex = 16
        Me.cbServo2Faulted.Text = "Servo2 Faulted"
        Me.cbServo2Faulted.UseVisualStyleBackColor = True
        '
        'cbServo2Enabled
        '
        Me.cbServo2Enabled.AutoSize = True
        Me.cbServo2Enabled.Location = New System.Drawing.Point(225, 37)
        Me.cbServo2Enabled.Name = "cbServo2Enabled"
        Me.cbServo2Enabled.Size = New System.Drawing.Size(131, 21)
        Me.cbServo2Enabled.TabIndex = 16
        Me.cbServo2Enabled.Text = "Servo2 Enabled"
        Me.cbServo2Enabled.UseVisualStyleBackColor = True
        '
        'CbServo1Faulted
        '
        Me.CbServo1Faulted.AutoSize = True
        Me.CbServo1Faulted.Location = New System.Drawing.Point(42, 64)
        Me.CbServo1Faulted.Name = "CbServo1Faulted"
        Me.CbServo1Faulted.Size = New System.Drawing.Size(130, 21)
        Me.CbServo1Faulted.TabIndex = 16
        Me.CbServo1Faulted.Text = "Servo 1 Faulted"
        Me.CbServo1Faulted.UseVisualStyleBackColor = True
        '
        'cbServo1Enabled
        '
        Me.cbServo1Enabled.AutoSize = True
        Me.cbServo1Enabled.Location = New System.Drawing.Point(42, 37)
        Me.cbServo1Enabled.Name = "cbServo1Enabled"
        Me.cbServo1Enabled.Size = New System.Drawing.Size(135, 21)
        Me.cbServo1Enabled.TabIndex = 16
        Me.cbServo1Enabled.Text = "Servo 1 Enabled"
        Me.cbServo1Enabled.UseVisualStyleBackColor = True
        '
        'btnFaultReset
        '
        Me.btnFaultReset.Location = New System.Drawing.Point(737, 60)
        Me.btnFaultReset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnFaultReset.Name = "btnFaultReset"
        Me.btnFaultReset.Size = New System.Drawing.Size(135, 38)
        Me.btnFaultReset.TabIndex = 15
        Me.btnFaultReset.Text = "Fault Reset"
        Me.btnFaultReset.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.lblRoutineStatus)
        Me.GroupBox2.Controls.Add(Me.btnLevel)
        Me.GroupBox2.Controls.Add(Me.btnPower)
        Me.GroupBox2.Controls.Add(Me.btnHome)
        Me.GroupBox2.Controls.Add(Me.lblSystemPos)
        Me.GroupBox2.Location = New System.Drawing.Point(478, 116)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(412, 274)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setup Functions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSetUserPos)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtNewUserPos)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 121)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(344, 110)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Position Offset"
        '
        'btnSetUserPos
        '
        Me.btnSetUserPos.Location = New System.Drawing.Point(32, 55)
        Me.btnSetUserPos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSetUserPos.Name = "btnSetUserPos"
        Me.btnSetUserPos.Size = New System.Drawing.Size(85, 50)
        Me.btnSetUserPos.TabIndex = 0
        Me.btnSetUserPos.Text = "Set User Position"
        Me.btnSetUserPos.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(18, 26)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(167, 17)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "New User Position Value:"
        '
        'txtNewUserPos
        '
        Me.txtNewUserPos.Location = New System.Drawing.Point(188, 23)
        Me.txtNewUserPos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNewUserPos.Name = "txtNewUserPos"
        Me.txtNewUserPos.Size = New System.Drawing.Size(89, 22)
        Me.txtNewUserPos.TabIndex = 3
        Me.txtNewUserPos.Text = "0.000m"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(28, 247)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(108, 17)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "System Position"
        '
        'lblRoutineStatus
        '
        Me.lblRoutineStatus.AutoSize = True
        Me.lblRoutineStatus.Location = New System.Drawing.Point(30, 85)
        Me.lblRoutineStatus.Name = "lblRoutineStatus"
        Me.lblRoutineStatus.Size = New System.Drawing.Size(223, 17)
        Me.lblRoutineStatus.TabIndex = 1
        Me.lblRoutineStatus.Text = "Routine status info displayed here"
        '
        'btnLevel
        '
        Me.btnLevel.Location = New System.Drawing.Point(35, 28)
        Me.btnLevel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLevel.Name = "btnLevel"
        Me.btnLevel.Size = New System.Drawing.Size(112, 38)
        Me.btnLevel.TabIndex = 0
        Me.btnLevel.Text = "Level Routine"
        Me.btnLevel.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(253, 28)
        Me.btnPower.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(135, 38)
        Me.btnPower.TabIndex = 0
        Me.btnPower.Text = "Power ON / OFF"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(162, 28)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(71, 38)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblSystemPos
        '
        Me.lblSystemPos.Location = New System.Drawing.Point(141, 242)
        Me.lblSystemPos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lblSystemPos.Name = "lblSystemPos"
        Me.lblSystemPos.Size = New System.Drawing.Size(89, 22)
        Me.lblSystemPos.TabIndex = 3
        Me.lblSystemPos.Text = "0.029m"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_JogModeToggle)
        Me.GroupBox1.Controls.Add(Me.txtTFB)
        Me.GroupBox1.Controls.Add(Me.btnLowerA)
        Me.GroupBox1.Controls.Add(Me.txtATB)
        Me.GroupBox1.Controls.Add(Me.btnLowerB)
        Me.GroupBox1.Controls.Add(Me.txtAPB)
        Me.GroupBox1.Controls.Add(Me.btnRaiseA)
        Me.GroupBox1.Controls.Add(Me.txtTFA)
        Me.GroupBox1.Controls.Add(Me.btnRaiseB)
        Me.GroupBox1.Controls.Add(Me.txtATA)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtAPA)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(457, 274)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual Control"
        '
        'btn_JogModeToggle
        '
        Me.btn_JogModeToggle.Location = New System.Drawing.Point(37, 193)
        Me.btn_JogModeToggle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_JogModeToggle.Name = "btn_JogModeToggle"
        Me.btn_JogModeToggle.Size = New System.Drawing.Size(135, 38)
        Me.btn_JogModeToggle.TabIndex = 15
        Me.btn_JogModeToggle.Text = "Jog Mode"
        Me.btn_JogModeToggle.UseVisualStyleBackColor = True
        '
        'txtTFB
        '
        Me.txtTFB.Location = New System.Drawing.Point(348, 121)
        Me.txtTFB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTFB.Name = "txtTFB"
        Me.txtTFB.Size = New System.Drawing.Size(89, 22)
        Me.txtTFB.TabIndex = 3
        '
        'btnLowerA
        '
        Me.btnLowerA.Location = New System.Drawing.Point(236, 226)
        Me.btnLowerA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLowerA.Name = "btnLowerA"
        Me.btnLowerA.Size = New System.Drawing.Size(71, 38)
        Me.btnLowerA.TabIndex = 0
        Me.btnLowerA.Text = "Lower"
        Me.btnLowerA.UseVisualStyleBackColor = True
        '
        'txtATB
        '
        Me.txtATB.Location = New System.Drawing.Point(349, 86)
        Me.txtATB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtATB.Name = "txtATB"
        Me.txtATB.Size = New System.Drawing.Size(89, 22)
        Me.txtATB.TabIndex = 3
        '
        'btnLowerB
        '
        Me.btnLowerB.Location = New System.Drawing.Point(349, 226)
        Me.btnLowerB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLowerB.Name = "btnLowerB"
        Me.btnLowerB.Size = New System.Drawing.Size(71, 38)
        Me.btnLowerB.TabIndex = 0
        Me.btnLowerB.Text = "Lower"
        Me.btnLowerB.UseVisualStyleBackColor = True
        '
        'txtAPB
        '
        Me.txtAPB.Location = New System.Drawing.Point(349, 54)
        Me.txtAPB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAPB.Name = "txtAPB"
        Me.txtAPB.Size = New System.Drawing.Size(89, 22)
        Me.txtAPB.TabIndex = 3
        '
        'btnRaiseA
        '
        Me.btnRaiseA.Location = New System.Drawing.Point(236, 182)
        Me.btnRaiseA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRaiseA.Name = "btnRaiseA"
        Me.btnRaiseA.Size = New System.Drawing.Size(71, 38)
        Me.btnRaiseA.TabIndex = 0
        Me.btnRaiseA.Text = "Raise"
        Me.btnRaiseA.UseVisualStyleBackColor = True
        '
        'txtTFA
        '
        Me.txtTFA.Location = New System.Drawing.Point(233, 121)
        Me.txtTFA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtTFA.Name = "txtTFA"
        Me.txtTFA.Size = New System.Drawing.Size(89, 22)
        Me.txtTFA.TabIndex = 3
        '
        'btnRaiseB
        '
        Me.btnRaiseB.Location = New System.Drawing.Point(349, 182)
        Me.btnRaiseB.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnRaiseB.Name = "btnRaiseB"
        Me.btnRaiseB.Size = New System.Drawing.Size(71, 38)
        Me.btnRaiseB.TabIndex = 0
        Me.btnRaiseB.Text = "Raise"
        Me.btnRaiseB.UseVisualStyleBackColor = True
        '
        'txtATA
        '
        Me.txtATA.Location = New System.Drawing.Point(235, 86)
        Me.txtATA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtATA.Name = "txtATA"
        Me.txtATA.Size = New System.Drawing.Size(89, 22)
        Me.txtATA.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(99, 54)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(119, 17)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Actuator Position:"
        '
        'txtAPA
        '
        Me.txtAPA.Location = New System.Drawing.Point(235, 54)
        Me.txtAPA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtAPA.Name = "txtAPA"
        Me.txtAPA.Size = New System.Drawing.Size(89, 22)
        Me.txtAPA.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(267, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 17)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "A"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(20, 123)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(210, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Tension/Compression Force: Kg"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(379, 20)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(17, 17)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "B"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(99, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(115, 17)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Actuator Torque:"
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
        Me.TabPage_LiveStatus.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_LiveStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_LiveStatus.Name = "TabPage_LiveStatus"
        Me.TabPage_LiveStatus.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_LiveStatus.Size = New System.Drawing.Size(1610, 801)
        Me.TabPage_LiveStatus.TabIndex = 0
        Me.TabPage_LiveStatus.Text = "Live Status"
        Me.TabPage_LiveStatus.UseVisualStyleBackColor = True
        '
        'Label_LeftShoulderVal
        '
        Me.Label_LeftShoulderVal.AutoSize = True
        Me.Label_LeftShoulderVal.Location = New System.Drawing.Point(149, 132)
        Me.Label_LeftShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftShoulderVal.Name = "Label_LeftShoulderVal"
        Me.Label_LeftShoulderVal.Size = New System.Drawing.Size(44, 17)
        Me.Label_LeftShoulderVal.TabIndex = 49
        Me.Label_LeftShoulderVal.Text = "L Val:"
        '
        'Label_RightShoulderVal
        '
        Me.Label_RightShoulderVal.AutoSize = True
        Me.Label_RightShoulderVal.Location = New System.Drawing.Point(437, 132)
        Me.Label_RightShoulderVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightShoulderVal.Name = "Label_RightShoulderVal"
        Me.Label_RightShoulderVal.Size = New System.Drawing.Size(46, 17)
        Me.Label_RightShoulderVal.TabIndex = 48
        Me.Label_RightShoulderVal.Text = "R Val:"
        '
        'Label_RightStickYNeg
        '
        Me.Label_RightStickYNeg.AutoSize = True
        Me.Label_RightStickYNeg.Location = New System.Drawing.Point(427, 518)
        Me.Label_RightStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickYNeg.Name = "Label_RightStickYNeg"
        Me.Label_RightStickYNeg.Size = New System.Drawing.Size(49, 17)
        Me.Label_RightStickYNeg.TabIndex = 43
        Me.Label_RightStickYNeg.Text = "Y Val: "
        '
        'Label_RightStickYPos
        '
        Me.Label_RightStickYPos.AutoSize = True
        Me.Label_RightStickYPos.Location = New System.Drawing.Point(425, 362)
        Me.Label_RightStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickYPos.Name = "Label_RightStickYPos"
        Me.Label_RightStickYPos.Size = New System.Drawing.Size(49, 17)
        Me.Label_RightStickYPos.TabIndex = 42
        Me.Label_RightStickYPos.Text = "Y Val: "
        '
        'Label_LeftStickYPos
        '
        Me.Label_LeftStickYPos.AutoSize = True
        Me.Label_LeftStickYPos.Location = New System.Drawing.Point(119, 222)
        Me.Label_LeftStickYPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickYPos.Name = "Label_LeftStickYPos"
        Me.Label_LeftStickYPos.Size = New System.Drawing.Size(49, 17)
        Me.Label_LeftStickYPos.TabIndex = 41
        Me.Label_LeftStickYPos.Text = "Y Val: "
        '
        'Label_LeftStickYNeg
        '
        Me.Label_LeftStickYNeg.AutoSize = True
        Me.Label_LeftStickYNeg.Location = New System.Drawing.Point(117, 372)
        Me.Label_LeftStickYNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickYNeg.Name = "Label_LeftStickYNeg"
        Me.Label_LeftStickYNeg.Size = New System.Drawing.Size(49, 17)
        Me.Label_LeftStickYNeg.TabIndex = 40
        Me.Label_LeftStickYNeg.Text = "Y Val: "
        '
        'Label_RightStickXPos
        '
        Me.Label_RightStickXPos.AutoSize = True
        Me.Label_RightStickXPos.Location = New System.Drawing.Point(473, 457)
        Me.Label_RightStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickXPos.Name = "Label_RightStickXPos"
        Me.Label_RightStickXPos.Size = New System.Drawing.Size(49, 17)
        Me.Label_RightStickXPos.TabIndex = 39
        Me.Label_RightStickXPos.Text = "X Val: "
        '
        'Label_RightStickXNeg
        '
        Me.Label_RightStickXNeg.AutoSize = True
        Me.Label_RightStickXNeg.Location = New System.Drawing.Point(376, 457)
        Me.Label_RightStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RightStickXNeg.Name = "Label_RightStickXNeg"
        Me.Label_RightStickXNeg.Size = New System.Drawing.Size(49, 17)
        Me.Label_RightStickXNeg.TabIndex = 38
        Me.Label_RightStickXNeg.Text = "X Val: "
        '
        'Label_LeftStickXPos
        '
        Me.Label_LeftStickXPos.AutoSize = True
        Me.Label_LeftStickXPos.Location = New System.Drawing.Point(164, 315)
        Me.Label_LeftStickXPos.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickXPos.Name = "Label_LeftStickXPos"
        Me.Label_LeftStickXPos.Size = New System.Drawing.Size(49, 17)
        Me.Label_LeftStickXPos.TabIndex = 37
        Me.Label_LeftStickXPos.Text = "X Val: "
        '
        'Label_LeftStickXNeg
        '
        Me.Label_LeftStickXNeg.AutoSize = True
        Me.Label_LeftStickXNeg.Location = New System.Drawing.Point(67, 315)
        Me.Label_LeftStickXNeg.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_LeftStickXNeg.Name = "Label_LeftStickXNeg"
        Me.Label_LeftStickXNeg.Size = New System.Drawing.Size(49, 17)
        Me.Label_LeftStickXNeg.TabIndex = 36
        Me.Label_LeftStickXNeg.Text = "X Val: "
        '
        'CheckBox_RightShoulderBtn
        '
        Me.CheckBox_RightShoulderBtn.AutoSize = True
        Me.CheckBox_RightShoulderBtn.Location = New System.Drawing.Point(427, 192)
        Me.CheckBox_RightShoulderBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_RightShoulderBtn.Name = "CheckBox_RightShoulderBtn"
        Me.CheckBox_RightShoulderBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_RightShoulderBtn.Size = New System.Drawing.Size(149, 21)
        Me.CheckBox_RightShoulderBtn.TabIndex = 33
        Me.CheckBox_RightShoulderBtn.Text = "Right Shoulder Btn"
        Me.CheckBox_RightShoulderBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_LeftShoulderBtn
        '
        Me.CheckBox_LeftShoulderBtn.AutoSize = True
        Me.CheckBox_LeftShoulderBtn.Location = New System.Drawing.Point(71, 192)
        Me.CheckBox_LeftShoulderBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_LeftShoulderBtn.Name = "CheckBox_LeftShoulderBtn"
        Me.CheckBox_LeftShoulderBtn.Size = New System.Drawing.Size(136, 21)
        Me.CheckBox_LeftShoulderBtn.TabIndex = 32
        Me.CheckBox_LeftShoulderBtn.Text = "LeftShoulder Btn"
        Me.CheckBox_LeftShoulderBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadLeft
        '
        Me.CheckBox_DPadLeft.AutoSize = True
        Me.CheckBox_DPadLeft.Location = New System.Drawing.Point(107, 439)
        Me.CheckBox_DPadLeft.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_DPadLeft.Name = "CheckBox_DPadLeft"
        Me.CheckBox_DPadLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_DPadLeft.Size = New System.Drawing.Size(54, 21)
        Me.CheckBox_DPadLeft.TabIndex = 31
        Me.CheckBox_DPadLeft.Text = "Left"
        Me.CheckBox_DPadLeft.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadRight
        '
        Me.CheckBox_DPadRight.AutoSize = True
        Me.CheckBox_DPadRight.Location = New System.Drawing.Point(215, 439)
        Me.CheckBox_DPadRight.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_DPadRight.Name = "CheckBox_DPadRight"
        Me.CheckBox_DPadRight.Size = New System.Drawing.Size(63, 21)
        Me.CheckBox_DPadRight.TabIndex = 30
        Me.CheckBox_DPadRight.Text = "Right"
        Me.CheckBox_DPadRight.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadDown
        '
        Me.CheckBox_DPadDown.AutoSize = True
        Me.CheckBox_DPadDown.Location = New System.Drawing.Point(180, 473)
        Me.CheckBox_DPadDown.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_DPadDown.Name = "CheckBox_DPadDown"
        Me.CheckBox_DPadDown.Size = New System.Drawing.Size(65, 21)
        Me.CheckBox_DPadDown.TabIndex = 29
        Me.CheckBox_DPadDown.Text = "Down"
        Me.CheckBox_DPadDown.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadUp
        '
        Me.CheckBox_DPadUp.AutoSize = True
        Me.CheckBox_DPadUp.Location = New System.Drawing.Point(147, 410)
        Me.CheckBox_DPadUp.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_DPadUp.Name = "CheckBox_DPadUp"
        Me.CheckBox_DPadUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_DPadUp.Size = New System.Drawing.Size(48, 21)
        Me.CheckBox_DPadUp.TabIndex = 28
        Me.CheckBox_DPadUp.Text = "Up"
        Me.CheckBox_DPadUp.UseVisualStyleBackColor = True
        '
        'CheckBox_BackBtn
        '
        Me.CheckBox_BackBtn.AutoSize = True
        Me.CheckBox_BackBtn.Location = New System.Drawing.Point(247, 299)
        Me.CheckBox_BackBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_BackBtn.Name = "CheckBox_BackBtn"
        Me.CheckBox_BackBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_BackBtn.Size = New System.Drawing.Size(61, 21)
        Me.CheckBox_BackBtn.TabIndex = 27
        Me.CheckBox_BackBtn.Text = "Back"
        Me.CheckBox_BackBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_StartBtn
        '
        Me.CheckBox_StartBtn.AutoSize = True
        Me.CheckBox_StartBtn.Location = New System.Drawing.Point(368, 299)
        Me.CheckBox_StartBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_StartBtn.Name = "CheckBox_StartBtn"
        Me.CheckBox_StartBtn.Size = New System.Drawing.Size(60, 21)
        Me.CheckBox_StartBtn.TabIndex = 26
        Me.CheckBox_StartBtn.Text = "Start"
        Me.CheckBox_StartBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_XButton
        '
        Me.CheckBox_XButton.AutoSize = True
        Me.CheckBox_XButton.Location = New System.Drawing.Point(461, 299)
        Me.CheckBox_XButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_XButton.Name = "CheckBox_XButton"
        Me.CheckBox_XButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_XButton.Size = New System.Drawing.Size(39, 21)
        Me.CheckBox_XButton.TabIndex = 25
        Me.CheckBox_XButton.Text = "X"
        Me.CheckBox_XButton.UseVisualStyleBackColor = True
        '
        'CheckBox_BButton
        '
        Me.CheckBox_BButton.AutoSize = True
        Me.CheckBox_BButton.Location = New System.Drawing.Point(555, 299)
        Me.CheckBox_BButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_BButton.Name = "CheckBox_BButton"
        Me.CheckBox_BButton.Size = New System.Drawing.Size(39, 21)
        Me.CheckBox_BButton.TabIndex = 24
        Me.CheckBox_BButton.Text = "B"
        Me.CheckBox_BButton.UseVisualStyleBackColor = True
        '
        'CheckBox_AButton
        '
        Me.CheckBox_AButton.AutoSize = True
        Me.CheckBox_AButton.Location = New System.Drawing.Point(520, 330)
        Me.CheckBox_AButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_AButton.Name = "CheckBox_AButton"
        Me.CheckBox_AButton.Size = New System.Drawing.Size(39, 21)
        Me.CheckBox_AButton.TabIndex = 23
        Me.CheckBox_AButton.Text = "A"
        Me.CheckBox_AButton.UseVisualStyleBackColor = True
        '
        'CheckBox_YButton
        '
        Me.CheckBox_YButton.AutoSize = True
        Me.CheckBox_YButton.Location = New System.Drawing.Point(496, 267)
        Me.CheckBox_YButton.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_YButton.Name = "CheckBox_YButton"
        Me.CheckBox_YButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_YButton.Size = New System.Drawing.Size(39, 21)
        Me.CheckBox_YButton.TabIndex = 22
        Me.CheckBox_YButton.Text = "Y"
        Me.CheckBox_YButton.UseVisualStyleBackColor = True
        '
        'ProgressBar_RightStickXMinus
        '
        Me.ProgressBar_RightStickXMinus.Location = New System.Drawing.Point(371, 441)
        Me.ProgressBar_RightStickXMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXMinus.Maximum = 32768
        Me.ProgressBar_RightStickXMinus.Name = "ProgressBar_RightStickXMinus"
        Me.ProgressBar_RightStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_RightStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_RightStickXMinus.Size = New System.Drawing.Size(61, 12)
        Me.ProgressBar_RightStickXMinus.TabIndex = 21
        '
        'ProgressBar_RightStickXPlus
        '
        Me.ProgressBar_RightStickXPlus.Location = New System.Drawing.Point(469, 441)
        Me.ProgressBar_RightStickXPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXPlus.Maximum = 32768
        Me.ProgressBar_RightStickXPlus.Name = "ProgressBar_RightStickXPlus"
        Me.ProgressBar_RightStickXPlus.Size = New System.Drawing.Size(61, 12)
        Me.ProgressBar_RightStickXPlus.TabIndex = 20
        '
        'ProgressBar_LeftStickXMinus
        '
        Me.ProgressBar_LeftStickXMinus.Location = New System.Drawing.Point(62, 299)
        Me.ProgressBar_LeftStickXMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXMinus.Maximum = 32768
        Me.ProgressBar_LeftStickXMinus.Name = "ProgressBar_LeftStickXMinus"
        Me.ProgressBar_LeftStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_LeftStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_LeftStickXMinus.Size = New System.Drawing.Size(61, 12)
        Me.ProgressBar_LeftStickXMinus.TabIndex = 19
        '
        'ProgressBar_LeftStickXPlus
        '
        Me.ProgressBar_LeftStickXPlus.Location = New System.Drawing.Point(158, 299)
        Me.ProgressBar_LeftStickXPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXPlus.Maximum = 32768
        Me.ProgressBar_LeftStickXPlus.Name = "ProgressBar_LeftStickXPlus"
        Me.ProgressBar_LeftStickXPlus.Size = New System.Drawing.Size(61, 12)
        Me.ProgressBar_LeftStickXPlus.TabIndex = 18
        '
        'ProgressBar_Controller0Battery
        '
        Me.ProgressBar_Controller0Battery.Location = New System.Drawing.Point(469, 34)
        Me.ProgressBar_Controller0Battery.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_Controller0Battery.MarqueeAnimationSpeed = 1
        Me.ProgressBar_Controller0Battery.Name = "ProgressBar_Controller0Battery"
        Me.ProgressBar_Controller0Battery.Size = New System.Drawing.Size(187, 12)
        Me.ProgressBar_Controller0Battery.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(405, 30)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 17)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Battery:"
        '
        'Label_Controller0_Connection
        '
        Me.Label_Controller0_Connection.BackColor = System.Drawing.Color.Transparent
        Me.Label_Controller0_Connection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Controller0_Connection.Location = New System.Drawing.Point(409, 7)
        Me.Label_Controller0_Connection.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Controller0_Connection.Name = "Label_Controller0_Connection"
        Me.Label_Controller0_Connection.Size = New System.Drawing.Size(247, 23)
        Me.Label_Controller0_Connection.TabIndex = 15
        Me.Label_Controller0_Connection.Text = "Controller 0 Connection"
        Me.Label_Controller0_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_JoyActiveFromPLC
        '
        Me.Label_JoyActiveFromPLC.BackColor = System.Drawing.Color.Transparent
        Me.Label_JoyActiveFromPLC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_JoyActiveFromPLC.Location = New System.Drawing.Point(94, 713)
        Me.Label_JoyActiveFromPLC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_JoyActiveFromPLC.Name = "Label_JoyActiveFromPLC"
        Me.Label_JoyActiveFromPLC.Size = New System.Drawing.Size(157, 28)
        Me.Label_JoyActiveFromPLC.TabIndex = 14
        Me.Label_JoyActiveFromPLC.Text = "Latency Status"
        Me.Label_JoyActiveFromPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar_ADSBad
        '
        Me.ProgressBar_ADSBad.Location = New System.Drawing.Point(409, 713)
        Me.ProgressBar_ADSBad.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_ADSBad.MarqueeAnimationSpeed = 0
        Me.ProgressBar_ADSBad.Name = "ProgressBar_ADSBad"
        Me.ProgressBar_ADSBad.Size = New System.Drawing.Size(140, 28)
        Me.ProgressBar_ADSBad.TabIndex = 13
        '
        'ProgressBar_ADSGood
        '
        Me.ProgressBar_ADSGood.Location = New System.Drawing.Point(269, 713)
        Me.ProgressBar_ADSGood.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_ADSGood.MarqueeAnimationSpeed = 0
        Me.ProgressBar_ADSGood.Name = "ProgressBar_ADSGood"
        Me.ProgressBar_ADSGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_ADSGood.RightToLeftLayout = True
        Me.ProgressBar_ADSGood.Size = New System.Drawing.Size(140, 28)
        Me.ProgressBar_ADSGood.TabIndex = 12
        '
        'TextBox_ADSDataRateAchieved
        '
        Me.TextBox_ADSDataRateAchieved.Enabled = False
        Me.TextBox_ADSDataRateAchieved.Location = New System.Drawing.Point(269, 681)
        Me.TextBox_ADSDataRateAchieved.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSDataRateAchieved.Name = "TextBox_ADSDataRateAchieved"
        Me.TextBox_ADSDataRateAchieved.Size = New System.Drawing.Size(280, 22)
        Me.TextBox_ADSDataRateAchieved.TabIndex = 11
        Me.TextBox_ADSDataRateAchieved.TabStop = False
        Me.TextBox_ADSDataRateAchieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 684)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(170, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ADS Data Rate Achieved:"
        '
        'TextBox_ADSConnectionStatus2
        '
        Me.TextBox_ADSConnectionStatus2.Enabled = False
        Me.TextBox_ADSConnectionStatus2.Location = New System.Drawing.Point(269, 746)
        Me.TextBox_ADSConnectionStatus2.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSConnectionStatus2.Name = "TextBox_ADSConnectionStatus2"
        Me.TextBox_ADSConnectionStatus2.Size = New System.Drawing.Size(280, 22)
        Me.TextBox_ADSConnectionStatus2.TabIndex = 9
        Me.TextBox_ADSConnectionStatus2.TabStop = False
        Me.TextBox_ADSConnectionStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 750)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ADS Connection Status: "
        '
        'TabPage_Connection
        '
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Controller)
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_PLC)
        Me.TabPage_Connection.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Connection.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_Connection.Name = "TabPage_Connection"
        Me.TabPage_Connection.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_Connection.Size = New System.Drawing.Size(1610, 801)
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
        Me.GroupBox_Controller.Location = New System.Drawing.Point(8, 374)
        Me.GroupBox_Controller.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Controller.Name = "GroupBox_Controller"
        Me.GroupBox_Controller.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_Controller.Size = New System.Drawing.Size(658, 414)
        Me.GroupBox_Controller.TabIndex = 11
        Me.GroupBox_Controller.TabStop = False
        Me.GroupBox_Controller.Text = "Game Controller"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(302, 96)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(117, 17)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "counts (255 max)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(35, 96)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(188, 17)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Analog Shoulder Dead Zone"
        '
        'TextBox_ShoulderDeadzone
        '
        Me.TextBox_ShoulderDeadzone.Location = New System.Drawing.Point(231, 91)
        Me.TextBox_ShoulderDeadzone.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ShoulderDeadzone.Name = "TextBox_ShoulderDeadzone"
        Me.TextBox_ShoulderDeadzone.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ShoulderDeadzone.TabIndex = 7
        Me.TextBox_ShoulderDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(302, 64)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(133, 17)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "counts (32767 max)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(35, 64)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(161, 17)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Analog Stick Dead Zone"
        '
        'TextBox_AnalogDeadzone
        '
        Me.TextBox_AnalogDeadzone.Location = New System.Drawing.Point(231, 59)
        Me.TextBox_AnalogDeadzone.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_AnalogDeadzone.Name = "TextBox_AnalogDeadzone"
        Me.TextBox_AnalogDeadzone.Size = New System.Drawing.Size(63, 22)
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
        Me.GroupBox_PLC.Location = New System.Drawing.Point(8, 7)
        Me.GroupBox_PLC.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox_PLC.Name = "GroupBox_PLC"
        Me.GroupBox_PLC.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox_PLC.Size = New System.Drawing.Size(658, 359)
        Me.GroupBox_PLC.TabIndex = 10
        Me.GroupBox_PLC.TabStop = False
        Me.GroupBox_PLC.Text = "PLC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(265, 158)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(26, 17)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ms"
        '
        'TextBox_ADSWatchdogDeadDuration
        '
        Me.TextBox_ADSWatchdogDeadDuration.Location = New System.Drawing.Point(195, 154)
        Me.TextBox_ADSWatchdogDeadDuration.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSWatchdogDeadDuration.Name = "TextBox_ADSWatchdogDeadDuration"
        Me.TextBox_ADSWatchdogDeadDuration.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSWatchdogDeadDuration.TabIndex = 4
        Me.TextBox_ADSWatchdogDeadDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(29, 158)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(163, 17)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ADS WD Dead Duration:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(265, 126)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ms"
        '
        'TextBox_ADSWatchdog
        '
        Me.TextBox_ADSWatchdog.Location = New System.Drawing.Point(195, 123)
        Me.TextBox_ADSWatchdog.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSWatchdog.Name = "TextBox_ADSWatchdog"
        Me.TextBox_ADSWatchdog.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSWatchdog.TabIndex = 3
        Me.TextBox_ADSWatchdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 126)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 17)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ADS Watchdog:"
        '
        'Button_ADSDisconnect
        '
        Me.Button_ADSDisconnect.Location = New System.Drawing.Point(439, 90)
        Me.Button_ADSDisconnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ADSDisconnect.Name = "Button_ADSDisconnect"
        Me.Button_ADSDisconnect.Size = New System.Drawing.Size(184, 28)
        Me.Button_ADSDisconnect.TabIndex = 10
        Me.Button_ADSDisconnect.Text = "Disconnect"
        Me.Button_ADSDisconnect.UseVisualStyleBackColor = True
        '
        'TextBox_TcJoyPath
        '
        Me.TextBox_TcJoyPath.Location = New System.Drawing.Point(195, 185)
        Me.TextBox_TcJoyPath.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_TcJoyPath.Name = "TextBox_TcJoyPath"
        Me.TextBox_TcJoyPath.Size = New System.Drawing.Size(448, 22)
        Me.TextBox_TcJoyPath.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 188)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(132, 17)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "FB_TcJoy Instance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(265, 98)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ms"
        '
        'TextBox_ADSRate
        '
        Me.TextBox_ADSRate.Location = New System.Drawing.Point(195, 92)
        Me.TextBox_ADSRate.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSRate.Name = "TextBox_ADSRate"
        Me.TextBox_ADSRate.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSRate.TabIndex = 2
        Me.TextBox_ADSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 96)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ADS Rate:"
        '
        'TextBox_ADSNetID
        '
        Me.TextBox_ADSNetID.Location = New System.Drawing.Point(195, 26)
        Me.TextBox_ADSNetID.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSNetID.Name = "TextBox_ADSNetID"
        Me.TextBox_ADSNetID.Size = New System.Drawing.Size(184, 22)
        Me.TextBox_ADSNetID.TabIndex = 0
        Me.TextBox_ADSNetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_TcJoyFunctionBlockStatus
        '
        Me.TextBox_TcJoyFunctionBlockStatus.Enabled = False
        Me.TextBox_TcJoyFunctionBlockStatus.Location = New System.Drawing.Point(258, 327)
        Me.TextBox_TcJoyFunctionBlockStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_TcJoyFunctionBlockStatus.Name = "TextBox_TcJoyFunctionBlockStatus"
        Me.TextBox_TcJoyFunctionBlockStatus.Size = New System.Drawing.Size(280, 22)
        Me.TextBox_TcJoyFunctionBlockStatus.TabIndex = 9
        Me.TextBox_TcJoyFunctionBlockStatus.TabStop = False
        Me.TextBox_TcJoyFunctionBlockStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 27)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADS NetID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(83, 331)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(146, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TcJoy Function Block:"
        '
        'TextBox_ADSPort
        '
        Me.TextBox_ADSPort.Location = New System.Drawing.Point(195, 60)
        Me.TextBox_ADSPort.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSPort.Name = "TextBox_ADSPort"
        Me.TextBox_ADSPort.Size = New System.Drawing.Size(63, 22)
        Me.TextBox_ADSPort.TabIndex = 1
        Me.TextBox_ADSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_ADSConnectionStatus
        '
        Me.TextBox_ADSConnectionStatus.Enabled = False
        Me.TextBox_ADSConnectionStatus.Location = New System.Drawing.Point(258, 297)
        Me.TextBox_ADSConnectionStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox_ADSConnectionStatus.Name = "TextBox_ADSConnectionStatus"
        Me.TextBox_ADSConnectionStatus.Size = New System.Drawing.Size(280, 22)
        Me.TextBox_ADSConnectionStatus.TabIndex = 7
        Me.TextBox_ADSConnectionStatus.TabStop = False
        Me.TextBox_ADSConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 62)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ADS Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(83, 300)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADS Connection Status: "
        '
        'Button_ADSConnect
        '
        Me.Button_ADSConnect.Location = New System.Drawing.Point(439, 54)
        Me.Button_ADSConnect.Margin = New System.Windows.Forms.Padding(4)
        Me.Button_ADSConnect.Name = "Button_ADSConnect"
        Me.Button_ADSConnect.Size = New System.Drawing.Size(184, 28)
        Me.Button_ADSConnect.TabIndex = 9
        Me.Button_ADSConnect.Text = "Connect"
        Me.Button_ADSConnect.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoConnectOnOpen
        '
        Me.CheckBox_AutoConnectOnOpen.AutoSize = True
        Me.CheckBox_AutoConnectOnOpen.Location = New System.Drawing.Point(439, 26)
        Me.CheckBox_AutoConnectOnOpen.Margin = New System.Windows.Forms.Padding(4)
        Me.CheckBox_AutoConnectOnOpen.Name = "CheckBox_AutoConnectOnOpen"
        Me.CheckBox_AutoConnectOnOpen.Size = New System.Drawing.Size(172, 21)
        Me.CheckBox_AutoConnectOnOpen.TabIndex = 8
        Me.CheckBox_AutoConnectOnOpen.Text = "Auto Connect On Start"
        Me.CheckBox_AutoConnectOnOpen.UseVisualStyleBackColor = True
        '
        'TabPage_Help
        '
        Me.TabPage_Help.Controls.Add(Me.RichTextBox_Help)
        Me.TabPage_Help.Location = New System.Drawing.Point(4, 25)
        Me.TabPage_Help.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage_Help.Name = "TabPage_Help"
        Me.TabPage_Help.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage_Help.Size = New System.Drawing.Size(1610, 801)
        Me.TabPage_Help.TabIndex = 2
        Me.TabPage_Help.Text = "Help"
        Me.TabPage_Help.UseVisualStyleBackColor = True
        '
        'RichTextBox_Help
        '
        Me.RichTextBox_Help.Location = New System.Drawing.Point(8, 7)
        Me.RichTextBox_Help.Margin = New System.Windows.Forms.Padding(4)
        Me.RichTextBox_Help.Name = "RichTextBox_Help"
        Me.RichTextBox_Help.Size = New System.Drawing.Size(656, 782)
        Me.RichTextBox_Help.TabIndex = 0
        Me.RichTextBox_Help.Text = "Written By Adrian Neill / Mechatronics Vehicle Systems lab. Contact Adrian.Neill@" &
    "uwaterloo.ca"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.toolStrip1)
        Me.TabPage2.Controls.Add(Me.ScopeProjectPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1610, 801)
        Me.TabPage2.TabIndex = 5
        Me.TabPage2.Text = "TcScope"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'toolStrip1
        '
        Me.toolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.toolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.toolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnLoad, Me.toolStripSeparator1, Me.btnAddChart, Me.btnAddAxis, Me.btnAddChannel, Me.toolStripSeparator2, Me.btnStart, Me.btnStop, Me.btnSave, Me.toolStripSeparator3, Me.btnRun, Me.btnPause, Me.toolStripSeparator4, Me.btnDelChart})
        Me.toolStrip1.Location = New System.Drawing.Point(4, 4)
        Me.toolStrip1.Name = "toolStrip1"
        Me.toolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.toolStrip1.Size = New System.Drawing.Size(1602, 27)
        Me.toolStrip1.TabIndex = 1
        Me.toolStrip1.Text = "toolStrip1"
        '
        'btnLoad
        '
        Me.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(46, 24)
        Me.btnLoad.Text = "Load"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'btnAddChart
        '
        Me.btnAddChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddChart.Name = "btnAddChart"
        Me.btnAddChart.Size = New System.Drawing.Size(80, 24)
        Me.btnAddChart.Text = "Add Chart"
        '
        'btnAddAxis
        '
        Me.btnAddAxis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddAxis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddAxis.Name = "btnAddAxis"
        Me.btnAddAxis.Size = New System.Drawing.Size(72, 24)
        Me.btnAddAxis.Text = "Add Axis"
        '
        'btnAddChannel
        '
        Me.btnAddChannel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnAddChannel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddChannel.Name = "btnAddChannel"
        Me.btnAddChannel.Size = New System.Drawing.Size(98, 24)
        Me.btnAddChannel.Text = "Add Channel"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'btnStart
        '
        Me.btnStart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnStart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(44, 24)
        Me.btnStart.Text = "Start"
        '
        'btnStop
        '
        Me.btnStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnStop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(44, 24)
        Me.btnStop.Text = "Stop"
        '
        'btnSave
        '
        Me.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(44, 24)
        Me.btnSave.Text = "Save"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'btnRun
        '
        Me.btnRun.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnRun.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnRun.Name = "btnRun"
        Me.btnRun.Size = New System.Drawing.Size(38, 24)
        Me.btnRun.Text = "Run"
        '
        'btnPause
        '
        Me.btnPause.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnPause.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(50, 24)
        Me.btnPause.Text = "Pause"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'btnDelChart
        '
        Me.btnDelChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnDelChart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnDelChart.Name = "btnDelChart"
        Me.btnDelChart.Size = New System.Drawing.Size(96, 24)
        Me.btnDelChart.Text = "Delete Chart"
        '
        'ScopeProjectPanel1
        '
        Me.ScopeProjectPanel1.AllowDrop = True
        Me.ScopeProjectPanel1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ScopeProjectPanel1.ChartBackColor = System.Drawing.SystemColors.Control
        Me.ScopeProjectPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ScopeProjectPanel1.GraphicLibrary = TwinCAT.Scope2.Communications.GraphicLibrary.GDI_Plus
        Me.ScopeProjectPanel1.GridSplitColor = System.Drawing.Color.DarkSlateGray
        Me.ScopeProjectPanel1.HotColor = System.Drawing.SystemColors.MenuHighlight
        Me.ScopeProjectPanel1.Location = New System.Drawing.Point(4, 4)
        Me.ScopeProjectPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ScopeProjectPanel1.Name = "ScopeProjectPanel1"
        Me.ScopeProjectPanel1.NormalColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.ScopeProjectPanel1.ScopeProject = Nothing
        Me.ScopeProjectPanel1.SelectedColor = System.Drawing.SystemColors.Highlight
        Me.ScopeProjectPanel1.Size = New System.Drawing.Size(1602, 793)
        Me.ScopeProjectPanel1.TabIndex = 0
        Me.ScopeProjectPanel1.TextColor = System.Drawing.Color.Black
        '
        'ProgressBar_RightShoulderAnalog
        '
        Me.ProgressBar_RightShoulderAnalog.Location = New System.Drawing.Point(484, 108)
        Me.ProgressBar_RightShoulderAnalog.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightShoulderAnalog.Maximum = 255
        Me.ProgressBar_RightShoulderAnalog.Name = "ProgressBar_RightShoulderAnalog"
        Me.ProgressBar_RightShoulderAnalog.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_RightShoulderAnalog.TabIndex = 58
        Me.ProgressBar_RightShoulderAnalog.Value = 255
        '
        'ProgressBar_LeftShoulderAnalog
        '
        Me.ProgressBar_LeftShoulderAnalog.Location = New System.Drawing.Point(135, 108)
        Me.ProgressBar_LeftShoulderAnalog.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftShoulderAnalog.Maximum = 255
        Me.ProgressBar_LeftShoulderAnalog.Name = "ProgressBar_LeftShoulderAnalog"
        Me.ProgressBar_LeftShoulderAnalog.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_LeftShoulderAnalog.TabIndex = 57
        Me.ProgressBar_LeftShoulderAnalog.Value = 255
        '
        'ProgressBar_LeftStickYMinus
        '
        Me.ProgressBar_LeftStickYMinus.Location = New System.Drawing.Point(136, 313)
        Me.ProgressBar_LeftStickYMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickYMinus.Maximum = 32768
        Me.ProgressBar_LeftStickYMinus.Name = "ProgressBar_LeftStickYMinus"
        Me.ProgressBar_LeftStickYMinus.Size = New System.Drawing.Size(12, 55)
        Me.ProgressBar_LeftStickYMinus.TabIndex = 56
        '
        'ProgressBar_RightStickYMinus
        '
        Me.ProgressBar_RightStickYMinus.Location = New System.Drawing.Point(443, 458)
        Me.ProgressBar_RightStickYMinus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickYMinus.Maximum = 32768
        Me.ProgressBar_RightStickYMinus.Name = "ProgressBar_RightStickYMinus"
        Me.ProgressBar_RightStickYMinus.Size = New System.Drawing.Size(12, 55)
        Me.ProgressBar_RightStickYMinus.TabIndex = 55
        '
        'ProgressBar_RightStickYPlus
        '
        Me.ProgressBar_RightStickYPlus.Location = New System.Drawing.Point(443, 382)
        Me.ProgressBar_RightStickYPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_RightStickYPlus.Maximum = 32768
        Me.ProgressBar_RightStickYPlus.Name = "ProgressBar_RightStickYPlus"
        Me.ProgressBar_RightStickYPlus.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_RightStickYPlus.TabIndex = 54
        Me.ProgressBar_RightStickYPlus.Value = 32768
        '
        'ProgressBar_LeftStickYPlus
        '
        Me.ProgressBar_LeftStickYPlus.Location = New System.Drawing.Point(136, 242)
        Me.ProgressBar_LeftStickYPlus.Margin = New System.Windows.Forms.Padding(4)
        Me.ProgressBar_LeftStickYPlus.Maximum = 32768
        Me.ProgressBar_LeftStickYPlus.Name = "ProgressBar_LeftStickYPlus"
        Me.ProgressBar_LeftStickYPlus.Size = New System.Drawing.Size(13, 55)
        Me.ProgressBar_LeftStickYPlus.TabIndex = 51
        Me.ProgressBar_LeftStickYPlus.Value = 32768
        '
        'cb_GeneralFault
        '
        Me.cb_GeneralFault.AutoSize = True
        Me.cb_GeneralFault.Location = New System.Drawing.Point(742, 16)
        Me.cb_GeneralFault.Name = "cb_GeneralFault"
        Me.cb_GeneralFault.Size = New System.Drawing.Size(116, 21)
        Me.cb_GeneralFault.TabIndex = 16
        Me.cb_GeneralFault.Text = "General Fault"
        Me.cb_GeneralFault.UseVisualStyleBackColor = True
        '
        'HMI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1225, 834)
        Me.Controls.Add(Me.TabControl)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "HMI"
        Me.Text = "TcJoy by Jensen Mechatronics"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage_LiveStatus.ResumeLayout(False)
        Me.TabPage_LiveStatus.PerformLayout()
        Me.TabPage_Connection.ResumeLayout(False)
        Me.GroupBox_Controller.ResumeLayout(False)
        Me.GroupBox_Controller.PerformLayout()
        Me.GroupBox_PLC.ResumeLayout(False)
        Me.GroupBox_PLC.PerformLayout()
        Me.TabPage_Help.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.toolStrip1.ResumeLayout(False)
        Me.toolStrip1.PerformLayout()
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
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnSetUserPos As Button
    Friend WithEvents Label28 As Label
    Friend WithEvents txtNewUserPos As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents lblRoutineStatus As Label
    Friend WithEvents btnLevel As Button
    Friend WithEvents btnPower As Button
    Friend WithEvents btnHome As Button
    Friend WithEvents lblSystemPos As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtTFB As TextBox
    Friend WithEvents btnLowerA As Button
    Friend WithEvents txtATB As TextBox
    Friend WithEvents btnLowerB As Button
    Friend WithEvents txtAPB As TextBox
    Friend WithEvents btnRaiseA As Button
    Friend WithEvents txtTFA As TextBox
    Friend WithEvents btnRaiseB As Button
    Friend WithEvents txtATA As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtAPA As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TabPage2 As TabPage
    Private WithEvents toolStrip1 As ToolStrip
    Private WithEvents btnLoad As ToolStripButton
    Private WithEvents toolStripSeparator1 As ToolStripSeparator
    Private WithEvents btnAddChart As ToolStripButton
    Private WithEvents btnAddAxis As ToolStripButton
    Private WithEvents btnAddChannel As ToolStripButton
    Private WithEvents toolStripSeparator2 As ToolStripSeparator
    Private WithEvents btnStart As ToolStripButton
    Private WithEvents btnStop As ToolStripButton
    Private WithEvents btnSave As ToolStripButton
    Private WithEvents toolStripSeparator3 As ToolStripSeparator
    Private WithEvents btnRun As ToolStripButton
    Private WithEvents btnPause As ToolStripButton
    Private WithEvents toolStripSeparator4 As ToolStripSeparator
    Private WithEvents btnDelChart As ToolStripButton
    Friend WithEvents ScopeProjectPanel1 As TwinCAT.Measurement.Scope.Control.ScopeProjectPanel
    Friend WithEvents btnFaultReset As Button
    Friend WithEvents btn_JogModeToggle As Button
    Friend WithEvents cb_SoftwareEnable As CheckBox
    Friend WithEvents cbServosHalted As CheckBox
    Friend WithEvents cb_GearedIn As CheckBox
    Friend WithEvents cbServo2Faulted As CheckBox
    Friend WithEvents cbServo2Enabled As CheckBox
    Friend WithEvents CbServo1Faulted As CheckBox
    Friend WithEvents cbServo1Enabled As CheckBox
    Friend WithEvents cb_GeneralFault As CheckBox
End Class
