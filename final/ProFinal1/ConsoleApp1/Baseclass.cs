using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Baseclass
    {
        protected string Name { get; set; }
        protected int[] Card { get; set; } = new int[5];

        public Baseclass (string name, int[] card)
        {
            Name = name;
            Card = card;
        }

        public virtual void Showcard()
        {
            Console.WriteLine($"-{Name}-{Card[0]},{Card[1]},{Card[2]},{Card[3]},{Card[4]},{Card[5]}");
        }
    }
}
