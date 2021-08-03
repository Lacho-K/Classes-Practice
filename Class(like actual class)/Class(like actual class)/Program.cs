using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace SoftUniiii
{
    class Program
    {
        static double Dist(Point pa, Point pb)
        {
            double dist = Math.Sqrt(Math.Pow(pa.X - pb.X, 2) + Math.Pow(pa.Y - pb.Y, 2));
            return dist;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            Random rand = new Random();

            Point[] points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("x: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("y: ");
                int y = int.Parse(Console.ReadLine());
                points[i] = new Point(x, y);
                Console.WriteLine();
            }


            Console.WriteLine($"Random distance: {Dist(points[rand.Next(n)], points[rand.Next(n)]):F2}");


            double minDist = double.MaxValue;
            double maxDist = double.MinValue;
            int minDistIndexP1 = 0;
            int minDistIndexP2 = 0;
            int maxDistIndexP1 = 0;
            int maxDistIndexP2 = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }
                    double currentDist = Dist(points[i], points[j]);
                    if (currentDist < minDist)
                    {
                        minDist = currentDist;
                        minDistIndexP1 = i;
                        minDistIndexP2 = j;
                    }
                    else if(currentDist > maxDist)
                    {
                        maxDist = currentDist;
                        maxDistIndexP1 = i;
                        maxDistIndexP2 = j;
                    }
                }
            }
            Console.WriteLine($"Min distance = {minDist:F2}");
            Console.WriteLine($"Max distance = {maxDist:F2}");
            Console.WriteLine($"Coordinates that the min distance is between: p{minDistIndexP1+1}({points[minDistIndexP1].PrintCoordinates()}) and p{minDistIndexP2+1}({points[minDistIndexP2].PrintCoordinates()})");
            Console.WriteLine($"Coordinates that the max distance is between: p{maxDistIndexP1+1}({points[maxDistIndexP1].PrintCoordinates()}) and p{maxDistIndexP2+1}({points[maxDistIndexP2].PrintCoordinates()})");
        }
    }
}