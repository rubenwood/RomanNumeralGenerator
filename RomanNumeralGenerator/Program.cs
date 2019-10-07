using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumeralGenerator
{
    public class Program
    {        
        /// Main app BEGINS
        public static void Main()
        {
            string ans = ""; /// stores users answer when asked to run app again

            do
            {
                /// ask for user to input a number
                Console.WriteLine("Please input a number to convert to roman numerals: ");

                try /// try to handle input
                {
                    int input = Convert.ToInt32(Console.ReadLine()); /// input goes in as a string, so convert it to int
                    string numeral = generate(input); /// Call generate function here
                    Console.WriteLine("OUTPUT: " + numeral + "\n"); /// print output    
                }
                catch (Exception e) /// if input was not an int, handle exception
                {
                    Console.WriteLine("Please enter number!");
                }           

                /// ask if user wants to try again
                Console.WriteLine("Run app again? (Enter 'yes' or 'no')");
                ans = Console.ReadLine();
            } while (ans.ToLower().Trim() != "no");

        } /// Main app ENDS

        ///Generate function BEGINS
        public static string generate(int number)
        {
            string numeral = ""; /// output string

            /// Ensure number is between 1 and 3999
            if (number > 0 && number <= 3999)
            { 
                /// the following arrays store the Roman symbols for each unit... 
                string[] mSymbols = { "", "M", "MM", "MMM" }; /// ...thousands... (only need 3 M's becase max is 3999)
                string[] cSymbols = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" }; /// ...hundreds...
                string[] xSymbols = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" }; /// ...tens...
                string[] iSymbols = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" }; /// ...ones

                /// Here we find the corresponding symbol for our number
                /// this is based off simple calculation...
                string thousands = mSymbols[number / 1000];
                string hundreds = cSymbols[(number % 1000) / 100];
                string tens = xSymbols[(number % 100) / 10];
                string ones = iSymbols[(number % 10) / 1];

                /// concatenate all of this to our output string
                numeral = thousands + hundreds + tens + ones;
            }
            else
            {
                /// if the entered number is not between 1 and 3999, or is a different data type...
                Console.WriteLine("Please enter a number between 1 and 3999");
            }

            return numeral;

        }///Generate function ENDS
    }
}
