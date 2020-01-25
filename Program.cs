using System;

namespace CalcArea
{
    class MainClass
    {
        public static void CalcAreaCircle()
        {
            Console.WriteLine("Enter circle radius: ");
            int radius = int.Parse(Console.ReadLine());
            double areaCircle = Math.PI * radius * radius;
            Console.WriteLine("Area of circle equals {0:##.00}", areaCircle);
        }

        public static void CalcAreaRectangle(int sides)
        {
            Console.WriteLine("Enter length side A: ");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter length side B: ");
            int sideB = int.Parse(Console.ReadLine());
            if (sides == 2)
                Console.WriteLine("Rectangle Area equals {0:##.00}", (sideA * sideB));
            else
            {
                Console.WriteLine("Enter length side C: ");
                int sideC = int.Parse(Console.ReadLine());
                double p = (sideA + sideB + sideC) / 2;
                double rectArea = Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC));
                Console.WriteLine("Triangle Are equals {0}", rectArea);
                if ((sideA * sideA == sideB * sideB + sideC * sideC) ||
                    (sideB * sideB == sideA * sideA + sideC * sideC) ||
                    (sideC * sideC == sideA * sideA + sideB * sideB))
                    Console.WriteLine("The triangle is rectangular!");
            }
            
        }

        public static void CalcAreaTriangle(int sides)
        {
            CalcAreaRectangle(sides);
        }

        public static void UserInput()
        {
            Console.WriteLine("Enter the number of sides of the shape:\n " +
                "\t0 - circle\n" +
                "\t2 - rectangle\n" +
                "\t3 - triangle\n");
            var userInput = Console.ReadLine();
            int sides = int.Parse(userInput);
            if (sides == 0)
                CalcAreaCircle();
            else if (sides == 2)
                CalcAreaRectangle(sides);
            else if (sides == 3)
                CalcAreaTriangle(sides);
            else
            {
                Console.WriteLine("For this figure we don't have solution!\n " +
                    "Try again.\n" +
                    "-------------------------------------------------");
                UserInput();
            }
        }

        public static void Main(string[] args)
        {
            UserInput();
        }
    }
}
