using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere altura: ");
            
        
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insere raio: ");

            double r = double.Parse(Console.ReadLine());
            
        
            


            
            double V = Math.PI * (r * r) * a; //Volume
            Console.WriteLine(V);
        
        }
    }
}
