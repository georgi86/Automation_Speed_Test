﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;
using UtilityFunctions;


namespace SpeedTests
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The ActionTwo recording.
    /// </summary>
    [TestModule("f7a6d801-64e9-42c3-8a89-852c897edcf1", ModuleType.Recording, 1)]
    public partial class ActionTwo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the SpeedTestsRepository repository.
        /// </summary>
        public static SpeedTestsRepository repo = SpeedTestsRepository.Instance;

        static ActionTwo instance = new ActionTwo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ActionTwo()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ActionTwo Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.0")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 400;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 663;11.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.TitleBar.Click("663;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(1));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(2));
            Keyboard.Press("f");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'o'.", new RecordItemIndex(3));
            Keyboard.Press("o");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'OpenSnapXRoutine.FileNameField' at 202;5.", repo.OpenSnapXRoutine.FileNameFieldInfo, new RecordItemIndex(4));
            repo.OpenSnapXRoutine.FileNameField.DoubleClick("202;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'OpenSnapXRoutine.FileNameField'.", repo.OpenSnapXRoutine.FileNameFieldInfo, new RecordItemIndex(5));
            repo.OpenSnapXRoutine.FileNameField.PressKeys("{Delete}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Routines\\SpeedTwo.mxy'.", new RecordItemIndex(6));
            Keyboard.Press("D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Routines\\SpeedTwo.mxy");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'OpenSnapXRoutine.FileNameField'.", repo.OpenSnapXRoutine.FileNameFieldInfo, new RecordItemIndex(7));
            repo.OpenSnapXRoutine.FileNameField.PressKeys("{Return}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.TitleBar' at 668;9.", repo.SnapXUntitled.TitleBarInfo, new RecordItemIndex(8));
            repo.SnapXUntitled.TitleBar.Click("668;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LMenu}'.", new RecordItemIndex(9));
            Keyboard.Press("{LMenu}");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'f'.", new RecordItemIndex(10));
            Keyboard.Press("f");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'r'.", new RecordItemIndex(11));
            Keyboard.Press("r");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonOK' at Center.", repo.SnapXUntitled.ButtonOKInfo, new RecordItemIndex(12));
            repo.SnapXUntitled.ButtonOK.Click("45;10");
            Delay.Milliseconds(200);

            //Report.Log(ReportLevel.Info, "Wait", "Waiting 4m for item 'SnapXUntitled.ReMeasure' to exist.", repo.SnapXUntitled.ReMeasureInfo, new ActionTimeout(240000), new RecordItemIndex(13));
            //repo.SnapXUntitled.ReMeasureInfo.WaitForExists(240000);
            //Delay.Milliseconds(4000);

            repo.SnapXUntitled.ReMeasure.Focus();
            Delay.Milliseconds(200);

            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports\\ElapsedTimeTwo.PRT' with arguments '' in normal mode.", new RecordItemIndex(14));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports\\ElapsedTimeTwo.PRT", "", "D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ElapsedTimeTwoPRTNotepad'.", repo.ElapsedTimeTwoPRTNotepad.SelfInfo, new RecordItemIndex(15));
            repo.ElapsedTimeTwoPRTNotepad.Self.Maximize();
            Delay.Milliseconds(100);

            int iHardcodedTwo = 36;
            string ResultRoutineTwo = ((SpeedTests.SpeedTestsRepositoryFolders.ElapsedTimeTwoPRTNotepadAppFolder)repo.ElapsedTimeTwoPRTNotepad.SelfInfo.ParentFolder).Text15.TextValue;
            UtilityRun.RunEx(iHardcodedTwo, ResultRoutineTwo);
            Delay.Milliseconds(100);


            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ElapsedTimeTwoPRTNotepad.Text15'.", repo.ElapsedTimeTwoPRTNotepad.Text15Info, new RecordItemIndex(17));
            Host.Current.CloseApplication(repo.ElapsedTimeTwoPRTNotepad.Text15, new Duration(0));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(18));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ReMeasure' at Center.", repo.SnapXUntitled.ReMeasureInfo, new RecordItemIndex(19));
            repo.SnapXUntitled.ReMeasure.Click();
            Delay.Milliseconds(200);

            //Report.Log(ReportLevel.Info, "Wait", "Waiting 4m for item 'SnapXUntitled.Finish' to exist.", repo.SnapXUntitled.FinishInfo, new ActionTimeout(240000), new RecordItemIndex(20));
            //repo.SnapXUntitled.FinishInfo.WaitForExists(240000);
            //Delay.Milliseconds(2000);

            repo.SnapXUntitled.Finish.Focus();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Application", "Run application 'D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports\\ElapsedTimeTwo.PRT' with arguments '' in normal mode.", new RecordItemIndex(21));
            Host.Local.RunApplication("D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports\\ElapsedTimeTwo.PRT", "", "D:\\Joro\\GIT_Automations\\AutomationSpeedTests\\Reports", false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke Action", "Invoking Maximize() on item 'ElapsedTimeTwoPRTNotepad'.", repo.ElapsedTimeTwoPRTNotepad.SelfInfo, new RecordItemIndex(22));
            repo.ElapsedTimeTwoPRTNotepad.Self.Maximize();
            Delay.Milliseconds(100);



            iHardcodedTwo = 36;
            string ResultRemeasureRoutineTwo = ((SpeedTests.SpeedTestsRepositoryFolders.ElapsedTimeTwoPRTNotepadAppFolder)repo.ElapsedTimeTwoPRTNotepad.SelfInfo.ParentFolder).Text15.TextValue;
            UtilityRun.RunEx(iHardcodedTwo, ResultRemeasureRoutineTwo);
            Delay.Milliseconds(100);


            Report.Log(ReportLevel.Info, "Application", "Closing application containing item 'ElapsedTimeTwoPRTNotepad.Text15'.", repo.ElapsedTimeTwoPRTNotepad.Text15Info, new RecordItemIndex(24));
            Host.Current.CloseApplication(repo.ElapsedTimeTwoPRTNotepad.Text15, new Duration(0));
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 4s.", new RecordItemIndex(25));
            Delay.Duration(4000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.Finish' at Center.", repo.SnapXUntitled.FinishInfo, new RecordItemIndex(26));
            repo.SnapXUntitled.Finish.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 6s.", new RecordItemIndex(27));
            Delay.Duration(6000, false);

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'SnapXUntitled.ButtonGo' at 47;149.", repo.SnapXUntitled.ButtonGoInfo, new RecordItemIndex(0));
            repo.SnapXUntitled.ButtonGo.Click("47;149");
            Delay.Milliseconds(200);

        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
