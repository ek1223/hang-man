using System;

namespace hang_man
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choosenWord = "deneme";
            Console.WriteLine("Welcome to the hangedman please input a letter");

            int lives = 6;
            printgallow0();
            
            while (lives > 0)
              
            
            {
                string playerinput = Console.ReadLine();

                if (!string.IsNullOrEmpty(playerinput) && choosenWord.Contains(playerinput))
                {
                    Console.WriteLine("there is a " + playerinput + " in the word");
                }
                else
                {
                    Console.WriteLine("this word doesn't contain a " + playerinput + " in it");
                    lives--;
                }

                switch (lives)
                {
                    case 6:
                        printgallow0();
                        break;
                    case 5:
                        printgallow1();
                        break;
                    case 4:
                        printgallow2();
                        break;
                    case 3:
                        printgallow3();
                        break;
                    case 2:
                        printgallow4();
                        break;
                    case 1:
                        printgallow5();
                        break;
                    case 0:
                        printgallow6();
                        break;
                }
            }
        }

        private static void printgallow0()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("=========");
        }

        private static void printgallow1()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("       |");
            Console.WriteLine("=========");
        }

        private static void printgallow2()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine("  |    |");
            Console.WriteLine("  |    |");
            Console.WriteLine("       |");
            Console.WriteLine("=========");
        }

        private static void printgallow3()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine("  |    |");
            Console.WriteLine("  |    |");
            Console.WriteLine("   \\  |");
            Console.WriteLine("=========");
        }

        private static void printgallow4()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine("  |    |");
            Console.WriteLine("  |    |");
            Console.WriteLine(" / \\  |");
            Console.WriteLine("=========");
        }

        private static void printgallow5()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine("  |\\  |");
            Console.WriteLine("  |    |");
            Console.WriteLine(" / \\  |");
            Console.WriteLine("=========");
        }

        private static void printgallow6()
        {
            Console.WriteLine("  +----+");
            Console.WriteLine("  |    |");
            Console.WriteLine("  O    |");
            Console.WriteLine(" /|\\  |");
            Console.WriteLine("  |    |");
            Console.WriteLine(" / \\  |");
            Console.WriteLine("=========");
        }
    }
}
