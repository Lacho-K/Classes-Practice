using System;
using System.Collections.Generic;
using System.Linq;
namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split();
                cars[i] = new Car(carInfo[0], new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2])), new Cargo(carInfo[4], int.Parse(carInfo[3])), new List<Tyre> { new Tyre(double.Parse(carInfo[5]), int.Parse(carInfo[6])), new Tyre(double.Parse(carInfo[7]), int.Parse(carInfo[8])), new Tyre(double.Parse(carInfo[9]), int.Parse(carInfo[10])), new Tyre(double.Parse(carInfo[11]), int.Parse(carInfo[12])) });
            }
            string cargoTarget = Console.ReadLine();
            if(cargoTarget == "fragile")
            {
                cars.Where(c => c.cargo.type == "fragile" && c.tires.Any(t => t.pressure < 1)).ToList().ForEach(c => Console.WriteLine(c.model));
            }
            else if(cargoTarget == "flamable")
            {
                cars.Where(c => c.engine.power > 250 && c.cargo.type == "flamable").ToList().ForEach(c => Console.WriteLine(c.model));
            }
        }
    }
}
