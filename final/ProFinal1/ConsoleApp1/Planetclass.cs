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
        public string nameP { get; set; }
        public Planetclass(string name, int[] cardp) : base(name, cardp)
        {
            nameP=name;
            Cardp=cardp;
        }                          
        public virtual void Cheackcard()

        {
            string At = Console.ReadLine();
            int Rnum, x, i, SumCardp=0;
            Random random = new Random();
            bool cardcheack = false;
            int Sump = random.Next(15, 19);
            while (SumCardp != Sump )
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
            

            while (cardcheack != true)
            {
                if (At == "T0"|| At == "t0")
                {
                    Console.Write($"| {At}={Cardp[0]}");
                    cardcheack = true;
                }
                else if (At == "T1" || At == "t1")
                {
                    Console.Write($"| {At}={Cardp[1]}");
                    cardcheack = true;
                }
                else if (At == "T2" || At == "t2")
                {
                    Console.Write($"| {At}={Cardp[2]}");
                    cardcheack = true;
                }
                else if (At == "T3" || At == "t3")
                {
                    Console.Write($"| {At}={Cardp[3]}");
                    cardcheack = true;
                }
                else if (At == "T4" || At == "t4")
                {
                    Console.Write($"| {At}={Cardp[4]}");
                    cardcheack = true;
                }
                else if (At == "T5" || At == "t5")
                {
                    Console.Write($"| {At}={Cardp[5]}");
                    cardcheack = true;
                }
                else
                {
                    Console.WriteLine("your in put are wrot");
                    Console.WriteLine($"Enter T0 - T5 to CheackCard");
                    Console.Write($"Cheack {nameP}'s Card : ");

                    cardcheack = false;
                    At = Console.ReadLine();
                }
                



            }
            Console.WriteLine($" | Sum in is Planet {SumCardp}");
        }
    }
}
