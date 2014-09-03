using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceThrower1000
{
    class Program
    {
        static void Main(string[] args)
        {
            DiceThrower("10d6");
            DiceThrower("3d20");
            DiceThrower("100d6");
        }

        static void DiceThrower(string input)
        {
            //Make the string into a list 
            List<string> die = new List<string>();
            //splitting the input at the d
            die = input.Split('d').ToList();

            //Extra Credit
            //declare a variable for the total number rolled each time 
            int total = 0;

            //create a random generator
            Random rng = new Random();

            //print the input to the console
            Console.WriteLine("Throwing: " + input);
            Console.WriteLine("Results ");
            //create a loop to get the random numbers for each roll
            for (int i = 1; i <= int.Parse(die[0]); i++)
            {
                //determine how many times to roll each die
                int roll = rng.Next(1, int.Parse(die[1])+1);
                Console.Write(roll +" ");

                //Extra Credit
                //add the number rolled to the total after each roll 
                total = total + roll;

           }

            //Extra credit
            //Print the average by dividing the total by the number of rolls
            Console.WriteLine("\nAverage: " + total / int.Parse(die[0]));

            //print the output with spaces between each die/rolls
            Console.WriteLine("\n\n");

        }
    }
}
