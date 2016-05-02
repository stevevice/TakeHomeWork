using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FSM
{
    public static List<string> States = new List<string> { "INIT" };

    string CState = States[0];

    public void AddState(string NewState)
    {
            if (!States.Contains(NewState))
            {
                States.Add(NewState);
            }
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }

    class Transition
    {
        public string from;
        public string to;

        public Transition(string f, string t)
        {
            from = f;
            to = t;
        }
    }

    List<Transition> TransitionList = new List<Transition>();

    public void AddTransition(string NewFrom, string NewTo)
    {
        if (States.Contains(NewFrom) && States.Contains(NewTo))
        {
            Transition NewTrans = new Transition(NewFrom, NewTo);
            if (!TransitionList.Contains(NewTrans))
            {
                TransitionList.Add(NewTrans);
            }
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }
        else
        {
            Console.WriteLine("YoU CaNt Do ThAt!");
        }
    }

    public void ChangeState(string NextState)
    {
        Transition PossTrans = new Transition(CState, NextState);
        foreach (Transition i in TransitionList)
        {
            if (i.from == CState && i.to == NextState)
            {
                CState = NextState;
            }

            //if (!TransitionList.Contains(PossTrans))
            //{
            //    CState = NextState;
            //}
            else
            {
                Console.WriteLine("YoU CaNt Do ThAt!");
            }
        }
    }

    public void ListStates()
    {
        foreach(string i in States)
        {
            Console.WriteLine(i + "\n");
        }
    }

    public void ListTransitions()
    {
        foreach(Transition i in TransitionList)
        {
            Console.WriteLine(i.from + " to " + i.to + "\n");
        }
    }

    public string CurrentState
    {
        get { return CState; }    
    }

    public FSM()
    {

    }
}
