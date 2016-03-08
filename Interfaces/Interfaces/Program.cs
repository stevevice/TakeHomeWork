using System;
using System.Collections;
using System.Collections.Generic;

//This is the interface that we will use to for our variable to INTERCEPT from
//the INTERFACE
public interface IDamageable
{
    void TakeDamage(int totalDamage);
    //the interface then contains this funtion that every class will Intercept
    //from
}
class Wall : IDamageable //the class called Wall that will intercept from IDamageable
{
    void crumble() //class function that prints out the string "crumbling" when called
    {
        Console.WriteLine("crumbling");
    }
    public Wall(int numbricks) //Class's Wall Constructor that requires a parameter of
        //type int to be placed in the parameters that will be given to a variable name numbricks
    {
        m_bricks = numbricks; //member variable m_bricks will now equal the same value of numbricks
    }
    public void TakeDamage(int totalDamage) //function created in the interface now being provoked
        //the function takes in a parameter value of type int then it set the member variable m_bricks 
        //that is a part of class wall from it current minus the variable that you put in called 
        //totalDamage. It then prints the string written and the variable m_bricks to the string
        //and if the updated version of m_bricks is less than or equal to 5 then it will print to
        //the screen the string stated in that part of the function 
    {
        m_bricks -= totalDamage;
        Console.WriteLine("Current bricks that make me awesome: " + m_bricks.ToString());
        if (m_bricks <= 5)
            Console.WriteLine("i'm dedz");

    }
    int m_bricks; //declare the variable m_bricks of type int
    //if i have 5 or less bricks then I am dead :9 (not steve)
}
class Car : IDamageable //the class called Car that will intercept from IDamageable
{
    void driveaway() //Class function that prints to the screen the string written below
    {
        Console.WriteLine("driving away....");
    }
    int m_armor; //declare the variable m_armor of type int
    public Car(int armorPoints) //Class's Car Constructor that requires a parameter of
         //type int to be placed in the parameters that will be given to varaible name armorPoints
    {
        m_armor = armorPoints; //member variable m_armor will now equal the same value of armorPoints
    }

    public void TakeDamage(int totalDamage) //function created in the interface now being provoked
        //the function takes in a parameter value of type int then it set the member variable m_armor 
        //that is a part of class Car from it current minus the variable that you put in called 
        //totalDamage. It then prints the string written. then prints another string that
        //says something irrelevant to the program
    {
        m_armor -= totalDamage;
        Console.WriteLine("Current armor = " + m_armor.ToString());
        Console.WriteLine("Took it to the face");
    }
    //when a cars armor hits 0 then the car is dead :( (not steve)
}

class Ninja : IDamageable //the class called Ninja that will intercept from IDamageable
{
    private int m_hp; //declare the variable m_armor of type int and is a private variable
    public Ninja(int hp) //Class's Ninja Constructor that requires a parameter of
        //type int to be placed in the parameters that will be given to varaible name hp
    {
        m_hp = hp; //private member variable m_hp will now equal the same value of hp
    }
    public void MyDefinitionOfTakeDamage(int totalDamage) //function created in the interface now being provoked
        //the function takes in a parameter value of type int then it set the member variable m_hp 
        //that is a part of class Ninja from it current minus the variable that you put in called 
        //totalDamage
    {
        m_hp -= totalDamage;
    }

    public void TakeDamage(int totalDamage) //It is a function created in the interface now being provoked
        //the function takes in a parameter value of type int. It then prints the string written.
    {
        Console.WriteLine("i am ben i am ninja taking " + totalDamage.ToString() + " damages");
    }


}


class Program //class that is called Program
{
    static void Main(string[] args) //static Main funtion that has a parameter that can take in a type string
        //array of indefinite size and it is called args
    {
        List<IDamageable> damageableGameObjects = new List<IDamageable>(); //creates a list of type interface called
        //IDamageable then names the list damageableGameObjects and creates a place in memory for the List of type 
        //interface called IDamageable

        Car willsCar = new Car(25); //Declare a variable called willsCar of type Car and we set this variable's m_armor
        //to 25
        Wall andrew = new Wall(10); //Declare a variable called andrew of type Wall and we set this variable's m_bricks
        //to 10
        Ninja ben = new Ninja(3); //Declare a variable called ben of type Ninja and we set this variable's m_hp
        //to 3
        Console.WriteLine("TAKE DAMAGE WILL the CAR"); //prints to the screen something that is irrelevant
        //willsCar.TakeDamage(25); (not steve)
        Console.WriteLine("TAKE DAMAGE MANDREW the WALL"); //prints to the screen something that is irrelevant
        //andrew.TakeDamage(5); (not steve)

        damageableGameObjects.Add(willsCar); //we add the variable called willsCar to the list called damageableGameObjects
        damageableGameObjects.Add(andrew); //we add the variable called andrew to the list called damageableGameObjects
        damageableGameObjects.Add(ben); //we add the variable called ben to the list called damageableGameObjects
        for (int i = 0; i < damageableGameObjects.Count; ++i) //this is a for loop that creates a variable of type int called
        //i and set it to value 0. If within the 4 loop that i is not less than variable damageableGameObjects after we determine
        //how many is within the list
        {
            damageableGameObjects[i].TakeDamage(i); //the list called damageableGameObjects called whatever is i during the time 
            //of the loop then will call the function within the List and the  
        }
        Console.ReadLine();
    }
}