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
            Test2();
            Console.WriteLine();
        }

        
        static void Test1()
        {
            SaveLoad<Player> sl = new SaveLoad<Player>();
            Player c;
            c = new Player("Ben", 5, 1);
            sl.Serialize("benny", c);
        }

        static void Test2()
        {
            SaveLoad<Player> sl = new SaveLoad<Player>();
            Player bitch = sl.Deserialize("benny");
            Console.WriteLine(bitch);
        }

        void Test3()
        {
            FSM Test = new FSM();
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
