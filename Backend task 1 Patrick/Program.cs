using System;

namespace Backend_task_1_Patrick
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeFlag = false;

            while (!closeFlag)
            {
                Console.WriteLine("Choose one from options bellow. Write a number to make a choice.");
                Console.WriteLine("1 - Message");
                Console.WriteLine("2 - User input");
                Console.WriteLine("3 - Checkerboard Pattern");
                Console.WriteLine("4 - Exit");
                string choose = Console.ReadLine();
                if (choose == "1")
                {
                    Message();
                }
                else if (choose == "2")
                {
                    SayHello();
                }
                else if (choose == "3")
                {
                    CheckerboardPattern();
                }
                else if (choose == "4")
                {
                    closeFlag = true;
                }
                else
                {
                    Console.WriteLine("Bad input. Enter a number between 1 and 4");
                }
            }
            static void Message()
            {
                Console.WriteLine("Hello Everybody!!!");
            }

            static void SayHello()
            {
                string userName;
                int age;

                try
                {
                    Console.Write("Enter your name: ");
                    userName = Console.ReadLine();
                    Console.Write("Enter your age: ");
                    age = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Welcome " + userName + " you are " + age + " years old.");

                }
                catch
                {
                    Console.WriteLine("Bad input. Please write your age as a number.");
                }
            }

            static void CheckerboardPattern()
            {
                int column;
                int row;

                bool flagPattern = false;

                while (!flagPattern)
                {

                    Console.WriteLine("Make your own pattern");
                    try
                    {
                        Console.Write("How many colums want you make: ");
                        column = Convert.ToInt32(Console.ReadLine());
                        Console.Write("How many rows want you make: ");
                        row = Convert.ToInt32(Console.ReadLine());

                        
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
                            flagPattern = true;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Bad input. Please write a number");
                    }
                }
            }
        }
        
    }
}

