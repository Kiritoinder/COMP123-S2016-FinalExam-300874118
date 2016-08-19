using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**
 * App Name : Create Avatar
 * Author: Inderjeet Singh
 * StudentNumber: 300874118
 * Description: A splash screne form for the application
 * Version: 0.0.1
 * DateCreated: August 19,2016
 * DateModified:
 */
namespace COMP123_S2016_FinalExam_300874118
{
    //This is the first form of my application i.e. splashscrene
    
    public partial class SplashScreneForm : Form
    {
        //Main method
        //making alias for GenerateNameForm
        public GenerateNameForm FirstForm = Program.FirstForm;
        //Initializer
        public SplashScreneForm()
        {
            InitializeComponent();
        }

        // Timer tick event
        private void timer_Tick(object sender, EventArgs e)
        {
            //Showing the generate name form and hiding this form
            timer.Enabled = false;
            FirstForm.Show();
            this.Hide();
        }
    }
}
