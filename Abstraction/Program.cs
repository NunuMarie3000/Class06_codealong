using System;
using Abstraction.Classes;

namespace Abstraction
{
  class Program
  {
    static void Main(string[] args)
    {
      // Console.BackgroundColor = ConsoleColor.Green;
      // Console.ForegroundColor = ConsoleColor.Magenta;
      Console.ResetColor();
      KidParty johnsParty = new KidParty();
      johnsParty.Setup();
      johnsParty.PlayGames();
      johnsParty.SingHappyBirthday();
      johnsParty.TearDown();
    }
  }
}
