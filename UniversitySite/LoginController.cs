///////////////////////////////////////////////////////////
//  LoginController.cs
//  Implementation of the Class <<controller>> LoginController
//  Generated by Enterprise Architect
//  Created on:      23-���-2018 13:49:22
//  Original author: Veronika
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Data.SQLite;
using System.Data;

namespace UniversitySite {
	public static class  LoginController {
       
		/// 
		/// <param name="login"></param>
		private static bool CheckLogin(string login){
            int maxLen = 20;

            return (login.Length != 0 && login.Length <= maxLen);
		}

		/// 
		/// <param name="password"></param>
		private static bool CheckPassword(string password){
            int maxLen = 20;

            return (password.Length != 0 && password.Length <= maxLen);
        }

        public static User MakeUser(string login, string password)
        {
            SQLiteConnection m_dbConn = new SQLiteConnection("Data Source= C:\\Users\\Veronika\\Desktop\\programming\\labs_4\\PPS\\UniversitySite\\Database.db;Version=3;");
            m_dbConn.Open();

            User user = null;
            string sqlQuery = "SELECT TypeID FROM 'USER' WHERE LOGIN =\"" + login + "\"";
            sqlQuery += " AND PASSWORD=\"" + password + "\";";
            SQLiteCommand comm = new SQLiteCommand(sqlQuery, m_dbConn);
            SQLiteDataReader reader = comm.ExecuteReader();

            string str = "";

            try
            {
                if (CheckLogin(login) && CheckPassword(password))
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                            str = reader[0].ToString();
                    }
                    m_dbConn.Close();

                    if (str.Length == 0)
                        return null;

                    int type = Int32.Parse(str);

                    user = new User(login, password, type);
                    return user;
                }
            }
            catch (SQLiteException ex)
            {
                
            }

            return user;
        }

	}//end <<controller>> LoginController

}//end namespace LoginClassDiagram