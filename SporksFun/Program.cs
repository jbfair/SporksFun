using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SporksFun
{
    class Program
    {
        static void Main(string[] args)
        {
            int numRolls = 0;
            Console.WriteLine("Welcome to the dice thrower simulator!");

            Console.Write("How many times would you like to roll? ");
            numRolls = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("DICE ROLLING SIMULATION RESULTS Each '*' represents 1 % of the total number of rolls. Total number of rolls = " + numRolls + ".");
            Random r = new Random();

            
            int[] rollTotals = new int[13];
            int[] pctRolled = new int[13];
            double pct = 0.00;
            // simulate dice roll
            for (int i = 0; i < numRolls; i++)
            {
                
                int roll1 = r.Next(1, 7);
                int roll2 = r.Next(1, 7);
                int roll = roll1 + roll2;
                rollTotals[roll]++; 
            }
            // print results
            for (int i = 2; i < 13; i++)
            {
                pct = Math.Round(Convert.ToDouble(rollTotals[i] / Convert.ToDouble(numRolls) * 100),0);
                pctRolled[i] = Convert.ToInt32(pct);
                string stars = "";
                for (int x=0; x < pctRolled[i]; x++)
                {
                    stars += "*";
                }
                Console.WriteLine(i + ": " + stars);
                

            }
            Console.WriteLine("Thank you for using dice throwing simulator!");
            
        }
    }
}
