using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            /*
            double x = double. PositiveInfinity ;
            double xi = double. NegativeInfinity ;
            Console.WriteLine(x);
            Console.WriteLine(xi);

            float y = float. PositiveInfinity ;
            float yi = float. NegativeInfinity ;
            Console.WriteLine(y);
            Console.WriteLine(yi);
            */

            //Valores Mìnimos e Máximos
            /*
            Console.WriteLine($"byte: Min = {byte.MinValue}, Max = {byte.MaxValue}");
            Console.WriteLine($"sbyte: Min = {sbyte.MinValue}, Max = {sbyte.MaxValue}");
            Console.WriteLine($"short: Min = {short.MinValue}, Max = {short.MaxValue}");
            Console.WriteLine($"ushort: Min = {ushort.MinValue}, Max = {ushort.MaxValue}");
            Console.WriteLine($"int: Min = {int.MinValue}, Max = {int.MaxValue}");
            Console.WriteLine($"uint: Min = {uint.MinValue}, Max = {uint.MaxValue}");
            Console.WriteLine($"long: Min = {long.MinValue}, Max = {long.MaxValue}");
            Console.WriteLine($"ulong: Min = {ulong.MinValue}, Max = {ulong.MaxValue}");
            Console.WriteLine($"float: Min = {float.MinValue}, Max = {float.MaxValue}");
            Console.WriteLine($"double: Min = {double.MinValue}, Max = {double.MaxValue}");
            Console.WriteLine($"decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");
            */
            
            sbyte sb1 = sbyte.MaxValue;
            sbyte sb2 = sbyte.MinValue;
            Console.WriteLine(sb1);
            Console.WriteLine(sb2);

            byte b1 = byte.MaxValue;
            byte b2 = byte.MinValue;
            Console.WriteLine(b1);
            Console.WriteLine(b2);
            
            double db1 = double.MaxValue;
            double db2 = double.MinValue;
            Console.WriteLine(db1);
            Console.WriteLine(db2);

            ulong ul1 = ulong.MaxValue;
            ulong ul2 = ulong.MinValue;
            Console.WriteLine(ul1);
            Console.WriteLine(ul2);

            long l1 = long.MaxValue;
            long l2 = long.MinValue;
            Console.WriteLine(l1);
            Console.WriteLine(l2);

            ushort us1 = ushort.MaxValue;
            ushort us2 = ushort.MinValue;
            Console.WriteLine(us1);
            Console.WriteLine(us2);

            short s1 = short.MaxValue;
            short s2 = short.MinValue;
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            int i1 = int.MaxValue;
            int i2 = int.MinValue;
            Console.WriteLine(i1);
            Console.WriteLine(i2);

            uint ui1 = uint.MaxValue;
            uint ui2 = uint.MinValue;
            Console.WriteLine(ui1);
            Console.WriteLine(ui2);

            
            
            
            
            double z= double. PositiveInfinity / double. PositiveInfinity;//NaN
            float z1= float.NaN;//Direct
            Console.WriteLine(z);
            Console.WriteLine(z1); 


            //Exercicio 7 
        }
    }
}
