using System;

namespace ReverseNumber
{
    public class Program
    {
        public static void Main()
        {
            int num; //num is the number entered by the user.

            int reverse = 0;  //reverse is the reversed number ie. reverse of num.


            Console.WriteLine("Enter the number : ");
            num = int.Parse(Console.ReadLine());  //It is reading the number and storing that in num.


            //The while loop is used to reverse the number.
            //It keeps adding the rightmost digit of num to reverse.
            //Once the while loop ends, reverse holds the reversed value of num.

            while (num > 0)
            {
                reverse = reverse * 10 + num % 10;
                num = num / 10;
            }

            //Finally, it is printing the value of the reversed number i.e. reverse.
            Console.WriteLine("Reversed number : {0}", reverse);

        }
    }
}

//@FARUQESAY