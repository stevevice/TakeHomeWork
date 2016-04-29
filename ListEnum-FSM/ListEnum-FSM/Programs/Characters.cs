using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    string name;
    float health;
    float attack;
    float defense;
    float speed;
    float experience;

    public Character(string Name, float hp, float atk, float def, float spd, float xp)
    {
        name = Name;
        health = hp;
        attack = atk;
        defense = def;
        speed = spd;
        experience = xp;
    }
}


