using Cage.models;
using System;

namespace Cage
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Monkey monkey = new Monkey("Aff");
            Tiger tiger = new Tiger("katz");
            Cage<Monkey> monkeyCage = new Cage<Monkey>();
            monkeyCage.AddAnimal(monkey);
            Cage<Tiger> tigerCage = new Cage<Tiger>();
            tigerCage.AddAnimal(tiger);
            monkeyCage.PrintAnimal();
            tigerCage.PrintAnimal();
            monkeyCage.RemoveAnimal(monkey);
            monkeyCage.PrintAnimal();
            tigerCage.PrintAnimal();
            Console.ReadKey();
        }
    }
}
