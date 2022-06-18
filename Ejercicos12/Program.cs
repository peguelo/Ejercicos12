using System;

namespace Ejercicos12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i;
            float ahorro, total = 0;
            i = 1;
            Console.WriteLine("Haorros total de un año");
            while (i <= 12)
            {
                Console.Write("\nIngresa el ahorro del mes: ");
                ahorro = Convert.ToInt32(Console.ReadLine());
                total = total + ahorro;
                Console.WriteLine("El haorro del mes: {0} es: ${1}", i, total);
                i++;
            }
            Console.WriteLine("\nEl ahorro total del año es: ${0}", total);
            Console.ReadKey();
        }
    }
}
