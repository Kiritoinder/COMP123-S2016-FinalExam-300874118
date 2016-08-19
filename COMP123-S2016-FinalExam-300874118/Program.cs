using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//Class modified by Inderjeet Singh
// Student I.D- 300874118
// Date Modified: August 19,2016
namespace COMP123_S2016_FinalExam_300874118
{
    public static class Program
    {
        public static SplashScreneForm SplashScrene;
        public static GenerateNameForm FirstForm;
        public static Character character = new Character();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Start splash screne first
            FirstForm = new GenerateNameForm();
            SplashScrene = new SplashScreneForm();
            Application.Run(SplashScrene);
        }
    }
}
