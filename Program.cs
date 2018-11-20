using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //input the string

            String input = "Hello, I like cats. Do you like cats? No? Are you sure? Why don't you like cats? Are you sure? I like you.";

            //Call the function
            Console.WriteLine(tripletsToString(input));
        }

        static String tripletsToString(String input) 
        {
            //There are some edge cases - no space before the first word, and no space after the last. I added these two things to take care of them.
            input = " " + input + " EOF";

            //Split the string by the punctuation.
            string[] parts = Regex.Split(input.Substring(0, input.Length - 1), @"(?<=[.,?])");
            
            //Setup a dictionary called tuplets that stores the tuplet and the count number (which is stored as a string)
            Dictionary<string, string> tuplets = new Dictionary<string, string>();

            //Loop through all the parts of the input.
            foreach (string part in parts)
            {
                //Identify the possible tuplet using substring by the spaces in the words
                string[] possibleTuplets = part.Substring(0, part.Length - 1).Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                
                //Loop through the identified possible tuplets
                for (int i = 0; i < possibleTuplets.Length - 1; i++, index++ ) 
                {
                        //store the currentTuplet
                        string currentTuplet = possibleTuplets[i].ToString() + " " + possibleTuplets[(i + 1)].ToString();

                        //Count the number of tuplets remaining
                        string numTuplets = (input.Split(new string[] {currentTuplet}, StringSplitOptions.RemoveEmptyEntries).Length -1).ToString();
                    
                        //Not ideal but try to add the tuplet, if you can't its already in the list and throws a caught exception 
                        try
                        {
                            tuplets.Add(currentTuplet.Substring(0, currentTuplet.Length), numTuplets);
                        }
                        catch (ArgumentException)
                        {
                            //Expected exceptions to be handled
                        }
                }

            }
            //Edge case of the end of the string not having a space after the period
            tuplets.Remove("EO");

            //Join the dictionary together to output as a string
            return string.Join(Environment.NewLine, tuplets);
        }
    }
}
