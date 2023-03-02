using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Aviary
    {
        private List<Animal> _animals = new List<Animal>();

        public Aviary(string name, List<Animal> animals)
        {
            Name = name;
            _animals = animals;
        }

        public string Name { get; private set; }

        public void ShowAviary()
        {
            Console.WriteLine($"В {Name} вальере {_animals.Count}  животных");

            foreach (var animal in _animals)
            {
                animal.ShowStats();
            }

            Console.WriteLine();
        }
    }
}
