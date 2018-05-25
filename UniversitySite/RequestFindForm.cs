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

        }

        private void RequestFindForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["FindInfo"]; ;
            form1.Close();
        }

        private void RequestFindForm_Load(object sender, EventArgs e)
        {

        }
    }
}
