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
    public partial class RequestFindForm : Form
    {
        FormOfEducation edForm = FormOfEducation.intramuralForm;
        int year = 0;

        public RequestFindForm(FormOfEducation form, int reqYear)
        {
            InitializeComponent();
            edForm = form;
            year = reqYear;
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            if(RBLeaders.Checked)
            {
                Hide();
                ListOfLeaders form = new ListOfLeaders(year);
                form.Show();
            }
            if(RBSpecialities.Checked || RBPlan.Checked)
            {
                Hide();
                PlanOfAdmission form = new PlanOfAdmission(edForm, year);
                form.Show();
            }
            if (RBMaxScore.Checked)
            {
                Hide();
                MaxScore form = new MaxScore(year);
                form.Show();
            }
        }

        private void RequestFindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = Application.OpenForms["FindInfo"]; ;
            form1.Show();
        }

        private void RequestFindForm_Load(object sender, EventArgs e)
        {

        }
    }
}
