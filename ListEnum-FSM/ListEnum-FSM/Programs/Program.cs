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
            //FSM Test = new FSM();
            //Test.AddState("IDLE");
            //Test.AddTransition("INIT", "IDLE");
            //Test.ListStates();
            //Test.ListTransitions();
            //Console.WriteLine ("CState" + Test.CurrentState);
            //Test.ChangeState("IDLE");
            //Console.WriteLine("CState" + Test.CurrentState);
            //SaveLoad<FSM> saveLoad = new SaveLoad<FSM>();
            //saveLoad.Serialize("FSM", Test);
            Test1();
            Console.WriteLine();
        }

        static void Test1()
        {
            Character c = new Character("ben", 5, 5, 1, 1, 1);
            SaveLoad<Character> sl = new SaveLoad<Character>();
            sl.Serialize("benny", c);
            
        }
    }

   
}
