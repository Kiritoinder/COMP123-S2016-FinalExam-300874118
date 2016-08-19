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
 * Description: This class generate names for the users.
 * Version: 0.0.1
 * DateCreated: August 19,2016
 * DateModified:
*/
namespace COMP123_S2016_FinalExam_300874118
{
    public partial class GenerateNameForm : Form
    {
        Random random = new Random();
        public GenerateNameForm()
        {
            InitializeComponent();
        }

        //Added next button to hide this form and show AbilityGeneratorForm 
        private void NextButton_Click(object sender, EventArgs e)
        {
            Character character = new Character();
            character.FirstName = FirstNameTextBox.Text;
            character.LastName = LastNameTextBox.Text;


            //Next form
            AbilityGeneratorForm SecondForm = new AbilityGeneratorForm();
            SecondForm.Show(); // opens the next form i.e. AbilityGeneratorForm
            this.Hide(); //Hides this form
        }

        private void FirstNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FirstNameTextBox.Text = string.Empty;
            foreach(string value in FirstNameListBox.SelectedItems)
            {
                FirstNameTextBox.Text = value.ToString();
            }
        }

        private void LastNameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LastNameTextBox.Text = string.Empty;
            foreach (string value in LastNameListBox.SelectedItems)
            {
                LastNameTextBox.Text = value.ToString();
            }
        }
    }
}
