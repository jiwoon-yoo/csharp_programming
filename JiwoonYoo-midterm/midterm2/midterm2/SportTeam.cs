using midterm2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace midterm2
{
    internal class SportTeam : Person
    {
        //fields and property 
        private int _sportTeamId;
        private string _sportTeamName;
        private string _city;

        public int SportTeamId { get { return _sportTeamId; } set { _sportTeamId = value; } }   
        public string SportTeamName { get { return _sportTeamName; } set { _sportTeamName = value; } }  
        public string City { get { return _city; } set { _city = value; } }


        //constructor 
        public SportTeam(int index, int personId, string name, string address, string email, int age, string birthDay, int sportTeamId, string sportTeamName, string city) :base(index, personId, name, address, email, age, birthDay)
        {

            SportTeamId = sportTeamId;
            SportTeamName = sportTeamName; 
            City = city;
        }



    }
}
