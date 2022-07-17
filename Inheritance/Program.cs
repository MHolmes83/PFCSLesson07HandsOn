using System;
using static Inheritance.MemberSupplies;

namespace Inheritance
{
    public class Car : Vehicle
    {
        
        int trunkWidth;

        public Car(string make, string color, int fuelLevel, int trunkWidth) : base(make, color, fuelLevel)
        {
            
            this.trunkWidth = trunkWidth;
        }
    }

    public class Truck : Vehicle
    {
        
        int flatbedLength;

        public Truck(string make, string color, int fuelLevel, int flatbedLength) : base(make, color, fuelLevel)
        {
            
            this.flatbedLength = flatbedLength;
        }
    }

    public class Vehicle
    {
        string make;
        string color;
        bool isRunning = false;
        int fuelLevel;

        public Vehicle(string make, string color, int fuelLevel)
        {
            this.make = make;
            this.color = color;
            this.isRunning = false;
            this.fuelLevel = fuelLevel;
        }

        public void printDetails()
        {
            Console.WriteLine("The " + this.color + " " + this.make + " has a fuel level of " + this.fuelLevel + ". Is it running? " + this.isRunning);
        }

        public static void printVehicleColor(Vehicle v)
        {
            string vehicleColor = v.color;
            Console.WriteLine(vehicleColor);
        }
    }

    class MemberSupplies
    {
        public class Member
        {
            public string name;
            protected double baseSupplies;

            public Member(string name, double baseSupplies)
            {
                this.name = name;
                this.baseSupplies = baseSupplies;
            }

            public virtual double CalculateSupplies()
            {
                return baseSupplies;
            }
        }

        public class PremiumMember : Member
        {
            private double premiumSupplies;

            public PremiumMember(string name, double baseSupplies, double premiumSupplies) : base(name, baseSupplies)
            {
                this.premiumSupplies = premiumSupplies;
            }

            public override double CalculateSupplies()
            {
                return baseSupplies + premiumSupplies;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle newVehicle = new Vehicle("AcmeVehicle", "Gray", 5);
            newVehicle.printDetails();
            Vehicle.printVehicleColor(newVehicle);

            Car newCar = new Car("AcmeCar", "Black", 15, 10);
            newCar.printDetails();
            Vehicle.printVehicleColor(newCar);

            Truck newTruck = new Truck("AcmeTruck", "White", 25, 10);
            newTruck.printDetails();
            Vehicle.printVehicleColor(newTruck);

            PremiumMember member1 = new PremiumMember("Alice", 11200, 500);
            Member member2 = new Member("Bob", 11200);

            Console.WriteLine("Premium Member: " + member1.name + " paid " + member1.CalculateSupplies());

            Console.WriteLine("Member: " + member2.name + " paid " + member2.CalculateSupplies());
        }
    }
}