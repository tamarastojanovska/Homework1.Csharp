using System;

namespace Homework1.Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //# Class 2 Homework 📒
            //## Task 1
            //Create new console application “RealCalculator” that takes two numbers from the input and asks what operation would the user want to be done( +, - , * , / ). Then it returns the result.


            Console.WriteLine("Please enter the first number");
            string userInput1 = Console.ReadLine();
            Console.WriteLine("Please enter the second number");
            string userInput2 = Console.ReadLine();
            Console.WriteLine("Please enter the operation");
            string userInput3 = Console.ReadLine();

            int user1IntTryParse;
            int user2IntTryParse;
            int user3IntTryParse;
            bool isValidFirstNumber = int.TryParse(userInput1, out user1);
            bool isValidSecondNumber = int.TryParse(userInput2, out user2;
            bool isValidoperationNumber = int.TryParse(userInput3, out user3);

            if (num3 == ("+")
          return = (userInput1 + userInput2);

            else if (userInput3 == "-")
                return= (userInput1 - userInput2);

            else if (num3 == "*")
                return = (userInput1 * userInput2);

            else if (num3 == "/")
                return (userInput1 / userInput2);

        }
    }
}
