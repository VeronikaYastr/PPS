///////////////////////////////////////////////////////////
//  ShowingResult.cs
//  Implementation of the Class <<boundary>> ShowingResult
//  Generated by Enterprise Architect
//  Created on:      23-���-2018 13:53:54
//  Original author: Veronika
///////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace UniversitySite {
	/// <summary>
	/// ���������� �������� ��� ���������� ���������� ��������
	/// </summary>
	public class ShowingResult {

		public string ShowFail(){
            return "Failed! Try again.";
		}

		public string ShowSuccess(){
            return "Operation completed successfully!";
        }

	}//end <<boundary>> ShowingResult

    /// <summary>
	/// ����� ���������� �� �����
	/// </summary>
	public class ShowingInfo
    {

        /// 
        /// <param name="year"></param>
        public void showListOfLeaders(int year)
        {

        }

        /// 
        /// <param name="year"></param>
        /// <param name="form"></param>
        public void showListOfSpecialties(int year, FormOfEducation form)
        {

        }

        /// 
        /// <param name="year"></param>
        /// <param name="form"></param>
        public void showPlanOfAdmission(int year, FormOfEducation form)
        {

        }

        /// 
        /// <param name="year"></param>
        public void showSpecialityMaxScore(int year)
        {

        }

    }//end <<boundary>> ShowingInfo

}