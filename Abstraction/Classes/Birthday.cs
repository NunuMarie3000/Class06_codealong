using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
  // abstract is method signature and required to override
  // if you're gonna override something, you needs to be abstract first
  // abstract and override work together
  public abstract class Birthday : Party
  {
    // why do we have to { get; set; } here??? we already did it in the Party class
    public override int MaxNumberOfGuests { get; set; } = 100;
    public override decimal Budget { get; set; } = 1000.00m;
    public abstract int Age { get; set; }
    public abstract string[] Presents { get; set; }
    public abstract void PlayGames();
    public abstract void OpenPresents(string[] presents);
    // virtual means it's optional, it doesn't have to be implemented
    // may be implemented, not necessary
    public virtual void SingHappyBirthday()
      {
        Console.WriteLine("*singing Happy Birthday song*");
      }
  }
}