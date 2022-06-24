using OddEven.Model;
using System;

namespace OddEven
{
    class Program
    {
        static void Main(string[] args)
        {

            OddEvenGame numbers = new OddEvenGame();
            Console.WriteLine("Odd Numbers :");
            numbers.Odd();
            Console.WriteLine();
            Console.WriteLine("Even Numbers :");
            numbers.Even();
        }
    }
}
