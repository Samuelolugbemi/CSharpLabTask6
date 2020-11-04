using System;

namespace PackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            OvernightPackage overnight = new OvernightPackage("James", "Stuart", "Ogun State","Hacob", "Brown","Ibadan", 5.0, 5000M, "OverNight Package");
            TwoDayPackage twoDay = new TwoDayPackage("Jeremy", "Stutgartt", "Oyo State","Hamman", "Bronze","Ota", 6.0, 4000M, "Two Day Package");
            Console.WriteLine("\n Packages processed polymorphically...\n");
            Package[] packages = new Package[2] { overnight, twoDay };

            foreach (Package package in packages)
            {
                Console.WriteLine($"{package}\nShipping Cost: {package.CalculateCost():C}\n");
            }
        }
    }
}
