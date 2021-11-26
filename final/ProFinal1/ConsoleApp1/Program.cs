using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("= = = Welcome to my game. ! ! ! = = =");
            int AT1 = 0;
            int AT2 = 0;
            int AT3 = 0;
            int AT4 = 0;
            int AT5 = 0;
            int AT6 = 0;

            char Po;

            string po;
            int[] CardPlay = new int[6];

            int[] Carda = { 4, 4, 4, 4, 4, 4 };
            Ship shipa = new Ship("ShipA", Carda);
            shipa.Showcard();
            
            int[] Cardb = { 3, 4, 5, 5, 3, 5 };
            Ship shipb = new Ship("ShipB", Cardb);
            shipb.Showcard();
            Console.Write("input ship : ");
            
            int[] CardPlanet = { 1, 1, 6, 6, 1, 1 };
            Planetclass PlanetA = new Planetclass("Planet-06", CardPlanet);

            
            while (CardPlay != Carda ||CardPlay != Cardb)
            {
                po = Console.ReadLine();

                char.TryParse(po, out Po);

                if (Po == 'a' || Po == 'A')
                {
                    CardPlay = Carda;
                }
                else if (Po == 'b' || Po == 'B')
                {
                    CardPlay = Cardb;
                }
                else
                {
                    Console.WriteLine("your in put are wrot");
                }
            }

            Console.WriteLine($"a = {CardPlay[0]}| T1 = ?");
            Console.WriteLine($"b = {CardPlay[1]}| T2 = ?");
            Console.WriteLine($"c = {CardPlay[2]}| T3 = ?");
            Console.WriteLine($"d = {CardPlay[3]}| T4 = ?");
            Console.WriteLine($"e = {CardPlay[4]}| T5 = ?");
            Console.WriteLine($"f = {CardPlay[5]}| T6 = ?");
            Console.Write("input T cheack : ");
            PlanetA.Cheackcard();
            Console.WriteLine("input ATK ");
            

            while(AT1 == 0 || AT1 == 1 || AT1 == 2 || AT1 == 3 || AT1 == 4 || AT1 == 5 )
            {
                po = Console.ReadLine();

                 
                
                char.TryParse(po, out Po);
                if (Po == 'a' || Po == 'A')
                {
                    AT1 = 0;
                }
                else if (Po == 'b' || Po == 'B')
                {
                    AT1 = 1;
                }
                else if (Po == 'c' || Po == 'C')
                {
                    AT1 = 2;
                }
                else if (Po == 'd' || Po == 'D')
                {
                    AT1 = 3;
                }
                else if (Po == 'e' || Po == 'E')
                {
                    AT1 = 4;
                }
                else if (Po == 'f' || Po == 'F')
                {
                    AT1 = 5;
                }
                else
                {
                    Console.WriteLine("your in put are wrot");
                }
            }
            
            // Win | lose
            int x = 0,y=0;
            if (CardPlay[AT1] > CardPlanet[0])
            {
                x = x+1;
            }
            else
            {
                y = y+1;
            }
            if (CardPlay[AT2] > CardPlanet[1])
            {
                x = x + 1;   
            }
            else
            {
                y = y = y + 1;
            }
            if (CardPlay[AT3] > CardPlanet[2])
            {
                x = x + 1; 
            }
            else
            {
                y = y + 1;
            }
            if (CardPlay[AT4] > CardPlanet[3])
            {
                x = x + 1;
            }
            else
            {
                y = y + 1;
            }
            if (CardPlay[AT5] > CardPlanet[4])
            {
                x = x + 1;
            }
            else
            {
                y = y + 1;
            }
            if(CardPlay[AT6] > CardPlanet[5])
            {
                x = x + 1;
            }
            else
            {
                y = y + 1;
            }
            
            Console.WriteLine($"Win = {x} | Lose = {y}");
        }
    }
}
