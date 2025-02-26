using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere número inteiro não negativo: ");
            
        
            int i = int.Parse(Console.ReadLine()); 


            byte n = (byte)i;
            
            Console.WriteLine(n/2); //divides by 2
            Console.WriteLine(n << 3); //shift left binary by 3
            Console.WriteLine(n ^ 6); //XOR with 6
            Console.WriteLine(n > 10); //if greater than 10

        }
    }
}
