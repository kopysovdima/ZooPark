using System;
using System.Collections.Generic;

namespace ZooPark
{
    internal class AviaryCreater
    {
        private List<string> _names = new List<string>()
        {
            "Большой",
            "Средний",
            "Маленький",
            "Крытый",
            "С бассейном"
        };
        private static Random random = new Random();

        public Aviary Create(int coutnAnimals)
        {
            List<Animal> aviary = new List<Animal>();
            string title = _names[random.Next(_names.Count)];

            for (int i = 0; i < coutnAnimals; i++)
            {
                List<Animal> animals = new List<Animal>();

                animals.Add(new Animal("Лев", "мужской", "кароль природы", "рык"));
                animals.Add(new Animal("Зебра", "женский", "белая в черную полоску", "никакого"));
                animals.Add(new Animal("Тигр", "мужской", "очень сильный", "мурчит"));
                animals.Add(new Animal("Воробей", "женский", "быстрый и веселый", "свирель"));
                animals.Add(new Animal("Рассмаха", "мужской", "маленький, но очень опасный", "очень страшный крик"));

                aviary.Add(animals[random.Next(animals.Count)]);
            }

            return new Aviary(title, aviary);
        }
    }
}
