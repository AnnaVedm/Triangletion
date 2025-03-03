using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangletion.Models
{
    internal class Data
    {
        public static List<Router> Routers = new List<Router>();

        public static Priemnik Priemnik = new Priemnik();

        //корень((x2 - x1)² + (y2 - y1)²)
        public static void CalculateDistance() //расстояние от роутера до приемника
        {
            foreach (var router in Routers)
            {
                router.Distance = Math.Sqrt(
                    Math.Pow((router.Coordinates.X - Priemnik.Coordinates.X), 2) + 
                    Math.Pow((router.Coordinates.Y - Priemnik.Coordinates.Y),2)
                    );
            }
        }
    }
}
