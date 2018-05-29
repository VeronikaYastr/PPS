using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace UniversitySite
{
    public static class GetInfo
    {
        public static SQLiteDataReader ExecuteSql(string sql)
        {
            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= Database.db;Version=3;");
            m_dbConn.Open();

            SQLiteCommand comm = new SQLiteCommand(sql, m_dbConn);
            SQLiteDataReader reader = comm.ExecuteReader();

            return reader;
        }

        public static bool ExecuteReadSql(string sql)
        {
            try
            {
                SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= Database.db;Version=3;");
                m_dbConn.Open();

                SQLiteCommand comm = new SQLiteCommand(sql, m_dbConn);
                comm.ExecuteNonQuery();
            }
            catch(SQLiteException ex)
            {
                return false;
            }

            return true;
        }

        public static int DepMaxCode()
        {
            string sql = "SELECT max(DEPCODE) FROM 'DEPARTMENT';";
            SQLiteDataReader reader = ExecuteSql(sql);

            int maxCode = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxCode = Int32.Parse(reader.GetValue(0).ToString());
                }
            }

            return maxCode;
        }

        public static int SpecMaxCode()
        {
            string sql = "SELECT max(SCODE) FROM 'SPECIALITY';";
            SQLiteDataReader reader = ExecuteSql(sql);

            int maxCode = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxCode = Int32.Parse(reader.GetValue(0).ToString());
                }
            }

            return maxCode;
        }

        public static int FacMaxCode()
        {
            string sql = "SELECT max(FACCODE) FROM 'FACULTY';";
            SQLiteDataReader reader = ExecuteSql(sql);

            int maxCode = 0;
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    maxCode = Int32.Parse(reader.GetValue(0).ToString());
                }
            }

            return maxCode;
        }
    }
}
