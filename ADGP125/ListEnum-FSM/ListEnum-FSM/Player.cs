using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    public class Player
    {
        string m_name;
        int m_attack;
        int m_health;

        public Player(string name, int atk, int hp)
        {
            m_name = name;
            m_attack = atk;
            m_health = hp;
        }
    }
}
