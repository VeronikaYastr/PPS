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
    public partial class ListOfLeaders : Form
    {
        public ListOfLeaders(int reqYear)
        {
            InitializeComponent();
            ShowListOfLeaders(reqYear);
        }

        private void ListOfLeaders_Load(object sender, EventArgs e)
        {

        }

        /// 
        /// <param name="year"></param>
        public void ShowListOfLeaders(int year)
        {
            try
            {
                SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= C:\\Users\\Veronika\\Desktop\\programming\\labs_4\\PPS\\UniversitySite\\Database.db;Version=3;");
                m_dbConn.Open();

                string sqlQuery = "SELECT NAME,SCDEGREE,SCRANK,STARTDATE,SNAME,FACNAME,DEPNAME FROM 'LEADER'"+ 
                " INNER JOIN 'SPECIALITY' ON SID=SPECID INNER JOIN 'FACULTY' ON FAID=FACID " +
                "INNER JOIN 'DEPARTMENT' ON DEPRID=DEPID" +
                " WHERE STARTDATE <= " + year + " AND SCDEGREE = \"doctor\" AND SCRANK=\"professor\";";
                SQLiteCommand comm = new SQLiteCommand(sqlQuery, m_dbConn);
                SQLiteDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        dataGridLeaders.Rows.Add(new object[] {
                            reader.GetValue(0).ToString(),  
                            reader.GetValue(1).ToString(),
                            reader.GetValue(2).ToString(),
                            reader.GetValue(3).ToString(),
                            reader.GetValue(4).ToString(),
                            reader.GetValue(5).ToString(),
                            reader.GetValue(6).ToString()
                        });
                    }
                }
                else
                {
                    dataGridLeaders.Visible = false;
                    label2.Text = "Such information is not found!";
                }

                m_dbConn.Close();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Oops...Something went wrong:(" + ex.ToString());
            }
        }

        private void ListOfLeaders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = System.Windows.Forms.Application.OpenForms["RequestFindForm"]; ;
            form1.Close();
        }
    }
}
