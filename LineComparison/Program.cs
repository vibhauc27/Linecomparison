using System;

namespace LineComparison
{
    class Program
    {
       static void Main(string[] args)
        {
            int x1, y1, x2, y2;
            double lengthOfPoints;
            Console.WriteLine("Enter the Co-ordinates of first point (x1,y1) : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second point (x2,y2) : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            lengthOfPoints = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("The Length of 2 points is : " + lengthOfPoints);

        }
    }
}