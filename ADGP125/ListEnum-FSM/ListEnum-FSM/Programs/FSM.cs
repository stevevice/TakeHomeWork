using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FSM<T>
{
    public static List<T> States = new List<T> {  };

    T CState;

    public void AddState(T NewState)
    {
        NewState.ToString();
            if (!States.Contains(NewState))
            {
                States.Add(NewState);
                if (CState == null)
                {
                CState = NewState;
                }
            }
            else
            {
                Console.WriteLine("There is already a similar State.");
            }
        }

    class Transition
    {
        public T from;
        public T to;

        public Transition(T f, T t)
        {
            from = f;
            to = t;
        }
    }

    List<Transition> TransitionList = new List<Transition>();

    public void AddTransition(T NewFrom, T NewTo)
    {
        NewFrom.ToString();
        NewTo.ToString();

        if (States.Contains(NewFrom) && States.Contains(NewTo))
        {
            Transition NewTrans = new Transition(NewFrom, NewTo);
            if (!TransitionList.Contains(NewTrans))
            {
                TransitionList.Add(NewTrans);
            }
            else
            {
                Console.WriteLine("There is already a Transition for these two States");
            }
        }
        else
        {
            Console.WriteLine("You dont have one of the states.");
        }
    }

    public void ChangeState(T NextState)
    {
        Transition PossTrans = new Transition(CState, NextState);
        foreach (Transition i in TransitionList)
        {
            if (i.from.ToString() == CState.ToString() && i.to.ToString()== NextState.ToString())
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

        foreach(T i in States)
        {
            Console.WriteLine(i + "\n");
        }
    }

    public void ListTransitions()
    {
        foreach(Transition i in TransitionList)
        {
            Console.WriteLine(i.from.ToString() + " to " + i.to.ToString() + "\n");
        }
    }

    public string CurrentState
    {
        get { return CState.ToString(); }    
    }

    public FSM()
    {

    }
}
