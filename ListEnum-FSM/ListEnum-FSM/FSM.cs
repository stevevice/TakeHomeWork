using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FSM
{
    public static List<string> States = new List<string> { "INIT" };

    string CState = States[0];

    public void AddState(string NewsState)
    {
        foreach (string i in States)
        {
            if (i != NewsState)
            {
                States.Add(NewsState);
            }
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }
    }

    public class Transition
    {
        public string from;
        public string to;

        Transition(string f, string t)
        {
            from = f;
            to = t;
        }
    }

    List<Transition> TransitionList = new List<Transition>();

    public void AddTransition(Transition NewTrans)
    {
        foreach (string i in States)
        {
            if (NewTrans.from == i && NewTrans.to == i)
            {
                foreach (Transition j in TransitionList)
                {
                    {
                        if (j != NewTrans)
                        {
                            TransitionList.Add(NewTrans);
                        }
                        else
                        {
                            Console.WriteLine("YoU CaNt Do ThAt!");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }
    }

    public void ChangeState(string CurrentState, string NextState)
    {
        foreach (Transition i in TransitionList)
        {
            if (i.from == CState && i.to == NextState)
            {
                CState = NextState;
            }
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }
    }

    FSM()
    {

    }
}
