using System;

namespace ConsoleTestGit
{
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("You work with git!");
            Operation operation = new Operation();
            Console.WriteLine($"Сумма (21, 32) =  {operation.Sum(21, 32)}");


        }
    }
}
