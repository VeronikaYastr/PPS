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
    public partial class ChooseAction : Form
    {
        User user = null;
        public ChooseAction(User curUser)
        {
            InitializeComponent();
            user = curUser;
        }

        private void RButtonAdd_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ButtonChoose_Click(object sender, EventArgs e)
        {
            TypeOfRequest req = TypeOfRequest.getInfo;
            if (RButtonAdd.Checked)
            {
                req = TypeOfRequest.addInfo;
            }
            else if (RButtonUpdate.Checked)
            {
                req = TypeOfRequest.updateInfo;
            }

            if (!CheckingInfo.CheckAccess(user.Type, req))
                MessageBox.Show("Access is denied!");
            else
            {
                switch (req)
                {
                    case TypeOfRequest.getInfo:
                        {
                            this.Hide();
                            FindInfo form = new FindInfo();
                            form.Show();
                            break;
                        }
                    case TypeOfRequest.addInfo:
                        {
                            this.Hide();
                            AddInfo form = new AddInfo();
                            form.Show();
                            break;
                        }
                    case TypeOfRequest.updateInfo:
                        {
                            this.Hide();
                            UpdateInfo form = new UpdateInfo();
                            form.Show();
                            break;
                        }
                    default: break;
                }
            }
        }

        private void ChooseAction_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["LoginForm"]; ;
            form1.Close();
        }

        private void ChooseAction_Load(object sender, EventArgs e)
        {

        }
    }
}
