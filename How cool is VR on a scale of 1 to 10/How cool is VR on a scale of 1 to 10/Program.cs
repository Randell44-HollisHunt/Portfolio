using System;

namespace AskUserValueGreaterOrLessThan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Simple program that receives a value and then gives a response based on the number range it falls within.  
            Console.WriteLine("On a scale of 1 to 10 how cool is VR?");

            string line = Console.ReadLine();

            double value;  // Was going to use an int but realized someone using a decimal would quickly break this and so opted for a double instead.
            double.TryParse(line, out value);

            if (value < 10.0 && value >= 7.0)
            {
                Console.WriteLine("You really like VR.  I agree, it's pretty cool.");
            }
            else if (value < 7.0 && value >= 5.0)
            {
                Console.WriteLine("A realistic view of current VR.  Great potential but many problems to solve just yet.");
            }
            else if (value < 5.0 && value >= 1.0)
            {
                Console.WriteLine("Awww, no excitement at all?  Everyone is interested in different things I guess.");
            }
            else
            {
                Console.WriteLine("This isn't a number between 1 and 10.");
            }


            Console.ReadLine();
        }


    }
}
