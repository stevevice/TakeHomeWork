using System;

namespace ADGP_125
{

    
    public interface Character
    {
        string name
        {
            get;
            set;
        }

        float health
        {
            get;
            set;
        }

        float attack
        {
            get;
            set;
        }

    }

    [Serializable]
    public class Player: Character
    {
        string _name;
        float _health;
        float _attack;

        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public float health
        {
            get
            {
                return _health;
            }

            set
            {
                _health = value;
            }
        }

        public float attack
        {
            get
            {
                return _attack;
            }

            set
            {
                _attack = value;
            }
        }

        public Player(string Name, float hp, float atk)
        {
            name = Name;
            health = hp;
            attack = atk;
        }

        Player()
        {
            name = "Steve";
            health = 10;
            attack = 2;
        }


    }
}


