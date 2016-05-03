using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADGP_125
{
    //Finite State Machine
    class Program
    {   
        
        static void Main(string[] args)
        {
            Console.WriteLine("You are about to Serialize.");
            Test1();
            Console.ReadLine();
            Console.WriteLine("You are about to Deserialize from the file in the folder SavedFiles");
            Test2();
            Console.ReadLine();
            Test3();
            Console.ReadLine();
        }

        
        static void Test1()
        {
            SaveLoad<Player> sl = new SaveLoad<Player>();
            Player c;
            c = new Player("Ben", 10, 1);
            sl.Serialize("benny", c);
            Console.WriteLine("You just serialized.");
        }

        static void Test2()
        {
            SaveLoad<Player> sl = new SaveLoad<Player>();
            Player Ben = sl.Deserialize("benny");
            Console.WriteLine("name = " + Ben.name + "\n");
            Console.WriteLine("health = " + Ben.health + "\n");
            Console.WriteLine("attack = " + Ben.attack + "\n");
        }

        static void Test3()
        {
            FSM<string> Test = new FSM<string>();
            Test.AddState("INIT");
            Test.AddState("IDLE");
            Test.AddTransition("INIT", "IDLE");
            Test.ListStates();
            Test.ListTransitions();
            Console.WriteLine("CState" + Test.CurrentState);
            Test.ChangeState("IDLE");
            Console.WriteLine("CState" + Test.CurrentState);
        }
    }
}
