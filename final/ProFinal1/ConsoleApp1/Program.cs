﻿using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("►►►► Welcome to my game. ◄◄◄◄◄");
            //strat loop
            bool loop = false;
            while (loop == false)
            {
                int AT0 = 0;
                int AT1 = 0;
                int AT2 = 0;
                int AT3 = 0;
                int AT4 = 0;
                int AT5 = 0;
                int Rnum, SumCarda = 0, SumCardb = 0;
                Random random = new Random();
                char[] inAT = new char[6];
                bool[] cAT = { false, false, false, false, false, false };
                int[] Carda = new int[6], Cardb = new int[6], CardPlay = new int[6]; ;
                //random cards Ship A
                int sumA = random.Next(18, 23);
                while (sumA != SumCarda)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        int randomNumber = random.Next(0, 7);
                        Rnum = randomNumber;
                        Carda[j] = Rnum;

                    }
                    SumCarda = Carda[0] + Carda[1] + Carda[2] + Carda[3] + Carda[4] + Carda[5];
                }
                //random cards Ship B
                int sumb = random.Next(20, 25);
                while (sumb != SumCardb)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        int randomNumber = random.Next(1, 8);
                        Rnum = randomNumber;
                        Cardb[j] = Rnum;

                    }
                    SumCardb = Cardb[0] + Cardb[1] + Cardb[2] + Cardb[3] + Cardb[4] + Cardb[5];
                }


                // Show ship and planet cards
                Ship shipa = new Ship("ShipA", Carda);
                shipa.Showcard();
                Console.WriteLine($" | Sum ship A = {sumA} ");

                Ship shipb = new Ship("ShipB", Cardb);
                shipb.Showcard();
                Console.WriteLine($" | Sum ship b = {sumb} ");
                Console.WriteLine("| ► Type 'A' or 'B' for choose The ship");
                Console.Write("| Choose Your ship ► ");

                int[] CardPlanet = new int[6];
                Planetclass PlanetA = new Planetclass("Planet-06", CardPlanet);

                // Get input for choose ship
                while (CardPlay != Carda && CardPlay != Cardb)
                {

                    char.TryParse(Console.ReadLine(), out inAT[0]);

                    if (inAT[0] == 'a' || inAT[0] == 'A')
                    {
                        CardPlay = Carda;
                    }
                    else if (inAT[0] == 'b' || inAT[0] == 'B')
                    {
                        CardPlay = Cardb;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                }

                Console.WriteLine($"| Card'a' = {CardPlay[0]}| T0 = ?");
                Console.WriteLine($"| Card'b' = {CardPlay[1]}| T1 = ?");
                Console.WriteLine($"| Card'c' = {CardPlay[2]}| T2 = ?");
                Console.WriteLine($"| Card'd' = {CardPlay[3]}| T3 = ?");
                Console.WriteLine($"| Card'e' = {CardPlay[4]}| T4 = ?");
                Console.WriteLine($"| Card'f' = {CardPlay[5]}| T5 = ?");
                Console.WriteLine($"| Enter T0 - T5 to 1st CheackCard");
                Console.Write($"| Cheack {PlanetA.nameP}'s Card : ");
                PlanetA.Cheackcard();
                Console.WriteLine($"| Enter T0 - T5 to 2nd CheackCard");
                Console.Write($"| Cheack {PlanetA.nameP}'s Card : ");
                PlanetA.Cheackcard();

                //set AT0 done
                while (cAT[0] != true)
                {
                    Console.Write("Pick a card to Attack T0 : ");
                    char.TryParse(Console.ReadLine(), out inAT[0]);

                    if (inAT[0] == 'a' || inAT[0] == 'A')
                    {
                        AT0 = 0;
                        cAT[0] = true;
                    }
                    else if (inAT[0] == 'b' || inAT[0] == 'B')
                    {
                        AT0 = 1;
                        cAT[0] = true;
                    }
                    else if (inAT[0] == 'c' || inAT[0] == 'C')
                    {
                        AT0 = 2;
                        cAT[0] = true;
                    }
                    else if (inAT[0] == 'd' || inAT[0] == 'D')
                    {
                        AT0 = 3;
                        cAT[0] = true;
                    }
                    else if (inAT[0] == 'e' || inAT[0] == 'E')
                    {
                        AT0 = 4;
                        cAT[0] = true;
                    }
                    else if (inAT[0] == 'f' || inAT[0] == 'F')
                    {
                        AT0 = 5;
                        cAT[0] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                }
                //set AT1 done
                while (cAT[1] != true)
                {
                    Console.Write("Pick a card to Attack T1 : ");

                    char.TryParse(Console.ReadLine(), out inAT[1]);
                    if (inAT[1] == 'a' || inAT[1] == 'A')
                    {
                        AT1 = 0;
                        cAT[1] = true;
                    }
                    else if (inAT[1] == 'b' || inAT[1] == 'B')
                    {
                        AT1 = 1;
                        cAT[1] = true;
                    }
                    else if (inAT[1] == 'c' || inAT[1] == 'C')
                    {
                        AT1 = 2;
                        cAT[1] = true;
                    }
                    else if (inAT[1] == 'd' || inAT[1] == 'D')
                    {
                        AT1 = 3;
                        cAT[1] = true;
                    }
                    else if (inAT[1] == 'e' || inAT[1] == 'E')
                    {
                        AT1 = 4;
                        cAT[1] = true;
                    }
                    else if (inAT[1] == 'f' || inAT[1] == 'F')
                    {
                        AT1 = 5;
                        cAT[1] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                    if (AT0 == AT1)
                    {
                        cAT[1] = false;
                        Console.WriteLine("you used it");
                    }
                    else { cAT[1] = true; }
                }
                //set AT2 done
                while (cAT[2] != true)
                {
                    Console.Write("Pick a card to Attack T2 : ");

                    char.TryParse(Console.ReadLine(), out inAT[2]);
                    if (inAT[2] == 'a' || inAT[2] == 'A')
                    {
                        AT2 = 0;
                        cAT[2] = true;
                    }
                    else if (inAT[2] == 'b' || inAT[2] == 'B')
                    {
                        AT2 = 1;
                        cAT[2] = true;
                    }
                    else if (inAT[2] == 'c' || inAT[2] == 'C')
                    {
                        AT2 = 2;
                        cAT[2] = true;
                    }
                    else if (inAT[2] == 'd' || inAT[2] == 'D')
                    {
                        AT2 = 3;
                        cAT[2] = true;
                    }
                    else if (inAT[2] == 'e' || inAT[2] == 'E')
                    {
                        AT2 = 4;
                        cAT[2] = true;
                    }
                    else if (inAT[2] == 'f' || inAT[2] == 'F')
                    {
                        AT2 = 5;
                        cAT[2] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                    if (AT0 == AT2 || AT1 == AT2)
                    {
                        cAT[2] = false;
                        Console.WriteLine("you used it");
                    }
                    else { cAT[2] = true; }
                }
                //set AT3 done
                while (cAT[3] != true)
                {
                    Console.Write("Pick a card to Attack T3 : ");

                    char.TryParse(Console.ReadLine(), out inAT[3]);
                    if (inAT[3] == 'a' || inAT[3] == 'A')
                    {
                        AT3 = 0;
                        cAT[3] = true;
                    }
                    else if (inAT[3] == 'b' || inAT[3] == 'B')
                    {
                        AT3 = 1;
                        cAT[3] = true;
                    }
                    else if (inAT[3] == 'c' || inAT[3] == 'C')
                    {
                        AT3 = 2;
                        cAT[3] = true;
                    }
                    else if (inAT[3] == 'd' || inAT[3] == 'D')
                    {
                        AT3 = 3;
                        cAT[3] = true;
                    }
                    else if (inAT[3] == 'e' || inAT[3] == 'E')
                    {
                        AT3 = 4;
                        cAT[3] = true;
                    }
                    else if (inAT[3] == 'f' || inAT[3] == 'F')
                    {
                        AT3 = 5;
                        cAT[3] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                    if (AT0 == AT3 || AT1 == AT3 || AT3 == AT2)
                    {
                        cAT[3] = false;
                        Console.WriteLine("you used it");
                    }
                    else { cAT[3] = true; }
                }
                //set AT4 done
                while (cAT[4] != true)
                {
                    Console.Write("Pick a card to Attack T4 : ");

                    char.TryParse(Console.ReadLine(), out inAT[4]);
                    if (inAT[4] == 'a' || inAT[4] == 'A')
                    {
                        AT4 = 0;
                        cAT[4] = true;
                    }
                    else if (inAT[4] == 'b' || inAT[4] == 'B')
                    {
                        AT4 = 1;
                        cAT[4] = true;
                    }
                    else if (inAT[4] == 'c' || inAT[4] == 'C')
                    {
                        AT4 = 2;
                        cAT[4] = true;
                    }
                    else if (inAT[4] == 'd' || inAT[4] == 'D')
                    {
                        AT4 = 3;
                        cAT[4] = true;
                    }
                    else if (inAT[4] == 'e' || inAT[4] == 'E')
                    {
                        AT4 = 4;
                        cAT[4] = true;
                    }
                    else if (inAT[4] == 'f' || inAT[4] == 'F')
                    {
                        AT4 = 5;
                        cAT[4] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                    if (AT0 == AT4 || AT1 == AT4 || AT4 == AT2 || AT4 == AT3)
                    {
                        cAT[4] = false;
                        Console.WriteLine("you used it");
                    }
                    else { cAT[4] = true; }
                }
                //set AT5 done
                while (cAT[5] != true)
                {
                    Console.Write("Pick a card to Attack T5 : ");

                    char.TryParse(Console.ReadLine(), out inAT[5]);
                    if (inAT[5] == 'a' || inAT[5] == 'A')
                    {
                        AT5 = 0;
                        cAT[5] = true;
                    }
                    else if (inAT[5] == 'b' || inAT[5] == 'B')
                    {
                        AT5 = 1;
                        cAT[5] = true;
                    }
                    else if (inAT[5] == 'c' || inAT[5] == 'C')
                    {
                        AT5 = 2;
                        cAT[5] = true;
                    }
                    else if (inAT[5] == 'd' || inAT[5] == 'D')
                    {
                        AT5 = 3;
                        cAT[5] = true;
                    }
                    else if (inAT[5] == 'e' || inAT[5] == 'E')
                    {
                        AT5 = 4;
                        cAT[5] = true;
                    }
                    else if (inAT[5] == 'f' || inAT[5] == 'F')
                    {
                        AT5 = 5;
                        cAT[5] = true;
                    }
                    else
                    {
                        Console.WriteLine("your in put are wrot");
                    }
                    if (AT0 == AT5 || AT1 == AT5 || AT2 == AT5 || AT3 == AT5 || AT4 == AT5)
                    {
                        cAT[2] = false;
                        Console.WriteLine("you used it");
                    }
                    else { cAT[2] = true; }
                }


                // Win | lose
                int x = 0, y = 0;
                if (CardPlay[AT0] > PlanetA.Cardp[0])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                if (CardPlay[AT1] > PlanetA.Cardp[1])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                if (CardPlay[AT2] > PlanetA.Cardp[2])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                if (CardPlay[AT3] > PlanetA.Cardp[3])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                if (CardPlay[AT4] > PlanetA.Cardp[4])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                if (CardPlay[AT5] > PlanetA.Cardp[5])
                {
                    x = x + 1;
                }
                else
                {
                    y = y + 1;
                }
                Console.WriteLine($"Win = {x} | Lose = {y}");
                PlanetA.Showcard();
                //loop game
                Console.WriteLine("\nDo you want to play again [Y]Yes ro [N]No");
                String ans = Console.ReadLine();
                if (ans == "N")
                {
                    Console.WriteLine("See ya~~~");
                    loop = true;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
