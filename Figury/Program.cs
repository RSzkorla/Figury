using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figury
{
  class Program
  {
    static private int dokladnosc = 2;
    static private List<Bryla> figury = new List<Bryla>();
    static void DodajFiguryDoListy()
    {
      figury.Add(new Kula());
      figury.Add(new Ostroslup());
    }
    static void Main(string[] args)
    {
      DodajFiguryDoListy();
      foreach(Bryla i in figury)
      {
        Console.WriteLine(i.Nazwa());
        i.WprowadzDane();
        Console.WriteLine($"Pole: {i.LiczPole(dokladnosc)}, Objętość: {i.LiczObjetosc(dokladnosc)}");

      }
    }
  }
}