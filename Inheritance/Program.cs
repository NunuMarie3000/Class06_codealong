using System;

namespace Inheritance
{
  class Program
  {
    static void Main(string[] args)
    {
      Car batmobile = new Car(4, "The Batmobile");
      batmobile.DriveCar();
    }
  }

  class Vehicle
  {
    public int Wheels { get; set; }
    public string Name { get; set; }
    public void Drive()
    {
      Console.WriteLine($"My {Wheels} wheel car, {Name}, is now driving.");
    }
  }

  class Car : Vehicle
  {
    public Car(){}
    public Car(int wheels, string name)
    {
      Wheels = wheels;
      Name = name;
    }
    public void DriveCar()
    {
      Console.WriteLine("Step on the gas pedal");
      // base references the parent/base class, which is Vehicle
      // dot notation allows it to reference Drive
      base.Drive();
    }
  }
}
