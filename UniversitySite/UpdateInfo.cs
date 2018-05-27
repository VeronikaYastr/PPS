using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversitySite
{
    public partial class UpdateInfo : Form
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void ButtonUpdLeader_Click(object sender, EventArgs e)
        {
            string name = textBoxLeader.Text;
            string year = textBoxYear.Text;

            if (name.Length != 0 && CheckingInfo.CheckCorectness(year))
            {
                if (UpdatingInformation.UpdateHistory(name, Int32.Parse(year)))
                    MessageBox.Show("Successfully update!");
                else
                    MessageBox.Show("Oops... Something went wrong! Try again.");
            }
            else
                MessageBox.Show("Incorrect info!");
            
        }

        private void UpdateInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["ChooseAction"]; ;
            form1.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxSubj.Text;
            string score = textBoxScore.Text;

            if (name.Length != 0 && score.Length != 0)
            {
                if (UpdatingInformation.UpdateMaxScore(name, Int32.Parse(score)))
                    MessageBox.Show("Successfully update!");
                else
                    MessageBox.Show("Oops... Something went wrong! Try again.");
            }
            else
                MessageBox.Show("Incorrect info!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBoxSpec.Text;
            string amount = textBoxAmount.Text;

            if (name.Length != 0 && amount.Length != 0)
            {
                if (UpdatingInformation.UpdatePlanOfAdmission(name, Int32.Parse(amount)))
                    MessageBox.Show("Successfully update!");
                else
                    MessageBox.Show("Oops... Something went wrong! Try again.");
            }
            else
                MessageBox.Show("Incorrect info!");
        }
    }
}
