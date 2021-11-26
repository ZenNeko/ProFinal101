using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Planetclass :Baseclass
    {
        public int[] Cardp { get; set; } = new int[6];
        public Planetclass(string name, int[] cardp) : base(name, cardp)
        {
            cardp = Cardp;
        }
        public virtual void Cheackcard()

        {
            string At = Console.ReadLine();
            int Rnum, x, i, SumCardp=0;
            Random random = new Random();
            Cardp[0] = random.Next();
            bool cardcheack = false;

            while(SumCardp < 35 )
            {
                SumCardp=0;
                for (int j = 0; j < 6; j++)
                {
                    int randomNumber = random.Next(1, 7);
                    Rnum = randomNumber;
                    Cardp[j] = Rnum;
                    
                }
                SumCardp = Cardp[0] + Cardp[1] + Cardp[2] + Cardp[3] + Cardp[4] + Cardp[5];
            }
            Console.WriteLine(SumCardp);
            

            while (cardcheack != true)
            {
                if (At == "T0"|| At == "t0")
                {
                    Console.WriteLine($"{At}={Cardp[0]}");
                    cardcheack = true;
                }
                else if (At == "T1" || At == "t1")
                {
                    Console.WriteLine($"{At}={Cardp[1]}");
                    cardcheack = true;
                }
                else if (At == "T2" || At == "t2")
                {
                    Console.WriteLine($"{At}={Cardp[2]}");
                    cardcheack = true;
                }
                else if (At == "T3" || At == "t3")
                {
                    Console.WriteLine($"{At}={Cardp[3]}");
                    cardcheack = true;
                }
                else if (At == "T4" || At == "t4")
                {
                    Console.WriteLine($"{At}={Cardp[4]}");
                    cardcheack = true;
                }
                else if (At == "T5" || At == "t5")
                {
                    Console.WriteLine($"{At}={Cardp[5]}");
                    cardcheack = true;
                }
                else
                {
                    
                    Console.WriteLine("your in put are wrot");
                    Console.Write("input T cheack : ");
                    cardcheack = false;
                    At = Console.ReadLine();
                }
              
                

            }
        }
    }
}
