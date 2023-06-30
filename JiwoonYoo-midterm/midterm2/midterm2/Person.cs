using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm2
{
    internal class Person
    {
        //fields and property 
        private int _index;
        private int _personId;
        private string _name;
        private string _address;
        private string _email;
        private int _age;
        private string _birthDay;       //

        public int Index { get { return _index; } set { _index = value; } }
        public int PersonId { get { return _personId; } set { _personId = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public string BirthDay { get { return _birthDay; } set { _birthDay = value; } }


        //constructor 
        public Person(int index, int personId, string name, string address, string email, int age, string birthDay)
        {
            Index = index;
            PersonId = personId;
            Name = name;
            Address = address;
            Email = email;
            Age = age;
            BirthDay = birthDay;

        }




    }
}
