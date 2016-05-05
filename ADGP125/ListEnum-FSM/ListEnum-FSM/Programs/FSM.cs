using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FSM<T> //class that will take in a type  given to it
{
    public static List<T> States = new List<T>(); //Empty List of Generic Type 

    T CState; //Variable of generic type

    public void AddState(T NewState) //function that adds a state and needs 1 parameter which is the state you want to pass in
    {
            if (!States.Contains(NewState)) //if states list does not contain variable NewState value...
            {//it will  add the  state and if CState is an empty variable then CState is equal to NewState
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
        //2 public variables
        public T from;
        public T to;

        public Transition(T f, T t) //Constructor that  is used define a Transition 
        {
            from = f;
            to = t;
        }
    }

    List<Transition> TransitionList = new List<Transition>(); //transition list that is used to keep track of what transitions are available

    public void AddTransition(T NewFrom, T NewTo) //void function that is used to add a transition and it takes in 2 parameters both of them are of generic type T
    {
        if (States.Contains(NewFrom) && States.Contains(NewTo)) //if list states contains variable 
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
                Console.WriteLine("You dont have a Transition that allows for you to switch from Current state to the State you want.");
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
