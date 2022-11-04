using System;
using System.Net.NetworkInformation;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating one integer number n to read the user input.
            int n;

            //Ask the user to enter a number.
            Console.WriteLine("Enter a number to check : ");

            //Read the number and store it in n.
            n = int.Parse(Console.ReadLine());


            //Using an if-else statement, check if the number is divisible by 2 or not.
            if (n % 2 == 0)
            {
                //If yes, print that the number is an even number.
                Console.WriteLine(n + " is an even number");
            }
            else
            {
                //Else, print that the number is an odd number.
                 Console.WriteLine(n + " is an odd number");
            }
        }
    }
}

//FARUQESAY