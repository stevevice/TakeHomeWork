using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSM
{
    //Finite State Machine
    class Program
    {
        static void Main(string[] args)
        {
            Player dog = new Player("James", 5, 50);
            Player cat = new Player("Jesse", 10, 20);

            List<Player> Animals = new List<Player>();
            Animals.Add(dog);
            Animals.Add(cat);
        }
    }
}
