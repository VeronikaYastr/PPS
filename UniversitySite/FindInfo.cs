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
    public partial class FindInfo : Form
    {
        public FindInfo()
        {
            InitializeComponent();
        }

        private void FindInfo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["ChooseAction"]; ;
            form1.Close();
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            FormOfEducation form = FormOfEducation.partTimeForm;
            if (!CheckingInfo.CheckCorectness(textYear.Text))
            {
                MessageBox.Show("Invalid year!");
            }
            else
            {
                if (RBExtramural.Checked)
                    form = FormOfEducation.extramuralForm;
                else if (RBIntramural.Checked)
                    form = FormOfEducation.intramuralForm;

                int year = Int32.Parse(textYear.Text);

                this.Hide();
                RequestFindForm reqForm = new RequestFindForm(form, year);
                reqForm.Show();
            }
        }

        private void FindInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
