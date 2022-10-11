using System;

namespace OOP_CodeAlong
{
  class Program
  {
    static void Main(string[] args)
    {
      // instantiating a new instance of the car class, calling it john and passing in 4 as an argument
      Car john = new Car(4);
      john.Drive();
    }
  }
  public class Vehicle
  {
    // setting Wheels as a property of the vehicle class, adding getter/setter so i can set the value later
    // i don't know if there's a difference in using getter/setter if all the classes/properties are public, i think you can just declare the variable and set in with assignment operator where you want to.
    public int Wheels { get; set;}
    public string Name { get; set; }
    // public int Wheels;
    // public string Name;
    // creating Drive method of the Vehicle class that prints a phrase
    public void Drive()
    {
      Console.WriteLine($"{Wheels} wheels are moving. Vroom Vroom!");
    }
  }

  // : is inheritance
  // so Car is inheriting properties of Vehicle
  // inheritance is the same as extending in javascript
  public class Car : Vehicle
  {
    // creates constructor to insantiate new instances of Car classes
    // takes in a parameter: an integer called wheels
    public Car(int wheels, string name)
    {
      // sets public property Wheels to whatever we pass into the Car constructor when we create new one
      Wheels = wheels;
    }
  }
}