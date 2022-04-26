using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace DomRia
{
    class Client : Human
    {
        public Client()
        {
            flats = new List<Flat>();
            flat = new Flat();
        }
        public void SearchByRangePrice()
        {
            if (flats.Count == 0) Read();
            Console.WriteLine("1 - $");
            Console.WriteLine("2 - грн");
            Console.WriteLine("3 - $_2м");
            int chCurrency = int.Parse(Console.ReadLine());
            if (chCurrency <= 0 || chCurrency > 3) Console.WriteLine("Ошибка!");
            else
            {
                Console.WriteLine("Введите диапазон интересующей вас цены: ");
                Console.Write("От: ");
                int from = int.Parse(Console.ReadLine());
                Console.Write("До: ");
                int before = int.Parse(Console.ReadLine());
                List<Flat> rez = new List<Flat>();
                if (chCurrency == 1) rez = flats.FindAll(p => p.price.AmericanCurrency >= from && p.price.AmericanCurrency <= before);
                if (chCurrency == 2) rez = flats.FindAll(p => p.price.UkraineCurrency >= from && p.price.UkraineCurrency <= before);
                if (chCurrency == 3) rez = flats.FindAll(p => p.price.PricePerSquareMeter >= from && p.price.PricePerSquareMeter <= before);
                if (rez.Count == 0) Console.WriteLine("Пусто!");
                foreach (var i in rez)
                {
                    Console.WriteLine($"{i}");
                }
            }
        }
        public void SearchByFloor()
        {
            if (flats.Count == 0)
                Read();
            Console.WriteLine("Введите диапазон интересующего вас этажа: ");
            Console.Write("От: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int before = int.Parse(Console.ReadLine());
            var SearchByFloor = flats.FindAll(p => p.information_Flat.Floor >= from && p.information_Flat.Floor <= before);
            if (SearchByFloor.Count == 0) Console.WriteLine("Пусто!");
            foreach (var i in SearchByFloor)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void SearchBySquare()
        {
            if (flats.Count == 0)
                Read();
            Console.WriteLine("Введите диапазон интересующей вас общей площади: ");
            Console.Write("От: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("До: ");
            int before = int.Parse(Console.ReadLine());
            var searchByGeneralSquare = flats.FindAll(p => p.information_Flat.Quadrature >= from && p.information_Flat.Quadrature <= before);
            if (searchByGeneralSquare.Count == 0) Console.WriteLine("Пусто!");
            foreach (var i in searchByGeneralSquare)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void SearchByCountRooms()
        {
            if (flats.Count == 0)
                Read();
            Console.Write("Введите необходимое количество комнат: ");
            int countRooms = int.Parse(Console.ReadLine());
            var searchByCountRooms = flats.FindAll(p => p.information_Flat.CountRoom == countRooms);
            if (searchByCountRooms.Count == 0) Console.WriteLine("Пусто!");
            foreach (var i in searchByCountRooms)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void SortByAscendingPrice()
        {
            if (flats.Count == 0)
                Read();
            var sort = flats.OrderBy(p => p.price.AmericanCurrency);
            foreach (var i in sort)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void SortByDescendingPrice()
        {
            if (flats.Count == 0)
                Read();
            var sort = flats.OrderByDescending(p => p.price.AmericanCurrency);
            foreach (var i in sort)
            {
                Console.WriteLine($"{i}");
            }
        }
        public void SearchByCity()
        {
            if (flats.Count == 0)
                Read();
            Console.Write("Введите город: ");
            string city = Console.ReadLine();
            var searchByCity = flats.FindAll(p => p.location.City.Equals(city));
            if (searchByCity.Count == 0) Console.WriteLine("Пусто!");
            foreach (var i in searchByCity)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}
