using System;
using System.Net;

namespace GuessTheNumber
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Random rnd = new Random();
            int numberToGuess = rnd.Next(31);
            
            Console.WriteLine("Insert number: ");
            int aa = int.Parse(Console.ReadLine());

            switch (response)
            {
                case (aa > numberToGuess);
                    response = "The hidden number is lower than"{aa}".Try again.";
                    break;
                
                case (aa < numberToGuess);
                    response = "The hidden number is higher than"{aa}".Try again.";
                    break;

                case (aa < 0);
                    response = "Numbers must be between 0 and 30.Try again.";
                    break;

                case (aa > 30);
                    response = "Numbers must be between 0 and 30.Try again.";
                    break;
                
                case (aa == numberToGuess);
                    response = "You have found the hidden number"+ {numberToGuess}+ "after" + {} +"tries.";
                    return;
            }

            

            

            Console.WriteLine(numberToGuess);

            

        }
    }
}
