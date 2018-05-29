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
                string sqlQuery = "SELECT NAME,SCDEGREE,SCRANK,STARTDATE,SNAME,FACNAME,DEPNAME FROM 'LEADER'"+ 
                " INNER JOIN 'SPECIALITY' ON SID=SPECID INNER JOIN 'FACULTY' ON FAID=FACID " +
                "INNER JOIN 'DEPARTMENT' ON DEPRID=DEPID" +
                " WHERE STARTDATE <= " + year + " AND SCDEGREE = \"doctor\" AND SCRANK=\"professor\";";

                SQLiteDataReader reader = GetInfo.ExecuteSql(sqlQuery);
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
                
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Oops...Something went wrong:(" + ex.ToString());
            }
        }

        private void ListOfLeaders_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form form1 = Application.OpenForms["RequestFindForm"]; ;
            form1.Show();
        }
    }
}
