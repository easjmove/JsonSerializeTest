using JsonSerializeTest.Models;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace JsonSerializeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //SerializeCar();
            CreateCarDealerShip();
        }

        public static void SerializeCar()
        {
            Car myCar = new Car() { Brand = "BMW", Model = "330e", Color = "Green", Mileage = 45721 };
            Console.WriteLine(myCar.ToString());
            string serializedCar = JsonSerializer.Serialize(myCar);
            Console.WriteLine("{\"Brand\":\"BMW\",\"Model\":\"330e\",\"Color\":\"Green\",\"Mileage\":45721}");
            Console.WriteLine(serializedCar);

            Car deCar = JsonSerializer.Deserialize<Car>(serializedCar);
        }

        public static void CreateCarDealerShip()
        {
            CarDealership myDealerShip = new CarDealership() { Name = "Move Cars", Address = "MagleGårdsvej 2" };
            List<string> moveJobAreas = new List<string>() {"President","Mechanic" };
            List<string> notMoveJobAread = new List<string>() { "Vice-President", "Mechanic" };
            Employee move = new Employee() { Name = "Move", MonthsEmployed = 28, Salary = 1000000, JobAreas = moveJobAreas };
            Employee notMove = new Employee() { Name = "Not Move", MonthsEmployed = 13, Salary = 100, JobAreas = notMoveJobAread };

            myDealerShip.Employees.Add(move);
            myDealerShip.Employees.Add(notMove);

            Car bmwCar = new Car() { Brand = "BMW", Model = "330e", Color = "Green", Mileage = 45721 };
            Car vwCar = new Car() { Brand = "VW", Model = "Golf", Color = "Red", Mileage = 20 };
            Car fordCar = new Car() { Brand = "Ford", Model = "Galaxy", Color = "Black", Mileage = 124326 };

            myDealerShip.Cars.Add(bmwCar);
            myDealerShip.Cars.Add(vwCar);
            myDealerShip.Cars.Add(fordCar);

            Console.WriteLine(JsonSerializer.Serialize(myDealerShip));
        }
    }
}
