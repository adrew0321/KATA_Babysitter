using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KATA_Babysitter
{
    class Program
    {
        static void Main(string[] args)
        {
            string babySitterName;
            Family familyA = new Family("The Adams Family", 15);
            Family familyB = new Family("The Klumps Family", 12);
            Family familyC = new Family("The Miller Family", 21);
            string familySelection;

            

            Console.WriteLine("Welcome to the Baby-Sitter TimeSheet Tracker \n\nPlease provide your name below and lets begin...");
            babySitterName = Console.ReadLine();

            Console.WriteLine($"Thank You {babySitterName}, what family did you babysit today? (Choose from the list below)\n" +
                $"1) {familyA.Name}\n" +
                $"2) {familyB.Name}\n" +
                $"3) {familyC.Name}\n");

            //add loop
            familySelection = Console.ReadLine().ToString();
            if (familySelection == "1" || familySelection == familyA.Name)
            {
                familySelection = familyA.Name;
                Console.WriteLine($"You\'ve selected {familySelection}\n ");
            }
            else if (familySelection == "2" || familySelection == familyB.Name)
            {
                familySelection = familyB.Name;
                Console.WriteLine($"You\'ve selected {familySelection}\n ");
            }
            else if (familySelection == "3" || familySelection == familyC.Name)
            {
                familySelection = familyC.Name;
                Console.WriteLine($"You\'ve selected {familySelection}\n ");
            }
            else
                Console.WriteLine("Please try again...");

            Console.WriteLine($"What time did you clock in, {babySitterName}?");


            

       


        }

    }
}
