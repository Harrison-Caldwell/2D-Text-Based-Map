using System;

namespace _2D_Text_Based_Map
{
    class Program
    {
        static bool GameOver = false;

        static char Border = Convert.ToChar(175);

        

        static void AsciiSucks()
        {
            Convert.ToChar(186);
        }

        




        static char[,] map = new char[,]
         {
             


                {'^' , '^' , '!' , '!' , '*' , '*' , '*' , '~' , '~' , '^' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '!' , '!' , '~' , '~' , '~' , '~' , '~' , '~' , '~', '~' },
                {'^' , '*' , '*' , '*' , '*' , '*' , '!' , '~' , '~' , '!' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '!' , '!' , '~' , '~' , '~' , '~' , '~' , '~' , '~', '~' },
                {'*' , '*' , '*' , '*' , '*' , '*' , '!' , '~' , '~' , '@' , '@' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '*' , '!' , '!' , '~' , '~' , '~' , '~' , '~' , '~' , '~', '~' },
                {'*' , '*' , '*' , '*' , '*' , '@' , '~' , '~' , '!' , '*' , '*' , '*' , '@' , '*' , '*' , '@' , '@' , '*' , '*' , '*' , '*' , '!' , '~' , '~' , '~' , '~' , '~' , '~' , '~', '!' },
                {'*' , '*' , '*' , '*' , '*' , '~' , '~' , '@' , '!' , '*' , '*' , '*' , '@' , '*' , '@' , '@' , '@' , '*' , '*' , '*' , '*' , '*' , '!' , '~' , '~' , '~' , '~' , '~' , '!', '!' },
                {'*' , '*' , '*' , '*' , '~' , '~' , '!' , '!' , '*' , '*' , '*' , '*' , '!' , '!' , '@' , '@' , '@' , '*' , '*' , '*' , '*' , '*' , '!' , '~' , '~' , '~' , '~' , '!' , '!', '!' },
                {'*' , '*' , '*' , '*' , '~' , '~' , '!' , '*' , '*' , '*' , '*' , '!' , '!' , '!' , '!' , '!' , '@' , '*' , '*' , '*' , '*' , '*' , '@' , '!' , '~' , '~' , '!' , '!' , '!', '@' },
                {'*' , '*' , '*' , '~' , '~' , '@' , '!' , '*' , '*' , '*' , '*' , '!' , '!' , '!' , '!' , '!' , '!' , '*' , '*' , '*' , '*' , '@' , '@' , '!' , '!' , '~' , '!' , '@' , '@', '*' },
                {'*' , '*' , '*' , '~' , '~' , '*' , '!' , '*' , '*' , '*' , '*' , '!' , '!' , '!' , '!' , '!' , '!' , '*' , '*' , '*' , '*' , '@' , '@' , '!' , '!' , '!' , '@' , '@' , '@', '*' },
                {'*' , '*' , '~' , '~' , '@' , '*' , '!' , '*' , '*' , '*' , '!' , '!' , '!' , '!' , '!' , '!' , '!' , '*' , '*' , '*' , '@' , '@' , '!' , '!' , '!' , '!' , '@' , '@' , '@', '*' }
                //Legend
                // ^ = Mountain
                // ~ = water
                // * = grass
                // @ = flower
                // ! = tree
            };

        static void DisplayMap(int scale)
        {
            
            
           
            if (scale == 1)
            {
               
                for (int x = 0; x <= 9; x = x + 1)
                {
                    Console.WriteLine();
                    Console.ResetColor();
                    Console.Write(Convert.ToChar(124));
                    for (int y = 0; y <= 29; y = y + 1)
                    {
                        
                        if (map[x, y] == '^')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.BackgroundColor = ConsoleColor.Gray;
                            
                        }

                        if (map[x, y] == '~')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.BackgroundColor = ConsoleColor.Blue;
                            
                        }

                        if (map[x, y] == '*')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.BackgroundColor = ConsoleColor.Green;
                            
                        }

                        if (map[x, y] == '@')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.BackgroundColor = ConsoleColor.Red;
                            
                        }

                        if (map[x, y] == '!')
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.BackgroundColor = ConsoleColor.Magenta;
                            
                        }
                        
                        Console.Write(map[x, y]);
                    }
                    Console.ResetColor();
                    Console.Write(Convert.ToChar(124));
                }
            }
            if (scale == 2)
            {
                Console.WriteLine(Convert.ToChar(124));
                for (int x = 0; x <= 9; x = x + 1)
                {
                    Console.WriteLine();
                    Console.Write(Convert.ToChar(124));
                    for (int y = 0; y <= 29; y = y + 1)
                    {
                        Console.Write(map[x, y]);
                        Console.Write(map[x, y]);
                    }
                    Console.Write(Convert.ToChar(124));
                }
            }
            

            if (scale == 3)
            {
                for (int x = 0; x <= 9; x = x + 1)
                {
                    Console.WriteLine();
                    Console.Write(Convert.ToChar(124));
                    for (int y = 0; y <= 29; y = y + 1)
                    {
                        Console.Write(map[x, y]);
                        Console.Write(map[x, y]);
                        Console.Write(map[x, y]);
                    }
                    Console.Write(Convert.ToChar(124));
                }
            }

           if (GameOver == false)
            {
                GameOver = true;
            }

            Console.ReadKey(true);
            
        }
        



        static void Main(string[] args)
        {
            char[,] map = new char[10, 30]; 

            while(GameOver == false)
            {
                DisplayMap(1);
            }
        }
    }
}
