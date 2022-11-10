using System;
using AbstractClassAndInterface.AbstractClass;
using AbstractClassAndInterface.Interface;

namespace AbstractClassAndInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            double speed = 0.0;
            Car car1 = new Car();
            IVehicle truck1 = new Truck();

            Console.WriteLine("Enter car distance:");
            car1.Distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter car time in minutes:");
            car1.Time = Convert.ToDouble(Console.ReadLine());
            speed = car1.Speed();
            Console.WriteLine("Car speed is {0:0.00} :", speed);
            Console.WriteLine();

            Console.WriteLine("Enter truck distance:");
            truck1.Distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter truck time in minutes:");
            truck1.Time = Convert.ToDouble(Console.ReadLine());
            speed = truck1.Speed();
            Console.WriteLine("Truck speed is {0:0.00} :", speed);
            Console.Read();
        }
    }
}
