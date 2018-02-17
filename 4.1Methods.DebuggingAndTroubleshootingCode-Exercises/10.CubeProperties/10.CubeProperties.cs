using System;

namespace _10.CubeProperties
{
    class Program
    {
        static void Main()
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            switch (parameter)
            {
                case "face":
                    GetCubeLengthOfFaceDiagonals(side);
                    break;
                case "volume":
                    GetCubeVolume(side);
                    break;
                case "space":
                    GetCubeSpaceDiagonals(side);
                    break;
                case "area":
                    GetCubeArea(side);
                    break;
            }
        }
        static void GetCubeArea(double side)
        {
            double area = 6 * Math.Pow(side,2);
            Console.WriteLine($"{area:f2}");
        }

        static void GetCubeVolume(double side)
        {
            double volume = Math.Pow(side, 3);
            Console.WriteLine($"{volume:f2}");
        }

        static void GetCubeSpaceDiagonals (double side)
        {
            double spaceDiagonals = Math.Sqrt(3) * side;
            Console.WriteLine($"{spaceDiagonals:f2}");
        }
        static void GetCubeLengthOfFaceDiagonals(double side)
        {
            double lengthFaceDiagonals = Math.Sqrt(2) * side;
            Console.WriteLine($"{lengthFaceDiagonals:f2}");
        }
    }
}
