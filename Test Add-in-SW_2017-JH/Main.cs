using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swpublished;
using System;
using System.IO;
//system information class
using System.Windows.Forms;
//using CsvHelper.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Test_Add_in_SW_2017_JH
{
    public class Main : ISwAddin
    {
        //Created by Joshua Hollenbeck - 1/29/2018
        //copywrite Josh Hollenbeck and its contributors
        //Property of Trinity Woodworks and Joshua Hollenbeck
        // - [THIS IS A TEST PLUGIN FOR SOLIDWORKS 2017 SP-5]
        //Credit to Josh Close for the CsvHelper library
        //https://github.com/JoshClose/CsvHelper


        // MAIN ADD IN SECTION - USING ISwAddin will establish communication with solidworks to enable and disable the plugin when solidworks is running
        #region Private Setup Members
        
        // cookie initializer
        private int mSwCookie;

        //User interface initializer 
        private TaskpaneViewHandler mTaskpaneView;

        //variable for the User interface that will run inside solidworks
        private TestAddInHostUI mtestAddInHostUI;

        //Instance of Solidworks Application
        private SldWorks mSolidWorksAppInstance;

        // allows for solidworks to recognize this application from the list of plugins potentially installed in the software
        public const string SWTASKPANE_PROGID = "TEST_APP_JH";

        #endregion

        #region Solidworks Add-in Callbacks

        //This section is called everytime solidworks is opened

        public bool ConnectToSW(object ThisSW, int Cookie)
        {
            //throw new System.NotImplementedException();

            // Store a reference to the instance of solidworks running
            mSolidWorksAppInstance = (SldWorks)ThisSW;

            // Store cookie I.D
            mSwCookie = Cookie;

            // call back info
            var callBackInfo = mSolidWorksAppInstance.SetAddinCallbackInfo2(0, this, mSwCookie);

            // fucntion calls UI to load
            LoadUI();

            //return if successfull
            return true;
        }

        //This section is called everytime soldiworks is closed 

        public bool DisconnectFromSW()
        {
            //throw new System.NotImplementedException();
            UnloadUI();

            //return if successfull
            return true;
        }

        #endregion

        #region Build UI

        // build user interface on runtime
        private void LoadUI()
        {
            //throw new NotImplementedException();

            // Find location of the programs Icon
            var iconPath = Path.Combine(Path.GetDirectoryName(typeof(Main).Assembly.CodeBase).Replace(@"file:\",""), "rsz_sw_cube_red.PNG");

            //create a taskpane in solidworks

            //mTaskpaneView = mSolidWorksAppInstance.CreateTaskpaneView2(iconPath, "");

            //Load UI into SW taskpane
            //mTaskpaneHost = (TestAddInHostUI)mTaskpaneView.AddControl(Main.SWTASKPANE_PROGID, string.Empty);
        }

        #endregion

        #region Deconstruct UI

        // Remove from memory once closed
        private void UnloadUI()
        {
            //throw new NotImplementedException();
        }

        // Testing Github upload Here

        #endregion
    }
}
