Imports TwinCAT
Imports TwinCAT.Ads
Imports System.ComponentModel

Module PLC_IO_Polling

    Dim debug = False
    Public WithEvents BackgroundWorker1 As BackgroundWorker

    ''' <summary>
    ''' Start off the background worker, which will configure itself and then run.
    ''' </summary>
    Public Sub StartWorker()

        ' Start worker with relevant data
        BackgroundWorker1 = New BackgroundWorker()
        BackgroundWorker1.WorkerSupportsCancellation = True
        BackgroundWorker1.RunWorkerAsync(HMI.BgTaskData)
        If debug Then Console.WriteLine("BG Worker Started, netID is " + HMI.BgTaskData.NetID)

    End Sub

    ''' <summary>
    ''' Start up the IO poller for the Twincat ADS data
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub BackgroundWorker1_DoWork(ByVal sender As System.Object,
                                         ByVal e As System.ComponentModel.DoWorkEventArgs) _
                                         Handles BackgroundWorker1.DoWork

        'Dim Stopwatch As Stopwatch = Stopwatch.StartNew()
        Dim iState As Integer = 0
        Dim symbol As ITcAdsSymbol ' working symbol. 
        Dim debug = False

        ' Do writes
        For Each tag As HMI.DataTag In e.Argument.TagList
            If tag.IsWritten Then



                Try
                    If debug Then Console.WriteLine("Writing Tag: " + tag.TagName + " to value: " + tag.Value.ToString)
                    ' Get data type and other information from PLC
                    symbol = e.Argument.ADS_Connection.AdsClient.ReadSymbolInfo(tag.TagName)
                    ' Write value to PLC
                    e.Argument.ADS_Connection.AdsClient.WriteSymbol(symbol, tag.Value)
                    e.Argument.IsConnected = e.Argument.ADS_Connection.AdsClient.IsConnected

                Catch ex As Exception
                    Console.WriteLine("Could not get symbol or write tag: " + tag.TagName + " ex: " + ex.Message)
                    e.Argument.IsConnected = False
                    BackgroundWorker1.CancelAsync()
                End Try

            End If
        Next

    End Sub

    Public Sub AddVariablesToList(ByRef BgTaskData As HMI.TaskData)

        Dim fbPath As String
        fbPath = HMI.TextBox_TcJoyPath.Text

        ' Note:  Data types not used, but leaving it here in case it is useful later.

        ' Add tags to our data object, ones that we write to TwinCAT (VB TO PLC)

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".bHeartBeatToggle", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iADSWatchdogMS", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iADSWatchdogDeadDurationMS", AdsDatatypeId.ADST_INT32, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".bControllerConnected", AdsDatatypeId.ADST_BIT, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".Start_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".Back_Button", AdsDatatypeId.ADST_BIT, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".A_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".B_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".X_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".Y_Button", AdsDatatypeId.ADST_BIT, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".LeftShoulder_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".RightShoulder_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".LeftStick_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".RightStick_Button", AdsDatatypeId.ADST_BIT, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".DPad_Up_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".DPad_Left_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".DPad_Right_Button", AdsDatatypeId.ADST_BIT, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".DPad_Down_Button", AdsDatatypeId.ADST_BIT, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iLeftStick_X_Axis", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iLeftStick_Y_Axis", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iRightStick_X_Axis", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iRightStick_Y_Axis", AdsDatatypeId.ADST_INT32, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iLeftTrigger_Axis", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iRightTrigger_Axis", AdsDatatypeId.ADST_INT32, False, True))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".sBatteryInfo", AdsDatatypeId.ADST_STRING, False, True))

        'custom tags
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HmiButtonData0", AdsDatatypeId.ADST_INT32, False, True))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HmiButtonData1", AdsDatatypeId.ADST_INT32, False, True))


        ' Add tags to our data object, ones that read from TwinCAT From PLC To VB
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HmiBoolDword0", AdsDatatypeId.ADST_INT32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HmiBoolDword1", AdsDatatypeId.ADST_INT32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo1_Pos", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo1_Torque", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo1_Vel", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo1_Force", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo2_Pos", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo2_Torque", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo2_Vel", AdsDatatypeId.ADST_REAL32, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag("Global_variables.HMI_Servo2_Force", AdsDatatypeId.ADST_REAL32, True, False))

        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".bIsActive", AdsDatatypeId.ADST_BIT, True, False))
        BgTaskData.TagList.Add(New HMI.DataTag(fbPath + ".iUpdateRateMS", AdsDatatypeId.ADST_BIT, True, False))

    End Sub




End Module
