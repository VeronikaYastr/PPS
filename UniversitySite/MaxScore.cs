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
            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= C:\\Users\\Veronika\\Desktop\\programming\\labs_4\\PPS\\UniversitySite\\Database.db;Version=3;");
            m_dbConn.Open();

            try
            {
                string sqlQuery = "SELECT SNAME FROM 'SUBJECT' INNER JOIN 'SPECIALITY' " +
                "ON SPECIALID=SPECID  WHERE PASSINGSCORE = " +
                "(SELECT max(PASSINGSCORE) FROM 'SUBJECT' WHERE SUBJNAME=\"mathematics\" AND YEAR = " + year +
                ") AND YEAR = " + year + ";";
                
                SQLiteCommand comm = new SQLiteCommand(sqlQuery, m_dbConn);
                SQLiteDataReader reader = comm.ExecuteReader();
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

                m_dbConn.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Oops...Something went wrong:(" + ex.ToString());
            }
}

        private void MaxScore_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["RequestFindForm"]; ;
            form1.Close();
        }
    }
}
