using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ADGP_125
{
    //Finite State Machine
    [Serializable]
    class Program
    {   
        
        static void Main(string[] args)
        {
            FSM Test = new FSM();
            Test.AddState("IDLE");
            Test.AddTransition("INIT", "IDLE");
            Test.ListStates();
            Test.ListTransitions();
            Console.WriteLine ("CState" + Test.CurrentState);
            Test.ChangeState("IDLE");
            Console.WriteLine("CState" + Test.CurrentState);

        }
    }
}
