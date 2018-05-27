using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySite
{

    public enum FormOfEducation : int
    {

        intramuralForm = 1,
        extramuralForm,
        partTimeForm

    }//end FormOfEducation

    /// <summary>
    /// Возможные значения типа пользователя после входа в систему
    /// </summary>
    public enum TypeOfUser : int
    {

        administrator = 1,
        applicant,
        university_worker

    }//end TypeOfUser

    /// <summary>
    /// Возможные виды запросов
    /// </summary>
    public enum TypeOfRequest : int
    {

        getInfo = 1,
        addInfo,
        updateInfo

    }//end TypeOfRequest

    /// <summary>
    /// факультет
    /// </summary>
    public class Faculty
    {
        public int Code { get; private set; }
        public String Name { get; private set; }
        public string ShortName { get; private set; }

        public Faculty(int code, string name)
        {
            Code = code;
            Name = name;
            ShortName = name.Substring(0, 2);
        }

    }//end <<entity>> Faculty

    /// <summary>
    /// кафедра
    /// </summary>
    public class Department
    {
        public int Code { get; private set; }
        public String Name { get; private set; }
        public string ShortName { get; private set; }

        public Department(int code, string name)
        {
            Code = code;
            Name = name;
            ShortName = name.Substring(0, 2);
        }

    }//end <<entity>> Faculty

    /// <summary>
    /// Руководитель учебного подразделения
    /// </summary>
    public class Head
    {
        public string Name { get; private set; }
        public string ScDegree { get; private set; }
        public string ScRank { get; private set; }
        public int StartDate { get; private set; }
        public int EndDate { get; private set; }

        public Head(int year, string name, string degree, string rank)
        {
            StartDate = year;
            Name = name;
            ScDegree = degree;
            ScRank = rank;
        }
    }//end <<entity>> Head

    /// <summary>
    /// Класс, который содержит информацию о пользователе, который вошел в систему
    /// </summary>
    public class User
    {
        public string Login { get; private set; }
        public string Password { get; private set; }
        public TypeOfUser Type { get; private set; }

        public User(string login, string password, int type)
        {
            Login = login;
            Password = password;
            Type = (TypeOfUser)Enum.GetValues(typeof(TypeOfUser)).GetValue(type - 1);
        }

    }//end <<entity>>User

    public class Subject
    {
        private string Name { get; set; }
        private int PassingScore { get; set; }
        private int Year { get; set; }

        public Subject(int score, string name, int year)
        {
            Name = name;
            PassingScore = score;
            Year = year;
        }
    }

    /// <summary>
    /// Speciality
    /// </summary>
    public class Speciality
    {
        public int Code { get; private set; }
        public String Name { get; private set; }
        public string ShortName { get; private set; }

        public Speciality(int code, string name)
        {
            Code = code;
            Name = name;
            ShortName = name.Substring(0, 2);
        }
    }//end <<entity>> Speciality

}
