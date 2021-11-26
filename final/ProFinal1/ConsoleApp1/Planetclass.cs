using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Planetclass :Baseclass
    {
        public Planetclass (string name, int[] card1) : base(name, card1)
        {
           
        }
        public virtual void Cheackcard()
           
        {
            string At = Console.ReadLine();
            int x=0;
            if (At == "T1")
            {
                x = 0;
            }
            else if (At == "T2")
            {
                x = 1;
            }
            else if (At == "T3")
            {
                x = 2;
            }
            else if (At == "T4")
            {
                x = 3;
            }
            else if (At == "T5")
            {
                x = 4;
            }
            else if (At == "T6")
            {
                x = 5;
            }
            else
            {

            }
            Console.WriteLine($"{At}={x}") ;
        }
    }
}
