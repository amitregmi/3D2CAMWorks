using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using CAMWORKSLib;

namespace _3D2CAMWorks
{
    public partial class Form1 : Form
    {
        SldWorks swApp;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_CAM_Calc_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Initialization SolidWorks
                Type swType = Type.GetTypeFromProgID("SldWorks.Application");
                SldWorks swApp = (SldWorks)Activator.CreateInstance(swType);
                //Initialization CAMWorks
                CWApp cwAPP = new CWApp();
                // Extract Machinable Features by AFR
                ICWDoc3 cwActiveDoc = cwAPP.IGetActiveDoc();
                cwActiveDoc.ExtractMachinableFeatures();
                // Generate Operation                
                cwAPP.ActiveDocGOP(1);
                // Generate Tool Path               
                ICWPartDoc cwPartDoc = (ICWPartDoc)cwActiveDoc;
                cwPartDoc.GenerateToolpath();
                // Simulation
                cwAPP.ActiveDocLaunchSimulation();
                cwAPP.ActiveDocPlaySimulation();
            }
            catch
            {

            }

        }
    }
}
