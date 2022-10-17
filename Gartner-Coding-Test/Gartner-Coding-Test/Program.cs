using System;

namespace ConsoleApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (input != null && input.Length == 3)
                ImportProduct.importProductData(input[2]);
            else
                Console.WriteLine("Please enter correct input");
        }
    }

}
