using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Program
  {
    static private int dokladnosc {get;set;}
    static private List<Bryla> figury = new List<Bryla>();
    static void DodajFiguryDoListy()
    {
      figury.Add(new Kula());
    }
    static void Main(string[] args)
    {
    }
  }
}