using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPVehicule
{
    class Program
    {
        class Vehicle
        {
            public static int nrVehicles = 0;
            public int doors;
            protected int speed;
            private string fuel = "not assigned";
            public string state = "functional";

            public Vehicle()
            {
                nrVehicles = nrVehicles + 1;
            }
            public virtual void SetFuel(string value)
            {
                fuel = value;
            }
            public void ConsoleFuel()
            {
                Console.WriteLine($"Fuel: {fuel}");
            }
            public string GetFuel()
            {
                return fuel;
            }
            public int GetNumberOfVehicles()
            {
                return nrVehicles;
            }
        }
        class Car: Vehicle
        {
            private int id;
            public string mark;
            
            public Car()
            {
                id = nrVehicles;
            }
            public void GetId()
            {
                if (mark != null)
                    Console.WriteLine($"Id of {mark} is: {id}");
                else
                    Console.WriteLine($"id of no name object: {id}");
            }
            public void SetSpeed(int value)
            {
                speed = value;
                GetSpeed();
            }
            public void SetSpeed()
            {
                speed = 0;
                Console.WriteLine("Speed is 0 (overloaded function)");
            }
            public void GetSpeed()
            {
                Console.WriteLine($"Speed: {speed} km/h (overloaded function)");
            }
        }
        class Plane: Vehicle
        {
            private int id;
            public string company;
            public Plane()
            {
                id = nrVehicles;
            }
            public void GetId()
            {
                if (company != null)
                    Console.WriteLine($"Id of {company} is: {id}");
                else
                    Console.WriteLine($"id of no name object: {id}");
            }
            public override void SetFuel(string value)
            {
                base.SetFuel(value);
            }
            public void SetSpeed(int value)
            {
                speed = value;
                Console.WriteLine($"Speed: {speed} km/h");
            }
        }
        class Truck: Vehicle
        {
            private int id;
            public Truck()
            {
                id = nrVehicles;
            }
            public void ChangeState()
            {
                if (state == "functional")
                    state = "non functional";
                else
                    state = "functional";
            }
            public void GetId()
            {
                Console.WriteLine($"Id of truck: {id}");
            }
        }
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle();
            vehicle.doors = 1;
            Console.WriteLine($"Vehicle object with {vehicle.doors} door(s) and {vehicle.state}\n");

            Car car = new Car();
            car.GetId();
            car.doors = 4;                                                                          //public property: doors
            car.mark = "Skoda";                                                                     //public property: mark
            Console.WriteLine($"Mark {car.mark}, {car.doors} door(s) and {vehicle.state}");         //default state from base class
            car.GetId();
            car.SetFuel("Petrol");                                                                  //function for private property: fuel
            car.ConsoleFuel();                                                                      //logs private property from base class: fuel
            car.SetSpeed();                                                                         //method for protected property from base class: speed
            car.SetSpeed(200);                                                                      //same method using overload

            Plane plane = new Plane();
            plane.doors = 1;
            plane.company = "airline plane";
            Console.WriteLine($"\nPlane {plane.company}, {plane.company} door(s)");
            plane.GetId();                                                                          //function for private member in subclass
            plane.SetFuel("cherosen");                                                              //overrid method from base class
            plane.ConsoleFuel();
            plane.SetSpeed(1000);

            Truck truck = new Truck();
            truck.doors = 2;
            Console.WriteLine($"Truck with {truck.doors} door(s) and {truck.state}");
            truck.GetId();
            truck.ChangeState();
            Console.WriteLine($"Truck new state: {truck.state}");

            Console.WriteLine($"\nTotal number of vehicles: {vehicle.GetNumberOfVehicles()}");      //method that counts STATIC (declared once and keep value and stored in momory) property from base that increments at every instance of a new object (in ctor)

            Console.ReadKey();
        }
    }
}
