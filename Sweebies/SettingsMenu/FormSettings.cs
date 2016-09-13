using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweebies
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void buttonLaunch_Click(object sender, EventArgs e)
        {

            string sweebieName;
            int sweebieNum;

            if (SweebieName.Text.Length <= 0)
            {
                showDataValidationWarning("Sweebie Name must not be empty");
                return;
            }
            try
            {
                sweebieNum = int.Parse(SweebieNumber.Text);
            }catch(FormatException exc)
            {
                showDataValidationWarning("Sweebie Number must be a number greater than 0");
                return;
            }
            if(sweebieNum <= 0)
            {
                showDataValidationWarning("Sweebie Number must be greater than 0");
                return;
            }


            sweebieName = SweebieName.Text;

            if (sweebieName == "empty")
            {
                sweebieName = "smartass";
            }

            this.Hide();
            SweebiesDisplay SwbDsp = new SweebiesDisplay(sweebieName, sweebieNum);
            SwbDsp.FormClosed += SwbDsp_FormClosed;
            SwbDsp.ShowDialog();
        }

        private void SwbDsp_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Show();
            this.Close();
        }

        private void showDataValidationWarning(string warning)
        {
            MessageBox.Show(warning,
                "Important Note",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }
    }
}
