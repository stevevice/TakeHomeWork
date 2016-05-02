
public class Character
{
    string name;
    float health;
    float attack;
    float defense;
    float speed;
    float experience;

    Character() { }

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


