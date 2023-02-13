using System;
using System.Collections.Generic;

namespace ZooPark
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoopark zoopark = new Zoopark();
            zoopark.StartExcursion();            

        }
    }

    class Zoopark
    {
        private List<Aviary> _aviaries = new List<Aviary>();
        private AviaryCreater _aviaryCreater = new AviaryCreater();

        public Zoopark() 
        {
            int countAviares = 4;
            int countAnimals = 5;

            for (int i = 0; i < countAviares; i++)
            {
                _aviaries.Add(_aviaryCreater.Create(countAnimals));
            }
        }

        public void ShowAllAviary()
        {
            Console.WriteLine("Вальеры:");

            for (int i = 0; i < _aviaries.Count; i++)
            {
                int numberAviary = i + 1;
                Console.WriteLine($"{numberAviary} {_aviaries[i]._name}");

                //Aviary aviary = _aviaries[i];
                //aviary.ShowAviary();

            }
        }

        public void StartExcursion()
        {
            Zoopark zoopark = new Zoopark();

            const int CommandGoExcursion = 1;
            const int CommandExed = 2;

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"Добро пожаловать в Зоопар." +
                    "\nДля налало экскурии, выбирите вальер " +
                    ". Выход из зоопарка \"exit\"");
                zoopark.ShowAllAviary();
                Console.WriteLine();

                int userInput = ReadInt();

                switch (userInput)
                {
                    case CommandGoExcursion:
                        break;

                    case CommandExed:
                        isWork= false; 
                        break;
                }
            }
        }

        private static int ReadInt()
        {
            int result;

            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.WriteLine("Неверный ввод номера!");
                Console.Write("Повторите попытку");
            }

            return result;
        }
    }

    class Aviary
    {
        private List<Animal> _animals= new List<Animal>();

        public Aviary(string name,List<Animal> animals) 
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

    class Animal
    {
        public Animal(string name, string gender ,string description, string sound) 
        {
            Name= name;
            Gender= gender;
            Description= description;
            Voise= sound;
        }

        public string Name { get;private set; }
        public string Gender { get; private set; }
        public string Description { get; private set; }
        public string Voise { get; private set; }

        public void ShowStats()
        {
            Console.WriteLine($"Название животного - {Name}, пол животного - {Gender}\nХарактеристики - {Description}.\nИздаваемый звук - {Voise}");
        }
    }

    class AviaryCreater
    {
        private List<string> _names = new List<string>() 
        {
            "Большой",
            "Средний",
            "Маленький",
            "Крытый",
            "С бассейном"
        };
        private static Random random= new Random();
        
        public Aviary Create(int coutnAnimals)
        {
            List<Animal> aviary = new List<Animal>();
            string title = _names[random.Next(_names.Count)];

            for (int i = 0; i < coutnAnimals; i++)
            {
                List<Animal> animals= new List<Animal>();

                animals.Add(new Animal("Лев", "мужской", "кароль природы", "рык"));
                animals.Add(new Animal("Зебра", "женский", "белая в черную полоску", "никакого"));
                animals.Add(new Animal("Тигр", "мужской", "очень сильный", "мурчит"));
                animals.Add(new Animal("Воробей", "женский", "быстрый и веселый", "свирель"));
                animals.Add(new Animal("Рассмаха", "мужской", "маленький, но очень опасный", "очень страшный крик"));

                aviary.Add(animals[random.Next(animals.Count)]);
            }

            return new Aviary(title ,aviary);
        }
    }
}
