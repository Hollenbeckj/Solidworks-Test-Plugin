using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Test_Add_in_SW_2017_JH
{
    // set program I.D to the variable SW_TASKPANE_PROGID in the main class
    //solidworks needs this line so that it can search for this class using COM which was made exposable in the class properties
    [ProgId(Main.SWTASKPANE_PROGID)]

    public partial class TestAddInHostUI : UserControl
    {
        public TestAddInHostUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
