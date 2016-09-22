using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            double grapesAcr = int.Parse(Console.ReadLine());
            double grapesForAcr = double.Parse(Console.ReadLine());
            double litters = double.Parse(Console.ReadLine());
            int workesrs = int.Parse(Console.ReadLine());

            double percent = 0.4;
            grapesAcr = grapesAcr * grapesForAcr;
            double wine = (grapesAcr * percent) / 2.5;

            if (wine >= litters)
            {
                double totalwine = Math.Ceiling(wine - litters);
                double diff = Math.Ceiling(totalwine / workesrs);
                Console.WriteLine("Good harvest this year! Total wine: {0} liters.", Math.Floor(wine));
                Console.WriteLine("{0} liters left -> {1} liters per person.", Math.Ceiling(totalwine), diff);
            }
            else
            {
                double totalwine = Math.Floor(litters - wine);
                Console.WriteLine("It will be a tough winter! More {0} liters wine needed.", totalwine);
            }
        }
    }
}
//Add a conflict and fix it