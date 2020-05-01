<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblAutoSeqPause = New System.Windows.Forms.Label()
        Me.lblManStepMode = New System.Windows.Forms.Label()
        Me.lblAutoSeq = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtUserPos = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
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
        Me.btnJumpToPos = New System.Windows.Forms.Button()
        Me.btnAutoStep = New System.Windows.Forms.Button()
        Me.btnStep = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
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
        Me.txtTime = New System.Windows.Forms.TextBox()
        Me.txtPosTime = New System.Windows.Forms.TextBox()
        Me.dgvProgramData = New System.Windows.Forms.DataGridView()
        Me.PositionNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Speed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jerk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Accel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Decel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Dwell = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SameDeCel = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtTargetPos = New System.Windows.Forms.TextBox()
        Me.txtCurrPos = New System.Windows.Forms.TextBox()
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
        Me.TabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvProgramData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage_LiveStatus.SuspendLayout()
        Me.TabPage_Connection.SuspendLayout()
        Me.GroupBox_Controller.SuspendLayout()
        Me.GroupBox_PLC.SuspendLayout()
        Me.TabPage_Help.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl
        '
        Me.TabControl.Controls.Add(Me.TabPage1)
        Me.TabControl.Controls.Add(Me.TabPage_LiveStatus)
        Me.TabControl.Controls.Add(Me.TabPage_Connection)
        Me.TabControl.Controls.Add(Me.TabPage_Help)
        Me.TabControl.Location = New System.Drawing.Point(2, 3)
        Me.TabControl.Name = "TabControl"
        Me.TabControl.SelectedIndex = 0
        Me.TabControl.Size = New System.Drawing.Size(1213, 674)
        Me.TabControl.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.lblAutoSeqPause)
        Me.TabPage1.Controls.Add(Me.lblManStepMode)
        Me.TabPage1.Controls.Add(Me.lblAutoSeq)
        Me.TabPage1.Controls.Add(Me.Label30)
        Me.TabPage1.Controls.Add(Me.Label27)
        Me.TabPage1.Controls.Add(Me.Label29)
        Me.TabPage1.Controls.Add(Me.txtUserPos)
        Me.TabPage1.Controls.Add(Me.Label24)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.btnJumpToPos)
        Me.TabPage1.Controls.Add(Me.btnAutoStep)
        Me.TabPage1.Controls.Add(Me.btnStep)
        Me.TabPage1.Controls.Add(Me.Button9)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.txtTime)
        Me.TabPage1.Controls.Add(Me.txtPosTime)
        Me.TabPage1.Controls.Add(Me.dgvProgramData)
        Me.TabPage1.Controls.Add(Me.txtTargetPos)
        Me.TabPage1.Controls.Add(Me.txtCurrPos)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage1.Size = New System.Drawing.Size(1205, 648)
        Me.TabPage1.TabIndex = 4
        Me.TabPage1.Text = "Hank Rig Controls"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(68, 129)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(243, 205)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'lblAutoSeqPause
        '
        Me.lblAutoSeqPause.AutoSize = True
        Me.lblAutoSeqPause.Location = New System.Drawing.Point(399, 348)
        Me.lblAutoSeqPause.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutoSeqPause.Name = "lblAutoSeqPause"
        Me.lblAutoSeqPause.Size = New System.Drawing.Size(145, 13)
        Me.lblAutoSeqPause.TabIndex = 9
        Me.lblAutoSeqPause.Text = "Automatic Sequence Paused"
        '
        'lblManStepMode
        '
        Me.lblManStepMode.AutoSize = True
        Me.lblManStepMode.Location = New System.Drawing.Point(399, 320)
        Me.lblManStepMode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblManStepMode.Name = "lblManStepMode"
        Me.lblManStepMode.Size = New System.Drawing.Size(96, 13)
        Me.lblManStepMode.TabIndex = 9
        Me.lblManStepMode.Text = "Manual Step mode"
        '
        'lblAutoSeq
        '
        Me.lblAutoSeq.AutoSize = True
        Me.lblAutoSeq.Location = New System.Drawing.Point(399, 297)
        Me.lblAutoSeq.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutoSeq.Name = "lblAutoSeq"
        Me.lblAutoSeq.Size = New System.Drawing.Size(149, 13)
        Me.lblAutoSeq.TabIndex = 9
        Me.lblAutoSeq.Text = "Running Automatic Sequence"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(359, 96)
        Me.Label30.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(145, 13)
        Me.Label30.TabIndex = 8
        Me.Label30.Text = "Time Elapsed / Position Time"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(392, 66)
        Me.Label27.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(118, 13)
        Me.Label27.TabIndex = 8
        Me.Label27.Text = "Current PositionNumber"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(422, 42)
        Me.Label29.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(72, 13)
        Me.Label29.TabIndex = 7
        Me.Label29.Text = "User Position:"
        '
        'txtUserPos
        '
        Me.txtUserPos.Location = New System.Drawing.Point(516, 40)
        Me.txtUserPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtUserPos.Name = "txtUserPos"
        Me.txtUserPos.Size = New System.Drawing.Size(68, 20)
        Me.txtUserPos.TabIndex = 3
        Me.txtUserPos.Text = "0.000m"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(685, 18)
        Me.Label24.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(136, 13)
        Me.Label24.TabIndex = 6
        Me.Label24.Text = "Loaded Test Program data:"
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
        Me.GroupBox2.Location = New System.Drawing.Point(358, 424)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(309, 223)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Setup Functions"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnSetUserPos)
        Me.GroupBox3.Controls.Add(Me.Label28)
        Me.GroupBox3.Controls.Add(Me.txtNewUserPos)
        Me.GroupBox3.Location = New System.Drawing.Point(15, 98)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(258, 90)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Position Offset"
        '
        'btnSetUserPos
        '
        Me.btnSetUserPos.Location = New System.Drawing.Point(24, 45)
        Me.btnSetUserPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnSetUserPos.Name = "btnSetUserPos"
        Me.btnSetUserPos.Size = New System.Drawing.Size(64, 41)
        Me.btnSetUserPos.TabIndex = 0
        Me.btnSetUserPos.Text = "Set User Position"
        Me.btnSetUserPos.UseVisualStyleBackColor = True
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 21)
        Me.Label28.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(127, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "New User Position Value:"
        '
        'txtNewUserPos
        '
        Me.txtNewUserPos.Location = New System.Drawing.Point(141, 19)
        Me.txtNewUserPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNewUserPos.Name = "txtNewUserPos"
        Me.txtNewUserPos.Size = New System.Drawing.Size(68, 20)
        Me.txtNewUserPos.TabIndex = 3
        Me.txtNewUserPos.Text = "0.000m"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(21, 201)
        Me.Label26.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(81, 13)
        Me.Label26.TabIndex = 7
        Me.Label26.Text = "System Position"
        '
        'lblRoutineStatus
        '
        Me.lblRoutineStatus.AutoSize = True
        Me.lblRoutineStatus.Location = New System.Drawing.Point(23, 69)
        Me.lblRoutineStatus.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRoutineStatus.Name = "lblRoutineStatus"
        Me.lblRoutineStatus.Size = New System.Drawing.Size(166, 13)
        Me.lblRoutineStatus.TabIndex = 1
        Me.lblRoutineStatus.Text = "Routine status info displayed here"
        '
        'btnLevel
        '
        Me.btnLevel.Location = New System.Drawing.Point(26, 23)
        Me.btnLevel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLevel.Name = "btnLevel"
        Me.btnLevel.Size = New System.Drawing.Size(84, 31)
        Me.btnLevel.TabIndex = 0
        Me.btnLevel.Text = "Level Routine"
        Me.btnLevel.UseVisualStyleBackColor = True
        '
        'btnPower
        '
        Me.btnPower.Location = New System.Drawing.Point(190, 23)
        Me.btnPower.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnPower.Name = "btnPower"
        Me.btnPower.Size = New System.Drawing.Size(101, 31)
        Me.btnPower.TabIndex = 0
        Me.btnPower.Text = "Power ON / OFF"
        Me.btnPower.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(121, 23)
        Me.btnHome.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(53, 31)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'lblSystemPos
        '
        Me.lblSystemPos.Location = New System.Drawing.Point(106, 197)
        Me.lblSystemPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lblSystemPos.Name = "lblSystemPos"
        Me.lblSystemPos.Size = New System.Drawing.Size(68, 20)
        Me.lblSystemPos.TabIndex = 3
        Me.lblSystemPos.Text = "0.029m"
        '
        'btnJumpToPos
        '
        Me.btnJumpToPos.Location = New System.Drawing.Point(397, 230)
        Me.btnJumpToPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnJumpToPos.Name = "btnJumpToPos"
        Me.btnJumpToPos.Size = New System.Drawing.Size(113, 40)
        Me.btnJumpToPos.TabIndex = 0
        Me.btnJumpToPos.Text = "Jump to Position Number:"
        Me.btnJumpToPos.UseVisualStyleBackColor = True
        '
        'btnAutoStep
        '
        Me.btnAutoStep.Location = New System.Drawing.Point(398, 183)
        Me.btnAutoStep.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAutoStep.Name = "btnAutoStep"
        Me.btnAutoStep.Size = New System.Drawing.Size(113, 36)
        Me.btnAutoStep.TabIndex = 0
        Me.btnAutoStep.Text = "Automatic Step Forward"
        Me.btnAutoStep.UseVisualStyleBackColor = True
        '
        'btnStep
        '
        Me.btnStep.Location = New System.Drawing.Point(527, 183)
        Me.btnStep.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnStep.Name = "btnStep"
        Me.btnStep.Size = New System.Drawing.Size(57, 36)
        Me.btnStep.TabIndex = 0
        Me.btnStep.Text = "Step Back"
        Me.btnStep.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(596, 183)
        Me.Button9.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(53, 36)
        Me.Button9.TabIndex = 0
        Me.Button9.Text = "Step Forward"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Location = New System.Drawing.Point(4, 424)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(343, 223)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Manual Control"
        '
        'txtTFB
        '
        Me.txtTFB.Location = New System.Drawing.Point(261, 98)
        Me.txtTFB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTFB.Name = "txtTFB"
        Me.txtTFB.Size = New System.Drawing.Size(68, 20)
        Me.txtTFB.TabIndex = 3
        '
        'btnLowerA
        '
        Me.btnLowerA.Location = New System.Drawing.Point(177, 183)
        Me.btnLowerA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLowerA.Name = "btnLowerA"
        Me.btnLowerA.Size = New System.Drawing.Size(53, 31)
        Me.btnLowerA.TabIndex = 0
        Me.btnLowerA.Text = "Lower"
        Me.btnLowerA.UseVisualStyleBackColor = True
        '
        'txtATB
        '
        Me.txtATB.Location = New System.Drawing.Point(262, 70)
        Me.txtATB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtATB.Name = "txtATB"
        Me.txtATB.Size = New System.Drawing.Size(68, 20)
        Me.txtATB.TabIndex = 3
        '
        'btnLowerB
        '
        Me.btnLowerB.Location = New System.Drawing.Point(262, 183)
        Me.btnLowerB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLowerB.Name = "btnLowerB"
        Me.btnLowerB.Size = New System.Drawing.Size(53, 31)
        Me.btnLowerB.TabIndex = 0
        Me.btnLowerB.Text = "Lower"
        Me.btnLowerB.UseVisualStyleBackColor = True
        '
        'txtAPB
        '
        Me.txtAPB.Location = New System.Drawing.Point(262, 44)
        Me.txtAPB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAPB.Name = "txtAPB"
        Me.txtAPB.Size = New System.Drawing.Size(68, 20)
        Me.txtAPB.TabIndex = 3
        '
        'btnRaiseA
        '
        Me.btnRaiseA.Location = New System.Drawing.Point(177, 148)
        Me.btnRaiseA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRaiseA.Name = "btnRaiseA"
        Me.btnRaiseA.Size = New System.Drawing.Size(53, 31)
        Me.btnRaiseA.TabIndex = 0
        Me.btnRaiseA.Text = "Raise"
        Me.btnRaiseA.UseVisualStyleBackColor = True
        '
        'txtTFA
        '
        Me.txtTFA.Location = New System.Drawing.Point(175, 98)
        Me.txtTFA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTFA.Name = "txtTFA"
        Me.txtTFA.Size = New System.Drawing.Size(68, 20)
        Me.txtTFA.TabIndex = 3
        '
        'btnRaiseB
        '
        Me.btnRaiseB.Location = New System.Drawing.Point(262, 148)
        Me.btnRaiseB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRaiseB.Name = "btnRaiseB"
        Me.btnRaiseB.Size = New System.Drawing.Size(53, 31)
        Me.btnRaiseB.TabIndex = 0
        Me.btnRaiseB.Text = "Raise"
        Me.btnRaiseB.UseVisualStyleBackColor = True
        '
        'txtATA
        '
        Me.txtATA.Location = New System.Drawing.Point(176, 70)
        Me.txtATA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtATA.Name = "txtATA"
        Me.txtATA.Size = New System.Drawing.Size(68, 20)
        Me.txtATA.TabIndex = 3
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(74, 44)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(90, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Actuator Position:"
        '
        'txtAPA
        '
        Me.txtAPA.Location = New System.Drawing.Point(176, 44)
        Me.txtAPA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAPA.Name = "txtAPA"
        Me.txtAPA.Size = New System.Drawing.Size(68, 20)
        Me.txtAPA.TabIndex = 3
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(200, 16)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(14, 13)
        Me.Label21.TabIndex = 2
        Me.Label21.Text = "A"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(15, 100)
        Me.Label23.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(160, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Tension/Compression Force: kN"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(284, 16)
        Me.Label22.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(14, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "B"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(74, 70)
        Me.Label20.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(87, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Actuator Torque:"
        '
        'txtTime
        '
        Me.txtTime.Location = New System.Drawing.Point(516, 96)
        Me.txtTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTime.Name = "txtTime"
        Me.txtTime.Size = New System.Drawing.Size(68, 20)
        Me.txtTime.TabIndex = 3
        Me.txtTime.Text = "45ms"
        '
        'txtPosTime
        '
        Me.txtPosTime.Location = New System.Drawing.Point(587, 96)
        Me.txtPosTime.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPosTime.Name = "txtPosTime"
        Me.txtPosTime.Size = New System.Drawing.Size(68, 20)
        Me.txtPosTime.TabIndex = 3
        Me.txtPosTime.Text = "100ms"
        '
        'dgvProgramData
        '
        Me.dgvProgramData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProgramData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PositionNumber, Me.Position, Me.Speed, Me.Jerk, Me.Accel, Me.Decel, Me.Dwell, Me.SameDeCel})
        Me.dgvProgramData.Location = New System.Drawing.Point(687, 41)
        Me.dgvProgramData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvProgramData.Name = "dgvProgramData"
        Me.dgvProgramData.RowHeadersWidth = 62
        Me.dgvProgramData.RowTemplate.Height = 28
        Me.dgvProgramData.Size = New System.Drawing.Size(842, 606)
        Me.dgvProgramData.TabIndex = 1
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
        'txtTargetPos
        '
        Me.txtTargetPos.Location = New System.Drawing.Point(527, 241)
        Me.txtTargetPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTargetPos.Name = "txtTargetPos"
        Me.txtTargetPos.Size = New System.Drawing.Size(122, 20)
        Me.txtTargetPos.TabIndex = 3
        Me.txtTargetPos.Text = "Target Position number"
        '
        'txtCurrPos
        '
        Me.txtCurrPos.Location = New System.Drawing.Point(515, 66)
        Me.txtCurrPos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCurrPos.Name = "txtCurrPos"
        Me.txtCurrPos.Size = New System.Drawing.Size(68, 20)
        Me.txtCurrPos.TabIndex = 3
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
        Me.TabPage_LiveStatus.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_LiveStatus.Name = "TabPage_LiveStatus"
        Me.TabPage_LiveStatus.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage_LiveStatus.Size = New System.Drawing.Size(1205, 648)
        Me.TabPage_LiveStatus.TabIndex = 0
        Me.TabPage_LiveStatus.Text = "Live Status"
        Me.TabPage_LiveStatus.UseVisualStyleBackColor = True
        '
        'ProgressBar_RightShoulderAnalog
        '
        Me.ProgressBar_RightShoulderAnalog.Location = New System.Drawing.Point(363, 88)
        Me.ProgressBar_RightShoulderAnalog.Maximum = 255
        Me.ProgressBar_RightShoulderAnalog.Name = "ProgressBar_RightShoulderAnalog"
        Me.ProgressBar_RightShoulderAnalog.Size = New System.Drawing.Size(10, 45)
        Me.ProgressBar_RightShoulderAnalog.TabIndex = 58
        Me.ProgressBar_RightShoulderAnalog.Value = 255
        '
        'ProgressBar_LeftShoulderAnalog
        '
        Me.ProgressBar_LeftShoulderAnalog.Location = New System.Drawing.Point(101, 88)
        Me.ProgressBar_LeftShoulderAnalog.Maximum = 255
        Me.ProgressBar_LeftShoulderAnalog.Name = "ProgressBar_LeftShoulderAnalog"
        Me.ProgressBar_LeftShoulderAnalog.Size = New System.Drawing.Size(10, 45)
        Me.ProgressBar_LeftShoulderAnalog.TabIndex = 57
        Me.ProgressBar_LeftShoulderAnalog.Value = 255
        '
        'ProgressBar_LeftStickYMinus
        '
        Me.ProgressBar_LeftStickYMinus.Location = New System.Drawing.Point(102, 254)
        Me.ProgressBar_LeftStickYMinus.Maximum = 32768
        Me.ProgressBar_LeftStickYMinus.Name = "ProgressBar_LeftStickYMinus"
        Me.ProgressBar_LeftStickYMinus.Size = New System.Drawing.Size(9, 45)
        Me.ProgressBar_LeftStickYMinus.TabIndex = 56
        '
        'ProgressBar_RightStickYMinus
        '
        Me.ProgressBar_RightStickYMinus.Location = New System.Drawing.Point(332, 372)
        Me.ProgressBar_RightStickYMinus.Maximum = 32768
        Me.ProgressBar_RightStickYMinus.Name = "ProgressBar_RightStickYMinus"
        Me.ProgressBar_RightStickYMinus.Size = New System.Drawing.Size(9, 45)
        Me.ProgressBar_RightStickYMinus.TabIndex = 55
        '
        'ProgressBar_RightStickYPlus
        '
        Me.ProgressBar_RightStickYPlus.Location = New System.Drawing.Point(332, 311)
        Me.ProgressBar_RightStickYPlus.Maximum = 32768
        Me.ProgressBar_RightStickYPlus.Name = "ProgressBar_RightStickYPlus"
        Me.ProgressBar_RightStickYPlus.Size = New System.Drawing.Size(10, 45)
        Me.ProgressBar_RightStickYPlus.TabIndex = 54
        Me.ProgressBar_RightStickYPlus.Value = 32768
        '
        'ProgressBar_LeftStickYPlus
        '
        Me.ProgressBar_LeftStickYPlus.Location = New System.Drawing.Point(102, 196)
        Me.ProgressBar_LeftStickYPlus.Maximum = 32768
        Me.ProgressBar_LeftStickYPlus.Name = "ProgressBar_LeftStickYPlus"
        Me.ProgressBar_LeftStickYPlus.Size = New System.Drawing.Size(10, 45)
        Me.ProgressBar_LeftStickYPlus.TabIndex = 51
        Me.ProgressBar_LeftStickYPlus.Value = 32768
        '
        'Label_LeftShoulderVal
        '
        Me.Label_LeftShoulderVal.AutoSize = True
        Me.Label_LeftShoulderVal.Location = New System.Drawing.Point(112, 107)
        Me.Label_LeftShoulderVal.Name = "Label_LeftShoulderVal"
        Me.Label_LeftShoulderVal.Size = New System.Drawing.Size(34, 13)
        Me.Label_LeftShoulderVal.TabIndex = 49
        Me.Label_LeftShoulderVal.Text = "L Val:"
        '
        'Label_RightShoulderVal
        '
        Me.Label_RightShoulderVal.AutoSize = True
        Me.Label_RightShoulderVal.Location = New System.Drawing.Point(328, 107)
        Me.Label_RightShoulderVal.Name = "Label_RightShoulderVal"
        Me.Label_RightShoulderVal.Size = New System.Drawing.Size(36, 13)
        Me.Label_RightShoulderVal.TabIndex = 48
        Me.Label_RightShoulderVal.Text = "R Val:"
        '
        'Label_RightStickYNeg
        '
        Me.Label_RightStickYNeg.AutoSize = True
        Me.Label_RightStickYNeg.Location = New System.Drawing.Point(320, 421)
        Me.Label_RightStickYNeg.Name = "Label_RightStickYNeg"
        Me.Label_RightStickYNeg.Size = New System.Drawing.Size(38, 13)
        Me.Label_RightStickYNeg.TabIndex = 43
        Me.Label_RightStickYNeg.Text = "Y Val: "
        '
        'Label_RightStickYPos
        '
        Me.Label_RightStickYPos.AutoSize = True
        Me.Label_RightStickYPos.Location = New System.Drawing.Point(319, 294)
        Me.Label_RightStickYPos.Name = "Label_RightStickYPos"
        Me.Label_RightStickYPos.Size = New System.Drawing.Size(38, 13)
        Me.Label_RightStickYPos.TabIndex = 42
        Me.Label_RightStickYPos.Text = "Y Val: "
        '
        'Label_LeftStickYPos
        '
        Me.Label_LeftStickYPos.AutoSize = True
        Me.Label_LeftStickYPos.Location = New System.Drawing.Point(89, 181)
        Me.Label_LeftStickYPos.Name = "Label_LeftStickYPos"
        Me.Label_LeftStickYPos.Size = New System.Drawing.Size(38, 13)
        Me.Label_LeftStickYPos.TabIndex = 41
        Me.Label_LeftStickYPos.Text = "Y Val: "
        '
        'Label_LeftStickYNeg
        '
        Me.Label_LeftStickYNeg.AutoSize = True
        Me.Label_LeftStickYNeg.Location = New System.Drawing.Point(88, 302)
        Me.Label_LeftStickYNeg.Name = "Label_LeftStickYNeg"
        Me.Label_LeftStickYNeg.Size = New System.Drawing.Size(38, 13)
        Me.Label_LeftStickYNeg.TabIndex = 40
        Me.Label_LeftStickYNeg.Text = "Y Val: "
        '
        'Label_RightStickXPos
        '
        Me.Label_RightStickXPos.AutoSize = True
        Me.Label_RightStickXPos.Location = New System.Drawing.Point(355, 371)
        Me.Label_RightStickXPos.Name = "Label_RightStickXPos"
        Me.Label_RightStickXPos.Size = New System.Drawing.Size(38, 13)
        Me.Label_RightStickXPos.TabIndex = 39
        Me.Label_RightStickXPos.Text = "X Val: "
        '
        'Label_RightStickXNeg
        '
        Me.Label_RightStickXNeg.AutoSize = True
        Me.Label_RightStickXNeg.Location = New System.Drawing.Point(282, 371)
        Me.Label_RightStickXNeg.Name = "Label_RightStickXNeg"
        Me.Label_RightStickXNeg.Size = New System.Drawing.Size(38, 13)
        Me.Label_RightStickXNeg.TabIndex = 38
        Me.Label_RightStickXNeg.Text = "X Val: "
        '
        'Label_LeftStickXPos
        '
        Me.Label_LeftStickXPos.AutoSize = True
        Me.Label_LeftStickXPos.Location = New System.Drawing.Point(123, 256)
        Me.Label_LeftStickXPos.Name = "Label_LeftStickXPos"
        Me.Label_LeftStickXPos.Size = New System.Drawing.Size(38, 13)
        Me.Label_LeftStickXPos.TabIndex = 37
        Me.Label_LeftStickXPos.Text = "X Val: "
        '
        'Label_LeftStickXNeg
        '
        Me.Label_LeftStickXNeg.AutoSize = True
        Me.Label_LeftStickXNeg.Location = New System.Drawing.Point(50, 256)
        Me.Label_LeftStickXNeg.Name = "Label_LeftStickXNeg"
        Me.Label_LeftStickXNeg.Size = New System.Drawing.Size(38, 13)
        Me.Label_LeftStickXNeg.TabIndex = 36
        Me.Label_LeftStickXNeg.Text = "X Val: "
        '
        'CheckBox_RightShoulderBtn
        '
        Me.CheckBox_RightShoulderBtn.AutoSize = True
        Me.CheckBox_RightShoulderBtn.Location = New System.Drawing.Point(320, 156)
        Me.CheckBox_RightShoulderBtn.Name = "CheckBox_RightShoulderBtn"
        Me.CheckBox_RightShoulderBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_RightShoulderBtn.Size = New System.Drawing.Size(115, 17)
        Me.CheckBox_RightShoulderBtn.TabIndex = 33
        Me.CheckBox_RightShoulderBtn.Text = "Right Shoulder Btn"
        Me.CheckBox_RightShoulderBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_LeftShoulderBtn
        '
        Me.CheckBox_LeftShoulderBtn.AutoSize = True
        Me.CheckBox_LeftShoulderBtn.Location = New System.Drawing.Point(53, 156)
        Me.CheckBox_LeftShoulderBtn.Name = "CheckBox_LeftShoulderBtn"
        Me.CheckBox_LeftShoulderBtn.Size = New System.Drawing.Size(105, 17)
        Me.CheckBox_LeftShoulderBtn.TabIndex = 32
        Me.CheckBox_LeftShoulderBtn.Text = "LeftShoulder Btn"
        Me.CheckBox_LeftShoulderBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadLeft
        '
        Me.CheckBox_DPadLeft.AutoSize = True
        Me.CheckBox_DPadLeft.Location = New System.Drawing.Point(80, 357)
        Me.CheckBox_DPadLeft.Name = "CheckBox_DPadLeft"
        Me.CheckBox_DPadLeft.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_DPadLeft.Size = New System.Drawing.Size(44, 17)
        Me.CheckBox_DPadLeft.TabIndex = 31
        Me.CheckBox_DPadLeft.Text = "Left"
        Me.CheckBox_DPadLeft.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadRight
        '
        Me.CheckBox_DPadRight.AutoSize = True
        Me.CheckBox_DPadRight.Location = New System.Drawing.Point(161, 357)
        Me.CheckBox_DPadRight.Name = "CheckBox_DPadRight"
        Me.CheckBox_DPadRight.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox_DPadRight.TabIndex = 30
        Me.CheckBox_DPadRight.Text = "Right"
        Me.CheckBox_DPadRight.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadDown
        '
        Me.CheckBox_DPadDown.AutoSize = True
        Me.CheckBox_DPadDown.Location = New System.Drawing.Point(135, 384)
        Me.CheckBox_DPadDown.Name = "CheckBox_DPadDown"
        Me.CheckBox_DPadDown.Size = New System.Drawing.Size(54, 17)
        Me.CheckBox_DPadDown.TabIndex = 29
        Me.CheckBox_DPadDown.Text = "Down"
        Me.CheckBox_DPadDown.UseVisualStyleBackColor = True
        '
        'CheckBox_DPadUp
        '
        Me.CheckBox_DPadUp.AutoSize = True
        Me.CheckBox_DPadUp.Location = New System.Drawing.Point(110, 333)
        Me.CheckBox_DPadUp.Name = "CheckBox_DPadUp"
        Me.CheckBox_DPadUp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_DPadUp.Size = New System.Drawing.Size(40, 17)
        Me.CheckBox_DPadUp.TabIndex = 28
        Me.CheckBox_DPadUp.Text = "Up"
        Me.CheckBox_DPadUp.UseVisualStyleBackColor = True
        '
        'CheckBox_BackBtn
        '
        Me.CheckBox_BackBtn.AutoSize = True
        Me.CheckBox_BackBtn.Location = New System.Drawing.Point(185, 243)
        Me.CheckBox_BackBtn.Name = "CheckBox_BackBtn"
        Me.CheckBox_BackBtn.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_BackBtn.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox_BackBtn.TabIndex = 27
        Me.CheckBox_BackBtn.Text = "Back"
        Me.CheckBox_BackBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_StartBtn
        '
        Me.CheckBox_StartBtn.AutoSize = True
        Me.CheckBox_StartBtn.Location = New System.Drawing.Point(276, 243)
        Me.CheckBox_StartBtn.Name = "CheckBox_StartBtn"
        Me.CheckBox_StartBtn.Size = New System.Drawing.Size(48, 17)
        Me.CheckBox_StartBtn.TabIndex = 26
        Me.CheckBox_StartBtn.Text = "Start"
        Me.CheckBox_StartBtn.UseVisualStyleBackColor = True
        '
        'CheckBox_XButton
        '
        Me.CheckBox_XButton.AutoSize = True
        Me.CheckBox_XButton.Location = New System.Drawing.Point(346, 243)
        Me.CheckBox_XButton.Name = "CheckBox_XButton"
        Me.CheckBox_XButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_XButton.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox_XButton.TabIndex = 25
        Me.CheckBox_XButton.Text = "X"
        Me.CheckBox_XButton.UseVisualStyleBackColor = True
        '
        'CheckBox_BButton
        '
        Me.CheckBox_BButton.AutoSize = True
        Me.CheckBox_BButton.Location = New System.Drawing.Point(416, 243)
        Me.CheckBox_BButton.Name = "CheckBox_BButton"
        Me.CheckBox_BButton.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox_BButton.TabIndex = 24
        Me.CheckBox_BButton.Text = "B"
        Me.CheckBox_BButton.UseVisualStyleBackColor = True
        '
        'CheckBox_AButton
        '
        Me.CheckBox_AButton.AutoSize = True
        Me.CheckBox_AButton.Location = New System.Drawing.Point(390, 268)
        Me.CheckBox_AButton.Name = "CheckBox_AButton"
        Me.CheckBox_AButton.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox_AButton.TabIndex = 23
        Me.CheckBox_AButton.Text = "A"
        Me.CheckBox_AButton.UseVisualStyleBackColor = True
        '
        'CheckBox_YButton
        '
        Me.CheckBox_YButton.AutoSize = True
        Me.CheckBox_YButton.Location = New System.Drawing.Point(372, 217)
        Me.CheckBox_YButton.Name = "CheckBox_YButton"
        Me.CheckBox_YButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckBox_YButton.Size = New System.Drawing.Size(33, 17)
        Me.CheckBox_YButton.TabIndex = 22
        Me.CheckBox_YButton.Text = "Y"
        Me.CheckBox_YButton.UseVisualStyleBackColor = True
        '
        'ProgressBar_RightStickXMinus
        '
        Me.ProgressBar_RightStickXMinus.Location = New System.Drawing.Point(278, 358)
        Me.ProgressBar_RightStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXMinus.Maximum = 32768
        Me.ProgressBar_RightStickXMinus.Name = "ProgressBar_RightStickXMinus"
        Me.ProgressBar_RightStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_RightStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_RightStickXMinus.Size = New System.Drawing.Size(46, 10)
        Me.ProgressBar_RightStickXMinus.TabIndex = 21
        '
        'ProgressBar_RightStickXPlus
        '
        Me.ProgressBar_RightStickXPlus.Location = New System.Drawing.Point(352, 358)
        Me.ProgressBar_RightStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_RightStickXPlus.Maximum = 32768
        Me.ProgressBar_RightStickXPlus.Name = "ProgressBar_RightStickXPlus"
        Me.ProgressBar_RightStickXPlus.Size = New System.Drawing.Size(46, 10)
        Me.ProgressBar_RightStickXPlus.TabIndex = 20
        '
        'ProgressBar_LeftStickXMinus
        '
        Me.ProgressBar_LeftStickXMinus.Location = New System.Drawing.Point(47, 243)
        Me.ProgressBar_LeftStickXMinus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXMinus.Maximum = 32768
        Me.ProgressBar_LeftStickXMinus.Name = "ProgressBar_LeftStickXMinus"
        Me.ProgressBar_LeftStickXMinus.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_LeftStickXMinus.RightToLeftLayout = True
        Me.ProgressBar_LeftStickXMinus.Size = New System.Drawing.Size(46, 10)
        Me.ProgressBar_LeftStickXMinus.TabIndex = 19
        '
        'ProgressBar_LeftStickXPlus
        '
        Me.ProgressBar_LeftStickXPlus.Location = New System.Drawing.Point(119, 243)
        Me.ProgressBar_LeftStickXPlus.MarqueeAnimationSpeed = 0
        Me.ProgressBar_LeftStickXPlus.Maximum = 32768
        Me.ProgressBar_LeftStickXPlus.Name = "ProgressBar_LeftStickXPlus"
        Me.ProgressBar_LeftStickXPlus.Size = New System.Drawing.Size(46, 10)
        Me.ProgressBar_LeftStickXPlus.TabIndex = 18
        '
        'ProgressBar_Controller0Battery
        '
        Me.ProgressBar_Controller0Battery.Location = New System.Drawing.Point(352, 28)
        Me.ProgressBar_Controller0Battery.MarqueeAnimationSpeed = 1
        Me.ProgressBar_Controller0Battery.Name = "ProgressBar_Controller0Battery"
        Me.ProgressBar_Controller0Battery.Size = New System.Drawing.Size(140, 10)
        Me.ProgressBar_Controller0Battery.TabIndex = 17
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(304, 25)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(43, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Battery:"
        '
        'Label_Controller0_Connection
        '
        Me.Label_Controller0_Connection.BackColor = System.Drawing.Color.Transparent
        Me.Label_Controller0_Connection.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_Controller0_Connection.Location = New System.Drawing.Point(307, 6)
        Me.Label_Controller0_Connection.Name = "Label_Controller0_Connection"
        Me.Label_Controller0_Connection.Size = New System.Drawing.Size(185, 19)
        Me.Label_Controller0_Connection.TabIndex = 15
        Me.Label_Controller0_Connection.Text = "Controller 0 Connection"
        Me.Label_Controller0_Connection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label_JoyActiveFromPLC
        '
        Me.Label_JoyActiveFromPLC.BackColor = System.Drawing.Color.Transparent
        Me.Label_JoyActiveFromPLC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_JoyActiveFromPLC.Location = New System.Drawing.Point(71, 579)
        Me.Label_JoyActiveFromPLC.Name = "Label_JoyActiveFromPLC"
        Me.Label_JoyActiveFromPLC.Size = New System.Drawing.Size(118, 23)
        Me.Label_JoyActiveFromPLC.TabIndex = 14
        Me.Label_JoyActiveFromPLC.Text = "Latency Status"
        Me.Label_JoyActiveFromPLC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar_ADSBad
        '
        Me.ProgressBar_ADSBad.Location = New System.Drawing.Point(307, 579)
        Me.ProgressBar_ADSBad.MarqueeAnimationSpeed = 0
        Me.ProgressBar_ADSBad.Name = "ProgressBar_ADSBad"
        Me.ProgressBar_ADSBad.Size = New System.Drawing.Size(105, 23)
        Me.ProgressBar_ADSBad.TabIndex = 13
        '
        'ProgressBar_ADSGood
        '
        Me.ProgressBar_ADSGood.Location = New System.Drawing.Point(202, 579)
        Me.ProgressBar_ADSGood.MarqueeAnimationSpeed = 0
        Me.ProgressBar_ADSGood.Name = "ProgressBar_ADSGood"
        Me.ProgressBar_ADSGood.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProgressBar_ADSGood.RightToLeftLayout = True
        Me.ProgressBar_ADSGood.Size = New System.Drawing.Size(105, 23)
        Me.ProgressBar_ADSGood.TabIndex = 12
        '
        'TextBox_ADSDataRateAchieved
        '
        Me.TextBox_ADSDataRateAchieved.Enabled = False
        Me.TextBox_ADSDataRateAchieved.Location = New System.Drawing.Point(202, 553)
        Me.TextBox_ADSDataRateAchieved.Name = "TextBox_ADSDataRateAchieved"
        Me.TextBox_ADSDataRateAchieved.Size = New System.Drawing.Size(211, 20)
        Me.TextBox_ADSDataRateAchieved.TabIndex = 11
        Me.TextBox_ADSDataRateAchieved.TabStop = False
        Me.TextBox_ADSDataRateAchieved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(68, 556)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "ADS Data Rate Achieved:"
        '
        'TextBox_ADSConnectionStatus2
        '
        Me.TextBox_ADSConnectionStatus2.Enabled = False
        Me.TextBox_ADSConnectionStatus2.Location = New System.Drawing.Point(202, 606)
        Me.TextBox_ADSConnectionStatus2.Name = "TextBox_ADSConnectionStatus2"
        Me.TextBox_ADSConnectionStatus2.Size = New System.Drawing.Size(211, 20)
        Me.TextBox_ADSConnectionStatus2.TabIndex = 9
        Me.TextBox_ADSConnectionStatus2.TabStop = False
        Me.TextBox_ADSConnectionStatus2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(68, 609)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "ADS Connection Status: "
        '
        'TabPage_Connection
        '
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_Controller)
        Me.TabPage_Connection.Controls.Add(Me.GroupBox_PLC)
        Me.TabPage_Connection.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Connection.Name = "TabPage_Connection"
        Me.TabPage_Connection.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage_Connection.Size = New System.Drawing.Size(1205, 648)
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
        Me.GroupBox_Controller.Location = New System.Drawing.Point(6, 304)
        Me.GroupBox_Controller.Name = "GroupBox_Controller"
        Me.GroupBox_Controller.Size = New System.Drawing.Size(493, 336)
        Me.GroupBox_Controller.TabIndex = 11
        Me.GroupBox_Controller.TabStop = False
        Me.GroupBox_Controller.Text = "Game Controller"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(227, 78)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(88, 13)
        Me.Label16.TabIndex = 23
        Me.Label16.Text = "counts (255 max)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 78)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(142, 13)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Analog Shoulder Dead Zone"
        '
        'TextBox_ShoulderDeadzone
        '
        Me.TextBox_ShoulderDeadzone.Location = New System.Drawing.Point(173, 74)
        Me.TextBox_ShoulderDeadzone.Name = "TextBox_ShoulderDeadzone"
        Me.TextBox_ShoulderDeadzone.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_ShoulderDeadzone.TabIndex = 7
        Me.TextBox_ShoulderDeadzone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(227, 52)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(100, 13)
        Me.Label15.TabIndex = 22
        Me.Label15.Text = "counts (32767 max)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(124, 13)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "Analog Stick Dead Zone"
        '
        'TextBox_AnalogDeadzone
        '
        Me.TextBox_AnalogDeadzone.Location = New System.Drawing.Point(173, 48)
        Me.TextBox_AnalogDeadzone.Name = "TextBox_AnalogDeadzone"
        Me.TextBox_AnalogDeadzone.Size = New System.Drawing.Size(48, 20)
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
        Me.GroupBox_PLC.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox_PLC.Name = "GroupBox_PLC"
        Me.GroupBox_PLC.Size = New System.Drawing.Size(493, 292)
        Me.GroupBox_PLC.TabIndex = 10
        Me.GroupBox_PLC.TabStop = False
        Me.GroupBox_PLC.Text = "PLC"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(199, 128)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(20, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "ms"
        '
        'TextBox_ADSWatchdogDeadDuration
        '
        Me.TextBox_ADSWatchdogDeadDuration.Location = New System.Drawing.Point(146, 125)
        Me.TextBox_ADSWatchdogDeadDuration.Name = "TextBox_ADSWatchdogDeadDuration"
        Me.TextBox_ADSWatchdogDeadDuration.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_ADSWatchdogDeadDuration.TabIndex = 4
        Me.TextBox_ADSWatchdogDeadDuration.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(22, 128)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 13)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "ADS WD Dead Duration:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(199, 103)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(20, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "ms"
        '
        'TextBox_ADSWatchdog
        '
        Me.TextBox_ADSWatchdog.Location = New System.Drawing.Point(146, 100)
        Me.TextBox_ADSWatchdog.Name = "TextBox_ADSWatchdog"
        Me.TextBox_ADSWatchdog.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_ADSWatchdog.TabIndex = 3
        Me.TextBox_ADSWatchdog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 103)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(85, 13)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "ADS Watchdog:"
        '
        'Button_ADSDisconnect
        '
        Me.Button_ADSDisconnect.Location = New System.Drawing.Point(329, 73)
        Me.Button_ADSDisconnect.Name = "Button_ADSDisconnect"
        Me.Button_ADSDisconnect.Size = New System.Drawing.Size(138, 23)
        Me.Button_ADSDisconnect.TabIndex = 10
        Me.Button_ADSDisconnect.Text = "Disconnect"
        Me.Button_ADSDisconnect.UseVisualStyleBackColor = True
        '
        'TextBox_TcJoyPath
        '
        Me.TextBox_TcJoyPath.Location = New System.Drawing.Point(146, 150)
        Me.TextBox_TcJoyPath.Name = "TextBox_TcJoyPath"
        Me.TextBox_TcJoyPath.Size = New System.Drawing.Size(337, 20)
        Me.TextBox_TcJoyPath.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(22, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "FB_TcJoy Instance:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(199, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "ms"
        '
        'TextBox_ADSRate
        '
        Me.TextBox_ADSRate.Location = New System.Drawing.Point(146, 75)
        Me.TextBox_ADSRate.Name = "TextBox_ADSRate"
        Me.TextBox_ADSRate.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_ADSRate.TabIndex = 2
        Me.TextBox_ADSRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(22, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "ADS Rate:"
        '
        'TextBox_ADSNetID
        '
        Me.TextBox_ADSNetID.Location = New System.Drawing.Point(146, 21)
        Me.TextBox_ADSNetID.Name = "TextBox_ADSNetID"
        Me.TextBox_ADSNetID.Size = New System.Drawing.Size(139, 20)
        Me.TextBox_ADSNetID.TabIndex = 0
        Me.TextBox_ADSNetID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_TcJoyFunctionBlockStatus
        '
        Me.TextBox_TcJoyFunctionBlockStatus.Enabled = False
        Me.TextBox_TcJoyFunctionBlockStatus.Location = New System.Drawing.Point(193, 266)
        Me.TextBox_TcJoyFunctionBlockStatus.Name = "TextBox_TcJoyFunctionBlockStatus"
        Me.TextBox_TcJoyFunctionBlockStatus.Size = New System.Drawing.Size(211, 20)
        Me.TextBox_TcJoyFunctionBlockStatus.TabIndex = 9
        Me.TextBox_TcJoyFunctionBlockStatus.TabStop = False
        Me.TextBox_TcJoyFunctionBlockStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ADS NetID:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 269)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "TcJoy Function Block:"
        '
        'TextBox_ADSPort
        '
        Me.TextBox_ADSPort.Location = New System.Drawing.Point(146, 49)
        Me.TextBox_ADSPort.Name = "TextBox_ADSPort"
        Me.TextBox_ADSPort.Size = New System.Drawing.Size(48, 20)
        Me.TextBox_ADSPort.TabIndex = 1
        Me.TextBox_ADSPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TextBox_ADSConnectionStatus
        '
        Me.TextBox_ADSConnectionStatus.Enabled = False
        Me.TextBox_ADSConnectionStatus.Location = New System.Drawing.Point(193, 241)
        Me.TextBox_ADSConnectionStatus.Name = "TextBox_ADSConnectionStatus"
        Me.TextBox_ADSConnectionStatus.Size = New System.Drawing.Size(211, 20)
        Me.TextBox_ADSConnectionStatus.TabIndex = 7
        Me.TextBox_ADSConnectionStatus.TabStop = False
        Me.TextBox_ADSConnectionStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ADS Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 244)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ADS Connection Status: "
        '
        'Button_ADSConnect
        '
        Me.Button_ADSConnect.Location = New System.Drawing.Point(329, 44)
        Me.Button_ADSConnect.Name = "Button_ADSConnect"
        Me.Button_ADSConnect.Size = New System.Drawing.Size(138, 23)
        Me.Button_ADSConnect.TabIndex = 9
        Me.Button_ADSConnect.Text = "Connect"
        Me.Button_ADSConnect.UseVisualStyleBackColor = True
        '
        'CheckBox_AutoConnectOnOpen
        '
        Me.CheckBox_AutoConnectOnOpen.AutoSize = True
        Me.CheckBox_AutoConnectOnOpen.Location = New System.Drawing.Point(329, 21)
        Me.CheckBox_AutoConnectOnOpen.Name = "CheckBox_AutoConnectOnOpen"
        Me.CheckBox_AutoConnectOnOpen.Size = New System.Drawing.Size(133, 17)
        Me.CheckBox_AutoConnectOnOpen.TabIndex = 8
        Me.CheckBox_AutoConnectOnOpen.Text = "Auto Connect On Start"
        Me.CheckBox_AutoConnectOnOpen.UseVisualStyleBackColor = True
        '
        'TabPage_Help
        '
        Me.TabPage_Help.Controls.Add(Me.RichTextBox_Help)
        Me.TabPage_Help.Location = New System.Drawing.Point(4, 22)
        Me.TabPage_Help.Name = "TabPage_Help"
        Me.TabPage_Help.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.TabPage_Help.Size = New System.Drawing.Size(1205, 648)
        Me.TabPage_Help.TabIndex = 2
        Me.TabPage_Help.Text = "Help"
        Me.TabPage_Help.UseVisualStyleBackColor = True
        '
        'RichTextBox_Help
        '
        Me.RichTextBox_Help.Location = New System.Drawing.Point(6, 6)
        Me.RichTextBox_Help.Name = "RichTextBox_Help"
        Me.RichTextBox_Help.Size = New System.Drawing.Size(493, 636)
        Me.RichTextBox_Help.TabIndex = 0
        Me.RichTextBox_Help.Text = resources.GetString("RichTextBox_Help.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 677)
        Me.Controls.Add(Me.TabControl)
        Me.Name = "Form1"
        Me.Text = "TcJoy by Jensen Mechatronics"
        Me.TabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvProgramData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage_LiveStatus.ResumeLayout(False)
        Me.TabPage_LiveStatus.PerformLayout()
        Me.TabPage_Connection.ResumeLayout(False)
        Me.GroupBox_Controller.ResumeLayout(False)
        Me.GroupBox_Controller.PerformLayout()
        Me.GroupBox_PLC.ResumeLayout(False)
        Me.GroupBox_PLC.PerformLayout()
        Me.TabPage_Help.ResumeLayout(False)
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
    Friend WithEvents lblAutoSeqPause As Label
    Friend WithEvents lblManStepMode As Label
    Friend WithEvents lblAutoSeq As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txtUserPos As TextBox
    Friend WithEvents Label24 As Label
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
    Friend WithEvents btnJumpToPos As Button
    Friend WithEvents btnAutoStep As Button
    Friend WithEvents btnStep As Button
    Friend WithEvents Button9 As Button
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
    Friend WithEvents txtTime As TextBox
    Friend WithEvents txtPosTime As TextBox
    Friend WithEvents dgvProgramData As DataGridView
    Friend WithEvents PositionNumber As DataGridViewTextBoxColumn
    Friend WithEvents Position As DataGridViewTextBoxColumn
    Friend WithEvents Speed As DataGridViewTextBoxColumn
    Friend WithEvents Jerk As DataGridViewTextBoxColumn
    Friend WithEvents Accel As DataGridViewTextBoxColumn
    Friend WithEvents Decel As DataGridViewTextBoxColumn
    Friend WithEvents Dwell As DataGridViewTextBoxColumn
    Friend WithEvents SameDeCel As DataGridViewCheckBoxColumn
    Friend WithEvents txtTargetPos As TextBox
    Friend WithEvents txtCurrPos As TextBox
End Class
