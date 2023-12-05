using System;

namespace Lesson_11.Tumakov
{
    public class Building
    {
        public int BuildingNumber { get; private set; }
        public int height { get; set; }
        public int Floors { get; set; }
        public int Apartments { get; set; }
        public int Entrances { get; set; }

        public Building()
        {
            BuildingNumber = GenerateBuildingNumber();
        }

        private static int lastBuildingNumber = 0;

        private static int GenerateBuildingNumber()
        {
            return ++lastBuildingNumber;
        }

        public void PrintBuildingDetails()
        {
            Console.WriteLine($"Номер здания: {BuildingNumber}");
            Console.WriteLine($"Высота: {height} метров");
            Console.WriteLine($"Этажи: {Floors}");
            Console.WriteLine($"Квартиры: {Apartments}");
            Console.WriteLine($"Подъезды: {Entrances}");
        }

        public double CalculateFloorHeight()
        {
            return (double)height / Floors;
        }

        public int CalculateApartmentsPerEntrance()
        {
            return Apartments / Entrances;
        }

        public int CalculateApartmentsPerFloor()
        {
            return Apartments / Floors;
        }
    }

    public class BuildingCollection
    {
        private Building[] buildings;

        public BuildingCollection()
        {
            buildings = new Building[10];

            Random random = new Random();
            for (int i = 0; i < buildings.Length; i++)
            {
                buildings[i] = new Building
                {
                    height = random.Next(50, 200),
                    Floors = random.Next(5, 20),
                    Apartments = random.Next(20, 100),
                    Entrances = random.Next(1, 5)
                };
            }
        }

        public Building this[int index]
        {
            get
            {
                if (index >= 0 && index < buildings.Length)
                {
                    return buildings[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Нет такого индекса.");
                }
            }
        }
    }
}

