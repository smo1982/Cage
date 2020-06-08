using System;
using System.Collections.Generic;
using System.Text;

namespace Cage.models
{
    class Cage<T>
    {
        private List<T> list = new List<T>();

        public void AddAnimal(T animal)
        {
            list.Add(animal);
        }

        public void RemoveAnimal(T animal)
        {
            list.Remove(animal);
        }

        public void PrintAnimal()
        {
            foreach(T objekt in list)
            {
                Console.WriteLine(objekt);
            }
        }
    }
}
