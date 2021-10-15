using System;

namespace Backend_task_1_Patrick
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeFlag = true;

            while (closeFlag)
            {
                Console.WriteLine("Choose one from options bellow. Write a number to make a choice");
                Console.WriteLine("1 - Greet");
                string greetApp = Console.ReadLine();
                if (greetApp == "1")
                {
                    SayHello();
                }
                else if (greetApp == "2")
                {
                    CheckerboardPattern();
                }
                else
                {
                    Console.WriteLine("Bad input. Enter a number between 1 and 4");
                }
            }

            static void SayHello()
            {
                Console.Write("Enter your name: ");
                string userName = Console.ReadLine();
                Console.WriteLine("Welcome " + userName + "!!!");
            }

            static void CheckerboardPattern()
            {
                Console.WriteLine("Make your own pattern");
                Console.Write("How many colums want you make: ");
                int column = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many rows want you make: ");
                int row = Convert.ToInt32(Console.ReadLine());

                try
                {
                    for (int i = 1; i <= column; i++)
                    {
                        for (int j = 1; j <= row; j++)
                        {
                            if ((i + j) % 2 == 0)
                            {
                                Console.Write("X");
                            }
                            else
                            {
                                Console.Write("O");
                            }
                        }
                        Console.WriteLine();
                    }
                } catch
                {
                    Console.WriteLine("Bad input.");
                }

            }
        }
        
    }
}

