using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace UniversitySite
{
    public partial class PlanOfAdmission : Form
    {
        public PlanOfAdmission(FormOfEducation edForm, int year)
        {
            InitializeComponent();
            ShowPlanOfAdmission(year, edForm);
        }

        private void PlanOfAdmission_Load(object sender, EventArgs e)
        {

        }

        /// 
        /// <param name="year"></param>
        /// <param name="form"></param>
        public void ShowPlanOfAdmission(int year, FormOfEducation form)
        {
            try
            {
                SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= C:\\Users\\Veronika\\Desktop\\programming\\labs_4\\PPS\\UniversitySite\\Database.db;Version=3;");
                m_dbConn.Open();
                
                string sqlQuery = "SELECT SNAME,AMOUNT FROM 'PLANOFADMISSION'" +
                " INNER JOIN 'SPECIALITY' ON SPECIID=SPECID " +
                " WHERE PLAN_YEAR = " + year + " AND FORMID = " + (int)form + ";";
                SQLiteCommand comm = new SQLiteCommand(sqlQuery, m_dbConn);
                SQLiteDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridPlan.Rows.Add(new object[] {
                            reader.GetValue(0).ToString(),
                            reader.GetValue(1).ToString(),
                        });
                    }
                }
                else
                {
                    dataGridPlan.Visible = false;
                    label2.Text = "Such information is not found!";
                }
                m_dbConn.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Oops...Something went wrong:(" + ex.ToString());
            }
        }

        private void PlanOfAdmission_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["RequestFindForm"]; ;
            form1.Close();
        }
    }
}
