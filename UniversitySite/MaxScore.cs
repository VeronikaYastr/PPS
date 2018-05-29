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
    public partial class MaxScore : Form
    {
        public MaxScore(int year)
        {
            InitializeComponent();
            ShowSpecialityMaxScore(year);
        }

        private void MaxScore_Load(object sender, EventArgs e)
        {
            
        }

        /// 
        /// <param name="year"></param>
        public void ShowSpecialityMaxScore(int year)
        {
            try
            {
                string sqlQuery = "SELECT SNAME FROM 'SUBJECT' INNER JOIN 'SPECIALITY' " +
                "ON SPECIALID=SPECID  WHERE PASSINGSCORE = " +
                "(SELECT max(PASSINGSCORE) FROM 'SUBJECT' WHERE SUBJNAME=\"mathematics\" AND YEAR = " + year +
                ") AND YEAR = " + year + ";";

                SQLiteDataReader reader = GetInfo.ExecuteSql(sqlQuery);
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        labelSpec.Text = reader.GetValue(0).ToString();
                    }
                }
                else
                {
                    labelSpec.Text = "No such speciality";
                }
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Oops...Something went wrong:(" + ex.ToString());
            }
}

        private void MaxScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = Application.OpenForms["RequestFindForm"]; ;
            form1.Show();
        }
    }
}
