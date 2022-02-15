using System;

namespace LineComparison
{
    class Program
    {
       static void Main(string[] args)
        {
            int x1, y1, x2, y2,x3,y3,x4,y4;
            double lengthOfFirstPoints, lengthOfSecondPoints;
            Console.WriteLine("Enter the Co-ordinates of first line 1st point (x1,y1) : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of first line 2nd point (x2,y2) : ");
            x2 = Convert.ToInt32(Console.ReadLine());
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second line 1st point (x3,y3) : ");
            x3 = Convert.ToInt32(Console.ReadLine());
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Co-ordinates of second line 2nd point (x4,y4) : ");
            x4 = Convert.ToInt32(Console.ReadLine());
            y4 = Convert.ToInt32(Console.ReadLine());

            lengthOfFirstPoints = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            lengthOfSecondPoints = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));

            //int status = lengthOfFirstPoints.CompareTo(lengthOfSecondPoints);
            if (lengthOfFirstPoints > 0)
            {
                Console.WriteLine("length of line 1 greater than length of line 2", lengthOfFirstPoints, lengthOfSecondPoints);
            }
            else if (lengthOfSecondPoints < 0)
            {
                Console.WriteLine("length of line 1 is lesser than length of line 2", lengthOfFirstPoints, lengthOfSecondPoints);
            }
            else
            {
                Console.WriteLine("length of line 1 is equal to length of line 2", lengthOfFirstPoints, lengthOfSecondPoints);
            }

        }
    }
}