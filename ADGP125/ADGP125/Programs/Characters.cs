using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Character
{
    float health;
    float attack;
    float defense;
    float speed;
    float experience;

    public Character(float hp, float atk, float def, float spd, float xp)
    {
        health = hp;
        attack = atk;
        defense = def;
        speed = spd;
        experience = xp;
    }
}

public class Player : public Character
{
    float 

    Player() : base ()
    {

    }
}
