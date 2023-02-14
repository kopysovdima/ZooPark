using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class Animal
    {
        public Animal(string name, string gender, string description, string sound)
        {
            Name = name;
            Gender = gender;
            Description = description;
            Voise = sound;
        }

        public string Name { get; private set; }
        public string Gender { get; private set; }
        public string Description { get; private set; }
        public string Voise { get; private set; }

        public void ShowStats()
        {
            Console.WriteLine($"Название животного - {Name}, пол животного - {Gender}\nХарактеристики - {Description}.\nИздаваемый звук - {Voise}");
        }
    }
}
