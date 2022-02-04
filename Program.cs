using System;
using DIO.src.entities;

namespace dotnet___poo
{
  class Program
  {
    static void Main(string[] args)
    {
      Knight arus = new Knight("Arus", 23, "Knight");
      Wizard wizard = new Wizard("Jenica", 20, "White Wizard");

      Console.WriteLine(arus.Attack());
      Console.WriteLine(wizard.Attack(1));
      Console.WriteLine(wizard.Attack(7));
    }
  }
}