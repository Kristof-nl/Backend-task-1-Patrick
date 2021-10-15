using System;

namespace Backend_task_1_Patrick
{
    class Program
    {
        static void Main(string[] args)
        {
            bool closeFlag = true;

            while(closeFlag)
            {

            }
            SayHello();
        }
        static void SayHello()
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName + "!!!");
        }
    }
}
