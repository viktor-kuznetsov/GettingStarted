using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStarted
{
    class Program
    {
        static void Main(string[] args)
        {
            Building house = new Building(2, 2500, 4);
            Building office = new Building(3, 4200, 25);

            int areaPPofHouse;

            /*
            house.occupants = 4;
            house.area = 2500;
            house.floors = 2;

            office.occupants = 25;
            office.area = 4200;
            office.floors = 3;
            */
            areaPPofHouse = house.AreaPerPerson();


            Console.WriteLine("house has:\n " + 
                            house.floors + " floors\n " +
                            house.occupants + " occupants\n " +
                            house.area + " total area\n " + 
                            areaPPofHouse + " total area\n" + 
                            house.MaxOccupant(150) + " max quantity of Occupants");
            //house.AreaPerPerson();

            //Console.ReadKey();

            ChkNum ob = new ChkNum();

            for (int i = 2; i < 10; i++)
                if (ob.IsPrime(i)) Console.WriteLine(i + " is a prime.");
                else Console.WriteLine(i + " is not prime.");


        }



    }

    class Building
    {
        public int floors;
        public int area;
        public int occupants;

        public Building(int f, int a, int o)
        {
            floors = f;
            area = a;
            occupants = o;
     }

        public int AreaPerPerson()
        {
            
            return area / occupants;
            
        }

        public int MaxOccupant(int minArea)
        {
            return area / minArea;
        }

    }

    class ChkNum
    {
        public bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= x / i; i++)
                if ((x % i) == 0) return false;

            return true;
        }
    }

}
