using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {

            Console.WriteLine("Insere número inteiro: ");
            
        
            int i = int.Parse(Console.ReadLine()); 
            

            

        
            sbyte n = (sbyte)i;
        
            Console.WriteLine((--n));
            Console.WriteLine((++n));
        }
    }
}
