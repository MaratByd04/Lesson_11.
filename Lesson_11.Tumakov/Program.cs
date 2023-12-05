using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11.Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Домашнее задание 13.1 и 13.2\n");
            Console.ForegroundColor = ConsoleColor.White;

            BuildingCollection buildingCollection = new BuildingCollection();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Здание {i + 1} Подробности:");
                buildingCollection[i].PrintBuildingDetails();
                Console.WriteLine($"Высота этажа: {buildingCollection[i].CalculateFloorHeight():F2} метров");
                Console.WriteLine($"Квартир в подъезде: {buildingCollection[i].CalculateApartmentsPerEntrance()}");
                Console.WriteLine($"Квартир на этаже: {buildingCollection[i].CalculateApartmentsPerFloor()}");
                Console.WriteLine();
            }
        }
    }
}
