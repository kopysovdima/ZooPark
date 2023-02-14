using System;
using System.Collections.Generic;

namespace ZooPark
{
    internal class Zoopark
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
            }
        }

        public void StartExcursion()
        {
            Zoopark zoopark = new Zoopark();

            const int CommandExed = 5;

            bool isWork = true;

            while (isWork)
            {
                Console.Clear();
                Console.WriteLine($"Добро пожаловать в Зоопар." +
                    "\nДля налало экскурии, выбирите вальер. " +
                    $"Для выхода из зоопарка нажмите {CommandExed}");
                zoopark.ShowAllAviary();
                Console.WriteLine();

                int userInput = ReadInt();

                if (userInput.Equals(CommandExed))
                {
                    isWork = false;
                }
                else if (userInput - 1 <= _aviaries.Count)
                {
                    _aviaries[userInput - 1].ShowAviary();
                }
                else
                {
                    Console.WriteLine("Неправильный ввод");
                }

                Console.ReadKey();
            }
        }

        private static int ReadInt()
        {
            int result;

            while (int.TryParse(Console.ReadLine(), out result) == false)
            {
                Console.Clear();
                Console.WriteLine("Не правильный ввод!");
                Console.Write("Повторите попытку");
            }

            return result;
        }
    }
}
