using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CASE_STUDY
{
    public class Population
    {
        int applicationID;
        int memberID;
        string firstname;
        string middleName;
        string lastName;
        string suffix;
        DateTime dob;
        string gender;

        public int ApplicationID { get => applicationID; set => applicationID = value; }
        public int MemberID { get => memberID; set => memberID = value; }
        public string Firstname { get => firstname; set => firstname = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Suffix { get => suffix; set => suffix = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Gender { get => gender; set => gender = value; }
    }
}