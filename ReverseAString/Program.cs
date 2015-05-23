using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReverseAString
{
    class Program
    {
        static void Main()
        {
            // Let's print out a nice welcome message for our user.
            Console.WriteLine("Welcome to Josh's Sentence Reverser 4000!" + Environment.NewLine);

            // Ask the user for the string they would like reversed.
            Console.Write("Please enter the sentence you would like reversed: ");

            // Read the user input and store it in a variable.
            string originalString = Console.ReadLine();
            Console.Write("\n");

            // Create the loading bar mechanism. This calculation is nearly instant, this is just for practice.
            Console.Write("Thanks, give me a moment to process.");

            // How many periods do we want on our fake loading bar?
            int periodLimit = 6;

            for (int loopCounter = 0; loopCounter <= periodLimit; loopCounter++)
            {
                // Write a period for every loop up to and including the value of periodLimit.
                Console.Write(".");
                Thread.Sleep(250);
            }

            // This is done like this because the idea is to store the characters in reverse order
            // so when we loop back through later, the loop can start at one and just print the characters
            // in the proper order.
            int characterNumber = originalString.Length;

            // Here we create our array that we'll use to hold the characters.
            char[] characterArray = new char[characterNumber];

            // Now we'll initialize the loop counter for the original string. Lets call it originalCounter.
            int originalCounter = 0;

            // Lets populate the array we just created with our characters.
            foreach (char c in originalString)
            {
                characterArray[originalCounter] = c;
                
                // Incremenet the loop counter so it knows the loop has undergone an interation.
                originalCounter++;
            }

            // Initialize the reverseString variable which will hold our processed, reversed string.
            string reverseString = "";

            // Lets loop over the array to get our reversed string out.
            for (int loopCount = characterNumber - 1; loopCount >= 0; loopCount--)
            {
               reverseString = reverseString + characterArray[loopCount];
            }

            // Print out the results to the console.
            Console.Write("\n\n");
            Console.WriteLine("All done! Your sentence reversed is:");
            Console.Write("\n");
            Console.WriteLine(reverseString);

            // Pause the console so the user can read the information
            Console.WriteLine("\nThanks for using my program. Please press the Enter key to exit! :)");
            Console.ReadLine();
        }
    }
}