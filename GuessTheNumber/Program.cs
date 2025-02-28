using System;

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

            switch(aa)
            {
                
            }

            Console.WriteLine(numberToGuess);

            

        }
    }
}
