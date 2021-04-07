using System;

namespace Area_Of_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if(type == "square")
            {
                double side = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(side * side, 3));
            }
            else if(type == "rectangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double sideB = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(sideA * sideB, 3));

            }
            else if(type == "circle")
            {

                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((Math.PI * (radius * radius)), 3));
            }
            else if(type == "triangle")
            {
                double sideA = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round((sideA * h)/2, 3));

            }
        }
    }
}
