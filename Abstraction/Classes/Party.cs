using System;
using System.Collections.Generic; // how we create arrays, etc. being able to make collections
using System.Linq; // lets us reference info accross other pages
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Classes
{
  public abstract class Party
  {
    // abstract: modeling the relevent attributes and interactions of entities as classes to define an abstract representations of a system
    public abstract int MaxNumberOfGuests { get; set; }
    public abstract decimal Budget { get; set; }
    public abstract string Venue { get; set; }
    public string Theme { get; set; }
    public abstract void Setup();
    public abstract void TearDown();
  }
}