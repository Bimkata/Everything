using System;

namespace Car
{
    class Program
    {
        public class Car
        {
            public string brand;
            public string model;
            public int engineVolume;
            public int yearProd;
        }
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.brand = "FlyingCar";
            myCar.model = "Mark1";
            myCar.engineVolume = 3000;
            myCar.yearProd = 2020;
            Console.Write(myCar.brand + "," + myCar.model +",");
            Console.WriteLine(myCar.engineVolume + "," + myCar.yearProd + ",");
            Console.ReadLine();
        }
    }
}
