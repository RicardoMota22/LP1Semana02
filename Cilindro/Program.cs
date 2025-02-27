using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insere altura: ");
            int aa = int.Parse(Console.ReadLine());

            double a = (double)aa; 
            
        
            //double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Insere raio: ");
            int rr = int.Parse(Console.ReadLine());

            //double r = double.Parse(Console.ReadLine());

            double r = (double)rr; 
            double V = Math.PI * Math.Pow(r, 2) * a; //Volume using Math.Pi 
            //and Math.Power
            double Vo = Math.Round(V, 3); //Rounds to 3 decimal places
            Console.WriteLine(Vo);

            double Sa = 2 * Math.PI * r * (r + a); //Surface area 
            double Sao = Math.Round(Sa, 3); //Rounds to 3 decimal places

            Console.WriteLine(Sao);
        
        }
    }
}
