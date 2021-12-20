using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("ул. Суворова 2", 100000, 10, 15);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("ул. Кирова 15", -2, 12, 50, 16);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
