using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
namespace DomRia
{
    class Menu
    {
        private Manager manager;
        private Client client;
        Action action = null;
        public Menu()
        {
            manager = new Manager();
            client = new Client();
        }
        public void MManager()
        {
            int ch;
            do
            {
                Console.WriteLine("\t\tМеню");
                Console.WriteLine("1 - Добавление объявления");
                Console.WriteLine("2 - Вывод всех объявлений");
                Console.WriteLine("3 - Удаление объявления");
                Console.WriteLine("0 - Выход");
                Console.Write("Сделайте свой выбор: ");
                ch = int.Parse(Console.ReadLine());
                if (ch == 0) break;
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        action = manager.Add;
                        action += manager.Save;
                        break;
                    case 2:
                        Console.Clear();
                        action = manager.ShowAll;
                        break;
                    case 3:
                        Console.Clear();
                        action = manager.RemoveAdvertisment;
                        break;
                }
                action?.Invoke();
                Console.Write("Нажмите любую кнопку, чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            } while (ch != 0);
        }
        public void MClient()
        {
            int ch;
            do
            {
                Console.WriteLine("\t\tМеню");
                Console.WriteLine("1 - Показ всех объявлений");
                Console.WriteLine("2 - Поиск по городу");
                Console.WriteLine("3 - Поиск по номеру телефона риелтoра");
                Console.WriteLine("4 - Сортировка объявлений по возрастанию цены");
                Console.WriteLine("5 - Сортировка объявлений по убыванию цены");
                Console.WriteLine("6 - Поиск в диапазоне цены");
                Console.WriteLine("7 - Поиск в диапазоне этажности");
                Console.WriteLine("8 - Поиск в диапазоне общей площади");
                Console.WriteLine("9 - Поиск по количеству комнат");
                Console.WriteLine("0 - Выход");
                Console.Write("Сделайте свой выбор: ");
                ch = int.Parse(Console.ReadLine());
                if (ch == 0) break;
                switch (ch)
                {
                    case 1:
                        Console.Clear();
                        action = client.ShowAll;
                        break;
                    case 2:
                        Console.Clear();
                        action = client.SearchByCity;
                        break;
                    case 3:
                        Console.Clear();
                        action = client.SortByAscendingPrice;
                        break;
                    case 4:
                        Console.Clear();
                        action = client.SortByDescendingPrice;
                        break;
                    case 5:
                        Console.Clear();
                        action = client.SearchByRangePrice;
                        break;
                    case 6:
                        Console.Clear();
                        action = client.SearchByFloor;
                        break;
                    case 7:
                        Console.Clear();
                        action = client.SearchBySquare;
                        break;
                    case 8:
                        Console.Clear();
                        action = client.SearchByCountRooms;
                        break;
                }
                action?.Invoke();
                Console.Write("Нажмите любую кнопку, чтобы продолжить...");
                Console.ReadKey();
                Console.Clear();
            } while (ch != 0);
        }
    }
}