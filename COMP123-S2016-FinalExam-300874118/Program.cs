using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            FirstForm = new GenerateNameForm();
            SplashScrene = new SplashScreneForm();
            Application.Run(SplashScrene);
        }
    }
}
