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
            _name = name;
            _animals = animals;
        }

        public string _name { get; private set; }

        public void ShowAviary()
        {
            Console.WriteLine($"В {_name} вальере {_animals.Count}  животных");

            foreach (var animal in _animals)
            {
                animal.ShowStats();
            }

            Console.WriteLine();
        }
    }
}
