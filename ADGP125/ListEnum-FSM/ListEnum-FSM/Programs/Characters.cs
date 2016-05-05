using System;

namespace ADGP_125
{
    public interface Character//the interface called that my class can implement from
    {
        string name //created a variable that all classes will inherit from this class of type string
        {
            get;
            set;
        }

        float health//created a variable that all classes will inherit from this class of type float
        {
            get;
            set;
        }

        float attack//created a variable that all classes will inherit from this class of type float
        {
            get;
            set;
        }

    }

    [Serializable]
    public class Player: Character //Created a class that implements from interface Character and is Serializable
    {
        string _name;
        float _health;
        float _attack;

        public string name //public string variable 
        {
            get //grabs the  variable name and  returns the value
            {
                return _name;
            }

            set // gives the  variable the value 
            {
                _name = value; 
            }
        }

        public float health //public float variable
        {
            get //grabs the  variable name and  returns the value
            {
                return _health;
            }

            set // gives the  variable the value 
            {
                _health = value;
            }
        }

        public float attack //public float variable
        {
            get //grabs the  variable name and  returns the value
            {
                return _attack;
            }

            set // gives the  variable the value 
            {
                _attack = value;
            }
        }

        public Player(string Name, float hp, float atk) //Constructor that  takes 3 parameters
        {
            name = Name;
            health = hp;
            attack = atk;
        }

        Player() //Default Constructor
        {
            name = "Steve";
            health = 10;
            attack = 2;
        }
    }
}


