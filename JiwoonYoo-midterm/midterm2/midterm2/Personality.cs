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
    internal class Personality : Person
    {
        //fields and property 
        private int _personalityId;
        private int _shoeSize;
        private string _favouriteMovie;
        private string _favouriteActor;

        public int PersonalityId { get { return _personalityId; } set { _personalityId = value; } }
        public int ShoeSize { get { return _shoeSize; } set { _shoeSize = value; } }    
        public string FavouriteMovie { get { return _favouriteMovie;  } set { _favouriteMovie = value;  } }
        public string FavourtieActor { get { return _favouriteActor;  } set { _favouriteActor = value; } }


        //constructor 
        public Personality(int index, int personId, string name, string address, string email, int age, string birthDay, int personalityId, int shoeSize, string favouriteMovie, string favouriteActor) : base(index, personId, name, address, email, age, birthDay)
        {
            PersonalityId = personalityId;
            ShoeSize = shoeSize;
            FavouriteMovie = favouriteMovie;
            FavourtieActor = favouriteActor; 
        }



    }
}
